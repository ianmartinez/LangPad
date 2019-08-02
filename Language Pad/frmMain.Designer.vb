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
        Me.SplitLayoutPanel = New System.Windows.Forms.SplitContainer()
        Me.MainToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.DataToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CharCountToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.WordCountToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblPageCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ThemeCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.tcNotebook = New System.Windows.Forms.TabControl()
        Me.pnlFindReplace = New TundraLib.DoubleBufferedPanel()
        Me.btnFindNext = New System.Windows.Forms.Button()
        Me.btnReplaceAll = New System.Windows.Forms.Button()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.pnlColor = New TundraLib.DoubleBufferedPanel()
        Me.ColorLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnTransparentColor = New System.Windows.Forms.Button()
        Me.StylizedColorButton1 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton2 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton3 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton4 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton5 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton6 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton7 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton8 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton9 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton10 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton11 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton12 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton20 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton21 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton13 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton14 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton15 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton16 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton17 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton18 = New TundraLib.StylizedColorButton()
        Me.StylizedColorButton19 = New TundraLib.StylizedColorButton()
        Me.rbHighlight = New System.Windows.Forms.RadioButton()
        Me.rbTextColor = New System.Windows.Forms.RadioButton()
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
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.CharacterEditorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StylizedPanel1 = New TundraLib.DoubleBufferedPanel()
        Me.pnlDocumentProperties = New Language_Pad.PropertiesEditor()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.dlgSaveImage = New System.Windows.Forms.SaveFileDialog()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FullModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimalModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToggleSidebarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleStatusbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleCommonToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToogleFormattingToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicatePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem29 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenamePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DictionaryMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMain.SuspendLayout()
        CType(Me.SplitLayoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitLayoutPanel.Panel1.SuspendLayout()
        Me.SplitLayoutPanel.Panel2.SuspendLayout()
        Me.SplitLayoutPanel.SuspendLayout()
        Me.MainToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.MainToolStripContainer.ContentPanel.SuspendLayout()
        Me.MainToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.MainToolStripContainer.SuspendLayout()
        Me.DataToolStrip.SuspendLayout()
        Me.pnlFindReplace.SuspendLayout()
        Me.pnlColor.SuspendLayout()
        Me.ColorLayoutPanel.SuspendLayout()
        Me.FontToolStrip.SuspendLayout()
        Me.FileToolStrip.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'dlgOpenImage
        '
        Me.dlgOpenImage.Filter = "Image files(*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif|JPEG f" &
    "iles (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif" &
    "|All files (*.*)|*.*"
        Me.dlgOpenImage.Title = "Insert Image"
        '
        'dlgFont
        '
        Me.dlgFont.ShowColor = True
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
        Me.cmsMain.Size = New System.Drawing.Size(142, 150)
        '
        'CopyContextMenuItem
        '
        Me.CopyContextMenuItem.Image = CType(resources.GetObject("CopyContextMenuItem.Image"), System.Drawing.Image)
        Me.CopyContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyContextMenuItem.Name = "CopyContextMenuItem"
        Me.CopyContextMenuItem.Size = New System.Drawing.Size(141, 28)
        Me.CopyContextMenuItem.Text = "Copy"
        '
        'PasteContextMenuItem
        '
        Me.PasteContextMenuItem.Image = CType(resources.GetObject("PasteContextMenuItem.Image"), System.Drawing.Image)
        Me.PasteContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteContextMenuItem.Name = "PasteContextMenuItem"
        Me.PasteContextMenuItem.Size = New System.Drawing.Size(141, 28)
        Me.PasteContextMenuItem.Text = "Paste"
        '
        'CutContextMenuItem
        '
        Me.CutContextMenuItem.Image = CType(resources.GetObject("CutContextMenuItem.Image"), System.Drawing.Image)
        Me.CutContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutContextMenuItem.Name = "CutContextMenuItem"
        Me.CutContextMenuItem.Size = New System.Drawing.Size(141, 28)
        Me.CutContextMenuItem.Text = "Cut"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(138, 6)
        '
        'SelectAllContextMenuItem
        '
        Me.SelectAllContextMenuItem.Image = CType(resources.GetObject("SelectAllContextMenuItem.Image"), System.Drawing.Image)
        Me.SelectAllContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SelectAllContextMenuItem.Name = "SelectAllContextMenuItem"
        Me.SelectAllContextMenuItem.Size = New System.Drawing.Size(141, 28)
        Me.SelectAllContextMenuItem.Text = "Select All"
        '
        'DeselectAllContextMenuItem
        '
        Me.DeselectAllContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeselectAllContextMenuItem.Name = "DeselectAllContextMenuItem"
        Me.DeselectAllContextMenuItem.Size = New System.Drawing.Size(141, 28)
        Me.DeselectAllContextMenuItem.Text = "Deselect All"
        '
        'SplitLayoutPanel
        '
        Me.SplitLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitLayoutPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitLayoutPanel.Location = New System.Drawing.Point(0, 24)
        Me.SplitLayoutPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitLayoutPanel.Name = "SplitLayoutPanel"
        '
        'SplitLayoutPanel.Panel1
        '
        Me.SplitLayoutPanel.Panel1.Controls.Add(Me.MainToolStripContainer)
        '
        'SplitLayoutPanel.Panel2
        '
        Me.SplitLayoutPanel.Panel2.Controls.Add(Me.StylizedPanel1)
        Me.SplitLayoutPanel.Panel2MinSize = 325
        Me.SplitLayoutPanel.Size = New System.Drawing.Size(1257, 737)
        Me.SplitLayoutPanel.SplitterDistance = 907
        Me.SplitLayoutPanel.SplitterWidth = 2
        Me.SplitLayoutPanel.TabIndex = 1
        '
        'MainToolStripContainer
        '
        '
        'MainToolStripContainer.BottomToolStripPanel
        '
        Me.MainToolStripContainer.BottomToolStripPanel.Controls.Add(Me.DataToolStrip)
        '
        'MainToolStripContainer.ContentPanel
        '
        Me.MainToolStripContainer.ContentPanel.Controls.Add(Me.tcNotebook)
        Me.MainToolStripContainer.ContentPanel.Controls.Add(Me.pnlFindReplace)
        Me.MainToolStripContainer.ContentPanel.Controls.Add(Me.pnlColor)
        Me.MainToolStripContainer.ContentPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MainToolStripContainer.ContentPanel.Size = New System.Drawing.Size(907, 674)
        Me.MainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'MainToolStripContainer.LeftToolStripPanel
        '
        Me.MainToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStripContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.MainToolStripContainer.Name = "MainToolStripContainer"
        '
        'MainToolStripContainer.RightToolStripPanel
        '
        Me.MainToolStripContainer.Size = New System.Drawing.Size(907, 737)
        Me.MainToolStripContainer.TabIndex = 74
        '
        'MainToolStripContainer.TopToolStripPanel
        '
        Me.MainToolStripContainer.TopToolStripPanel.Controls.Add(Me.FileToolStrip)
        Me.MainToolStripContainer.TopToolStripPanel.Controls.Add(Me.FontToolStrip)
        '
        'DataToolStrip
        '
        Me.DataToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.DataToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DataToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.DataToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CharCountToolStripLabel, Me.ToolStripSeparator10, Me.WordCountToolStripLabel, Me.ToolStripSeparator11, Me.lblPageCount, Me.ToolStripSeparator12, Me.ToolStripLabel1, Me.ThemeCombo})
        Me.DataToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DataToolStrip.Name = "DataToolStrip"
        Me.DataToolStrip.Size = New System.Drawing.Size(907, 25)
        Me.DataToolStrip.Stretch = True
        Me.DataToolStrip.TabIndex = 2
        '
        'CharCountToolStripLabel
        '
        Me.CharCountToolStripLabel.Name = "CharCountToolStripLabel"
        Me.CharCountToolStripLabel.Size = New System.Drawing.Size(106, 22)
        Me.CharCountToolStripLabel.Text = "Character Count: 0"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'WordCountToolStripLabel
        '
        Me.WordCountToolStripLabel.Name = "WordCountToolStripLabel"
        Me.WordCountToolStripLabel.Size = New System.Drawing.Size(84, 22)
        Me.WordCountToolStripLabel.Text = "Word Count: 0"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'lblPageCount
        '
        Me.lblPageCount.Name = "lblPageCount"
        Me.lblPageCount.Size = New System.Drawing.Size(81, 22)
        Me.lblPageCount.Text = "Page Count: 0"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator12.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel1.Text = "Theme:"
        Me.ToolStripLabel1.Visible = False
        '
        'ThemeCombo
        '
        Me.ThemeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ThemeCombo.Items.AddRange(New Object() {"Breeze"})
        Me.ThemeCombo.Name = "ThemeCombo"
        Me.ThemeCombo.Size = New System.Drawing.Size(145, 25)
        Me.ThemeCombo.Visible = False
        '
        'tcNotebook
        '
        Me.tcNotebook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcNotebook.Location = New System.Drawing.Point(0, 132)
        Me.tcNotebook.Margin = New System.Windows.Forms.Padding(2)
        Me.tcNotebook.Name = "tcNotebook"
        Me.tcNotebook.SelectedIndex = 0
        Me.tcNotebook.Size = New System.Drawing.Size(907, 542)
        Me.tcNotebook.TabIndex = 73
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
        Me.pnlFindReplace.Location = New System.Drawing.Point(0, 97)
        Me.pnlFindReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlFindReplace.Name = "pnlFindReplace"
        Me.pnlFindReplace.Size = New System.Drawing.Size(907, 35)
        Me.pnlFindReplace.TabIndex = 72
        Me.pnlFindReplace.Visible = False
        '
        'btnFindNext
        '
        Me.btnFindNext.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFindNext.Location = New System.Drawing.Point(398, 5)
        Me.btnFindNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(78, 24)
        Me.btnFindNext.TabIndex = 69
        Me.btnFindNext.Text = " Find Next"
        Me.btnFindNext.UseVisualStyleBackColor = False
        '
        'btnReplaceAll
        '
        Me.btnReplaceAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReplaceAll.Location = New System.Drawing.Point(562, 5)
        Me.btnReplaceAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.Size = New System.Drawing.Size(78, 24)
        Me.btnReplaceAll.TabIndex = 71
        Me.btnReplaceAll.Text = "Replace All"
        Me.btnReplaceAll.UseVisualStyleBackColor = False
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(203, 9)
        Me.txtReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(112, 20)
        Me.txtReplace.TabIndex = 67
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(150, 11)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "Replace:"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(40, 9)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(108, 20)
        Me.txtFind.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 11)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Find:"
        '
        'btnReplace
        '
        Me.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReplace.Location = New System.Drawing.Point(480, 5)
        Me.btnReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(78, 24)
        Me.btnReplace.TabIndex = 70
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = False
        '
        'btnFind
        '
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFind.Location = New System.Drawing.Point(317, 5)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(78, 24)
        Me.btnFind.TabIndex = 68
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'pnlColor
        '
        Me.pnlColor.BackColor = System.Drawing.Color.Transparent
        Me.pnlColor.Controls.Add(Me.ColorLayoutPanel)
        Me.pnlColor.Controls.Add(Me.rbHighlight)
        Me.pnlColor.Controls.Add(Me.rbTextColor)
        Me.pnlColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlColor.Location = New System.Drawing.Point(0, 0)
        Me.pnlColor.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pnlColor.Size = New System.Drawing.Size(907, 97)
        Me.pnlColor.TabIndex = 74
        Me.pnlColor.Visible = False
        '
        'ColorLayoutPanel
        '
        Me.ColorLayoutPanel.AutoScroll = True
        Me.ColorLayoutPanel.AutoScrollMargin = New System.Drawing.Size(15, 5)
        Me.ColorLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.ColorLayoutPanel.Controls.Add(Me.btnTransparentColor)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton1)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton2)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton3)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton4)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton5)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton6)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton7)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton8)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton9)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton10)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton11)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton12)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton20)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton21)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton13)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton14)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton15)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton16)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton17)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton18)
        Me.ColorLayoutPanel.Controls.Add(Me.StylizedColorButton19)
        Me.ColorLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ColorLayoutPanel.Location = New System.Drawing.Point(0, 32)
        Me.ColorLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ColorLayoutPanel.Name = "ColorLayoutPanel"
        Me.ColorLayoutPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.ColorLayoutPanel.Size = New System.Drawing.Size(907, 64)
        Me.ColorLayoutPanel.TabIndex = 70
        '
        'btnTransparentColor
        '
        Me.btnTransparentColor.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnTransparentColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransparentColor.ForeColor = System.Drawing.Color.Red
        Me.btnTransparentColor.Location = New System.Drawing.Point(7, 7)
        Me.btnTransparentColor.Name = "btnTransparentColor"
        Me.btnTransparentColor.Size = New System.Drawing.Size(32, 31)
        Me.btnTransparentColor.TabIndex = 21
        Me.btnTransparentColor.Text = "X"
        Me.ttMain.SetToolTip(Me.btnTransparentColor, "Transparent")
        Me.btnTransparentColor.UseVisualStyleBackColor = True
        '
        'StylizedColorButton1
        '
        Me.StylizedColorButton1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton1.Color = System.Drawing.Color.Black
        Me.StylizedColorButton1.Image = CType(resources.GetObject("StylizedColorButton1.Image"), System.Drawing.Image)
        Me.StylizedColorButton1.Location = New System.Drawing.Point(44, 6)
        Me.StylizedColorButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton1.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton1.Name = "StylizedColorButton1"
        Me.StylizedColorButton1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton1.RightClickMode = True
        Me.StylizedColorButton1.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton1.TabIndex = 0
        Me.StylizedColorButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton1.UseVisualStyleBackColor = True
        '
        'StylizedColorButton2
        '
        Me.StylizedColorButton2.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton2.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StylizedColorButton2.Image = CType(resources.GetObject("StylizedColorButton2.Image"), System.Drawing.Image)
        Me.StylizedColorButton2.Location = New System.Drawing.Point(80, 6)
        Me.StylizedColorButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton2.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton2.Name = "StylizedColorButton2"
        Me.StylizedColorButton2.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton2.RightClickMode = True
        Me.StylizedColorButton2.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton2.TabIndex = 1
        Me.StylizedColorButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton2.UseVisualStyleBackColor = True
        '
        'StylizedColorButton3
        '
        Me.StylizedColorButton3.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton3.Color = System.Drawing.Color.Silver
        Me.StylizedColorButton3.Image = CType(resources.GetObject("StylizedColorButton3.Image"), System.Drawing.Image)
        Me.StylizedColorButton3.Location = New System.Drawing.Point(116, 6)
        Me.StylizedColorButton3.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton3.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton3.Name = "StylizedColorButton3"
        Me.StylizedColorButton3.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton3.RightClickMode = True
        Me.StylizedColorButton3.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton3.TabIndex = 2
        Me.StylizedColorButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton3.UseVisualStyleBackColor = True
        '
        'StylizedColorButton4
        '
        Me.StylizedColorButton4.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton4.Color = System.Drawing.Color.Gainsboro
        Me.StylizedColorButton4.Image = CType(resources.GetObject("StylizedColorButton4.Image"), System.Drawing.Image)
        Me.StylizedColorButton4.Location = New System.Drawing.Point(152, 6)
        Me.StylizedColorButton4.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton4.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton4.Name = "StylizedColorButton4"
        Me.StylizedColorButton4.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton4.RightClickMode = True
        Me.StylizedColorButton4.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton4.TabIndex = 3
        Me.StylizedColorButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton4.UseVisualStyleBackColor = True
        '
        'StylizedColorButton5
        '
        Me.StylizedColorButton5.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton5.Color = System.Drawing.Color.White
        Me.StylizedColorButton5.Image = CType(resources.GetObject("StylizedColorButton5.Image"), System.Drawing.Image)
        Me.StylizedColorButton5.Location = New System.Drawing.Point(188, 6)
        Me.StylizedColorButton5.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton5.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton5.Name = "StylizedColorButton5"
        Me.StylizedColorButton5.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton5.RightClickMode = True
        Me.StylizedColorButton5.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton5.TabIndex = 4
        Me.StylizedColorButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton5.UseVisualStyleBackColor = True
        '
        'StylizedColorButton6
        '
        Me.StylizedColorButton6.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton6.Color = System.Drawing.Color.Red
        Me.StylizedColorButton6.Image = CType(resources.GetObject("StylizedColorButton6.Image"), System.Drawing.Image)
        Me.StylizedColorButton6.Location = New System.Drawing.Point(224, 6)
        Me.StylizedColorButton6.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton6.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton6.Name = "StylizedColorButton6"
        Me.StylizedColorButton6.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton6.RightClickMode = True
        Me.StylizedColorButton6.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton6.TabIndex = 5
        Me.StylizedColorButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton6.UseVisualStyleBackColor = True
        '
        'StylizedColorButton7
        '
        Me.StylizedColorButton7.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton7.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedColorButton7.Image = CType(resources.GetObject("StylizedColorButton7.Image"), System.Drawing.Image)
        Me.StylizedColorButton7.Location = New System.Drawing.Point(260, 6)
        Me.StylizedColorButton7.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton7.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton7.Name = "StylizedColorButton7"
        Me.StylizedColorButton7.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton7.RightClickMode = True
        Me.StylizedColorButton7.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton7.TabIndex = 6
        Me.StylizedColorButton7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton7.UseVisualStyleBackColor = True
        '
        'StylizedColorButton8
        '
        Me.StylizedColorButton8.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton8.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedColorButton8.Image = CType(resources.GetObject("StylizedColorButton8.Image"), System.Drawing.Image)
        Me.StylizedColorButton8.Location = New System.Drawing.Point(296, 6)
        Me.StylizedColorButton8.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton8.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton8.Name = "StylizedColorButton8"
        Me.StylizedColorButton8.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton8.RightClickMode = True
        Me.StylizedColorButton8.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton8.TabIndex = 7
        Me.StylizedColorButton8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton8.UseVisualStyleBackColor = True
        '
        'StylizedColorButton9
        '
        Me.StylizedColorButton9.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton9.Color = System.Drawing.Color.Goldenrod
        Me.StylizedColorButton9.Image = CType(resources.GetObject("StylizedColorButton9.Image"), System.Drawing.Image)
        Me.StylizedColorButton9.Location = New System.Drawing.Point(332, 6)
        Me.StylizedColorButton9.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton9.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton9.Name = "StylizedColorButton9"
        Me.StylizedColorButton9.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton9.RightClickMode = True
        Me.StylizedColorButton9.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton9.TabIndex = 8
        Me.StylizedColorButton9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton9.UseVisualStyleBackColor = True
        '
        'StylizedColorButton10
        '
        Me.StylizedColorButton10.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton10.Color = System.Drawing.Color.Yellow
        Me.StylizedColorButton10.Image = CType(resources.GetObject("StylizedColorButton10.Image"), System.Drawing.Image)
        Me.StylizedColorButton10.Location = New System.Drawing.Point(368, 6)
        Me.StylizedColorButton10.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton10.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton10.Name = "StylizedColorButton10"
        Me.StylizedColorButton10.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton10.RightClickMode = True
        Me.StylizedColorButton10.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton10.TabIndex = 9
        Me.StylizedColorButton10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton10.UseVisualStyleBackColor = True
        '
        'StylizedColorButton11
        '
        Me.StylizedColorButton11.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton11.Color = System.Drawing.Color.Lime
        Me.StylizedColorButton11.Image = CType(resources.GetObject("StylizedColorButton11.Image"), System.Drawing.Image)
        Me.StylizedColorButton11.Location = New System.Drawing.Point(404, 6)
        Me.StylizedColorButton11.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton11.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton11.Name = "StylizedColorButton11"
        Me.StylizedColorButton11.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton11.RightClickMode = True
        Me.StylizedColorButton11.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton11.TabIndex = 10
        Me.StylizedColorButton11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton11.UseVisualStyleBackColor = True
        '
        'StylizedColorButton12
        '
        Me.StylizedColorButton12.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton12.Color = System.Drawing.Color.OliveDrab
        Me.StylizedColorButton12.Image = CType(resources.GetObject("StylizedColorButton12.Image"), System.Drawing.Image)
        Me.StylizedColorButton12.Location = New System.Drawing.Point(440, 6)
        Me.StylizedColorButton12.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton12.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton12.Name = "StylizedColorButton12"
        Me.StylizedColorButton12.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton12.RightClickMode = True
        Me.StylizedColorButton12.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton12.TabIndex = 11
        Me.StylizedColorButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton12.UseVisualStyleBackColor = True
        '
        'StylizedColorButton20
        '
        Me.StylizedColorButton20.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton20.Color = System.Drawing.Color.Green
        Me.StylizedColorButton20.Image = CType(resources.GetObject("StylizedColorButton20.Image"), System.Drawing.Image)
        Me.StylizedColorButton20.Location = New System.Drawing.Point(476, 6)
        Me.StylizedColorButton20.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton20.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton20.Name = "StylizedColorButton20"
        Me.StylizedColorButton20.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton20.RightClickMode = True
        Me.StylizedColorButton20.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton20.TabIndex = 12
        Me.StylizedColorButton20.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton20.UseVisualStyleBackColor = True
        '
        'StylizedColorButton21
        '
        Me.StylizedColorButton21.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton21.Color = System.Drawing.Color.DarkGreen
        Me.StylizedColorButton21.Image = CType(resources.GetObject("StylizedColorButton21.Image"), System.Drawing.Image)
        Me.StylizedColorButton21.Location = New System.Drawing.Point(512, 6)
        Me.StylizedColorButton21.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton21.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton21.Name = "StylizedColorButton21"
        Me.StylizedColorButton21.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton21.RightClickMode = True
        Me.StylizedColorButton21.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton21.TabIndex = 13
        Me.StylizedColorButton21.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton21.UseVisualStyleBackColor = True
        '
        'StylizedColorButton13
        '
        Me.StylizedColorButton13.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton13.Color = System.Drawing.Color.CadetBlue
        Me.StylizedColorButton13.Image = CType(resources.GetObject("StylizedColorButton13.Image"), System.Drawing.Image)
        Me.StylizedColorButton13.Location = New System.Drawing.Point(548, 6)
        Me.StylizedColorButton13.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton13.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton13.Name = "StylizedColorButton13"
        Me.StylizedColorButton13.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton13.RightClickMode = True
        Me.StylizedColorButton13.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton13.TabIndex = 14
        Me.StylizedColorButton13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton13.UseVisualStyleBackColor = True
        '
        'StylizedColorButton14
        '
        Me.StylizedColorButton14.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton14.Color = System.Drawing.Color.DeepSkyBlue
        Me.StylizedColorButton14.Image = CType(resources.GetObject("StylizedColorButton14.Image"), System.Drawing.Image)
        Me.StylizedColorButton14.Location = New System.Drawing.Point(584, 6)
        Me.StylizedColorButton14.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton14.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton14.Name = "StylizedColorButton14"
        Me.StylizedColorButton14.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton14.RightClickMode = True
        Me.StylizedColorButton14.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton14.TabIndex = 15
        Me.StylizedColorButton14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton14.UseVisualStyleBackColor = True
        '
        'StylizedColorButton15
        '
        Me.StylizedColorButton15.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton15.Color = System.Drawing.Color.Blue
        Me.StylizedColorButton15.Image = CType(resources.GetObject("StylizedColorButton15.Image"), System.Drawing.Image)
        Me.StylizedColorButton15.Location = New System.Drawing.Point(620, 6)
        Me.StylizedColorButton15.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton15.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton15.Name = "StylizedColorButton15"
        Me.StylizedColorButton15.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton15.RightClickMode = True
        Me.StylizedColorButton15.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton15.TabIndex = 16
        Me.StylizedColorButton15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton15.UseVisualStyleBackColor = True
        '
        'StylizedColorButton16
        '
        Me.StylizedColorButton16.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton16.Color = System.Drawing.Color.DarkSlateBlue
        Me.StylizedColorButton16.Image = CType(resources.GetObject("StylizedColorButton16.Image"), System.Drawing.Image)
        Me.StylizedColorButton16.Location = New System.Drawing.Point(656, 6)
        Me.StylizedColorButton16.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton16.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton16.Name = "StylizedColorButton16"
        Me.StylizedColorButton16.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton16.RightClickMode = True
        Me.StylizedColorButton16.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton16.TabIndex = 17
        Me.StylizedColorButton16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton16.UseVisualStyleBackColor = True
        '
        'StylizedColorButton17
        '
        Me.StylizedColorButton17.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton17.Color = System.Drawing.Color.Purple
        Me.StylizedColorButton17.Image = CType(resources.GetObject("StylizedColorButton17.Image"), System.Drawing.Image)
        Me.StylizedColorButton17.Location = New System.Drawing.Point(692, 6)
        Me.StylizedColorButton17.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton17.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton17.Name = "StylizedColorButton17"
        Me.StylizedColorButton17.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton17.RightClickMode = True
        Me.StylizedColorButton17.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton17.TabIndex = 18
        Me.StylizedColorButton17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton17.UseVisualStyleBackColor = True
        '
        'StylizedColorButton18
        '
        Me.StylizedColorButton18.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton18.Color = System.Drawing.Color.DeepPink
        Me.StylizedColorButton18.Image = CType(resources.GetObject("StylizedColorButton18.Image"), System.Drawing.Image)
        Me.StylizedColorButton18.Location = New System.Drawing.Point(728, 6)
        Me.StylizedColorButton18.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton18.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton18.Name = "StylizedColorButton18"
        Me.StylizedColorButton18.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton18.RightClickMode = True
        Me.StylizedColorButton18.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton18.TabIndex = 19
        Me.StylizedColorButton18.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton18.UseVisualStyleBackColor = True
        '
        'StylizedColorButton19
        '
        Me.StylizedColorButton19.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton19.Color = System.Drawing.Color.Fuchsia
        Me.StylizedColorButton19.Image = CType(resources.GetObject("StylizedColorButton19.Image"), System.Drawing.Image)
        Me.StylizedColorButton19.Location = New System.Drawing.Point(764, 6)
        Me.StylizedColorButton19.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton19.MinimumSize = New System.Drawing.Size(2, 16)
        Me.StylizedColorButton19.Name = "StylizedColorButton19"
        Me.StylizedColorButton19.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.StylizedColorButton19.RightClickMode = True
        Me.StylizedColorButton19.Size = New System.Drawing.Size(32, 33)
        Me.StylizedColorButton19.TabIndex = 20
        Me.StylizedColorButton19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StylizedColorButton19.UseVisualStyleBackColor = True
        '
        'rbHighlight
        '
        Me.rbHighlight.AutoSize = True
        Me.rbHighlight.BackColor = System.Drawing.Color.Transparent
        Me.rbHighlight.Location = New System.Drawing.Point(53, 9)
        Me.rbHighlight.Margin = New System.Windows.Forms.Padding(2)
        Me.rbHighlight.Name = "rbHighlight"
        Me.rbHighlight.Size = New System.Drawing.Size(66, 17)
        Me.rbHighlight.TabIndex = 1
        Me.rbHighlight.Text = "Highlight"
        Me.rbHighlight.UseVisualStyleBackColor = False
        '
        'rbTextColor
        '
        Me.rbTextColor.AutoSize = True
        Me.rbTextColor.BackColor = System.Drawing.Color.Transparent
        Me.rbTextColor.Checked = True
        Me.rbTextColor.Location = New System.Drawing.Point(6, 9)
        Me.rbTextColor.Margin = New System.Windows.Forms.Padding(2)
        Me.rbTextColor.Name = "rbTextColor"
        Me.rbTextColor.Size = New System.Drawing.Size(46, 17)
        Me.rbTextColor.TabIndex = 0
        Me.rbTextColor.TabStop = True
        Me.rbTextColor.Text = "Text"
        Me.rbTextColor.UseVisualStyleBackColor = False
        '
        'FontToolStrip
        '
        Me.FontToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FontToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FontToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripButton, Me.ToolStripSeparator9, Me.BoldToolStripButton, Me.ItalicToolStripButton, Me.UnderlineToolStripButton, Me.StrikeToolStripButton, Me.ToolStripSeparator5, Me.AlignLeftToolStripButton, Me.AlignCenterToolStripButton, Me.AlignRightToolStripButton, Me.ToolStripSeparator8, Me.IndentToolStripComboBox, Me.IndentToolStripButton})
        Me.FontToolStrip.Location = New System.Drawing.Point(293, 0)
        Me.FontToolStrip.MinimumSize = New System.Drawing.Size(0, 38)
        Me.FontToolStrip.Name = "FontToolStrip"
        Me.FontToolStrip.Size = New System.Drawing.Size(366, 38)
        Me.FontToolStrip.TabIndex = 1
        '
        'FontToolStripButton
        '
        Me.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), System.Drawing.Image)
        Me.FontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontToolStripButton.Name = "FontToolStripButton"
        Me.FontToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.FontToolStripButton.Text = "Font"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 38)
        '
        'BoldToolStripButton
        '
        Me.BoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BoldToolStripButton.Image = CType(resources.GetObject("BoldToolStripButton.Image"), System.Drawing.Image)
        Me.BoldToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BoldToolStripButton.Name = "BoldToolStripButton"
        Me.BoldToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.BoldToolStripButton.Text = "Bold"
        '
        'ItalicToolStripButton
        '
        Me.ItalicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItalicToolStripButton.Image = CType(resources.GetObject("ItalicToolStripButton.Image"), System.Drawing.Image)
        Me.ItalicToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ItalicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ItalicToolStripButton.Name = "ItalicToolStripButton"
        Me.ItalicToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.ItalicToolStripButton.Text = "Italic"
        '
        'UnderlineToolStripButton
        '
        Me.UnderlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UnderlineToolStripButton.Image = CType(resources.GetObject("UnderlineToolStripButton.Image"), System.Drawing.Image)
        Me.UnderlineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UnderlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UnderlineToolStripButton.Name = "UnderlineToolStripButton"
        Me.UnderlineToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.UnderlineToolStripButton.Text = "Underline"
        '
        'StrikeToolStripButton
        '
        Me.StrikeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StrikeToolStripButton.Image = CType(resources.GetObject("StrikeToolStripButton.Image"), System.Drawing.Image)
        Me.StrikeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StrikeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StrikeToolStripButton.Name = "StrikeToolStripButton"
        Me.StrikeToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.StrikeToolStripButton.Text = "Strike"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 38)
        '
        'AlignLeftToolStripButton
        '
        Me.AlignLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignLeftToolStripButton.Image = CType(resources.GetObject("AlignLeftToolStripButton.Image"), System.Drawing.Image)
        Me.AlignLeftToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignLeftToolStripButton.Name = "AlignLeftToolStripButton"
        Me.AlignLeftToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.AlignLeftToolStripButton.Text = "Align Left"
        '
        'AlignCenterToolStripButton
        '
        Me.AlignCenterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignCenterToolStripButton.Image = CType(resources.GetObject("AlignCenterToolStripButton.Image"), System.Drawing.Image)
        Me.AlignCenterToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignCenterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignCenterToolStripButton.Name = "AlignCenterToolStripButton"
        Me.AlignCenterToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.AlignCenterToolStripButton.Text = "Align Center"
        '
        'AlignRightToolStripButton
        '
        Me.AlignRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignRightToolStripButton.Image = CType(resources.GetObject("AlignRightToolStripButton.Image"), System.Drawing.Image)
        Me.AlignRightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignRightToolStripButton.Name = "AlignRightToolStripButton"
        Me.AlignRightToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.AlignRightToolStripButton.Text = "Align Right"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 38)
        '
        'IndentToolStripComboBox
        '
        Me.IndentToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IndentToolStripComboBox.Name = "IndentToolStripComboBox"
        Me.IndentToolStripComboBox.Size = New System.Drawing.Size(100, 38)
        '
        'IndentToolStripButton
        '
        Me.IndentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IndentToolStripButton.Image = CType(resources.GetObject("IndentToolStripButton.Image"), System.Drawing.Image)
        Me.IndentToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IndentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IndentToolStripButton.Name = "IndentToolStripButton"
        Me.IndentToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.IndentToolStripButton.Text = "Indent"
        '
        'FileToolStrip
        '
        Me.FileToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FileToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FileToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.PastePlainToolStripButton, Me.toolStripSeparator2, Me.UndoToolStripButton, Me.RedoToolStripButton, Me.ToolStripSeparator14, Me.CharacterEditorToolStripButton})
        Me.FileToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.FileToolStrip.MinimumSize = New System.Drawing.Size(0, 38)
        Me.FileToolStrip.Name = "FileToolStrip"
        Me.FileToolStrip.Size = New System.Drawing.Size(290, 38)
        Me.FileToolStrip.TabIndex = 0
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.NewToolStripButton.Text = "New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.OpenToolStripButton.Text = "Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.SaveToolStripButton.Text = "Save"
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
        Me.CutToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.CutToolStripButton.Text = "Cut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.CopyToolStripButton.Text = "Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.PasteToolStripButton.Text = "Paste"
        '
        'PastePlainToolStripButton
        '
        Me.PastePlainToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PastePlainToolStripButton.Image = CType(resources.GetObject("PastePlainToolStripButton.Image"), System.Drawing.Image)
        Me.PastePlainToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PastePlainToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PastePlainToolStripButton.Name = "PastePlainToolStripButton"
        Me.PastePlainToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.PastePlainToolStripButton.Text = "Paste Text"
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
        Me.UndoToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.UndoToolStripButton.Text = "Undo"
        '
        'RedoToolStripButton
        '
        Me.RedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RedoToolStripButton.Image = CType(resources.GetObject("RedoToolStripButton.Image"), System.Drawing.Image)
        Me.RedoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RedoToolStripButton.Name = "RedoToolStripButton"
        Me.RedoToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.RedoToolStripButton.Text = "Redo"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 38)
        '
        'CharacterEditorToolStripButton
        '
        Me.CharacterEditorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CharacterEditorToolStripButton.Image = CType(resources.GetObject("CharacterEditorToolStripButton.Image"), System.Drawing.Image)
        Me.CharacterEditorToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CharacterEditorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CharacterEditorToolStripButton.Name = "CharacterEditorToolStripButton"
        Me.CharacterEditorToolStripButton.Size = New System.Drawing.Size(26, 35)
        Me.CharacterEditorToolStripButton.Text = "Character Editor"
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.AutoScroll = True
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.pnlDocumentProperties)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Size = New System.Drawing.Size(348, 737)
        Me.StylizedPanel1.TabIndex = 13
        '
        'pnlDocumentProperties
        '
        Me.pnlDocumentProperties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDocumentProperties.Location = New System.Drawing.Point(0, 0)
        Me.pnlDocumentProperties.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlDocumentProperties.MinimumSize = New System.Drawing.Size(272, 0)
        Me.pnlDocumentProperties.Name = "pnlDocumentProperties"
        Me.pnlDocumentProperties.Size = New System.Drawing.Size(348, 737)
        Me.pnlDocumentProperties.TabIndex = 0
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Notebook file (*.nt)|*.nt|Zip files (*.zip)|*.zip|All files (*.*)|*.*"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Notebook file (*.nt)|*.nt|Thorn Writer File (*.thw)|*.thw|Zip files (*.zip)|*.zip" &
    "|All files (*.*)|*.*"
        '
        'dlgSaveImage
        '
        Me.dlgSaveImage.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*"
        '
        'MainMenu
        '
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.PageToolStripMenuItem, Me.InsertToolStripMenuItem, Me.StyleToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MainMenu.Size = New System.Drawing.Size(1257, 24)
        Me.MainMenu.TabIndex = 75
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator3, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator4, Me.PrintToolStripMenuItem, Me.PageSetupToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.ToolStripMenuItem22, Me.RTFEditorToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(183, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = CType(resources.GetObject("SaveAsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveAsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(183, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.PrintToolStripMenuItem.Text = "Print..."
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Image = CType(resources.GetObject("PageSetupToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PageSetupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup..."
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview..."
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(183, 6)
        '
        'RTFEditorToolStripMenuItem
        '
        Me.RTFEditorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RTFEditorToolStripMenuItem.Name = "RTFEditorToolStripMenuItem"
        Me.RTFEditorToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.RTFEditorToolStripMenuItem.Text = "RTF Editor..."
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator6, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.PastePlainToolStripMenuItem, Me.ToolStripMenuItem25, Me.FindToolStripMenuItem, Me.toolStripSeparator7, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UndoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(149, 28)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RedoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(149, 28)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(146, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(149, 28)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(149, 28)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(149, 28)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'PastePlainToolStripMenuItem
        '
        Me.PastePlainToolStripMenuItem.Image = CType(resources.GetObject("PastePlainToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PastePlainToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PastePlainToolStripMenuItem.Name = "PastePlainToolStripMenuItem"
        Me.PastePlainToolStripMenuItem.Size = New System.Drawing.Size(149, 28)
        Me.PastePlainToolStripMenuItem.Text = "Paste Text"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(146, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = CType(resources.GetObject("FindToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FindToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(149, 28)
        Me.FindToolStripMenuItem.Text = "Find/Replace"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(146, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Image = CType(resources.GetObject("SelectAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SelectAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(149, 28)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomInToolStripMenuItem, Me.ZoomOutToolStripMenuItem, Me.ToolStripMenuItem27, Me.ZoomToolStripMenuItem, Me.EditZoomToolStripMenuItem, Me.ToolStripMenuItem26, Me.WordWrapToolStripMenuItem, Me.ToolStripMenuItem1, Me.FullModeToolStripMenuItem, Me.MinimalModeToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToggleSidebarToolStripMenuItem, Me.ToggleStatusbarToolStripMenuItem, Me.ToggleCommonToolbarToolStripMenuItem, Me.ToogleFormattingToolbarToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ZoomInToolStripMenuItem
        '
        Me.ZoomInToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        Me.ZoomInToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.ZoomInToolStripMenuItem.Text = "Zoom In"
        '
        'ZoomOutToolStripMenuItem
        '
        Me.ZoomOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        Me.ZoomOutToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.ZoomOutToolStripMenuItem.Text = "Zoom Out"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(216, 6)
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.ZoomToolStripMenuItem.Text = "100% Zoom"
        '
        'EditZoomToolStripMenuItem
        '
        Me.EditZoomToolStripMenuItem.Image = CType(resources.GetObject("EditZoomToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditZoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditZoomToolStripMenuItem.Name = "EditZoomToolStripMenuItem"
        Me.EditZoomToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.EditZoomToolStripMenuItem.Text = "Custom Zoom..."
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(216, 6)
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.CheckOnClick = True
        Me.WordWrapToolStripMenuItem.Image = CType(resources.GetObject("WordWrapToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WordWrapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.WordWrapToolStripMenuItem.Text = "Word Wrap"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(216, 6)
        '
        'FullModeToolStripMenuItem
        '
        Me.FullModeToolStripMenuItem.Name = "FullModeToolStripMenuItem"
        Me.FullModeToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.FullModeToolStripMenuItem.Text = "Full Mode"
        '
        'MinimalModeToolStripMenuItem
        '
        Me.MinimalModeToolStripMenuItem.Name = "MinimalModeToolStripMenuItem"
        Me.MinimalModeToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.MinimalModeToolStripMenuItem.Text = "Minimal Mode"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(216, 6)
        '
        'ToggleSidebarToolStripMenuItem
        '
        Me.ToggleSidebarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToggleSidebarToolStripMenuItem.Name = "ToggleSidebarToolStripMenuItem"
        Me.ToggleSidebarToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.ToggleSidebarToolStripMenuItem.Text = "Toggle Sidebar"
        '
        'ToggleStatusbarToolStripMenuItem
        '
        Me.ToggleStatusbarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToggleStatusbarToolStripMenuItem.Name = "ToggleStatusbarToolStripMenuItem"
        Me.ToggleStatusbarToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.ToggleStatusbarToolStripMenuItem.Text = "Toggle Statusbar"
        '
        'ToggleCommonToolbarToolStripMenuItem
        '
        Me.ToggleCommonToolbarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToggleCommonToolbarToolStripMenuItem.Name = "ToggleCommonToolbarToolStripMenuItem"
        Me.ToggleCommonToolbarToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.ToggleCommonToolbarToolStripMenuItem.Text = "Toggle Common Toolbar"
        '
        'ToogleFormattingToolbarToolStripMenuItem
        '
        Me.ToogleFormattingToolbarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToogleFormattingToolbarToolStripMenuItem.Name = "ToogleFormattingToolbarToolStripMenuItem"
        Me.ToogleFormattingToolbarToolStripMenuItem.Size = New System.Drawing.Size(219, 28)
        Me.ToogleFormattingToolbarToolStripMenuItem.Text = "Toogle Formatting Toolbar"
        '
        'PageToolStripMenuItem
        '
        Me.PageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPageToolStripMenuItem, Me.RemovePageToolStripMenuItem, Me.DuplicatePageToolStripMenuItem, Me.ToolStripMenuItem28, Me.ImportPageToolStripMenuItem, Me.ExportPageToolStripMenuItem, Me.ToolStripMenuItem29, Me.RenamePageToolStripMenuItem, Me.ToolStripMenuItem3, Me.DictionaryMenuItem})
        Me.PageToolStripMenuItem.Name = "PageToolStripMenuItem"
        Me.PageToolStripMenuItem.Size = New System.Drawing.Size(72, 22)
        Me.PageToolStripMenuItem.Text = "Notebook"
        '
        'AddPageToolStripMenuItem
        '
        Me.AddPageToolStripMenuItem.Image = CType(resources.GetObject("AddPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddPageToolStripMenuItem.Name = "AddPageToolStripMenuItem"
        Me.AddPageToolStripMenuItem.Size = New System.Drawing.Size(161, 28)
        Me.AddPageToolStripMenuItem.Text = "Add Page"
        '
        'RemovePageToolStripMenuItem
        '
        Me.RemovePageToolStripMenuItem.Image = CType(resources.GetObject("RemovePageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemovePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemovePageToolStripMenuItem.Name = "RemovePageToolStripMenuItem"
        Me.RemovePageToolStripMenuItem.Size = New System.Drawing.Size(161, 28)
        Me.RemovePageToolStripMenuItem.Text = "Remove Page"
        '
        'DuplicatePageToolStripMenuItem
        '
        Me.DuplicatePageToolStripMenuItem.Image = CType(resources.GetObject("DuplicatePageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DuplicatePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DuplicatePageToolStripMenuItem.Name = "DuplicatePageToolStripMenuItem"
        Me.DuplicatePageToolStripMenuItem.Size = New System.Drawing.Size(161, 28)
        Me.DuplicatePageToolStripMenuItem.Text = "Duplicate Page"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(158, 6)
        '
        'ImportPageToolStripMenuItem
        '
        Me.ImportPageToolStripMenuItem.Image = CType(resources.GetObject("ImportPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImportPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportPageToolStripMenuItem.Name = "ImportPageToolStripMenuItem"
        Me.ImportPageToolStripMenuItem.Size = New System.Drawing.Size(161, 28)
        Me.ImportPageToolStripMenuItem.Text = "Import Page..."
        '
        'ExportPageToolStripMenuItem
        '
        Me.ExportPageToolStripMenuItem.Image = CType(resources.GetObject("ExportPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExportPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportPageToolStripMenuItem.Name = "ExportPageToolStripMenuItem"
        Me.ExportPageToolStripMenuItem.Size = New System.Drawing.Size(161, 28)
        Me.ExportPageToolStripMenuItem.Text = "Export Page..."
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(158, 6)
        '
        'RenamePageToolStripMenuItem
        '
        Me.RenamePageToolStripMenuItem.Image = CType(resources.GetObject("RenamePageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenamePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RenamePageToolStripMenuItem.Name = "RenamePageToolStripMenuItem"
        Me.RenamePageToolStripMenuItem.Size = New System.Drawing.Size(161, 28)
        Me.RenamePageToolStripMenuItem.Text = "Rename Page..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(158, 6)
        '
        'DictionaryMenuItem
        '
        Me.DictionaryMenuItem.Image = CType(resources.GetObject("DictionaryMenuItem.Image"), System.Drawing.Image)
        Me.DictionaryMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DictionaryMenuItem.Name = "DictionaryMenuItem"
        Me.DictionaryMenuItem.Size = New System.Drawing.Size(161, 28)
        Me.DictionaryMenuItem.Text = "Dictionary..."
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImageToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(48, 22)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Image = CType(resources.GetObject("ImageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(122, 28)
        Me.ImageToolStripMenuItem.Text = "Image..."
        '
        'StyleToolStripMenuItem
        '
        Me.StyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorPanelToolStripMenuItem, Me.ToolStripSeparator13, Me.InsertBulletsToolStripMenuItem, Me.RemoveBulletsToolStripMenuItem, Me.ToolStripMenuItem24, Me.DefaultStyleToolStripMenuItem, Me.EditStyleToolStripMenuItem, Me.ApplyStyleToolStripMenuItem, Me.ToolStripMenuItem31, Me.SubscriptToolStripMenuItem, Me.SuperscriptToolStripMenuItem, Me.BaselineToolStripMenuItem, Me.ToolStripMenuItem32, Me.TextColorToolStripMenuItem, Me.HighlightToolStripMenuItem})
        Me.StyleToolStripMenuItem.Name = "StyleToolStripMenuItem"
        Me.StyleToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.StyleToolStripMenuItem.Text = "Style"
        '
        'ColorPanelToolStripMenuItem
        '
        Me.ColorPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ColorPanelToolStripMenuItem.Name = "ColorPanelToolStripMenuItem"
        Me.ColorPanelToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.ColorPanelToolStripMenuItem.Text = "Toggle Color Panel"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(176, 6)
        '
        'InsertBulletsToolStripMenuItem
        '
        Me.InsertBulletsToolStripMenuItem.Image = CType(resources.GetObject("InsertBulletsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InsertBulletsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InsertBulletsToolStripMenuItem.Name = "InsertBulletsToolStripMenuItem"
        Me.InsertBulletsToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.InsertBulletsToolStripMenuItem.Text = "Insert Bullets"
        '
        'RemoveBulletsToolStripMenuItem
        '
        Me.RemoveBulletsToolStripMenuItem.Image = CType(resources.GetObject("RemoveBulletsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveBulletsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveBulletsToolStripMenuItem.Name = "RemoveBulletsToolStripMenuItem"
        Me.RemoveBulletsToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.RemoveBulletsToolStripMenuItem.Text = "Remove Bullets"
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(176, 6)
        '
        'DefaultStyleToolStripMenuItem
        '
        Me.DefaultStyleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DefaultStyleToolStripMenuItem.Name = "DefaultStyleToolStripMenuItem"
        Me.DefaultStyleToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.DefaultStyleToolStripMenuItem.Text = "Default Style"
        '
        'EditStyleToolStripMenuItem
        '
        Me.EditStyleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditStyleToolStripMenuItem.Name = "EditStyleToolStripMenuItem"
        Me.EditStyleToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.EditStyleToolStripMenuItem.Text = "Edit Style..."
        '
        'ApplyStyleToolStripMenuItem
        '
        Me.ApplyStyleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ApplyStyleToolStripMenuItem.Name = "ApplyStyleToolStripMenuItem"
        Me.ApplyStyleToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.ApplyStyleToolStripMenuItem.Text = "Apply Style"
        '
        'ToolStripMenuItem31
        '
        Me.ToolStripMenuItem31.Name = "ToolStripMenuItem31"
        Me.ToolStripMenuItem31.Size = New System.Drawing.Size(176, 6)
        '
        'SubscriptToolStripMenuItem
        '
        Me.SubscriptToolStripMenuItem.Image = CType(resources.GetObject("SubscriptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SubscriptToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SubscriptToolStripMenuItem.Name = "SubscriptToolStripMenuItem"
        Me.SubscriptToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.SubscriptToolStripMenuItem.Text = "Subscript"
        '
        'SuperscriptToolStripMenuItem
        '
        Me.SuperscriptToolStripMenuItem.Image = CType(resources.GetObject("SuperscriptToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SuperscriptToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SuperscriptToolStripMenuItem.Name = "SuperscriptToolStripMenuItem"
        Me.SuperscriptToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.SuperscriptToolStripMenuItem.Text = "Superscript"
        '
        'BaselineToolStripMenuItem
        '
        Me.BaselineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BaselineToolStripMenuItem.Name = "BaselineToolStripMenuItem"
        Me.BaselineToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.BaselineToolStripMenuItem.Text = "Baseline"
        '
        'ToolStripMenuItem32
        '
        Me.ToolStripMenuItem32.Name = "ToolStripMenuItem32"
        Me.ToolStripMenuItem32.Size = New System.Drawing.Size(176, 6)
        '
        'TextColorToolStripMenuItem
        '
        Me.TextColorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TextColorToolStripMenuItem.Name = "TextColorToolStripMenuItem"
        Me.TextColorToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.TextColorToolStripMenuItem.Text = "Text Color..."
        '
        'HighlightToolStripMenuItem
        '
        Me.HighlightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HighlightToolStripMenuItem.Name = "HighlightToolStripMenuItem"
        Me.HighlightToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.HighlightToolStripMenuItem.Text = "Highlight..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CharacterEditorToolStripMenuItem, Me.ToolStripMenuItem4, Me.UpdateToolStripMenuItem, Me.ToolStripMenuItem23, Me.SettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 22)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CharacterEditorToolStripMenuItem
        '
        Me.CharacterEditorToolStripMenuItem.Image = CType(resources.GetObject("CharacterEditorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CharacterEditorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CharacterEditorToolStripMenuItem.Name = "CharacterEditorToolStripMenuItem"
        Me.CharacterEditorToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.CharacterEditorToolStripMenuItem.Text = "Character Editor..."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(171, 6)
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Image = CType(resources.GetObject("UpdateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.UpdateToolStripMenuItem.Text = "Update..."
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(171, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.SettingsToolStripMenuItem.Text = "Settings..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 28)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 761)
        Me.Controls.Add(Me.SplitLayoutPanel)
        Me.Controls.Add(Me.MainMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "Language Pad X.x"
        Me.cmsMain.ResumeLayout(False)
        Me.SplitLayoutPanel.Panel1.ResumeLayout(False)
        Me.SplitLayoutPanel.Panel2.ResumeLayout(False)
        CType(Me.SplitLayoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitLayoutPanel.ResumeLayout(False)
        Me.MainToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.MainToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.MainToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.MainToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.MainToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.MainToolStripContainer.ResumeLayout(False)
        Me.MainToolStripContainer.PerformLayout()
        Me.DataToolStrip.ResumeLayout(False)
        Me.DataToolStrip.PerformLayout()
        Me.pnlFindReplace.ResumeLayout(False)
        Me.pnlFindReplace.PerformLayout()
        Me.pnlColor.ResumeLayout(False)
        Me.pnlColor.PerformLayout()
        Me.ColorLayoutPanel.ResumeLayout(False)
        Me.FontToolStrip.ResumeLayout(False)
        Me.FontToolStrip.PerformLayout()
        Me.FileToolStrip.ResumeLayout(False)
        Me.FileToolStrip.PerformLayout()
        Me.StylizedPanel1.ResumeLayout(False)
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlgOpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents dlgSavePage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgPrintPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents dlgPrint As System.Windows.Forms.PrintDialog
    Friend WithEvents dlgOpenPage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents pdMain As System.Drawing.Printing.PrintDocument
    Friend WithEvents pnlFindReplace As TundraLib.DoubleBufferedPanel
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnReplaceAll As System.Windows.Forms.Button
    Friend WithEvents btnFindNext As System.Windows.Forms.Button
    Friend WithEvents cmsMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeselectAllContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitLayoutPanel As System.Windows.Forms.SplitContainer
    Friend WithEvents tcNotebook As System.Windows.Forms.TabControl
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StylizedPanel1 As TundraLib.DoubleBufferedPanel
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents dlgSaveImage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MainToolStripContainer As ToolStripContainer
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
    Friend WithEvents InsertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents pnlColor As TundraLib.DoubleBufferedPanel
    Friend WithEvents ColorLayoutPanel As FlowLayoutPanel
    Friend WithEvents StylizedColorButton1 As TundraLib.StylizedColorButton
    Friend WithEvents rbHighlight As RadioButton
    Friend WithEvents rbTextColor As RadioButton
    Friend WithEvents ColorPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents StylizedColorButton2 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton3 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton4 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton5 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton6 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton7 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton8 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton9 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton10 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton11 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton12 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton13 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton14 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton15 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton16 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton17 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton18 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton19 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton20 As TundraLib.StylizedColorButton
    Friend WithEvents StylizedColorButton21 As TundraLib.StylizedColorButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToggleSidebarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleCommonToolbarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToogleFormattingToolbarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleStatusbarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimalModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents btnTransparentColor As Button
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents DictionaryMenuItem As ToolStripMenuItem
    Friend WithEvents pnlDocumentProperties As PropertiesEditor
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents CharacterEditorToolStripButton As ToolStripButton
    Friend WithEvents CharacterEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
End Class
