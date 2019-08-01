using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookFile
{
    /* 
        Serialize as:
        0.word
        0.pronunciation
        0.definition
        0.notes=         */
    public class DictionaryWord
    {
        public string Word { get; set; } = "";
        public string Pronunciation { get; set; } = "";
        public string Definition { get; set; } = "";
        public string Notes { get; set; } = "";
    }

    public class Dictionary
    {
        public List<DictionaryWord> Words { get; set; } = new List<DictionaryWord>();

        public void Open(string fileName)
        {

        }

        public void Save(string fileName)
        {

        }
    }
}
