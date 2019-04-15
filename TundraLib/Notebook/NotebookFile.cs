using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.IO.Compression;
using static TundraLib.ZiaFile;

namespace TundraLib.Notebook
{
    [Serializable()]
    public class NotebookPage
    {
        public string Title;
        public string RTF;
    }

    [Serializable()]
    public class NotebookFile
    {
        public bool Modified = false;
        public bool EmbedSymbols = false;
        public string DocumentPath;
        public string ProgramVersion = ProgramVersion;
        public decimal NTSpecificationVersion = NTVersion;

        public string Title;
        public string Language;
        public string Author;
        public string Website;
        public string CustomSymbols;
        public string Info;

        public List<NotebookPage> Pages = new List<NotebookPage>();
        public DictionaryFile WordDictionary = new DictionaryFile();

        public void Save(string FilePath)
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);
            NotebookFileAccess.Save(FilePath, this);
            Modified = false;
        }

        public void Open(string FilePath, bool Opening = false)
        {
            NotebookFile NewNotebook = NotebookFileAccess.Open(FilePath);
            Author = NewNotebook.Author;
            ProgramVersion = NewNotebook.ProgramVersion;
            NTSpecificationVersion = NewNotebook.NTSpecificationVersion;
            Title = NewNotebook.Title;
            Language = NewNotebook.Language;
            Website = NewNotebook.Website;
            Pages = NewNotebook.Pages;
            DocumentPath = FilePath;
            Info = NewNotebook.Info;
            CustomSymbols = NewNotebook.CustomSymbols;
            EmbedSymbols = NewNotebook.EmbedSymbols;
            WordDictionary = NewNotebook.WordDictionary;
        }

        public NotebookFile()
        {
        }
    }

    static class NotebookFileAccess
    {
        private static string PagesFolder;
        public static void Save(string FilePath, NotebookFile Notebook)
        {
            frmMain.SaveTabs();

            if (frmDictionary.Loaded == false)
                frmDictionary.LoadDictionary();

            frmDictionary.SaveDictionary();

            Guid guid = Guid.NewGuid();
            string tmp = Application.LocalUserAppDataPath + @"\zip-" + guid.ToString();
            if (Directory.Exists(tmp))
                Directory.Delete(tmp, true);

            Directory.CreateDirectory(tmp);

            PagesFolder = tmp + @"\pages\";
            Directory.CreateDirectory(PagesFolder);

            List<ZiaLine> DataFile = new List<ZiaLine>()
        {
            new ZiaLine(LineType.Comment, "Settings"),
            new ZiaLine(LineType.KeyValue, "Title", Notebook.Title),
            new ZiaLine(LineType.KeyValue, "Language", Notebook.Language),
            new ZiaLine(LineType.KeyValue, "Author", Notebook.Author),
            new ZiaLine(LineType.KeyValue, "Website", Notebook.Website),
            new ZiaLine(LineType.KeyValue, "NTVersion", NTVersion),
            new ZiaLine(LineType.KeyValue, "LangPadVersion", LangPadVersion),
            new ZiaLine(LineType.Blank),
            new ZiaLine(LineType.Comment, "Pages")
        };

            for (var i = 0; i <= Notebook.Pages.Count - 1; i++)
            {
                var Page = Notebook.Pages[i];
                DataFile.Add(new ZiaLine(LineType.KeyValue, "Page" + i, ToCompatibleString(Page.Title)));

                StreamWriter txtWriter;
                txtWriter = new StreamWriter(PagesFolder + i + ".rtf");
                txtWriter.Write(Page.RTF);
                txtWriter.Close();
            }

            if (Notebook.EmbedSymbols == true)
                Notebook.CustomSymbols = My.Settings.CustomSymbols;
            else
                Notebook.CustomSymbols = "";

            // Write to disk
            File.WriteAllText(tmp + @"\data.txt", Write(DataFile));
            File.WriteAllText(tmp + @"\info.txt", Notebook.Info);
            File.WriteAllText(tmp + @"\custom_symbols.txt", Notebook.CustomSymbols);
            Notebook.WordDictionary.Save(tmp + @"\dictionary.txt");
            Notebook.DocumentPath = FilePath;

            ZipFile.CreateFromDirectory(tmp, FilePath, CompressionLevel.Optimal, false);
        }

        public static NotebookFile Open(string FilePath)
        {
            NotebookFile NewNotebook = new NotebookFile();
            Guid guid = Guid.NewGuid();
            string tmp = Application.LocalUserAppDataPath + @"\zip-" + guid.ToString();

            if ((Directory.Exists(tmp)))
                Directory.Delete(tmp, true);

            Directory.CreateDirectory(tmp);

            ZipFile.ExtractToDirectory(FilePath, tmp);
            PagesFolder = tmp + @"\pages\";

            var LineList = Read(File.ReadAllText(tmp + @"\data.txt"));
            NewNotebook.NTSpecificationVersion = decimal.Parse(Search(LineList, "NTVersion"));
            bool CompatMode = (NewNotebook.NTSpecificationVersion < 2);

            if (CompatMode)
            {
                var PageOrder = Search(LineList, "Page Order").Split(
                {
                    "|"
            }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string PageTitle in PageOrder)
                {
                    NotebookPage Page = new NotebookPage()
                    {
                        Title = PageTitle,
                        RTF = File.ReadAllText(PagesFolder + PageTitle + ".rtf")
                    };
                    NewNotebook.Pages.Add(Page);
                }
            }
            else
            {
                int PageCount = Directory.EnumerateFiles(PagesFolder).Count();
                for (var i = 0; i <= PageCount - 1; i++)
                {
                    NotebookPage Page = new NotebookPage();
                    string PageName = Search(LineList, "Page" + i);

                    if (PageName == null)
                        PageName = (i + 1).ToString();

                    Page.Title = PageName;
                    Page.RTF = File.ReadAllText(PagesFolder + i + ".rtf");
                    NewNotebook.Pages.Add(Page);
                }
            }



            NewNotebook.Title = Search(LineList, "Title");
            NewNotebook.Language = Search(LineList, "Language");
            NewNotebook.Author = Search(LineList, "Author");
            NewNotebook.Website = Search(LineList, "Website");
            NewNotebook.ProgramVersion = Search(LineList, "LangPadVersion");
            NewNotebook.CustomSymbols = File.ReadAllText(tmp + @"\custom_symbols.txt");
            NewNotebook.Info = File.ReadAllText(tmp + @"\info.txt");
            NewNotebook.WordDictionary.Open(tmp + @"\dictionary.txt");

            if (!(NewNotebook.CustomSymbols == ""))
                NewNotebook.EmbedSymbols = true;

            if (NewNotebook.CustomSymbols == "")
            {
            }
            else if (NewNotebook.CustomSymbols == My.Settings.CustomSymbols)
            {
            }
            else if (My.Settings.CustomSymbols.StartsWith(NewNotebook.CustomSymbols))
            {
            }
            else
            {
                dlgAppendReplace.ShowDialog();
                if (dlgAppendReplace.Result == dlgAppendReplace.AppendReplaceDialogResult.Append)
                    My.Settings.CustomSymbols = My.Settings.CustomSymbols + NewNotebook.CustomSymbols;
                else if (dlgAppendReplace.Result == dlgAppendReplace.AppendReplaceDialogResult.Replace)
                    My.Settings.CustomSymbols = NewNotebook.CustomSymbols;
                else
                {
                }

                frmMain.CustomLayoutPanel.Controls.Clear();
                frmDictionary.CustomLayoutPanel.Controls.Clear();

                string[] LineList2 = My.Settings.CustomSymbols.Split(
                {
                    Environment.NewLine
            }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string IPA in LineList2)
                {
                    SymbolButton SymbolButton = new SymbolButton()
                    {
                        Text = IPA
                    };
                    SymbolButton.Click += frmMain.InsertIPA;
                    frmMain.CustomLayoutPanel.Controls.Add(SymbolButton);

                    SymbolButton SymbolButtonDictionary = new SymbolButton()
                    {
                        Text = IPA
                    };
                    SymbolButtonDictionary.Click += frmDictionary.InsertIPA;
                    frmDictionary.CustomLayoutPanel.Controls.Add(SymbolButtonDictionary);
                }
            }

            return NewNotebook;
        }
    }
}