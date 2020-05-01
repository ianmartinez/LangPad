using System;
using System.Collections.Generic;
using System.IO;

namespace LangPadData.NotebookNT
{
    public class DictionaryNT
    {
        public List<WordNT> Words { get; set; } = new List<WordNT>();

        public void Open(string filePath)
        {
            // Reset words
            Words = new List<WordNT>();

            var lines = KeyValue.ReadFile(filePath);
            foreach(var line in lines)
            {
                var lineCols = line.Value.Split('|');
                if(line.Key.StartsWith("Word") && lineCols.Length == 4) // Valid format
                {
                    var newWord = new WordNT
                    {
                        Word = KeyValue.UnformatString(lineCols[0]),
                        Pronunciation = KeyValue.UnformatString(lineCols[1]),
                        Definition = KeyValue.UnformatString(lineCols[2]),
                        Notes = KeyValue.UnformatString(lineCols[3])
                    };

                    Words.Add(newWord);
                }
            }
        }

        public void Save(string filePath)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);

            var dictionaryLines = new List<KvLine>
            {
                new KvLine(KvLineType.Comment, "Dictionary"),
                new KvLine(KvLineType.Comment, "NT Version:" + NotebookNT.NT_VERSION),
                new KvLine(KvLineType.Blank)
            };

            for (var i = 0; i < Words.Count; i++)
            {
                var currentWord = Words[i];
                var lineValue = string.Format("{0}|{1}|{2}|{3}",
                    KeyValue.FormatString(currentWord.Word),
                    KeyValue.FormatString(currentWord.Pronunciation),
                    KeyValue.FormatString(currentWord.Definition),
                    KeyValue.FormatString(currentWord.Notes));

                dictionaryLines.Add(new KvLine(KvLineType.KeyValue, "Word " + i, lineValue));
            }

           KeyValue.WriteFile(filePath, dictionaryLines);
        }

        public void OpenCsv(string filePath)
        {
            // Reset words
            Words = new List<WordNT>();

            var lines = Lines.Get(File.ReadAllText(filePath));
            foreach(var line in lines)
            {
                var isHeader = line.Trim().Equals("Word,Pronunciation,Definition,Notes");
                if(!isHeader)
                {
                    var lineCols = line.Split(',');
                    if(lineCols.Length >= 4)
                    {
                        var newWord = new WordNT
                        {
                            Word = KeyValue.UnformatString(lineCols[0]),
                            Pronunciation = KeyValue.UnformatString(lineCols[1]),
                            Definition = KeyValue.UnformatString(lineCols[2]),
                            Notes = KeyValue.UnformatString(lineCols[3])
                        };

                        Words.Add(newWord);
                    }
                }
            }
        }
    }

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
