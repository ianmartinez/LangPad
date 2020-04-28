using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using static ThornWriter.NotebookFile.KeyValue;

namespace ThornWriter.NotebookFile
{
    public class Notebook
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
        public List<Page> Pages { get; set; } = new List<Page>();
        public Dictionary NotebookDictionary { get; set; } = new Dictionary();

        public void Save(string filePath)
        {
            var temp = new TempFolder();
            Directory.CreateDirectory(temp.PagesFolder);

            var dataFile = new List<Line>()
            {
                new Line(LineType.KeyValue, "title", Title),
                new Line(LineType.KeyValue, "language", Language),
                new Line(LineType.KeyValue, "author", Author),
                new Line(LineType.KeyValue, "website", Website),
                new Line(LineType.KeyValue, "specVersion", SpecVersion.ToString())
            };

            var pagesFile = new List<Line>();
            for (var i = 0; i < Pages.Count; i++)
            {
                var page = Pages[i];

                if (i > 0)
                    pagesFile.Add(new Line(LineType.Blank));

                pagesFile.Add(new Line(LineType.Comment, "Page " + i));
                pagesFile.Add(new Line(LineType.KeyValue, i + ".title", page.Title));
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
