using System;
using System.Collections.Generic;
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
        public decimal NtSpecVersion { get; set; }

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
        public DictionaryNT dictionary = new DictionaryNT();

        public void Save(string filePath)
        {

        }

        public void Open(string filePath)
        {

        }
    }
}
