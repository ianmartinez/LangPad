using System.Collections.Generic;
using static LangPadData.KeyValue;

namespace LangPadData.NotebookNTX;

/* 
    Serialize as:
    0.word=
    0.pronunciation=
    0.definition=
    0.notes=         */

/// <summary>
/// A dictionary in the future NTX file format (*.ntx), designed to replace
/// the NT format (NotebookNT, DictionaryNT, etc.). It is based around HTML
/// page data instead of RTF page data, and contains many other breaking features
/// that make it incompatible with the current format.
/// 
/// It is a work in progress and the NT format is still used by the actual 
/// program for the time being.
/// </summary>
public class DictionaryWordNTX
{
    public string Word { get; set; } = "";
    public string Pronunciation { get; set; } = "";
    public string Definition { get; set; } = "";
    public string Notes { get; set; } = "";
}

public class DictionaryNTX
{
    public List<DictionaryWordNTX> Words { get; set; } = [];

    public string Save()
    {
        var dictionaryFile = new List<KvLine>();

        for (var i = 0; i < Words.Count; i++)
        {
            var word = Words[i];

            if (i > 0)
                dictionaryFile.Add(new KvLine(KvLineType.Blank));

            dictionaryFile.Add(new KvLine(KvLineType.Comment, $"Word {i}"));
            dictionaryFile.Add(new KvLine(KvLineType.KeyValue, $"{i}.word", word.Word));
            dictionaryFile.Add(new KvLine(KvLineType.KeyValue, $"{i}.pronunciation", word.Pronunciation));
            dictionaryFile.Add(new KvLine(KvLineType.KeyValue, $"{i}.definition", word.Definition));
            dictionaryFile.Add(new KvLine(KvLineType.KeyValue, $"{i}.notes", word.Notes));
        }

        return Write(dictionaryFile);
    }
}
