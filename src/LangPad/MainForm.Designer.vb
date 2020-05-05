<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.OpenImageDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FontPicker = New System.Windows.Forms.FontDialog()
        Me.SavePageDialog = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDocumentDialogPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocumentDialog = New System.Windows.Forms.PrintDialog()
        Me.OpenPageDialog = New System.Windows.Forms.OpenFileDialog()
        Me.PrintPageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        Me.PagePrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.MainContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PastePlainContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeselectAllContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitLayoutPanel = New System.Windows.Forms.SplitContainer()
        Me.PropertiesContainerPanel = New LangPadUI.DoubleBufferedPanel()
        Me.NotebookEditorPanel = New LangPad.NotebookEditor()
        Me.CurrentPageContainerBorder = New LangPadUI.DoubleBufferedPanel()
        Me.CurrentPageContainer = New LangPadUI.DoubleBufferedPanel()
        Me.FindReplacePanel = New LangPadUI.DoubleBufferedPanel()
        Me.FindNextButton = New System.Windows.Forms.Button()
        Me.ReplaceAllButton = New System.Windows.Forms.Button()
        Me.ReplaceTextBox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ReplaceButton = New System.Windows.Forms.Button()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.ColorPanel = New LangPadUI.DoubleBufferedPanel()
        Me.ColorLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TransparentColorButton = New System.Windows.Forms.Button()
        Me.ColorButton1 = New LangPadUI.ColorButton()
        Me.ColorButton2 = New LangPadUI.ColorButton()
        Me.ColorButton3 = New LangPadUI.ColorButton()
        Me.ColorButton4 = New LangPadUI.ColorButton()
        Me.ColorButton5 = New LangPadUI.ColorButton()
        Me.ColorButton6 = New LangPadUI.ColorButton()
        Me.ColorButton7 = New LangPadUI.ColorButton()
        Me.ColorButton8 = New LangPadUI.ColorButton()
        Me.ColorButton9 = New LangPadUI.ColorButton()
        Me.ColorButton10 = New LangPadUI.ColorButton()
        Me.ColorButton11 = New LangPadUI.ColorButton()
        Me.ColorButton12 = New LangPadUI.ColorButton()
        Me.ColorButton20 = New LangPadUI.ColorButton()
        Me.ColorButton21 = New LangPadUI.ColorButton()
        Me.ColorButton13 = New LangPadUI.ColorButton()
        Me.ColorButton14 = New LangPadUI.ColorButton()
        Me.ColorButton15 = New LangPadUI.ColorButton()
        Me.ColorButton16 = New LangPadUI.ColorButton()
        Me.ColorButton17 = New LangPadUI.ColorButton()
        Me.ColorButton18 = New LangPadUI.ColorButton()
        Me.ColorButton19 = New LangPadUI.ColorButton()
        Me.rbHighlight = New System.Windows.Forms.RadioButton()
        Me.TextColorRadio = New System.Windows.Forms.RadioButton()
        Me.MainToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.DataToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CharCountToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.WordCountToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.CurrentLineToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.PageCountLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ThemeCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
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
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.CharacterEditorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DictionaryToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.BoldToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ItalicToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.UnderlineToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StrikeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlignLeftToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlignCenterToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlignRightToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.DecreaseIndentToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.IncreaseIndentToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.MainTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToggleToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicatePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicateAndNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenamePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem29 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PreviousPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.DictionaryMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinguisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.BroadTranscriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NarrowTranscriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveBracketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem32 = New System.Windows.Forms.ToolStripSeparator()
        Me.InsertBulletsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveBulletsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlignLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlignCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlignRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.BoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItalicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnderlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrikeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.IncreaseIndentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseIndentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetIndentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.IncreaseBulletIndentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseBulletIndentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetBulletIndentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.IncreaseHangingIndentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseHangingIndentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetHangingIndentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.SubscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuperscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaselineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.InsertTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatreonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainContextMenu.SuspendLayout()
        CType(Me.SplitLayoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitLayoutPanel.Panel1.SuspendLayout()
        Me.SplitLayoutPanel.Panel2.SuspendLayout()
        Me.SplitLayoutPanel.SuspendLayout()
        Me.PropertiesContainerPanel.SuspendLayout()
        Me.CurrentPageContainerBorder.SuspendLayout()
        Me.FindReplacePanel.SuspendLayout()
        Me.ColorPanel.SuspendLayout()
        Me.ColorLayoutPanel.SuspendLayout()
        Me.MainToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.MainToolStripContainer.ContentPanel.SuspendLayout()
        Me.MainToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.MainToolStripContainer.SuspendLayout()
        Me.DataToolStrip.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenImageDialog
        '
        Me.OpenImageDialog.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif|JPEG " &
    "files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gi" &
    "f|All files (*.*)|*.*"
        Me.OpenImageDialog.Title = "Insert Image"
        '
        'FontPicker
        '
        Me.FontPicker.ShowColor = True
        '
        'SavePageDialog
        '
        Me.SavePageDialog.Filter = "Rich text file (*.rtf)|*.rtf|HTML (*.html)|*.html|Text file (*.txt)|*.txt|All fil" &
    "es (*.*)|*.*"
        '
        'PrintDocumentDialogPreview
        '
        Me.PrintDocumentDialogPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintDocumentDialogPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintDocumentDialogPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintDocumentDialogPreview.Enabled = True
        Me.PrintDocumentDialogPreview.Icon = CType(resources.GetObject("PrintDocumentDialogPreview.Icon"), System.Drawing.Icon)
        Me.PrintDocumentDialogPreview.Name = "PrintDocumentDialogPreview"
        Me.PrintDocumentDialogPreview.Visible = False
        '
        'PrintDocumentDialog
        '
        Me.PrintDocumentDialog.AllowSelection = True
        Me.PrintDocumentDialog.PrintToFile = True
        Me.PrintDocumentDialog.UseEXDialog = True
        '
        'OpenPageDialog
        '
        Me.OpenPageDialog.Filter = "Text files (*.rtf;*.txt)|*.rtf;*.txt|Rich text files (*.rtf)|*.rtf|Text files (*." &
    "txt)|*.txt|All files (*.*)|*.*"
        '
        'PagePrintDocument
        '
        '
        'MainContextMenu
        '
        Me.MainContextMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyContextMenuItem, Me.PasteContextMenuItem, Me.PastePlainContextMenuItem, Me.CutContextMenuItem, Me.ToolStripSeparator1, Me.SelectAllContextMenuItem, Me.DeselectAllContextMenuItem})
        Me.MainContextMenu.Name = "MainContextMenu"
        Me.MainContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainContextMenu.Size = New System.Drawing.Size(176, 202)
        '
        'CopyContextMenuItem
        '
        Me.CopyContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyContextMenuItem.Name = "CopyContextMenuItem"
        Me.CopyContextMenuItem.Size = New System.Drawing.Size(175, 32)
        Me.CopyContextMenuItem.Text = "Copy"
        '
        'PasteContextMenuItem
        '
        Me.PasteContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteContextMenuItem.Name = "PasteContextMenuItem"
        Me.PasteContextMenuItem.Size = New System.Drawing.Size(175, 32)
        Me.PasteContextMenuItem.Text = "Paste"
        '
        'PastePlainContextMenuItem
        '
        Me.PastePlainContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PastePlainContextMenuItem.Name = "PastePlainContextMenuItem"
        Me.PastePlainContextMenuItem.Size = New System.Drawing.Size(175, 32)
        Me.PastePlainContextMenuItem.Text = "Paste Plain"
        '
        'CutContextMenuItem
        '
        Me.CutContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutContextMenuItem.Name = "CutContextMenuItem"
        Me.CutContextMenuItem.Size = New System.Drawing.Size(175, 32)
        Me.CutContextMenuItem.Text = "Cut"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(172, 6)
        '
        'SelectAllContextMenuItem
        '
        Me.SelectAllContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SelectAllContextMenuItem.Name = "SelectAllContextMenuItem"
        Me.SelectAllContextMenuItem.Size = New System.Drawing.Size(175, 32)
        Me.SelectAllContextMenuItem.Text = "Select All"
        '
        'DeselectAllContextMenuItem
        '
        Me.DeselectAllContextMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeselectAllContextMenuItem.Name = "DeselectAllContextMenuItem"
        Me.DeselectAllContextMenuItem.Size = New System.Drawing.Size(175, 32)
        Me.DeselectAllContextMenuItem.Text = "Deselect All"
        '
        'SplitLayoutPanel
        '
        Me.SplitLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitLayoutPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.SplitLayoutPanel.Name = "SplitLayoutPanel"
        '
        'SplitLayoutPanel.Panel1
        '
        Me.SplitLayoutPanel.Panel1.Controls.Add(Me.PropertiesContainerPanel)
        Me.SplitLayoutPanel.Panel1MinSize = 340
        '
        'SplitLayoutPanel.Panel2
        '
        Me.SplitLayoutPanel.Panel2.Controls.Add(Me.CurrentPageContainerBorder)
        Me.SplitLayoutPanel.Panel2.Controls.Add(Me.FindReplacePanel)
        Me.SplitLayoutPanel.Panel2.Controls.Add(Me.ColorPanel)
        Me.SplitLayoutPanel.Size = New System.Drawing.Size(1356, 833)
        Me.SplitLayoutPanel.SplitterDistance = 340
        Me.SplitLayoutPanel.SplitterWidth = 3
        Me.SplitLayoutPanel.TabIndex = 1
        '
        'PropertiesContainerPanel
        '
        Me.PropertiesContainerPanel.AutoScroll = True
        Me.PropertiesContainerPanel.BackColor = System.Drawing.Color.Transparent
        Me.PropertiesContainerPanel.Controls.Add(Me.NotebookEditorPanel)
        Me.PropertiesContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesContainerPanel.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesContainerPanel.Name = "PropertiesContainerPanel"
        Me.PropertiesContainerPanel.Size = New System.Drawing.Size(340, 833)
        Me.PropertiesContainerPanel.TabIndex = 13
        '
        'NotebookEditorPanel
        '
        Me.NotebookEditorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotebookEditorPanel.Location = New System.Drawing.Point(0, 0)
        Me.NotebookEditorPanel.MinimumSize = New System.Drawing.Size(330, 470)
        Me.NotebookEditorPanel.Name = "NotebookEditorPanel"
        Me.NotebookEditorPanel.Size = New System.Drawing.Size(340, 833)
        Me.NotebookEditorPanel.TabIndex = 0
        '
        'CurrentPageContainerBorder
        '
        Me.CurrentPageContainerBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CurrentPageContainerBorder.Controls.Add(Me.CurrentPageContainer)
        Me.CurrentPageContainerBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurrentPageContainerBorder.Location = New System.Drawing.Point(0, 166)
        Me.CurrentPageContainerBorder.Name = "CurrentPageContainerBorder"
        Me.CurrentPageContainerBorder.Padding = New System.Windows.Forms.Padding(1)
        Me.CurrentPageContainerBorder.Size = New System.Drawing.Size(1013, 667)
        Me.CurrentPageContainerBorder.TabIndex = 76
        '
        'CurrentPageContainer
        '
        Me.CurrentPageContainer.BackColor = System.Drawing.SystemColors.Window
        Me.CurrentPageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurrentPageContainer.Location = New System.Drawing.Point(1, 1)
        Me.CurrentPageContainer.Name = "CurrentPageContainer"
        Me.CurrentPageContainer.Padding = New System.Windows.Forms.Padding(3)
        Me.CurrentPageContainer.Size = New System.Drawing.Size(1011, 665)
        Me.CurrentPageContainer.TabIndex = 75
        '
        'FindReplacePanel
        '
        Me.FindReplacePanel.BackColor = System.Drawing.Color.Transparent
        Me.FindReplacePanel.Controls.Add(Me.FindNextButton)
        Me.FindReplacePanel.Controls.Add(Me.ReplaceAllButton)
        Me.FindReplacePanel.Controls.Add(Me.ReplaceTextBox)
        Me.FindReplacePanel.Controls.Add(Me.Label18)
        Me.FindReplacePanel.Controls.Add(Me.FindTextBox)
        Me.FindReplacePanel.Controls.Add(Me.Label17)
        Me.FindReplacePanel.Controls.Add(Me.ReplaceButton)
        Me.FindReplacePanel.Controls.Add(Me.FindButton)
        Me.FindReplacePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FindReplacePanel.Location = New System.Drawing.Point(0, 112)
        Me.FindReplacePanel.Name = "FindReplacePanel"
        Me.FindReplacePanel.Size = New System.Drawing.Size(1013, 54)
        Me.FindReplacePanel.TabIndex = 72
        Me.FindReplacePanel.Visible = False
        '
        'FindNextButton
        '
        Me.FindNextButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FindNextButton.Location = New System.Drawing.Point(597, 8)
        Me.FindNextButton.Name = "FindNextButton"
        Me.FindNextButton.Size = New System.Drawing.Size(117, 37)
        Me.FindNextButton.TabIndex = 69
        Me.FindNextButton.Text = " Find Next"
        Me.FindNextButton.UseVisualStyleBackColor = False
        '
        'ReplaceAllButton
        '
        Me.ReplaceAllButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ReplaceAllButton.Location = New System.Drawing.Point(843, 8)
        Me.ReplaceAllButton.Name = "ReplaceAllButton"
        Me.ReplaceAllButton.Size = New System.Drawing.Size(117, 37)
        Me.ReplaceAllButton.TabIndex = 71
        Me.ReplaceAllButton.Text = "Replace All"
        Me.ReplaceAllButton.UseVisualStyleBackColor = False
        '
        'ReplaceTextBox
        '
        Me.ReplaceTextBox.Location = New System.Drawing.Point(304, 14)
        Me.ReplaceTextBox.Name = "ReplaceTextBox"
        Me.ReplaceTextBox.Size = New System.Drawing.Size(166, 26)
        Me.ReplaceTextBox.TabIndex = 67
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(225, 17)
        Me.Label18.Margin = New System.Windows.Forms.Padding(3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 20)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "Replace:"
        '
        'FindTextBox
        '
        Me.FindTextBox.Location = New System.Drawing.Point(60, 14)
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(160, 26)
        Me.FindTextBox.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 17)
        Me.Label17.Margin = New System.Windows.Forms.Padding(3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 20)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Find:"
        '
        'ReplaceButton
        '
        Me.ReplaceButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ReplaceButton.Location = New System.Drawing.Point(720, 8)
        Me.ReplaceButton.Name = "ReplaceButton"
        Me.ReplaceButton.Size = New System.Drawing.Size(117, 37)
        Me.ReplaceButton.TabIndex = 70
        Me.ReplaceButton.Text = "Replace"
        Me.ReplaceButton.UseVisualStyleBackColor = False
        '
        'FindButton
        '
        Me.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FindButton.Location = New System.Drawing.Point(476, 8)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(117, 37)
        Me.FindButton.TabIndex = 68
        Me.FindButton.Text = "Find"
        Me.FindButton.UseVisualStyleBackColor = False
        '
        'ColorPanel
        '
        Me.ColorPanel.BackColor = System.Drawing.Color.Transparent
        Me.ColorPanel.Controls.Add(Me.ColorLayoutPanel)
        Me.ColorPanel.Controls.Add(Me.rbHighlight)
        Me.ColorPanel.Controls.Add(Me.TextColorRadio)
        Me.ColorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ColorPanel.Location = New System.Drawing.Point(0, 0)
        Me.ColorPanel.Name = "ColorPanel"
        Me.ColorPanel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ColorPanel.Size = New System.Drawing.Size(1013, 112)
        Me.ColorPanel.TabIndex = 74
        Me.ColorPanel.Visible = False
        '
        'ColorLayoutPanel
        '
        Me.ColorLayoutPanel.AutoScroll = True
        Me.ColorLayoutPanel.AutoScrollMargin = New System.Drawing.Size(15, 5)
        Me.ColorLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.ColorLayoutPanel.Controls.Add(Me.TransparentColorButton)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton1)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton2)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton3)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton4)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton5)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton6)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton7)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton8)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton9)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton10)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton11)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton12)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton20)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton21)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton13)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton14)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton15)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton16)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton17)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton18)
        Me.ColorLayoutPanel.Controls.Add(Me.ColorButton19)
        Me.ColorLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ColorLayoutPanel.Location = New System.Drawing.Point(0, 51)
        Me.ColorLayoutPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.ColorLayoutPanel.Name = "ColorLayoutPanel"
        Me.ColorLayoutPanel.Padding = New System.Windows.Forms.Padding(6)
        Me.ColorLayoutPanel.Size = New System.Drawing.Size(1013, 59)
        Me.ColorLayoutPanel.TabIndex = 70
        '
        'TransparentColorButton
        '
        Me.TransparentColorButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.TransparentColorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransparentColorButton.ForeColor = System.Drawing.Color.Red
        Me.TransparentColorButton.Location = New System.Drawing.Point(10, 11)
        Me.TransparentColorButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TransparentColorButton.MinimumSize = New System.Drawing.Size(36, 36)
        Me.TransparentColorButton.Name = "TransparentColorButton"
        Me.TransparentColorButton.Padding = New System.Windows.Forms.Padding(2)
        Me.TransparentColorButton.Size = New System.Drawing.Size(36, 36)
        Me.TransparentColorButton.TabIndex = 21
        Me.TransparentColorButton.Text = "X"
        Me.MainTooltip.SetToolTip(Me.TransparentColorButton, "Transparent")
        Me.TransparentColorButton.UseVisualStyleBackColor = True
        '
        'ColorButton1
        '
        Me.ColorButton1.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton1.Color = System.Drawing.Color.Black
        Me.ColorButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton1.Image = CType(resources.GetObject("ColorButton1.Image"), System.Drawing.Image)
        Me.ColorButton1.Location = New System.Drawing.Point(53, 9)
        Me.ColorButton1.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton1.Name = "ColorButton1"
        Me.ColorButton1.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton1.RightClickMode = True
        Me.ColorButton1.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton1.TabIndex = 0
        Me.ColorButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton1.UseVisualStyleBackColor = True
        '
        'ColorButton2
        '
        Me.ColorButton2.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton2.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ColorButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton2.Image = CType(resources.GetObject("ColorButton2.Image"), System.Drawing.Image)
        Me.ColorButton2.Location = New System.Drawing.Point(95, 9)
        Me.ColorButton2.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton2.Name = "ColorButton2"
        Me.ColorButton2.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton2.RightClickMode = True
        Me.ColorButton2.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton2.TabIndex = 1
        Me.ColorButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton2.UseVisualStyleBackColor = True
        '
        'ColorButton3
        '
        Me.ColorButton3.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton3.Color = System.Drawing.Color.Silver
        Me.ColorButton3.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton3.Image = CType(resources.GetObject("ColorButton3.Image"), System.Drawing.Image)
        Me.ColorButton3.Location = New System.Drawing.Point(137, 9)
        Me.ColorButton3.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton3.Name = "ColorButton3"
        Me.ColorButton3.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton3.RightClickMode = True
        Me.ColorButton3.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton3.TabIndex = 2
        Me.ColorButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton3.UseVisualStyleBackColor = True
        '
        'ColorButton4
        '
        Me.ColorButton4.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton4.Color = System.Drawing.Color.Gainsboro
        Me.ColorButton4.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton4.Image = CType(resources.GetObject("ColorButton4.Image"), System.Drawing.Image)
        Me.ColorButton4.Location = New System.Drawing.Point(179, 9)
        Me.ColorButton4.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton4.Name = "ColorButton4"
        Me.ColorButton4.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton4.RightClickMode = True
        Me.ColorButton4.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton4.TabIndex = 3
        Me.ColorButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton4.UseVisualStyleBackColor = True
        '
        'ColorButton5
        '
        Me.ColorButton5.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton5.Color = System.Drawing.Color.White
        Me.ColorButton5.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton5.Image = CType(resources.GetObject("ColorButton5.Image"), System.Drawing.Image)
        Me.ColorButton5.Location = New System.Drawing.Point(221, 9)
        Me.ColorButton5.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton5.Name = "ColorButton5"
        Me.ColorButton5.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton5.RightClickMode = True
        Me.ColorButton5.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton5.TabIndex = 4
        Me.ColorButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton5.UseVisualStyleBackColor = True
        '
        'ColorButton6
        '
        Me.ColorButton6.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton6.Color = System.Drawing.Color.Red
        Me.ColorButton6.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton6.Image = CType(resources.GetObject("ColorButton6.Image"), System.Drawing.Image)
        Me.ColorButton6.Location = New System.Drawing.Point(263, 9)
        Me.ColorButton6.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton6.Name = "ColorButton6"
        Me.ColorButton6.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton6.RightClickMode = True
        Me.ColorButton6.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton6.TabIndex = 5
        Me.ColorButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton6.UseVisualStyleBackColor = True
        '
        'ColorButton7
        '
        Me.ColorButton7.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton7.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorButton7.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton7.Image = CType(resources.GetObject("ColorButton7.Image"), System.Drawing.Image)
        Me.ColorButton7.Location = New System.Drawing.Point(305, 9)
        Me.ColorButton7.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton7.Name = "ColorButton7"
        Me.ColorButton7.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton7.RightClickMode = True
        Me.ColorButton7.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton7.TabIndex = 6
        Me.ColorButton7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton7.UseVisualStyleBackColor = True
        '
        'ColorButton8
        '
        Me.ColorButton8.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton8.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorButton8.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton8.Image = CType(resources.GetObject("ColorButton8.Image"), System.Drawing.Image)
        Me.ColorButton8.Location = New System.Drawing.Point(347, 9)
        Me.ColorButton8.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton8.Name = "ColorButton8"
        Me.ColorButton8.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton8.RightClickMode = True
        Me.ColorButton8.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton8.TabIndex = 7
        Me.ColorButton8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton8.UseVisualStyleBackColor = True
        '
        'ColorButton9
        '
        Me.ColorButton9.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton9.Color = System.Drawing.Color.Goldenrod
        Me.ColorButton9.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton9.Image = CType(resources.GetObject("ColorButton9.Image"), System.Drawing.Image)
        Me.ColorButton9.Location = New System.Drawing.Point(389, 9)
        Me.ColorButton9.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton9.Name = "ColorButton9"
        Me.ColorButton9.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton9.RightClickMode = True
        Me.ColorButton9.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton9.TabIndex = 8
        Me.ColorButton9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton9.UseVisualStyleBackColor = True
        '
        'ColorButton10
        '
        Me.ColorButton10.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton10.Color = System.Drawing.Color.Yellow
        Me.ColorButton10.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton10.Image = CType(resources.GetObject("ColorButton10.Image"), System.Drawing.Image)
        Me.ColorButton10.Location = New System.Drawing.Point(431, 9)
        Me.ColorButton10.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton10.Name = "ColorButton10"
        Me.ColorButton10.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton10.RightClickMode = True
        Me.ColorButton10.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton10.TabIndex = 9
        Me.ColorButton10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton10.UseVisualStyleBackColor = True
        '
        'ColorButton11
        '
        Me.ColorButton11.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton11.Color = System.Drawing.Color.Lime
        Me.ColorButton11.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton11.Image = CType(resources.GetObject("ColorButton11.Image"), System.Drawing.Image)
        Me.ColorButton11.Location = New System.Drawing.Point(473, 9)
        Me.ColorButton11.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton11.Name = "ColorButton11"
        Me.ColorButton11.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton11.RightClickMode = True
        Me.ColorButton11.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton11.TabIndex = 10
        Me.ColorButton11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton11.UseVisualStyleBackColor = True
        '
        'ColorButton12
        '
        Me.ColorButton12.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton12.Color = System.Drawing.Color.OliveDrab
        Me.ColorButton12.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton12.Image = CType(resources.GetObject("ColorButton12.Image"), System.Drawing.Image)
        Me.ColorButton12.Location = New System.Drawing.Point(515, 9)
        Me.ColorButton12.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton12.Name = "ColorButton12"
        Me.ColorButton12.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton12.RightClickMode = True
        Me.ColorButton12.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton12.TabIndex = 11
        Me.ColorButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton12.UseVisualStyleBackColor = True
        '
        'ColorButton20
        '
        Me.ColorButton20.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton20.Color = System.Drawing.Color.Green
        Me.ColorButton20.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton20.Image = CType(resources.GetObject("ColorButton20.Image"), System.Drawing.Image)
        Me.ColorButton20.Location = New System.Drawing.Point(557, 9)
        Me.ColorButton20.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton20.Name = "ColorButton20"
        Me.ColorButton20.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton20.RightClickMode = True
        Me.ColorButton20.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton20.TabIndex = 12
        Me.ColorButton20.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton20.UseVisualStyleBackColor = True
        '
        'ColorButton21
        '
        Me.ColorButton21.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton21.Color = System.Drawing.Color.DarkGreen
        Me.ColorButton21.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton21.Image = CType(resources.GetObject("ColorButton21.Image"), System.Drawing.Image)
        Me.ColorButton21.Location = New System.Drawing.Point(599, 9)
        Me.ColorButton21.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton21.Name = "ColorButton21"
        Me.ColorButton21.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton21.RightClickMode = True
        Me.ColorButton21.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton21.TabIndex = 13
        Me.ColorButton21.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton21.UseVisualStyleBackColor = True
        '
        'ColorButton13
        '
        Me.ColorButton13.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton13.Color = System.Drawing.Color.CadetBlue
        Me.ColorButton13.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton13.Image = CType(resources.GetObject("ColorButton13.Image"), System.Drawing.Image)
        Me.ColorButton13.Location = New System.Drawing.Point(641, 9)
        Me.ColorButton13.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton13.Name = "ColorButton13"
        Me.ColorButton13.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton13.RightClickMode = True
        Me.ColorButton13.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton13.TabIndex = 14
        Me.ColorButton13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton13.UseVisualStyleBackColor = True
        '
        'ColorButton14
        '
        Me.ColorButton14.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton14.Color = System.Drawing.Color.DeepSkyBlue
        Me.ColorButton14.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton14.Image = CType(resources.GetObject("ColorButton14.Image"), System.Drawing.Image)
        Me.ColorButton14.Location = New System.Drawing.Point(683, 9)
        Me.ColorButton14.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton14.Name = "ColorButton14"
        Me.ColorButton14.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton14.RightClickMode = True
        Me.ColorButton14.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton14.TabIndex = 15
        Me.ColorButton14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton14.UseVisualStyleBackColor = True
        '
        'ColorButton15
        '
        Me.ColorButton15.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton15.Color = System.Drawing.Color.Blue
        Me.ColorButton15.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton15.Image = CType(resources.GetObject("ColorButton15.Image"), System.Drawing.Image)
        Me.ColorButton15.Location = New System.Drawing.Point(725, 9)
        Me.ColorButton15.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton15.Name = "ColorButton15"
        Me.ColorButton15.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton15.RightClickMode = True
        Me.ColorButton15.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton15.TabIndex = 16
        Me.ColorButton15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton15.UseVisualStyleBackColor = True
        '
        'ColorButton16
        '
        Me.ColorButton16.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton16.Color = System.Drawing.Color.DarkSlateBlue
        Me.ColorButton16.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton16.Image = CType(resources.GetObject("ColorButton16.Image"), System.Drawing.Image)
        Me.ColorButton16.Location = New System.Drawing.Point(767, 9)
        Me.ColorButton16.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton16.Name = "ColorButton16"
        Me.ColorButton16.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton16.RightClickMode = True
        Me.ColorButton16.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton16.TabIndex = 17
        Me.ColorButton16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton16.UseVisualStyleBackColor = True
        '
        'ColorButton17
        '
        Me.ColorButton17.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton17.Color = System.Drawing.Color.Purple
        Me.ColorButton17.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton17.Image = CType(resources.GetObject("ColorButton17.Image"), System.Drawing.Image)
        Me.ColorButton17.Location = New System.Drawing.Point(809, 9)
        Me.ColorButton17.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton17.Name = "ColorButton17"
        Me.ColorButton17.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton17.RightClickMode = True
        Me.ColorButton17.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton17.TabIndex = 18
        Me.ColorButton17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton17.UseVisualStyleBackColor = True
        '
        'ColorButton18
        '
        Me.ColorButton18.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton18.Color = System.Drawing.Color.DeepPink
        Me.ColorButton18.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton18.Image = CType(resources.GetObject("ColorButton18.Image"), System.Drawing.Image)
        Me.ColorButton18.Location = New System.Drawing.Point(851, 9)
        Me.ColorButton18.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton18.Name = "ColorButton18"
        Me.ColorButton18.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton18.RightClickMode = True
        Me.ColorButton18.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton18.TabIndex = 19
        Me.ColorButton18.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ColorButton18.UseVisualStyleBackColor = True
        '
        'ColorButton19
        '
        Me.ColorButton19.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton19.Color = System.Drawing.Color.Fuchsia
        Me.ColorButton19.Dock = System.Windows.Forms.DockStyle.Left
        Me.ColorButton19.Image = CType(resources.GetObject("ColorButton19.Image"), System.Drawing.Image)
        Me.ColorButton19.Location = New System.Drawing.Point(893, 9)
        Me.ColorButton19.MinimumSize = New System.Drawing.Size(36, 36)
        Me.ColorButton19.Name = "ColorButton19"
        Me.ColorButton19.Padding = New System.Windows.Forms.Padding(2)
        Me.ColorButton19.RightClickMode = True
        Me.ColorButton19.Size = New System.Drawing.Size(36, 40)
        Me.ColorButton19.TabIndex = 20
        Me.ColorButton19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ColorButton19.UseVisualStyleBackColor = True
        '
        'rbHighlight
        '
        Me.rbHighlight.AutoSize = True
        Me.rbHighlight.BackColor = System.Drawing.Color.Transparent
        Me.rbHighlight.Location = New System.Drawing.Point(80, 14)
        Me.rbHighlight.Name = "rbHighlight"
        Me.rbHighlight.Size = New System.Drawing.Size(96, 24)
        Me.rbHighlight.TabIndex = 1
        Me.rbHighlight.Text = "Highlight"
        Me.rbHighlight.UseVisualStyleBackColor = False
        '
        'TextColorRadio
        '
        Me.TextColorRadio.AutoSize = True
        Me.TextColorRadio.BackColor = System.Drawing.Color.Transparent
        Me.TextColorRadio.Checked = True
        Me.TextColorRadio.Location = New System.Drawing.Point(9, 14)
        Me.TextColorRadio.Name = "TextColorRadio"
        Me.TextColorRadio.Size = New System.Drawing.Size(64, 24)
        Me.TextColorRadio.TabIndex = 0
        Me.TextColorRadio.TabStop = True
        Me.TextColorRadio.Text = "Text"
        Me.TextColorRadio.UseVisualStyleBackColor = False
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
        Me.MainToolStripContainer.ContentPanel.Controls.Add(Me.SplitLayoutPanel)
        Me.MainToolStripContainer.ContentPanel.Size = New System.Drawing.Size(1356, 833)
        Me.MainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainToolStripContainer.Location = New System.Drawing.Point(0, 33)
        Me.MainToolStripContainer.Name = "MainToolStripContainer"
        Me.MainToolStripContainer.Size = New System.Drawing.Size(1356, 911)
        Me.MainToolStripContainer.TabIndex = 74
        '
        'MainToolStripContainer.TopToolStripPanel
        '
        Me.MainToolStripContainer.TopToolStripPanel.Controls.Add(Me.MainToolStrip)
        '
        'DataToolStrip
        '
        Me.DataToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.DataToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DataToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.DataToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CharCountToolStripLabel, Me.ToolStripSeparator10, Me.WordCountToolStripLabel, Me.ToolStripSeparator26, Me.CurrentLineToolStripLabel, Me.ToolStripSeparator11, Me.PageCountLabel, Me.ToolStripSeparator12, Me.ToolStripLabel1, Me.ThemeCombo})
        Me.DataToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DataToolStrip.Name = "DataToolStrip"
        Me.DataToolStrip.Padding = New System.Windows.Forms.Padding(2)
        Me.DataToolStrip.Size = New System.Drawing.Size(1356, 37)
        Me.DataToolStrip.Stretch = True
        Me.DataToolStrip.TabIndex = 2
        '
        'CharCountToolStripLabel
        '
        Me.CharCountToolStripLabel.BackColor = System.Drawing.Color.Transparent
        Me.CharCountToolStripLabel.Name = "CharCountToolStripLabel"
        Me.CharCountToolStripLabel.Size = New System.Drawing.Size(158, 28)
        Me.CharCountToolStripLabel.Text = "Character Count: 0"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 33)
        '
        'WordCountToolStripLabel
        '
        Me.WordCountToolStripLabel.BackColor = System.Drawing.Color.Transparent
        Me.WordCountToolStripLabel.Name = "WordCountToolStripLabel"
        Me.WordCountToolStripLabel.Size = New System.Drawing.Size(128, 28)
        Me.WordCountToolStripLabel.Text = "Word Count: 0"
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(6, 33)
        '
        'CurrentLineToolStripLabel
        '
        Me.CurrentLineToolStripLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurrentLineToolStripLabel.Name = "CurrentLineToolStripLabel"
        Me.CurrentLineToolStripLabel.Size = New System.Drawing.Size(62, 28)
        Me.CurrentLineToolStripLabel.Text = "Line: 1"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 33)
        '
        'PageCountLabel
        '
        Me.PageCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.PageCountLabel.Name = "PageCountLabel"
        Me.PageCountLabel.Size = New System.Drawing.Size(122, 28)
        Me.PageCountLabel.Text = "Page Count: 0"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(69, 28)
        Me.ToolStripLabel1.Text = "Theme:"
        '
        'ThemeCombo
        '
        Me.ThemeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ThemeCombo.Items.AddRange(New Object() {"Light", "Dark", "Glacier", "Olive"})
        Me.ThemeCombo.Name = "ThemeCombo"
        Me.ThemeCombo.Size = New System.Drawing.Size(145, 33)
        '
        'MainToolStrip
        '
        Me.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.PastePlainToolStripButton, Me.toolStripSeparator2, Me.UndoToolStripButton, Me.RedoToolStripButton, Me.ToolStripSeparator9, Me.CharacterEditorToolStripButton, Me.DictionaryToolStripButton, Me.ToolStripSeparator14, Me.FontToolStripButton, Me.ToolStripSeparator15, Me.BoldToolStripButton, Me.ItalicToolStripButton, Me.UnderlineToolStripButton, Me.StrikeToolStripButton, Me.ToolStripSeparator5, Me.AlignLeftToolStripButton, Me.AlignCenterToolStripButton, Me.AlignRightToolStripButton, Me.ToolStripSeparator8, Me.DecreaseIndentToolStripButton, Me.IncreaseIndentToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.MinimumSize = New System.Drawing.Size(0, 38)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainToolStrip.Size = New System.Drawing.Size(1356, 41)
        Me.MainToolStrip.Stretch = True
        Me.MainToolStrip.TabIndex = 0
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.NewToolStripButton.Text = "New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.OpenToolStripButton.Text = "Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.SaveToolStripButton.Text = "Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 41)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.CutToolStripButton.Text = "Cut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.CopyToolStripButton.Text = "Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.PasteToolStripButton.Text = "Paste"
        '
        'PastePlainToolStripButton
        '
        Me.PastePlainToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PastePlainToolStripButton.Image = CType(resources.GetObject("PastePlainToolStripButton.Image"), System.Drawing.Image)
        Me.PastePlainToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PastePlainToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PastePlainToolStripButton.Name = "PastePlainToolStripButton"
        Me.PastePlainToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.PastePlainToolStripButton.Text = "Paste Text"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 41)
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoToolStripButton.Image = CType(resources.GetObject("UndoToolStripButton.Image"), System.Drawing.Image)
        Me.UndoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoToolStripButton.Name = "UndoToolStripButton"
        Me.UndoToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.UndoToolStripButton.Text = "Undo"
        '
        'RedoToolStripButton
        '
        Me.RedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RedoToolStripButton.Image = CType(resources.GetObject("RedoToolStripButton.Image"), System.Drawing.Image)
        Me.RedoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RedoToolStripButton.Name = "RedoToolStripButton"
        Me.RedoToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.RedoToolStripButton.Text = "Redo"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 41)
        '
        'CharacterEditorToolStripButton
        '
        Me.CharacterEditorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CharacterEditorToolStripButton.Image = CType(resources.GetObject("CharacterEditorToolStripButton.Image"), System.Drawing.Image)
        Me.CharacterEditorToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CharacterEditorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CharacterEditorToolStripButton.Name = "CharacterEditorToolStripButton"
        Me.CharacterEditorToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.CharacterEditorToolStripButton.Text = "Character Editor"
        '
        'DictionaryToolStripButton
        '
        Me.DictionaryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DictionaryToolStripButton.Image = CType(resources.GetObject("DictionaryToolStripButton.Image"), System.Drawing.Image)
        Me.DictionaryToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DictionaryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DictionaryToolStripButton.Name = "DictionaryToolStripButton"
        Me.DictionaryToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DictionaryToolStripButton.Text = "Dictionary"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 41)
        '
        'FontToolStripButton
        '
        Me.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), System.Drawing.Image)
        Me.FontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontToolStripButton.Name = "FontToolStripButton"
        Me.FontToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.FontToolStripButton.Text = "Font"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.ForeColor = System.Drawing.Color.Red
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 41)
        '
        'BoldToolStripButton
        '
        Me.BoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BoldToolStripButton.Image = CType(resources.GetObject("BoldToolStripButton.Image"), System.Drawing.Image)
        Me.BoldToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BoldToolStripButton.Name = "BoldToolStripButton"
        Me.BoldToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.BoldToolStripButton.Text = "Bold"
        '
        'ItalicToolStripButton
        '
        Me.ItalicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItalicToolStripButton.Image = CType(resources.GetObject("ItalicToolStripButton.Image"), System.Drawing.Image)
        Me.ItalicToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ItalicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ItalicToolStripButton.Name = "ItalicToolStripButton"
        Me.ItalicToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ItalicToolStripButton.Text = "Italic"
        '
        'UnderlineToolStripButton
        '
        Me.UnderlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UnderlineToolStripButton.Image = CType(resources.GetObject("UnderlineToolStripButton.Image"), System.Drawing.Image)
        Me.UnderlineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UnderlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UnderlineToolStripButton.Name = "UnderlineToolStripButton"
        Me.UnderlineToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.UnderlineToolStripButton.Text = "Underline"
        '
        'StrikeToolStripButton
        '
        Me.StrikeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StrikeToolStripButton.Image = CType(resources.GetObject("StrikeToolStripButton.Image"), System.Drawing.Image)
        Me.StrikeToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StrikeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StrikeToolStripButton.Name = "StrikeToolStripButton"
        Me.StrikeToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.StrikeToolStripButton.Text = "Strike"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 41)
        '
        'AlignLeftToolStripButton
        '
        Me.AlignLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignLeftToolStripButton.Image = CType(resources.GetObject("AlignLeftToolStripButton.Image"), System.Drawing.Image)
        Me.AlignLeftToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignLeftToolStripButton.Name = "AlignLeftToolStripButton"
        Me.AlignLeftToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.AlignLeftToolStripButton.Text = "Align Left"
        '
        'AlignCenterToolStripButton
        '
        Me.AlignCenterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignCenterToolStripButton.Image = CType(resources.GetObject("AlignCenterToolStripButton.Image"), System.Drawing.Image)
        Me.AlignCenterToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignCenterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignCenterToolStripButton.Name = "AlignCenterToolStripButton"
        Me.AlignCenterToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.AlignCenterToolStripButton.Text = "Align Center"
        '
        'AlignRightToolStripButton
        '
        Me.AlignRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlignRightToolStripButton.Image = CType(resources.GetObject("AlignRightToolStripButton.Image"), System.Drawing.Image)
        Me.AlignRightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlignRightToolStripButton.Name = "AlignRightToolStripButton"
        Me.AlignRightToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.AlignRightToolStripButton.Text = "Align Right"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 41)
        '
        'DecreaseIndentToolStripButton
        '
        Me.DecreaseIndentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DecreaseIndentToolStripButton.Image = CType(resources.GetObject("DecreaseIndentToolStripButton.Image"), System.Drawing.Image)
        Me.DecreaseIndentToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DecreaseIndentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DecreaseIndentToolStripButton.Name = "DecreaseIndentToolStripButton"
        Me.DecreaseIndentToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DecreaseIndentToolStripButton.Text = "Decrease Indent"
        '
        'IncreaseIndentToolStripButton
        '
        Me.IncreaseIndentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IncreaseIndentToolStripButton.Image = CType(resources.GetObject("IncreaseIndentToolStripButton.Image"), System.Drawing.Image)
        Me.IncreaseIndentToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IncreaseIndentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IncreaseIndentToolStripButton.Name = "IncreaseIndentToolStripButton"
        Me.IncreaseIndentToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.IncreaseIndentToolStripButton.Text = "Increase Indent"
        '
        'OpenDialog
        '
        Me.OpenDialog.Filter = "Notebook file (*.nt)|*.nt|Zip files (*.zip)|*.zip|All files (*.*)|*.*"
        '
        'SaveDialog
        '
        Me.SaveDialog.Filter = "Notebook file (*.nt)|*.nt|Thorn Writer File (*.thw)|*.thw|Zip files (*.zip)|*.zip" &
    "|All files (*.*)|*.*"
        '
        'MainMenu
        '
        Me.MainMenu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.PageToolStripMenuItem, Me.LinguisticsToolStripMenuItem, Me.InsertToolStripMenuItem, Me.StyleToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MainMenu.Size = New System.Drawing.Size(1356, 33)
        Me.MainMenu.TabIndex = 75
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.NewWindowToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator3, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator4, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PageSetupToolStripMenuItem, Me.ToolStripMenuItem22, Me.RTFEditorToolStripMenuItem, Me.ToolStripSeparator16, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(332, 34)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewWindowToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(332, 34)
        Me.NewWindowToolStripMenuItem.Text = "New Window"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(332, 34)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(329, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(332, 34)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(332, 34)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(329, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(332, 34)
        Me.PrintToolStripMenuItem.Text = "Print..."
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(332, 34)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview..."
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(332, 34)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup..."
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(329, 6)
        '
        'RTFEditorToolStripMenuItem
        '
        Me.RTFEditorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RTFEditorToolStripMenuItem.Name = "RTFEditorToolStripMenuItem"
        Me.RTFEditorToolStripMenuItem.Size = New System.Drawing.Size(332, 34)
        Me.RTFEditorToolStripMenuItem.Text = "RTF Editor..."
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(329, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(332, 34)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator6, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.PastePlainToolStripMenuItem, Me.ToolStripMenuItem25, Me.FindToolStripMenuItem, Me.toolStripSeparator7, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(300, 34)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(300, 34)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(297, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(300, 34)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(300, 34)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(300, 34)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'PastePlainToolStripMenuItem
        '
        Me.PastePlainToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PastePlainToolStripMenuItem.Name = "PastePlainToolStripMenuItem"
        Me.PastePlainToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PastePlainToolStripMenuItem.Size = New System.Drawing.Size(300, 34)
        Me.PastePlainToolStripMenuItem.Text = "Paste Text"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(297, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(300, 34)
        Me.FindToolStripMenuItem.Text = "Find/Replace"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(297, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(300, 34)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomInToolStripMenuItem, Me.ZoomOutToolStripMenuItem, Me.ToolStripMenuItem27, Me.ZoomToolStripMenuItem, Me.EditZoomToolStripMenuItem, Me.ToolStripMenuItem26, Me.WordWrapToolStripMenuItem, Me.ToolStripMenuItem1, Me.FullModeToolStripMenuItem, Me.MinimalModeToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToggleSidebarToolStripMenuItem, Me.ToggleStatusbarToolStripMenuItem, Me.ToggleToolbarToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ZoomInToolStripMenuItem
        '
        Me.ZoomInToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        Me.ZoomInToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus), System.Windows.Forms.Keys)
        Me.ZoomInToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.ZoomInToolStripMenuItem.Text = "Zoom In"
        '
        'ZoomOutToolStripMenuItem
        '
        Me.ZoomOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        Me.ZoomOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.OemMinus), System.Windows.Forms.Keys)
        Me.ZoomOutToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.ZoomOutToolStripMenuItem.Text = "Zoom Out"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(332, 6)
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.ZoomToolStripMenuItem.Text = "100% Zoom"
        '
        'EditZoomToolStripMenuItem
        '
        Me.EditZoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditZoomToolStripMenuItem.Name = "EditZoomToolStripMenuItem"
        Me.EditZoomToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.EditZoomToolStripMenuItem.Text = "Custom Zoom..."
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(332, 6)
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.CheckOnClick = True
        Me.WordWrapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.WordWrapToolStripMenuItem.Text = "Word Wrap"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(332, 6)
        '
        'FullModeToolStripMenuItem
        '
        Me.FullModeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FullModeToolStripMenuItem.Name = "FullModeToolStripMenuItem"
        Me.FullModeToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.FullModeToolStripMenuItem.Text = "Full Mode"
        '
        'MinimalModeToolStripMenuItem
        '
        Me.MinimalModeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MinimalModeToolStripMenuItem.Name = "MinimalModeToolStripMenuItem"
        Me.MinimalModeToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.MinimalModeToolStripMenuItem.Text = "Minimal Mode"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(332, 6)
        '
        'ToggleSidebarToolStripMenuItem
        '
        Me.ToggleSidebarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToggleSidebarToolStripMenuItem.Name = "ToggleSidebarToolStripMenuItem"
        Me.ToggleSidebarToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.ToggleSidebarToolStripMenuItem.Text = "Toggle Sidebar"
        '
        'ToggleStatusbarToolStripMenuItem
        '
        Me.ToggleStatusbarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToggleStatusbarToolStripMenuItem.Name = "ToggleStatusbarToolStripMenuItem"
        Me.ToggleStatusbarToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.ToggleStatusbarToolStripMenuItem.Text = "Toggle Statusbar"
        '
        'ToggleToolbarToolStripMenuItem
        '
        Me.ToggleToolbarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToggleToolbarToolStripMenuItem.Name = "ToggleToolbarToolStripMenuItem"
        Me.ToggleToolbarToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.ToggleToolbarToolStripMenuItem.Text = "Toggle Toolbar"
        '
        'PageToolStripMenuItem
        '
        Me.PageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPageToolStripMenuItem, Me.RemovePageToolStripMenuItem, Me.DuplicatePageToolStripMenuItem, Me.DuplicateAndNameToolStripMenuItem, Me.ToolStripMenuItem28, Me.RenamePageToolStripMenuItem, Me.ToolStripMenuItem29, Me.ImportPageToolStripMenuItem, Me.ExportPageToolStripMenuItem, Me.ToolStripMenuItem3, Me.PreviousPageToolStripMenuItem, Me.NextPageToolStripMenuItem, Me.ToolStripSeparator21, Me.DictionaryMenuItem})
        Me.PageToolStripMenuItem.Name = "PageToolStripMenuItem"
        Me.PageToolStripMenuItem.Size = New System.Drawing.Size(109, 29)
        Me.PageToolStripMenuItem.Text = "Notebook"
        '
        'AddPageToolStripMenuItem
        '
        Me.AddPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddPageToolStripMenuItem.Name = "AddPageToolStripMenuItem"
        Me.AddPageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.AddPageToolStripMenuItem.Size = New System.Drawing.Size(442, 34)
        Me.AddPageToolStripMenuItem.Text = "Add Page"
        '
        'RemovePageToolStripMenuItem
        '
        Me.RemovePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemovePageToolStripMenuItem.Name = "RemovePageToolStripMenuItem"
        Me.RemovePageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.RemovePageToolStripMenuItem.Size = New System.Drawing.Size(442, 34)
        Me.RemovePageToolStripMenuItem.Text = "Remove Page"
        '
        'DuplicatePageToolStripMenuItem
        '
        Me.DuplicatePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DuplicatePageToolStripMenuItem.Name = "DuplicatePageToolStripMenuItem"
        Me.DuplicatePageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DuplicatePageToolStripMenuItem.Size = New System.Drawing.Size(442, 34)
        Me.DuplicatePageToolStripMenuItem.Text = "Duplicate Page"
        '
        'DuplicateAndNameToolStripMenuItem
        '
        Me.DuplicateAndNameToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DuplicateAndNameToolStripMenuItem.Name = "DuplicateAndNameToolStripMenuItem"
        Me.DuplicateAndNameToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DuplicateAndNameToolStripMenuItem.Size = New System.Drawing.Size(442, 34)
        Me.DuplicateAndNameToolStripMenuItem.Text = "Duplicate and Name Page..."
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(439, 6)
        '
        'RenamePageToolStripMenuItem
        '
        Me.RenamePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RenamePageToolStripMenuItem.Name = "RenamePageToolStripMenuItem"
        Me.RenamePageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.RenamePageToolStripMenuItem.Size = New System.Drawing.Size(442, 34)
        Me.RenamePageToolStripMenuItem.Text = "Rename Page..."
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(439, 6)
        '
        'ImportPageToolStripMenuItem
        '
        Me.ImportPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportPageToolStripMenuItem.Name = "ImportPageToolStripMenuItem"
        Me.ImportPageToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImportPageToolStripMenuItem.Size = New System.Drawing.Size(442, 34)
        Me.ImportPageToolStripMenuItem.Text = "Import Page..."
        '
        'ExportPageToolStripMenuItem
        '
        Me.ExportPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportPageToolStripMenuItem.Name = "ExportPageToolStripMenuItem"
        Me.ExportPageToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExportPageToolStripMenuItem.Size = New System.Drawing.Size(442, 34)
        Me.ExportPageToolStripMenuItem.Text = "Export Page..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(439, 6)
        '
        'PreviousPageToolStripMenuItem
        '
        Me.PreviousPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PreviousPageToolStripMenuItem.Name = "PreviousPageToolStripMenuItem"
        Me.PreviousPageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.PreviousPageToolStripMenuItem.Size = New System.Drawing.Size(442, 34)
        Me.PreviousPageToolStripMenuItem.Text = "Previous Page"
        '
        'NextPageToolStripMenuItem
        '
        Me.NextPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NextPageToolStripMenuItem.Name = "NextPageToolStripMenuItem"
        Me.NextPageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.NextPageToolStripMenuItem.Size = New System.Drawing.Size(442, 34)
        Me.NextPageToolStripMenuItem.Text = "Next Page"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(439, 6)
        '
        'DictionaryMenuItem
        '
        Me.DictionaryMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DictionaryMenuItem.Name = "DictionaryMenuItem"
        Me.DictionaryMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.DictionaryMenuItem.Size = New System.Drawing.Size(442, 34)
        Me.DictionaryMenuItem.Text = "Dictionary..."
        '
        'LinguisticsToolStripMenuItem
        '
        Me.LinguisticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CharacterEditorToolStripMenuItem, Me.ToolStripSeparator25, Me.BroadTranscriptionToolStripMenuItem, Me.NarrowTranscriptionToolStripMenuItem, Me.RemoveBracketsToolStripMenuItem})
        Me.LinguisticsToolStripMenuItem.Name = "LinguisticsToolStripMenuItem"
        Me.LinguisticsToolStripMenuItem.Size = New System.Drawing.Size(109, 29)
        Me.LinguisticsToolStripMenuItem.Text = "Linguistics"
        '
        'CharacterEditorToolStripMenuItem
        '
        Me.CharacterEditorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CharacterEditorToolStripMenuItem.Name = "CharacterEditorToolStripMenuItem"
        Me.CharacterEditorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.CharacterEditorToolStripMenuItem.Size = New System.Drawing.Size(415, 34)
        Me.CharacterEditorToolStripMenuItem.Text = "Character Editor..."
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(412, 6)
        '
        'BroadTranscriptionToolStripMenuItem
        '
        Me.BroadTranscriptionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BroadTranscriptionToolStripMenuItem.Name = "BroadTranscriptionToolStripMenuItem"
        Me.BroadTranscriptionToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BroadTranscriptionToolStripMenuItem.Size = New System.Drawing.Size(415, 34)
        Me.BroadTranscriptionToolStripMenuItem.Text = "Broad Transcription /◌/"
        '
        'NarrowTranscriptionToolStripMenuItem
        '
        Me.NarrowTranscriptionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NarrowTranscriptionToolStripMenuItem.Name = "NarrowTranscriptionToolStripMenuItem"
        Me.NarrowTranscriptionToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.NarrowTranscriptionToolStripMenuItem.Size = New System.Drawing.Size(415, 34)
        Me.NarrowTranscriptionToolStripMenuItem.Text = "Narrow Transcription [◌]"
        '
        'RemoveBracketsToolStripMenuItem
        '
        Me.RemoveBracketsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveBracketsToolStripMenuItem.Name = "RemoveBracketsToolStripMenuItem"
        Me.RemoveBracketsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.RemoveBracketsToolStripMenuItem.Size = New System.Drawing.Size(415, 34)
        Me.RemoveBracketsToolStripMenuItem.Text = "Remove Brackets"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImageToolStripMenuItem, Me.ToolStripMenuItem32, Me.InsertBulletsToolStripMenuItem, Me.RemoveBulletsToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(72, 29)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(343, 34)
        Me.ImageToolStripMenuItem.Text = "Image..."
        '
        'ToolStripMenuItem32
        '
        Me.ToolStripMenuItem32.Name = "ToolStripMenuItem32"
        Me.ToolStripMenuItem32.Size = New System.Drawing.Size(340, 6)
        '
        'InsertBulletsToolStripMenuItem
        '
        Me.InsertBulletsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InsertBulletsToolStripMenuItem.Name = "InsertBulletsToolStripMenuItem"
        Me.InsertBulletsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.InsertBulletsToolStripMenuItem.Size = New System.Drawing.Size(343, 34)
        Me.InsertBulletsToolStripMenuItem.Text = "Insert Bullets"
        '
        'RemoveBulletsToolStripMenuItem
        '
        Me.RemoveBulletsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveBulletsToolStripMenuItem.Name = "RemoveBulletsToolStripMenuItem"
        Me.RemoveBulletsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.RemoveBulletsToolStripMenuItem.Size = New System.Drawing.Size(343, 34)
        Me.RemoveBulletsToolStripMenuItem.Text = "Remove Bullets"
        '
        'StyleToolStripMenuItem
        '
        Me.StyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorPanelToolStripMenuItem, Me.ToolStripSeparator13, Me.TextColorToolStripMenuItem, Me.HighlightToolStripMenuItem, Me.ToolStripMenuItem24, Me.EditStyleToolStripMenuItem, Me.DefaultStyleToolStripMenuItem, Me.ApplyStyleToolStripMenuItem})
        Me.StyleToolStripMenuItem.Name = "StyleToolStripMenuItem"
        Me.StyleToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.StyleToolStripMenuItem.Text = "Style"
        '
        'ColorPanelToolStripMenuItem
        '
        Me.ColorPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ColorPanelToolStripMenuItem.Name = "ColorPanelToolStripMenuItem"
        Me.ColorPanelToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.ColorPanelToolStripMenuItem.Text = "Toggle Color Panel"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(274, 6)
        '
        'TextColorToolStripMenuItem
        '
        Me.TextColorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TextColorToolStripMenuItem.Name = "TextColorToolStripMenuItem"
        Me.TextColorToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.TextColorToolStripMenuItem.Text = "Text Color..."
        '
        'HighlightToolStripMenuItem
        '
        Me.HighlightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HighlightToolStripMenuItem.Name = "HighlightToolStripMenuItem"
        Me.HighlightToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.HighlightToolStripMenuItem.Text = "Highlight..."
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(274, 6)
        '
        'EditStyleToolStripMenuItem
        '
        Me.EditStyleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditStyleToolStripMenuItem.Name = "EditStyleToolStripMenuItem"
        Me.EditStyleToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.EditStyleToolStripMenuItem.Text = "Edit Style..."
        '
        'DefaultStyleToolStripMenuItem
        '
        Me.DefaultStyleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DefaultStyleToolStripMenuItem.Name = "DefaultStyleToolStripMenuItem"
        Me.DefaultStyleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.DefaultStyleToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.DefaultStyleToolStripMenuItem.Text = "Default Style"
        '
        'ApplyStyleToolStripMenuItem
        '
        Me.ApplyStyleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ApplyStyleToolStripMenuItem.Name = "ApplyStyleToolStripMenuItem"
        Me.ApplyStyleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.ApplyStyleToolStripMenuItem.Size = New System.Drawing.Size(277, 34)
        Me.ApplyStyleToolStripMenuItem.Text = "Apply Style"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ToolStripSeparator18, Me.AlignLeftToolStripMenuItem, Me.AlignCenterToolStripMenuItem, Me.AlignRightToolStripMenuItem, Me.ToolStripSeparator19, Me.BoldToolStripMenuItem, Me.ItalicToolStripMenuItem, Me.UnderlineToolStripMenuItem, Me.StrikeToolStripMenuItem, Me.ToolStripSeparator20, Me.IncreaseIndentToolStripMenuItem, Me.DecreaseIndentToolStripMenuItem, Me.ResetIndentToolStripMenuItem, Me.ToolStripSeparator22, Me.IncreaseBulletIndentToolStripMenuItem, Me.DecreaseBulletIndentToolStripMenuItem, Me.ResetBulletIndentToolStripMenuItem, Me.ToolStripSeparator23, Me.IncreaseHangingIndentToolStripMenuItem, Me.DecreaseHangingIndentToolStripMenuItem, Me.ResetHangingIndentToolStripMenuItem, Me.ToolStripSeparator17, Me.SubscriptToolStripMenuItem, Me.SuperscriptToolStripMenuItem, Me.BaselineToolStripMenuItem, Me.ToolStripSeparator24, Me.InsertTabToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.FormatToolStripMenuItem.Text = "Text"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.FontToolStripMenuItem.Text = "Font..."
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(424, 6)
        '
        'AlignLeftToolStripMenuItem
        '
        Me.AlignLeftToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignLeftToolStripMenuItem.Name = "AlignLeftToolStripMenuItem"
        Me.AlignLeftToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.AlignLeftToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.AlignLeftToolStripMenuItem.Text = "Align Left"
        '
        'AlignCenterToolStripMenuItem
        '
        Me.AlignCenterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignCenterToolStripMenuItem.Name = "AlignCenterToolStripMenuItem"
        Me.AlignCenterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.AlignCenterToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.AlignCenterToolStripMenuItem.Text = "Align Center"
        '
        'AlignRightToolStripMenuItem
        '
        Me.AlignRightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AlignRightToolStripMenuItem.Name = "AlignRightToolStripMenuItem"
        Me.AlignRightToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.AlignRightToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.AlignRightToolStripMenuItem.Text = "Align Right"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(424, 6)
        '
        'BoldToolStripMenuItem
        '
        Me.BoldToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BoldToolStripMenuItem.Name = "BoldToolStripMenuItem"
        Me.BoldToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BoldToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.BoldToolStripMenuItem.Text = "Bold"
        '
        'ItalicToolStripMenuItem
        '
        Me.ItalicToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ItalicToolStripMenuItem.Name = "ItalicToolStripMenuItem"
        Me.ItalicToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ItalicToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.ItalicToolStripMenuItem.Text = "Italic"
        '
        'UnderlineToolStripMenuItem
        '
        Me.UnderlineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UnderlineToolStripMenuItem.Name = "UnderlineToolStripMenuItem"
        Me.UnderlineToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UnderlineToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.UnderlineToolStripMenuItem.Text = "Underline"
        '
        'StrikeToolStripMenuItem
        '
        Me.StrikeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StrikeToolStripMenuItem.Name = "StrikeToolStripMenuItem"
        Me.StrikeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.StrikeToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.StrikeToolStripMenuItem.Text = "Strike"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(424, 6)
        '
        'IncreaseIndentToolStripMenuItem
        '
        Me.IncreaseIndentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IncreaseIndentToolStripMenuItem.Name = "IncreaseIndentToolStripMenuItem"
        Me.IncreaseIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.IncreaseIndentToolStripMenuItem.Text = "Increase Indent"
        '
        'DecreaseIndentToolStripMenuItem
        '
        Me.DecreaseIndentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DecreaseIndentToolStripMenuItem.Name = "DecreaseIndentToolStripMenuItem"
        Me.DecreaseIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.DecreaseIndentToolStripMenuItem.Text = "Decrease Indent"
        Me.DecreaseIndentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ResetIndentToolStripMenuItem
        '
        Me.ResetIndentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ResetIndentToolStripMenuItem.Name = "ResetIndentToolStripMenuItem"
        Me.ResetIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.ResetIndentToolStripMenuItem.Text = "Reset Indent"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(424, 6)
        '
        'IncreaseBulletIndentToolStripMenuItem
        '
        Me.IncreaseBulletIndentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IncreaseBulletIndentToolStripMenuItem.Name = "IncreaseBulletIndentToolStripMenuItem"
        Me.IncreaseBulletIndentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Tab), System.Windows.Forms.Keys)
        Me.IncreaseBulletIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.IncreaseBulletIndentToolStripMenuItem.Text = "Increase Bullet Indent"
        '
        'DecreaseBulletIndentToolStripMenuItem
        '
        Me.DecreaseBulletIndentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DecreaseBulletIndentToolStripMenuItem.Name = "DecreaseBulletIndentToolStripMenuItem"
        Me.DecreaseBulletIndentToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Tab), System.Windows.Forms.Keys)
        Me.DecreaseBulletIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.DecreaseBulletIndentToolStripMenuItem.Text = "Decrease Bullet Indent"
        Me.DecreaseBulletIndentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ResetBulletIndentToolStripMenuItem
        '
        Me.ResetBulletIndentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ResetBulletIndentToolStripMenuItem.Name = "ResetBulletIndentToolStripMenuItem"
        Me.ResetBulletIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.ResetBulletIndentToolStripMenuItem.Text = "Reset Bullet Indent"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(424, 6)
        '
        'IncreaseHangingIndentToolStripMenuItem
        '
        Me.IncreaseHangingIndentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IncreaseHangingIndentToolStripMenuItem.Name = "IncreaseHangingIndentToolStripMenuItem"
        Me.IncreaseHangingIndentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.IncreaseHangingIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.IncreaseHangingIndentToolStripMenuItem.Text = "Increase Hanging Indent"
        '
        'DecreaseHangingIndentToolStripMenuItem
        '
        Me.DecreaseHangingIndentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DecreaseHangingIndentToolStripMenuItem.Name = "DecreaseHangingIndentToolStripMenuItem"
        Me.DecreaseHangingIndentToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.DecreaseHangingIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.DecreaseHangingIndentToolStripMenuItem.Text = "Decrease Hanging Indent"
        '
        'ResetHangingIndentToolStripMenuItem
        '
        Me.ResetHangingIndentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ResetHangingIndentToolStripMenuItem.Name = "ResetHangingIndentToolStripMenuItem"
        Me.ResetHangingIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.ResetHangingIndentToolStripMenuItem.Text = "Reset Hanging Indent"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(424, 6)
        '
        'SubscriptToolStripMenuItem
        '
        Me.SubscriptToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SubscriptToolStripMenuItem.Name = "SubscriptToolStripMenuItem"
        Me.SubscriptToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.SubscriptToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.SubscriptToolStripMenuItem.Text = "Subscript"
        '
        'SuperscriptToolStripMenuItem
        '
        Me.SuperscriptToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SuperscriptToolStripMenuItem.Name = "SuperscriptToolStripMenuItem"
        Me.SuperscriptToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.SuperscriptToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.SuperscriptToolStripMenuItem.Text = "Superscript"
        '
        'BaselineToolStripMenuItem
        '
        Me.BaselineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BaselineToolStripMenuItem.Name = "BaselineToolStripMenuItem"
        Me.BaselineToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.BaselineToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.BaselineToolStripMenuItem.Text = "Baseline"
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(424, 6)
        '
        'InsertTabToolStripMenuItem
        '
        Me.InsertTabToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InsertTabToolStripMenuItem.Name = "InsertTabToolStripMenuItem"
        Me.InsertTabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.InsertTabToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.InsertTabToolStripMenuItem.Text = "Insert Tab"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.ToolStripMenuItem23, Me.SettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(69, 29)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(190, 34)
        Me.UpdateToolStripMenuItem.Text = "Update..."
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(187, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(190, 34)
        Me.SettingsToolStripMenuItem.Text = "Settings..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatreonToolStripMenuItem, Me.ToolStripSeparator27, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'PatreonToolStripMenuItem
        '
        Me.PatreonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PatreonToolStripMenuItem.Name = "PatreonToolStripMenuItem"
        Me.PatreonToolStripMenuItem.Size = New System.Drawing.Size(282, 34)
        Me.PatreonToolStripMenuItem.Text = "Support on Patreon..."
        '
        'ToolStripSeparator27
        '
        Me.ToolStripSeparator27.Name = "ToolStripSeparator27"
        Me.ToolStripSeparator27.Size = New System.Drawing.Size(279, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(282, 34)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 944)
        Me.Controls.Add(Me.MainToolStripContainer)
        Me.Controls.Add(Me.MainMenu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "MainForm"
        Me.Text = "LangPad X.x"
        Me.MainContextMenu.ResumeLayout(False)
        Me.SplitLayoutPanel.Panel1.ResumeLayout(False)
        Me.SplitLayoutPanel.Panel2.ResumeLayout(False)
        CType(Me.SplitLayoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitLayoutPanel.ResumeLayout(False)
        Me.PropertiesContainerPanel.ResumeLayout(False)
        Me.CurrentPageContainerBorder.ResumeLayout(False)
        Me.FindReplacePanel.ResumeLayout(False)
        Me.FindReplacePanel.PerformLayout()
        Me.ColorPanel.ResumeLayout(False)
        Me.ColorPanel.PerformLayout()
        Me.ColorLayoutPanel.ResumeLayout(False)
        Me.MainToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.MainToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.MainToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.MainToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.MainToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.MainToolStripContainer.ResumeLayout(False)
        Me.MainToolStripContainer.PerformLayout()
        Me.DataToolStrip.ResumeLayout(False)
        Me.DataToolStrip.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenImageDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FontPicker As System.Windows.Forms.FontDialog
    Friend WithEvents SavePageDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDocumentDialogPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocumentDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents OpenPageDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintPageSetupDialog As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PagePrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents FindReplacePanel As LangPadUI.DoubleBufferedPanel
    Friend WithEvents ReplaceButton As System.Windows.Forms.Button
    Friend WithEvents FindButton As System.Windows.Forms.Button
    Friend WithEvents ReplaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents FindTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ReplaceAllButton As System.Windows.Forms.Button
    Friend WithEvents FindNextButton As System.Windows.Forms.Button
    Friend WithEvents MainContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeselectAllContextMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitLayoutPanel As System.Windows.Forms.SplitContainer
    Friend WithEvents OpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PropertiesContainerPanel As LangPadUI.DoubleBufferedPanel
    Friend WithEvents MainTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents MainToolStripContainer As ToolStripContainer
    Friend WithEvents MainToolStrip As ToolStrip
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
    Friend WithEvents DataToolStrip As ToolStrip
    Friend WithEvents CharCountToolStripLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents WordCountToolStripLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents PageCountLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ThemeCombo As ToolStripComboBox
    Friend WithEvents ColorPanel As LangPadUI.DoubleBufferedPanel
    Friend WithEvents ColorLayoutPanel As FlowLayoutPanel
    Friend WithEvents ColorButton1 As LangPadUI.ColorButton
    Friend WithEvents rbHighlight As RadioButton
    Friend WithEvents TextColorRadio As RadioButton
    Friend WithEvents ColorButton2 As LangPadUI.ColorButton
    Friend WithEvents ColorButton3 As LangPadUI.ColorButton
    Friend WithEvents ColorButton4 As LangPadUI.ColorButton
    Friend WithEvents ColorButton5 As LangPadUI.ColorButton
    Friend WithEvents ColorButton6 As LangPadUI.ColorButton
    Friend WithEvents ColorButton7 As LangPadUI.ColorButton
    Friend WithEvents ColorButton8 As LangPadUI.ColorButton
    Friend WithEvents ColorButton9 As LangPadUI.ColorButton
    Friend WithEvents ColorButton10 As LangPadUI.ColorButton
    Friend WithEvents ColorButton11 As LangPadUI.ColorButton
    Friend WithEvents ColorButton12 As LangPadUI.ColorButton
    Friend WithEvents ColorButton13 As LangPadUI.ColorButton
    Friend WithEvents ColorButton14 As LangPadUI.ColorButton
    Friend WithEvents ColorButton15 As LangPadUI.ColorButton
    Friend WithEvents ColorButton16 As LangPadUI.ColorButton
    Friend WithEvents ColorButton17 As LangPadUI.ColorButton
    Friend WithEvents ColorButton18 As LangPadUI.ColorButton
    Friend WithEvents ColorButton19 As LangPadUI.ColorButton
    Friend WithEvents ColorButton20 As LangPadUI.ColorButton
    Friend WithEvents ColorButton21 As LangPadUI.ColorButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToggleSidebarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleToolbarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleStatusbarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimalModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents TransparentColorButton As Button
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents DictionaryMenuItem As ToolStripMenuItem
    Friend WithEvents NotebookEditorPanel As NotebookEditor
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents CharacterEditorToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents FontToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents BoldToolStripButton As ToolStripButton
    Friend WithEvents ItalicToolStripButton As ToolStripButton
    Friend WithEvents UnderlineToolStripButton As ToolStripButton
    Friend WithEvents StrikeToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AlignLeftToolStripButton As ToolStripButton
    Friend WithEvents AlignCenterToolStripButton As ToolStripButton
    Friend WithEvents AlignRightToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents IncreaseIndentToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DictionaryToolStripButton As ToolStripButton
    Friend WithEvents PastePlainContextMenuItem As ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents SubscriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuperscriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaselineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem32 As ToolStripSeparator
    Friend WithEvents InsertBulletsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveBulletsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents AlignLeftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlignCenterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlignRightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents TextColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HighlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem24 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator19 As ToolStripSeparator
    Friend WithEvents BoldToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItalicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnderlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StrikeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator20 As ToolStripSeparator
    Friend WithEvents DecreaseIndentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreviousPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator21 As ToolStripSeparator
    Friend WithEvents IncreaseIndentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator22 As ToolStripSeparator
    Friend WithEvents IncreaseBulletIndentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecreaseBulletIndentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator23 As ToolStripSeparator
    Friend WithEvents IncreaseHangingIndentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecreaseHangingIndentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetIndentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetBulletIndentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetHangingIndentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator24 As ToolStripSeparator
    Friend WithEvents InsertTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinguisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CharacterEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator25 As ToolStripSeparator
    Friend WithEvents BroadTranscriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NarrowTranscriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveBracketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DuplicateAndNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator26 As ToolStripSeparator
    Friend WithEvents CurrentLineToolStripLabel As ToolStripLabel
    Friend WithEvents PatreonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator27 As ToolStripSeparator
    Friend WithEvents CurrentPageContainer As LangPadUI.DoubleBufferedPanel
    Friend WithEvents CurrentPageContainerBorder As LangPadUI.DoubleBufferedPanel
    Friend WithEvents DecreaseIndentToolStripButton As ToolStripButton
End Class
