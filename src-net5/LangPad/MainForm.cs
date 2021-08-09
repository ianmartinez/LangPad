using Eto.Drawing;
using Eto.Forms;
using LangPad.Forms;
using LangPad.Inspectors;
using LangPad.Web;
using LangPadData;
using LangPadData.Inspectors;
using LangPadData.Notebook;
using LangPadData.Web;
using LangPadData.Web.Controls;
using System;

namespace LangPad
{
    public class MainForm : Form
    {
        IWebViewManager PreviewManager;
        IWebViewManager EditManager;
        TextEditor PageEditor;
        Notebook Document = new Notebook();
        Page CurrentPage
        {
            get
            {
                var pageIndex = PageSelector.SelectedRow;

                if (pageIndex != -1 && pageIndex < Document.Pages.Count)
                    return Document.Pages[pageIndex];

                return null;
            }
        }

        #region "Windows"
        PreferencesForm PreferencesDialog = new PreferencesForm();
        PageInspector PageInspector = new PageInspector();
        #endregion

        #region "Controls"
        WebView DocumentPreview = new WebView();
        WebView DocumentEditor = new WebView();
        TreeGridItemCollection PageSelectorItems = new TreeGridItemCollection();
        TreeGridView PageSelector = new TreeGridView();
        Panel MainPanel = new Panel();
        Splitter MainSplitter = new Splitter();
        Splitter DocumentSplitter = new Splitter();
        #endregion

