using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using static NotebookFile.KeyValue;

namespace NotebookFile
{
    public class Notebook
    {
        private static readonly string appDataFolder =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public string FilePath { get; set; }
        public decimal AppVersion { get; set; }
        public decimal SpecVersion { get; set; }

        public string Title { get; set; }
        public string Language { get; set; }
        public string Author { get; set; }
        public string Website { get; set; }
        public string Info { get; set; }

        public string Stylesheet { get; set; }

        public List<string> Characters { get; set; }
        public List<Page> Pages { get; set; }
        public Dictionary Dictionary { get; set; }


        public void Save(string filePath)
        {
            // Temporary folder to be zipped
            var guid = Guid.NewGuid();
            var rootFolder = string.Format("{0}\\notebook-{1}", appDataFolder, guid.ToString());
            var pagesFolder = string.Format("{0}\\pages", rootFolder);

            if (Directory.Exists(rootFolder))
                Directory.Delete(rootFolder, true);

            Directory.CreateDirectory(rootFolder);
            Directory.CreateDirectory(pagesFolder);

            var dataFile = new List<Line>()
            {
                new Line(LineType.Comment, "Settings"),
                new Line(LineType.KeyValue, "Title", Title),
                new Line(LineType.KeyValue, "Language", Language),
                new Line(LineType.KeyValue, "Author", Author),
                new Line(LineType.KeyValue, "Website", Website),
                new Line(LineType.KeyValue, "AppVersion", AppVersion.ToString()),
                new Line(LineType.KeyValue, "SpecVersion", SpecVersion.ToString()),

                new Line(LineType.Blank),
                new Line(LineType.Comment, "Pages")
            };

            for(var i=0; i<Pages.Count; i++)
            {
                var page = Pages[i];
                dataFile.Add(new Line(LineType.KeyValue, "Page" + i, FormatString(page.Title)));

                var pageWriter = new StreamWriter(string.Format("{0}\\{1}.html", pagesFolder, i.ToString()));
                pageWriter.Write(page.Content);
                pageWriter.Close();
            }

            File.WriteAllText(string.Format("{0}\\data.txt", rootFolder), Write(dataFile));
            File.WriteAllText(string.Format("{0}\\info.txt", rootFolder), Info);
            File.WriteAllText(string.Format("{0}\\characters.txt", rootFolder), string.Join("\n", Characters));
            Dictionary.Save(string.Format("{0}\\dictionary.txt", rootFolder));

            FilePath = filePath;
            ZipFile.CreateFromDirectory(rootFolder, FilePath, CompressionLevel.Optimal, false);
        }

        public void Open(string filePath)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);
        }
    }
}
