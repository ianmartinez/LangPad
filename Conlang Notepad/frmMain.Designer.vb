<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.dlgSaveNarration = New System.Windows.Forms.SaveFileDialog()
        Me.cmsMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeselectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NarrateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsTextHighlight = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsTextColor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.tcNotebook = New System.Windows.Forms.TabControl()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.EmoteLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.StylizedButton3 = New Tundra.StylizedButton()
        Me.StylizedButton4 = New Tundra.StylizedButton()
        Me.StylizedButton5 = New Tundra.StylizedButton()
        Me.StylizedButton6 = New Tundra.StylizedButton()
        Me.StylizedButton7 = New Tundra.StylizedButton()
        Me.StylizedButton8 = New Tundra.StylizedButton()
        Me.StylizedButton9 = New Tundra.StylizedButton()
        Me.StylizedButton10 = New Tundra.StylizedButton()
        Me.StylizedButton11 = New Tundra.StylizedButton()
        Me.StylizedButton12 = New Tundra.StylizedButton()
        Me.StylizedButton13 = New Tundra.StylizedButton()
        Me.StylizedButton14 = New Tundra.StylizedButton()
        Me.StylizedButton15 = New Tundra.StylizedButton()
        Me.StylizedButton16 = New Tundra.StylizedButton()
        Me.StylizedButton17 = New Tundra.StylizedButton()
        Me.StylizedButton18 = New Tundra.StylizedButton()
        Me.StylizedButton19 = New Tundra.StylizedButton()
        Me.StylizedButton20 = New Tundra.StylizedButton()
        Me.StylizedButton21 = New Tundra.StylizedButton()
        Me.StylizedButton22 = New Tundra.StylizedButton()
        Me.StylizedButton23 = New Tundra.StylizedButton()
        Me.StylizedButton24 = New Tundra.StylizedButton()
        Me.StylizedButton25 = New Tundra.StylizedButton()
        Me.StylizedButton26 = New Tundra.StylizedButton()
        Me.StylizedButton27 = New Tundra.StylizedButton()
        Me.StylizedButton28 = New Tundra.StylizedButton()
        Me.StylizedButton29 = New Tundra.StylizedButton()
        Me.StylizedButton30 = New Tundra.StylizedButton()
        Me.StylizedButton31 = New Tundra.StylizedButton()
        Me.StylizedButton32 = New Tundra.StylizedButton()
        Me.StylizedButton33 = New Tundra.StylizedButton()
        Me.StylizedButton34 = New Tundra.StylizedButton()
        Me.StylizedButton35 = New Tundra.StylizedButton()
        Me.StylizedButton36 = New Tundra.StylizedButton()
        Me.StylizedButton37 = New Tundra.StylizedButton()
        Me.StylizedButton38 = New Tundra.StylizedButton()
        Me.StylizedButton39 = New Tundra.StylizedButton()
        Me.StylizedButton40 = New Tundra.StylizedButton()
        Me.StylizedButton41 = New Tundra.StylizedButton()
        Me.StylizedButton93 = New Tundra.StylizedButton()
        Me.StylizedButton42 = New Tundra.StylizedButton()
        Me.StylizedButton43 = New Tundra.StylizedButton()
        Me.StylizedButton44 = New Tundra.StylizedButton()
        Me.StylizedButton45 = New Tundra.StylizedButton()
        Me.StylizedButton46 = New Tundra.StylizedButton()
        Me.StylizedButton47 = New Tundra.StylizedButton()
        Me.StylizedButton48 = New Tundra.StylizedButton()
        Me.StylizedButton49 = New Tundra.StylizedButton()
        Me.StylizedButton50 = New Tundra.StylizedButton()
        Me.StylizedButton51 = New Tundra.StylizedButton()
        Me.StylizedButton52 = New Tundra.StylizedButton()
        Me.StylizedButton53 = New Tundra.StylizedButton()
        Me.StylizedButton88 = New Tundra.StylizedButton()
        Me.StylizedButton54 = New Tundra.StylizedButton()
        Me.StylizedButton55 = New Tundra.StylizedButton()
        Me.StylizedButton56 = New Tundra.StylizedButton()
        Me.StylizedButton57 = New Tundra.StylizedButton()
        Me.StylizedButton58 = New Tundra.StylizedButton()
        Me.StylizedButton90 = New Tundra.StylizedButton()
        Me.StylizedButton65 = New Tundra.StylizedButton()
        Me.StylizedButton59 = New Tundra.StylizedButton()
        Me.StylizedButton60 = New Tundra.StylizedButton()
        Me.StylizedButton61 = New Tundra.StylizedButton()
        Me.StylizedButton62 = New Tundra.StylizedButton()
        Me.StylizedButton63 = New Tundra.StylizedButton()
        Me.StylizedButton64 = New Tundra.StylizedButton()
        Me.StylizedButton66 = New Tundra.StylizedButton()
        Me.StylizedButton68 = New Tundra.StylizedButton()
        Me.StylizedButton71 = New Tundra.StylizedButton()
        Me.StylizedButton69 = New Tundra.StylizedButton()
        Me.StylizedButton70 = New Tundra.StylizedButton()
        Me.StylizedButton72 = New Tundra.StylizedButton()
        Me.StylizedButton73 = New Tundra.StylizedButton()
        Me.StylizedButton74 = New Tundra.StylizedButton()
        Me.StylizedButton75 = New Tundra.StylizedButton()
        Me.StylizedButton76 = New Tundra.StylizedButton()
        Me.StylizedButton77 = New Tundra.StylizedButton()
        Me.StylizedButton78 = New Tundra.StylizedButton()
        Me.StylizedButton79 = New Tundra.StylizedButton()
        Me.StylizedButton80 = New Tundra.StylizedButton()
        Me.StylizedButton67 = New Tundra.StylizedButton()
        Me.StylizedButton81 = New Tundra.StylizedButton()
        Me.StylizedButton82 = New Tundra.StylizedButton()
        Me.StylizedButton83 = New Tundra.StylizedButton()
        Me.StylizedButton84 = New Tundra.StylizedButton()
        Me.StylizedButton85 = New Tundra.StylizedButton()
        Me.StylizedButton86 = New Tundra.StylizedButton()
        Me.StylizedButton87 = New Tundra.StylizedButton()
        Me.StylizedButton89 = New Tundra.StylizedButton()
        Me.StylizedButton91 = New Tundra.StylizedButton()
        Me.StylizedButton92 = New Tundra.StylizedButton()
        Me.StylizedButton94 = New Tundra.StylizedButton()
        Me.StylizedButton95 = New Tundra.StylizedButton()
        Me.StylizedButton96 = New Tundra.StylizedButton()
        Me.StylizedButton97 = New Tundra.StylizedButton()
        Me.StylizedButton100 = New Tundra.StylizedButton()
        Me.StylizedButton102 = New Tundra.StylizedButton()
        Me.ClipArtLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.StylizedPanel2 = New Tundra.StylizedPanel()
        Me.btnClose = New Tundra.StylizedButton()
        Me.btnEmotesTab = New Tundra.StylizedRadioButton()
        Me.btnClipArtTab = New Tundra.StylizedRadioButton()
        Me.StylizedRadioButton1 = New Tundra.StylizedRadioButton()
        Me.btnNotebookTab = New Tundra.StylizedRadioButton()
        Me.dlgSaveNotebook = New System.Windows.Forms.SaveFileDialog()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSaveSpeech = New Tundra.StylizedButton()
        Me.btnStop = New Tundra.StylizedButton()
        Me.btnPlay = New Tundra.StylizedButton()
        Me.btnBaseline = New Tundra.StylizedButton()
        Me.btnSubscript = New Tundra.StylizedButton()
        Me.btnSuperscript = New Tundra.StylizedButton()
        Me.btnRight = New Tundra.StylizedButton()
        Me.btnCenter = New Tundra.StylizedButton()
        Me.btnLeft = New Tundra.StylizedButton()
        Me.btnIndent = New Tundra.StylizedButton()
        Me.btnStrikethrough = New Tundra.StylizedButton()
        Me.btnUnderline = New Tundra.StylizedButton()
        Me.btnItalic = New Tundra.StylizedButton()
        Me.btnBold = New Tundra.StylizedButton()
        Me.btnQuickRedo = New Tundra.StylizedButton()
        Me.btnQuickUndo = New Tundra.StylizedButton()
        Me.btnQuickSymbols = New Tundra.StylizedButton()
        Me.btnQuickAccents = New Tundra.StylizedButton()
        Me.btnQuickOpen = New Tundra.StylizedButton()
        Me.btnQuickSave = New Tundra.StylizedButton()
        Me.dlgSaveImage = New System.Windows.Forms.SaveFileDialog()
        Me.pnlFindReplace = New Tundra.StylizedPanel()
        Me.btnFindNext = New Tundra.StylizedButton()
        Me.btnReplaceAll = New Tundra.StylizedButton()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnReplace = New Tundra.StylizedButton()
        Me.btnFind = New Tundra.StylizedButton()
        Me.pnlTop = New Tundra.StylizedPanel()
        Me.pnlControl = New Tundra.DoubleBufferedPanel()
        Me.btnCustomZoom = New Tundra.StylizedButton()
        Me.btnWordWrap = New Tundra.StylizedButton()
        Me.btnSelectAll = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel14 = New Tundra.DoubleBufferedPanel()
        Me.btnFindReplace = New Tundra.StylizedButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnZoom100 = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel13 = New Tundra.DoubleBufferedPanel()
        Me.btnZoomOut = New Tundra.StylizedButton()
        Me.btnZoomIn = New Tundra.StylizedButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlInsert = New Tundra.DoubleBufferedPanel()
        Me.btnEdit = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel20 = New Tundra.DoubleBufferedPanel()
        Me.btnApply = New Tundra.StylizedButton()
        Me.btnDefault = New Tundra.StylizedButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnTable = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel12 = New Tundra.DoubleBufferedPanel()
        Me.btnTextArt = New Tundra.StylizedButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnClipArt = New Tundra.StylizedButton()
        Me.btnEmojis = New Tundra.StylizedButton()
        Me.btnWebcam = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel8 = New Tundra.DoubleBufferedPanel()
        Me.btnImportFile = New Tundra.StylizedButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DoubleBufferedPanel9 = New Tundra.DoubleBufferedPanel()
        Me.btnRemoveBullets = New Tundra.StylizedButton()
        Me.btnAddBullets = New Tundra.StylizedButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlNotebook = New Tundra.DoubleBufferedPanel()
        Me.DoubleBufferedPanel23 = New Tundra.DoubleBufferedPanel()
        Me.lblDictionary = New System.Windows.Forms.Label()
        Me.StylizedButton1 = New Tundra.StylizedButton()
        Me.btnDuplicate = New Tundra.StylizedButton()
        Me.btnExportPage = New Tundra.StylizedButton()
        Me.btnImportPage = New Tundra.StylizedButton()
        Me.btnRenamePage = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel18 = New Tundra.DoubleBufferedPanel()
        Me.btnNotebookEditor = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel19 = New Tundra.DoubleBufferedPanel()
        Me.btnRemove = New Tundra.StylizedButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnAdd = New Tundra.StylizedButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.pnlLinguistics = New Tundra.DoubleBufferedPanel()
        Me.nudSpeed = New System.Windows.Forms.NumericUpDown()
        Me.cbVoice = New System.Windows.Forms.ComboBox()
        Me.btnCustomSymbols = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel2 = New Tundra.DoubleBufferedPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DoubleBufferedPanel10 = New Tundra.DoubleBufferedPanel()
        Me.btnAccentMark = New Tundra.StylizedButton()
        Me.btnSymbols = New Tundra.StylizedButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlMain = New Tundra.DoubleBufferedPanel()
        Me.nudSize = New System.Windows.Forms.NumericUpDown()
        Me.DoubleBufferedPanel1 = New Tundra.DoubleBufferedPanel()
        Me.btnHighlight = New Tundra.StylizedButton()
        Me.btnText = New Tundra.StylizedButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudIndent = New System.Windows.Forms.NumericUpDown()
        Me.DoubleBufferedPanel6 = New Tundra.DoubleBufferedPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFont = New Tundra.StylizedButton()
        Me.cbFont = New System.Windows.Forms.ComboBox()
        Me.DoubleBufferedPanel5 = New Tundra.DoubleBufferedPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPastePlain = New Tundra.StylizedButton()
        Me.btnPaste = New Tundra.StylizedButton()
        Me.btnCut = New Tundra.StylizedButton()
        Me.btnCopy = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel4 = New Tundra.DoubleBufferedPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRedo = New Tundra.StylizedButton()
        Me.btnUndo = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel3 = New Tundra.DoubleBufferedPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlFile = New Tundra.DoubleBufferedPanel()
        Me.btnSettings = New Tundra.StylizedButton()
        Me.btnCheckUpdate = New Tundra.StylizedButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DoubleBufferedPanel15 = New Tundra.DoubleBufferedPanel()
        Me.DoubleBufferedPanel16 = New Tundra.DoubleBufferedPanel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnRTF = New Tundra.StylizedButton()
        Me.btnPageSetup = New Tundra.StylizedButton()
        Me.btnAbout = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel11 = New Tundra.DoubleBufferedPanel()
        Me.btnPrint = New Tundra.StylizedButton()
        Me.btnPrintPreview = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel7 = New Tundra.DoubleBufferedPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSaveAs = New Tundra.StylizedButton()
        Me.btnOpen = New Tundra.StylizedButton()
        Me.btnSave = New Tundra.StylizedButton()
        Me.btnNew = New Tundra.StylizedButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlTabs = New Tundra.StylizedPanel()
        Me.DoubleBufferedPanel22 = New Tundra.DoubleBufferedPanel()
        Me.DoubleBufferedPanel17 = New Tundra.DoubleBufferedPanel()
        Me.btnControl = New Tundra.StylizedRadioButton()
        Me.btnInsert = New Tundra.StylizedRadioButton()
        Me.btnNotebook = New Tundra.StylizedRadioButton()
        Me.btnLinguistics = New Tundra.StylizedRadioButton()
        Me.btnHome = New Tundra.StylizedRadioButton()
        Me.btnConlangNotepad = New Tundra.StylizedRadioButton()
        Me.DoubleBufferedPanel21 = New Tundra.DoubleBufferedPanel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblCharCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblWordCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NotebookEditor1 = New Language_Pad.NotebookEditor()
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
        Me.cmsTextHighlight.SuspendLayout()
        Me.cmsTextColor.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.EmoteLayoutPanel.SuspendLayout()
        Me.StylizedPanel2.SuspendLayout()
        Me.pnlFindReplace.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlInsert.SuspendLayout()
        Me.pnlNotebook.SuspendLayout()
        Me.pnlLinguistics.SuspendLayout()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.nudSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIndent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFile.SuspendLayout()
        Me.pnlTabs.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
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
        Me.tcSymbols.Location = New System.Drawing.Point(0, 2)
        Me.tcSymbols.Margin = New System.Windows.Forms.Padding(2)
        Me.tcSymbols.Name = "tcSymbols"
        Me.tcSymbols.SelectedIndex = 0
        Me.tcSymbols.Size = New System.Drawing.Size(977, 122)
        Me.tcSymbols.TabIndex = 72
        '
        'ConsonantsTabPage
        '
        Me.ConsonantsTabPage.Controls.Add(Me.ConsonantsLayoutPanel)
        Me.ConsonantsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ConsonantsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.ConsonantsTabPage.Name = "ConsonantsTabPage"
        Me.ConsonantsTabPage.Size = New System.Drawing.Size(969, 96)
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
        Me.ConsonantsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsonantsLayoutPanel.Name = "ConsonantsLayoutPanel"
        Me.ConsonantsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.ConsonantsLayoutPanel.Size = New System.Drawing.Size(969, 96)
        Me.ConsonantsLayoutPanel.TabIndex = 7
        '
        'AffricatesTabPage
        '
        Me.AffricatesTabPage.Controls.Add(Me.AffricatesLayoutPanel)
        Me.AffricatesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AffricatesTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.AffricatesTabPage.Name = "AffricatesTabPage"
        Me.AffricatesTabPage.Size = New System.Drawing.Size(969, 96)
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
        Me.AffricatesLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AffricatesLayoutPanel.Name = "AffricatesLayoutPanel"
        Me.AffricatesLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.AffricatesLayoutPanel.Size = New System.Drawing.Size(969, 96)
        Me.AffricatesLayoutPanel.TabIndex = 8
        '
        'VowelsTabPage
        '
        Me.VowelsTabPage.Controls.Add(Me.VowelsLayoutPanel)
        Me.VowelsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.VowelsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.VowelsTabPage.Name = "VowelsTabPage"
        Me.VowelsTabPage.Size = New System.Drawing.Size(969, 96)
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
        Me.VowelsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.VowelsLayoutPanel.Name = "VowelsLayoutPanel"
        Me.VowelsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.VowelsLayoutPanel.Size = New System.Drawing.Size(969, 96)
        Me.VowelsLayoutPanel.TabIndex = 8
        '
        'AccentsTabPage
        '
        Me.AccentsTabPage.Controls.Add(Me.AccentsLayoutPanel)
        Me.AccentsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AccentsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.AccentsTabPage.Name = "AccentsTabPage"
        Me.AccentsTabPage.Size = New System.Drawing.Size(969, 96)
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
        Me.AccentsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AccentsLayoutPanel.Name = "AccentsLayoutPanel"
        Me.AccentsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.AccentsLayoutPanel.Size = New System.Drawing.Size(969, 96)
        Me.AccentsLayoutPanel.TabIndex = 9
        '
        'ToneIntonationTabPage
        '
        Me.ToneIntonationTabPage.Controls.Add(Me.ToneIntonationLayoutPanel)
        Me.ToneIntonationTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ToneIntonationTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.ToneIntonationTabPage.Name = "ToneIntonationTabPage"
        Me.ToneIntonationTabPage.Size = New System.Drawing.Size(969, 96)
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
        Me.ToneIntonationLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ToneIntonationLayoutPanel.Name = "ToneIntonationLayoutPanel"
        Me.ToneIntonationLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.ToneIntonationLayoutPanel.Size = New System.Drawing.Size(969, 96)
        Me.ToneIntonationLayoutPanel.TabIndex = 10
        '
        'OtherTabPage
        '
        Me.OtherTabPage.Controls.Add(Me.OtherLayoutPanel)
        Me.OtherTabPage.Location = New System.Drawing.Point(4, 22)
        Me.OtherTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.OtherTabPage.Name = "OtherTabPage"
        Me.OtherTabPage.Size = New System.Drawing.Size(969, 96)
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
        Me.OtherLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.OtherLayoutPanel.Name = "OtherLayoutPanel"
        Me.OtherLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.OtherLayoutPanel.Size = New System.Drawing.Size(969, 96)
        Me.OtherLayoutPanel.TabIndex = 8
        '
        'CommonTabPage
        '
        Me.CommonTabPage.Controls.Add(Me.CommonLayoutPanel)
        Me.CommonTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CommonTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.CommonTabPage.Name = "CommonTabPage"
        Me.CommonTabPage.Size = New System.Drawing.Size(969, 96)
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
        Me.CommonLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CommonLayoutPanel.Name = "CommonLayoutPanel"
        Me.CommonLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.CommonLayoutPanel.Size = New System.Drawing.Size(969, 96)
        Me.CommonLayoutPanel.TabIndex = 9
        '
        'CustomTabPage
        '
        Me.CustomTabPage.Controls.Add(Me.CustomLayoutPanel)
        Me.CustomTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CustomTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.CustomTabPage.Name = "CustomTabPage"
        Me.CustomTabPage.Size = New System.Drawing.Size(969, 96)
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
        Me.CustomLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomLayoutPanel.Name = "CustomLayoutPanel"
        Me.CustomLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.CustomLayoutPanel.Size = New System.Drawing.Size(969, 96)
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
        'dlgSaveNarration
        '
        Me.dlgSaveNarration.Filter = "Audio files (*.wav)|*.wav|All files (*.*)|*.*"
        '
        'cmsMain
        '
        Me.cmsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.CutToolStripMenuItem, Me.ToolStripSeparator1, Me.SelectAllToolStripMenuItem, Me.DeselectAllToolStripMenuItem, Me.ToolStripMenuItem1, Me.NarrateToolStripMenuItem})
        Me.cmsMain.Name = "cmsMain"
        Me.cmsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.cmsMain.Size = New System.Drawing.Size(136, 148)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(132, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Image = CType(resources.GetObject("SelectAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'DeselectAllToolStripMenuItem
        '
        Me.DeselectAllToolStripMenuItem.Image = CType(resources.GetObject("DeselectAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeselectAllToolStripMenuItem.Name = "DeselectAllToolStripMenuItem"
        Me.DeselectAllToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.DeselectAllToolStripMenuItem.Text = "Deselect All"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(132, 6)
        '
        'NarrateToolStripMenuItem
        '
        Me.NarrateToolStripMenuItem.Image = CType(resources.GetObject("NarrateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NarrateToolStripMenuItem.Name = "NarrateToolStripMenuItem"
        Me.NarrateToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.NarrateToolStripMenuItem.Text = "Narrate"
        '
        'cmsTextHighlight
        '
        Me.cmsTextHighlight.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTextHighlight.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12, Me.ToolStripMenuItem13, Me.ToolStripMenuItem14, Me.ToolStripMenuItem15, Me.ToolStripMenuItem16, Me.ToolStripMenuItem17, Me.ToolStripMenuItem18, Me.ToolStripMenuItem19, Me.ToolStripMenuItem20, Me.ToolStripMenuItem21})
        Me.cmsTextHighlight.Name = "cmsMain"
        Me.cmsTextHighlight.Size = New System.Drawing.Size(78, 224)
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.BackColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem12.Text = " "
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.BackColor = System.Drawing.Color.Gray
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem13.Text = " "
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem14.Text = " "
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.BackColor = System.Drawing.Color.Red
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem15.Text = " "
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem16.Text = " "
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.BackColor = System.Drawing.Color.Yellow
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem17.Text = " "
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.BackColor = System.Drawing.Color.Lime
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem18.Text = " "
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.BackColor = System.Drawing.Color.Cyan
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem19.Text = " "
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.BackColor = System.Drawing.Color.Blue
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(77, 22)
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.BackColor = System.Drawing.Color.Fuchsia
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(77, 22)
        '
        'cmsTextColor
        '
        Me.cmsTextColor.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsTextColor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem2, Me.ToolStripMenuItem11})
        Me.cmsTextColor.Name = "cmsMain"
        Me.cmsTextColor.Size = New System.Drawing.Size(78, 224)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem3.Text = " "
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.Gray
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem4.Text = " "
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem5.Text = " "
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.BackColor = System.Drawing.Color.Red
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem6.Text = " "
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem7.Text = " "
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.BackColor = System.Drawing.Color.Yellow
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem8.Text = " "
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.BackColor = System.Drawing.Color.Lime
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem9.Text = " "
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.BackColor = System.Drawing.Color.Cyan
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripMenuItem10.Text = " "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Blue
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(77, 22)
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.BackColor = System.Drawing.Color.Fuchsia
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(77, 22)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 276)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tcSymbols)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(977, 367)
        Me.SplitContainer1.SplitterDistance = 124
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 73
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.tcNotebook)
        Me.SplitContainer2.Panel1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.StylizedPanel1)
        Me.SplitContainer2.Panel2MinSize = 235
        Me.SplitContainer2.Size = New System.Drawing.Size(977, 241)
        Me.SplitContainer2.SplitterDistance = 722
        Me.SplitContainer2.SplitterWidth = 2
        Me.SplitContainer2.TabIndex = 1
        '
        'tcNotebook
        '
        Me.tcNotebook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcNotebook.Location = New System.Drawing.Point(0, 2)
        Me.tcNotebook.Margin = New System.Windows.Forms.Padding(2)
        Me.tcNotebook.Name = "tcNotebook"
        Me.tcNotebook.SelectedIndex = 0
        Me.tcNotebook.Size = New System.Drawing.Size(722, 239)
        Me.tcNotebook.TabIndex = 73
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.AutoScroll = True
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.EmoteLayoutPanel)
        Me.StylizedPanel1.Controls.Add(Me.ClipArtLayoutPanel)
        Me.StylizedPanel1.Controls.Add(Me.NotebookEditor1)
        Me.StylizedPanel1.Controls.Add(Me.StylizedPanel2)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Size = New System.Drawing.Size(253, 241)
        Me.StylizedPanel1.Style = "Colors=~245|~245" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight" &
    " Color=$0"
        Me.StylizedPanel1.TabIndex = 13
        '
        'EmoteLayoutPanel
        '
        Me.EmoteLayoutPanel.AutoScroll = True
        Me.EmoteLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton3)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton4)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton5)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton6)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton7)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton8)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton9)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton10)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton11)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton12)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton13)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton14)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton15)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton16)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton17)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton18)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton19)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton20)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton21)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton22)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton23)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton24)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton25)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton26)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton27)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton28)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton29)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton30)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton31)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton32)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton33)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton34)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton35)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton36)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton37)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton38)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton39)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton40)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton41)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton93)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton42)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton43)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton44)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton45)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton46)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton47)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton48)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton49)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton50)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton51)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton52)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton53)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton88)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton54)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton55)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton56)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton57)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton58)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton90)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton65)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton59)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton60)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton61)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton62)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton63)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton64)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton66)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton68)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton71)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton69)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton70)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton72)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton73)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton74)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton75)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton76)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton77)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton78)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton79)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton80)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton67)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton81)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton82)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton83)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton84)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton85)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton86)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton87)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton89)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton91)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton92)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton94)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton95)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton96)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton97)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton100)
        Me.EmoteLayoutPanel.Controls.Add(Me.StylizedButton102)
        Me.EmoteLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmoteLayoutPanel.Location = New System.Drawing.Point(0, 115)
        Me.EmoteLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.EmoteLayoutPanel.Name = "EmoteLayoutPanel"
        Me.EmoteLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.EmoteLayoutPanel.Size = New System.Drawing.Size(253, 46)
        Me.EmoteLayoutPanel.TabIndex = 8
        '
        'StylizedButton3
        '
        Me.StylizedButton3.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton3.BackgroundImage = CType(resources.GetObject("StylizedButton3.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton3.FlatAppearance.BorderSize = 0
        Me.StylizedButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton3.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton3.Image = CType(resources.GetObject("StylizedButton3.Image"), System.Drawing.Image)
        Me.StylizedButton3.Location = New System.Drawing.Point(6, 6)
        Me.StylizedButton3.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton3.Name = "StylizedButton3"
        Me.StylizedButton3.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton3.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton3.Style = resources.GetString("StylizedButton3.Style")
        Me.StylizedButton3.TabIndex = 103
        Me.StylizedButton3.UseCompatibleTextRendering = True
        Me.StylizedButton3.UseVisualStyleBackColor = False
        '
        'StylizedButton4
        '
        Me.StylizedButton4.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton4.BackgroundImage = CType(resources.GetObject("StylizedButton4.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton4.FlatAppearance.BorderSize = 0
        Me.StylizedButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton4.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton4.Image = CType(resources.GetObject("StylizedButton4.Image"), System.Drawing.Image)
        Me.StylizedButton4.Location = New System.Drawing.Point(30, 6)
        Me.StylizedButton4.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton4.Name = "StylizedButton4"
        Me.StylizedButton4.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton4.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton4.Style = resources.GetString("StylizedButton4.Style")
        Me.StylizedButton4.TabIndex = 104
        Me.StylizedButton4.UseCompatibleTextRendering = True
        Me.StylizedButton4.UseVisualStyleBackColor = False
        '
        'StylizedButton5
        '
        Me.StylizedButton5.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton5.BackgroundImage = CType(resources.GetObject("StylizedButton5.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton5.FlatAppearance.BorderSize = 0
        Me.StylizedButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton5.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton5.Image = CType(resources.GetObject("StylizedButton5.Image"), System.Drawing.Image)
        Me.StylizedButton5.Location = New System.Drawing.Point(54, 6)
        Me.StylizedButton5.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton5.Name = "StylizedButton5"
        Me.StylizedButton5.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton5.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton5.Style = resources.GetString("StylizedButton5.Style")
        Me.StylizedButton5.TabIndex = 105
        Me.StylizedButton5.UseCompatibleTextRendering = True
        Me.StylizedButton5.UseVisualStyleBackColor = False
        '
        'StylizedButton6
        '
        Me.StylizedButton6.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton6.BackgroundImage = CType(resources.GetObject("StylizedButton6.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton6.FlatAppearance.BorderSize = 0
        Me.StylizedButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton6.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton6.Image = CType(resources.GetObject("StylizedButton6.Image"), System.Drawing.Image)
        Me.StylizedButton6.Location = New System.Drawing.Point(78, 6)
        Me.StylizedButton6.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton6.Name = "StylizedButton6"
        Me.StylizedButton6.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton6.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton6.Style = resources.GetString("StylizedButton6.Style")
        Me.StylizedButton6.TabIndex = 106
        Me.StylizedButton6.UseCompatibleTextRendering = True
        Me.StylizedButton6.UseVisualStyleBackColor = False
        '
        'StylizedButton7
        '
        Me.StylizedButton7.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton7.BackgroundImage = CType(resources.GetObject("StylizedButton7.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton7.FlatAppearance.BorderSize = 0
        Me.StylizedButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton7.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton7.Image = CType(resources.GetObject("StylizedButton7.Image"), System.Drawing.Image)
        Me.StylizedButton7.Location = New System.Drawing.Point(102, 6)
        Me.StylizedButton7.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton7.Name = "StylizedButton7"
        Me.StylizedButton7.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton7.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton7.Style = resources.GetString("StylizedButton7.Style")
        Me.StylizedButton7.TabIndex = 107
        Me.StylizedButton7.UseCompatibleTextRendering = True
        Me.StylizedButton7.UseVisualStyleBackColor = False
        '
        'StylizedButton8
        '
        Me.StylizedButton8.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton8.BackgroundImage = CType(resources.GetObject("StylizedButton8.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton8.FlatAppearance.BorderSize = 0
        Me.StylizedButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton8.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton8.Image = CType(resources.GetObject("StylizedButton8.Image"), System.Drawing.Image)
        Me.StylizedButton8.Location = New System.Drawing.Point(126, 6)
        Me.StylizedButton8.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton8.Name = "StylizedButton8"
        Me.StylizedButton8.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton8.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton8.Style = resources.GetString("StylizedButton8.Style")
        Me.StylizedButton8.TabIndex = 108
        Me.StylizedButton8.UseCompatibleTextRendering = True
        Me.StylizedButton8.UseVisualStyleBackColor = False
        '
        'StylizedButton9
        '
        Me.StylizedButton9.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton9.BackgroundImage = CType(resources.GetObject("StylizedButton9.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton9.FlatAppearance.BorderSize = 0
        Me.StylizedButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton9.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton9.Image = CType(resources.GetObject("StylizedButton9.Image"), System.Drawing.Image)
        Me.StylizedButton9.Location = New System.Drawing.Point(150, 6)
        Me.StylizedButton9.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton9.Name = "StylizedButton9"
        Me.StylizedButton9.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton9.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton9.Style = resources.GetString("StylizedButton9.Style")
        Me.StylizedButton9.TabIndex = 109
        Me.StylizedButton9.UseCompatibleTextRendering = True
        Me.StylizedButton9.UseVisualStyleBackColor = False
        '
        'StylizedButton10
        '
        Me.StylizedButton10.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton10.BackgroundImage = CType(resources.GetObject("StylizedButton10.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton10.FlatAppearance.BorderSize = 0
        Me.StylizedButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton10.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton10.Image = CType(resources.GetObject("StylizedButton10.Image"), System.Drawing.Image)
        Me.StylizedButton10.Location = New System.Drawing.Point(174, 6)
        Me.StylizedButton10.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton10.Name = "StylizedButton10"
        Me.StylizedButton10.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton10.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton10.Style = resources.GetString("StylizedButton10.Style")
        Me.StylizedButton10.TabIndex = 110
        Me.StylizedButton10.UseCompatibleTextRendering = True
        Me.StylizedButton10.UseVisualStyleBackColor = False
        '
        'StylizedButton11
        '
        Me.StylizedButton11.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton11.BackgroundImage = CType(resources.GetObject("StylizedButton11.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton11.FlatAppearance.BorderSize = 0
        Me.StylizedButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton11.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton11.Image = CType(resources.GetObject("StylizedButton11.Image"), System.Drawing.Image)
        Me.StylizedButton11.Location = New System.Drawing.Point(198, 6)
        Me.StylizedButton11.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton11.Name = "StylizedButton11"
        Me.StylizedButton11.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton11.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton11.Style = resources.GetString("StylizedButton11.Style")
        Me.StylizedButton11.TabIndex = 111
        Me.StylizedButton11.UseCompatibleTextRendering = True
        Me.StylizedButton11.UseVisualStyleBackColor = False
        '
        'StylizedButton12
        '
        Me.StylizedButton12.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton12.BackgroundImage = CType(resources.GetObject("StylizedButton12.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton12.FlatAppearance.BorderSize = 0
        Me.StylizedButton12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton12.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton12.Image = CType(resources.GetObject("StylizedButton12.Image"), System.Drawing.Image)
        Me.StylizedButton12.Location = New System.Drawing.Point(6, 30)
        Me.StylizedButton12.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton12.Name = "StylizedButton12"
        Me.StylizedButton12.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton12.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton12.Style = resources.GetString("StylizedButton12.Style")
        Me.StylizedButton12.TabIndex = 112
        Me.StylizedButton12.UseCompatibleTextRendering = True
        Me.StylizedButton12.UseVisualStyleBackColor = False
        '
        'StylizedButton13
        '
        Me.StylizedButton13.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton13.BackgroundImage = CType(resources.GetObject("StylizedButton13.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton13.FlatAppearance.BorderSize = 0
        Me.StylizedButton13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton13.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton13.Image = CType(resources.GetObject("StylizedButton13.Image"), System.Drawing.Image)
        Me.StylizedButton13.Location = New System.Drawing.Point(30, 30)
        Me.StylizedButton13.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton13.Name = "StylizedButton13"
        Me.StylizedButton13.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton13.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton13.Style = resources.GetString("StylizedButton13.Style")
        Me.StylizedButton13.TabIndex = 113
        Me.StylizedButton13.UseCompatibleTextRendering = True
        Me.StylizedButton13.UseVisualStyleBackColor = False
        '
        'StylizedButton14
        '
        Me.StylizedButton14.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton14.BackgroundImage = CType(resources.GetObject("StylizedButton14.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton14.FlatAppearance.BorderSize = 0
        Me.StylizedButton14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton14.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton14.Image = CType(resources.GetObject("StylizedButton14.Image"), System.Drawing.Image)
        Me.StylizedButton14.Location = New System.Drawing.Point(54, 30)
        Me.StylizedButton14.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton14.Name = "StylizedButton14"
        Me.StylizedButton14.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton14.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton14.Style = resources.GetString("StylizedButton14.Style")
        Me.StylizedButton14.TabIndex = 114
        Me.StylizedButton14.UseCompatibleTextRendering = True
        Me.StylizedButton14.UseVisualStyleBackColor = False
        '
        'StylizedButton15
        '
        Me.StylizedButton15.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton15.BackgroundImage = CType(resources.GetObject("StylizedButton15.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton15.FlatAppearance.BorderSize = 0
        Me.StylizedButton15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton15.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton15.Image = CType(resources.GetObject("StylizedButton15.Image"), System.Drawing.Image)
        Me.StylizedButton15.Location = New System.Drawing.Point(78, 30)
        Me.StylizedButton15.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton15.Name = "StylizedButton15"
        Me.StylizedButton15.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton15.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton15.Style = resources.GetString("StylizedButton15.Style")
        Me.StylizedButton15.TabIndex = 115
        Me.StylizedButton15.UseCompatibleTextRendering = True
        Me.StylizedButton15.UseVisualStyleBackColor = False
        '
        'StylizedButton16
        '
        Me.StylizedButton16.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton16.BackgroundImage = CType(resources.GetObject("StylizedButton16.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton16.FlatAppearance.BorderSize = 0
        Me.StylizedButton16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton16.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton16.Image = CType(resources.GetObject("StylizedButton16.Image"), System.Drawing.Image)
        Me.StylizedButton16.Location = New System.Drawing.Point(102, 30)
        Me.StylizedButton16.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton16.Name = "StylizedButton16"
        Me.StylizedButton16.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton16.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton16.Style = resources.GetString("StylizedButton16.Style")
        Me.StylizedButton16.TabIndex = 116
        Me.StylizedButton16.UseCompatibleTextRendering = True
        Me.StylizedButton16.UseVisualStyleBackColor = False
        '
        'StylizedButton17
        '
        Me.StylizedButton17.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton17.BackgroundImage = CType(resources.GetObject("StylizedButton17.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton17.FlatAppearance.BorderSize = 0
        Me.StylizedButton17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton17.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton17.Image = CType(resources.GetObject("StylizedButton17.Image"), System.Drawing.Image)
        Me.StylizedButton17.Location = New System.Drawing.Point(126, 30)
        Me.StylizedButton17.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton17.Name = "StylizedButton17"
        Me.StylizedButton17.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton17.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton17.Style = resources.GetString("StylizedButton17.Style")
        Me.StylizedButton17.TabIndex = 117
        Me.StylizedButton17.UseCompatibleTextRendering = True
        Me.StylizedButton17.UseVisualStyleBackColor = False
        '
        'StylizedButton18
        '
        Me.StylizedButton18.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton18.BackgroundImage = CType(resources.GetObject("StylizedButton18.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton18.FlatAppearance.BorderSize = 0
        Me.StylizedButton18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton18.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton18.Image = CType(resources.GetObject("StylizedButton18.Image"), System.Drawing.Image)
        Me.StylizedButton18.Location = New System.Drawing.Point(150, 30)
        Me.StylizedButton18.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton18.Name = "StylizedButton18"
        Me.StylizedButton18.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton18.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton18.Style = resources.GetString("StylizedButton18.Style")
        Me.StylizedButton18.TabIndex = 118
        Me.StylizedButton18.UseCompatibleTextRendering = True
        Me.StylizedButton18.UseVisualStyleBackColor = False
        '
        'StylizedButton19
        '
        Me.StylizedButton19.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton19.BackgroundImage = CType(resources.GetObject("StylizedButton19.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton19.FlatAppearance.BorderSize = 0
        Me.StylizedButton19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton19.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton19.Image = CType(resources.GetObject("StylizedButton19.Image"), System.Drawing.Image)
        Me.StylizedButton19.Location = New System.Drawing.Point(174, 30)
        Me.StylizedButton19.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton19.Name = "StylizedButton19"
        Me.StylizedButton19.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton19.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton19.Style = resources.GetString("StylizedButton19.Style")
        Me.StylizedButton19.TabIndex = 119
        Me.StylizedButton19.UseCompatibleTextRendering = True
        Me.StylizedButton19.UseVisualStyleBackColor = False
        '
        'StylizedButton20
        '
        Me.StylizedButton20.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton20.BackgroundImage = CType(resources.GetObject("StylizedButton20.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton20.FlatAppearance.BorderSize = 0
        Me.StylizedButton20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton20.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton20.Image = CType(resources.GetObject("StylizedButton20.Image"), System.Drawing.Image)
        Me.StylizedButton20.Location = New System.Drawing.Point(198, 30)
        Me.StylizedButton20.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton20.Name = "StylizedButton20"
        Me.StylizedButton20.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton20.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton20.Style = resources.GetString("StylizedButton20.Style")
        Me.StylizedButton20.TabIndex = 120
        Me.StylizedButton20.UseCompatibleTextRendering = True
        Me.StylizedButton20.UseVisualStyleBackColor = False
        '
        'StylizedButton21
        '
        Me.StylizedButton21.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton21.BackgroundImage = CType(resources.GetObject("StylizedButton21.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton21.FlatAppearance.BorderSize = 0
        Me.StylizedButton21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton21.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton21.Image = CType(resources.GetObject("StylizedButton21.Image"), System.Drawing.Image)
        Me.StylizedButton21.Location = New System.Drawing.Point(6, 54)
        Me.StylizedButton21.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton21.Name = "StylizedButton21"
        Me.StylizedButton21.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton21.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton21.Style = resources.GetString("StylizedButton21.Style")
        Me.StylizedButton21.TabIndex = 121
        Me.StylizedButton21.UseCompatibleTextRendering = True
        Me.StylizedButton21.UseVisualStyleBackColor = False
        '
        'StylizedButton22
        '
        Me.StylizedButton22.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton22.BackgroundImage = CType(resources.GetObject("StylizedButton22.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton22.FlatAppearance.BorderSize = 0
        Me.StylizedButton22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton22.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton22.Image = CType(resources.GetObject("StylizedButton22.Image"), System.Drawing.Image)
        Me.StylizedButton22.Location = New System.Drawing.Point(30, 54)
        Me.StylizedButton22.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton22.Name = "StylizedButton22"
        Me.StylizedButton22.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton22.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton22.Style = resources.GetString("StylizedButton22.Style")
        Me.StylizedButton22.TabIndex = 122
        Me.StylizedButton22.UseCompatibleTextRendering = True
        Me.StylizedButton22.UseVisualStyleBackColor = False
        '
        'StylizedButton23
        '
        Me.StylizedButton23.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton23.BackgroundImage = CType(resources.GetObject("StylizedButton23.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton23.FlatAppearance.BorderSize = 0
        Me.StylizedButton23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton23.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton23.Image = CType(resources.GetObject("StylizedButton23.Image"), System.Drawing.Image)
        Me.StylizedButton23.Location = New System.Drawing.Point(54, 54)
        Me.StylizedButton23.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton23.Name = "StylizedButton23"
        Me.StylizedButton23.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton23.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton23.Style = resources.GetString("StylizedButton23.Style")
        Me.StylizedButton23.TabIndex = 123
        Me.StylizedButton23.UseCompatibleTextRendering = True
        Me.StylizedButton23.UseVisualStyleBackColor = False
        '
        'StylizedButton24
        '
        Me.StylizedButton24.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton24.BackgroundImage = CType(resources.GetObject("StylizedButton24.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton24.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton24.FlatAppearance.BorderSize = 0
        Me.StylizedButton24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton24.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton24.Image = CType(resources.GetObject("StylizedButton24.Image"), System.Drawing.Image)
        Me.StylizedButton24.Location = New System.Drawing.Point(78, 54)
        Me.StylizedButton24.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton24.Name = "StylizedButton24"
        Me.StylizedButton24.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton24.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton24.Style = resources.GetString("StylizedButton24.Style")
        Me.StylizedButton24.TabIndex = 124
        Me.StylizedButton24.UseCompatibleTextRendering = True
        Me.StylizedButton24.UseVisualStyleBackColor = False
        '
        'StylizedButton25
        '
        Me.StylizedButton25.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton25.BackgroundImage = CType(resources.GetObject("StylizedButton25.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton25.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton25.FlatAppearance.BorderSize = 0
        Me.StylizedButton25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton25.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton25.Image = CType(resources.GetObject("StylizedButton25.Image"), System.Drawing.Image)
        Me.StylizedButton25.Location = New System.Drawing.Point(102, 54)
        Me.StylizedButton25.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton25.Name = "StylizedButton25"
        Me.StylizedButton25.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton25.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton25.Style = resources.GetString("StylizedButton25.Style")
        Me.StylizedButton25.TabIndex = 125
        Me.StylizedButton25.UseCompatibleTextRendering = True
        Me.StylizedButton25.UseVisualStyleBackColor = False
        '
        'StylizedButton26
        '
        Me.StylizedButton26.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton26.BackgroundImage = CType(resources.GetObject("StylizedButton26.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton26.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton26.FlatAppearance.BorderSize = 0
        Me.StylizedButton26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton26.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton26.Image = CType(resources.GetObject("StylizedButton26.Image"), System.Drawing.Image)
        Me.StylizedButton26.Location = New System.Drawing.Point(126, 54)
        Me.StylizedButton26.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton26.Name = "StylizedButton26"
        Me.StylizedButton26.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton26.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton26.Style = resources.GetString("StylizedButton26.Style")
        Me.StylizedButton26.TabIndex = 126
        Me.StylizedButton26.UseCompatibleTextRendering = True
        Me.StylizedButton26.UseVisualStyleBackColor = False
        '
        'StylizedButton27
        '
        Me.StylizedButton27.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton27.BackgroundImage = CType(resources.GetObject("StylizedButton27.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton27.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton27.FlatAppearance.BorderSize = 0
        Me.StylizedButton27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton27.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton27.Image = CType(resources.GetObject("StylizedButton27.Image"), System.Drawing.Image)
        Me.StylizedButton27.Location = New System.Drawing.Point(150, 54)
        Me.StylizedButton27.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton27.Name = "StylizedButton27"
        Me.StylizedButton27.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton27.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton27.Style = resources.GetString("StylizedButton27.Style")
        Me.StylizedButton27.TabIndex = 127
        Me.StylizedButton27.UseCompatibleTextRendering = True
        Me.StylizedButton27.UseVisualStyleBackColor = False
        '
        'StylizedButton28
        '
        Me.StylizedButton28.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton28.BackgroundImage = CType(resources.GetObject("StylizedButton28.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton28.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton28.FlatAppearance.BorderSize = 0
        Me.StylizedButton28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton28.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton28.Image = CType(resources.GetObject("StylizedButton28.Image"), System.Drawing.Image)
        Me.StylizedButton28.Location = New System.Drawing.Point(174, 54)
        Me.StylizedButton28.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton28.Name = "StylizedButton28"
        Me.StylizedButton28.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton28.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton28.Style = resources.GetString("StylizedButton28.Style")
        Me.StylizedButton28.TabIndex = 128
        Me.StylizedButton28.UseCompatibleTextRendering = True
        Me.StylizedButton28.UseVisualStyleBackColor = False
        '
        'StylizedButton29
        '
        Me.StylizedButton29.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton29.BackgroundImage = CType(resources.GetObject("StylizedButton29.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton29.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton29.FlatAppearance.BorderSize = 0
        Me.StylizedButton29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton29.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton29.Image = CType(resources.GetObject("StylizedButton29.Image"), System.Drawing.Image)
        Me.StylizedButton29.Location = New System.Drawing.Point(198, 54)
        Me.StylizedButton29.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton29.Name = "StylizedButton29"
        Me.StylizedButton29.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton29.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton29.Style = resources.GetString("StylizedButton29.Style")
        Me.StylizedButton29.TabIndex = 129
        Me.StylizedButton29.UseCompatibleTextRendering = True
        Me.StylizedButton29.UseVisualStyleBackColor = False
        '
        'StylizedButton30
        '
        Me.StylizedButton30.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton30.BackgroundImage = CType(resources.GetObject("StylizedButton30.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton30.FlatAppearance.BorderSize = 0
        Me.StylizedButton30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton30.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton30.Image = CType(resources.GetObject("StylizedButton30.Image"), System.Drawing.Image)
        Me.StylizedButton30.Location = New System.Drawing.Point(6, 78)
        Me.StylizedButton30.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton30.Name = "StylizedButton30"
        Me.StylizedButton30.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton30.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton30.Style = resources.GetString("StylizedButton30.Style")
        Me.StylizedButton30.TabIndex = 130
        Me.StylizedButton30.UseCompatibleTextRendering = True
        Me.StylizedButton30.UseVisualStyleBackColor = False
        '
        'StylizedButton31
        '
        Me.StylizedButton31.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton31.BackgroundImage = CType(resources.GetObject("StylizedButton31.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton31.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton31.FlatAppearance.BorderSize = 0
        Me.StylizedButton31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton31.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton31.Image = CType(resources.GetObject("StylizedButton31.Image"), System.Drawing.Image)
        Me.StylizedButton31.Location = New System.Drawing.Point(30, 78)
        Me.StylizedButton31.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton31.Name = "StylizedButton31"
        Me.StylizedButton31.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton31.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton31.Style = resources.GetString("StylizedButton31.Style")
        Me.StylizedButton31.TabIndex = 131
        Me.StylizedButton31.UseCompatibleTextRendering = True
        Me.StylizedButton31.UseVisualStyleBackColor = False
        '
        'StylizedButton32
        '
        Me.StylizedButton32.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton32.BackgroundImage = CType(resources.GetObject("StylizedButton32.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton32.FlatAppearance.BorderSize = 0
        Me.StylizedButton32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton32.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton32.Image = CType(resources.GetObject("StylizedButton32.Image"), System.Drawing.Image)
        Me.StylizedButton32.Location = New System.Drawing.Point(54, 78)
        Me.StylizedButton32.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton32.Name = "StylizedButton32"
        Me.StylizedButton32.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton32.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton32.Style = resources.GetString("StylizedButton32.Style")
        Me.StylizedButton32.TabIndex = 132
        Me.StylizedButton32.UseCompatibleTextRendering = True
        Me.StylizedButton32.UseVisualStyleBackColor = False
        '
        'StylizedButton33
        '
        Me.StylizedButton33.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton33.BackgroundImage = CType(resources.GetObject("StylizedButton33.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton33.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton33.FlatAppearance.BorderSize = 0
        Me.StylizedButton33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton33.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton33.Image = CType(resources.GetObject("StylizedButton33.Image"), System.Drawing.Image)
        Me.StylizedButton33.Location = New System.Drawing.Point(78, 78)
        Me.StylizedButton33.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton33.Name = "StylizedButton33"
        Me.StylizedButton33.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton33.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton33.Style = resources.GetString("StylizedButton33.Style")
        Me.StylizedButton33.TabIndex = 133
        Me.StylizedButton33.UseCompatibleTextRendering = True
        Me.StylizedButton33.UseVisualStyleBackColor = False
        '
        'StylizedButton34
        '
        Me.StylizedButton34.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton34.BackgroundImage = CType(resources.GetObject("StylizedButton34.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton34.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton34.FlatAppearance.BorderSize = 0
        Me.StylizedButton34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton34.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton34.Image = CType(resources.GetObject("StylizedButton34.Image"), System.Drawing.Image)
        Me.StylizedButton34.Location = New System.Drawing.Point(102, 78)
        Me.StylizedButton34.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton34.Name = "StylizedButton34"
        Me.StylizedButton34.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton34.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton34.Style = resources.GetString("StylizedButton34.Style")
        Me.StylizedButton34.TabIndex = 134
        Me.StylizedButton34.UseCompatibleTextRendering = True
        Me.StylizedButton34.UseVisualStyleBackColor = False
        '
        'StylizedButton35
        '
        Me.StylizedButton35.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton35.BackgroundImage = CType(resources.GetObject("StylizedButton35.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton35.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton35.FlatAppearance.BorderSize = 0
        Me.StylizedButton35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton35.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton35.Image = CType(resources.GetObject("StylizedButton35.Image"), System.Drawing.Image)
        Me.StylizedButton35.Location = New System.Drawing.Point(126, 78)
        Me.StylizedButton35.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton35.Name = "StylizedButton35"
        Me.StylizedButton35.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton35.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton35.Style = resources.GetString("StylizedButton35.Style")
        Me.StylizedButton35.TabIndex = 135
        Me.StylizedButton35.UseCompatibleTextRendering = True
        Me.StylizedButton35.UseVisualStyleBackColor = False
        '
        'StylizedButton36
        '
        Me.StylizedButton36.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton36.BackgroundImage = CType(resources.GetObject("StylizedButton36.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton36.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton36.FlatAppearance.BorderSize = 0
        Me.StylizedButton36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton36.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton36.Image = CType(resources.GetObject("StylizedButton36.Image"), System.Drawing.Image)
        Me.StylizedButton36.Location = New System.Drawing.Point(150, 78)
        Me.StylizedButton36.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton36.Name = "StylizedButton36"
        Me.StylizedButton36.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton36.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton36.Style = resources.GetString("StylizedButton36.Style")
        Me.StylizedButton36.TabIndex = 136
        Me.StylizedButton36.UseCompatibleTextRendering = True
        Me.StylizedButton36.UseVisualStyleBackColor = False
        '
        'StylizedButton37
        '
        Me.StylizedButton37.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton37.BackgroundImage = CType(resources.GetObject("StylizedButton37.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton37.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton37.FlatAppearance.BorderSize = 0
        Me.StylizedButton37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton37.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton37.Image = CType(resources.GetObject("StylizedButton37.Image"), System.Drawing.Image)
        Me.StylizedButton37.Location = New System.Drawing.Point(174, 78)
        Me.StylizedButton37.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton37.Name = "StylizedButton37"
        Me.StylizedButton37.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton37.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton37.Style = resources.GetString("StylizedButton37.Style")
        Me.StylizedButton37.TabIndex = 137
        Me.StylizedButton37.UseCompatibleTextRendering = True
        Me.StylizedButton37.UseVisualStyleBackColor = False
        '
        'StylizedButton38
        '
        Me.StylizedButton38.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton38.BackgroundImage = CType(resources.GetObject("StylizedButton38.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton38.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton38.FlatAppearance.BorderSize = 0
        Me.StylizedButton38.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton38.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton38.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton38.Image = CType(resources.GetObject("StylizedButton38.Image"), System.Drawing.Image)
        Me.StylizedButton38.Location = New System.Drawing.Point(198, 78)
        Me.StylizedButton38.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton38.Name = "StylizedButton38"
        Me.StylizedButton38.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton38.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton38.Style = resources.GetString("StylizedButton38.Style")
        Me.StylizedButton38.TabIndex = 138
        Me.StylizedButton38.UseCompatibleTextRendering = True
        Me.StylizedButton38.UseVisualStyleBackColor = False
        '
        'StylizedButton39
        '
        Me.StylizedButton39.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton39.BackgroundImage = CType(resources.GetObject("StylizedButton39.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton39.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton39.FlatAppearance.BorderSize = 0
        Me.StylizedButton39.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton39.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton39.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton39.Image = CType(resources.GetObject("StylizedButton39.Image"), System.Drawing.Image)
        Me.StylizedButton39.Location = New System.Drawing.Point(6, 102)
        Me.StylizedButton39.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton39.Name = "StylizedButton39"
        Me.StylizedButton39.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton39.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton39.Style = resources.GetString("StylizedButton39.Style")
        Me.StylizedButton39.TabIndex = 139
        Me.StylizedButton39.UseCompatibleTextRendering = True
        Me.StylizedButton39.UseVisualStyleBackColor = False
        '
        'StylizedButton40
        '
        Me.StylizedButton40.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton40.BackgroundImage = CType(resources.GetObject("StylizedButton40.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton40.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton40.FlatAppearance.BorderSize = 0
        Me.StylizedButton40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton40.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton40.Image = CType(resources.GetObject("StylizedButton40.Image"), System.Drawing.Image)
        Me.StylizedButton40.Location = New System.Drawing.Point(30, 102)
        Me.StylizedButton40.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton40.Name = "StylizedButton40"
        Me.StylizedButton40.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton40.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton40.Style = resources.GetString("StylizedButton40.Style")
        Me.StylizedButton40.TabIndex = 140
        Me.StylizedButton40.UseCompatibleTextRendering = True
        Me.StylizedButton40.UseVisualStyleBackColor = False
        '
        'StylizedButton41
        '
        Me.StylizedButton41.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton41.BackgroundImage = CType(resources.GetObject("StylizedButton41.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton41.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton41.FlatAppearance.BorderSize = 0
        Me.StylizedButton41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton41.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton41.Image = CType(resources.GetObject("StylizedButton41.Image"), System.Drawing.Image)
        Me.StylizedButton41.Location = New System.Drawing.Point(54, 102)
        Me.StylizedButton41.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton41.Name = "StylizedButton41"
        Me.StylizedButton41.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton41.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton41.Style = resources.GetString("StylizedButton41.Style")
        Me.StylizedButton41.TabIndex = 141
        Me.StylizedButton41.UseCompatibleTextRendering = True
        Me.StylizedButton41.UseVisualStyleBackColor = False
        '
        'StylizedButton93
        '
        Me.StylizedButton93.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton93.BackgroundImage = CType(resources.GetObject("StylizedButton93.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton93.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton93.FlatAppearance.BorderSize = 0
        Me.StylizedButton93.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton93.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton93.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton93.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton93.Image = CType(resources.GetObject("StylizedButton93.Image"), System.Drawing.Image)
        Me.StylizedButton93.Location = New System.Drawing.Point(78, 102)
        Me.StylizedButton93.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton93.Name = "StylizedButton93"
        Me.StylizedButton93.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton93.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton93.Style = resources.GetString("StylizedButton93.Style")
        Me.StylizedButton93.TabIndex = 193
        Me.StylizedButton93.UseCompatibleTextRendering = True
        Me.StylizedButton93.UseVisualStyleBackColor = False
        '
        'StylizedButton42
        '
        Me.StylizedButton42.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton42.BackgroundImage = CType(resources.GetObject("StylizedButton42.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton42.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton42.FlatAppearance.BorderSize = 0
        Me.StylizedButton42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton42.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton42.Image = CType(resources.GetObject("StylizedButton42.Image"), System.Drawing.Image)
        Me.StylizedButton42.Location = New System.Drawing.Point(102, 102)
        Me.StylizedButton42.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton42.Name = "StylizedButton42"
        Me.StylizedButton42.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton42.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton42.Style = resources.GetString("StylizedButton42.Style")
        Me.StylizedButton42.TabIndex = 142
        Me.StylizedButton42.UseCompatibleTextRendering = True
        Me.StylizedButton42.UseVisualStyleBackColor = False
        '
        'StylizedButton43
        '
        Me.StylizedButton43.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton43.BackgroundImage = CType(resources.GetObject("StylizedButton43.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton43.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton43.FlatAppearance.BorderSize = 0
        Me.StylizedButton43.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton43.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton43.Image = CType(resources.GetObject("StylizedButton43.Image"), System.Drawing.Image)
        Me.StylizedButton43.Location = New System.Drawing.Point(126, 102)
        Me.StylizedButton43.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton43.Name = "StylizedButton43"
        Me.StylizedButton43.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton43.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton43.Style = resources.GetString("StylizedButton43.Style")
        Me.StylizedButton43.TabIndex = 143
        Me.StylizedButton43.UseCompatibleTextRendering = True
        Me.StylizedButton43.UseVisualStyleBackColor = False
        '
        'StylizedButton44
        '
        Me.StylizedButton44.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton44.BackgroundImage = CType(resources.GetObject("StylizedButton44.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton44.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton44.FlatAppearance.BorderSize = 0
        Me.StylizedButton44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton44.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton44.Image = CType(resources.GetObject("StylizedButton44.Image"), System.Drawing.Image)
        Me.StylizedButton44.Location = New System.Drawing.Point(150, 102)
        Me.StylizedButton44.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton44.Name = "StylizedButton44"
        Me.StylizedButton44.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton44.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton44.Style = resources.GetString("StylizedButton44.Style")
        Me.StylizedButton44.TabIndex = 144
        Me.StylizedButton44.UseCompatibleTextRendering = True
        Me.StylizedButton44.UseVisualStyleBackColor = False
        '
        'StylizedButton45
        '
        Me.StylizedButton45.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton45.BackgroundImage = CType(resources.GetObject("StylizedButton45.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton45.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton45.FlatAppearance.BorderSize = 0
        Me.StylizedButton45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton45.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton45.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton45.Image = CType(resources.GetObject("StylizedButton45.Image"), System.Drawing.Image)
        Me.StylizedButton45.Location = New System.Drawing.Point(174, 102)
        Me.StylizedButton45.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton45.Name = "StylizedButton45"
        Me.StylizedButton45.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton45.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton45.Style = resources.GetString("StylizedButton45.Style")
        Me.StylizedButton45.TabIndex = 145
        Me.StylizedButton45.UseCompatibleTextRendering = True
        Me.StylizedButton45.UseVisualStyleBackColor = False
        '
        'StylizedButton46
        '
        Me.StylizedButton46.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton46.BackgroundImage = CType(resources.GetObject("StylizedButton46.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton46.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton46.FlatAppearance.BorderSize = 0
        Me.StylizedButton46.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton46.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton46.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton46.Image = CType(resources.GetObject("StylizedButton46.Image"), System.Drawing.Image)
        Me.StylizedButton46.Location = New System.Drawing.Point(198, 102)
        Me.StylizedButton46.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton46.Name = "StylizedButton46"
        Me.StylizedButton46.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton46.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton46.Style = resources.GetString("StylizedButton46.Style")
        Me.StylizedButton46.TabIndex = 146
        Me.StylizedButton46.UseCompatibleTextRendering = True
        Me.StylizedButton46.UseVisualStyleBackColor = False
        '
        'StylizedButton47
        '
        Me.StylizedButton47.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton47.BackgroundImage = CType(resources.GetObject("StylizedButton47.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton47.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton47.FlatAppearance.BorderSize = 0
        Me.StylizedButton47.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton47.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton47.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton47.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton47.Image = CType(resources.GetObject("StylizedButton47.Image"), System.Drawing.Image)
        Me.StylizedButton47.Location = New System.Drawing.Point(6, 126)
        Me.StylizedButton47.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton47.Name = "StylizedButton47"
        Me.StylizedButton47.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton47.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton47.Style = resources.GetString("StylizedButton47.Style")
        Me.StylizedButton47.TabIndex = 147
        Me.StylizedButton47.UseCompatibleTextRendering = True
        Me.StylizedButton47.UseVisualStyleBackColor = False
        '
        'StylizedButton48
        '
        Me.StylizedButton48.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton48.BackgroundImage = CType(resources.GetObject("StylizedButton48.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton48.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton48.FlatAppearance.BorderSize = 0
        Me.StylizedButton48.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton48.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton48.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton48.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton48.Image = CType(resources.GetObject("StylizedButton48.Image"), System.Drawing.Image)
        Me.StylizedButton48.Location = New System.Drawing.Point(30, 126)
        Me.StylizedButton48.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton48.Name = "StylizedButton48"
        Me.StylizedButton48.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton48.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton48.Style = resources.GetString("StylizedButton48.Style")
        Me.StylizedButton48.TabIndex = 148
        Me.StylizedButton48.UseCompatibleTextRendering = True
        Me.StylizedButton48.UseVisualStyleBackColor = False
        '
        'StylizedButton49
        '
        Me.StylizedButton49.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton49.BackgroundImage = CType(resources.GetObject("StylizedButton49.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton49.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton49.FlatAppearance.BorderSize = 0
        Me.StylizedButton49.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton49.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton49.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton49.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton49.Image = CType(resources.GetObject("StylizedButton49.Image"), System.Drawing.Image)
        Me.StylizedButton49.Location = New System.Drawing.Point(54, 126)
        Me.StylizedButton49.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton49.Name = "StylizedButton49"
        Me.StylizedButton49.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton49.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton49.Style = resources.GetString("StylizedButton49.Style")
        Me.StylizedButton49.TabIndex = 149
        Me.StylizedButton49.UseCompatibleTextRendering = True
        Me.StylizedButton49.UseVisualStyleBackColor = False
        '
        'StylizedButton50
        '
        Me.StylizedButton50.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton50.BackgroundImage = CType(resources.GetObject("StylizedButton50.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton50.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton50.FlatAppearance.BorderSize = 0
        Me.StylizedButton50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton50.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton50.Image = CType(resources.GetObject("StylizedButton50.Image"), System.Drawing.Image)
        Me.StylizedButton50.Location = New System.Drawing.Point(78, 126)
        Me.StylizedButton50.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton50.Name = "StylizedButton50"
        Me.StylizedButton50.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton50.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton50.Style = resources.GetString("StylizedButton50.Style")
        Me.StylizedButton50.TabIndex = 150
        Me.StylizedButton50.UseCompatibleTextRendering = True
        Me.StylizedButton50.UseVisualStyleBackColor = False
        '
        'StylizedButton51
        '
        Me.StylizedButton51.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton51.BackgroundImage = CType(resources.GetObject("StylizedButton51.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton51.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton51.FlatAppearance.BorderSize = 0
        Me.StylizedButton51.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton51.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton51.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton51.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton51.Image = CType(resources.GetObject("StylizedButton51.Image"), System.Drawing.Image)
        Me.StylizedButton51.Location = New System.Drawing.Point(102, 126)
        Me.StylizedButton51.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton51.Name = "StylizedButton51"
        Me.StylizedButton51.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton51.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton51.Style = resources.GetString("StylizedButton51.Style")
        Me.StylizedButton51.TabIndex = 151
        Me.StylizedButton51.UseCompatibleTextRendering = True
        Me.StylizedButton51.UseVisualStyleBackColor = False
        '
        'StylizedButton52
        '
        Me.StylizedButton52.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton52.BackgroundImage = CType(resources.GetObject("StylizedButton52.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton52.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton52.FlatAppearance.BorderSize = 0
        Me.StylizedButton52.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton52.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton52.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton52.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton52.Image = CType(resources.GetObject("StylizedButton52.Image"), System.Drawing.Image)
        Me.StylizedButton52.Location = New System.Drawing.Point(126, 126)
        Me.StylizedButton52.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton52.Name = "StylizedButton52"
        Me.StylizedButton52.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton52.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton52.Style = resources.GetString("StylizedButton52.Style")
        Me.StylizedButton52.TabIndex = 152
        Me.StylizedButton52.UseCompatibleTextRendering = True
        Me.StylizedButton52.UseVisualStyleBackColor = False
        '
        'StylizedButton53
        '
        Me.StylizedButton53.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton53.BackgroundImage = CType(resources.GetObject("StylizedButton53.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton53.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton53.FlatAppearance.BorderSize = 0
        Me.StylizedButton53.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton53.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton53.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton53.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton53.Image = CType(resources.GetObject("StylizedButton53.Image"), System.Drawing.Image)
        Me.StylizedButton53.Location = New System.Drawing.Point(150, 126)
        Me.StylizedButton53.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton53.Name = "StylizedButton53"
        Me.StylizedButton53.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton53.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton53.Style = resources.GetString("StylizedButton53.Style")
        Me.StylizedButton53.TabIndex = 153
        Me.StylizedButton53.UseCompatibleTextRendering = True
        Me.StylizedButton53.UseVisualStyleBackColor = False
        '
        'StylizedButton88
        '
        Me.StylizedButton88.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton88.BackgroundImage = CType(resources.GetObject("StylizedButton88.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton88.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton88.FlatAppearance.BorderSize = 0
        Me.StylizedButton88.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton88.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton88.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton88.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton88.Image = CType(resources.GetObject("StylizedButton88.Image"), System.Drawing.Image)
        Me.StylizedButton88.Location = New System.Drawing.Point(174, 126)
        Me.StylizedButton88.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton88.Name = "StylizedButton88"
        Me.StylizedButton88.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton88.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton88.Style = resources.GetString("StylizedButton88.Style")
        Me.StylizedButton88.TabIndex = 188
        Me.StylizedButton88.UseCompatibleTextRendering = True
        Me.StylizedButton88.UseVisualStyleBackColor = False
        '
        'StylizedButton54
        '
        Me.StylizedButton54.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton54.BackgroundImage = CType(resources.GetObject("StylizedButton54.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton54.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton54.FlatAppearance.BorderSize = 0
        Me.StylizedButton54.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton54.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton54.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton54.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton54.Image = CType(resources.GetObject("StylizedButton54.Image"), System.Drawing.Image)
        Me.StylizedButton54.Location = New System.Drawing.Point(198, 126)
        Me.StylizedButton54.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton54.Name = "StylizedButton54"
        Me.StylizedButton54.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton54.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton54.Style = resources.GetString("StylizedButton54.Style")
        Me.StylizedButton54.TabIndex = 154
        Me.StylizedButton54.UseCompatibleTextRendering = True
        Me.StylizedButton54.UseVisualStyleBackColor = False
        '
        'StylizedButton55
        '
        Me.StylizedButton55.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton55.BackgroundImage = CType(resources.GetObject("StylizedButton55.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton55.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton55.FlatAppearance.BorderSize = 0
        Me.StylizedButton55.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton55.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton55.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton55.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton55.Image = CType(resources.GetObject("StylizedButton55.Image"), System.Drawing.Image)
        Me.StylizedButton55.Location = New System.Drawing.Point(6, 150)
        Me.StylizedButton55.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton55.Name = "StylizedButton55"
        Me.StylizedButton55.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton55.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton55.Style = resources.GetString("StylizedButton55.Style")
        Me.StylizedButton55.TabIndex = 155
        Me.StylizedButton55.UseCompatibleTextRendering = True
        Me.StylizedButton55.UseVisualStyleBackColor = False
        '
        'StylizedButton56
        '
        Me.StylizedButton56.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton56.BackgroundImage = CType(resources.GetObject("StylizedButton56.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton56.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton56.FlatAppearance.BorderSize = 0
        Me.StylizedButton56.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton56.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton56.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton56.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton56.Image = CType(resources.GetObject("StylizedButton56.Image"), System.Drawing.Image)
        Me.StylizedButton56.Location = New System.Drawing.Point(30, 150)
        Me.StylizedButton56.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton56.Name = "StylizedButton56"
        Me.StylizedButton56.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton56.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton56.Style = resources.GetString("StylizedButton56.Style")
        Me.StylizedButton56.TabIndex = 156
        Me.StylizedButton56.UseCompatibleTextRendering = True
        Me.StylizedButton56.UseVisualStyleBackColor = False
        '
        'StylizedButton57
        '
        Me.StylizedButton57.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton57.BackgroundImage = CType(resources.GetObject("StylizedButton57.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton57.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton57.FlatAppearance.BorderSize = 0
        Me.StylizedButton57.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton57.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton57.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton57.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton57.Image = CType(resources.GetObject("StylizedButton57.Image"), System.Drawing.Image)
        Me.StylizedButton57.Location = New System.Drawing.Point(54, 150)
        Me.StylizedButton57.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton57.Name = "StylizedButton57"
        Me.StylizedButton57.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton57.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton57.Style = resources.GetString("StylizedButton57.Style")
        Me.StylizedButton57.TabIndex = 157
        Me.StylizedButton57.UseCompatibleTextRendering = True
        Me.StylizedButton57.UseVisualStyleBackColor = False
        '
        'StylizedButton58
        '
        Me.StylizedButton58.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton58.BackgroundImage = CType(resources.GetObject("StylizedButton58.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton58.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton58.FlatAppearance.BorderSize = 0
        Me.StylizedButton58.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton58.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton58.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton58.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton58.Image = CType(resources.GetObject("StylizedButton58.Image"), System.Drawing.Image)
        Me.StylizedButton58.Location = New System.Drawing.Point(78, 150)
        Me.StylizedButton58.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton58.Name = "StylizedButton58"
        Me.StylizedButton58.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton58.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton58.Style = resources.GetString("StylizedButton58.Style")
        Me.StylizedButton58.TabIndex = 158
        Me.StylizedButton58.UseCompatibleTextRendering = True
        Me.StylizedButton58.UseVisualStyleBackColor = False
        '
        'StylizedButton90
        '
        Me.StylizedButton90.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton90.BackgroundImage = CType(resources.GetObject("StylizedButton90.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton90.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton90.FlatAppearance.BorderSize = 0
        Me.StylizedButton90.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton90.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton90.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton90.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton90.Image = CType(resources.GetObject("StylizedButton90.Image"), System.Drawing.Image)
        Me.StylizedButton90.Location = New System.Drawing.Point(102, 150)
        Me.StylizedButton90.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton90.Name = "StylizedButton90"
        Me.StylizedButton90.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton90.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton90.Style = resources.GetString("StylizedButton90.Style")
        Me.StylizedButton90.TabIndex = 190
        Me.StylizedButton90.UseCompatibleTextRendering = True
        Me.StylizedButton90.UseVisualStyleBackColor = False
        '
        'StylizedButton65
        '
        Me.StylizedButton65.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton65.BackgroundImage = CType(resources.GetObject("StylizedButton65.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton65.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton65.FlatAppearance.BorderSize = 0
        Me.StylizedButton65.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton65.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton65.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton65.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton65.Image = CType(resources.GetObject("StylizedButton65.Image"), System.Drawing.Image)
        Me.StylizedButton65.Location = New System.Drawing.Point(126, 150)
        Me.StylizedButton65.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton65.Name = "StylizedButton65"
        Me.StylizedButton65.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton65.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton65.Style = resources.GetString("StylizedButton65.Style")
        Me.StylizedButton65.TabIndex = 165
        Me.StylizedButton65.UseCompatibleTextRendering = True
        Me.StylizedButton65.UseVisualStyleBackColor = False
        '
        'StylizedButton59
        '
        Me.StylizedButton59.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton59.BackgroundImage = CType(resources.GetObject("StylizedButton59.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton59.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton59.FlatAppearance.BorderSize = 0
        Me.StylizedButton59.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton59.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton59.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton59.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton59.Image = CType(resources.GetObject("StylizedButton59.Image"), System.Drawing.Image)
        Me.StylizedButton59.Location = New System.Drawing.Point(150, 150)
        Me.StylizedButton59.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton59.Name = "StylizedButton59"
        Me.StylizedButton59.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton59.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton59.Style = resources.GetString("StylizedButton59.Style")
        Me.StylizedButton59.TabIndex = 159
        Me.StylizedButton59.UseCompatibleTextRendering = True
        Me.StylizedButton59.UseVisualStyleBackColor = False
        '
        'StylizedButton60
        '
        Me.StylizedButton60.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton60.BackgroundImage = CType(resources.GetObject("StylizedButton60.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton60.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton60.FlatAppearance.BorderSize = 0
        Me.StylizedButton60.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton60.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton60.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton60.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton60.Image = CType(resources.GetObject("StylizedButton60.Image"), System.Drawing.Image)
        Me.StylizedButton60.Location = New System.Drawing.Point(174, 150)
        Me.StylizedButton60.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton60.Name = "StylizedButton60"
        Me.StylizedButton60.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton60.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton60.Style = resources.GetString("StylizedButton60.Style")
        Me.StylizedButton60.TabIndex = 160
        Me.StylizedButton60.UseCompatibleTextRendering = True
        Me.StylizedButton60.UseVisualStyleBackColor = False
        '
        'StylizedButton61
        '
        Me.StylizedButton61.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton61.BackgroundImage = CType(resources.GetObject("StylizedButton61.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton61.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton61.FlatAppearance.BorderSize = 0
        Me.StylizedButton61.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton61.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton61.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton61.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton61.Image = CType(resources.GetObject("StylizedButton61.Image"), System.Drawing.Image)
        Me.StylizedButton61.Location = New System.Drawing.Point(198, 150)
        Me.StylizedButton61.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton61.Name = "StylizedButton61"
        Me.StylizedButton61.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton61.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton61.Style = resources.GetString("StylizedButton61.Style")
        Me.StylizedButton61.TabIndex = 161
        Me.StylizedButton61.UseCompatibleTextRendering = True
        Me.StylizedButton61.UseVisualStyleBackColor = False
        '
        'StylizedButton62
        '
        Me.StylizedButton62.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton62.BackgroundImage = CType(resources.GetObject("StylizedButton62.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton62.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton62.FlatAppearance.BorderSize = 0
        Me.StylizedButton62.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton62.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton62.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton62.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton62.Image = CType(resources.GetObject("StylizedButton62.Image"), System.Drawing.Image)
        Me.StylizedButton62.Location = New System.Drawing.Point(6, 174)
        Me.StylizedButton62.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton62.Name = "StylizedButton62"
        Me.StylizedButton62.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton62.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton62.Style = resources.GetString("StylizedButton62.Style")
        Me.StylizedButton62.TabIndex = 162
        Me.StylizedButton62.UseCompatibleTextRendering = True
        Me.StylizedButton62.UseVisualStyleBackColor = False
        '
        'StylizedButton63
        '
        Me.StylizedButton63.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton63.BackgroundImage = CType(resources.GetObject("StylizedButton63.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton63.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton63.FlatAppearance.BorderSize = 0
        Me.StylizedButton63.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton63.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton63.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton63.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton63.Image = CType(resources.GetObject("StylizedButton63.Image"), System.Drawing.Image)
        Me.StylizedButton63.Location = New System.Drawing.Point(30, 174)
        Me.StylizedButton63.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton63.Name = "StylizedButton63"
        Me.StylizedButton63.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton63.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton63.Style = resources.GetString("StylizedButton63.Style")
        Me.StylizedButton63.TabIndex = 163
        Me.StylizedButton63.UseCompatibleTextRendering = True
        Me.StylizedButton63.UseVisualStyleBackColor = False
        '
        'StylizedButton64
        '
        Me.StylizedButton64.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton64.BackgroundImage = CType(resources.GetObject("StylizedButton64.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton64.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton64.FlatAppearance.BorderSize = 0
        Me.StylizedButton64.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton64.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton64.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton64.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton64.Image = CType(resources.GetObject("StylizedButton64.Image"), System.Drawing.Image)
        Me.StylizedButton64.Location = New System.Drawing.Point(54, 174)
        Me.StylizedButton64.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton64.Name = "StylizedButton64"
        Me.StylizedButton64.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton64.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton64.Style = resources.GetString("StylizedButton64.Style")
        Me.StylizedButton64.TabIndex = 164
        Me.StylizedButton64.UseCompatibleTextRendering = True
        Me.StylizedButton64.UseVisualStyleBackColor = False
        '
        'StylizedButton66
        '
        Me.StylizedButton66.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton66.BackgroundImage = CType(resources.GetObject("StylizedButton66.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton66.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton66.FlatAppearance.BorderSize = 0
        Me.StylizedButton66.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton66.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton66.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton66.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton66.Image = CType(resources.GetObject("StylizedButton66.Image"), System.Drawing.Image)
        Me.StylizedButton66.Location = New System.Drawing.Point(78, 174)
        Me.StylizedButton66.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton66.Name = "StylizedButton66"
        Me.StylizedButton66.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton66.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton66.Style = resources.GetString("StylizedButton66.Style")
        Me.StylizedButton66.TabIndex = 166
        Me.StylizedButton66.UseCompatibleTextRendering = True
        Me.StylizedButton66.UseVisualStyleBackColor = False
        '
        'StylizedButton68
        '
        Me.StylizedButton68.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton68.BackgroundImage = CType(resources.GetObject("StylizedButton68.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton68.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton68.FlatAppearance.BorderSize = 0
        Me.StylizedButton68.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton68.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton68.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton68.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton68.Image = CType(resources.GetObject("StylizedButton68.Image"), System.Drawing.Image)
        Me.StylizedButton68.Location = New System.Drawing.Point(102, 174)
        Me.StylizedButton68.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton68.Name = "StylizedButton68"
        Me.StylizedButton68.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton68.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton68.Style = resources.GetString("StylizedButton68.Style")
        Me.StylizedButton68.TabIndex = 167
        Me.StylizedButton68.UseCompatibleTextRendering = True
        Me.StylizedButton68.UseVisualStyleBackColor = False
        '
        'StylizedButton71
        '
        Me.StylizedButton71.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton71.BackgroundImage = CType(resources.GetObject("StylizedButton71.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton71.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton71.FlatAppearance.BorderSize = 0
        Me.StylizedButton71.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton71.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton71.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton71.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton71.Image = CType(resources.GetObject("StylizedButton71.Image"), System.Drawing.Image)
        Me.StylizedButton71.Location = New System.Drawing.Point(126, 174)
        Me.StylizedButton71.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton71.Name = "StylizedButton71"
        Me.StylizedButton71.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton71.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton71.Style = resources.GetString("StylizedButton71.Style")
        Me.StylizedButton71.TabIndex = 170
        Me.StylizedButton71.UseCompatibleTextRendering = True
        Me.StylizedButton71.UseVisualStyleBackColor = False
        '
        'StylizedButton69
        '
        Me.StylizedButton69.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton69.BackgroundImage = CType(resources.GetObject("StylizedButton69.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton69.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton69.FlatAppearance.BorderSize = 0
        Me.StylizedButton69.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton69.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton69.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton69.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton69.Image = CType(resources.GetObject("StylizedButton69.Image"), System.Drawing.Image)
        Me.StylizedButton69.Location = New System.Drawing.Point(150, 174)
        Me.StylizedButton69.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton69.Name = "StylizedButton69"
        Me.StylizedButton69.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton69.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton69.Style = resources.GetString("StylizedButton69.Style")
        Me.StylizedButton69.TabIndex = 168
        Me.StylizedButton69.UseCompatibleTextRendering = True
        Me.StylizedButton69.UseVisualStyleBackColor = False
        '
        'StylizedButton70
        '
        Me.StylizedButton70.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton70.BackgroundImage = CType(resources.GetObject("StylizedButton70.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton70.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton70.FlatAppearance.BorderSize = 0
        Me.StylizedButton70.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton70.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton70.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton70.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton70.Image = CType(resources.GetObject("StylizedButton70.Image"), System.Drawing.Image)
        Me.StylizedButton70.Location = New System.Drawing.Point(174, 174)
        Me.StylizedButton70.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton70.Name = "StylizedButton70"
        Me.StylizedButton70.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton70.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton70.Style = resources.GetString("StylizedButton70.Style")
        Me.StylizedButton70.TabIndex = 169
        Me.StylizedButton70.UseCompatibleTextRendering = True
        Me.StylizedButton70.UseVisualStyleBackColor = False
        '
        'StylizedButton72
        '
        Me.StylizedButton72.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton72.BackgroundImage = CType(resources.GetObject("StylizedButton72.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton72.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton72.FlatAppearance.BorderSize = 0
        Me.StylizedButton72.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton72.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton72.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton72.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton72.Image = CType(resources.GetObject("StylizedButton72.Image"), System.Drawing.Image)
        Me.StylizedButton72.Location = New System.Drawing.Point(198, 174)
        Me.StylizedButton72.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton72.Name = "StylizedButton72"
        Me.StylizedButton72.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton72.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton72.Style = resources.GetString("StylizedButton72.Style")
        Me.StylizedButton72.TabIndex = 171
        Me.StylizedButton72.UseCompatibleTextRendering = True
        Me.StylizedButton72.UseVisualStyleBackColor = False
        '
        'StylizedButton73
        '
        Me.StylizedButton73.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton73.BackgroundImage = CType(resources.GetObject("StylizedButton73.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton73.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton73.FlatAppearance.BorderSize = 0
        Me.StylizedButton73.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton73.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton73.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton73.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton73.Image = CType(resources.GetObject("StylizedButton73.Image"), System.Drawing.Image)
        Me.StylizedButton73.Location = New System.Drawing.Point(6, 198)
        Me.StylizedButton73.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton73.Name = "StylizedButton73"
        Me.StylizedButton73.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton73.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton73.Style = resources.GetString("StylizedButton73.Style")
        Me.StylizedButton73.TabIndex = 172
        Me.StylizedButton73.UseCompatibleTextRendering = True
        Me.StylizedButton73.UseVisualStyleBackColor = False
        '
        'StylizedButton74
        '
        Me.StylizedButton74.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton74.BackgroundImage = CType(resources.GetObject("StylizedButton74.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton74.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton74.FlatAppearance.BorderSize = 0
        Me.StylizedButton74.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton74.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton74.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton74.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton74.Image = CType(resources.GetObject("StylizedButton74.Image"), System.Drawing.Image)
        Me.StylizedButton74.Location = New System.Drawing.Point(30, 198)
        Me.StylizedButton74.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton74.Name = "StylizedButton74"
        Me.StylizedButton74.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton74.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton74.Style = resources.GetString("StylizedButton74.Style")
        Me.StylizedButton74.TabIndex = 173
        Me.StylizedButton74.UseCompatibleTextRendering = True
        Me.StylizedButton74.UseVisualStyleBackColor = False
        '
        'StylizedButton75
        '
        Me.StylizedButton75.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton75.BackgroundImage = CType(resources.GetObject("StylizedButton75.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton75.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton75.FlatAppearance.BorderSize = 0
        Me.StylizedButton75.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton75.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton75.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton75.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton75.Image = CType(resources.GetObject("StylizedButton75.Image"), System.Drawing.Image)
        Me.StylizedButton75.Location = New System.Drawing.Point(54, 198)
        Me.StylizedButton75.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton75.Name = "StylizedButton75"
        Me.StylizedButton75.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton75.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton75.Style = resources.GetString("StylizedButton75.Style")
        Me.StylizedButton75.TabIndex = 174
        Me.StylizedButton75.UseCompatibleTextRendering = True
        Me.StylizedButton75.UseVisualStyleBackColor = False
        '
        'StylizedButton76
        '
        Me.StylizedButton76.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton76.BackgroundImage = CType(resources.GetObject("StylizedButton76.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton76.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton76.FlatAppearance.BorderSize = 0
        Me.StylizedButton76.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton76.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton76.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton76.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton76.Image = CType(resources.GetObject("StylizedButton76.Image"), System.Drawing.Image)
        Me.StylizedButton76.Location = New System.Drawing.Point(78, 198)
        Me.StylizedButton76.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton76.Name = "StylizedButton76"
        Me.StylizedButton76.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton76.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton76.Style = resources.GetString("StylizedButton76.Style")
        Me.StylizedButton76.TabIndex = 175
        Me.StylizedButton76.UseCompatibleTextRendering = True
        Me.StylizedButton76.UseVisualStyleBackColor = False
        '
        'StylizedButton77
        '
        Me.StylizedButton77.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton77.BackgroundImage = CType(resources.GetObject("StylizedButton77.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton77.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton77.FlatAppearance.BorderSize = 0
        Me.StylizedButton77.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton77.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton77.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton77.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton77.Image = CType(resources.GetObject("StylizedButton77.Image"), System.Drawing.Image)
        Me.StylizedButton77.Location = New System.Drawing.Point(102, 198)
        Me.StylizedButton77.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton77.Name = "StylizedButton77"
        Me.StylizedButton77.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton77.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton77.Style = resources.GetString("StylizedButton77.Style")
        Me.StylizedButton77.TabIndex = 176
        Me.StylizedButton77.UseCompatibleTextRendering = True
        Me.StylizedButton77.UseVisualStyleBackColor = False
        '
        'StylizedButton78
        '
        Me.StylizedButton78.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton78.BackgroundImage = CType(resources.GetObject("StylizedButton78.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton78.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton78.FlatAppearance.BorderSize = 0
        Me.StylizedButton78.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton78.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton78.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton78.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton78.Image = CType(resources.GetObject("StylizedButton78.Image"), System.Drawing.Image)
        Me.StylizedButton78.Location = New System.Drawing.Point(126, 198)
        Me.StylizedButton78.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton78.Name = "StylizedButton78"
        Me.StylizedButton78.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton78.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton78.Style = resources.GetString("StylizedButton78.Style")
        Me.StylizedButton78.TabIndex = 177
        Me.StylizedButton78.UseCompatibleTextRendering = True
        Me.StylizedButton78.UseVisualStyleBackColor = False
        '
        'StylizedButton79
        '
        Me.StylizedButton79.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton79.BackgroundImage = CType(resources.GetObject("StylizedButton79.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton79.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton79.FlatAppearance.BorderSize = 0
        Me.StylizedButton79.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton79.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton79.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton79.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton79.Image = CType(resources.GetObject("StylizedButton79.Image"), System.Drawing.Image)
        Me.StylizedButton79.Location = New System.Drawing.Point(150, 198)
        Me.StylizedButton79.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton79.Name = "StylizedButton79"
        Me.StylizedButton79.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton79.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton79.Style = resources.GetString("StylizedButton79.Style")
        Me.StylizedButton79.TabIndex = 178
        Me.StylizedButton79.UseCompatibleTextRendering = True
        Me.StylizedButton79.UseVisualStyleBackColor = False
        '
        'StylizedButton80
        '
        Me.StylizedButton80.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton80.BackgroundImage = CType(resources.GetObject("StylizedButton80.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton80.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton80.FlatAppearance.BorderSize = 0
        Me.StylizedButton80.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton80.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton80.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton80.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton80.Image = CType(resources.GetObject("StylizedButton80.Image"), System.Drawing.Image)
        Me.StylizedButton80.Location = New System.Drawing.Point(174, 198)
        Me.StylizedButton80.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton80.Name = "StylizedButton80"
        Me.StylizedButton80.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton80.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton80.Style = resources.GetString("StylizedButton80.Style")
        Me.StylizedButton80.TabIndex = 179
        Me.StylizedButton80.UseCompatibleTextRendering = True
        Me.StylizedButton80.UseVisualStyleBackColor = False
        '
        'StylizedButton67
        '
        Me.StylizedButton67.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton67.BackgroundImage = CType(resources.GetObject("StylizedButton67.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton67.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton67.FlatAppearance.BorderSize = 0
        Me.StylizedButton67.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton67.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton67.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton67.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton67.Image = CType(resources.GetObject("StylizedButton67.Image"), System.Drawing.Image)
        Me.StylizedButton67.Location = New System.Drawing.Point(198, 198)
        Me.StylizedButton67.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton67.Name = "StylizedButton67"
        Me.StylizedButton67.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton67.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton67.Style = resources.GetString("StylizedButton67.Style")
        Me.StylizedButton67.TabIndex = 180
        Me.StylizedButton67.UseCompatibleTextRendering = True
        Me.StylizedButton67.UseVisualStyleBackColor = False
        '
        'StylizedButton81
        '
        Me.StylizedButton81.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton81.BackgroundImage = CType(resources.GetObject("StylizedButton81.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton81.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton81.FlatAppearance.BorderSize = 0
        Me.StylizedButton81.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton81.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton81.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton81.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton81.Image = CType(resources.GetObject("StylizedButton81.Image"), System.Drawing.Image)
        Me.StylizedButton81.Location = New System.Drawing.Point(6, 222)
        Me.StylizedButton81.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton81.Name = "StylizedButton81"
        Me.StylizedButton81.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton81.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton81.Style = resources.GetString("StylizedButton81.Style")
        Me.StylizedButton81.TabIndex = 181
        Me.StylizedButton81.UseCompatibleTextRendering = True
        Me.StylizedButton81.UseVisualStyleBackColor = False
        '
        'StylizedButton82
        '
        Me.StylizedButton82.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton82.BackgroundImage = CType(resources.GetObject("StylizedButton82.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton82.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton82.FlatAppearance.BorderSize = 0
        Me.StylizedButton82.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton82.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton82.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton82.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton82.Image = CType(resources.GetObject("StylizedButton82.Image"), System.Drawing.Image)
        Me.StylizedButton82.Location = New System.Drawing.Point(30, 222)
        Me.StylizedButton82.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton82.Name = "StylizedButton82"
        Me.StylizedButton82.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton82.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton82.Style = resources.GetString("StylizedButton82.Style")
        Me.StylizedButton82.TabIndex = 182
        Me.StylizedButton82.UseCompatibleTextRendering = True
        Me.StylizedButton82.UseVisualStyleBackColor = False
        '
        'StylizedButton83
        '
        Me.StylizedButton83.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton83.BackgroundImage = CType(resources.GetObject("StylizedButton83.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton83.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton83.FlatAppearance.BorderSize = 0
        Me.StylizedButton83.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton83.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton83.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton83.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton83.Image = CType(resources.GetObject("StylizedButton83.Image"), System.Drawing.Image)
        Me.StylizedButton83.Location = New System.Drawing.Point(54, 222)
        Me.StylizedButton83.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton83.Name = "StylizedButton83"
        Me.StylizedButton83.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton83.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton83.Style = resources.GetString("StylizedButton83.Style")
        Me.StylizedButton83.TabIndex = 183
        Me.StylizedButton83.UseCompatibleTextRendering = True
        Me.StylizedButton83.UseVisualStyleBackColor = False
        '
        'StylizedButton84
        '
        Me.StylizedButton84.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton84.BackgroundImage = CType(resources.GetObject("StylizedButton84.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton84.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton84.FlatAppearance.BorderSize = 0
        Me.StylizedButton84.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton84.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton84.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton84.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton84.Image = CType(resources.GetObject("StylizedButton84.Image"), System.Drawing.Image)
        Me.StylizedButton84.Location = New System.Drawing.Point(78, 222)
        Me.StylizedButton84.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton84.Name = "StylizedButton84"
        Me.StylizedButton84.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton84.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton84.Style = resources.GetString("StylizedButton84.Style")
        Me.StylizedButton84.TabIndex = 184
        Me.StylizedButton84.UseCompatibleTextRendering = True
        Me.StylizedButton84.UseVisualStyleBackColor = False
        '
        'StylizedButton85
        '
        Me.StylizedButton85.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton85.BackgroundImage = CType(resources.GetObject("StylizedButton85.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton85.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton85.FlatAppearance.BorderSize = 0
        Me.StylizedButton85.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton85.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton85.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton85.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton85.Image = CType(resources.GetObject("StylizedButton85.Image"), System.Drawing.Image)
        Me.StylizedButton85.Location = New System.Drawing.Point(102, 222)
        Me.StylizedButton85.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton85.Name = "StylizedButton85"
        Me.StylizedButton85.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton85.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton85.Style = resources.GetString("StylizedButton85.Style")
        Me.StylizedButton85.TabIndex = 185
        Me.StylizedButton85.UseCompatibleTextRendering = True
        Me.StylizedButton85.UseVisualStyleBackColor = False
        '
        'StylizedButton86
        '
        Me.StylizedButton86.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton86.BackgroundImage = CType(resources.GetObject("StylizedButton86.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton86.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton86.FlatAppearance.BorderSize = 0
        Me.StylizedButton86.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton86.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton86.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton86.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton86.Image = CType(resources.GetObject("StylizedButton86.Image"), System.Drawing.Image)
        Me.StylizedButton86.Location = New System.Drawing.Point(126, 222)
        Me.StylizedButton86.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton86.Name = "StylizedButton86"
        Me.StylizedButton86.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton86.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton86.Style = resources.GetString("StylizedButton86.Style")
        Me.StylizedButton86.TabIndex = 186
        Me.StylizedButton86.UseCompatibleTextRendering = True
        Me.StylizedButton86.UseVisualStyleBackColor = False
        '
        'StylizedButton87
        '
        Me.StylizedButton87.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton87.BackgroundImage = CType(resources.GetObject("StylizedButton87.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton87.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton87.FlatAppearance.BorderSize = 0
        Me.StylizedButton87.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton87.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton87.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton87.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton87.Image = CType(resources.GetObject("StylizedButton87.Image"), System.Drawing.Image)
        Me.StylizedButton87.Location = New System.Drawing.Point(150, 222)
        Me.StylizedButton87.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton87.Name = "StylizedButton87"
        Me.StylizedButton87.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton87.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton87.Style = resources.GetString("StylizedButton87.Style")
        Me.StylizedButton87.TabIndex = 187
        Me.StylizedButton87.UseCompatibleTextRendering = True
        Me.StylizedButton87.UseVisualStyleBackColor = False
        '
        'StylizedButton89
        '
        Me.StylizedButton89.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton89.BackgroundImage = CType(resources.GetObject("StylizedButton89.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton89.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton89.FlatAppearance.BorderSize = 0
        Me.StylizedButton89.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton89.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton89.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton89.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton89.Image = CType(resources.GetObject("StylizedButton89.Image"), System.Drawing.Image)
        Me.StylizedButton89.Location = New System.Drawing.Point(174, 222)
        Me.StylizedButton89.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton89.Name = "StylizedButton89"
        Me.StylizedButton89.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton89.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton89.Style = resources.GetString("StylizedButton89.Style")
        Me.StylizedButton89.TabIndex = 189
        Me.StylizedButton89.UseCompatibleTextRendering = True
        Me.StylizedButton89.UseVisualStyleBackColor = False
        '
        'StylizedButton91
        '
        Me.StylizedButton91.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton91.BackgroundImage = CType(resources.GetObject("StylizedButton91.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton91.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton91.FlatAppearance.BorderSize = 0
        Me.StylizedButton91.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton91.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton91.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton91.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton91.Image = CType(resources.GetObject("StylizedButton91.Image"), System.Drawing.Image)
        Me.StylizedButton91.Location = New System.Drawing.Point(198, 222)
        Me.StylizedButton91.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton91.Name = "StylizedButton91"
        Me.StylizedButton91.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton91.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton91.Style = resources.GetString("StylizedButton91.Style")
        Me.StylizedButton91.TabIndex = 191
        Me.StylizedButton91.UseCompatibleTextRendering = True
        Me.StylizedButton91.UseVisualStyleBackColor = False
        '
        'StylizedButton92
        '
        Me.StylizedButton92.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton92.BackgroundImage = CType(resources.GetObject("StylizedButton92.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton92.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton92.FlatAppearance.BorderSize = 0
        Me.StylizedButton92.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton92.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton92.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton92.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton92.Image = CType(resources.GetObject("StylizedButton92.Image"), System.Drawing.Image)
        Me.StylizedButton92.Location = New System.Drawing.Point(6, 246)
        Me.StylizedButton92.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton92.Name = "StylizedButton92"
        Me.StylizedButton92.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton92.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton92.Style = resources.GetString("StylizedButton92.Style")
        Me.StylizedButton92.TabIndex = 192
        Me.StylizedButton92.UseCompatibleTextRendering = True
        Me.StylizedButton92.UseVisualStyleBackColor = False
        '
        'StylizedButton94
        '
        Me.StylizedButton94.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton94.BackgroundImage = CType(resources.GetObject("StylizedButton94.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton94.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton94.FlatAppearance.BorderSize = 0
        Me.StylizedButton94.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton94.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton94.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton94.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton94.Image = CType(resources.GetObject("StylizedButton94.Image"), System.Drawing.Image)
        Me.StylizedButton94.Location = New System.Drawing.Point(30, 246)
        Me.StylizedButton94.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton94.Name = "StylizedButton94"
        Me.StylizedButton94.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton94.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton94.Style = resources.GetString("StylizedButton94.Style")
        Me.StylizedButton94.TabIndex = 194
        Me.StylizedButton94.UseCompatibleTextRendering = True
        Me.StylizedButton94.UseVisualStyleBackColor = False
        '
        'StylizedButton95
        '
        Me.StylizedButton95.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton95.BackgroundImage = CType(resources.GetObject("StylizedButton95.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton95.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton95.FlatAppearance.BorderSize = 0
        Me.StylizedButton95.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton95.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton95.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton95.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton95.Image = CType(resources.GetObject("StylizedButton95.Image"), System.Drawing.Image)
        Me.StylizedButton95.Location = New System.Drawing.Point(54, 246)
        Me.StylizedButton95.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton95.Name = "StylizedButton95"
        Me.StylizedButton95.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton95.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton95.Style = resources.GetString("StylizedButton95.Style")
        Me.StylizedButton95.TabIndex = 195
        Me.StylizedButton95.UseCompatibleTextRendering = True
        Me.StylizedButton95.UseVisualStyleBackColor = False
        '
        'StylizedButton96
        '
        Me.StylizedButton96.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton96.BackgroundImage = CType(resources.GetObject("StylizedButton96.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton96.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton96.FlatAppearance.BorderSize = 0
        Me.StylizedButton96.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton96.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton96.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton96.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton96.Image = CType(resources.GetObject("StylizedButton96.Image"), System.Drawing.Image)
        Me.StylizedButton96.Location = New System.Drawing.Point(78, 246)
        Me.StylizedButton96.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton96.Name = "StylizedButton96"
        Me.StylizedButton96.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton96.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton96.Style = resources.GetString("StylizedButton96.Style")
        Me.StylizedButton96.TabIndex = 196
        Me.StylizedButton96.UseCompatibleTextRendering = True
        Me.StylizedButton96.UseVisualStyleBackColor = False
        '
        'StylizedButton97
        '
        Me.StylizedButton97.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton97.BackgroundImage = CType(resources.GetObject("StylizedButton97.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton97.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton97.FlatAppearance.BorderSize = 0
        Me.StylizedButton97.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton97.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton97.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton97.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton97.Image = CType(resources.GetObject("StylizedButton97.Image"), System.Drawing.Image)
        Me.StylizedButton97.Location = New System.Drawing.Point(102, 246)
        Me.StylizedButton97.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton97.Name = "StylizedButton97"
        Me.StylizedButton97.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton97.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton97.Style = resources.GetString("StylizedButton97.Style")
        Me.StylizedButton97.TabIndex = 197
        Me.StylizedButton97.UseCompatibleTextRendering = True
        Me.StylizedButton97.UseVisualStyleBackColor = False
        '
        'StylizedButton100
        '
        Me.StylizedButton100.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton100.BackgroundImage = CType(resources.GetObject("StylizedButton100.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton100.FlatAppearance.BorderSize = 0
        Me.StylizedButton100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton100.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton100.Image = CType(resources.GetObject("StylizedButton100.Image"), System.Drawing.Image)
        Me.StylizedButton100.Location = New System.Drawing.Point(126, 246)
        Me.StylizedButton100.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton100.Name = "StylizedButton100"
        Me.StylizedButton100.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton100.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton100.Style = resources.GetString("StylizedButton100.Style")
        Me.StylizedButton100.TabIndex = 198
        Me.StylizedButton100.UseCompatibleTextRendering = True
        Me.StylizedButton100.UseVisualStyleBackColor = False
        '
        'StylizedButton102
        '
        Me.StylizedButton102.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton102.BackgroundImage = CType(resources.GetObject("StylizedButton102.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton102.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton102.FlatAppearance.BorderSize = 0
        Me.StylizedButton102.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton102.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton102.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton102.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton102.Image = CType(resources.GetObject("StylizedButton102.Image"), System.Drawing.Image)
        Me.StylizedButton102.Location = New System.Drawing.Point(150, 246)
        Me.StylizedButton102.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton102.Name = "StylizedButton102"
        Me.StylizedButton102.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.StylizedButton102.Size = New System.Drawing.Size(20, 20)
        Me.StylizedButton102.Style = resources.GetString("StylizedButton102.Style")
        Me.StylizedButton102.TabIndex = 199
        Me.StylizedButton102.UseCompatibleTextRendering = True
        Me.StylizedButton102.UseVisualStyleBackColor = False
        '
        'ClipArtLayoutPanel
        '
        Me.ClipArtLayoutPanel.AutoScroll = True
        Me.ClipArtLayoutPanel.AutoScrollMargin = New System.Drawing.Size(15, 5)
        Me.ClipArtLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ClipArtLayoutPanel.Location = New System.Drawing.Point(0, 69)
        Me.ClipArtLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ClipArtLayoutPanel.Name = "ClipArtLayoutPanel"
        Me.ClipArtLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.ClipArtLayoutPanel.Size = New System.Drawing.Size(253, 46)
        Me.ClipArtLayoutPanel.TabIndex = 7
        '
        'StylizedPanel2
        '
        Me.StylizedPanel2.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel2.Controls.Add(Me.btnClose)
        Me.StylizedPanel2.Controls.Add(Me.btnEmotesTab)
        Me.StylizedPanel2.Controls.Add(Me.btnClipArtTab)
        Me.StylizedPanel2.Controls.Add(Me.StylizedRadioButton1)
        Me.StylizedPanel2.Controls.Add(Me.btnNotebookTab)
        Me.StylizedPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.StylizedPanel2.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.StylizedPanel2.Name = "StylizedPanel2"
        Me.StylizedPanel2.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.StylizedPanel2.Size = New System.Drawing.Size(253, 28)
        Me.StylizedPanel2.Style = "Colors=~255|~255" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight" &
    " Color$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=1"
        Me.StylizedPanel2.TabIndex = 71
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(227, 2)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnClose.Size = New System.Drawing.Size(26, 26)
        Me.btnClose.Style = resources.GetString("btnClose.Style")
        Me.btnClose.TabIndex = 61
        Me.btnClose.UseCompatibleTextRendering = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnEmotesTab
        '
        Me.btnEmotesTab.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnEmotesTab.AutoSize = True
        Me.btnEmotesTab.BackColor = System.Drawing.Color.Transparent
        Me.btnEmotesTab.BackgroundImage = CType(resources.GetObject("btnEmotesTab.BackgroundImage"), System.Drawing.Image)
        Me.btnEmotesTab.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEmotesTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEmotesTab.FlatAppearance.BorderSize = 0
        Me.btnEmotesTab.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnEmotesTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEmotesTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEmotesTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmotesTab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnEmotesTab.Location = New System.Drawing.Point(178, 2)
        Me.btnEmotesTab.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEmotesTab.Name = "btnEmotesTab"
        Me.btnEmotesTab.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnEmotesTab.Size = New System.Drawing.Size(52, 26)
        Me.btnEmotesTab.Style = resources.GetString("btnEmotesTab.Style")
        Me.btnEmotesTab.TabIndex = 65
        Me.btnEmotesTab.Text = "Emotes"
        Me.btnEmotesTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEmotesTab.UseVisualStyleBackColor = False
        '
        'btnClipArtTab
        '
        Me.btnClipArtTab.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnClipArtTab.AutoSize = True
        Me.btnClipArtTab.BackColor = System.Drawing.Color.Transparent
        Me.btnClipArtTab.BackgroundImage = CType(resources.GetObject("btnClipArtTab.BackgroundImage"), System.Drawing.Image)
        Me.btnClipArtTab.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClipArtTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClipArtTab.FlatAppearance.BorderSize = 0
        Me.btnClipArtTab.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnClipArtTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClipArtTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClipArtTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClipArtTab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnClipArtTab.Location = New System.Drawing.Point(128, 2)
        Me.btnClipArtTab.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClipArtTab.Name = "btnClipArtTab"
        Me.btnClipArtTab.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnClipArtTab.Size = New System.Drawing.Size(50, 26)
        Me.btnClipArtTab.Style = resources.GetString("btnClipArtTab.Style")
        Me.btnClipArtTab.TabIndex = 64
        Me.btnClipArtTab.Text = "Clip Art"
        Me.btnClipArtTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnClipArtTab.UseVisualStyleBackColor = False
        '
        'StylizedRadioButton1
        '
        Me.StylizedRadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.StylizedRadioButton1.AutoSize = True
        Me.StylizedRadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedRadioButton1.BackgroundImage = CType(resources.GetObject("StylizedRadioButton1.BackgroundImage"), System.Drawing.Image)
        Me.StylizedRadioButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.StylizedRadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedRadioButton1.FlatAppearance.BorderSize = 0
        Me.StylizedRadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.StylizedRadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedRadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedRadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedRadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.StylizedRadioButton1.Location = New System.Drawing.Point(64, 2)
        Me.StylizedRadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedRadioButton1.Name = "StylizedRadioButton1"
        Me.StylizedRadioButton1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.StylizedRadioButton1.Size = New System.Drawing.Size(64, 26)
        Me.StylizedRadioButton1.Style = resources.GetString("StylizedRadioButton1.Style")
        Me.StylizedRadioButton1.TabIndex = 63
        Me.StylizedRadioButton1.Text = "Dictionary"
        Me.StylizedRadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StylizedRadioButton1.UseVisualStyleBackColor = False
        '
        'btnNotebookTab
        '
        Me.btnNotebookTab.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnNotebookTab.AutoSize = True
        Me.btnNotebookTab.BackColor = System.Drawing.Color.Transparent
        Me.btnNotebookTab.BackgroundImage = CType(resources.GetObject("btnNotebookTab.BackgroundImage"), System.Drawing.Image)
        Me.btnNotebookTab.Checked = True
        Me.btnNotebookTab.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNotebookTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotebookTab.FlatAppearance.BorderSize = 0
        Me.btnNotebookTab.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnNotebookTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNotebookTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNotebookTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotebookTab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotebookTab.Location = New System.Drawing.Point(0, 2)
        Me.btnNotebookTab.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNotebookTab.Name = "btnNotebookTab"
        Me.btnNotebookTab.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNotebookTab.Size = New System.Drawing.Size(64, 26)
        Me.btnNotebookTab.Style = resources.GetString("btnNotebookTab.Style")
        Me.btnNotebookTab.TabIndex = 62
        Me.btnNotebookTab.TabStop = True
        Me.btnNotebookTab.Text = "Notebook"
        Me.btnNotebookTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNotebookTab.UseVisualStyleBackColor = False
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
        'btnSaveSpeech
        '
        Me.btnSaveSpeech.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveSpeech.BackgroundImage = CType(resources.GetObject("btnSaveSpeech.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveSpeech.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSaveSpeech.FlatAppearance.BorderSize = 0
        Me.btnSaveSpeech.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSaveSpeech.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSaveSpeech.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSaveSpeech.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSpeech.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSpeech.ForeColor = System.Drawing.Color.Black
        Me.btnSaveSpeech.Image = CType(resources.GetObject("btnSaveSpeech.Image"), System.Drawing.Image)
        Me.btnSaveSpeech.Location = New System.Drawing.Point(369, 33)
        Me.btnSaveSpeech.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveSpeech.Name = "btnSaveSpeech"
        Me.btnSaveSpeech.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnSaveSpeech.Size = New System.Drawing.Size(26, 26)
        Me.btnSaveSpeech.Style = resources.GetString("btnSaveSpeech.Style")
        Me.btnSaveSpeech.TabIndex = 44
        Me.ttMain.SetToolTip(Me.btnSaveSpeech, "Save")
        Me.btnSaveSpeech.UseCompatibleTextRendering = True
        Me.btnSaveSpeech.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.BackgroundImage = CType(resources.GetObject("btnStop.BackgroundImage"), System.Drawing.Image)
        Me.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStop.FlatAppearance.BorderSize = 0
        Me.btnStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.Location = New System.Drawing.Point(339, 33)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnStop.Size = New System.Drawing.Size(26, 26)
        Me.btnStop.Style = resources.GetString("btnStop.Style")
        Me.btnStop.TabIndex = 43
        Me.ttMain.SetToolTip(Me.btnStop, "Stop")
        Me.btnStop.UseCompatibleTextRendering = True
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.BackgroundImage = CType(resources.GetObject("btnPlay.BackgroundImage"), System.Drawing.Image)
        Me.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.Black
        Me.btnPlay.Image = CType(resources.GetObject("btnPlay.Image"), System.Drawing.Image)
        Me.btnPlay.Location = New System.Drawing.Point(309, 33)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnPlay.Size = New System.Drawing.Size(26, 26)
        Me.btnPlay.Style = resources.GetString("btnPlay.Style")
        Me.btnPlay.TabIndex = 42
        Me.ttMain.SetToolTip(Me.btnPlay, "Play")
        Me.btnPlay.UseCompatibleTextRendering = True
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnBaseline
        '
        Me.btnBaseline.BackColor = System.Drawing.Color.Transparent
        Me.btnBaseline.BackgroundImage = CType(resources.GetObject("btnBaseline.BackgroundImage"), System.Drawing.Image)
        Me.btnBaseline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBaseline.FlatAppearance.BorderSize = 0
        Me.btnBaseline.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnBaseline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBaseline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBaseline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaseline.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaseline.ForeColor = System.Drawing.Color.Black
        Me.btnBaseline.Image = CType(resources.GetObject("btnBaseline.Image"), System.Drawing.Image)
        Me.btnBaseline.Location = New System.Drawing.Point(430, 33)
        Me.btnBaseline.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBaseline.Name = "btnBaseline"
        Me.btnBaseline.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnBaseline.Size = New System.Drawing.Size(26, 26)
        Me.btnBaseline.Style = resources.GetString("btnBaseline.Style")
        Me.btnBaseline.TabIndex = 29
        Me.ttMain.SetToolTip(Me.btnBaseline, "Baseline")
        Me.btnBaseline.UseCompatibleTextRendering = True
        Me.btnBaseline.UseVisualStyleBackColor = False
        '
        'btnSubscript
        '
        Me.btnSubscript.BackColor = System.Drawing.Color.Transparent
        Me.btnSubscript.BackgroundImage = CType(resources.GetObject("btnSubscript.BackgroundImage"), System.Drawing.Image)
        Me.btnSubscript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubscript.FlatAppearance.BorderSize = 0
        Me.btnSubscript.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSubscript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSubscript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSubscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubscript.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubscript.ForeColor = System.Drawing.Color.Black
        Me.btnSubscript.Image = CType(resources.GetObject("btnSubscript.Image"), System.Drawing.Image)
        Me.btnSubscript.Location = New System.Drawing.Point(370, 33)
        Me.btnSubscript.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubscript.Name = "btnSubscript"
        Me.btnSubscript.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnSubscript.Size = New System.Drawing.Size(26, 26)
        Me.btnSubscript.Style = resources.GetString("btnSubscript.Style")
        Me.btnSubscript.TabIndex = 27
        Me.ttMain.SetToolTip(Me.btnSubscript, "Subscript")
        Me.btnSubscript.UseCompatibleTextRendering = True
        Me.btnSubscript.UseVisualStyleBackColor = False
        '
        'btnSuperscript
        '
        Me.btnSuperscript.BackColor = System.Drawing.Color.Transparent
        Me.btnSuperscript.BackgroundImage = CType(resources.GetObject("btnSuperscript.BackgroundImage"), System.Drawing.Image)
        Me.btnSuperscript.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSuperscript.FlatAppearance.BorderSize = 0
        Me.btnSuperscript.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSuperscript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSuperscript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSuperscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuperscript.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuperscript.ForeColor = System.Drawing.Color.Black
        Me.btnSuperscript.Image = CType(resources.GetObject("btnSuperscript.Image"), System.Drawing.Image)
        Me.btnSuperscript.Location = New System.Drawing.Point(400, 33)
        Me.btnSuperscript.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSuperscript.Name = "btnSuperscript"
        Me.btnSuperscript.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnSuperscript.Size = New System.Drawing.Size(26, 26)
        Me.btnSuperscript.Style = resources.GetString("btnSuperscript.Style")
        Me.btnSuperscript.TabIndex = 28
        Me.ttMain.SetToolTip(Me.btnSuperscript, "Superscript")
        Me.btnSuperscript.UseCompatibleTextRendering = True
        Me.btnSuperscript.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.Transparent
        Me.btnRight.BackgroundImage = CType(resources.GetObject("btnRight.BackgroundImage"), System.Drawing.Image)
        Me.btnRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRight.FlatAppearance.BorderSize = 0
        Me.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight.ForeColor = System.Drawing.Color.Black
        Me.btnRight.Image = CType(resources.GetObject("btnRight.Image"), System.Drawing.Image)
        Me.btnRight.Location = New System.Drawing.Point(532, 33)
        Me.btnRight.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnRight.Size = New System.Drawing.Size(26, 26)
        Me.btnRight.Style = resources.GetString("btnRight.Style")
        Me.btnRight.TabIndex = 34
        Me.btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnRight, "Right align")
        Me.btnRight.UseCompatibleTextRendering = True
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnCenter
        '
        Me.btnCenter.BackColor = System.Drawing.Color.Transparent
        Me.btnCenter.BackgroundImage = CType(resources.GetObject("btnCenter.BackgroundImage"), System.Drawing.Image)
        Me.btnCenter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCenter.FlatAppearance.BorderSize = 0
        Me.btnCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCenter.ForeColor = System.Drawing.Color.Black
        Me.btnCenter.Image = CType(resources.GetObject("btnCenter.Image"), System.Drawing.Image)
        Me.btnCenter.Location = New System.Drawing.Point(502, 33)
        Me.btnCenter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCenter.Name = "btnCenter"
        Me.btnCenter.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnCenter.Size = New System.Drawing.Size(26, 26)
        Me.btnCenter.Style = resources.GetString("btnCenter.Style")
        Me.btnCenter.TabIndex = 33
        Me.btnCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnCenter, "Center align")
        Me.btnCenter.UseCompatibleTextRendering = True
        Me.btnCenter.UseVisualStyleBackColor = False
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.Transparent
        Me.btnLeft.BackgroundImage = CType(resources.GetObject("btnLeft.BackgroundImage"), System.Drawing.Image)
        Me.btnLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLeft.FlatAppearance.BorderSize = 0
        Me.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft.ForeColor = System.Drawing.Color.Black
        Me.btnLeft.Image = CType(resources.GetObject("btnLeft.Image"), System.Drawing.Image)
        Me.btnLeft.Location = New System.Drawing.Point(472, 33)
        Me.btnLeft.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnLeft.Size = New System.Drawing.Size(26, 26)
        Me.btnLeft.Style = resources.GetString("btnLeft.Style")
        Me.btnLeft.TabIndex = 32
        Me.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnLeft, "Left align")
        Me.btnLeft.UseCompatibleTextRendering = True
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'btnIndent
        '
        Me.btnIndent.BackColor = System.Drawing.Color.Transparent
        Me.btnIndent.BackgroundImage = CType(resources.GetObject("btnIndent.BackgroundImage"), System.Drawing.Image)
        Me.btnIndent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIndent.FlatAppearance.BorderSize = 0
        Me.btnIndent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnIndent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnIndent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIndent.ForeColor = System.Drawing.Color.Black
        Me.btnIndent.Image = CType(resources.GetObject("btnIndent.Image"), System.Drawing.Image)
        Me.btnIndent.Location = New System.Drawing.Point(466, 2)
        Me.btnIndent.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIndent.Name = "btnIndent"
        Me.btnIndent.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnIndent.Size = New System.Drawing.Size(26, 26)
        Me.btnIndent.Style = resources.GetString("btnIndent.Style")
        Me.btnIndent.TabIndex = 30
        Me.btnIndent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnIndent, "Indent")
        Me.btnIndent.UseCompatibleTextRendering = True
        Me.btnIndent.UseVisualStyleBackColor = False
        '
        'btnStrikethrough
        '
        Me.btnStrikethrough.BackColor = System.Drawing.Color.Transparent
        Me.btnStrikethrough.BackgroundImage = CType(resources.GetObject("btnStrikethrough.BackgroundImage"), System.Drawing.Image)
        Me.btnStrikethrough.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStrikethrough.FlatAppearance.BorderSize = 0
        Me.btnStrikethrough.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnStrikethrough.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStrikethrough.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStrikethrough.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStrikethrough.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStrikethrough.ForeColor = System.Drawing.Color.Black
        Me.btnStrikethrough.Image = CType(resources.GetObject("btnStrikethrough.Image"), System.Drawing.Image)
        Me.btnStrikethrough.Location = New System.Drawing.Point(340, 33)
        Me.btnStrikethrough.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStrikethrough.Name = "btnStrikethrough"
        Me.btnStrikethrough.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnStrikethrough.Size = New System.Drawing.Size(26, 26)
        Me.btnStrikethrough.Style = resources.GetString("btnStrikethrough.Style")
        Me.btnStrikethrough.TabIndex = 26
        Me.ttMain.SetToolTip(Me.btnStrikethrough, "Strikethrough")
        Me.btnStrikethrough.UseCompatibleTextRendering = True
        Me.btnStrikethrough.UseVisualStyleBackColor = False
        '
        'btnUnderline
        '
        Me.btnUnderline.BackColor = System.Drawing.Color.Transparent
        Me.btnUnderline.BackgroundImage = CType(resources.GetObject("btnUnderline.BackgroundImage"), System.Drawing.Image)
        Me.btnUnderline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUnderline.FlatAppearance.BorderSize = 0
        Me.btnUnderline.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnUnderline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUnderline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnderline.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnderline.ForeColor = System.Drawing.Color.Black
        Me.btnUnderline.Image = CType(resources.GetObject("btnUnderline.Image"), System.Drawing.Image)
        Me.btnUnderline.Location = New System.Drawing.Point(310, 33)
        Me.btnUnderline.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUnderline.Name = "btnUnderline"
        Me.btnUnderline.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnUnderline.Size = New System.Drawing.Size(26, 26)
        Me.btnUnderline.Style = resources.GetString("btnUnderline.Style")
        Me.btnUnderline.TabIndex = 25
        Me.ttMain.SetToolTip(Me.btnUnderline, "Underline")
        Me.btnUnderline.UseCompatibleTextRendering = True
        Me.btnUnderline.UseVisualStyleBackColor = False
        '
        'btnItalic
        '
        Me.btnItalic.BackColor = System.Drawing.Color.Transparent
        Me.btnItalic.BackgroundImage = CType(resources.GetObject("btnItalic.BackgroundImage"), System.Drawing.Image)
        Me.btnItalic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnItalic.FlatAppearance.BorderSize = 0
        Me.btnItalic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnItalic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnItalic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItalic.ForeColor = System.Drawing.Color.Black
        Me.btnItalic.Image = CType(resources.GetObject("btnItalic.Image"), System.Drawing.Image)
        Me.btnItalic.Location = New System.Drawing.Point(280, 33)
        Me.btnItalic.Margin = New System.Windows.Forms.Padding(2)
        Me.btnItalic.Name = "btnItalic"
        Me.btnItalic.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnItalic.Size = New System.Drawing.Size(26, 26)
        Me.btnItalic.Style = resources.GetString("btnItalic.Style")
        Me.btnItalic.TabIndex = 24
        Me.ttMain.SetToolTip(Me.btnItalic, "Italic")
        Me.btnItalic.UseCompatibleTextRendering = True
        Me.btnItalic.UseVisualStyleBackColor = False
        '
        'btnBold
        '
        Me.btnBold.BackColor = System.Drawing.Color.Transparent
        Me.btnBold.BackgroundImage = CType(resources.GetObject("btnBold.BackgroundImage"), System.Drawing.Image)
        Me.btnBold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBold.FlatAppearance.BorderSize = 0
        Me.btnBold.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnBold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBold.ForeColor = System.Drawing.Color.Black
        Me.btnBold.Image = CType(resources.GetObject("btnBold.Image"), System.Drawing.Image)
        Me.btnBold.Location = New System.Drawing.Point(250, 33)
        Me.btnBold.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnBold.Size = New System.Drawing.Size(26, 26)
        Me.btnBold.Style = resources.GetString("btnBold.Style")
        Me.btnBold.TabIndex = 23
        Me.ttMain.SetToolTip(Me.btnBold, "Bold")
        Me.btnBold.UseCompatibleTextRendering = True
        Me.btnBold.UseVisualStyleBackColor = False
        '
        'btnQuickRedo
        '
        Me.btnQuickRedo.BackColor = System.Drawing.Color.Transparent
        Me.btnQuickRedo.BackgroundImage = CType(resources.GetObject("btnQuickRedo.BackgroundImage"), System.Drawing.Image)
        Me.btnQuickRedo.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnQuickRedo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuickRedo.FlatAppearance.BorderSize = 0
        Me.btnQuickRedo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnQuickRedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuickRedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuickRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickRedo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickRedo.ForeColor = System.Drawing.Color.Black
        Me.btnQuickRedo.Image = CType(resources.GetObject("btnQuickRedo.Image"), System.Drawing.Image)
        Me.btnQuickRedo.Location = New System.Drawing.Point(697, 0)
        Me.btnQuickRedo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuickRedo.Name = "btnQuickRedo"
        Me.btnQuickRedo.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnQuickRedo.Size = New System.Drawing.Size(25, 25)
        Me.btnQuickRedo.Style = resources.GetString("btnQuickRedo.Style")
        Me.btnQuickRedo.TabIndex = 97
        Me.ttMain.SetToolTip(Me.btnQuickRedo, "Redo")
        Me.btnQuickRedo.UseCompatibleTextRendering = True
        Me.btnQuickRedo.UseVisualStyleBackColor = False
        '
        'btnQuickUndo
        '
        Me.btnQuickUndo.BackColor = System.Drawing.Color.Transparent
        Me.btnQuickUndo.BackgroundImage = CType(resources.GetObject("btnQuickUndo.BackgroundImage"), System.Drawing.Image)
        Me.btnQuickUndo.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnQuickUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuickUndo.FlatAppearance.BorderSize = 0
        Me.btnQuickUndo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnQuickUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuickUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuickUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickUndo.ForeColor = System.Drawing.Color.Black
        Me.btnQuickUndo.Image = CType(resources.GetObject("btnQuickUndo.Image"), System.Drawing.Image)
        Me.btnQuickUndo.Location = New System.Drawing.Point(672, 0)
        Me.btnQuickUndo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuickUndo.Name = "btnQuickUndo"
        Me.btnQuickUndo.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnQuickUndo.Size = New System.Drawing.Size(25, 25)
        Me.btnQuickUndo.Style = resources.GetString("btnQuickUndo.Style")
        Me.btnQuickUndo.TabIndex = 96
        Me.ttMain.SetToolTip(Me.btnQuickUndo, "Undo")
        Me.btnQuickUndo.UseCompatibleTextRendering = True
        Me.btnQuickUndo.UseVisualStyleBackColor = False
        '
        'btnQuickSymbols
        '
        Me.btnQuickSymbols.BackColor = System.Drawing.Color.Transparent
        Me.btnQuickSymbols.BackgroundImage = CType(resources.GetObject("btnQuickSymbols.BackgroundImage"), System.Drawing.Image)
        Me.btnQuickSymbols.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnQuickSymbols.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuickSymbols.FlatAppearance.BorderSize = 0
        Me.btnQuickSymbols.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnQuickSymbols.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuickSymbols.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuickSymbols.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickSymbols.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickSymbols.ForeColor = System.Drawing.Color.Black
        Me.btnQuickSymbols.Image = CType(resources.GetObject("btnQuickSymbols.Image"), System.Drawing.Image)
        Me.btnQuickSymbols.Location = New System.Drawing.Point(723, 0)
        Me.btnQuickSymbols.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuickSymbols.Name = "btnQuickSymbols"
        Me.btnQuickSymbols.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnQuickSymbols.Size = New System.Drawing.Size(25, 25)
        Me.btnQuickSymbols.Style = resources.GetString("btnQuickSymbols.Style")
        Me.btnQuickSymbols.TabIndex = 98
        Me.ttMain.SetToolTip(Me.btnQuickSymbols, "Symbols")
        Me.btnQuickSymbols.UseCompatibleTextRendering = True
        Me.btnQuickSymbols.UseVisualStyleBackColor = False
        '
        'btnQuickAccents
        '
        Me.btnQuickAccents.BackColor = System.Drawing.Color.Transparent
        Me.btnQuickAccents.BackgroundImage = CType(resources.GetObject("btnQuickAccents.BackgroundImage"), System.Drawing.Image)
        Me.btnQuickAccents.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnQuickAccents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuickAccents.FlatAppearance.BorderSize = 0
        Me.btnQuickAccents.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnQuickAccents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuickAccents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuickAccents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickAccents.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickAccents.ForeColor = System.Drawing.Color.Black
        Me.btnQuickAccents.Image = CType(resources.GetObject("btnQuickAccents.Image"), System.Drawing.Image)
        Me.btnQuickAccents.Location = New System.Drawing.Point(748, 0)
        Me.btnQuickAccents.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuickAccents.Name = "btnQuickAccents"
        Me.btnQuickAccents.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnQuickAccents.Size = New System.Drawing.Size(25, 25)
        Me.btnQuickAccents.Style = resources.GetString("btnQuickAccents.Style")
        Me.btnQuickAccents.TabIndex = 99
        Me.ttMain.SetToolTip(Me.btnQuickAccents, "Accent Mark")
        Me.btnQuickAccents.UseCompatibleTextRendering = True
        Me.btnQuickAccents.UseVisualStyleBackColor = False
        '
        'btnQuickOpen
        '
        Me.btnQuickOpen.BackColor = System.Drawing.Color.Transparent
        Me.btnQuickOpen.BackgroundImage = CType(resources.GetObject("btnQuickOpen.BackgroundImage"), System.Drawing.Image)
        Me.btnQuickOpen.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnQuickOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuickOpen.FlatAppearance.BorderSize = 0
        Me.btnQuickOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnQuickOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuickOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuickOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickOpen.ForeColor = System.Drawing.Color.Black
        Me.btnQuickOpen.Image = CType(resources.GetObject("btnQuickOpen.Image"), System.Drawing.Image)
        Me.btnQuickOpen.Location = New System.Drawing.Point(621, 0)
        Me.btnQuickOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuickOpen.Name = "btnQuickOpen"
        Me.btnQuickOpen.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnQuickOpen.Size = New System.Drawing.Size(25, 25)
        Me.btnQuickOpen.Style = resources.GetString("btnQuickOpen.Style")
        Me.btnQuickOpen.TabIndex = 94
        Me.ttMain.SetToolTip(Me.btnQuickOpen, "Open")
        Me.btnQuickOpen.UseCompatibleTextRendering = True
        Me.btnQuickOpen.UseVisualStyleBackColor = False
        '
        'btnQuickSave
        '
        Me.btnQuickSave.BackColor = System.Drawing.Color.Transparent
        Me.btnQuickSave.BackgroundImage = CType(resources.GetObject("btnQuickSave.BackgroundImage"), System.Drawing.Image)
        Me.btnQuickSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnQuickSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuickSave.FlatAppearance.BorderSize = 0
        Me.btnQuickSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnQuickSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuickSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuickSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickSave.ForeColor = System.Drawing.Color.Black
        Me.btnQuickSave.Image = CType(resources.GetObject("btnQuickSave.Image"), System.Drawing.Image)
        Me.btnQuickSave.Location = New System.Drawing.Point(646, 0)
        Me.btnQuickSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuickSave.Name = "btnQuickSave"
        Me.btnQuickSave.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnQuickSave.Size = New System.Drawing.Size(25, 25)
        Me.btnQuickSave.Style = resources.GetString("btnQuickSave.Style")
        Me.btnQuickSave.TabIndex = 95
        Me.ttMain.SetToolTip(Me.btnQuickSave, "Save")
        Me.btnQuickSave.UseCompatibleTextRendering = True
        Me.btnQuickSave.UseVisualStyleBackColor = False
        '
        'dlgSaveImage
        '
        Me.dlgSaveImage.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*"
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
        Me.pnlFindReplace.Location = New System.Drawing.Point(0, 246)
        Me.pnlFindReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlFindReplace.Name = "pnlFindReplace"
        Me.pnlFindReplace.Size = New System.Drawing.Size(977, 30)
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
        Me.btnFindNext.Image = CType(resources.GetObject("btnFindNext.Image"), System.Drawing.Image)
        Me.btnFindNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFindNext.Location = New System.Drawing.Point(390, 2)
        Me.btnFindNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnFindNext.Size = New System.Drawing.Size(88, 24)
        Me.btnFindNext.Style = resources.GetString("btnFindNext.Style")
        Me.btnFindNext.TabIndex = 69
        Me.btnFindNext.Text = "  Find Next"
        Me.btnFindNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFindNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.btnReplaceAll.Image = CType(resources.GetObject("btnReplaceAll.Image"), System.Drawing.Image)
        Me.btnReplaceAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReplaceAll.Location = New System.Drawing.Point(570, 2)
        Me.btnReplaceAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnReplaceAll.Size = New System.Drawing.Size(98, 24)
        Me.btnReplaceAll.Style = resources.GetString("btnReplaceAll.Style")
        Me.btnReplaceAll.TabIndex = 71
        Me.btnReplaceAll.Text = "  Replace All"
        Me.btnReplaceAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReplaceAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReplaceAll.UseCompatibleTextRendering = True
        Me.btnReplaceAll.UseVisualStyleBackColor = False
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(202, 5)
        Me.txtReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(112, 20)
        Me.txtReplace.TabIndex = 67
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(150, 8)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 13)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "Replace:"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(38, 5)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(108, 20)
        Me.txtFind.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(2, 8)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
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
        Me.btnReplace.Image = CType(resources.GetObject("btnReplace.Image"), System.Drawing.Image)
        Me.btnReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReplace.Location = New System.Drawing.Point(482, 2)
        Me.btnReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnReplace.Size = New System.Drawing.Size(84, 24)
        Me.btnReplace.Style = resources.GetString("btnReplace.Style")
        Me.btnReplace.TabIndex = 70
        Me.btnReplace.Text = "  Replace"
        Me.btnReplace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFind.Location = New System.Drawing.Point(318, 2)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnFind.Size = New System.Drawing.Size(68, 24)
        Me.btnFind.Style = resources.GetString("btnFind.Style")
        Me.btnFind.TabIndex = 68
        Me.btnFind.Text = "  Find"
        Me.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFind.UseCompatibleTextRendering = True
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.AutoScroll = True
        Me.pnlTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlTop.Controls.Add(Me.pnlControl)
        Me.pnlTop.Controls.Add(Me.pnlInsert)
        Me.pnlTop.Controls.Add(Me.pnlNotebook)
        Me.pnlTop.Controls.Add(Me.pnlLinguistics)
        Me.pnlTop.Controls.Add(Me.pnlMain)
        Me.pnlTop.Controls.Add(Me.pnlFile)
        Me.pnlTop.Controls.Add(Me.pnlTabs)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(977, 246)
        Me.pnlTop.Style = "Colors=~245|~245|~239" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|0.8|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Highlight Color=$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=1"
        Me.pnlTop.TabIndex = 12
        '
        'pnlControl
        '
        Me.pnlControl.AutoScroll = True
        Me.pnlControl.BackColor = System.Drawing.Color.Transparent
        Me.pnlControl.Controls.Add(Me.btnCustomZoom)
        Me.pnlControl.Controls.Add(Me.btnWordWrap)
        Me.pnlControl.Controls.Add(Me.btnSelectAll)
        Me.pnlControl.Controls.Add(Me.DoubleBufferedPanel14)
        Me.pnlControl.Controls.Add(Me.btnFindReplace)
        Me.pnlControl.Controls.Add(Me.Label15)
        Me.pnlControl.Controls.Add(Me.btnZoom100)
        Me.pnlControl.Controls.Add(Me.DoubleBufferedPanel13)
        Me.pnlControl.Controls.Add(Me.btnZoomOut)
        Me.pnlControl.Controls.Add(Me.btnZoomIn)
        Me.pnlControl.Controls.Add(Me.Label12)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControl.Location = New System.Drawing.Point(0, 430)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(960, 81)
        Me.pnlControl.TabIndex = 74
        Me.pnlControl.Visible = False
        '
        'btnCustomZoom
        '
        Me.btnCustomZoom.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomZoom.BackgroundImage = CType(resources.GetObject("btnCustomZoom.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomZoom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCustomZoom.FlatAppearance.BorderSize = 0
        Me.btnCustomZoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCustomZoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCustomZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomZoom.ForeColor = System.Drawing.Color.Black
        Me.btnCustomZoom.Image = CType(resources.GetObject("btnCustomZoom.Image"), System.Drawing.Image)
        Me.btnCustomZoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomZoom.Location = New System.Drawing.Point(94, 33)
        Me.btnCustomZoom.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomZoom.Name = "btnCustomZoom"
        Me.btnCustomZoom.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnCustomZoom.Size = New System.Drawing.Size(100, 26)
        Me.btnCustomZoom.Style = resources.GetString("btnCustomZoom.Style")
        Me.btnCustomZoom.TabIndex = 62
        Me.btnCustomZoom.Text = " Edit Zoom"
        Me.btnCustomZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomZoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomZoom.UseCompatibleTextRendering = True
        Me.btnCustomZoom.UseVisualStyleBackColor = False
        '
        'btnWordWrap
        '
        Me.btnWordWrap.BackColor = System.Drawing.Color.Transparent
        Me.btnWordWrap.BackgroundImage = CType(resources.GetObject("btnWordWrap.BackgroundImage"), System.Drawing.Image)
        Me.btnWordWrap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnWordWrap.FlatAppearance.BorderSize = 0
        Me.btnWordWrap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnWordWrap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnWordWrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWordWrap.ForeColor = System.Drawing.Color.Black
        Me.btnWordWrap.Image = CType(resources.GetObject("btnWordWrap.Image"), System.Drawing.Image)
        Me.btnWordWrap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWordWrap.Location = New System.Drawing.Point(314, 2)
        Me.btnWordWrap.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWordWrap.Name = "btnWordWrap"
        Me.btnWordWrap.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnWordWrap.Size = New System.Drawing.Size(106, 26)
        Me.btnWordWrap.Style = resources.GetString("btnWordWrap.Style")
        Me.btnWordWrap.TabIndex = 65
        Me.btnWordWrap.Text = " Word Wrap"
        Me.btnWordWrap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWordWrap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWordWrap.UseCompatibleTextRendering = True
        Me.btnWordWrap.UseVisualStyleBackColor = False
        '
        'btnSelectAll
        '
        Me.btnSelectAll.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectAll.BackgroundImage = CType(resources.GetObject("btnSelectAll.BackgroundImage"), System.Drawing.Image)
        Me.btnSelectAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSelectAll.FlatAppearance.BorderSize = 0
        Me.btnSelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectAll.ForeColor = System.Drawing.Color.Black
        Me.btnSelectAll.Image = CType(resources.GetObject("btnSelectAll.Image"), System.Drawing.Image)
        Me.btnSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectAll.Location = New System.Drawing.Point(204, 33)
        Me.btnSelectAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnSelectAll.Size = New System.Drawing.Size(106, 26)
        Me.btnSelectAll.Style = resources.GetString("btnSelectAll.Style")
        Me.btnSelectAll.TabIndex = 64
        Me.btnSelectAll.Text = " Select All"
        Me.btnSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSelectAll.UseCompatibleTextRendering = True
        Me.btnSelectAll.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel14
        '
        Me.DoubleBufferedPanel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel14.Location = New System.Drawing.Point(422, 7)
        Me.DoubleBufferedPanel14.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel14.Name = "DoubleBufferedPanel14"
        Me.DoubleBufferedPanel14.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel14.TabIndex = 61
        '
        'btnFindReplace
        '
        Me.btnFindReplace.BackColor = System.Drawing.Color.Transparent
        Me.btnFindReplace.BackgroundImage = CType(resources.GetObject("btnFindReplace.BackgroundImage"), System.Drawing.Image)
        Me.btnFindReplace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFindReplace.FlatAppearance.BorderSize = 0
        Me.btnFindReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFindReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFindReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindReplace.ForeColor = System.Drawing.Color.Black
        Me.btnFindReplace.Image = CType(resources.GetObject("btnFindReplace.Image"), System.Drawing.Image)
        Me.btnFindReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFindReplace.Location = New System.Drawing.Point(204, 2)
        Me.btnFindReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFindReplace.Name = "btnFindReplace"
        Me.btnFindReplace.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnFindReplace.Size = New System.Drawing.Size(106, 26)
        Me.btnFindReplace.Style = resources.GetString("btnFindReplace.Style")
        Me.btnFindReplace.TabIndex = 63
        Me.btnFindReplace.Text = " Find/Replace"
        Me.btnFindReplace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFindReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFindReplace.UseCompatibleTextRendering = True
        Me.btnFindReplace.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Gray
        Me.Label15.Location = New System.Drawing.Point(202, 60)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(218, 19)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Editing"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnZoom100
        '
        Me.btnZoom100.BackColor = System.Drawing.Color.Transparent
        Me.btnZoom100.BackgroundImage = CType(resources.GetObject("btnZoom100.BackgroundImage"), System.Drawing.Image)
        Me.btnZoom100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnZoom100.FlatAppearance.BorderSize = 0
        Me.btnZoom100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnZoom100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnZoom100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoom100.ForeColor = System.Drawing.Color.Black
        Me.btnZoom100.Image = CType(resources.GetObject("btnZoom100.Image"), System.Drawing.Image)
        Me.btnZoom100.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZoom100.Location = New System.Drawing.Point(94, 2)
        Me.btnZoom100.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZoom100.Name = "btnZoom100"
        Me.btnZoom100.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnZoom100.Size = New System.Drawing.Size(100, 26)
        Me.btnZoom100.Style = resources.GetString("btnZoom100.Style")
        Me.btnZoom100.TabIndex = 61
        Me.btnZoom100.Text = " 100% Zoom"
        Me.btnZoom100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZoom100.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnZoom100.UseCompatibleTextRendering = True
        Me.btnZoom100.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel13
        '
        Me.DoubleBufferedPanel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel13.Location = New System.Drawing.Point(200, 7)
        Me.DoubleBufferedPanel13.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel13.Name = "DoubleBufferedPanel13"
        Me.DoubleBufferedPanel13.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel13.TabIndex = 51
        '
        'btnZoomOut
        '
        Me.btnZoomOut.BackColor = System.Drawing.Color.Transparent
        Me.btnZoomOut.BackgroundImage = CType(resources.GetObject("btnZoomOut.BackgroundImage"), System.Drawing.Image)
        Me.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnZoomOut.FlatAppearance.BorderSize = 0
        Me.btnZoomOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomOut.ForeColor = System.Drawing.Color.Black
        Me.btnZoomOut.Image = CType(resources.GetObject("btnZoomOut.Image"), System.Drawing.Image)
        Me.btnZoomOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZoomOut.Location = New System.Drawing.Point(4, 33)
        Me.btnZoomOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnZoomOut.Size = New System.Drawing.Size(86, 26)
        Me.btnZoomOut.Style = resources.GetString("btnZoomOut.Style")
        Me.btnZoomOut.TabIndex = 60
        Me.btnZoomOut.Text = " Zoom Out"
        Me.btnZoomOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnZoomOut.UseCompatibleTextRendering = True
        Me.btnZoomOut.UseVisualStyleBackColor = False
        '
        'btnZoomIn
        '
        Me.btnZoomIn.BackColor = System.Drawing.Color.Transparent
        Me.btnZoomIn.BackgroundImage = CType(resources.GetObject("btnZoomIn.BackgroundImage"), System.Drawing.Image)
        Me.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnZoomIn.FlatAppearance.BorderSize = 0
        Me.btnZoomIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomIn.ForeColor = System.Drawing.Color.Black
        Me.btnZoomIn.Image = CType(resources.GetObject("btnZoomIn.Image"), System.Drawing.Image)
        Me.btnZoomIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZoomIn.Location = New System.Drawing.Point(4, 2)
        Me.btnZoomIn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnZoomIn.Size = New System.Drawing.Size(86, 26)
        Me.btnZoomIn.Style = resources.GetString("btnZoomIn.Style")
        Me.btnZoomIn.TabIndex = 59
        Me.btnZoomIn.Text = " Zoom In"
        Me.btnZoomIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnZoomIn.UseCompatibleTextRendering = True
        Me.btnZoomIn.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Gray
        Me.Label12.Location = New System.Drawing.Point(4, 60)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(190, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Zoom"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlInsert
        '
        Me.pnlInsert.AutoScroll = True
        Me.pnlInsert.BackColor = System.Drawing.Color.Transparent
        Me.pnlInsert.Controls.Add(Me.btnEdit)
        Me.pnlInsert.Controls.Add(Me.DoubleBufferedPanel20)
        Me.pnlInsert.Controls.Add(Me.btnApply)
        Me.pnlInsert.Controls.Add(Me.btnDefault)
        Me.pnlInsert.Controls.Add(Me.Label13)
        Me.pnlInsert.Controls.Add(Me.btnTable)
        Me.pnlInsert.Controls.Add(Me.DoubleBufferedPanel12)
        Me.pnlInsert.Controls.Add(Me.btnTextArt)
        Me.pnlInsert.Controls.Add(Me.Label14)
        Me.pnlInsert.Controls.Add(Me.btnClipArt)
        Me.pnlInsert.Controls.Add(Me.btnEmojis)
        Me.pnlInsert.Controls.Add(Me.btnWebcam)
        Me.pnlInsert.Controls.Add(Me.DoubleBufferedPanel8)
        Me.pnlInsert.Controls.Add(Me.btnImportFile)
        Me.pnlInsert.Controls.Add(Me.Label9)
        Me.pnlInsert.Controls.Add(Me.DoubleBufferedPanel9)
        Me.pnlInsert.Controls.Add(Me.btnRemoveBullets)
        Me.pnlInsert.Controls.Add(Me.btnAddBullets)
        Me.pnlInsert.Controls.Add(Me.Label10)
        Me.pnlInsert.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInsert.Location = New System.Drawing.Point(0, 349)
        Me.pnlInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlInsert.Name = "pnlInsert"
        Me.pnlInsert.Size = New System.Drawing.Size(960, 81)
        Me.pnlInsert.TabIndex = 73
        Me.pnlInsert.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(428, 32)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnEdit.Size = New System.Drawing.Size(86, 26)
        Me.btnEdit.Style = resources.GetString("btnEdit.Style")
        Me.btnEdit.TabIndex = 60
        Me.btnEdit.Text = " Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseCompatibleTextRendering = True
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel20
        '
        Me.DoubleBufferedPanel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DoubleBufferedPanel20.Location = New System.Drawing.Point(608, 7)
        Me.DoubleBufferedPanel20.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel20.Name = "DoubleBufferedPanel20"
        Me.DoubleBufferedPanel20.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel20.TabIndex = 97
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Transparent
        Me.btnApply.BackgroundImage = CType(resources.GetObject("btnApply.BackgroundImage"), System.Drawing.Image)
        Me.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApply.FlatAppearance.BorderSize = 0
        Me.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.ForeColor = System.Drawing.Color.Black
        Me.btnApply.Image = CType(resources.GetObject("btnApply.Image"), System.Drawing.Image)
        Me.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApply.Location = New System.Drawing.Point(518, 2)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(2)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnApply.Size = New System.Drawing.Size(86, 26)
        Me.btnApply.Style = resources.GetString("btnApply.Style")
        Me.btnApply.TabIndex = 61
        Me.btnApply.Text = " Apply"
        Me.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApply.UseCompatibleTextRendering = True
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnDefault
        '
        Me.btnDefault.BackColor = System.Drawing.Color.Transparent
        Me.btnDefault.BackgroundImage = CType(resources.GetObject("btnDefault.BackgroundImage"), System.Drawing.Image)
        Me.btnDefault.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDefault.FlatAppearance.BorderSize = 0
        Me.btnDefault.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefault.ForeColor = System.Drawing.Color.Black
        Me.btnDefault.Image = CType(resources.GetObject("btnDefault.Image"), System.Drawing.Image)
        Me.btnDefault.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDefault.Location = New System.Drawing.Point(428, 2)
        Me.btnDefault.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnDefault.Size = New System.Drawing.Size(86, 26)
        Me.btnDefault.Style = resources.GetString("btnDefault.Style")
        Me.btnDefault.TabIndex = 59
        Me.btnDefault.Text = " Default"
        Me.btnDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDefault.UseCompatibleTextRendering = True
        Me.btnDefault.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(427, 60)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 19)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Style"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTable
        '
        Me.btnTable.BackColor = System.Drawing.Color.Transparent
        Me.btnTable.BackgroundImage = CType(resources.GetObject("btnTable.BackgroundImage"), System.Drawing.Image)
        Me.btnTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTable.FlatAppearance.BorderSize = 0
        Me.btnTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTable.ForeColor = System.Drawing.Color.Black
        Me.btnTable.Image = CType(resources.GetObject("btnTable.Image"), System.Drawing.Image)
        Me.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTable.Location = New System.Drawing.Point(341, 33)
        Me.btnTable.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnTable.Size = New System.Drawing.Size(76, 26)
        Me.btnTable.Style = resources.GetString("btnTable.Style")
        Me.btnTable.TabIndex = 58
        Me.btnTable.Text = " Table"
        Me.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTable.UseCompatibleTextRendering = True
        Me.btnTable.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel12
        '
        Me.DoubleBufferedPanel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel12.Location = New System.Drawing.Point(423, 7)
        Me.DoubleBufferedPanel12.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel12.Name = "DoubleBufferedPanel12"
        Me.DoubleBufferedPanel12.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel12.TabIndex = 83
        '
        'btnTextArt
        '
        Me.btnTextArt.BackColor = System.Drawing.Color.Transparent
        Me.btnTextArt.BackgroundImage = CType(resources.GetObject("btnTextArt.BackgroundImage"), System.Drawing.Image)
        Me.btnTextArt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTextArt.FlatAppearance.BorderSize = 0
        Me.btnTextArt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTextArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTextArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTextArt.ForeColor = System.Drawing.Color.Black
        Me.btnTextArt.Image = CType(resources.GetObject("btnTextArt.Image"), System.Drawing.Image)
        Me.btnTextArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTextArt.Location = New System.Drawing.Point(341, 2)
        Me.btnTextArt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTextArt.Name = "btnTextArt"
        Me.btnTextArt.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnTextArt.Size = New System.Drawing.Size(76, 26)
        Me.btnTextArt.Style = resources.GetString("btnTextArt.Style")
        Me.btnTextArt.TabIndex = 57
        Me.btnTextArt.Text = " Text Art"
        Me.btnTextArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTextArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTextArt.UseCompatibleTextRendering = True
        Me.btnTextArt.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(341, 60)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 19)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Graphics"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClipArt
        '
        Me.btnClipArt.BackColor = System.Drawing.Color.Transparent
        Me.btnClipArt.BackgroundImage = CType(resources.GetObject("btnClipArt.BackgroundImage"), System.Drawing.Image)
        Me.btnClipArt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClipArt.FlatAppearance.BorderSize = 0
        Me.btnClipArt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClipArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClipArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClipArt.ForeColor = System.Drawing.Color.Black
        Me.btnClipArt.Image = CType(resources.GetObject("btnClipArt.Image"), System.Drawing.Image)
        Me.btnClipArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClipArt.Location = New System.Drawing.Point(246, 32)
        Me.btnClipArt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClipArt.Name = "btnClipArt"
        Me.btnClipArt.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnClipArt.Size = New System.Drawing.Size(86, 26)
        Me.btnClipArt.Style = resources.GetString("btnClipArt.Style")
        Me.btnClipArt.TabIndex = 56
        Me.btnClipArt.Text = " Clip Art"
        Me.btnClipArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClipArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClipArt.UseCompatibleTextRendering = True
        Me.btnClipArt.UseVisualStyleBackColor = False
        '
        'btnEmojis
        '
        Me.btnEmojis.BackColor = System.Drawing.Color.Transparent
        Me.btnEmojis.BackgroundImage = CType(resources.GetObject("btnEmojis.BackgroundImage"), System.Drawing.Image)
        Me.btnEmojis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEmojis.FlatAppearance.BorderSize = 0
        Me.btnEmojis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEmojis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEmojis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmojis.ForeColor = System.Drawing.Color.Black
        Me.btnEmojis.Image = CType(resources.GetObject("btnEmojis.Image"), System.Drawing.Image)
        Me.btnEmojis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmojis.Location = New System.Drawing.Point(246, 2)
        Me.btnEmojis.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEmojis.Name = "btnEmojis"
        Me.btnEmojis.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnEmojis.Size = New System.Drawing.Size(86, 26)
        Me.btnEmojis.Style = resources.GetString("btnEmojis.Style")
        Me.btnEmojis.TabIndex = 55
        Me.btnEmojis.Text = " Emotes"
        Me.btnEmojis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmojis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmojis.UseCompatibleTextRendering = True
        Me.btnEmojis.UseVisualStyleBackColor = False
        '
        'btnWebcam
        '
        Me.btnWebcam.BackColor = System.Drawing.Color.Transparent
        Me.btnWebcam.BackgroundImage = CType(resources.GetObject("btnWebcam.BackgroundImage"), System.Drawing.Image)
        Me.btnWebcam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnWebcam.FlatAppearance.BorderSize = 0
        Me.btnWebcam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnWebcam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnWebcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWebcam.ForeColor = System.Drawing.Color.Black
        Me.btnWebcam.Image = CType(resources.GetObject("btnWebcam.Image"), System.Drawing.Image)
        Me.btnWebcam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWebcam.Location = New System.Drawing.Point(139, 33)
        Me.btnWebcam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWebcam.Name = "btnWebcam"
        Me.btnWebcam.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnWebcam.Size = New System.Drawing.Size(103, 26)
        Me.btnWebcam.Style = resources.GetString("btnWebcam.Style")
        Me.btnWebcam.TabIndex = 54
        Me.btnWebcam.Text = " Webcam"
        Me.btnWebcam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWebcam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWebcam.UseCompatibleTextRendering = True
        Me.btnWebcam.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel8
        '
        Me.DoubleBufferedPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel8.Location = New System.Drawing.Point(336, 7)
        Me.DoubleBufferedPanel8.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel8.Name = "DoubleBufferedPanel8"
        Me.DoubleBufferedPanel8.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel8.TabIndex = 55
        '
        'btnImportFile
        '
        Me.btnImportFile.BackColor = System.Drawing.Color.Transparent
        Me.btnImportFile.BackgroundImage = CType(resources.GetObject("btnImportFile.BackgroundImage"), System.Drawing.Image)
        Me.btnImportFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImportFile.FlatAppearance.BorderSize = 0
        Me.btnImportFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnImportFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnImportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportFile.ForeColor = System.Drawing.Color.Black
        Me.btnImportFile.Image = CType(resources.GetObject("btnImportFile.Image"), System.Drawing.Image)
        Me.btnImportFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportFile.Location = New System.Drawing.Point(139, 2)
        Me.btnImportFile.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImportFile.Name = "btnImportFile"
        Me.btnImportFile.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnImportFile.Size = New System.Drawing.Size(103, 26)
        Me.btnImportFile.Style = resources.GetString("btnImportFile.Style")
        Me.btnImportFile.TabIndex = 53
        Me.btnImportFile.Text = " Import File"
        Me.btnImportFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportFile.UseCompatibleTextRendering = True
        Me.btnImportFile.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(139, 60)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(198, 19)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Image"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DoubleBufferedPanel9
        '
        Me.DoubleBufferedPanel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel9.Location = New System.Drawing.Point(134, 7)
        Me.DoubleBufferedPanel9.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel9.Name = "DoubleBufferedPanel9"
        Me.DoubleBufferedPanel9.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel9.TabIndex = 51
        '
        'btnRemoveBullets
        '
        Me.btnRemoveBullets.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveBullets.BackgroundImage = CType(resources.GetObject("btnRemoveBullets.BackgroundImage"), System.Drawing.Image)
        Me.btnRemoveBullets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemoveBullets.FlatAppearance.BorderSize = 0
        Me.btnRemoveBullets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRemoveBullets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRemoveBullets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveBullets.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveBullets.Image = CType(resources.GetObject("btnRemoveBullets.Image"), System.Drawing.Image)
        Me.btnRemoveBullets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveBullets.Location = New System.Drawing.Point(4, 33)
        Me.btnRemoveBullets.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemoveBullets.Name = "btnRemoveBullets"
        Me.btnRemoveBullets.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnRemoveBullets.Size = New System.Drawing.Size(124, 26)
        Me.btnRemoveBullets.Style = resources.GetString("btnRemoveBullets.Style")
        Me.btnRemoveBullets.TabIndex = 52
        Me.btnRemoveBullets.Text = " Remove Bullets"
        Me.btnRemoveBullets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveBullets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemoveBullets.UseCompatibleTextRendering = True
        Me.btnRemoveBullets.UseVisualStyleBackColor = False
        '
        'btnAddBullets
        '
        Me.btnAddBullets.BackColor = System.Drawing.Color.Transparent
        Me.btnAddBullets.BackgroundImage = CType(resources.GetObject("btnAddBullets.BackgroundImage"), System.Drawing.Image)
        Me.btnAddBullets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddBullets.FlatAppearance.BorderSize = 0
        Me.btnAddBullets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddBullets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddBullets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBullets.ForeColor = System.Drawing.Color.Black
        Me.btnAddBullets.Image = CType(resources.GetObject("btnAddBullets.Image"), System.Drawing.Image)
        Me.btnAddBullets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBullets.Location = New System.Drawing.Point(4, 2)
        Me.btnAddBullets.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddBullets.Name = "btnAddBullets"
        Me.btnAddBullets.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnAddBullets.Size = New System.Drawing.Size(124, 26)
        Me.btnAddBullets.Style = resources.GetString("btnAddBullets.Style")
        Me.btnAddBullets.TabIndex = 51
        Me.btnAddBullets.Text = " Insert Bullets"
        Me.btnAddBullets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBullets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddBullets.UseCompatibleTextRendering = True
        Me.btnAddBullets.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(4, 60)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Bullets"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlNotebook
        '
        Me.pnlNotebook.AutoScroll = True
        Me.pnlNotebook.BackColor = System.Drawing.Color.Transparent
        Me.pnlNotebook.Controls.Add(Me.DoubleBufferedPanel23)
        Me.pnlNotebook.Controls.Add(Me.lblDictionary)
        Me.pnlNotebook.Controls.Add(Me.StylizedButton1)
        Me.pnlNotebook.Controls.Add(Me.btnDuplicate)
        Me.pnlNotebook.Controls.Add(Me.btnExportPage)
        Me.pnlNotebook.Controls.Add(Me.btnImportPage)
        Me.pnlNotebook.Controls.Add(Me.btnRenamePage)
        Me.pnlNotebook.Controls.Add(Me.DoubleBufferedPanel18)
        Me.pnlNotebook.Controls.Add(Me.btnNotebookEditor)
        Me.pnlNotebook.Controls.Add(Me.DoubleBufferedPanel19)
        Me.pnlNotebook.Controls.Add(Me.btnRemove)
        Me.pnlNotebook.Controls.Add(Me.Label20)
        Me.pnlNotebook.Controls.Add(Me.btnAdd)
        Me.pnlNotebook.Controls.Add(Me.Label22)
        Me.pnlNotebook.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNotebook.Location = New System.Drawing.Point(0, 268)
        Me.pnlNotebook.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlNotebook.Name = "pnlNotebook"
        Me.pnlNotebook.Size = New System.Drawing.Size(960, 81)
        Me.pnlNotebook.TabIndex = 76
        Me.pnlNotebook.Visible = False
        '
        'DoubleBufferedPanel23
        '
        Me.DoubleBufferedPanel23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel23.Location = New System.Drawing.Point(603, 7)
        Me.DoubleBufferedPanel23.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel23.Name = "DoubleBufferedPanel23"
        Me.DoubleBufferedPanel23.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel23.TabIndex = 84
        '
        'lblDictionary
        '
        Me.lblDictionary.BackColor = System.Drawing.Color.Transparent
        Me.lblDictionary.ForeColor = System.Drawing.Color.Gray
        Me.lblDictionary.Location = New System.Drawing.Point(498, 58)
        Me.lblDictionary.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDictionary.Name = "lblDictionary"
        Me.lblDictionary.Size = New System.Drawing.Size(101, 19)
        Me.lblDictionary.TabIndex = 85
        Me.lblDictionary.Text = "Dictionary"
        Me.lblDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StylizedButton1
        '
        Me.StylizedButton1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedButton1.BackgroundImage = CType(resources.GetObject("StylizedButton1.BackgroundImage"), System.Drawing.Image)
        Me.StylizedButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StylizedButton1.FlatAppearance.BorderSize = 0
        Me.StylizedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StylizedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StylizedButton1.ForeColor = System.Drawing.Color.Black
        Me.StylizedButton1.Image = CType(resources.GetObject("StylizedButton1.Image"), System.Drawing.Image)
        Me.StylizedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StylizedButton1.Location = New System.Drawing.Point(501, 2)
        Me.StylizedButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedButton1.Name = "StylizedButton1"
        Me.StylizedButton1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.StylizedButton1.Size = New System.Drawing.Size(98, 26)
        Me.StylizedButton1.Style = resources.GetString("StylizedButton1.Style")
        Me.StylizedButton1.TabIndex = 52
        Me.StylizedButton1.Text = " Editor"
        Me.StylizedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StylizedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.StylizedButton1.UseCompatibleTextRendering = True
        Me.StylizedButton1.UseVisualStyleBackColor = False
        '
        'btnDuplicate
        '
        Me.btnDuplicate.BackColor = System.Drawing.Color.Transparent
        Me.btnDuplicate.BackgroundImage = CType(resources.GetObject("btnDuplicate.BackgroundImage"), System.Drawing.Image)
        Me.btnDuplicate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDuplicate.FlatAppearance.BorderSize = 0
        Me.btnDuplicate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDuplicate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuplicate.ForeColor = System.Drawing.Color.Black
        Me.btnDuplicate.Image = CType(resources.GetObject("btnDuplicate.Image"), System.Drawing.Image)
        Me.btnDuplicate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDuplicate.Location = New System.Drawing.Point(262, 2)
        Me.btnDuplicate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnDuplicate.Size = New System.Drawing.Size(124, 26)
        Me.btnDuplicate.Style = resources.GetString("btnDuplicate.Style")
        Me.btnDuplicate.TabIndex = 49
        Me.btnDuplicate.Text = " Duplicate Page"
        Me.btnDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDuplicate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDuplicate.UseCompatibleTextRendering = True
        Me.btnDuplicate.UseVisualStyleBackColor = False
        '
        'btnExportPage
        '
        Me.btnExportPage.BackColor = System.Drawing.Color.Transparent
        Me.btnExportPage.BackgroundImage = CType(resources.GetObject("btnExportPage.BackgroundImage"), System.Drawing.Image)
        Me.btnExportPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExportPage.FlatAppearance.BorderSize = 0
        Me.btnExportPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExportPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExportPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportPage.ForeColor = System.Drawing.Color.Black
        Me.btnExportPage.Image = CType(resources.GetObject("btnExportPage.Image"), System.Drawing.Image)
        Me.btnExportPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportPage.Location = New System.Drawing.Point(134, 33)
        Me.btnExportPage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportPage.Name = "btnExportPage"
        Me.btnExportPage.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnExportPage.Size = New System.Drawing.Size(124, 26)
        Me.btnExportPage.Style = resources.GetString("btnExportPage.Style")
        Me.btnExportPage.TabIndex = 48
        Me.btnExportPage.Text = " Export Page"
        Me.btnExportPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportPage.UseCompatibleTextRendering = True
        Me.btnExportPage.UseVisualStyleBackColor = False
        '
        'btnImportPage
        '
        Me.btnImportPage.BackColor = System.Drawing.Color.Transparent
        Me.btnImportPage.BackgroundImage = CType(resources.GetObject("btnImportPage.BackgroundImage"), System.Drawing.Image)
        Me.btnImportPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImportPage.FlatAppearance.BorderSize = 0
        Me.btnImportPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnImportPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnImportPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportPage.ForeColor = System.Drawing.Color.Black
        Me.btnImportPage.Image = CType(resources.GetObject("btnImportPage.Image"), System.Drawing.Image)
        Me.btnImportPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportPage.Location = New System.Drawing.Point(134, 2)
        Me.btnImportPage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImportPage.Name = "btnImportPage"
        Me.btnImportPage.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnImportPage.Size = New System.Drawing.Size(124, 26)
        Me.btnImportPage.Style = resources.GetString("btnImportPage.Style")
        Me.btnImportPage.TabIndex = 47
        Me.btnImportPage.Text = " Import Page"
        Me.btnImportPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportPage.UseCompatibleTextRendering = True
        Me.btnImportPage.UseVisualStyleBackColor = False
        '
        'btnRenamePage
        '
        Me.btnRenamePage.BackColor = System.Drawing.Color.Transparent
        Me.btnRenamePage.BackgroundImage = CType(resources.GetObject("btnRenamePage.BackgroundImage"), System.Drawing.Image)
        Me.btnRenamePage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRenamePage.FlatAppearance.BorderSize = 0
        Me.btnRenamePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRenamePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRenamePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRenamePage.ForeColor = System.Drawing.Color.Black
        Me.btnRenamePage.Image = CType(resources.GetObject("btnRenamePage.Image"), System.Drawing.Image)
        Me.btnRenamePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRenamePage.Location = New System.Drawing.Point(262, 33)
        Me.btnRenamePage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRenamePage.Name = "btnRenamePage"
        Me.btnRenamePage.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnRenamePage.Size = New System.Drawing.Size(124, 26)
        Me.btnRenamePage.Style = resources.GetString("btnRenamePage.Style")
        Me.btnRenamePage.TabIndex = 50
        Me.btnRenamePage.Text = " Rename Page"
        Me.btnRenamePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRenamePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRenamePage.UseCompatibleTextRendering = True
        Me.btnRenamePage.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel18
        '
        Me.DoubleBufferedPanel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel18.Location = New System.Drawing.Point(496, 7)
        Me.DoubleBufferedPanel18.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel18.Name = "DoubleBufferedPanel18"
        Me.DoubleBufferedPanel18.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel18.TabIndex = 83
        '
        'btnNotebookEditor
        '
        Me.btnNotebookEditor.BackColor = System.Drawing.Color.Transparent
        Me.btnNotebookEditor.BackgroundImage = CType(resources.GetObject("btnNotebookEditor.BackgroundImage"), System.Drawing.Image)
        Me.btnNotebookEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotebookEditor.FlatAppearance.BorderSize = 0
        Me.btnNotebookEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNotebookEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNotebookEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotebookEditor.ForeColor = System.Drawing.Color.Black
        Me.btnNotebookEditor.Image = CType(resources.GetObject("btnNotebookEditor.Image"), System.Drawing.Image)
        Me.btnNotebookEditor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotebookEditor.Location = New System.Drawing.Point(394, 2)
        Me.btnNotebookEditor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNotebookEditor.Name = "btnNotebookEditor"
        Me.btnNotebookEditor.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnNotebookEditor.Size = New System.Drawing.Size(98, 26)
        Me.btnNotebookEditor.Style = resources.GetString("btnNotebookEditor.Style")
        Me.btnNotebookEditor.TabIndex = 51
        Me.btnNotebookEditor.Text = " Editor"
        Me.btnNotebookEditor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotebookEditor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNotebookEditor.UseCompatibleTextRendering = True
        Me.btnNotebookEditor.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel19
        '
        Me.DoubleBufferedPanel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel19.Location = New System.Drawing.Point(390, 7)
        Me.DoubleBufferedPanel19.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel19.Name = "DoubleBufferedPanel19"
        Me.DoubleBufferedPanel19.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel19.TabIndex = 55
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.BackgroundImage = CType(resources.GetObject("btnRemove.BackgroundImage"), System.Drawing.Image)
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.Location = New System.Drawing.Point(4, 33)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnRemove.Size = New System.Drawing.Size(124, 26)
        Me.btnRemove.Style = resources.GetString("btnRemove.Style")
        Me.btnRemove.TabIndex = 46
        Me.btnRemove.Text = " Remove Page"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemove.UseCompatibleTextRendering = True
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Gray
        Me.Label20.Location = New System.Drawing.Point(392, 58)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 19)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = " Notebook"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(4, 2)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnAdd.Size = New System.Drawing.Size(124, 26)
        Me.btnAdd.Style = resources.GetString("btnAdd.Style")
        Me.btnAdd.TabIndex = 45
        Me.btnAdd.Text = " Add Page"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseCompatibleTextRendering = True
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.ForeColor = System.Drawing.Color.Gray
        Me.Label22.Location = New System.Drawing.Point(4, 60)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(386, 19)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Page"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLinguistics
        '
        Me.pnlLinguistics.AutoScroll = True
        Me.pnlLinguistics.BackColor = System.Drawing.Color.Transparent
        Me.pnlLinguistics.Controls.Add(Me.nudSpeed)
        Me.pnlLinguistics.Controls.Add(Me.btnSaveSpeech)
        Me.pnlLinguistics.Controls.Add(Me.btnStop)
        Me.pnlLinguistics.Controls.Add(Me.btnPlay)
        Me.pnlLinguistics.Controls.Add(Me.cbVoice)
        Me.pnlLinguistics.Controls.Add(Me.btnCustomSymbols)
        Me.pnlLinguistics.Controls.Add(Me.DoubleBufferedPanel2)
        Me.pnlLinguistics.Controls.Add(Me.Label6)
        Me.pnlLinguistics.Controls.Add(Me.DoubleBufferedPanel10)
        Me.pnlLinguistics.Controls.Add(Me.btnAccentMark)
        Me.pnlLinguistics.Controls.Add(Me.btnSymbols)
        Me.pnlLinguistics.Controls.Add(Me.Label8)
        Me.pnlLinguistics.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLinguistics.Location = New System.Drawing.Point(0, 187)
        Me.pnlLinguistics.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLinguistics.Name = "pnlLinguistics"
        Me.pnlLinguistics.Size = New System.Drawing.Size(960, 81)
        Me.pnlLinguistics.TabIndex = 72
        Me.pnlLinguistics.Visible = False
        '
        'nudSpeed
        '
        Me.nudSpeed.Location = New System.Drawing.Point(396, 6)
        Me.nudSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.nudSpeed.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudSpeed.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nudSpeed.Name = "nudSpeed"
        Me.nudSpeed.Size = New System.Drawing.Size(52, 20)
        Me.nudSpeed.TabIndex = 41
        Me.nudSpeed.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'cbVoice
        '
        Me.cbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbVoice.FormattingEnabled = True
        Me.cbVoice.Location = New System.Drawing.Point(252, 6)
        Me.cbVoice.Margin = New System.Windows.Forms.Padding(2)
        Me.cbVoice.Name = "cbVoice"
        Me.cbVoice.Size = New System.Drawing.Size(140, 21)
        Me.cbVoice.TabIndex = 40
        '
        'btnCustomSymbols
        '
        Me.btnCustomSymbols.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomSymbols.BackgroundImage = CType(resources.GetObject("btnCustomSymbols.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomSymbols.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCustomSymbols.FlatAppearance.BorderSize = 0
        Me.btnCustomSymbols.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCustomSymbols.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCustomSymbols.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomSymbols.ForeColor = System.Drawing.Color.Black
        Me.btnCustomSymbols.Image = CType(resources.GetObject("btnCustomSymbols.Image"), System.Drawing.Image)
        Me.btnCustomSymbols.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomSymbols.Location = New System.Drawing.Point(108, 2)
        Me.btnCustomSymbols.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomSymbols.Name = "btnCustomSymbols"
        Me.btnCustomSymbols.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnCustomSymbols.Size = New System.Drawing.Size(134, 26)
        Me.btnCustomSymbols.Style = resources.GetString("btnCustomSymbols.Style")
        Me.btnCustomSymbols.TabIndex = 39
        Me.btnCustomSymbols.Text = " Custom Symbols"
        Me.btnCustomSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomSymbols.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomSymbols.UseCompatibleTextRendering = True
        Me.btnCustomSymbols.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel2
        '
        Me.DoubleBufferedPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel2.Location = New System.Drawing.Point(452, 7)
        Me.DoubleBufferedPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel2.Name = "DoubleBufferedPanel2"
        Me.DoubleBufferedPanel2.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel2.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(250, 60)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 19)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Narration"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DoubleBufferedPanel10
        '
        Me.DoubleBufferedPanel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel10.Location = New System.Drawing.Point(248, 7)
        Me.DoubleBufferedPanel10.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel10.Name = "DoubleBufferedPanel10"
        Me.DoubleBufferedPanel10.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel10.TabIndex = 51
        '
        'btnAccentMark
        '
        Me.btnAccentMark.BackColor = System.Drawing.Color.Transparent
        Me.btnAccentMark.BackgroundImage = CType(resources.GetObject("btnAccentMark.BackgroundImage"), System.Drawing.Image)
        Me.btnAccentMark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAccentMark.FlatAppearance.BorderSize = 0
        Me.btnAccentMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAccentMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAccentMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccentMark.ForeColor = System.Drawing.Color.Black
        Me.btnAccentMark.Image = CType(resources.GetObject("btnAccentMark.Image"), System.Drawing.Image)
        Me.btnAccentMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccentMark.Location = New System.Drawing.Point(4, 33)
        Me.btnAccentMark.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAccentMark.Name = "btnAccentMark"
        Me.btnAccentMark.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnAccentMark.Size = New System.Drawing.Size(98, 26)
        Me.btnAccentMark.Style = resources.GetString("btnAccentMark.Style")
        Me.btnAccentMark.TabIndex = 38
        Me.btnAccentMark.Text = " Accent Mark"
        Me.btnAccentMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccentMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccentMark.UseCompatibleTextRendering = True
        Me.btnAccentMark.UseVisualStyleBackColor = False
        '
        'btnSymbols
        '
        Me.btnSymbols.BackColor = System.Drawing.Color.Transparent
        Me.btnSymbols.BackgroundImage = CType(resources.GetObject("btnSymbols.BackgroundImage"), System.Drawing.Image)
        Me.btnSymbols.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSymbols.FlatAppearance.BorderSize = 0
        Me.btnSymbols.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSymbols.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSymbols.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSymbols.ForeColor = System.Drawing.Color.Black
        Me.btnSymbols.Image = CType(resources.GetObject("btnSymbols.Image"), System.Drawing.Image)
        Me.btnSymbols.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSymbols.Location = New System.Drawing.Point(4, 2)
        Me.btnSymbols.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSymbols.Name = "btnSymbols"
        Me.btnSymbols.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnSymbols.Size = New System.Drawing.Size(98, 26)
        Me.btnSymbols.Style = resources.GetString("btnSymbols.Style")
        Me.btnSymbols.TabIndex = 37
        Me.btnSymbols.Text = " Symbols"
        Me.btnSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSymbols.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSymbols.UseCompatibleTextRendering = True
        Me.btnSymbols.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(4, 60)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Symbols"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.Controls.Add(Me.btnBaseline)
        Me.pnlMain.Controls.Add(Me.btnSubscript)
        Me.pnlMain.Controls.Add(Me.btnSuperscript)
        Me.pnlMain.Controls.Add(Me.nudSize)
        Me.pnlMain.Controls.Add(Me.DoubleBufferedPanel1)
        Me.pnlMain.Controls.Add(Me.btnHighlight)
        Me.pnlMain.Controls.Add(Me.btnText)
        Me.pnlMain.Controls.Add(Me.Label7)
        Me.pnlMain.Controls.Add(Me.Label5)
        Me.pnlMain.Controls.Add(Me.btnRight)
        Me.pnlMain.Controls.Add(Me.btnCenter)
        Me.pnlMain.Controls.Add(Me.btnLeft)
        Me.pnlMain.Controls.Add(Me.nudIndent)
        Me.pnlMain.Controls.Add(Me.btnIndent)
        Me.pnlMain.Controls.Add(Me.DoubleBufferedPanel6)
        Me.pnlMain.Controls.Add(Me.Label4)
        Me.pnlMain.Controls.Add(Me.btnFont)
        Me.pnlMain.Controls.Add(Me.btnStrikethrough)
        Me.pnlMain.Controls.Add(Me.btnUnderline)
        Me.pnlMain.Controls.Add(Me.btnItalic)
        Me.pnlMain.Controls.Add(Me.btnBold)
        Me.pnlMain.Controls.Add(Me.cbFont)
        Me.pnlMain.Controls.Add(Me.DoubleBufferedPanel5)
        Me.pnlMain.Controls.Add(Me.Label3)
        Me.pnlMain.Controls.Add(Me.btnPastePlain)
        Me.pnlMain.Controls.Add(Me.btnPaste)
        Me.pnlMain.Controls.Add(Me.btnCut)
        Me.pnlMain.Controls.Add(Me.btnCopy)
        Me.pnlMain.Controls.Add(Me.DoubleBufferedPanel4)
        Me.pnlMain.Controls.Add(Me.Label2)
        Me.pnlMain.Controls.Add(Me.btnRedo)
        Me.pnlMain.Controls.Add(Me.btnUndo)
        Me.pnlMain.Controls.Add(Me.DoubleBufferedPanel3)
        Me.pnlMain.Controls.Add(Me.Label1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMain.Location = New System.Drawing.Point(0, 106)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(960, 81)
        Me.pnlMain.TabIndex = 43
        '
        'nudSize
        '
        Me.nudSize.Location = New System.Drawing.Point(394, 6)
        Me.nudSize.Margin = New System.Windows.Forms.Padding(2)
        Me.nudSize.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSize.Name = "nudSize"
        Me.nudSize.Size = New System.Drawing.Size(59, 20)
        Me.nudSize.TabIndex = 22
        Me.nudSize.Value = New Decimal(New Integer() {11, 0, 0, 0})
        '
        'DoubleBufferedPanel1
        '
        Me.DoubleBufferedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DoubleBufferedPanel1.Location = New System.Drawing.Point(664, 7)
        Me.DoubleBufferedPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel1.Name = "DoubleBufferedPanel1"
        Me.DoubleBufferedPanel1.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel1.TabIndex = 71
        '
        'btnHighlight
        '
        Me.btnHighlight.BackColor = System.Drawing.Color.Transparent
        Me.btnHighlight.BackgroundImage = CType(resources.GetObject("btnHighlight.BackgroundImage"), System.Drawing.Image)
        Me.btnHighlight.ContextMenuStrip = Me.cmsTextHighlight
        Me.btnHighlight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHighlight.FlatAppearance.BorderSize = 0
        Me.btnHighlight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHighlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHighlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighlight.ForeColor = System.Drawing.Color.Black
        Me.btnHighlight.Image = CType(resources.GetObject("btnHighlight.Image"), System.Drawing.Image)
        Me.btnHighlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHighlight.Location = New System.Drawing.Point(574, 33)
        Me.btnHighlight.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHighlight.Name = "btnHighlight"
        Me.btnHighlight.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnHighlight.Size = New System.Drawing.Size(86, 26)
        Me.btnHighlight.Style = resources.GetString("btnHighlight.Style")
        Me.btnHighlight.TabIndex = 36
        Me.btnHighlight.Text = " Highlight"
        Me.btnHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHighlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHighlight.UseCompatibleTextRendering = True
        Me.btnHighlight.UseVisualStyleBackColor = False
        '
        'btnText
        '
        Me.btnText.BackColor = System.Drawing.Color.Transparent
        Me.btnText.BackgroundImage = CType(resources.GetObject("btnText.BackgroundImage"), System.Drawing.Image)
        Me.btnText.ContextMenuStrip = Me.cmsTextColor
        Me.btnText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnText.FlatAppearance.BorderSize = 0
        Me.btnText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnText.ForeColor = System.Drawing.Color.Black
        Me.btnText.Image = CType(resources.GetObject("btnText.Image"), System.Drawing.Image)
        Me.btnText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnText.Location = New System.Drawing.Point(574, 2)
        Me.btnText.Margin = New System.Windows.Forms.Padding(2)
        Me.btnText.Name = "btnText"
        Me.btnText.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnText.Size = New System.Drawing.Size(86, 26)
        Me.btnText.Style = resources.GetString("btnText.Style")
        Me.btnText.TabIndex = 35
        Me.btnText.Text = " Text "
        Me.btnText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnText.UseCompatibleTextRendering = True
        Me.btnText.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(574, 60)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 19)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Color"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(548, 8)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "px"
        '
        'nudIndent
        '
        Me.nudIndent.Location = New System.Drawing.Point(496, 6)
        Me.nudIndent.Margin = New System.Windows.Forms.Padding(2)
        Me.nudIndent.Name = "nudIndent"
        Me.nudIndent.Size = New System.Drawing.Size(40, 20)
        Me.nudIndent.TabIndex = 31
        Me.nudIndent.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'DoubleBufferedPanel6
        '
        Me.DoubleBufferedPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DoubleBufferedPanel6.Location = New System.Drawing.Point(570, 6)
        Me.DoubleBufferedPanel6.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel6.Name = "DoubleBufferedPanel6"
        Me.DoubleBufferedPanel6.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel6.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(466, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Paragraph"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFont
        '
        Me.btnFont.BackColor = System.Drawing.Color.Transparent
        Me.btnFont.BackgroundImage = CType(resources.GetObject("btnFont.BackgroundImage"), System.Drawing.Image)
        Me.btnFont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFont.FlatAppearance.BorderSize = 0
        Me.btnFont.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnFont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFont.ForeColor = System.Drawing.Color.Black
        Me.btnFont.Image = CType(resources.GetObject("btnFont.Image"), System.Drawing.Image)
        Me.btnFont.Location = New System.Drawing.Point(430, 59)
        Me.btnFont.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnFont.Size = New System.Drawing.Size(26, 20)
        Me.btnFont.Style = resources.GetString("btnFont.Style")
        Me.btnFont.TabIndex = 68
        Me.btnFont.TabStop = False
        Me.btnFont.UseCompatibleTextRendering = True
        Me.btnFont.UseVisualStyleBackColor = False
        '
        'cbFont
        '
        Me.cbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFont.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbFont.FormattingEnabled = True
        Me.cbFont.Location = New System.Drawing.Point(252, 5)
        Me.cbFont.Margin = New System.Windows.Forms.Padding(2)
        Me.cbFont.Name = "cbFont"
        Me.cbFont.Size = New System.Drawing.Size(140, 21)
        Me.cbFont.TabIndex = 21
        '
        'DoubleBufferedPanel5
        '
        Me.DoubleBufferedPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel5.Location = New System.Drawing.Point(460, 7)
        Me.DoubleBufferedPanel5.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel5.Name = "DoubleBufferedPanel5"
        Me.DoubleBufferedPanel5.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel5.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(254, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 19)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Font"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPastePlain
        '
        Me.btnPastePlain.BackColor = System.Drawing.Color.Transparent
        Me.btnPastePlain.BackgroundImage = CType(resources.GetObject("btnPastePlain.BackgroundImage"), System.Drawing.Image)
        Me.btnPastePlain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPastePlain.FlatAppearance.BorderSize = 0
        Me.btnPastePlain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPastePlain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPastePlain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPastePlain.ForeColor = System.Drawing.Color.Black
        Me.btnPastePlain.Image = CType(resources.GetObject("btnPastePlain.Image"), System.Drawing.Image)
        Me.btnPastePlain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPastePlain.Location = New System.Drawing.Point(148, 32)
        Me.btnPastePlain.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPastePlain.Name = "btnPastePlain"
        Me.btnPastePlain.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnPastePlain.Size = New System.Drawing.Size(94, 26)
        Me.btnPastePlain.Style = resources.GetString("btnPastePlain.Style")
        Me.btnPastePlain.TabIndex = 20
        Me.btnPastePlain.Text = " Paste Plain"
        Me.btnPastePlain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPastePlain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPastePlain.UseCompatibleTextRendering = True
        Me.btnPastePlain.UseVisualStyleBackColor = False
        '
        'btnPaste
        '
        Me.btnPaste.BackColor = System.Drawing.Color.Transparent
        Me.btnPaste.BackgroundImage = CType(resources.GetObject("btnPaste.BackgroundImage"), System.Drawing.Image)
        Me.btnPaste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPaste.FlatAppearance.BorderSize = 0
        Me.btnPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaste.ForeColor = System.Drawing.Color.Black
        Me.btnPaste.Image = CType(resources.GetObject("btnPaste.Image"), System.Drawing.Image)
        Me.btnPaste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaste.Location = New System.Drawing.Point(76, 33)
        Me.btnPaste.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnPaste.Size = New System.Drawing.Size(68, 26)
        Me.btnPaste.Style = resources.GetString("btnPaste.Style")
        Me.btnPaste.TabIndex = 18
        Me.btnPaste.Text = " Paste"
        Me.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPaste.UseCompatibleTextRendering = True
        Me.btnPaste.UseVisualStyleBackColor = False
        '
        'btnCut
        '
        Me.btnCut.BackColor = System.Drawing.Color.Transparent
        Me.btnCut.BackgroundImage = CType(resources.GetObject("btnCut.BackgroundImage"), System.Drawing.Image)
        Me.btnCut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCut.FlatAppearance.BorderSize = 0
        Me.btnCut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCut.ForeColor = System.Drawing.Color.Black
        Me.btnCut.Image = CType(resources.GetObject("btnCut.Image"), System.Drawing.Image)
        Me.btnCut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCut.Location = New System.Drawing.Point(148, 2)
        Me.btnCut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnCut.Size = New System.Drawing.Size(94, 26)
        Me.btnCut.Style = resources.GetString("btnCut.Style")
        Me.btnCut.TabIndex = 19
        Me.btnCut.Text = " Cut"
        Me.btnCut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCut.UseCompatibleTextRendering = True
        Me.btnCut.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.Transparent
        Me.btnCopy.BackgroundImage = CType(resources.GetObject("btnCopy.BackgroundImage"), System.Drawing.Image)
        Me.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCopy.FlatAppearance.BorderSize = 0
        Me.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.ForeColor = System.Drawing.Color.Black
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopy.Location = New System.Drawing.Point(76, 2)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnCopy.Size = New System.Drawing.Size(68, 26)
        Me.btnCopy.Style = resources.GetString("btnCopy.Style")
        Me.btnCopy.TabIndex = 17
        Me.btnCopy.Text = " Copy"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCopy.UseCompatibleTextRendering = True
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel4
        '
        Me.DoubleBufferedPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel4.Location = New System.Drawing.Point(248, 7)
        Me.DoubleBufferedPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel4.Name = "DoubleBufferedPanel4"
        Me.DoubleBufferedPanel4.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel4.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(76, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Clipboard"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRedo
        '
        Me.btnRedo.BackColor = System.Drawing.Color.Transparent
        Me.btnRedo.BackgroundImage = CType(resources.GetObject("btnRedo.BackgroundImage"), System.Drawing.Image)
        Me.btnRedo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRedo.FlatAppearance.BorderSize = 0
        Me.btnRedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRedo.ForeColor = System.Drawing.Color.Black
        Me.btnRedo.Image = CType(resources.GetObject("btnRedo.Image"), System.Drawing.Image)
        Me.btnRedo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRedo.Location = New System.Drawing.Point(4, 33)
        Me.btnRedo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRedo.Name = "btnRedo"
        Me.btnRedo.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnRedo.Size = New System.Drawing.Size(62, 26)
        Me.btnRedo.Style = resources.GetString("btnRedo.Style")
        Me.btnRedo.TabIndex = 16
        Me.btnRedo.Text = " Redo"
        Me.btnRedo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRedo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRedo.UseCompatibleTextRendering = True
        Me.btnRedo.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.Color.Transparent
        Me.btnUndo.BackgroundImage = CType(resources.GetObject("btnUndo.BackgroundImage"), System.Drawing.Image)
        Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUndo.FlatAppearance.BorderSize = 0
        Me.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.ForeColor = System.Drawing.Color.Black
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUndo.Location = New System.Drawing.Point(4, 2)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnUndo.Size = New System.Drawing.Size(62, 26)
        Me.btnUndo.Style = resources.GetString("btnUndo.Style")
        Me.btnUndo.TabIndex = 15
        Me.btnUndo.Text = " Undo"
        Me.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUndo.UseCompatibleTextRendering = True
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel3
        '
        Me.DoubleBufferedPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel3.Location = New System.Drawing.Point(72, 7)
        Me.DoubleBufferedPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel3.Name = "DoubleBufferedPanel3"
        Me.DoubleBufferedPanel3.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(4, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "History"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFile
        '
        Me.pnlFile.AutoScroll = True
        Me.pnlFile.BackColor = System.Drawing.Color.Transparent
        Me.pnlFile.Controls.Add(Me.btnSettings)
        Me.pnlFile.Controls.Add(Me.btnCheckUpdate)
        Me.pnlFile.Controls.Add(Me.Label21)
        Me.pnlFile.Controls.Add(Me.DoubleBufferedPanel15)
        Me.pnlFile.Controls.Add(Me.DoubleBufferedPanel16)
        Me.pnlFile.Controls.Add(Me.Label19)
        Me.pnlFile.Controls.Add(Me.btnRTF)
        Me.pnlFile.Controls.Add(Me.btnPageSetup)
        Me.pnlFile.Controls.Add(Me.btnAbout)
        Me.pnlFile.Controls.Add(Me.DoubleBufferedPanel11)
        Me.pnlFile.Controls.Add(Me.btnPrint)
        Me.pnlFile.Controls.Add(Me.btnPrintPreview)
        Me.pnlFile.Controls.Add(Me.DoubleBufferedPanel7)
        Me.pnlFile.Controls.Add(Me.Label11)
        Me.pnlFile.Controls.Add(Me.btnSaveAs)
        Me.pnlFile.Controls.Add(Me.btnOpen)
        Me.pnlFile.Controls.Add(Me.btnSave)
        Me.pnlFile.Controls.Add(Me.btnNew)
        Me.pnlFile.Controls.Add(Me.Label16)
        Me.pnlFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFile.Location = New System.Drawing.Point(0, 25)
        Me.pnlFile.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlFile.Name = "pnlFile"
        Me.pnlFile.Size = New System.Drawing.Size(960, 81)
        Me.pnlFile.TabIndex = 75
        Me.pnlFile.Visible = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundImage = CType(resources.GetObject("btnSettings.BackgroundImage"), System.Drawing.Image)
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.ForeColor = System.Drawing.Color.Black
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(489, 32)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnSettings.Size = New System.Drawing.Size(88, 26)
        Me.btnSettings.Style = resources.GetString("btnSettings.Style")
        Me.btnSettings.TabIndex = 16
        Me.btnSettings.Text = " Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseCompatibleTextRendering = True
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnCheckUpdate
        '
        Me.btnCheckUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckUpdate.BackgroundImage = CType(resources.GetObject("btnCheckUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCheckUpdate.FlatAppearance.BorderSize = 0
        Me.btnCheckUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCheckUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCheckUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnCheckUpdate.Image = CType(resources.GetObject("btnCheckUpdate.Image"), System.Drawing.Image)
        Me.btnCheckUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckUpdate.Location = New System.Drawing.Point(489, 2)
        Me.btnCheckUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckUpdate.Name = "btnCheckUpdate"
        Me.btnCheckUpdate.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnCheckUpdate.Size = New System.Drawing.Size(88, 26)
        Me.btnCheckUpdate.Style = resources.GetString("btnCheckUpdate.Style")
        Me.btnCheckUpdate.TabIndex = 15
        Me.btnCheckUpdate.Text = " Update"
        Me.btnCheckUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCheckUpdate.UseCompatibleTextRendering = True
        Me.btnCheckUpdate.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.ForeColor = System.Drawing.Color.Gray
        Me.Label21.Location = New System.Drawing.Point(486, 61)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(190, 19)
        Me.Label21.TabIndex = 66
        Me.Label21.Text = "Language Pad"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DoubleBufferedPanel15
        '
        Me.DoubleBufferedPanel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel15.Location = New System.Drawing.Point(158, 7)
        Me.DoubleBufferedPanel15.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel15.Name = "DoubleBufferedPanel15"
        Me.DoubleBufferedPanel15.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel15.TabIndex = 51
        '
        'DoubleBufferedPanel16
        '
        Me.DoubleBufferedPanel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel16.Location = New System.Drawing.Point(484, 7)
        Me.DoubleBufferedPanel16.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel16.Name = "DoubleBufferedPanel16"
        Me.DoubleBufferedPanel16.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel16.TabIndex = 63
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.Color.Gray
        Me.Label19.Location = New System.Drawing.Point(376, 61)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 19)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "Advanced"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRTF
        '
        Me.btnRTF.BackColor = System.Drawing.Color.Transparent
        Me.btnRTF.BackgroundImage = CType(resources.GetObject("btnRTF.BackgroundImage"), System.Drawing.Image)
        Me.btnRTF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRTF.FlatAppearance.BorderSize = 0
        Me.btnRTF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRTF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRTF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRTF.ForeColor = System.Drawing.Color.Black
        Me.btnRTF.Image = CType(resources.GetObject("btnRTF.Image"), System.Drawing.Image)
        Me.btnRTF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRTF.Location = New System.Drawing.Point(376, 2)
        Me.btnRTF.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRTF.Name = "btnRTF"
        Me.btnRTF.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnRTF.Size = New System.Drawing.Size(102, 26)
        Me.btnRTF.Style = resources.GetString("btnRTF.Style")
        Me.btnRTF.TabIndex = 14
        Me.btnRTF.Text = " RTF Editor"
        Me.btnRTF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRTF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRTF.UseCompatibleTextRendering = True
        Me.btnRTF.UseVisualStyleBackColor = False
        '
        'btnPageSetup
        '
        Me.btnPageSetup.BackColor = System.Drawing.Color.Transparent
        Me.btnPageSetup.BackgroundImage = CType(resources.GetObject("btnPageSetup.BackgroundImage"), System.Drawing.Image)
        Me.btnPageSetup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPageSetup.FlatAppearance.BorderSize = 0
        Me.btnPageSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPageSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPageSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPageSetup.ForeColor = System.Drawing.Color.Black
        Me.btnPageSetup.Image = CType(resources.GetObject("btnPageSetup.Image"), System.Drawing.Image)
        Me.btnPageSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPageSetup.Location = New System.Drawing.Point(272, 2)
        Me.btnPageSetup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPageSetup.Name = "btnPageSetup"
        Me.btnPageSetup.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnPageSetup.Size = New System.Drawing.Size(94, 26)
        Me.btnPageSetup.Style = resources.GetString("btnPageSetup.Style")
        Me.btnPageSetup.TabIndex = 12
        Me.btnPageSetup.Text = " Page Setup"
        Me.btnPageSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPageSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPageSetup.UseCompatibleTextRendering = True
        Me.btnPageSetup.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.BackgroundImage = CType(resources.GetObject("btnAbout.BackgroundImage"), System.Drawing.Image)
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.ForeColor = System.Drawing.Color.Black
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(581, 2)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnAbout.Size = New System.Drawing.Size(88, 26)
        Me.btnAbout.Style = resources.GetString("btnAbout.Style")
        Me.btnAbout.TabIndex = 17
        Me.btnAbout.Text = " About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbout.UseCompatibleTextRendering = True
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel11
        '
        Me.DoubleBufferedPanel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel11.Location = New System.Drawing.Point(677, 7)
        Me.DoubleBufferedPanel11.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel11.Name = "DoubleBufferedPanel11"
        Me.DoubleBufferedPanel11.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel11.TabIndex = 62
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(164, 32)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnPrint.Size = New System.Drawing.Size(106, 26)
        Me.btnPrint.Style = resources.GetString("btnPrint.Style")
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = " Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseCompatibleTextRendering = True
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnPrintPreview.BackgroundImage = CType(resources.GetObject("btnPrintPreview.BackgroundImage"), System.Drawing.Image)
        Me.btnPrintPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrintPreview.FlatAppearance.BorderSize = 0
        Me.btnPrintPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPrintPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPrintPreview.Image = CType(resources.GetObject("btnPrintPreview.Image"), System.Drawing.Image)
        Me.btnPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintPreview.Location = New System.Drawing.Point(164, 2)
        Me.btnPrintPreview.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnPrintPreview.Size = New System.Drawing.Size(106, 26)
        Me.btnPrintPreview.Style = resources.GetString("btnPrintPreview.Style")
        Me.btnPrintPreview.TabIndex = 10
        Me.btnPrintPreview.Text = " Print Preview"
        Me.btnPrintPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintPreview.UseCompatibleTextRendering = True
        Me.btnPrintPreview.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel7
        '
        Me.DoubleBufferedPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel7.Location = New System.Drawing.Point(372, 7)
        Me.DoubleBufferedPanel7.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel7.Name = "DoubleBufferedPanel7"
        Me.DoubleBufferedPanel7.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel7.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(164, 61)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(206, 19)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Printing"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveAs
        '
        Me.btnSaveAs.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveAs.BackgroundImage = CType(resources.GetObject("btnSaveAs.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveAs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSaveAs.FlatAppearance.BorderSize = 0
        Me.btnSaveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSaveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAs.ForeColor = System.Drawing.Color.Black
        Me.btnSaveAs.Image = CType(resources.GetObject("btnSaveAs.Image"), System.Drawing.Image)
        Me.btnSaveAs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveAs.Location = New System.Drawing.Point(76, 33)
        Me.btnSaveAs.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnSaveAs.Size = New System.Drawing.Size(76, 26)
        Me.btnSaveAs.Style = resources.GetString("btnSaveAs.Style")
        Me.btnSaveAs.TabIndex = 9
        Me.btnSaveAs.Text = " Save As"
        Me.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveAs.UseCompatibleTextRendering = True
        Me.btnSaveAs.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.Transparent
        Me.btnOpen.BackgroundImage = CType(resources.GetObject("btnOpen.BackgroundImage"), System.Drawing.Image)
        Me.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOpen.FlatAppearance.BorderSize = 0
        Me.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.ForeColor = System.Drawing.Color.Black
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpen.Location = New System.Drawing.Point(8, 33)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnOpen.Size = New System.Drawing.Size(66, 26)
        Me.btnOpen.Style = resources.GetString("btnOpen.Style")
        Me.btnOpen.TabIndex = 7
        Me.btnOpen.Text = " Open"
        Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpen.UseCompatibleTextRendering = True
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(76, 2)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnSave.Size = New System.Drawing.Size(76, 26)
        Me.btnSave.Style = resources.GetString("btnSave.Style")
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = " Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseCompatibleTextRendering = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(8, 2)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnNew.Size = New System.Drawing.Size(66, 26)
        Me.btnNew.Style = resources.GetString("btnNew.Style")
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = " New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseCompatibleTextRendering = True
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Gray
        Me.Label16.Location = New System.Drawing.Point(4, 61)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 19)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "File"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTabs
        '
        Me.pnlTabs.BackColor = System.Drawing.Color.Transparent
        Me.pnlTabs.Controls.Add(Me.btnQuickOpen)
        Me.pnlTabs.Controls.Add(Me.btnQuickSave)
        Me.pnlTabs.Controls.Add(Me.DoubleBufferedPanel22)
        Me.pnlTabs.Controls.Add(Me.btnQuickUndo)
        Me.pnlTabs.Controls.Add(Me.btnQuickRedo)
        Me.pnlTabs.Controls.Add(Me.DoubleBufferedPanel17)
        Me.pnlTabs.Controls.Add(Me.btnControl)
        Me.pnlTabs.Controls.Add(Me.btnInsert)
        Me.pnlTabs.Controls.Add(Me.btnNotebook)
        Me.pnlTabs.Controls.Add(Me.btnLinguistics)
        Me.pnlTabs.Controls.Add(Me.btnHome)
        Me.pnlTabs.Controls.Add(Me.btnConlangNotepad)
        Me.pnlTabs.Controls.Add(Me.btnQuickSymbols)
        Me.pnlTabs.Controls.Add(Me.btnQuickAccents)
        Me.pnlTabs.Controls.Add(Me.DoubleBufferedPanel21)
        Me.pnlTabs.Controls.Add(Me.StatusStrip1)
        Me.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTabs.Location = New System.Drawing.Point(0, 0)
        Me.pnlTabs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.pnlTabs.Name = "pnlTabs"
        Me.pnlTabs.Size = New System.Drawing.Size(960, 25)
        Me.pnlTabs.Style = "Colors=$1|~249" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight C" &
    "olor$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=1"
        Me.pnlTabs.TabIndex = 71
        '
        'DoubleBufferedPanel22
        '
        Me.DoubleBufferedPanel22.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DoubleBufferedPanel22.Dock = System.Windows.Forms.DockStyle.Right
        Me.DoubleBufferedPanel22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel22.Location = New System.Drawing.Point(671, 0)
        Me.DoubleBufferedPanel22.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel22.Name = "DoubleBufferedPanel22"
        Me.DoubleBufferedPanel22.Size = New System.Drawing.Size(1, 25)
        Me.DoubleBufferedPanel22.TabIndex = 96
        '
        'DoubleBufferedPanel17
        '
        Me.DoubleBufferedPanel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DoubleBufferedPanel17.Dock = System.Windows.Forms.DockStyle.Right
        Me.DoubleBufferedPanel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel17.Location = New System.Drawing.Point(722, 0)
        Me.DoubleBufferedPanel17.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel17.Name = "DoubleBufferedPanel17"
        Me.DoubleBufferedPanel17.Size = New System.Drawing.Size(1, 25)
        Me.DoubleBufferedPanel17.TabIndex = 87
        '
        'btnControl
        '
        Me.btnControl.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnControl.AutoSize = True
        Me.btnControl.BackColor = System.Drawing.Color.Transparent
        Me.btnControl.BackgroundImage = CType(resources.GetObject("btnControl.BackgroundImage"), System.Drawing.Image)
        Me.btnControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnControl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnControl.FlatAppearance.BorderSize = 0
        Me.btnControl.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnControl.Location = New System.Drawing.Point(242, 0)
        Me.btnControl.Margin = New System.Windows.Forms.Padding(2)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnControl.Size = New System.Drawing.Size(50, 25)
        Me.btnControl.Style = resources.GetString("btnControl.Style")
        Me.btnControl.TabIndex = 5
        Me.btnControl.Text = "Control"
        Me.btnControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnControl.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnInsert.AutoSize = True
        Me.btnInsert.BackColor = System.Drawing.Color.Transparent
        Me.btnInsert.BackgroundImage = CType(resources.GetObject("btnInsert.BackgroundImage"), System.Drawing.Image)
        Me.btnInsert.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInsert.FlatAppearance.BorderSize = 0
        Me.btnInsert.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnInsert.Location = New System.Drawing.Point(199, 0)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnInsert.Size = New System.Drawing.Size(43, 25)
        Me.btnInsert.Style = resources.GetString("btnInsert.Style")
        Me.btnInsert.TabIndex = 4
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnNotebook
        '
        Me.btnNotebook.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnNotebook.AutoSize = True
        Me.btnNotebook.BackColor = System.Drawing.Color.Transparent
        Me.btnNotebook.BackgroundImage = CType(resources.GetObject("btnNotebook.BackgroundImage"), System.Drawing.Image)
        Me.btnNotebook.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNotebook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNotebook.FlatAppearance.BorderSize = 0
        Me.btnNotebook.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnNotebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNotebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNotebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotebook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnNotebook.Location = New System.Drawing.Point(135, 0)
        Me.btnNotebook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNotebook.Name = "btnNotebook"
        Me.btnNotebook.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNotebook.Size = New System.Drawing.Size(64, 25)
        Me.btnNotebook.Style = resources.GetString("btnNotebook.Style")
        Me.btnNotebook.TabIndex = 3
        Me.btnNotebook.Text = "Notebook"
        Me.btnNotebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNotebook.UseVisualStyleBackColor = False
        '
        'btnLinguistics
        '
        Me.btnLinguistics.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnLinguistics.AutoSize = True
        Me.btnLinguistics.BackColor = System.Drawing.Color.Transparent
        Me.btnLinguistics.BackgroundImage = CType(resources.GetObject("btnLinguistics.BackgroundImage"), System.Drawing.Image)
        Me.btnLinguistics.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLinguistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLinguistics.FlatAppearance.BorderSize = 0
        Me.btnLinguistics.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnLinguistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLinguistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLinguistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinguistics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnLinguistics.Location = New System.Drawing.Point(69, 0)
        Me.btnLinguistics.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLinguistics.Name = "btnLinguistics"
        Me.btnLinguistics.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnLinguistics.Size = New System.Drawing.Size(66, 25)
        Me.btnLinguistics.Style = resources.GetString("btnLinguistics.Style")
        Me.btnLinguistics.TabIndex = 2
        Me.btnLinguistics.Text = "Linguistics"
        Me.btnLinguistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLinguistics.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnHome.AutoSize = True
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.Checked = True
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHome.Location = New System.Drawing.Point(24, 0)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnHome.Size = New System.Drawing.Size(45, 25)
        Me.btnHome.Style = resources.GetString("btnHome.Style")
        Me.btnHome.TabIndex = 1
        Me.btnHome.TabStop = True
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnConlangNotepad
        '
        Me.btnConlangNotepad.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnConlangNotepad.AutoSize = True
        Me.btnConlangNotepad.BackColor = System.Drawing.Color.Transparent
        Me.btnConlangNotepad.BackgroundImage = CType(resources.GetObject("btnConlangNotepad.BackgroundImage"), System.Drawing.Image)
        Me.btnConlangNotepad.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnConlangNotepad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConlangNotepad.FlatAppearance.BorderSize = 0
        Me.btnConlangNotepad.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnConlangNotepad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnConlangNotepad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConlangNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConlangNotepad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnConlangNotepad.Image = CType(resources.GetObject("btnConlangNotepad.Image"), System.Drawing.Image)
        Me.btnConlangNotepad.Location = New System.Drawing.Point(0, 0)
        Me.btnConlangNotepad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnConlangNotepad.Name = "btnConlangNotepad"
        Me.btnConlangNotepad.Padding = New System.Windows.Forms.Padding(0, 1, 2, 2)
        Me.btnConlangNotepad.Size = New System.Drawing.Size(24, 25)
        Me.btnConlangNotepad.Style = resources.GetString("btnConlangNotepad.Style")
        Me.btnConlangNotepad.TabIndex = 0
        Me.btnConlangNotepad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnConlangNotepad.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel21
        '
        Me.DoubleBufferedPanel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DoubleBufferedPanel21.Dock = System.Windows.Forms.DockStyle.Right
        Me.DoubleBufferedPanel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel21.Location = New System.Drawing.Point(773, 0)
        Me.DoubleBufferedPanel21.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel21.Name = "DoubleBufferedPanel21"
        Me.DoubleBufferedPanel21.Size = New System.Drawing.Size(1, 25)
        Me.DoubleBufferedPanel21.TabIndex = 93
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCharCount, Me.lblWordCount})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(774, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(186, 25)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 13
        '
        'lblCharCount
        '
        Me.lblCharCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblCharCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblCharCount.Name = "lblCharCount"
        Me.lblCharCount.Size = New System.Drawing.Size(96, 20)
        Me.lblCharCount.Text = "Character Count: 0"
        '
        'lblWordCount
        '
        Me.lblWordCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblWordCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblWordCount.Name = "lblWordCount"
        Me.lblWordCount.Size = New System.Drawing.Size(76, 20)
        Me.lblWordCount.Text = "Word Count: 0"
        '
        'NotebookEditor1
        '
        Me.NotebookEditor1.BackColor = System.Drawing.Color.Transparent
        Me.NotebookEditor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.NotebookEditor1.Location = New System.Drawing.Point(0, 28)
        Me.NotebookEditor1.Margin = New System.Windows.Forms.Padding(2)
        Me.NotebookEditor1.Name = "NotebookEditor1"
        Me.NotebookEditor1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.NotebookEditor1.Size = New System.Drawing.Size(253, 41)
        Me.NotebookEditor1.TabIndex = 72
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(977, 643)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlFindReplace)
        Me.Controls.Add(Me.pnlTop)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.ShowIcon = False
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
        Me.cmsTextHighlight.ResumeLayout(False)
        Me.cmsTextColor.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.StylizedPanel1.ResumeLayout(False)
        Me.EmoteLayoutPanel.ResumeLayout(False)
        Me.StylizedPanel2.ResumeLayout(False)
        Me.StylizedPanel2.PerformLayout()
        Me.pnlFindReplace.ResumeLayout(False)
        Me.pnlFindReplace.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlInsert.ResumeLayout(False)
        Me.pnlNotebook.ResumeLayout(False)
        Me.pnlLinguistics.ResumeLayout(False)
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.nudSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIndent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFile.ResumeLayout(False)
        Me.pnlTabs.ResumeLayout(False)
        Me.pnlTabs.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents pnlTop As Tundra.StylizedPanel
    Friend WithEvents btnHome As Tundra.StylizedRadioButton
    Friend WithEvents btnLinguistics As Tundra.StylizedRadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblCharCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlMain As Tundra.DoubleBufferedPanel
    Friend WithEvents btnRedo As Tundra.StylizedButton
    Friend WithEvents btnUndo As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel3 As Tundra.DoubleBufferedPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInsert As Tundra.StylizedRadioButton
    Friend WithEvents btnPastePlain As Tundra.StylizedButton
    Friend WithEvents btnPaste As Tundra.StylizedButton
    Friend WithEvents btnCut As Tundra.StylizedButton
    Friend WithEvents btnCopy As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel4 As Tundra.DoubleBufferedPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnConlangNotepad As Tundra.StylizedRadioButton
    Friend WithEvents cbFont As System.Windows.Forms.ComboBox
    Friend WithEvents DoubleBufferedPanel5 As Tundra.DoubleBufferedPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnIndent As Tundra.StylizedButton
    Friend WithEvents btnStrikethrough As Tundra.StylizedButton
    Friend WithEvents btnUnderline As Tundra.StylizedButton
    Friend WithEvents btnItalic As Tundra.StylizedButton
    Friend WithEvents btnBold As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel6 As Tundra.DoubleBufferedPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnControl As Tundra.StylizedRadioButton
    Friend WithEvents pnlTabs As Tundra.StylizedPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnRight As Tundra.StylizedButton
    Friend WithEvents btnCenter As Tundra.StylizedButton
    Friend WithEvents btnLeft As Tundra.StylizedButton
    Friend WithEvents nudIndent As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnFont As Tundra.StylizedButton
    Friend WithEvents lblWordCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnHighlight As Tundra.StylizedButton
    Friend WithEvents btnText As Tundra.StylizedButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DoubleBufferedPanel1 As Tundra.DoubleBufferedPanel
    Friend WithEvents nudSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents pnlLinguistics As Tundra.DoubleBufferedPanel
    Friend WithEvents DoubleBufferedPanel10 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnAccentMark As Tundra.StylizedButton
    Friend WithEvents btnSymbols As Tundra.StylizedButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCustomSymbols As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel2 As Tundra.DoubleBufferedPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlControl As Tundra.DoubleBufferedPanel
    Friend WithEvents btnZoom100 As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel13 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnZoomOut As Tundra.StylizedButton
    Friend WithEvents btnZoomIn As Tundra.StylizedButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSubscript As Tundra.StylizedButton
    Friend WithEvents btnSuperscript As Tundra.StylizedButton
    Friend WithEvents btnBaseline As Tundra.StylizedButton
    Friend WithEvents pnlFile As Tundra.DoubleBufferedPanel
    Friend WithEvents btnAbout As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel11 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnPrint As Tundra.StylizedButton
    Friend WithEvents btnPrintPreview As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel7 As Tundra.DoubleBufferedPanel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSaveAs As Tundra.StylizedButton
    Friend WithEvents btnOpen As Tundra.StylizedButton
    Friend WithEvents btnSave As Tundra.StylizedButton
    Friend WithEvents btnNew As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel15 As Tundra.DoubleBufferedPanel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CommonTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CommonLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CustomTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CustomLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSelectAll As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel14 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnFindReplace As Tundra.StylizedButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dlgSavePage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgPrintPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents dlgPrint As System.Windows.Forms.PrintDialog
    Friend WithEvents dlgOpenPage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnPageSetup As Tundra.StylizedButton
    Friend WithEvents dlgSetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents pdMain As System.Drawing.Printing.PrintDocument
    Friend WithEvents dlgSaveNarration As System.Windows.Forms.SaveFileDialog
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
    Friend WithEvents nudSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSaveSpeech As Tundra.StylizedButton
    Friend WithEvents btnStop As Tundra.StylizedButton
    Friend WithEvents btnPlay As Tundra.StylizedButton
    Friend WithEvents cbVoice As System.Windows.Forms.ComboBox
    Friend WithEvents DoubleBufferedPanel16 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnRTF As Tundra.StylizedButton
    Friend WithEvents cmsMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeselectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NarrateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsTextColor As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsTextHighlight As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCustomZoom As Tundra.StylizedButton
    Friend WithEvents btnWordWrap As Tundra.StylizedButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ClipArtLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents EmoteLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents StylizedButton3 As Tundra.StylizedButton
    Friend WithEvents StylizedButton4 As Tundra.StylizedButton
    Friend WithEvents StylizedButton5 As Tundra.StylizedButton
    Friend WithEvents StylizedButton6 As Tundra.StylizedButton
    Friend WithEvents StylizedButton7 As Tundra.StylizedButton
    Friend WithEvents StylizedButton8 As Tundra.StylizedButton
    Friend WithEvents StylizedButton9 As Tundra.StylizedButton
    Friend WithEvents StylizedButton10 As Tundra.StylizedButton
    Friend WithEvents StylizedButton11 As Tundra.StylizedButton
    Friend WithEvents StylizedButton12 As Tundra.StylizedButton
    Friend WithEvents StylizedButton13 As Tundra.StylizedButton
    Friend WithEvents StylizedButton14 As Tundra.StylizedButton
    Friend WithEvents StylizedButton15 As Tundra.StylizedButton
    Friend WithEvents StylizedButton16 As Tundra.StylizedButton
    Friend WithEvents StylizedButton17 As Tundra.StylizedButton
    Friend WithEvents StylizedButton18 As Tundra.StylizedButton
    Friend WithEvents StylizedButton19 As Tundra.StylizedButton
    Friend WithEvents StylizedButton20 As Tundra.StylizedButton
    Friend WithEvents StylizedButton21 As Tundra.StylizedButton
    Friend WithEvents StylizedButton22 As Tundra.StylizedButton
    Friend WithEvents StylizedButton23 As Tundra.StylizedButton
    Friend WithEvents StylizedButton24 As Tundra.StylizedButton
    Friend WithEvents StylizedButton25 As Tundra.StylizedButton
    Friend WithEvents StylizedButton26 As Tundra.StylizedButton
    Friend WithEvents StylizedButton27 As Tundra.StylizedButton
    Friend WithEvents StylizedButton28 As Tundra.StylizedButton
    Friend WithEvents StylizedButton29 As Tundra.StylizedButton
    Friend WithEvents StylizedButton30 As Tundra.StylizedButton
    Friend WithEvents StylizedButton31 As Tundra.StylizedButton
    Friend WithEvents StylizedButton32 As Tundra.StylizedButton
    Friend WithEvents StylizedButton33 As Tundra.StylizedButton
    Friend WithEvents StylizedButton34 As Tundra.StylizedButton
    Friend WithEvents StylizedButton35 As Tundra.StylizedButton
    Friend WithEvents StylizedButton36 As Tundra.StylizedButton
    Friend WithEvents StylizedButton37 As Tundra.StylizedButton
    Friend WithEvents StylizedButton38 As Tundra.StylizedButton
    Friend WithEvents StylizedButton39 As Tundra.StylizedButton
    Friend WithEvents StylizedButton40 As Tundra.StylizedButton
    Friend WithEvents StylizedButton41 As Tundra.StylizedButton
    Friend WithEvents StylizedButton93 As Tundra.StylizedButton
    Friend WithEvents StylizedButton42 As Tundra.StylizedButton
    Friend WithEvents StylizedButton43 As Tundra.StylizedButton
    Friend WithEvents StylizedButton44 As Tundra.StylizedButton
    Friend WithEvents StylizedButton45 As Tundra.StylizedButton
    Friend WithEvents StylizedButton46 As Tundra.StylizedButton
    Friend WithEvents StylizedButton47 As Tundra.StylizedButton
    Friend WithEvents StylizedButton48 As Tundra.StylizedButton
    Friend WithEvents StylizedButton49 As Tundra.StylizedButton
    Friend WithEvents StylizedButton50 As Tundra.StylizedButton
    Friend WithEvents StylizedButton51 As Tundra.StylizedButton
    Friend WithEvents StylizedButton52 As Tundra.StylizedButton
    Friend WithEvents StylizedButton53 As Tundra.StylizedButton
    Friend WithEvents StylizedButton88 As Tundra.StylizedButton
    Friend WithEvents StylizedButton54 As Tundra.StylizedButton
    Friend WithEvents StylizedButton55 As Tundra.StylizedButton
    Friend WithEvents StylizedButton56 As Tundra.StylizedButton
    Friend WithEvents StylizedButton57 As Tundra.StylizedButton
    Friend WithEvents StylizedButton58 As Tundra.StylizedButton
    Friend WithEvents StylizedButton90 As Tundra.StylizedButton
    Friend WithEvents StylizedButton65 As Tundra.StylizedButton
    Friend WithEvents StylizedButton59 As Tundra.StylizedButton
    Friend WithEvents StylizedButton60 As Tundra.StylizedButton
    Friend WithEvents StylizedButton61 As Tundra.StylizedButton
    Friend WithEvents StylizedButton62 As Tundra.StylizedButton
    Friend WithEvents StylizedButton63 As Tundra.StylizedButton
    Friend WithEvents StylizedButton64 As Tundra.StylizedButton
    Friend WithEvents StylizedButton66 As Tundra.StylizedButton
    Friend WithEvents StylizedButton68 As Tundra.StylizedButton
    Friend WithEvents StylizedButton71 As Tundra.StylizedButton
    Friend WithEvents StylizedButton69 As Tundra.StylizedButton
    Friend WithEvents StylizedButton70 As Tundra.StylizedButton
    Friend WithEvents StylizedButton72 As Tundra.StylizedButton
    Friend WithEvents StylizedButton73 As Tundra.StylizedButton
    Friend WithEvents StylizedButton74 As Tundra.StylizedButton
    Friend WithEvents StylizedButton75 As Tundra.StylizedButton
    Friend WithEvents StylizedButton76 As Tundra.StylizedButton
    Friend WithEvents StylizedButton77 As Tundra.StylizedButton
    Friend WithEvents StylizedButton78 As Tundra.StylizedButton
    Friend WithEvents StylizedButton79 As Tundra.StylizedButton
    Friend WithEvents StylizedButton80 As Tundra.StylizedButton
    Friend WithEvents StylizedButton67 As Tundra.StylizedButton
    Friend WithEvents StylizedButton81 As Tundra.StylizedButton
    Friend WithEvents StylizedButton82 As Tundra.StylizedButton
    Friend WithEvents StylizedButton83 As Tundra.StylizedButton
    Friend WithEvents StylizedButton84 As Tundra.StylizedButton
    Friend WithEvents StylizedButton85 As Tundra.StylizedButton
    Friend WithEvents StylizedButton86 As Tundra.StylizedButton
    Friend WithEvents StylizedButton87 As Tundra.StylizedButton
    Friend WithEvents StylizedButton89 As Tundra.StylizedButton
    Friend WithEvents StylizedButton91 As Tundra.StylizedButton
    Friend WithEvents StylizedButton92 As Tundra.StylizedButton
    Friend WithEvents StylizedButton94 As Tundra.StylizedButton
    Friend WithEvents StylizedButton95 As Tundra.StylizedButton
    Friend WithEvents StylizedButton96 As Tundra.StylizedButton
    Friend WithEvents StylizedButton97 As Tundra.StylizedButton
    Friend WithEvents StylizedButton100 As Tundra.StylizedButton
    Friend WithEvents StylizedButton102 As Tundra.StylizedButton
    Friend WithEvents tcNotebook As System.Windows.Forms.TabControl
    Friend WithEvents pnlNotebook As Tundra.DoubleBufferedPanel
    Friend WithEvents btnRenamePage As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel18 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnNotebookEditor As Tundra.StylizedButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DoubleBufferedPanel19 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnRemove As Tundra.StylizedButton
    Friend WithEvents btnAdd As Tundra.StylizedButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnNotebook As Tundra.StylizedRadioButton
    Friend WithEvents dlgSaveNotebook As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnExportPage As Tundra.StylizedButton
    Friend WithEvents btnImportPage As Tundra.StylizedButton
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
    Friend WithEvents StylizedPanel2 As Tundra.StylizedPanel
    Friend WithEvents btnClose As Tundra.StylizedButton
    Friend WithEvents btnEmotesTab As Tundra.StylizedRadioButton
    Friend WithEvents btnClipArtTab As Tundra.StylizedRadioButton
    Friend WithEvents btnNotebookTab As Tundra.StylizedRadioButton
    Friend WithEvents NotebookEditor1 As Language_Pad.NotebookEditor
    Friend WithEvents btnDuplicate As Tundra.StylizedButton
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents dlgSaveImage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnCheckUpdate As Tundra.StylizedButton
    Friend WithEvents Label21 As Label
    Friend WithEvents btnSettings As Tundra.StylizedButton
    Friend WithEvents Label19 As Label
    Friend WithEvents pnlInsert As Tundra.DoubleBufferedPanel
    Friend WithEvents btnTable As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel12 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnTextArt As Tundra.StylizedButton
    Friend WithEvents Label14 As Label
    Friend WithEvents btnClipArt As Tundra.StylizedButton
    Friend WithEvents btnEmojis As Tundra.StylizedButton
    Friend WithEvents btnWebcam As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel8 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnImportFile As Tundra.StylizedButton
    Friend WithEvents Label9 As Label
    Friend WithEvents DoubleBufferedPanel9 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnRemoveBullets As Tundra.StylizedButton
    Friend WithEvents btnAddBullets As Tundra.StylizedButton
    Friend WithEvents Label10 As Label
    Friend WithEvents btnEdit As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel20 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnApply As Tundra.StylizedButton
    Friend WithEvents btnDefault As Tundra.StylizedButton
    Friend WithEvents Label13 As Label
    Friend WithEvents btnQuickUndo As Tundra.StylizedButton
    Friend WithEvents btnQuickRedo As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel17 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnQuickSymbols As Tundra.StylizedButton
    Friend WithEvents btnQuickAccents As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel21 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnQuickOpen As Tundra.StylizedButton
    Friend WithEvents btnQuickSave As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel22 As Tundra.DoubleBufferedPanel
    Friend WithEvents StylizedButton1 As Tundra.StylizedButton
    Friend WithEvents StylizedRadioButton1 As Tundra.StylizedRadioButton
    Friend WithEvents DoubleBufferedPanel23 As Tundra.DoubleBufferedPanel
    Friend WithEvents lblDictionary As Label
End Class