        #region "UI"
        string appTitle = "Thorn Writer " + AppInfo.GetFormattedVersion();
        public MainForm()
        {
            Title = appTitle;
            ClientSize = new Size(700, 500);

            // Set managers
            PreviewManager = new EtoWebViewManager(DocumentPreview);
            EditManager = new EtoWebViewManager(DocumentEditor);
            PageEditor = new TextEditor(EditManager, PreviewManager);
            PageEditor.ContentChanged += OnContentChanged;

            var documentBase = ResourceFiles.DocumentBase;
            documentBase = HtmlRenderer.RenderStyle(documentBase, "DocumentStyle", ResourceFiles.DocumentStyle);
            PageEditor.PreviewBase = documentBase;

            // Page Selector
            PageSelector.Columns.Add(new GridColumn()
            {
                DataCell = new ImageTextCell(0, 1),
                AutoSize = true,
                Resizable = false,
                Editable = true,
            });
            PageSelector.ShowHeader = false;
            PageSelector.Columns[0].AutoSize = true;
            PageSelector.Border = BorderType.None;
            PageSelector.SelectionChanged += OnChangeSelection;
            PageSelector.CellEdited += OnChangePageTitle;

            // Document Splitter
            DocumentSplitter.Panel1 = DocumentPreview;
            DocumentSplitter.Panel2 = DocumentEditor;
            DocumentSplitter.Orientation = Orientation.Vertical;
            DocumentSplitter.Position = 2 * (ClientSize.Height / 3);
            DocumentSplitter.FixedPanel = SplitterFixedPanel.Panel1;

            // Main Splitter
            MainSplitter.Panel1 = PageSelector;
            PageSelector.BackgroundColor = Color.FromArgb(0, 0, 0, 0);

            MainSplitter.Panel2 = DocumentSplitter;
            MainSplitter.Orientation = Orientation.Horizontal;
            MainSplitter.Position = 1 * (ClientSize.Width / 3);
            MainSplitter.FixedPanel = SplitterFixedPanel.Panel1;

            MainPanel.Content = MainSplitter;
            Content = MainPanel;

            // Commands - Application
            var prefrencesCommand = new Command
            {
                MenuText = "&Preferences...",
                ToolBarText = "Preferences",
                Image = Icons.Get("config")
            };
            prefrencesCommand.Executed += OnPreferences;

            // Commands - File
            var newNotebookCommand = new Command
            {
                MenuText = "New Notebook",
                ToolBarText = "New",
                Image = Icons.Get("document-new")
            };
            newNotebookCommand.Executed += OnNewNotebook;

            var openNotebookCommand = new Command
            {
                MenuText = "Open...",
                ToolBarText = "Open",
                Image = Icons.Get("document-open")
            };
            openNotebookCommand.Executed += OnOpenNotebook;

            var saveNotebookCommand = new Command
            {
                MenuText = "Save...",
                ToolBarText = "Save",
                Image = Icons.Get("document-save")
            };
            saveNotebookCommand.Executed += OnSaveNotebook;

            // Commands - Application
            var quitCommand = new Command
            {
                MenuText = "Quit",
                Shortcut = Application.Instance.CommonModifier | Keys.Q
            };
            quitCommand.Executed += OnQuit;

            var aboutCommand = new Command
            {
                MenuText = "About..."
            };
            aboutCommand.Executed += OnAbout;

            // Commands - Edit
            var undoCommand = new Command
            {
                MenuText = "Undo",
                ToolBarText = "Undo",
                Image = Icons.Get("edit-undo")
            };
            undoCommand.Executed += OnUndo;

            var redoCommand = new Command
            {
                MenuText = "Redo",
                ToolBarText = "Redo",
                Image = Icons.Get("edit-redo")
            };
            redoCommand.Executed += OnRedo;

            var cutCommand = new Command
            {
                MenuText = "Cut",
                ToolBarText = "Cut",
                Image = Icons.Get("edit-cut")
            };
            cutCommand.Executed += OnCut;

            var copyCommand = new Command
            {
                MenuText = "Copy",
                ToolBarText = "Copy",
                Image = Icons.Get("edit-copy")
            };
            copyCommand.Executed += OnCopy;

            var pasteCommand = new Command
            {
                MenuText = "Paste",
                ToolBarText = "Paste",
                Image = Icons.Get("edit-paste")
            };
            pasteCommand.Executed += OnPaste;

            // Commands - Notebook
            var pageInspectorCommand = new Command
            {
                MenuText = "Page Inspector...",
                ToolBarText = "Page Inspector",
                Image = Icons.Get("document-new")
            };
            pageInspectorCommand.Executed += OnPageInspector;

            var notebookInspectorCommand = new Command
            {
                MenuText = "Notebook Inspector...",
                ToolBarText = "Notebook Inspector",
                Image = Icons.Get("dictionary")
            };
            pageInspectorCommand.Executed += OnNotebookInspector;

            // Commands - Language
            var charactersCommand = new Command
            {
                MenuText = "Characters...",
                ToolBarText = "Characters",
                Image = Icons.Get("language")
            };
            charactersCommand.Executed += OnCharacters;

            var dictionaryCommand = new Command
            {
                MenuText = "Dictionary...",
                ToolBarText = "Dictionary",
                Image = Icons.Get("dictionary")
            };
            dictionaryCommand.Executed += OnCharacters;

            // Menu
            Menu = new MenuBar
            {
                Items =
                {
                    new ButtonMenuItem {Text = "&File", Items = {
                        newNotebookCommand, openNotebookCommand,
                        saveNotebookCommand
                    }},
                    new ButtonMenuItem { Text = "&Edit", Items = {
                        undoCommand, redoCommand,
                        new SeparatorMenuItem(),
                        cutCommand, copyCommand, pasteCommand
                    }},
                    new ButtonMenuItem { Text = "&Notebook", Items = {
                        pageInspectorCommand
                    }},
                    new ButtonMenuItem { Text = "&Language", Items = {
                        charactersCommand, dictionaryCommand
                    }}
                },
                ApplicationItems =
                {
                    prefrencesCommand
                },
                QuitItem = quitCommand,
                AboutItem = aboutCommand
            };

            // Toolbar		
            ToolBar = new ToolBar
            {
                Items = {
                        newNotebookCommand, openNotebookCommand, saveNotebookCommand,
                        new SeparatorToolItem() { Type = SeparatorToolItemType.FlexibleSpace },
                        charactersCommand, dictionaryCommand
                    }
            };

            // Inspectors
            PageInspector.ValueChanged += OnPageInspectorValueChanged;
            PageInspector.DeleteModel += OnDeletePage;

            // Load document
            PageInspector.IsRefreshing = true;
            var testStr = "";
            Document.Title = "Test Document";
            for (int i = 0; i < 5; i++)
            {
                testStr += "<b>Hello World</b> #" + i + "\n";
                Document.Pages.Add(new Page(Document)
                {
                    Title = "Page " + i,
                    Content = testStr
                });
            }

            LoadPages();
            PageInspector.IsRefreshing = false;
        }
        #endregion

        public void LoadPages()
        {
            PageSelectorItems.Clear();
            var pageIcon = Icons.Get("filetype-text");

            foreach (Page page in Document.Pages)
            {
                var notebookPagesTreeItem = new TreeGridItem()
                {
                    Expanded = false,
                    Values = new object[] { pageIcon, page.Title },
                };

                PageSelectorItems.Add(notebookPagesTreeItem);
            }

            PageSelector.DataStore = PageSelectorItems;

            if (PageSelectorItems.Count > 0 && Loaded)
                PageSelector.SelectedRow = 0;

            UpdateAppTitle();
        }

        public void UpdateAppTitle()
        {
            var pageIndex = PageSelector.SelectedRow;
            var pageName = (pageIndex == -1) ? "" : " (" + Document.Pages[pageIndex].Title + ")";
            if (!string.IsNullOrEmpty(Document.Title))
                Title = string.Format("{0} - {1}{2}", appTitle, Document.Title, pageName);
            else
                Title = appTitle;
        }

        public void DeletePage()
        {

        }

        /**
         * Event handlers
         */

        // File Menu
        FileFilter[] filters = {
            new FileFilter("Thorn Writer Notebook (*.thw)", ".thw")
        };

        public void OnNewNotebook(object sender, EventArgs e)
        {

        }

