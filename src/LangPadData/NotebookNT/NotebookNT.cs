using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LangPadData.NotebookNT
{
    public class NotebookNT
    {
        public const double NT_VERSION = 2.1;

        // File data
        public bool Modfied { get; set; } = false;
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
            Pages = new List<Page>();

            // Load pages
            if (NtSpecVersion < 2) // Use legacy page store method
            {
                var pageList = KeyValue.Search(dataLines, "Page Order").Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                foreach(var pageTitle in pageList)
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

            }

        }

        public void Save(string filePath)
        {

        }
    }
}
