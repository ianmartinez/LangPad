using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace LangPadData.NotebookNT;

/// <summary>
/// A notebook in the NT 1.x-2.x file format (*.nt).
/// </summary>
public class NotebookNT
{
    /// <summary>
    /// The version of the NT file format that this
    /// class saves in.
    /// </summary>
    public const double SPEC_VERSION = 2.2;

    /// <summary>
    /// If the notebook has been modified since
    /// last open/saveS.
    /// </summary>
    public bool Modified { get; set; } = false;

    /// <summary>
    /// The path to the file on the disk.
    /// </summary>
    public string DocumentPath { get; set; } = "";

    /// <summary>
    /// The version of NT file format that this
    /// file was opened as.
    /// </summary>
    public double NtSpecVersion { get; set; } = SPEC_VERSION;

    /// <summary>
    /// The title of the notebook.
    /// </summary>
    public string Title { get; set; } = "";

    /// <summary>
    /// The language the notebook is associated
    /// with.
    /// </summary>
    public string Language { get; set; } = "";

    /// <summary>
    /// The notebook's author.
    /// </summary>
    public string Author { get; set; } = "";

    /// <summary>
    /// A website associated with the notebook.
    /// </summary>
    public string Website { get; set; } = "";

    /// <summary>
    /// A list of custom characters stored in the file.
    /// </summary>
    public List<string> Characters { get; set; } = [];

    /// <summary>
    /// The notebook's info text.
    /// </summary>
    public string Info { get; set; } = "";

    /// <summary>
    /// A list of pages in the notebook.
    /// </summary>
    public List<PageNT> Pages { get; set; } = [];

    /// <summary>
    /// A list of words in the notebook.
    /// </summary>
    public DictionaryNT Dictionary = new();

    /// <summary>
    /// Open a notebook file into this instance of NotebookNT.
    /// </summary>
    /// 
    /// <param name="filePath">The path of the notebook file.</param>
    public void Open(string filePath)
    {
        var tempFolder = new TempFolderNT(false);

        // Extract to temp folder
        ZipFile.ExtractToDirectory(filePath, tempFolder.RootFolder);

        // The lines in the data.txt file
        var dataLines = KeyValue.ReadFile(tempFolder.DataFile);

        // Check the version of the notebook format so that we can
        // adjust the loading to support older formats
        var ntVersionStr = KeyValue.Search(dataLines, "NTVersion");

        // Versions prior to NT 1.2 didn't actually declare their spec version,
        // so a lookup will fail
        if (string.IsNullOrEmpty(ntVersionStr))
        {
            NtSpecVersion = 1;
        }
        else
        {
            if (double.TryParse(ntVersionStr, out double parsedNtVersion))
            {
                NtSpecVersion = parsedNtVersion;
            }
        }

        // Reset pages
        Pages = [];

        // Load pages
        if (NtSpecVersion < 2) // Use legacy page store method
        {
            var pageList = KeyValue.Search(dataLines, "Page Order").Split(["|"], StringSplitOptions.RemoveEmptyEntries);
            foreach (var pageTitle in pageList)
            {
                var newPage = new PageNT
                {
                    Title = pageTitle,
                    Rtf = File.ReadAllText(tempFolder.GetPagePath(pageTitle))
                };

                Pages.Add(newPage);
            }
        }
        else // Use the new method of storing pages that allows for arbitrary names
        {
            var pageCount = Directory.EnumerateFiles(tempFolder.PagesFolder).Count();
            for (var i = 0; i < pageCount; i++)
            {
                var pageTitle = KeyValue.Search(dataLines, $"Page{i}");
                var newPage = new PageNT
                {
                    Title = string.IsNullOrEmpty(pageTitle) ? $"Page {i + 1}" : pageTitle,
                    Rtf = File.ReadAllText(tempFolder.GetPagePath(i))
                };

                Pages.Add(newPage);
            }
        }

        // Load notebook info
        Title = KeyValue.Search(dataLines, "Title");
        Language = KeyValue.Search(dataLines, "Language");
        Author = KeyValue.Search(dataLines, "Author");
        Website = KeyValue.Search(dataLines, "Website");

        // Load file characters

        // The first release of the notebook format lacked embedded
        // custom symbols, so check if they exist before trying to
        // load them
        if (File.Exists(tempFolder.CharactersFile))
            Characters = [.. Lines.Get(File.ReadAllText(tempFolder.CharactersFile))];

        // === Load dictionary ===
        // Reset dictionary
        Dictionary = new DictionaryNT();

        // Some older versions (4.0-5.3) lacked a dictionary, so check 
        // if it exists before trying to load it
        if (File.Exists(tempFolder.DictionaryFile))
            Dictionary.Open(tempFolder.DictionaryFile);

        // 4.0 also lacks an info.txt, so check for that too
        if (File.Exists(tempFolder.InfoFile))
            Info = File.ReadAllText(tempFolder.InfoFile);

        Modified = false;
        DocumentPath = filePath;
    }

    /// <summary>
    /// Save this notebook to a file.
    /// </summary>
    /// 
    /// <param name="filePath">The file to save the notebook to.</param>
    public void Save(string filePath)
    {
        var tempFolder = new TempFolderNT(true);

        // Create data.txt KeyValues
        List<KvLine> dataFileLines = [
              new(KvLineType.Comment, "LangPad Notebook Info"),
              new(KvLineType.KeyValue, "Title", Title),
              new(KvLineType.KeyValue, "Language", Language),
              new(KvLineType.KeyValue, "Author", Author),
              new(KvLineType.KeyValue, "Website", Website),
              new(KvLineType.KeyValue, "NTVersion", SPEC_VERSION.ToString()),
              new(KvLineType.Blank),
              new(KvLineType.Comment, "Pages")
          ];

        // Add each page's data to data.txt
        for (var i = 0; i < Pages.Count; i++)
        {
            var page = Pages[i];
            // Add page title data in data.txt
            dataFileLines.Add(new KvLine(KvLineType.KeyValue, $"Page{i}", KeyValue.FormatString(page.Title)));
            // Add page file to the pages folder
            File.WriteAllText(tempFolder.GetPagePath(i), page.Rtf);
        }

        // Write data.txt, info.txt, and custom_symbols.txt
        // to the disk
        KeyValue.WriteFile(tempFolder.DataFile, dataFileLines);
        File.WriteAllText(tempFolder.InfoFile, Info);
        File.WriteAllText(tempFolder.CharactersFile, string.Join("\n", Characters));

        // Write dictionary to the disk
        Dictionary.Save(tempFolder.DictionaryFile);

        // Delete old file at filePath if we're saving over it
        if (File.Exists(filePath))
            File.Delete(filePath);

        // Create ZIP file containing the temp folder's contents at filePath
        ZipFile.CreateFromDirectory(tempFolder.RootFolder, filePath, CompressionLevel.Fastest, false);

        // Delete temp directory
        Directory.Delete(tempFolder.RootFolder, true);

        // Reset modified flag now that file has saved
        Modified = false;
    }
}