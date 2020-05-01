using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using static LangPadData.KeyValue;

namespace LangPadData.NotebookNTX
{
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
        public List<string> Characters { get; set; } = new List<string>();
        public List<PageNTX> Pages { get; set; } = new List<PageNTX>();
        public DictionaryNTX NotebookDictionary { get; set; } = new DictionaryNTX();

        public void Save(string filePath)
        {
            var temp = new TempFolderNTX();
            Directory.CreateDirectory(temp.PagesFolder);

            var dataFile = new List<KVLine>()
            {
                new KVLine(KVLineType.KeyValue, "title", Title),
                new KVLine(KVLineType.KeyValue, "language", Language),
                new KVLine(KVLineType.KeyValue, "author", Author),
                new KVLine(KVLineType.KeyValue, "website", Website),
                new KVLine(KVLineType.KeyValue, "specVersion", SpecVersion.ToString())
            };

            var pagesFile = new List<KVLine>();
            for (var i = 0; i < Pages.Count; i++)
            {
                var page = Pages[i];

                if (i > 0)
                    pagesFile.Add(new KVLine(KVLineType.Blank));

                pagesFile.Add(new KVLine(KVLineType.Comment, "Page " + i));
                pagesFile.Add(new KVLine(KVLineType.KeyValue, i + ".title", page.Title));
                File.WriteAllText(temp.GetPagePath(i), page.Content);
            }

            File.WriteAllText(temp.DataFile, Write(dataFile));
            File.WriteAllText(temp.StylesheetFile, Stylesheet);
            File.WriteAllText(temp.InfoFile, Info);
            File.WriteAllText(temp.CharactersFile, string.Join("\n", Characters));
            File.WriteAllText(temp.PagesFile, Write(pagesFile));
            File.WriteAllText(temp.DictionaryFile, NotebookDictionary.Save());

            ZipFile.CreateFromDirectory(temp.RootFolder, filePath, CompressionLevel.Optimal, false);
        }
    }
}
