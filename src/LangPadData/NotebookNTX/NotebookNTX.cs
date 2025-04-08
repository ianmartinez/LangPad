using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using static LangPadData.KeyValue;

namespace LangPadData.NotebookNTX;

/// <summary>
/// A notebook in the future NTX file format (*.ntx), designed to replace
/// the NT format (NotebookNT, DictionaryNT, etc.). It is based around HTML
/// page data instead of RTF page data, and contains many other breaking features
/// that make it incompatible with the current format.
/// 
/// It is a work in progress and the NT format is still used by the actual 
/// program for the time being.
/// </summary>
public class NotebookNTX
{
    public const double CurrentSpec = 3.0;
    public double SpecVersion { get; set; } = CurrentSpec;
    public string Title { get; set; } = "";
    public string Language { get; set; } = "";
    public string Author { get; set; } = "";
    public string Website { get; set; } = "";
    public string Info { get; set; } = "";
    public string Stylesheet { get; set; } = "";
    public List<string> Characters { get; set; } = [];
    public List<PageNTX> Pages { get; set; } = [];
    public DictionaryNTX NotebookDictionary { get; set; } = new DictionaryNTX();

    public void Save(string filePath)
    {
        var temp = new TempFolderNTX(true);

        var dataFile = new List<KvLine>()
          {
              new(KvLineType.KeyValue, "title", Title),
              new(KvLineType.KeyValue, "language", Language),
              new(KvLineType.KeyValue, "author", Author),
              new(KvLineType.KeyValue, "website", Website),
              new(KvLineType.KeyValue, "specVersion", SpecVersion.ToString())
          };

        var pagesFile = new List<KvLine>();
        for (var i = 0; i < Pages.Count; i++)
        {
            var page = Pages[i];

            if (i > 0)
                pagesFile.Add(new KvLine(KvLineType.Blank));

            pagesFile.Add(new KvLine(KvLineType.Comment, "Page " + i));
            pagesFile.Add(new KvLine(KvLineType.KeyValue, i + ".title", page.Title));
            File.WriteAllText(temp.GetPagePath(i), page.Content);
        }

        File.WriteAllText(temp.DataFile, Write(dataFile));
        File.WriteAllText(temp.StylesheetFile, Stylesheet);
        File.WriteAllText(temp.InfoFile, Info);
        File.WriteAllText(temp.CharactersFile, string.Join("\n", Characters));
        File.WriteAllText(temp.PagesFile, Write(pagesFile));
        File.WriteAllText(temp.DictionaryFile, NotebookDictionary.Save());

        ZipFile.CreateFromDirectory(temp.RootFolder, filePath, CompressionLevel.Fastest, false);
    }
}
