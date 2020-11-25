using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangPad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // File event handlers
            FileMenuItem.Click += FileMenuItem_Click;
            OpenMenuItem.Click += OpenMenuItem_Click;
            SaveMenuItem.Click += SaveMenuItem_Click;
            SaveAsMenuItem.Click += SaveAsMenuItem_Click;
            PrintMenuItem.Click += PrintMenuItem_Click;
            ExitMenuItem.Click += ExitMenuItem_Click;

            // Edit event handlers
            UndoMenuItem.Click += UndoMenuItem_Click;
            RedoMenuItem.Click += RedoMenuItem_Click;
            CutMenuItem.Click += CutMenuItem_Click;
            CopyMenuItem.Click += CopyMenuItem_Click;
            PasteMenuItem.Click += PasteMenuItem_Click;
            FindReplaceMenuItem.Click += FindReplaceMenuItem_Click;
            SelectAllMenuItem.Click += SelectAllMenuItem_Click;

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var editor = new Editor.Editor();
            editor.Dock = DockStyle.Fill;
            EditorPreviewSplitter.Panel2.Controls.Add(editor);
        }

        #region "File"
        private void FileMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PrintMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region "Edit"
        private void UndoMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void RedoMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void CutMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void FindReplaceMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void SelectAllMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region "View"
        #endregion

        #region "Notebook"
        #endregion

        #region "Linguistics"
        #endregion

        #region "Insert"
        #endregion

        #region "Tools"
        #endregion

        #region "Help"
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