        public void OnOpenNotebook(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();

            foreach (var filter in filters)
                openDialog.Filters.Add(filter);

            openDialog.CurrentFilterIndex = 0;

            if (openDialog.ShowDialog(this) == DialogResult.Ok)
            {
                Document.Open(openDialog.FileName);
                LoadPages();
            }
        }

        public void OnSaveNotebook(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();

            foreach (var filter in filters)
                saveDialog.Filters.Add(filter);

            saveDialog.CurrentFilterIndex = 0;

            if (saveDialog.ShowDialog(this) == DialogResult.Ok)
            {
                Document.Save(saveDialog.FileName);
                Document.Modified = false;
            }
        }

        // Edit Menu
        public void OnUndo(object sender, EventArgs e)
        {

        }

        public void OnRedo(object sender, EventArgs e)
        {

        }

        public void OnCut(object sender, EventArgs e)
        {

        }

        public void OnCopy(object sender, EventArgs e)
        {

        }

        public void OnPaste(object sender, EventArgs e)
        {

        }

        // Notebook Menu
        public void OnPageInspector(object sender, EventArgs e)
        {
            PageInspector.Show(this);
        }

        public void OnNotebookInspector(object sender, EventArgs e)
        {
            //   NotebookInspector.Show(this);
        }

        // Language Menu
        public void OnCharacters(object sender, EventArgs e)
        {

        }

        // Application Menu
        public void OnPreferences(object sender, EventArgs e)
        {
            if (!PreferencesDialog.Visible)
                PreferencesDialog.Show();
        }

        public void OnQuit(object sender, EventArgs e)
        {
            Application.Instance.Quit();
        }

        public void OnAbout(object sender, EventArgs e)
        {
            var aboutDialog = new AboutDialog
            {
                ProgramName = "Thorn Writer",
                Version = "Version " + AppInfo.GetFormattedVersion(),
                Copyright = string.Format("© 2012-{0} Ian Martinez", DateTime.Now.Year.ToString()),
                ProgramDescription = "A editor for linguistics.",
                License = AppInfo.GetLicense()
            };
            aboutDialog.ShowDialog(this);
        }

        public void OnDeletePage(object sender, EventArgs e)
        {
            if (CurrentPage != null)
            {
                var deletedIndex = CurrentPage.Index;
                PageSelectorItems.RemoveAt(deletedIndex);
                Document.Pages.RemoveAt(deletedIndex);
                PageSelector.SelectedRow = -1;
                PageSelector.ReloadData();
                UpdateAppTitle();
                PageInspector.Model = null;
            }
        }

        public void OnChangeSelection(object sender, EventArgs e)
        {
            if (CurrentPage != null)
            {
                PageEditor.Content = CurrentPage.Content;
                PageInspector.Model = CurrentPage;
                MainSplitter.Panel2.Visible = true;
            }
            else
            {
                PageEditor.Content = "";
                PageInspector.Model = null;
                MainSplitter.Panel2.Visible = false;
            }

            UpdateAppTitle();
        }

        public void OnContentChanged(object sender, EventArgs e)
        {
            if (CurrentPage != null)
                CurrentPage.Content = PageEditor.Content;
        }

        public void OnChangePageTitle(object sender, GridViewCellEventArgs e)
        {
            if (CurrentPage != null)
            {
                var item = (TreeGridItem)e.Item;
                /*
                 * icon = item.Values[0]
                 * text = item.Values[1]
                 */
                var newTitle = item.Values[1].ToString();

                // Change page title
                CurrentPage.Title = newTitle;
                UpdateAppTitle();
                PageSelector.ReloadItem(item);
                PageInspector.RefreshValue(PageInspectorValue.Title);
            }
        }

        private void OnPageInspectorValueChanged(object sender, InspectorValueChangedEventArgs<PageInspectorValue> e)
        {
            switch (e.TargetValue)
            {
                case PageInspectorValue.Title:
                    if (CurrentPage != null)
                    {
                        CurrentPage.Title = (string)e.NewValue;
                        (PageSelectorItems[CurrentPage.Index] as TreeGridItem).Values[1] = e.NewValue;
                        PageSelector.ReloadData();
                        PageSelector.ReloadItem(PageSelectorItems[CurrentPage.Index]);
                        UpdateAppTitle();
                    }
                    break;
                case PageInspectorValue.Index:
                    if (CurrentPage != null)
                    {
                        var oldIndex = int.Parse(e.OldValue.ToString());
                        var newIndex = int.Parse(e.NewValue.ToString());

                        CurrentPage.Index = newIndex;
                        var pageRow = PageSelectorItems[oldIndex];
                        PageSelectorItems.Remove(pageRow);
                        PageSelectorItems.Insert(newIndex, pageRow);
                        PageSelector.ReloadData();
                        PageSelector.SelectedRow = newIndex;
                    }
                    break;
                case PageInspectorValue.Notes:
                    if (CurrentPage != null)
                        CurrentPage.Notes = e.NewValue.ToString();

                    break;
            }
        }
    }
}
