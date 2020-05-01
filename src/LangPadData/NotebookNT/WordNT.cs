using System;
using System.Collections.Generic;

namespace LangPadData.NotebookNT
{
    /// <summary>
    /// A word definition in the dictionary in the NT 1.x-2.x file format (*.nt).
    /// </summary>
    public class WordNT : IComparable<WordNT>, IComparer<WordNT>
    {
        /// <summary>
        /// The word, in the original language.
        /// </summary>
        public string Word { get; set; } = "";

        /// <summary>
        /// The word's pronunciation.
        /// </summary>
        public string Pronunciation { get; set; } = "";

        /// <summary>
        /// The word's definition.
        /// </summary>
        public string Definition { get; set; } = "";

        /// <summary>
        /// Notes associated with the word.
        /// </summary>
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
