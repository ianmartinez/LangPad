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
        public string ProgramVersion { get; set; } = "";
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
            ProgramVersion = KeyValue.Search(dataLines, "ProgramVersion");

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

        }
    }
}
