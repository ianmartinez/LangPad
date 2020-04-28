﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.NotebookTabs = New System.Windows.Forms.TabControl()
        Me.FindReplaceDialog = New TundraLib.DoubleBufferedPanel()
        Me.FindNextButton = New System.Windows.Forms.Button()
        Me.ReplaceAllButton = New System.Windows.Forms.Button()
        Me.ReplaceTextBox = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ReplaceButton = New System.Windows.Forms.Button()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.ColorPanel = New TundraLib.DoubleBufferedPanel()
        Me.ColorLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TransparentColorButton = New System.Windows.Forms.Button()
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
        Me.TextColorRadio = New System.Windows.Forms.RadioButton()
        Me.PropertiesContainerPanel = New TundraLib.DoubleBufferedPanel()
        Me.PropertiesPanel = New LangPad.PropertiesEditor()
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
        Me.IndentToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.IndentToolStripButton = New System.Windows.Forms.ToolStripButton()
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
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainContextMenu.SuspendLayout()
        CType(Me.SplitLayoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitLayoutPanel.Panel1.SuspendLayout()
        Me.SplitLayoutPanel.Panel2.SuspendLayout()
        Me.SplitLayoutPanel.SuspendLayout()
        Me.FindReplaceDialog.SuspendLayout()
        Me.ColorPanel.SuspendLayout()
        Me.ColorLayoutPanel.SuspendLayout()
        Me.PropertiesContainerPanel.SuspendLayout()
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
        Me.SplitLayoutPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.SplitLayoutPanel.Name = "SplitLayoutPanel"
        '
        'SplitLayoutPanel.Panel1
        '
        Me.SplitLayoutPanel.Panel1.Controls.Add(Me.NotebookTabs)
        Me.SplitLayoutPanel.Panel1.Controls.Add(Me.FindReplaceDialog)
        Me.SplitLayoutPanel.Panel1.Controls.Add(Me.ColorPanel)
        '
        'SplitLayoutPanel.Panel2
        '
        Me.SplitLayoutPanel.Panel2.Controls.Add(Me.PropertiesContainerPanel)
        Me.SplitLayoutPanel.Panel2MinSize = 350
        Me.SplitLayoutPanel.Size = New System.Drawing.Size(1731, 962)
        Me.SplitLayoutPanel.SplitterDistance = 1332
        Me.SplitLayoutPanel.SplitterWidth = 3
        Me.SplitLayoutPanel.TabIndex = 1
        '
        'NotebookTabs
        '
        Me.NotebookTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotebookTabs.Location = New System.Drawing.Point(0, 172)
        Me.NotebookTabs.Name = "NotebookTabs"
        Me.NotebookTabs.SelectedIndex = 0
        Me.NotebookTabs.Size = New System.Drawing.Size(1332, 790)
        Me.NotebookTabs.TabIndex = 73
        '
        'FindReplaceDialog
        '
        Me.FindReplaceDialog.BackColor = System.Drawing.Color.Transparent
        Me.FindReplaceDialog.Controls.Add(Me.FindNextButton)
        Me.FindReplaceDialog.Controls.Add(Me.ReplaceAllButton)
        Me.FindReplaceDialog.Controls.Add(Me.ReplaceTextBox)
        Me.FindReplaceDialog.Controls.Add(Me.Label18)
        Me.FindReplaceDialog.Controls.Add(Me.FindTextBox)
        Me.FindReplaceDialog.Controls.Add(Me.Label17)
        Me.FindReplaceDialog.Controls.Add(Me.ReplaceButton)
        Me.FindReplaceDialog.Controls.Add(Me.FindButton)
        Me.FindReplaceDialog.Dock = System.Windows.Forms.DockStyle.Top
        Me.FindReplaceDialog.Location = New System.Drawing.Point(0, 118)
        Me.FindReplaceDialog.Name = "FindReplaceDialog"
        Me.FindReplaceDialog.Size = New System.Drawing.Size(1332, 54)
        Me.FindReplaceDialog.TabIndex = 72
        Me.FindReplaceDialog.Visible = False
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
        Me.ColorPanel.Size = New System.Drawing.Size(1332, 118)
        Me.ColorPanel.TabIndex = 74
        Me.ColorPanel.Visible = False
        '
        'ColorLayoutPanel
        '
        Me.ColorLayoutPanel.AutoScroll = True
        Me.ColorLayoutPanel.AutoScrollMargin = New System.Drawing.Size(15, 5)
        Me.ColorLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.ColorLayoutPanel.Controls.Add(Me.TransparentColorButton)
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
        Me.ColorLayoutPanel.Location = New System.Drawing.Point(0, 48)
        Me.ColorLayoutPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.ColorLayoutPanel.Name = "ColorLayoutPanel"
        Me.ColorLayoutPanel.Padding = New System.Windows.Forms.Padding(6)
        Me.ColorLayoutPanel.Size = New System.Drawing.Size(1332, 68)
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
        'StylizedColorButton1
        '
        Me.StylizedColorButton1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton1.Color = System.Drawing.Color.Black
        Me.StylizedColorButton1.Image = CType(resources.GetObject("StylizedColorButton1.Image"), System.Drawing.Image)
        Me.StylizedColorButton1.Location = New System.Drawing.Point(53, 9)
        Me.StylizedColorButton1.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton1.Name = "StylizedColorButton1"
        Me.StylizedColorButton1.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton1.RightClickMode = True
        Me.StylizedColorButton1.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton1.TabIndex = 0
        Me.StylizedColorButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton1.UseVisualStyleBackColor = True
        '
        'StylizedColorButton2
        '
        Me.StylizedColorButton2.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton2.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StylizedColorButton2.Image = CType(resources.GetObject("StylizedColorButton2.Image"), System.Drawing.Image)
        Me.StylizedColorButton2.Location = New System.Drawing.Point(95, 9)
        Me.StylizedColorButton2.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton2.Name = "StylizedColorButton2"
        Me.StylizedColorButton2.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton2.RightClickMode = True
        Me.StylizedColorButton2.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton2.TabIndex = 1
        Me.StylizedColorButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton2.UseVisualStyleBackColor = True
        '
        'StylizedColorButton3
        '
        Me.StylizedColorButton3.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton3.Color = System.Drawing.Color.Silver
        Me.StylizedColorButton3.Image = CType(resources.GetObject("StylizedColorButton3.Image"), System.Drawing.Image)
        Me.StylizedColorButton3.Location = New System.Drawing.Point(137, 9)
        Me.StylizedColorButton3.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton3.Name = "StylizedColorButton3"
        Me.StylizedColorButton3.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton3.RightClickMode = True
        Me.StylizedColorButton3.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton3.TabIndex = 2
        Me.StylizedColorButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton3.UseVisualStyleBackColor = True
        '
        'StylizedColorButton4
        '
        Me.StylizedColorButton4.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton4.Color = System.Drawing.Color.Gainsboro
        Me.StylizedColorButton4.Image = CType(resources.GetObject("StylizedColorButton4.Image"), System.Drawing.Image)
        Me.StylizedColorButton4.Location = New System.Drawing.Point(179, 9)
        Me.StylizedColorButton4.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton4.Name = "StylizedColorButton4"
        Me.StylizedColorButton4.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton4.RightClickMode = True
        Me.StylizedColorButton4.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton4.TabIndex = 3
        Me.StylizedColorButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton4.UseVisualStyleBackColor = True
        '
        'StylizedColorButton5
        '
        Me.StylizedColorButton5.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton5.Color = System.Drawing.Color.White
        Me.StylizedColorButton5.Image = CType(resources.GetObject("StylizedColorButton5.Image"), System.Drawing.Image)
        Me.StylizedColorButton5.Location = New System.Drawing.Point(221, 9)
        Me.StylizedColorButton5.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton5.Name = "StylizedColorButton5"
        Me.StylizedColorButton5.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton5.RightClickMode = True
        Me.StylizedColorButton5.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton5.TabIndex = 4
        Me.StylizedColorButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton5.UseVisualStyleBackColor = True
        '
        'StylizedColorButton6
        '
        Me.StylizedColorButton6.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton6.Color = System.Drawing.Color.Red
        Me.StylizedColorButton6.Image = CType(resources.GetObject("StylizedColorButton6.Image"), System.Drawing.Image)
        Me.StylizedColorButton6.Location = New System.Drawing.Point(263, 9)
        Me.StylizedColorButton6.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton6.Name = "StylizedColorButton6"
        Me.StylizedColorButton6.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton6.RightClickMode = True
        Me.StylizedColorButton6.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton6.TabIndex = 5
        Me.StylizedColorButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton6.UseVisualStyleBackColor = True
        '
        'StylizedColorButton7
        '
        Me.StylizedColorButton7.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton7.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedColorButton7.Image = CType(resources.GetObject("StylizedColorButton7.Image"), System.Drawing.Image)
        Me.StylizedColorButton7.Location = New System.Drawing.Point(305, 9)
        Me.StylizedColorButton7.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton7.Name = "StylizedColorButton7"
        Me.StylizedColorButton7.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton7.RightClickMode = True
        Me.StylizedColorButton7.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton7.TabIndex = 6
        Me.StylizedColorButton7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton7.UseVisualStyleBackColor = True
        '
        'StylizedColorButton8
        '
        Me.StylizedColorButton8.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton8.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedColorButton8.Image = CType(resources.GetObject("StylizedColorButton8.Image"), System.Drawing.Image)
        Me.StylizedColorButton8.Location = New System.Drawing.Point(347, 9)
        Me.StylizedColorButton8.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton8.Name = "StylizedColorButton8"
        Me.StylizedColorButton8.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton8.RightClickMode = True
        Me.StylizedColorButton8.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton8.TabIndex = 7
        Me.StylizedColorButton8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton8.UseVisualStyleBackColor = True
        '
        'StylizedColorButton9
        '
        Me.StylizedColorButton9.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton9.Color = System.Drawing.Color.Goldenrod
        Me.StylizedColorButton9.Image = CType(resources.GetObject("StylizedColorButton9.Image"), System.Drawing.Image)
        Me.StylizedColorButton9.Location = New System.Drawing.Point(389, 9)
        Me.StylizedColorButton9.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton9.Name = "StylizedColorButton9"
        Me.StylizedColorButton9.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton9.RightClickMode = True
        Me.StylizedColorButton9.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton9.TabIndex = 8
        Me.StylizedColorButton9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton9.UseVisualStyleBackColor = True
        '
        'StylizedColorButton10
        '
        Me.StylizedColorButton10.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton10.Color = System.Drawing.Color.Yellow
        Me.StylizedColorButton10.Image = CType(resources.GetObject("StylizedColorButton10.Image"), System.Drawing.Image)
        Me.StylizedColorButton10.Location = New System.Drawing.Point(431, 9)
        Me.StylizedColorButton10.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton10.Name = "StylizedColorButton10"
        Me.StylizedColorButton10.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton10.RightClickMode = True
        Me.StylizedColorButton10.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton10.TabIndex = 9
        Me.StylizedColorButton10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton10.UseVisualStyleBackColor = True
        '
        'StylizedColorButton11
        '
        Me.StylizedColorButton11.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton11.Color = System.Drawing.Color.Lime
        Me.StylizedColorButton11.Image = CType(resources.GetObject("StylizedColorButton11.Image"), System.Drawing.Image)
        Me.StylizedColorButton11.Location = New System.Drawing.Point(473, 9)
        Me.StylizedColorButton11.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton11.Name = "StylizedColorButton11"
        Me.StylizedColorButton11.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton11.RightClickMode = True
        Me.StylizedColorButton11.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton11.TabIndex = 10
        Me.StylizedColorButton11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton11.UseVisualStyleBackColor = True
        '
        'StylizedColorButton12
        '
        Me.StylizedColorButton12.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton12.Color = System.Drawing.Color.OliveDrab
        Me.StylizedColorButton12.Image = CType(resources.GetObject("StylizedColorButton12.Image"), System.Drawing.Image)
        Me.StylizedColorButton12.Location = New System.Drawing.Point(515, 9)
        Me.StylizedColorButton12.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton12.Name = "StylizedColorButton12"
        Me.StylizedColorButton12.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton12.RightClickMode = True
        Me.StylizedColorButton12.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton12.TabIndex = 11
        Me.StylizedColorButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton12.UseVisualStyleBackColor = True
        '
        'StylizedColorButton20
        '
        Me.StylizedColorButton20.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton20.Color = System.Drawing.Color.Green
        Me.StylizedColorButton20.Image = CType(resources.GetObject("StylizedColorButton20.Image"), System.Drawing.Image)
        Me.StylizedColorButton20.Location = New System.Drawing.Point(557, 9)
        Me.StylizedColorButton20.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton20.Name = "StylizedColorButton20"
        Me.StylizedColorButton20.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton20.RightClickMode = True
        Me.StylizedColorButton20.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton20.TabIndex = 12
        Me.StylizedColorButton20.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton20.UseVisualStyleBackColor = True
        '
        'StylizedColorButton21
        '
        Me.StylizedColorButton21.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton21.Color = System.Drawing.Color.DarkGreen
        Me.StylizedColorButton21.Image = CType(resources.GetObject("StylizedColorButton21.Image"), System.Drawing.Image)
        Me.StylizedColorButton21.Location = New System.Drawing.Point(599, 9)
        Me.StylizedColorButton21.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton21.Name = "StylizedColorButton21"
        Me.StylizedColorButton21.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton21.RightClickMode = True
        Me.StylizedColorButton21.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton21.TabIndex = 13
        Me.StylizedColorButton21.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton21.UseVisualStyleBackColor = True
        '
        'StylizedColorButton13
        '
        Me.StylizedColorButton13.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton13.Color = System.Drawing.Color.CadetBlue
        Me.StylizedColorButton13.Image = CType(resources.GetObject("StylizedColorButton13.Image"), System.Drawing.Image)
        Me.StylizedColorButton13.Location = New System.Drawing.Point(641, 9)
        Me.StylizedColorButton13.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton13.Name = "StylizedColorButton13"
        Me.StylizedColorButton13.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton13.RightClickMode = True
        Me.StylizedColorButton13.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton13.TabIndex = 14
        Me.StylizedColorButton13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton13.UseVisualStyleBackColor = True
        '
        'StylizedColorButton14
        '
        Me.StylizedColorButton14.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton14.Color = System.Drawing.Color.DeepSkyBlue
        Me.StylizedColorButton14.Image = CType(resources.GetObject("StylizedColorButton14.Image"), System.Drawing.Image)
        Me.StylizedColorButton14.Location = New System.Drawing.Point(683, 9)
        Me.StylizedColorButton14.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton14.Name = "StylizedColorButton14"
        Me.StylizedColorButton14.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton14.RightClickMode = True
        Me.StylizedColorButton14.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton14.TabIndex = 15
        Me.StylizedColorButton14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton14.UseVisualStyleBackColor = True
        '
        'StylizedColorButton15
        '
        Me.StylizedColorButton15.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton15.Color = System.Drawing.Color.Blue
        Me.StylizedColorButton15.Image = CType(resources.GetObject("StylizedColorButton15.Image"), System.Drawing.Image)
        Me.StylizedColorButton15.Location = New System.Drawing.Point(725, 9)
        Me.StylizedColorButton15.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton15.Name = "StylizedColorButton15"
        Me.StylizedColorButton15.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton15.RightClickMode = True
        Me.StylizedColorButton15.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton15.TabIndex = 16
        Me.StylizedColorButton15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton15.UseVisualStyleBackColor = True
        '
        'StylizedColorButton16
        '
        Me.StylizedColorButton16.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton16.Color = System.Drawing.Color.DarkSlateBlue
        Me.StylizedColorButton16.Image = CType(resources.GetObject("StylizedColorButton16.Image"), System.Drawing.Image)
        Me.StylizedColorButton16.Location = New System.Drawing.Point(767, 9)
        Me.StylizedColorButton16.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton16.Name = "StylizedColorButton16"
        Me.StylizedColorButton16.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton16.RightClickMode = True
        Me.StylizedColorButton16.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton16.TabIndex = 17
        Me.StylizedColorButton16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton16.UseVisualStyleBackColor = True
        '
        'StylizedColorButton17
        '
        Me.StylizedColorButton17.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton17.Color = System.Drawing.Color.Purple
        Me.StylizedColorButton17.Image = CType(resources.GetObject("StylizedColorButton17.Image"), System.Drawing.Image)
        Me.StylizedColorButton17.Location = New System.Drawing.Point(809, 9)
        Me.StylizedColorButton17.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton17.Name = "StylizedColorButton17"
        Me.StylizedColorButton17.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton17.RightClickMode = True
        Me.StylizedColorButton17.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton17.TabIndex = 18
        Me.StylizedColorButton17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton17.UseVisualStyleBackColor = True
        '
        'StylizedColorButton18
        '
        Me.StylizedColorButton18.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton18.Color = System.Drawing.Color.DeepPink
        Me.StylizedColorButton18.Image = CType(resources.GetObject("StylizedColorButton18.Image"), System.Drawing.Image)
        Me.StylizedColorButton18.Location = New System.Drawing.Point(851, 9)
        Me.StylizedColorButton18.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton18.Name = "StylizedColorButton18"
        Me.StylizedColorButton18.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton18.RightClickMode = True
        Me.StylizedColorButton18.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton18.TabIndex = 19
        Me.StylizedColorButton18.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.StylizedColorButton18.UseVisualStyleBackColor = True
        '
        'StylizedColorButton19
        '
        Me.StylizedColorButton19.BackColor = System.Drawing.Color.Transparent
        Me.StylizedColorButton19.Color = System.Drawing.Color.Fuchsia
        Me.StylizedColorButton19.Image = CType(resources.GetObject("StylizedColorButton19.Image"), System.Drawing.Image)
        Me.StylizedColorButton19.Location = New System.Drawing.Point(893, 9)
        Me.StylizedColorButton19.MinimumSize = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton19.Name = "StylizedColorButton19"
        Me.StylizedColorButton19.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedColorButton19.RightClickMode = True
        Me.StylizedColorButton19.Size = New System.Drawing.Size(36, 36)
        Me.StylizedColorButton19.TabIndex = 20
        Me.StylizedColorButton19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StylizedColorButton19.UseVisualStyleBackColor = True
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
        'PropertiesContainerPanel
        '
        Me.PropertiesContainerPanel.AutoScroll = True
        Me.PropertiesContainerPanel.BackColor = System.Drawing.Color.Transparent
        Me.PropertiesContainerPanel.Controls.Add(Me.PropertiesPanel)
        Me.PropertiesContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesContainerPanel.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesContainerPanel.Name = "PropertiesContainerPanel"
        Me.PropertiesContainerPanel.Size = New System.Drawing.Size(396, 962)
        Me.PropertiesContainerPanel.TabIndex = 13
        '
        'PropertiesPanel
        '
        Me.PropertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesPanel.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesPanel.Name = "PropertiesPanel"
        Me.PropertiesPanel.Size = New System.Drawing.Size(396, 962)
        Me.PropertiesPanel.TabIndex = 0
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
        Me.MainToolStripContainer.ContentPanel.Size = New System.Drawing.Size(1731, 962)
        Me.MainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'MainToolStripContainer.LeftToolStripPanel
        '
        Me.MainToolStripContainer.Location = New System.Drawing.Point(0, 33)
        Me.MainToolStripContainer.Name = "MainToolStripContainer"
        '
        'MainToolStripContainer.RightToolStripPanel
        '
        Me.MainToolStripContainer.Size = New System.Drawing.Size(1731, 1033)
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
        Me.DataToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CharCountToolStripLabel, Me.ToolStripSeparator10, Me.WordCountToolStripLabel, Me.ToolStripSeparator11, Me.lblPageCount, Me.ToolStripSeparator12, Me.ToolStripLabel1, Me.ThemeCombo})
        Me.DataToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DataToolStrip.Name = "DataToolStrip"
        Me.DataToolStrip.Size = New System.Drawing.Size(1731, 30)
        Me.DataToolStrip.Stretch = True
        Me.DataToolStrip.TabIndex = 2
        '
        'CharCountToolStripLabel
        '
        Me.CharCountToolStripLabel.Name = "CharCountToolStripLabel"
        Me.CharCountToolStripLabel.Size = New System.Drawing.Size(158, 25)
        Me.CharCountToolStripLabel.Text = "Character Count: 0"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 30)
        '
        'WordCountToolStripLabel
        '
        Me.WordCountToolStripLabel.Name = "WordCountToolStripLabel"
        Me.WordCountToolStripLabel.Size = New System.Drawing.Size(128, 25)
        Me.WordCountToolStripLabel.Text = "Word Count: 0"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 30)
        '
        'lblPageCount
        '
        Me.lblPageCount.Name = "lblPageCount"
        Me.lblPageCount.Size = New System.Drawing.Size(122, 25)
        Me.lblPageCount.Text = "Page Count: 0"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 33)
        Me.ToolStripSeparator12.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(69, 28)
        Me.ToolStripLabel1.Text = "Theme:"
        Me.ToolStripLabel1.Visible = False
        '
        'ThemeCombo
        '
        Me.ThemeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ThemeCombo.Items.AddRange(New Object() {"Breeze"})
        Me.ThemeCombo.Name = "ThemeCombo"
        Me.ThemeCombo.Size = New System.Drawing.Size(145, 33)
        Me.ThemeCombo.Visible = False
        '
        'MainToolStrip
        '
        Me.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.PastePlainToolStripButton, Me.toolStripSeparator2, Me.UndoToolStripButton, Me.RedoToolStripButton, Me.ToolStripSeparator9, Me.CharacterEditorToolStripButton, Me.DictionaryToolStripButton, Me.ToolStripSeparator14, Me.FontToolStripButton, Me.ToolStripSeparator15, Me.BoldToolStripButton, Me.ItalicToolStripButton, Me.UnderlineToolStripButton, Me.StrikeToolStripButton, Me.ToolStripSeparator5, Me.AlignLeftToolStripButton, Me.AlignCenterToolStripButton, Me.AlignRightToolStripButton, Me.ToolStripSeparator8, Me.IndentToolStripComboBox, Me.IndentToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.MinimumSize = New System.Drawing.Size(0, 38)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(1731, 41)
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
        'IndentToolStripComboBox
        '
        Me.IndentToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IndentToolStripComboBox.Name = "IndentToolStripComboBox"
        Me.IndentToolStripComboBox.Size = New System.Drawing.Size(100, 41)
        '
        'IndentToolStripButton
        '
        Me.IndentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IndentToolStripButton.Image = CType(resources.GetObject("IndentToolStripButton.Image"), System.Drawing.Image)
        Me.IndentToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IndentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.IndentToolStripButton.Name = "IndentToolStripButton"
        Me.IndentToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.IndentToolStripButton.Text = "Indent"
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
        Me.MainMenu.Size = New System.Drawing.Size(1731, 33)
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
        Me.FullModeToolStripMenuItem.Name = "FullModeToolStripMenuItem"
        Me.FullModeToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.FullModeToolStripMenuItem.Text = "Full Mode"
        '
        'MinimalModeToolStripMenuItem
        '
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
        Me.PageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPageToolStripMenuItem, Me.RemovePageToolStripMenuItem, Me.DuplicatePageToolStripMenuItem, Me.ToolStripMenuItem28, Me.RenamePageToolStripMenuItem, Me.ToolStripMenuItem29, Me.ImportPageToolStripMenuItem, Me.ExportPageToolStripMenuItem, Me.ToolStripMenuItem3, Me.PreviousPageToolStripMenuItem, Me.NextPageToolStripMenuItem, Me.ToolStripSeparator21, Me.DictionaryMenuItem})
        Me.PageToolStripMenuItem.Name = "PageToolStripMenuItem"
        Me.PageToolStripMenuItem.Size = New System.Drawing.Size(109, 29)
        Me.PageToolStripMenuItem.Text = "Notebook"
        '
        'AddPageToolStripMenuItem
        '
        Me.AddPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddPageToolStripMenuItem.Name = "AddPageToolStripMenuItem"
        Me.AddPageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.AddPageToolStripMenuItem.Size = New System.Drawing.Size(328, 34)
        Me.AddPageToolStripMenuItem.Text = "Add Page"
        '
        'RemovePageToolStripMenuItem
        '
        Me.RemovePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemovePageToolStripMenuItem.Name = "RemovePageToolStripMenuItem"
        Me.RemovePageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.RemovePageToolStripMenuItem.Size = New System.Drawing.Size(328, 34)
        Me.RemovePageToolStripMenuItem.Text = "Remove Page"
        '
        'DuplicatePageToolStripMenuItem
        '
        Me.DuplicatePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DuplicatePageToolStripMenuItem.Name = "DuplicatePageToolStripMenuItem"
        Me.DuplicatePageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DuplicatePageToolStripMenuItem.Size = New System.Drawing.Size(328, 34)
        Me.DuplicatePageToolStripMenuItem.Text = "Duplicate Page"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(325, 6)
        '
        'RenamePageToolStripMenuItem
        '
        Me.RenamePageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RenamePageToolStripMenuItem.Name = "RenamePageToolStripMenuItem"
        Me.RenamePageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.RenamePageToolStripMenuItem.Size = New System.Drawing.Size(328, 34)
        Me.RenamePageToolStripMenuItem.Text = "Rename Page..."
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(325, 6)
        '
        'ImportPageToolStripMenuItem
        '
        Me.ImportPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportPageToolStripMenuItem.Name = "ImportPageToolStripMenuItem"
        Me.ImportPageToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImportPageToolStripMenuItem.Size = New System.Drawing.Size(328, 34)
        Me.ImportPageToolStripMenuItem.Text = "Import Page..."
        '
        'ExportPageToolStripMenuItem
        '
        Me.ExportPageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportPageToolStripMenuItem.Name = "ExportPageToolStripMenuItem"
        Me.ExportPageToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExportPageToolStripMenuItem.Size = New System.Drawing.Size(328, 34)
        Me.ExportPageToolStripMenuItem.Text = "Export Page..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(325, 6)
        '
        'PreviousPageToolStripMenuItem
        '
        Me.PreviousPageToolStripMenuItem.Name = "PreviousPageToolStripMenuItem"
        Me.PreviousPageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.PreviousPageToolStripMenuItem.Size = New System.Drawing.Size(328, 34)
        Me.PreviousPageToolStripMenuItem.Text = "Previous Page"
        '
        'NextPageToolStripMenuItem
        '
        Me.NextPageToolStripMenuItem.Name = "NextPageToolStripMenuItem"
        Me.NextPageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.NextPageToolStripMenuItem.Size = New System.Drawing.Size(328, 34)
        Me.NextPageToolStripMenuItem.Text = "Next Page"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(325, 6)
        '
        'DictionaryMenuItem
        '
        Me.DictionaryMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DictionaryMenuItem.Name = "DictionaryMenuItem"
        Me.DictionaryMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.DictionaryMenuItem.Size = New System.Drawing.Size(328, 34)
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
        Me.BroadTranscriptionToolStripMenuItem.Name = "BroadTranscriptionToolStripMenuItem"
        Me.BroadTranscriptionToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BroadTranscriptionToolStripMenuItem.Size = New System.Drawing.Size(415, 34)
        Me.BroadTranscriptionToolStripMenuItem.Text = "Broad Transcription /◌/"
        '
        'NarrowTranscriptionToolStripMenuItem
        '
        Me.NarrowTranscriptionToolStripMenuItem.Name = "NarrowTranscriptionToolStripMenuItem"
        Me.NarrowTranscriptionToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.NarrowTranscriptionToolStripMenuItem.Size = New System.Drawing.Size(415, 34)
        Me.NarrowTranscriptionToolStripMenuItem.Text = "Narrow Transcription [◌]"
        '
        'RemoveBracketsToolStripMenuItem
        '
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
        Me.AlignLeftToolStripMenuItem.Name = "AlignLeftToolStripMenuItem"
        Me.AlignLeftToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.AlignLeftToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.AlignLeftToolStripMenuItem.Text = "Align Left"
        '
        'AlignCenterToolStripMenuItem
        '
        Me.AlignCenterToolStripMenuItem.Name = "AlignCenterToolStripMenuItem"
        Me.AlignCenterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.AlignCenterToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.AlignCenterToolStripMenuItem.Text = "Align Center"
        '
        'AlignRightToolStripMenuItem
        '
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
        Me.BoldToolStripMenuItem.Name = "BoldToolStripMenuItem"
        Me.BoldToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BoldToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.BoldToolStripMenuItem.Text = "Bold"
        '
        'ItalicToolStripMenuItem
        '
        Me.ItalicToolStripMenuItem.Name = "ItalicToolStripMenuItem"
        Me.ItalicToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ItalicToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.ItalicToolStripMenuItem.Text = "Italic"
        '
        'UnderlineToolStripMenuItem
        '
        Me.UnderlineToolStripMenuItem.Name = "UnderlineToolStripMenuItem"
        Me.UnderlineToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UnderlineToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.UnderlineToolStripMenuItem.Text = "Underline"
        '
        'StrikeToolStripMenuItem
        '
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
        Me.IncreaseIndentToolStripMenuItem.Name = "IncreaseIndentToolStripMenuItem"
        Me.IncreaseIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.IncreaseIndentToolStripMenuItem.Text = "Increase Indent"
        '
        'DecreaseIndentToolStripMenuItem
        '
        Me.DecreaseIndentToolStripMenuItem.Name = "DecreaseIndentToolStripMenuItem"
        Me.DecreaseIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.DecreaseIndentToolStripMenuItem.Text = "Decrease Indent"
        Me.DecreaseIndentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ResetIndentToolStripMenuItem
        '
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
        Me.IncreaseBulletIndentToolStripMenuItem.Name = "IncreaseBulletIndentToolStripMenuItem"
        Me.IncreaseBulletIndentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Tab), System.Windows.Forms.Keys)
        Me.IncreaseBulletIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.IncreaseBulletIndentToolStripMenuItem.Text = "Increase Bullet Indent"
        '
        'DecreaseBulletIndentToolStripMenuItem
        '
        Me.DecreaseBulletIndentToolStripMenuItem.Name = "DecreaseBulletIndentToolStripMenuItem"
        Me.DecreaseBulletIndentToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Tab), System.Windows.Forms.Keys)
        Me.DecreaseBulletIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.DecreaseBulletIndentToolStripMenuItem.Text = "Decrease Bullet Indent"
        Me.DecreaseBulletIndentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ResetBulletIndentToolStripMenuItem
        '
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
        Me.IncreaseHangingIndentToolStripMenuItem.Name = "IncreaseHangingIndentToolStripMenuItem"
        Me.IncreaseHangingIndentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.IncreaseHangingIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.IncreaseHangingIndentToolStripMenuItem.Text = "Increase Hanging Indent"
        '
        'DecreaseHangingIndentToolStripMenuItem
        '
        Me.DecreaseHangingIndentToolStripMenuItem.Name = "DecreaseHangingIndentToolStripMenuItem"
        Me.DecreaseHangingIndentToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.DecreaseHangingIndentToolStripMenuItem.Size = New System.Drawing.Size(427, 34)
        Me.DecreaseHangingIndentToolStripMenuItem.Text = "Decrease Hanging Indent"
        '
        'ResetHangingIndentToolStripMenuItem
        '
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
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(176, 34)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1731, 1066)
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
        Me.FindReplaceDialog.ResumeLayout(False)
        Me.FindReplaceDialog.PerformLayout()
        Me.ColorPanel.ResumeLayout(False)
        Me.ColorPanel.PerformLayout()
        Me.ColorLayoutPanel.ResumeLayout(False)
        Me.PropertiesContainerPanel.ResumeLayout(False)
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
    Friend WithEvents FindReplaceDialog As TundraLib.DoubleBufferedPanel
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
    Friend WithEvents NotebookTabs As System.Windows.Forms.TabControl
    Friend WithEvents OpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PropertiesContainerPanel As TundraLib.DoubleBufferedPanel
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
    Friend WithEvents lblPageCount As ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ThemeCombo As ToolStripComboBox
    Friend WithEvents ColorPanel As TundraLib.DoubleBufferedPanel
    Friend WithEvents ColorLayoutPanel As FlowLayoutPanel
    Friend WithEvents StylizedColorButton1 As TundraLib.StylizedColorButton
    Friend WithEvents rbHighlight As RadioButton
    Friend WithEvents TextColorRadio As RadioButton
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
    Friend WithEvents ToggleToolbarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToggleStatusbarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimalModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents TransparentColorButton As Button
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents DictionaryMenuItem As ToolStripMenuItem
    Friend WithEvents PropertiesPanel As PropertiesEditor
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
    Friend WithEvents IndentToolStripComboBox As ToolStripComboBox
    Friend WithEvents IndentToolStripButton As ToolStripButton
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
End Class