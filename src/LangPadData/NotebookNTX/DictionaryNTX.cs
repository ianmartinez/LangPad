using System.Collections.Generic;
using static LangPadData.KeyValue;

namespace LangPadData.NotebookNTX
{
    /* 
        Serialize as:
        0.word=
        0.pronunciation=
        0.definition=
        0.notes=         */
    public class DictionaryWordNTX
    {
        public string Word { get; set; } = "";
        public string Pronunciation { get; set; } = "";
        public string Definition { get; set; } = "";
        public string Notes { get; set; } = "";
    }

    public class DictionaryNTX
    {
        public List<DictionaryWordNTX> Words { get; set; } = new List<DictionaryWordNTX>();

        public string Save()
        {
            var dictionaryFile = new List<KVLine>();

            for (var i = 0; i < Words.Count; i++)
            {
                var word = Words[i];

                if (i > 0)
                    dictionaryFile.Add(new KVLine(KVLineType.Blank));

                dictionaryFile.Add(new KVLine(KVLineType.Comment, "Word " + i));
                dictionaryFile.Add(new KVLine(KVLineType.KeyValue, i + ".word", word.Word));
                dictionaryFile.Add(new KVLine(KVLineType.KeyValue, i + ".pronunciation", word.Pronunciation));
                dictionaryFile.Add(new KVLine(KVLineType.KeyValue, i + ".definition", word.Definition));
                dictionaryFile.Add(new KVLine(KVLineType.KeyValue, i + ".notes", word.Notes));
            }

            return Write(dictionaryFile);
        }
    }
}
