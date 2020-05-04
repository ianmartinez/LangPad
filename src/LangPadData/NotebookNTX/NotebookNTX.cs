using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using static LangPadData.KeyValue;

namespace LangPadData.NotebookNTX
{    
    /// <summary>
     /// A notebook in the NT 3.x file format (*.ntx), which
     /// is planned to replace the *.nt format. It is still
     /// in development.
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
        public List<string> Characters { get; set; } = new List<string>();
        public List<PageNTX> Pages { get; set; } = new List<PageNTX>();
        public DictionaryNTX NotebookDictionary { get; set; } = new DictionaryNTX();

        public void Save(string filePath)
        {
            var temp = new TempFolderNTX(true);

            var dataFile = new List<KvLine>()
            {
                new KvLine(KvLineType.KeyValue, "title", Title),
                new KvLine(KvLineType.KeyValue, "language", Language),
                new KvLine(KvLineType.KeyValue, "author", Author),
                new KvLine(KvLineType.KeyValue, "website", Website),
                new KvLine(KvLineType.KeyValue, "specVersion", SpecVersion.ToString())
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
}
