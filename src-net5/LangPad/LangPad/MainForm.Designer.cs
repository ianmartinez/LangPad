
namespace LangPad
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FindReplaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MainSplitter = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.EditorPreviewSplitter = new System.Windows.Forms.SplitContainer();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).BeginInit();
            this.MainSplitter.Panel1.SuspendLayout();
            this.MainSplitter.Panel2.SuspendLayout();
            this.MainSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditorPreviewSplitter)).BeginInit();
            this.EditorPreviewSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.InsertMenuItem,
            this.ToolsMenuItem,
            this.HelpMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(916, 28);
            this.MainMenu.TabIndex = 0;
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.toolStripSeparator,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.toolStripSeparator1,
            this.PrintMenuItem,
            this.toolStripSeparator2,
            this.ExitMenuItem});
            this.FileMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileMenuItem.Text = "&File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NewMenuItem.Image")));
            this.NewMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewMenuItem.Size = new System.Drawing.Size(237, 30);
            this.NewMenuItem.Text = "&New";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenMenuItem.Image")));
            this.OpenMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OpenMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenuItem.Size = new System.Drawing.Size(237, 30);
            this.OpenMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(234, 6);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveMenuItem.Image")));
            this.SaveMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuItem.Size = new System.Drawing.Size(237, 30);
            this.SaveMenuItem.Text = "&Save";
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsMenuItem.Image")));
            this.SaveAsMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsMenuItem.Size = new System.Drawing.Size(237, 30);
            this.SaveAsMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // PrintMenuItem
            // 
            this.PrintMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintMenuItem.Image")));
            this.PrintMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PrintMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintMenuItem.Name = "PrintMenuItem";
            this.PrintMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintMenuItem.Size = new System.Drawing.Size(237, 30);
            this.PrintMenuItem.Text = "&Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitMenuItem.Image")));
            this.ExitMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ExitMenuItem.Size = new System.Drawing.Size(237, 30);
            this.ExitMenuItem.Text = "E&xit";
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoMenuItem,
            this.RedoMenuItem,
            this.toolStripSeparator3,
            this.CutMenuItem,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.toolStripSeparator4,
            this.FindReplaceMenuItem,
            this.toolStripSeparator6,
            this.SelectAllMenuItem});
            this.EditMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(49, 24);
            this.EditMenuItem.Text = "&Edit";
            // 
            // UndoMenuItem
            // 
            this.UndoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UndoMenuItem.Image")));
            this.UndoMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UndoMenuItem.Name = "UndoMenuItem";
            this.UndoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoMenuItem.Size = new System.Drawing.Size(232, 30);
            this.UndoMenuItem.Text = "&Undo";
            // 
            // RedoMenuItem
            // 
            this.RedoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RedoMenuItem.Image")));
            this.RedoMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RedoMenuItem.Name = "RedoMenuItem";
            this.RedoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoMenuItem.Size = new System.Drawing.Size(232, 30);
            this.RedoMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(229, 6);
            // 
            // CutMenuItem
            // 
            this.CutMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CutMenuItem.Image")));
            this.CutMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CutMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutMenuItem.Name = "CutMenuItem";
            this.CutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutMenuItem.Size = new System.Drawing.Size(232, 30);
            this.CutMenuItem.Text = "Cu&t";
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CopyMenuItem.Image")));
            this.CopyMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CopyMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyMenuItem.Size = new System.Drawing.Size(232, 30);
            this.CopyMenuItem.Text = "&Copy";
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PasteMenuItem.Image")));
            this.PasteMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PasteMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteMenuItem.Size = new System.Drawing.Size(232, 30);
            this.PasteMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(229, 6);
            // 
            // FindReplaceMenuItem
            // 
            this.FindReplaceMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FindReplaceMenuItem.Name = "FindReplaceMenuItem";
            this.FindReplaceMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindReplaceMenuItem.Size = new System.Drawing.Size(232, 30);
            this.FindReplaceMenuItem.Text = "Find/Replace";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(229, 6);
            // 
            // SelectAllMenuItem
            // 
            this.SelectAllMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SelectAllMenuItem.Image")));
            this.SelectAllMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SelectAllMenuItem.Name = "SelectAllMenuItem";
            this.SelectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllMenuItem.Size = new System.Drawing.Size(232, 30);
            this.SelectAllMenuItem.Text = "Select &All";
            // 
            // InsertMenuItem
            // 
            this.InsertMenuItem.Name = "InsertMenuItem";
            this.InsertMenuItem.Size = new System.Drawing.Size(59, 24);
            this.InsertMenuItem.Text = "&Insert";
            // 
            // ToolsMenuItem
            // 
            this.ToolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.ToolsMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolsMenuItem.Name = "ToolsMenuItem";
            this.ToolsMenuItem.Size = new System.Drawing.Size(58, 24);
            this.ToolsMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.HelpMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(55, 24);
            this.HelpMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Location = new System.Drawing.Point(0, 28);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(916, 25);
            this.MainToolStrip.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 672);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(916, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "MainStatusStrip";
            // 
            // MainSplitter
            // 
            this.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitter.Location = new System.Drawing.Point(0, 53);
            this.MainSplitter.Name = "MainSplitter";
            // 
            // MainSplitter.Panel1
            // 
            this.MainSplitter.Panel1.Controls.Add(this.button1);
            // 
            // MainSplitter.Panel2
            // 
            this.MainSplitter.Panel2.Controls.Add(this.EditorPreviewSplitter);
            this.MainSplitter.Size = new System.Drawing.Size(916, 619);
            this.MainSplitter.SplitterDistance = 250;
            this.MainSplitter.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditorPreviewSplitter
            // 
            this.EditorPreviewSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorPreviewSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.EditorPreviewSplitter.Location = new System.Drawing.Point(0, 0);
            this.EditorPreviewSplitter.Name = "EditorPreviewSplitter";
            this.EditorPreviewSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.EditorPreviewSplitter.Size = new System.Drawing.Size(662, 619);
            this.EditorPreviewSplitter.SplitterDistance = 218;
            this.EditorPreviewSplitter.SplitterWidth = 6;
            this.EditorPreviewSplitter.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 694);
            this.Controls.Add(this.MainSplitter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "LangPad 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainSplitter.Panel1.ResumeLayout(false);
            this.MainSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).EndInit();
            this.MainSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditorPreviewSplitter)).EndInit();
            this.EditorPreviewSplitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PrintMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem SelectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem FindReplaceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertMenuItem;
        private System.Windows.Forms.SplitContainer MainSplitter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer EditorPreviewSplitter;
    }
}

