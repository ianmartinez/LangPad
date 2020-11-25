using System.Collections.Generic;
using static LangPadData.KeyValue;

namespace LangPadData.Notebook
{
    /* 
        Serialize as:
        0.word=
        0.pronunciation=
        0.definition=
        0.notes=         */

    /// <summary>
    /// A dictionary word in a dictionary.
    /// </summary>
    public class DictionaryWordNTX
    {
        public string Word { get; set; } = "";
        public string Pronunciation { get; set; } = "";
        public string Definition { get; set; } = "";
        public string Notes { get; set; } = "";
    }

    /// <summary>
    /// A dictionary in a notebook.
    /// </summary>
    public class Dictionary
    {
        public List<DictionaryWordNTX> Words { get; set; } = new List<DictionaryWordNTX>();

        public string Save()
        {
            var dictionaryFile = new List<KvLine>();

            for (var i = 0; i < Words.Count; i++)
            {
                var word = Words[i];

                if (i > 0)
                    dictionaryFile.Add(new KvLine(KvLineType.Blank));

                dictionaryFile.Add(new KvLine(KvLineType.Comment, "Word " + i));
                dictionaryFile.Add(new KvLine(KvLineType.KeyValue, i + ".word", word.Word));
                dictionaryFile.Add(new KvLine(KvLineType.KeyValue, i + ".pronunciation", word.Pronunciation));
                dictionaryFile.Add(new KvLine(KvLineType.KeyValue, i + ".definition", word.Definition));
                dictionaryFile.Add(new KvLine(KvLineType.KeyValue, i + ".notes", word.Notes));
            }

            return Write(dictionaryFile);
        }
    }
}
