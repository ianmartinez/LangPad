using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace LangPadData.NotebookNT
{
    public class NotebookNT
    {
        public const double NT_VERSION = 2.1;

        // File data
        public bool Modified { get; set; } = false;
        public string DocumentPath { get; set; } = "";
        public double NtSpecVersion { get; set; }

        // Notebook info
        public string Title { get; set; } = "";
        public string Language { get; set; } = "";
        public string Author { get; set; } = "";
        public string Website { get; set; } = "";
        public string CustomSymbols { get; set; } = "";
        public string Info { get; set; } = "";

        // Pages
        public List<PageNT> Pages { get; set; } = new List<PageNT>();

        // Dictionary
        public DictionaryNT Dictionary = new DictionaryNT();


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
                    NtSpecVersion = parsedNtVersion;
            }

            // Reset pages
            Pages = new List<PageNT>();

            // Load pages
            if (NtSpecVersion < 2) // Use legacy page store method
            {
                var pageList = KeyValue.Search(dataLines, "Page Order").Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
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
                    var pageTitle = KeyValue.Search(dataLines, "Page" + i);
                    var newPage = new PageNT
                    {
                        Title = string.IsNullOrEmpty(pageTitle) ? "Page " + (i + 1) : pageTitle,
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
            if (File.Exists(tempFolder.CustomSymbolsFile))
                CustomSymbols = File.ReadAllText(tempFolder.CustomSymbolsFile);

            // Load dictionary

            // Reset dictionary
            Dictionary = new DictionaryNT();

            // Some older versions (4.0-5.3) lacked a dictionary, so check 
            // if it exists before trying to load it
            if (File.Exists(tempFolder.DictionaryFile))
                Dictionary.Open(tempFolder.DictionaryFile);

            Modified = false;
            DocumentPath = filePath;
        }

        public void Save(string filePath)
        {
            var tempFolder = new TempFolderNT(true);

            // Create data.txt KeyValues
            var dataFileLines = new List<KvLine>
            {
                new KvLine(KvLineType.Comment, "LangPad Notebook Info"),
                new KvLine(KvLineType.KeyValue, "Title", Title),
                new KvLine(KvLineType.KeyValue, "Language", Language),
                new KvLine(KvLineType.KeyValue, "Author", Author),
                new KvLine(KvLineType.KeyValue, "Website", Website),
                new KvLine(KvLineType.KeyValue, "NTVersion", NT_VERSION.ToString()),
                new KvLine(KvLineType.Blank),
                new KvLine(KvLineType.Comment, "Pages")
            };

            // Add each page's data to data.txt
            for (var i = 0; i < Pages.Count; i++)
            {
                var page = Pages[i];
                // Add page title data in data.txt
                dataFileLines.Add(new KvLine(KvLineType.KeyValue, "Page" + i, KeyValue.FormatString(page.Title)));
                // Add page file to the pages folder
                File.WriteAllText(tempFolder.GetPagePath(i), page.Rtf);
            }

            // Write data.txt, info.txt, and custom_symbols.txt
            // to the disk
            KeyValue.WriteFile(tempFolder.DataFile, dataFileLines);
            File.WriteAllText(tempFolder.InfoFile, Info);
            File.WriteAllText(tempFolder.CustomSymbolsFile, CustomSymbols);

            // Write dictionary to the disk
            Dictionary.Save(tempFolder.DictionaryFile);

            // Create zip file containing the temp folder's contents
            ZipFile.CreateFromDirectory(tempFolder.RootFolder, filePath, CompressionLevel.Fastest, false);
        }
    }
}