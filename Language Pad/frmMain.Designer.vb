<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.dlgOpenImage = New System.Windows.Forms.OpenFileDialog()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.tcSymbols = New System.Windows.Forms.TabControl()
        Me.ConsonantsTabPage = New System.Windows.Forms.TabPage()
        Me.ConsonantsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AffricatesTabPage = New System.Windows.Forms.TabPage()
        Me.AffricatesLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.VowelsTabPage = New System.Windows.Forms.TabPage()
        Me.VowelsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AccentsTabPage = New System.Windows.Forms.TabPage()
        Me.AccentsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToneIntonationTabPage = New System.Windows.Forms.TabPage()
        Me.ToneIntonationLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.OtherTabPage = New System.Windows.Forms.TabPage()
        Me.OtherLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CommonTabPage = New System.Windows.Forms.TabPage()
        Me.CommonLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CustomTabPage = New System.Windows.Forms.TabPage()
        Me.CustomLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.dlgSavePage = New System.Windows.Forms.SaveFileDialog()
        Me.dlgPrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.dlgPrint = New System.Windows.Forms.PrintDialog()
        Me.dlgOpenPage = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSetup = New System.Windows.Forms.PageSetupDialog()
        Me.pdMain = New System.Drawing.Printing.PrintDocument()
        Me.cmsMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeselectAllContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.tcNotebook = New System.Windows.Forms.TabControl()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.dlgSaveNotebook = New System.Windows.Forms.SaveFileDialog()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.dlgSaveImage = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.DataToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CharCountToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.WordCountToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblPageCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ThemeCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.pnlFindReplace = New Tundra.StylizedPanel()
        Me.btnFindNext = New Tundra.StylizedButton()
        Me.btnReplaceAll = New Tundra.StylizedButton()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnReplace = New Tundra.StylizedButton()
        Me.btnFind = New Tundra.StylizedButton()
        Me.FileToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PastePlainToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RedoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FontToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FontToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BoldToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ItalicToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UnderlineToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StrikeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlignLeftToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlignCenterToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlignRightToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.IndentToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.IndentToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripSeparator()
        Me.RTFEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PastePlainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem25 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem27 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripSeparator()
        Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinguisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SymbolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomSymbolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccentMarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem30 = New System.Windows.Forms.ToolStripSeparator()
        Me.DictionaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertBulletsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveBulletsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripSeparator()
        Me.DefaultStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem31 = New System.Windows.Forms.ToolStripSeparator()
        Me.SubscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuperscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaselineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem32 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicatePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem29 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenamePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotebookEditor1 = New Language_Pad.NotebookEditor()
        Me.LinguisticsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SymbolsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AccentMarkToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomSymbolsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tcSymbols.SuspendLayout()
        Me.ConsonantsTabPage.SuspendLayout()
        Me.AffricatesTabPage.SuspendLayout()
        Me.VowelsTabPage.SuspendLayout()
        Me.AccentsTabPage.SuspendLayout()
        Me.ToneIntonationTabPage.SuspendLayout()
        Me.OtherTabPage.SuspendLayout()
        Me.CommonTabPage.SuspendLayout()
        Me.CustomTabPage.SuspendLayout()
        Me.cmsMain.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.DataToolStrip.SuspendLayout()
        Me.pnlFindReplace.SuspendLayout()
        Me.FileToolStrip.SuspendLayout()
        Me.FontToolStrip.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.LinguisticsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'dlgOpenImage
        '
        Me.dlgOpenImage.Filter = "Image files(*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif|JPEG f" &
    "iles (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif" &
    "|All files (*.*)|*.*"
        '
        'dlgFont
        '
        Me.dlgFont.ShowColor = True
        '
        'tcSymbols
        '
        Me.tcSymbols.Controls.Add(Me.ConsonantsTabPage)
        Me.tcSymbols.Controls.Add(Me.AffricatesTabPage)
        Me.tcSymbols.Controls.Add(Me.VowelsTabPage)
        Me.tcSymbols.Controls.Add(Me.AccentsTabPage)
        Me.tcSymbols.Controls.Add(Me.ToneIntonationTabPage)
        Me.tcSymbols.Controls.Add(Me.OtherTabPage)
        Me.tcSymbols.Controls.Add(Me.CommonTabPage)
        Me.tcSymbols.Controls.Add(Me.CustomTabPage)
        Me.tcSymbols.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcSymbols.Location = New System.Drawing.Point(0, 4)
        Me.tcSymbols.Margin = New System.Windows.Forms.Padding(4)
        Me.tcSymbols.Name = "tcSymbols"
        Me.tcSymbols.SelectedIndex = 0
        Me.tcSymbols.Size = New System.Drawing.Size(1910, 157)
        Me.tcSymbols.TabIndex = 72
        '
        'ConsonantsTabPage
        '
        Me.ConsonantsTabPage.Controls.Add(Me.ConsonantsLayoutPanel)
        Me.ConsonantsTabPage.Location = New System.Drawing.Point(8, 39)
        Me.ConsonantsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsonantsTabPage.Name = "ConsonantsTabPage"
        Me.ConsonantsTabPage.Size = New System.Drawing.Size(1894, 110)
        Me.ConsonantsTabPage.TabIndex = 0
        Me.ConsonantsTabPage.Text = "Consonants"
        Me.ConsonantsTabPage.UseVisualStyleBackColor = True
        '
        'ConsonantsLayoutPanel
        '
        Me.ConsonantsLayoutPanel.AutoScroll = True
        Me.ConsonantsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(15, 5)
        Me.ConsonantsLayoutPanel.AutoSize = True
        Me.ConsonantsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsonantsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ConsonantsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ConsonantsLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.ConsonantsLayoutPanel.Name = "ConsonantsLayoutPanel"
        Me.ConsonantsLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.ConsonantsLayoutPanel.Size = New System.Drawing.Size(1894, 110)
        Me.ConsonantsLayoutPanel.TabIndex = 7
        '
        'AffricatesTabPage
        '
        Me.AffricatesTabPage.Controls.Add(Me.AffricatesLayoutPanel)
        Me.AffricatesTabPage.Location = New System.Drawing.Point(8, 39)
        Me.AffricatesTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.AffricatesTabPage.Name = "AffricatesTabPage"
        Me.AffricatesTabPage.Size = New System.Drawing.Size(1894, 110)
        Me.AffricatesTabPage.TabIndex = 5
        Me.AffricatesTabPage.Text = "Affricates"
        Me.AffricatesTabPage.UseVisualStyleBackColor = True
        '
        'AffricatesLayoutPanel
        '
        Me.AffricatesLayoutPanel.AutoScroll = True
        Me.AffricatesLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AffricatesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AffricatesLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.AffricatesLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AffricatesLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.AffricatesLayoutPanel.Name = "AffricatesLayoutPanel"
        Me.AffricatesLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.AffricatesLayoutPanel.Size = New System.Drawing.Size(1894, 110)
        Me.AffricatesLayoutPanel.TabIndex = 8
        '
        'VowelsTabPage
        '
        Me.VowelsTabPage.Controls.Add(Me.VowelsLayoutPanel)
        Me.VowelsTabPage.Location = New System.Drawing.Point(8, 39)
        Me.VowelsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.VowelsTabPage.Name = "VowelsTabPage"
        Me.VowelsTabPage.Size = New System.Drawing.Size(1894, 110)
        Me.VowelsTabPage.TabIndex = 1
        Me.VowelsTabPage.Text = "Vowels"
        Me.VowelsTabPage.UseVisualStyleBackColor = True
        '
        'VowelsLayoutPanel
        '
        Me.VowelsLayoutPanel.AutoScroll = True
        Me.VowelsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.VowelsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VowelsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.VowelsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.VowelsLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.VowelsLayoutPanel.Name = "VowelsLayoutPanel"
        Me.VowelsLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.VowelsLayoutPanel.Size = New System.Drawing.Size(1894, 110)
        Me.VowelsLayoutPanel.TabIndex = 8
        '
        'AccentsTabPage
        '
        Me.AccentsTabPage.Controls.Add(Me.AccentsLayoutPanel)
        Me.AccentsTabPage.Location = New System.Drawing.Point(8, 39)
        Me.AccentsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.AccentsTabPage.Name = "AccentsTabPage"
        Me.AccentsTabPage.Size = New System.Drawing.Size(1894, 110)
        Me.AccentsTabPage.TabIndex = 3
        Me.AccentsTabPage.Text = "Accents"
        Me.AccentsTabPage.UseVisualStyleBackColor = True
        '
        'AccentsLayoutPanel
        '
        Me.AccentsLayoutPanel.AutoScroll = True
        Me.AccentsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AccentsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccentsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.AccentsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AccentsLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.AccentsLayoutPanel.Name = "AccentsLayoutPanel"
        Me.AccentsLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.AccentsLayoutPanel.Size = New System.Drawing.Size(1894, 110)
        Me.AccentsLayoutPanel.TabIndex = 9
        '
        'ToneIntonationTabPage
        '
        Me.ToneIntonationTabPage.Controls.Add(Me.ToneIntonationLayoutPanel)
        Me.ToneIntonationTabPage.Location = New System.Drawing.Point(8, 39)
        Me.ToneIntonationTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.ToneIntonationTabPage.Name = "ToneIntonationTabPage"
        Me.ToneIntonationTabPage.Size = New System.Drawing.Size(1894, 110)
        Me.ToneIntonationTabPage.TabIndex = 4
        Me.ToneIntonationTabPage.Text = "Tone & Intonation"
        Me.ToneIntonationTabPage.UseVisualStyleBackColor = True
        '
        'ToneIntonationLayoutPanel
        '
        Me.ToneIntonationLayoutPanel.AutoScroll = True
        Me.ToneIntonationLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.ToneIntonationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToneIntonationLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ToneIntonationLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ToneIntonationLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.ToneIntonationLayoutPanel.Name = "ToneIntonationLayoutPanel"
        Me.ToneIntonationLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.ToneIntonationLayoutPanel.Size = New System.Drawing.Size(1894, 110)
        Me.ToneIntonationLayoutPanel.TabIndex = 10
        '
        'OtherTabPage
        '
        Me.OtherTabPage.Controls.Add(Me.OtherLayoutPanel)
        Me.OtherTabPage.Location = New System.Drawing.Point(8, 39)
        Me.OtherTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.OtherTabPage.Name = "OtherTabPage"
        Me.OtherTabPage.Size = New System.Drawing.Size(1894, 110)
        Me.OtherTabPage.TabIndex = 2
        Me.OtherTabPage.Text = "Other"
        Me.OtherTabPage.UseVisualStyleBackColor = True
        '
        'OtherLayoutPanel
        '
        Me.OtherLayoutPanel.AutoScroll = True
        Me.OtherLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.OtherLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OtherLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.OtherLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.OtherLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.OtherLayoutPanel.Name = "OtherLayoutPanel"
        Me.OtherLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.OtherLayoutPanel.Size = New System.Drawing.Size(1894, 110)
        Me.OtherLayoutPanel.TabIndex = 8
        '
        'CommonTabPage
        '
        Me.CommonTabPage.Controls.Add(Me.CommonLayoutPanel)
        Me.CommonTabPage.Location = New System.Drawing.Point(8, 39)
        Me.CommonTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.CommonTabPage.Name = "CommonTabPage"
        Me.CommonTabPage.Size = New System.Drawing.Size(1894, 110)
        Me.CommonTabPage.TabIndex = 7
        Me.CommonTabPage.Text = "Common"
        Me.CommonTabPage.UseVisualStyleBackColor = True
        '
        'CommonLayoutPanel
        '
        Me.CommonLayoutPanel.AutoScroll = True
        Me.CommonLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.CommonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommonLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.CommonLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.CommonLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.CommonLayoutPanel.Name = "CommonLayoutPanel"
        Me.CommonLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.CommonLayoutPanel.Size = New System.Drawing.Size(1894, 110)
        Me.CommonLayoutPanel.TabIndex = 9
        '
        'CustomTabPage
        '
        Me.CustomTabPage.Controls.Add(Me.CustomLayoutPanel)
        Me.CustomTabPage.Location = New System.Drawing.Point(8, 39)
        Me.CustomTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomTabPage.Name = "CustomTabPage"
        Me.CustomTabPage.Size = New System.Drawing.Size(1894, 110)
        Me.CustomTabPage.TabIndex = 6
        Me.CustomTabPage.Text = "Custom"
        Me.CustomTabPage.UseVisualStyleBackColor = True
        '
        'CustomLayoutPanel
        '
        Me.CustomLayoutPanel.AutoScroll = True
        Me.CustomLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.CustomLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.CustomLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.CustomLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.CustomLayoutPanel.Name = "CustomLayoutPanel"
        Me.CustomLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.CustomLayoutPanel.Size = New System.Drawing.Size(1894, 110)
        Me.CustomLayoutPanel.TabIndex = 9
        '
        'dlgSavePage
        '
        Me.dlgSavePage.Filter = "Rich text file (*.rtf)|*.rtf|Text file (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'dlgPrintPreview
        '
        Me.dlgPrintPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintPreview.Enabled = True
        Me.dlgPrintPreview.Icon = CType(resources.GetObject("dlgPrintPreview.Icon"), System.Drawing.Icon)
        Me.dlgPrintPreview.Name = "dlgPrintPreview"
        Me.dlgPrintPreview.Visible = False
        '
        'dlgPrint
        '
        Me.dlgPrint.AllowSelection = True
        Me.dlgPrint.PrintToFile = True
        Me.dlgPrint.UseEXDialog = True
        '
        'dlgOpenPage
        '
        Me.dlgOpenPage.Filter = "Text files(*.rtf;*.txt)|*.rtf;*.txt|Rich text files (*.rtf)|*.rtf|Text files (*.t" &
    "xt)|*.txt|All files (*.*)|*.*"
        '
        'pdMain
        '
        '
        'cmsMain
        '
        Me.cmsMain.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.cmsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyContextMenuItem, Me.PasteContextMenuItem, Me.CutContextMenuItem, Me.ToolStripSeparator1, Me.SelectAllContextMenuItem, Me.DeselectAllContextMenuItem})
        Me.cmsMain.Name = "cmsMain"
        Me.cmsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.cmsMain.Size = New System.Drawing.Size(224, 190)
        '
        'CopyContextMenuItem
        '
        Me.CopyContextMenuItem.Image = CType(resources.GetObject("CopyContextMenuItem.Image"), System.Drawing.Image)
        Me.CopyContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyContextMenuItem.Name = "CopyContextMenuItem"
        Me.CopyContextMenuItem.Size = New System.Drawing.Size(223, 36)
        Me.CopyContextMenuItem.Text = "Copy"
        '
        'PasteContextMenuItem
        '
        Me.PasteContextMenuItem.Image = CType(resources.GetObject("PasteContextMenuItem.Image"), System.Drawing.Image)
        Me.PasteContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteContextMenuItem.Name = "PasteContextMenuItem"
        Me.PasteContextMenuItem.Size = New System.Drawing.Size(223, 36)
        Me.PasteContextMenuItem.Text = "Paste"
        '
        'CutContextMenuItem
        '
        Me.CutContextMenuItem.Image = CType(resources.GetObject("CutContextMenuItem.Image"), System.Drawing.Image)
        Me.CutContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutContextMenuItem.Name = "CutContextMenuItem"
        Me.CutContextMenuItem.Size = New System.Drawing.Size(223, 36)
        Me.CutContextMenuItem.Text = "Cut"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(220, 6)
        '
        'SelectAllContextMenuItem
        '
        Me.SelectAllContextMenuItem.Image = CType(resources.GetObject("SelectAllContextMenuItem.Image"), System.Drawing.Image)
        Me.SelectAllContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SelectAllContextMenuItem.Name = "SelectAllContextMenuItem"
        Me.SelectAllContextMenuItem.Size = New System.Drawing.Size(223, 36)
        Me.SelectAllContextMenuItem.Text = "Select All"
        '
        'DeselectAllContextMenuItem
        '
        Me.DeselectAllContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeselectAllContextMenuItem.Name = "DeselectAllContextMenuItem"
        Me.DeselectAllContextMenuItem.Size = New System.Drawing.Size(223, 36)
        Me.DeselectAllContextMenuItem.Text = "Deselect All"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 68)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tcSymbols)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1910, 1175)
        Me.SplitContainer1.SplitterDistance = 161
        Me.SplitContainer1.TabIndex = 73
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.tcNotebook)
        Me.SplitContainer2.Panel1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.StylizedPanel1)
        Me.SplitContainer2.Panel2MinSize = 235
        Me.SplitContainer2.Size = New System.Drawing.Size(1910, 1010)
        Me.SplitContainer2.SplitterDistance = 1366
        Me.SplitContainer2.TabIndex = 1
        '
        'tcNotebook
        '
        Me.tcNotebook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcNotebook.Location = New System.Drawing.Point(0, 4)
        Me.tcNotebook.Margin = New System.Windows.Forms.Padding(4)
        Me.tcNotebook.Name = "tcNotebook"
        Me.tcNotebook.SelectedIndex = 0
        Me.tcNotebook.Size = New System.Drawing.Size(1366, 1006)
        Me.tcNotebook.TabIndex = 73
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.AutoScroll = True
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.NotebookEditor1)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Size = New System.Drawing.Size(540, 1010)
        Me.StylizedPanel1.Style = "Colors=~245|~245" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight" &
    " Color=$0"
        Me.StylizedPanel1.TabIndex = 13
        '
        'dlgSaveNotebook
        '
        Me.dlgSaveNotebook.Filter = "Notebook file (*.nt)|*.nt|Zip file (*.zip)|*.nt|All files (*.*)|*.*"
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Notebook file (*.nt)|*.nt|Zip files (*.zip)|*.zip|All files (*.*)|*.*"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Notebook file (*.nt)|*.nt|Zip files (*.zip)|*.zip|All files (*.*)|*.*"
        '
        'dlgSaveImage
        '
        Me.dlgSaveImage.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.DataToolStrip)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.pnlFindReplace)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1910, 1243)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 40)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1910, 1323)
        Me.ToolStripContainer1.TabIndex = 74
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.LinguisticsToolStrip)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.FileToolStrip)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.FontToolStrip)
        '
        'DataToolStrip
        '
        Me.DataToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.DataToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DataToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.DataToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CharCountToolStripLabel, Me.ToolStripSeparator10, Me.WordCountToolStripLabel, Me.ToolStripSeparator11, Me.lblPageCount, Me.ToolStripSeparator12, Me.ToolStripLabel1, Me.ThemeCombo})
        Me.DataToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DataToolStrip.Name = "DataToolStrip"
        Me.DataToolStrip.Size = New System.Drawing.Size(1910, 40)
        Me.DataToolStrip.Stretch = True
        Me.DataToolStrip.TabIndex = 2
        '
        'CharCountToolStripLabel
        '
        Me.CharCountToolStripLabel.Name = "CharCountToolStripLabel"
        Me.CharCountToolStripLabel.Size = New System.Drawing.Size(213, 37)
        Me.CharCountToolStripLabel.Text = "Character Count: 0"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 40)
        '
        'WordCountToolStripLabel
        '
        Me.WordCountToolStripLabel.Name = "WordCountToolStripLabel"
        Me.WordCountToolStripLabel.Size = New System.Drawing.Size(169, 37)
        Me.WordCountToolStripLabel.Text = "Word Count: 0"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 40)
        '
        'lblPageCount
        '
        Me.lblPageCount.Name = "lblPageCount"
        Me.lblPageCount.Size = New System.Drawing.Size(163, 37)
        Me.lblPageCount.Text = "Page Count: 0"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(94, 37)
        Me.ToolStripLabel1.Text = "Theme:"
        '
        'ThemeCombo
        '
        Me.ThemeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ThemeCombo.Items.AddRange(New Object() {"Ice", "Night", "Luna", "Olive"})
        Me.ThemeCombo.Name = "ThemeCombo"
        Me.ThemeCombo.Size = New System.Drawing.Size(145, 40)
        '
        'pnlFindReplace
        '
        Me.pnlFindReplace.BackColor = System.Drawing.Color.Transparent
        Me.pnlFindReplace.Controls.Add(Me.btnFindNext)
        Me.pnlFindReplace.Controls.Add(Me.btnReplaceAll)
        Me.pnlFindReplace.Controls.Add(Me.txtReplace)
        Me.pnlFindReplace.Controls.Add(Me.Label18)
        Me.pnlFindReplace.Controls.Add(Me.txtFind)
        Me.pnlFindReplace.Controls.Add(Me.Label17)
        Me.pnlFindReplace.Controls.Add(Me.btnReplace)
        Me.pnlFindReplace.Controls.Add(Me.btnFind)
        Me.pnlFindReplace.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFindReplace.Location = New System.Drawing.Point(0, 0)
        Me.pnlFindReplace.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFindReplace.Name = "pnlFindReplace"
        Me.pnlFindReplace.Size = New System.Drawing.Size(1910, 68)
        Me.pnlFindReplace.Style = "Colors=~239|~235" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highligh" &
    "t Color=$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.pnlFindReplace.TabIndex = 72
        Me.pnlFindReplace.Visible = False
        '
        'btnFindNext
        '
        Me.btnFindNext.BackColor = System.Drawing.Color.Transparent
        Me.btnFindNext.BackgroundImage = CType(resources.GetObject("btnFindNext.BackgroundImage"), System.Drawing.Image)
        Me.btnFindNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFindNext.FlatAppearance.BorderSize = 0
        Me.btnFindNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFindNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindNext.ForeColor = System.Drawing.Color.Black
        Me.btnFindNext.Location = New System.Drawing.Point(797, 10)
        Me.btnFindNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnFindNext.Size = New System.Drawing.Size(155, 46)
        Me.btnFindNext.Style = resources.GetString("btnFindNext.Style")
        Me.btnFindNext.TabIndex = 69
        Me.btnFindNext.Text = " Find Next"
        Me.btnFindNext.UseCompatibleTextRendering = True
        Me.btnFindNext.UseVisualStyleBackColor = False
        '
        'btnReplaceAll
        '
        Me.btnReplaceAll.BackColor = System.Drawing.Color.Transparent
        Me.btnReplaceAll.BackgroundImage = CType(resources.GetObject("btnReplaceAll.BackgroundImage"), System.Drawing.Image)
        Me.btnReplaceAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReplaceAll.FlatAppearance.BorderSize = 0
        Me.btnReplaceAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReplaceAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReplaceAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReplaceAll.ForeColor = System.Drawing.Color.Black
        Me.btnReplaceAll.Location = New System.Drawing.Point(1123, 10)
        Me.btnReplaceAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnReplaceAll.Size = New System.Drawing.Size(155, 46)
        Me.btnReplaceAll.Style = resources.GetString("btnReplaceAll.Style")
        Me.btnReplaceAll.TabIndex = 71
        Me.btnReplaceAll.Text = "Replace All"
        Me.btnReplaceAll.UseCompatibleTextRendering = True
        Me.btnReplaceAll.UseVisualStyleBackColor = False
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(406, 18)
        Me.txtReplace.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(220, 31)
        Me.txtReplace.TabIndex = 67
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(301, 21)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 25)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "Replace:"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(81, 18)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(212, 31)
        Me.txtFind.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 21)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 25)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Find:"
        '
        'btnReplace
        '
        Me.btnReplace.BackColor = System.Drawing.Color.Transparent
        Me.btnReplace.BackgroundImage = CType(resources.GetObject("btnReplace.BackgroundImage"), System.Drawing.Image)
        Me.btnReplace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReplace.FlatAppearance.BorderSize = 0
        Me.btnReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReplace.ForeColor = System.Drawing.Color.Black
        Me.btnReplace.Location = New System.Drawing.Point(960, 10)
        Me.btnReplace.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnReplace.Size = New System.Drawing.Size(155, 46)
        Me.btnReplace.Style = resources.GetString("btnReplace.Style")
        Me.btnReplace.TabIndex = 70
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseCompatibleTextRendering = True
        Me.btnReplace.UseVisualStyleBackColor = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.Transparent
        Me.btnFind.BackgroundImage = CType(resources.GetObject("btnFind.BackgroundImage"), System.Drawing.Image)
        Me.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFind.FlatAppearance.BorderSize = 0
        Me.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.ForeColor = System.Drawing.Color.Black
        Me.btnFind.Location = New System.Drawing.Point(634, 10)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnFind.Size = New System.Drawing.Size(155, 46)
        Me.btnFind.Style = resources.GetString("btnFind.Style")
        Me.btnFind.TabIndex = 68
        Me.btnFind.Text = "Find"
        Me.btnFind.UseCompatibleTextRendering = True
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'FileToolStrip
        '
        Me.FileToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FileToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FileToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.PastePlainToolStripButton, Me.toolStripSeparator2, Me.UndoToolStripButton, Me.RedoToolStripButton})
        Me.FileToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.FileToolStrip.MinimumSize = New System.Drawing.Size(0, 38)
        Me.FileToolStrip.Name = "FileToolStrip"
        Me.FileToolStrip.Size = New System.Drawing.Size(276, 38)
        Me.FileToolStrip.TabIndex = 0
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.NewToolStripButton.Text = "New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'PastePlainToolStripButton
        '
        Me.PastePlainToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PastePlainToolStripButton.Image = CType(resources.GetObject("PastePlainToolStripButton.Image"), System.Drawing.Image)
        Me.PastePlainToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PastePlainToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PastePlainToolStripButton.Name = "PastePlainToolStripButton"
        Me.PastePlainToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.PastePlainToolStripButton.Text = "Paste Plain"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoToolStripButton.Image = CType(resources.GetObject("UndoToolStripButton.Image"), System.Drawing.Image)
        Me.UndoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoToolStripButton.Name = "UndoToolStripButton"
        Me.UndoToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.UndoToolStripButton.Text = "Undo"
        '
        'RedoToolStripButton
        '
        Me.RedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RedoToolStripButton.Image = CType(resources.GetObject("RedoToolStripButton.Image"), System.Drawing.Image)
        Me.RedoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RedoToolStripButton.Name = "RedoToolStripButton"
        Me.RedoToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.RedoToolStripButton.Text = "Redo"
        '
        'FontToolStrip
        '
        Me.FontToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FontToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FontToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripButton, Me.ToolStripSeparator9, Me.BoldToolStripButton, Me.ItalicToolStripButton, Me.UnderlineToolStripButton, Me.StrikeToolStripButton, Me.ToolStripSeparator5, Me.AlignLeftToolStripButton, Me.AlignCenterToolStripButton, Me.AlignRightToolStripButton, Me.ToolStripSeparator8, Me.IndentToolStripComboBox, Me.IndentToolStripButton})
        Me.FontToolStrip.Location = New System.Drawing.Point(437, 0)
        Me.FontToolStrip.MinimumSize = New System.Drawing.Size(0, 38)
        Me.FontToolStrip.Name = "FontToolStrip"
        Me.FontToolStrip.Size = New System.Drawing.Size(384, 40)
        Me.FontToolStrip.TabIndex = 1
        '
        'FontToolStripButton
        '
        Me.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), System.Drawing.Image)
        Me.FontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontToolStripButton.Name = "FontToolStripButton"
        Me.FontToolStripButton.Size = New System.Drawing.Size(28, 37)
        Me.FontToolStripButton.Text = "Font"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 40)
        '
        'BoldToolStripButton
        '
        Me.BoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BoldToolStripButton.Image = CType(resources.GetObject("BoldToolStripButton.Image"), System.Drawing.Image)
        Me.BoldToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BoldToolStripButton.Name = "BoldToolStripButton"
        Me.BoldToolStripButton.Size = New System.Drawing.Size(28, 37)
        Me.BoldToolStripButton.Text = "Bold"
        '
        'ItalicToolStripButton
        '
        Me.ItalicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItalicToolStripButton.Image = CType(resources.GetObject("ItalicToolStripButton.Image"), System.Drawing.Image)
        Me.ItalicToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ItalicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ItalicToolStripButton.Name = "ItalicToolStripButton"
        Me.ItalicToolStripButton.Size = New System.Drawing.Size(28, 37)
        Me.ItalicToolStripButton.Text = "Italic"
        '
        'UnderlineToolStripButton
        '
        Me.UnderlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UnderlineToolStripButton.Image = CType(resources.GetObject("UnderlineToolStripButton.Image"), System.Drawing.Image)
        Me.UnderlineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UnderlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UnderlineToolStripButton.Name = "UnderlineToolStripButton"
        Me.UnderlineToolStripButton.Size = New System.Drawing.Size(28, 37)
        Me.UnderlineToolStripButton.Text = "Underline"
        '
        'StrikeToolStripButton
        '
        Me.StrikeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StrikeToolStripButton.Image = CType(resources.GetObject("StrikeToolStripButton.Image"), System.Drawing.Image)
        Me.StrikeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StrikeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StrikeToolStripButton.Name = "StrikeToolStripButton"
        Me.StrikeToolStripButton.Size = New System.Drawing.Size(28, 37)
        Me.StrikeToolStripButton.Text = "Strike"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 40)
        '
        'AlignLeftToolStripButton
        '
        Me.AlignLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignLeftToolStripButton.Image = CType(resources.GetObject("AlignLeftToolStripButton.Image"), System.Drawing.Image)
        Me.AlignLeftToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignLeftToolStripButton.Name = "AlignLeftToolStripButton"
        Me.AlignLeftToolStripButton.Size = New System.Drawing.Size(28, 37)
        Me.AlignLeftToolStripButton.Text = "Align Left"
        '
        'AlignCenterToolStripButton
        '
        Me.AlignCenterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignCenterToolStripButton.Image = CType(resources.GetObject("AlignCenterToolStripButton.Image"), System.Drawing.Image)
        Me.AlignCenterToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignCenterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignCenterToolStripButton.Name = "AlignCenterToolStripButton"
        Me.AlignCenterToolStripButton.Size = New System.Drawing.Size(28, 37)
        Me.AlignCenterToolStripButton.Text = "Align Center"
        '
        'AlignRightToolStripButton
        '
        Me.AlignRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignRightToolStripButton.Image = CType(resources.GetObject("AlignRightToolStripButton.Image"), System.Drawing.Image)
        Me.AlignRightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignRightToolStripButton.Name = "AlignRightToolStripButton"
        Me.AlignRightToolStripButton.Size = New System.Drawing.Size(28, 37)
        Me.AlignRightToolStripButton.Text = "Align Right"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 40)
        '
        'IndentToolStripComboBox
        '
        Me.IndentToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IndentToolStripComboBox.Name = "IndentToolStripComboBox"
        Me.IndentToolStripComboBox.Size = New System.Drawing.Size(100, 40)
        '
        'IndentToolStripButton
        '
        Me.IndentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IndentToolStripButton.Image = CType(resources.GetObject("IndentToolStripButton.Image"), System.Drawing.Image)
        Me.IndentToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IndentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IndentToolStripButton.Name = "IndentToolStripButton"
        Me.IndentToolStripButton.Size = New System.Drawing.Size(28, 37)
        Me.IndentToolStripButton.Text = "Indent"
        '
        'MainMenu
        '
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.LinguisticsToolStripMenuItem, Me.InsertToolStripMenuItem, Me.StyleToolStripMenuItem, Me.PageToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1910, 40)
        Me.MainMenu.TabIndex = 75
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator3, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator4, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PageSetupToolStripMenuItem, Me.ToolStripMenuItem22, Me.RTFEditorToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(267, 38)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(267, 38)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(264, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(267, 38)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(267, 38)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(264, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(267, 38)
        Me.PrintToolStripMenuItem.Text = "Print..."
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(267, 38)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview..."
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Image = CType(resources.GetObject("PageSetupToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PageSetupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(267, 38)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup..."
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(264, 6)
        '
        'RTFEditorToolStripMenuItem
        '
        Me.RTFEditorToolStripMenuItem.Image = CType(resources.GetObject("RTFEditorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RTFEditorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RTFEditorToolStripMenuItem.Name = "RTFEditorToolStripMenuItem"
        Me.RTFEditorToolStripMenuItem.Size = New System.Drawing.Size(267, 38)
        Me.RTFEditorToolStripMenuItem.Text = "RTF Editor..."
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator6, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.PastePlainToolStripMenuItem, Me.ToolStripMenuItem25, Me.FindToolStripMenuItem, Me.toolStripSeparator7, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(67, 36)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UndoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(251, 38)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RedoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(251, 38)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(248, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(251, 38)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(251, 38)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(251, 38)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'PastePlainToolStripMenuItem
        '
        Me.PastePlainToolStripMenuItem.Image = CType(resources.GetObject("PastePlainToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PastePlainToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PastePlainToolStripMenuItem.Name = "PastePlainToolStripMenuItem"
        Me.PastePlainToolStripMenuItem.Size = New System.Drawing.Size(251, 38)
        Me.PastePlainToolStripMenuItem.Text = "Paste Plain"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(248, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = CType(resources.GetObject("FindToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FindToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(251, 38)
        Me.FindToolStripMenuItem.Text = "Find/Replace"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(248, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Image = CType(resources.GetObject("SelectAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SelectAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(251, 38)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomInToolStripMenuItem, Me.ZoomOutToolStripMenuItem, Me.ToolStripMenuItem27, Me.ZoomToolStripMenuItem, Me.EditZoomToolStripMenuItem, Me.ToolStripMenuItem26, Me.WordWrapToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(78, 36)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ZoomInToolStripMenuItem
        '
        Me.ZoomInToolStripMenuItem.Image = CType(resources.GetObject("ZoomInToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ZoomInToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        Me.ZoomInToolStripMenuItem.Size = New System.Drawing.Size(243, 38)
        Me.ZoomInToolStripMenuItem.Text = "Zoom In"
        '
        'ZoomOutToolStripMenuItem
        '
        Me.ZoomOutToolStripMenuItem.Image = CType(resources.GetObject("ZoomOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ZoomOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        Me.ZoomOutToolStripMenuItem.Size = New System.Drawing.Size(243, 38)
        Me.ZoomOutToolStripMenuItem.Text = "Zoom Out"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(240, 6)
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Image = CType(resources.GetObject("ZoomToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ZoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(243, 38)
        Me.ZoomToolStripMenuItem.Text = "100% Zoom"
        '
        'EditZoomToolStripMenuItem
        '
        Me.EditZoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditZoomToolStripMenuItem.Name = "EditZoomToolStripMenuItem"
        Me.EditZoomToolStripMenuItem.Size = New System.Drawing.Size(243, 38)
        Me.EditZoomToolStripMenuItem.Text = "Edit Zoom"
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(240, 6)
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.CheckOnClick = True
        Me.WordWrapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(243, 38)
        Me.WordWrapToolStripMenuItem.Text = "Word Wrap"
        '
        'LinguisticsToolStripMenuItem
        '
        Me.LinguisticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SymbolsToolStripMenuItem, Me.CustomSymbolsToolStripMenuItem, Me.AccentMarkToolStripMenuItem, Me.ToolStripMenuItem30, Me.DictionaryToolStripMenuItem})
        Me.LinguisticsToolStripMenuItem.Name = "LinguisticsToolStripMenuItem"
        Me.LinguisticsToolStripMenuItem.Size = New System.Drawing.Size(137, 36)
        Me.LinguisticsToolStripMenuItem.Text = "Linguistics"
        '
        'SymbolsToolStripMenuItem
        '
        Me.SymbolsToolStripMenuItem.Image = CType(resources.GetObject("SymbolsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SymbolsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SymbolsToolStripMenuItem.Name = "SymbolsToolStripMenuItem"
        Me.SymbolsToolStripMenuItem.Size = New System.Drawing.Size(307, 38)
        Me.SymbolsToolStripMenuItem.Text = "Symbols"
        '
        'CustomSymbolsToolStripMenuItem
        '
        Me.CustomSymbolsToolStripMenuItem.Image = CType(resources.GetObject("CustomSymbolsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CustomSymbolsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CustomSymbolsToolStripMenuItem.Name = "CustomSymbolsToolStripMenuItem"
        Me.CustomSymbolsToolStripMenuItem.Size = New System.Drawing.Size(307, 38)
        Me.CustomSymbolsToolStripMenuItem.Text = "Custom Symbols..."
        '
        'AccentMarkToolStripMenuItem
        '
        Me.AccentMarkToolStripMenuItem.Image = CType(resources.GetObject("AccentMarkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AccentMarkToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AccentMarkToolStripMenuItem.Name = "AccentMarkToolStripMenuItem"
        Me.AccentMarkToolStripMenuItem.Size = New System.Drawing.Size(307, 38)
        Me.AccentMarkToolStripMenuItem.Text = "Accent Mark..."
        '
        'ToolStripMenuItem30
        '
        Me.ToolStripMenuItem30.Name = "ToolStripMenuItem30"
        Me.ToolStripMenuItem30.Size = New System.Drawing.Size(304, 6)
        '
        'DictionaryToolStripMenuItem
        '
        Me.DictionaryToolStripMenuItem.Image = CType(resources.GetObject("DictionaryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DictionaryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DictionaryToolStripMenuItem.Name = "DictionaryToolStripMenuItem"
        Me.DictionaryToolStripMenuItem.Size = New System.Drawing.Size(307, 38)
        Me.DictionaryToolStripMenuItem.Text = "Dictionary..."
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImageToolStripMenuItem, Me.TextArtToolStripMenuItem, Me.TableToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(86, 36)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Image = CType(resources.GetObject("ImageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(210, 38)
        Me.ImageToolStripMenuItem.Text = "Image..."
        '
        'TextArtToolStripMenuItem
        '
        Me.TextArtToolStripMenuItem.Image = CType(resources.GetObject("TextArtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextArtToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TextArtToolStripMenuItem.Name = "TextArtToolStripMenuItem"
        Me.TextArtToolStripMenuItem.Size = New System.Drawing.Size(210, 38)
        Me.TextArtToolStripMenuItem.Text = "Text Art..."
        '
        'TableToolStripMenuItem
        '
        Me.TableToolStripMenuItem.Image = CType(resources.GetObject("TableToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TableToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TableToolStripMenuItem.Name = "TableToolStripMenuItem"
        Me.TableToolStripMenuItem.Size = New System.Drawing.Size(210, 38)
        Me.TableToolStripMenuItem.Text = "Table..."
        '
        'StyleToolStripMenuItem
        '
        Me.StyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertBulletsToolStripMenuItem, Me.RemoveBulletsToolStripMenuItem, Me.ToolStripMenuItem24, Me.DefaultStyleToolStripMenuItem, Me.EditStyleToolStripMenuItem, Me.ApplyStyleToolStripMenuItem, Me.ToolStripMenuItem31, Me.SubscriptToolStripMenuItem, Me.SuperscriptToolStripMenuItem, Me.BaselineToolStripMenuItem, Me.ToolStripMenuItem32, Me.TextColorToolStripMenuItem, Me.HighlightToolStripMenuItem})
        Me.StyleToolStripMenuItem.Name = "StyleToolStripMenuItem"
        Me.StyleToolStripMenuItem.Size = New System.Drawing.Size(78, 36)
        Me.StyleToolStripMenuItem.Text = "Style"
        '
        'InsertBulletsToolStripMenuItem
        '
        Me.InsertBulletsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InsertBulletsToolStripMenuItem.Name = "InsertBulletsToolStripMenuItem"
        Me.InsertBulletsToolStripMenuItem.Size = New System.Drawing.Size(278, 38)
        Me.InsertBulletsToolStripMenuItem.Text = "Insert Bullets"
        '
        'RemoveBulletsToolStripMenuItem
        '
        Me.RemoveBulletsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveBulletsToolStripMenuItem.Name = "RemoveBulletsToolStripMenuItem"
        Me.RemoveBulletsToolStripMenuItem.Size = New System.Drawing.Size(278, 38)
        Me.RemoveBulletsToolStripMenuItem.Text = "Remove Bullets"
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(275, 6)
        '
        'DefaultStyleToolStripMenuItem
        '
        Me.DefaultStyleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DefaultStyleToolStripMenuItem.Name = "DefaultStyleToolStripMenuItem"
        Me.DefaultStyleToolStripMenuItem.Size = New System.Drawing.Size(278, 38)
        Me.DefaultStyleToolStripMenuItem.Text = "Default Style"
        '
        'EditStyleToolStripMenuItem
        '
        Me.EditStyleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditStyleToolStripMenuItem.Name = "EditStyleToolStripMenuItem"
        Me.EditStyleToolStripMenuItem.Size = New System.Drawing.Size(278, 38)
        Me.EditStyleToolStripMenuItem.Text = "Edit Style..."
        '
        'ApplyStyleToolStripMenuItem
        '
        Me.ApplyStyleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ApplyStyleToolStripMenuItem.Name = "ApplyStyleToolStripMenuItem"
        Me.ApplyStyleToolStripMenuItem.Size = New System.Drawing.Size(278, 38)
        Me.ApplyStyleToolStripMenuItem.Text = "Apply Style"
        '
        'ToolStripMenuItem31
        '
        Me.ToolStripMenuItem31.Name = "ToolStripMenuItem31"
        Me.ToolStripMenuItem31.Size = New System.Drawing.Size(275, 6)
        '
        'SubscriptToolStripMenuItem
        '
        Me.SubscriptToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SubscriptToolStripMenuItem.Name = "SubscriptToolStripMenuItem"
        Me.SubscriptToolStripMenuItem.Size = New System.Drawing.Size(278, 38)
        Me.SubscriptToolStripMenuItem.Text = "Subscript"
        '
        'SuperscriptToolStripMenuItem
        '
        Me.SuperscriptToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SuperscriptToolStripMenuItem.Name = "SuperscriptToolStripMenuItem"
        Me.SuperscriptToolStripMenuItem.Size = New System.Drawing.Size(278, 38)
        Me.SuperscriptToolStripMenuItem.Text = "Superscript"
        '
        'BaselineToolStripMenuItem
        '
        Me.BaselineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BaselineToolStripMenuItem.Name = "BaselineToolStripMenuItem"
        Me.BaselineToolStripMenuItem.Size = New System.Drawing.Size(278, 38)
        Me.BaselineToolStripMenuItem.Text = "Baseline"
        '
        'ToolStripMenuItem32
        '
        Me.ToolStripMenuItem32.Name = "ToolStripMenuItem32"
        Me.ToolStripMenuItem32.Size = New System.Drawing.Size(275, 6)
        '
        'TextColorToolStripMenuItem
        '
        Me.TextColorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TextColorToolStripMenuItem.Name = "TextColorToolStripMenuItem"
        Me.TextColorToolStripMenuItem.Size = New System.Drawing.Size(278, 38)
        Me.TextColorToolStripMenuItem.Text = "Text Color..."
        '
        'HighlightToolStripMenuItem
        '
        Me.HighlightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HighlightToolStripMenuItem.Name = "HighlightToolStripMenuItem"
        Me.HighlightToolStripMenuItem.Size = New System.Drawing.Size(278, 38)
        Me.HighlightToolStripMenuItem.Text = "Highlight..."
        '
        'PageToolStripMenuItem
        '
        Me.PageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPageToolStripMenuItem, Me.RemovePageToolStripMenuItem, Me.DuplicatePageToolStripMenuItem, Me.ToolStripMenuItem28, Me.ImportPageToolStripMenuItem, Me.ExportPageToolStripMenuItem, Me.ToolStripMenuItem29, Me.RenamePageToolStripMenuItem})
        Me.PageToolStripMenuItem.Name = "PageToolStripMenuItem"
        Me.PageToolStripMenuItem.Size = New System.Drawing.Size(78, 36)
        Me.PageToolStripMenuItem.Text = "Page"
        '
        'AddPageToolStripMenuItem
        '
        Me.AddPageToolStripMenuItem.Image = CType(resources.GetObject("AddPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddPageToolStripMenuItem.Name = "AddPageToolStripMenuItem"
        Me.AddPageToolStripMenuItem.Size = New System.Drawing.Size(273, 38)
        Me.AddPageToolStripMenuItem.Text = "Add Page"
        '
        'RemovePageToolStripMenuItem
        '
        Me.RemovePageToolStripMenuItem.Image = CType(resources.GetObject("RemovePageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemovePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemovePageToolStripMenuItem.Name = "RemovePageToolStripMenuItem"
        Me.RemovePageToolStripMenuItem.Size = New System.Drawing.Size(273, 38)
        Me.RemovePageToolStripMenuItem.Text = "Remove Page"
        '
        'DuplicatePageToolStripMenuItem
        '
        Me.DuplicatePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DuplicatePageToolStripMenuItem.Name = "DuplicatePageToolStripMenuItem"
        Me.DuplicatePageToolStripMenuItem.Size = New System.Drawing.Size(273, 38)
        Me.DuplicatePageToolStripMenuItem.Text = "Duplicate Page"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(270, 6)
        '
        'ImportPageToolStripMenuItem
        '
        Me.ImportPageToolStripMenuItem.Image = CType(resources.GetObject("ImportPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImportPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportPageToolStripMenuItem.Name = "ImportPageToolStripMenuItem"
        Me.ImportPageToolStripMenuItem.Size = New System.Drawing.Size(273, 38)
        Me.ImportPageToolStripMenuItem.Text = "Import Page..."
        '
        'ExportPageToolStripMenuItem
        '
        Me.ExportPageToolStripMenuItem.Image = CType(resources.GetObject("ExportPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExportPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportPageToolStripMenuItem.Name = "ExportPageToolStripMenuItem"
        Me.ExportPageToolStripMenuItem.Size = New System.Drawing.Size(273, 38)
        Me.ExportPageToolStripMenuItem.Text = "Export Page..."
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(270, 6)
        '
        'RenamePageToolStripMenuItem
        '
        Me.RenamePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RenamePageToolStripMenuItem.Name = "RenamePageToolStripMenuItem"
        Me.RenamePageToolStripMenuItem.Size = New System.Drawing.Size(273, 38)
        Me.RenamePageToolStripMenuItem.Text = "Rename Page..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.ToolStripMenuItem23, Me.SettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(82, 36)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Image = CType(resources.GetObject("UpdateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(215, 38)
        Me.UpdateToolStripMenuItem.Text = "Update..."
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(212, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(215, 38)
        Me.SettingsToolStripMenuItem.Text = "Settings..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(77, 36)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(194, 38)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'NotebookEditor1
        '
        Me.NotebookEditor1.BackColor = System.Drawing.Color.Transparent
        Me.NotebookEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotebookEditor1.Location = New System.Drawing.Point(0, 0)
        Me.NotebookEditor1.Margin = New System.Windows.Forms.Padding(4)
        Me.NotebookEditor1.MinimumSize = New System.Drawing.Size(524, 0)
        Me.NotebookEditor1.Name = "NotebookEditor1"
        Me.NotebookEditor1.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.NotebookEditor1.Size = New System.Drawing.Size(540, 1010)
        Me.NotebookEditor1.TabIndex = 72
        '
        'LinguisticsToolStrip
        '
        Me.LinguisticsToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.LinguisticsToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.LinguisticsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SymbolsToolStripButton, Me.CustomSymbolsToolStripButton, Me.AccentMarkToolStripButton})
        Me.LinguisticsToolStrip.Location = New System.Drawing.Point(279, 0)
        Me.LinguisticsToolStrip.MinimumSize = New System.Drawing.Size(0, 38)
        Me.LinguisticsToolStrip.Name = "LinguisticsToolStrip"
        Me.LinguisticsToolStrip.Size = New System.Drawing.Size(158, 38)
        Me.LinguisticsToolStrip.TabIndex = 2
        '
        'SymbolsToolStripButton
        '
        Me.SymbolsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SymbolsToolStripButton.Image = CType(resources.GetObject("SymbolsToolStripButton.Image"), System.Drawing.Image)
        Me.SymbolsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SymbolsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SymbolsToolStripButton.Name = "SymbolsToolStripButton"
        Me.SymbolsToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.SymbolsToolStripButton.Text = "Symbols"
        '
        'AccentMarkToolStripButton
        '
        Me.AccentMarkToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AccentMarkToolStripButton.Image = CType(resources.GetObject("AccentMarkToolStripButton.Image"), System.Drawing.Image)
        Me.AccentMarkToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AccentMarkToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AccentMarkToolStripButton.Name = "AccentMarkToolStripButton"
        Me.AccentMarkToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.AccentMarkToolStripButton.Text = "Accent Mark"
        '
        'CustomSymbolsToolStripButton
        '
        Me.CustomSymbolsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomSymbolsToolStripButton.Image = CType(resources.GetObject("CustomSymbolsToolStripButton.Image"), System.Drawing.Image)
        Me.CustomSymbolsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CustomSymbolsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CustomSymbolsToolStripButton.Name = "CustomSymbolsToolStripButton"
        Me.CustomSymbolsToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.CustomSymbolsToolStripButton.Text = "Custom Symbols"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1910, 1363)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MainMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Language Pad X.x"
        Me.tcSymbols.ResumeLayout(False)
        Me.ConsonantsTabPage.ResumeLayout(False)
        Me.ConsonantsTabPage.PerformLayout()
        Me.AffricatesTabPage.ResumeLayout(False)
        Me.VowelsTabPage.ResumeLayout(False)
        Me.AccentsTabPage.ResumeLayout(False)
        Me.ToneIntonationTabPage.ResumeLayout(False)
        Me.OtherTabPage.ResumeLayout(False)
        Me.CommonTabPage.ResumeLayout(False)
        Me.CustomTabPage.ResumeLayout(False)
        Me.cmsMain.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.StylizedPanel1.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.DataToolStrip.ResumeLayout(False)
        Me.DataToolStrip.PerformLayout()
        Me.pnlFindReplace.ResumeLayout(False)
        Me.pnlFindReplace.PerformLayout()
        Me.FileToolStrip.ResumeLayout(False)
        Me.FileToolStrip.PerformLayout()
        Me.FontToolStrip.ResumeLayout(False)
        Me.FontToolStrip.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.LinguisticsToolStrip.ResumeLayout(False)
        Me.LinguisticsToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlgOpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents tcSymbols As System.Windows.Forms.TabControl
    Friend WithEvents ConsonantsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ConsonantsLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents AffricatesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents AffricatesLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents VowelsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents VowelsLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents AccentsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents AccentsLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToneIntonationTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ToneIntonationLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents OtherTabPage As System.Windows.Forms.TabPage
    Friend WithEvents OtherLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CommonTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CommonLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CustomTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CustomLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents dlgSavePage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgPrintPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents dlgPrint As System.Windows.Forms.PrintDialog
    Friend WithEvents dlgOpenPage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents pdMain As System.Drawing.Printing.PrintDocument
    Friend WithEvents pnlFindReplace As Tundra.StylizedPanel
    Friend WithEvents btnReplace As Tundra.StylizedButton
    Friend WithEvents btnFind As Tundra.StylizedButton
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnReplaceAll As Tundra.StylizedButton
    Friend WithEvents btnFindNext As Tundra.StylizedButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmsMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeselectAllContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents tcNotebook As System.Windows.Forms.TabControl
    Friend WithEvents dlgSaveNotebook As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
    Friend WithEvents NotebookEditor1 As Language_Pad.NotebookEditor
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents dlgSaveImage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents FileToolStrip As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem22 As ToolStripSeparator
    Friend WithEvents RTFEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator6 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PastePlainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator7 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinguisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SymbolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomSymbolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccentMarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem23 As ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StyleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertBulletsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveBulletsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem24 As ToolStripSeparator
    Friend WithEvents DefaultStyleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditStyleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplyStyleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem25 As ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem27 As ToolStripSeparator
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem26 As ToolStripSeparator
    Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem30 As ToolStripSeparator
    Friend WithEvents DictionaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextArtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemovePageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DuplicatePageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem28 As ToolStripSeparator
    Friend WithEvents ImportPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem29 As ToolStripSeparator
    Friend WithEvents RenamePageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PastePlainToolStripButton As ToolStripButton
    Friend WithEvents UndoToolStripButton As ToolStripButton
    Friend WithEvents RedoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripMenuItem31 As ToolStripSeparator
    Friend WithEvents SubscriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuperscriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaselineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem32 As ToolStripSeparator
    Friend WithEvents TextColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStrip As ToolStrip
    Friend WithEvents FontToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents BoldToolStripButton As ToolStripButton
    Friend WithEvents UnderlineToolStripButton As ToolStripButton
    Friend WithEvents ItalicToolStripButton As ToolStripButton
    Friend WithEvents StrikeToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AlignLeftToolStripButton As ToolStripButton
    Friend WithEvents AlignCenterToolStripButton As ToolStripButton
    Friend WithEvents AlignRightToolStripButton As ToolStripButton
    Friend WithEvents IndentToolStripComboBox As ToolStripComboBox
    Friend WithEvents IndentToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents DataToolStrip As ToolStrip
    Friend WithEvents CharCountToolStripLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents WordCountToolStripLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents lblPageCount As ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ThemeCombo As ToolStripComboBox
    Friend WithEvents LinguisticsToolStrip As ToolStrip
    Friend WithEvents SymbolsToolStripButton As ToolStripButton
    Friend WithEvents CustomSymbolsToolStripButton As ToolStripButton
    Friend WithEvents AccentMarkToolStripButton As ToolStripButton
End Class
