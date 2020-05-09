using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LangPadData.NotebookNT
{
    /// <summary>
    /// A dictionary in the NT 1.x-2.x file format (*.nt).
    /// </summary>
    public class DictionaryNT
    {
        /// <summary>
        /// A list of words in the dictionary.
        /// </summary>
        public List<WordNT> Words { get; set; } = new List<WordNT>();

        /// <summary>
        /// Replace the words in this dictionary with the words in 
        /// a dictionary file.
        /// </summary>
        /// 
        /// <param name="filePath">The path of the dictionary file.</param>
        /// <param name="replaceExisting">If the current words should be replaced.</param>
        public void Open(string filePath, bool replaceExisting = true)
        {
            // Reset words if replaceExisting
            if (replaceExisting)
                Words = new List<WordNT>();

            var lines = KeyValue.ReadFile(filePath);
            foreach (var line in lines)
            {
                var lineCols = line.Value.Split('|');
                if (line.Key.StartsWith("Word") && lineCols.Length == 4) // Valid format
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

        /// <summary>
        /// Save the dictionary to a text file.
        /// </summary>
        /// 
        /// <param name="filePath">The file to save the dictionary to.</param>
        public void Save(string filePath)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);

            var dictionaryLines = new List<KvLine>
            {
                new KvLine(KvLineType.Comment, "Dictionary"),
                new KvLine(KvLineType.Comment, "NT Version:" + NotebookNT.SPEC_VERSION),
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

        /// <summary>
        /// Open a CSV file as a dictionary.
        /// </summary>
        /// 
        /// <param name="filePath">The file to open.</param>
        /// <param name="replaceExisting">If the current words should be replaced.</param>
        public void OpenCsv(string filePath, bool replaceExisting = true)
        {
            // Reset words if replaceExisting
            if (replaceExisting)
                Words = new List<WordNT>();

            var lines = Lines.Get(File.ReadAllText(filePath));

            // Loop through each line and add a word to the dictionary
            // if it's in a valid format
            for (var i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                var isHeader = i == 0 && line.Trim().ToLower().Equals("word,pronunciation,definition,notes");

                if (!isHeader)
                {
                    var lineCols = line.Split(',');
                    if (lineCols.Length >= 4)
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

        /// <summary>
        /// Save the dictionary as a CSV (Comma-Separated Values)  file.
        /// </summary>
        /// 
        /// <param name="filePath">The file to save to.</param>
        public void SaveCsv(string filePath)
        {
            var lines = new List<string>();
            var colFormat = "{0},{1},{2},{3}";

            // Add header
            lines.Add(string.Format(colFormat, "word", "pronunciation", "definition", "notes").ToUpper());

            // Add each word
            foreach (var word in Words)
                lines.Add(string.Format("{0},{1},{2},{3}", word.Word, word.Pronunciation, word.Definition, word.Notes));

            // Write to CSV
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }

        public void SaveHtml(string filePath)
        {

        }
    }
}
