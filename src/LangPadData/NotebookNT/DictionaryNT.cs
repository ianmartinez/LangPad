using LangPadData.Properties;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LangPadData.NotebookNT;

/// <summary>
/// A dictionary in the NT 1.x-2.x file format (*.nt).
/// </summary>
public class DictionaryNT
{
    /// <summary>
    /// A list of words in the dictionary.
    /// </summary>
    public List<WordNT> Words { get; set; } = [];

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
            Words = [];

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

        List<KvLine> dictionaryLines =
          [
              new KvLine(KvLineType.Comment, "Dictionary"),
              new KvLine(KvLineType.Comment, $"NT Version:{NotebookNT.SPEC_VERSION}"),
              new KvLine(KvLineType.Blank)
          ];

        for (var i = 0; i < Words.Count; i++)
        {
            var currentWord = Words[i];
            var lineValue = string.Format("{0}|{1}|{2}|{3}",
                KeyValue.FormatString(currentWord.Word),
                KeyValue.FormatString(currentWord.Pronunciation),
                KeyValue.FormatString(currentWord.Definition),
                KeyValue.FormatString(currentWord.Notes));

            dictionaryLines.Add(new KvLine(KvLineType.KeyValue, $"Word {i}", lineValue));
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
            Words = [];

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
        List<string> lines =
        [
            // Add header
            $"{"word"},{"pronunciation"},{"definition"},{"notes"}".ToUpper()
        ];

        // Add each word
        foreach (var word in Words)
        {
            lines.Add($"{word.Word},{word.Pronunciation},{word.Definition},{word.Notes}");
        }

        // Write to CSV
        File.WriteAllLines(filePath, lines, Encoding.UTF8);
    }

    /// <summary>
    /// Export the current dictionary to an HTML
    /// document, with option settings object to
    /// customize the generated HTML.
    /// </summary>
    /// 
    /// <param name="filePath">The path of the HTML file.</param>
    /// <param name="exportSettings">The HTML rendering settings.</param>
    public void SaveHtml(string filePath, HtmlExportSettings exportSettings = null)
    {
        exportSettings ??= new HtmlExportSettings();

        // Get the sorted words
        var sortedWords = new List<WordNT>();
        sortedWords.AddRange(Words);
        sortedWords.Sort();

        // Create description 
        var descriptionLines = new List<string>();
        var descriptionIndent = "\t\t\t";
        if (exportSettings.DescriptionParagraphs)
        {
            var descriptionTextLines = Lines.Get(exportSettings.Description);
            foreach (var line in descriptionTextLines)
            {
                descriptionLines.Add($"{descriptionIndent}<p>");
                descriptionLines.Add($"{descriptionIndent}\t{line}");
                descriptionLines.Add($"{descriptionIndent}</p>");
            }
        }
        else
        {
            descriptionLines.Add($"{descriptionIndent}{exportSettings.Description}");
        }

        // Create table
        List<string> tableLines = [];
        var rowIndent = "\t\t\t";
        var rowDataIndent = "\t\t\t\t";

        // If any columns selected
        if (exportSettings.WordCol || exportSettings.PronunciationCol || exportSettings.DefinitionCol || exportSettings.NotesCol)
        {
            // Add header
            tableLines.Add($"{rowIndent}<tr>");

            if (exportSettings.WordCol)
                tableLines.Add($"{rowDataIndent}<th>Word</th>");

            if (exportSettings.PronunciationCol)
                tableLines.Add($"{rowDataIndent}<th>Pronunciation</th>");

            if (exportSettings.DefinitionCol)
                tableLines.Add($"{rowDataIndent}<th>Definition</th>");

            if (exportSettings.NotesCol)
                tableLines.Add($"{rowDataIndent}<th>Notes</th>");

            tableLines.Add($"{rowIndent}</tr>");

            // Add each word
            foreach (var word in sortedWords)
            {
                tableLines.Add($"{rowIndent}<tr>");

                if (exportSettings.WordCol)
                    tableLines.Add($"{rowDataIndent}<td>{word.Word}</td>");

                if (exportSettings.PronunciationCol)
                    tableLines.Add($"{rowDataIndent}<td>{word.Pronunciation}</td>");

                if (exportSettings.DefinitionCol)
                    tableLines.Add($"{rowDataIndent}<td>{word.Definition}</td>");

                if (exportSettings.NotesCol)
                    tableLines.Add($"{rowDataIndent}<td>{word.Notes}</td>");

                tableLines.Add($"{rowIndent}</tr>");
            }
        }

        // Generate html string
        var htmlDoc = string.Format(Resources.DictionaryHtmlBase,
            exportSettings.Title,
            string.Join("\n", descriptionLines),
            Resources.DictionaryHtmlStyle,
            string.Join("\n", tableLines));

        // Write to file
        File.WriteAllText(filePath, htmlDoc);
    }
}
