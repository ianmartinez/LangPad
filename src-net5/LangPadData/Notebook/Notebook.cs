using LangPadData.Inspectors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using static LangPadData.KeyValue;

namespace LangPadData.Notebook
{
    public enum NotebookInspectorValue
    {
        PageCount
    }

    /// <summary>
    /// The core data of a notebook file.
    /// </summary>
    public class Notebook
    {
        public const double CurrentSpec = 3.0;
        public double SpecVersion { get; set; } = CurrentSpec;

        public event EventHandler<InspectorValueChangedEventArgs<NotebookInspectorValue>> ValueChanged;

        public string Title { get; set; } = "";
        public string Language { get; set; } = "";
        public string Author { get; set; } = "";
        public string Website { get; set; } = "";
        public string Info { get; set; } = "";
        public string Stylesheet { get; set; } = "";
        public List<Resource> Resouces { get; set; } = new List<Resource>();
        public List<string> Characters { get; set; } = new List<string>();
        public ObservableCollection<Page> Pages { get; set; } = new ObservableCollection<Page>();
        public Dictionary NotebookDictionary { get; set; } = new Dictionary();
        public bool Modified { get; set; } = false;
        public string FilePath { get; set; } = "";

        public Notebook()
        {
            Pages.CollectionChanged += Pages_CollectionChanged;
        }

        // Fire the ValueChanged event when the page count changes
        private void Pages_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var args = new InspectorValueChangedEventArgs<NotebookInspectorValue>
            {
                OldValue = -1, // We don't care about the old value on this event
                NewValue = Pages.Count,
                TargetValue = NotebookInspectorValue.PageCount
            };

            ValueChanged?.Invoke(this, args);
        }
        public void Open(string filePath)
        {
            throw new NotImplementedException();
        }

        public void Save(string filePath)
        {
            var temp = new TempFolder(true);

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

            // Write other files
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
