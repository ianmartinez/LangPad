using System;
using System.Collections.Generic;
using System.Text;

namespace LangPadData.NotebookNT
{
    public class WordNT : IComparable<WordNT>, IComparer<WordNT>
    {
        public string Word { get; set; } = "";
        public string Pronunciation { get; set; } = "";
        public string Definition { get; set; } = "";
        public string Notes { get; set; } = "";

        public int Compare(WordNT x, WordNT y)
        {
            return x.CompareTo(y);
        }

        public int CompareTo(WordNT other)
        {
            return Word.CompareTo(other.Word);
        }
    }
}
