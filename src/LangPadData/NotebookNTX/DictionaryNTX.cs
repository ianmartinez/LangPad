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
            var dictionaryFile = new List<Line>();

            for (var i = 0; i < Words.Count; i++)
            {
                var word = Words[i];

                if (i > 0)
                    dictionaryFile.Add(new Line(LineType.Blank));

                dictionaryFile.Add(new Line(LineType.Comment, "Word " + i));
                dictionaryFile.Add(new Line(LineType.KeyValue, i + ".word", word.Word));
                dictionaryFile.Add(new Line(LineType.KeyValue, i + ".pronunciation", word.Pronunciation));
                dictionaryFile.Add(new Line(LineType.KeyValue, i + ".definition", word.Definition));
                dictionaryFile.Add(new Line(LineType.KeyValue, i + ".notes", word.Notes));
            }

            return Write(dictionaryFile);
        }
    }
}
