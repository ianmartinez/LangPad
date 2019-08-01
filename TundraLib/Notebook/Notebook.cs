using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using static NotebookFile.KeyValue;

namespace NotebookFile
{
    public class Notebook
    {
        public const double CurrentSpec = 3.0;

        public string FilePath { get; set; } = "";
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
                new Line(LineType.Comment, "Settings"),
                new Line(LineType.KeyValue, "Title", Title),
                new Line(LineType.KeyValue, "Language", Language),
                new Line(LineType.KeyValue, "Author", Author),
                new Line(LineType.KeyValue, "Website", Website),
                new Line(LineType.KeyValue, "SpecVersion", SpecVersion.ToString()),

                new Line(LineType.Blank),
                new Line(LineType.Comment, "Pages")
            };

            for (var i = 0; i < Pages.Count; i++)
            {
                var page = Pages[i];
                dataFile.Add(new Line(LineType.KeyValue, "Page" + i, FormatString(page.Title)));
                File.WriteAllText(temp.GetPagePath(i), page.Content);
            }

            File.WriteAllText(temp.DataFile, Write(dataFile));
            File.WriteAllText(temp.StylesheetFile, Stylesheet);
            File.WriteAllText(temp.InfoFile, Info);
            File.WriteAllText(temp.CharactersFile, string.Join("\n", Characters));
            NotebookDictionary.Save(temp.DictionaryFile);

            ZipFile.CreateFromDirectory(temp.RootFolder, filePath, CompressionLevel.Optimal, false);
            FilePath = filePath;
        }

        public void Open(string filePath)
        {
            var temp = new TempFolder();
            ZipFile.ExtractToDirectory(filePath, temp.RootFolder);

            var dataFileLines = Read(File.ReadAllText(temp.DataFile));
            SpecVersion = double.Parse(Search(dataFileLines, "SpecVersion"));
            Title = Search(dataFileLines, "Title");
            Language = Search(dataFileLines, "Language");
            Author = Search(dataFileLines, "Author");
            Website = Search(dataFileLines, "Website");
            Characters = new List<string>(ToLines(File.ReadAllText(temp.CharactersFile)));
            Stylesheet = File.ReadAllText(temp.StylesheetFile);
            Info = File.ReadAllText(temp.InfoFile);
            NotebookDictionary.Open(temp.DictionaryFile);

            Pages.Clear();
            var pageCount = Directory.EnumerateFiles(temp.RootFolder).Count();
            for (var i = 0; i < pageCount; i++)
            {
                Pages.Add(new Page()
                {
                    Title = Search(dataFileLines, "Page" + i),
                    Content = File.ReadAllText(temp.GetPagePath(i))
                });
            }

            Directory.Delete(temp.RootFolder, true);
            FilePath = filePath;
        }
    }
}
