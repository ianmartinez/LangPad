<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CharacterEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharacterEditor))
        Me.tcCharacters = New System.Windows.Forms.TabControl()
        Me.tpLocal = New System.Windows.Forms.TabPage()
        Me.LocalToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.LocalCharPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.LocalToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ImportLocalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExportLocalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearLocalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tpFile = New System.Windows.Forms.TabPage()
        Me.FileToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.FilePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.FileToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ImportFileToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExportFileToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearFileToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tpExtended = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpLatin = New System.Windows.Forms.TabPage()
        Me.LatinExtendedLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpCyrillic = New System.Windows.Forms.TabPage()
        Me.CyrillicExtendedPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpGreek = New System.Windows.Forms.TabPage()
        Me.GreekExtendedPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpIPA = New System.Windows.Forms.TabPage()
        Me.tcIPA = New System.Windows.Forms.TabControl()
        Me.ConsonantsTabPage = New System.Windows.Forms.TabPage()
        Me.ConsonantsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AffricatesTabPage = New System.Windows.Forms.TabPage()
        Me.AffricatesLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.VowelsTabPage = New System.Windows.Forms.TabPage()
        Me.VowelsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToneIntonationTabPage = New System.Windows.Forms.TabPage()
        Me.ToneIntonationLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.DiacriticsTabPage = New System.Windows.Forms.TabPage()
        Me.DiacriticsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SuprasegmentalsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpSearch = New System.Windows.Forms.TabPage()
        Me.SearchToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.SearchCharactersPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SearchQueryTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SearchModeDropDown = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.pnlModifyChar = New System.Windows.Forms.Panel()
        Me.gbAccents = New System.Windows.Forms.GroupBox()
        Me.AccentsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAffricate = New System.Windows.Forms.Button()
        Me.btnLowercase = New System.Windows.Forms.Button()
        Me.btnUppercase = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnAddToLocal = New System.Windows.Forms.Button()
        Me.btnCharacter = New System.Windows.Forms.Button()
        Me.txtCharacter = New System.Windows.Forms.TextBox()
        Me.cbSmartReplace = New System.Windows.Forms.CheckBox()
        Me.btnAddToFile = New System.Windows.Forms.Button()
        Me.btnCopyToClipboard = New System.Windows.Forms.Button()
        Me.menuCharButton = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToEditorCharacterMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceEditorCharacterMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToClipboardMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToFileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToLocalMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveCharSplitter = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.pnlSmartReplace = New TundraLib.DoubleBufferedPanel()
        Me.tcCharacters.SuspendLayout()
        Me.tpLocal.SuspendLayout()
        Me.LocalToolStripContainer.ContentPanel.SuspendLayout()
        Me.LocalToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.LocalToolStripContainer.SuspendLayout()
        Me.LocalToolStrip.SuspendLayout()
        Me.tpFile.SuspendLayout()
        Me.FileToolStripContainer.ContentPanel.SuspendLayout()
        Me.FileToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.FileToolStripContainer.SuspendLayout()
        Me.FileToolStrip.SuspendLayout()
        Me.tpExtended.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpLatin.SuspendLayout()
        Me.tpCyrillic.SuspendLayout()
        Me.tpGreek.SuspendLayout()
        Me.tpIPA.SuspendLayout()
        Me.tcIPA.SuspendLayout()
        Me.ConsonantsTabPage.SuspendLayout()
        Me.AffricatesTabPage.SuspendLayout()
        Me.VowelsTabPage.SuspendLayout()
        Me.ToneIntonationTabPage.SuspendLayout()
        Me.DiacriticsTabPage.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tpSearch.SuspendLayout()
        Me.SearchToolStripContainer.ContentPanel.SuspendLayout()
        Me.SearchToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.SearchToolStripContainer.SuspendLayout()
        Me.SearchToolStrip.SuspendLayout()
        Me.pnlModifyChar.SuspendLayout()
        Me.gbAccents.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.menuCharButton.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcCharacters
        '
        Me.tcCharacters.Controls.Add(Me.tpLocal)
        Me.tcCharacters.Controls.Add(Me.tpFile)
        Me.tcCharacters.Controls.Add(Me.tpExtended)
        Me.tcCharacters.Controls.Add(Me.tpIPA)
        Me.tcCharacters.Controls.Add(Me.tpSearch)
        Me.tcCharacters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcCharacters.Location = New System.Drawing.Point(0, 0)
        Me.tcCharacters.Multiline = True
        Me.tcCharacters.Name = "tcCharacters"
        Me.tcCharacters.SelectedIndex = 0
        Me.tcCharacters.Size = New System.Drawing.Size(340, 288)
        Me.tcCharacters.TabIndex = 74
        '
        'tpLocal
        '
        Me.tpLocal.Controls.Add(Me.LocalToolStripContainer)
        Me.tpLocal.Location = New System.Drawing.Point(4, 22)
        Me.tpLocal.Name = "tpLocal"
        Me.tpLocal.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLocal.Size = New System.Drawing.Size(292, 262)
        Me.tpLocal.TabIndex = 1
        Me.tpLocal.Text = "Local"
        Me.tpLocal.UseVisualStyleBackColor = True
        '
        'LocalToolStripContainer
        '
        '
        'LocalToolStripContainer.ContentPanel
        '
        Me.LocalToolStripContainer.ContentPanel.Controls.Add(Me.LocalCharPanel)
        Me.LocalToolStripContainer.ContentPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.LocalToolStripContainer.ContentPanel.Size = New System.Drawing.Size(286, 227)
        Me.LocalToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalToolStripContainer.Location = New System.Drawing.Point(3, 3)
        Me.LocalToolStripContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.LocalToolStripContainer.Name = "LocalToolStripContainer"
        Me.LocalToolStripContainer.Size = New System.Drawing.Size(286, 256)
        Me.LocalToolStripContainer.TabIndex = 83
        '
        'LocalToolStripContainer.TopToolStripPanel
        '
        Me.LocalToolStripContainer.TopToolStripPanel.Controls.Add(Me.LocalToolStrip)
        '
        'LocalCharPanel
        '
        Me.LocalCharPanel.AutoScroll = True
        Me.LocalCharPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.LocalCharPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalCharPanel.Location = New System.Drawing.Point(0, 0)
        Me.LocalCharPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LocalCharPanel.Name = "LocalCharPanel"
        Me.LocalCharPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.LocalCharPanel.Size = New System.Drawing.Size(286, 227)
        Me.LocalCharPanel.TabIndex = 10
        '
        'LocalToolStrip
        '
        Me.LocalToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.LocalToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.LocalToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.LocalToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportLocalToolStripButton, Me.ExportLocalToolStripButton, Me.ToolStripSeparator2, Me.ClearLocalToolStripButton})
        Me.LocalToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.LocalToolStrip.Name = "LocalToolStrip"
        Me.LocalToolStrip.Size = New System.Drawing.Size(286, 29)
        Me.LocalToolStrip.Stretch = True
        Me.LocalToolStrip.TabIndex = 0
        '
        'ImportLocalToolStripButton
        '
        Me.ImportLocalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportLocalToolStripButton.Image = CType(resources.GetObject("ImportLocalToolStripButton.Image"), System.Drawing.Image)
        Me.ImportLocalToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportLocalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportLocalToolStripButton.Name = "ImportLocalToolStripButton"
        Me.ImportLocalToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.ImportLocalToolStripButton.Text = "Import..."
        '
        'ExportLocalToolStripButton
        '
        Me.ExportLocalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportLocalToolStripButton.Image = CType(resources.GetObject("ExportLocalToolStripButton.Image"), System.Drawing.Image)
        Me.ExportLocalToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportLocalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportLocalToolStripButton.Name = "ExportLocalToolStripButton"
        Me.ExportLocalToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.ExportLocalToolStripButton.Text = "Export..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'ClearLocalToolStripButton
        '
        Me.ClearLocalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearLocalToolStripButton.Image = CType(resources.GetObject("ClearLocalToolStripButton.Image"), System.Drawing.Image)
        Me.ClearLocalToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClearLocalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearLocalToolStripButton.Name = "ClearLocalToolStripButton"
        Me.ClearLocalToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.ClearLocalToolStripButton.Text = "Clear"
        '
        'tpFile
        '
        Me.tpFile.Controls.Add(Me.FileToolStripContainer)
        Me.tpFile.Location = New System.Drawing.Point(4, 22)
        Me.tpFile.Name = "tpFile"
        Me.tpFile.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFile.Size = New System.Drawing.Size(292, 262)
        Me.tpFile.TabIndex = 0
        Me.tpFile.Text = "File"
        Me.tpFile.UseVisualStyleBackColor = True
        '
        'FileToolStripContainer
        '
        '
        'FileToolStripContainer.ContentPanel
        '
        Me.FileToolStripContainer.ContentPanel.Controls.Add(Me.FilePanel)
        Me.FileToolStripContainer.ContentPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.FileToolStripContainer.ContentPanel.Size = New System.Drawing.Size(286, 227)
        Me.FileToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileToolStripContainer.Location = New System.Drawing.Point(3, 3)
        Me.FileToolStripContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.FileToolStripContainer.Name = "FileToolStripContainer"
        Me.FileToolStripContainer.Size = New System.Drawing.Size(286, 256)
        Me.FileToolStripContainer.TabIndex = 82
        '
        'FileToolStripContainer.TopToolStripPanel
        '
        Me.FileToolStripContainer.TopToolStripPanel.Controls.Add(Me.FileToolStrip)
        '
        'FilePanel
        '
        Me.FilePanel.AutoScroll = True
        Me.FilePanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.FilePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilePanel.Location = New System.Drawing.Point(0, 0)
        Me.FilePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.FilePanel.Name = "FilePanel"
        Me.FilePanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.FilePanel.Size = New System.Drawing.Size(286, 227)
        Me.FilePanel.TabIndex = 10
        '
        'FileToolStrip
        '
        Me.FileToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FileToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FileToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FileToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportFileToolStripButton, Me.ExportFileToolStripButton, Me.ToolStripSeparator5, Me.ClearFileToolStripButton})
        Me.FileToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FileToolStrip.Name = "FileToolStrip"
        Me.FileToolStrip.Size = New System.Drawing.Size(286, 29)
        Me.FileToolStrip.Stretch = True
        Me.FileToolStrip.TabIndex = 0
        '
        'ImportFileToolStripButton
        '
        Me.ImportFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportFileToolStripButton.Image = CType(resources.GetObject("ImportFileToolStripButton.Image"), System.Drawing.Image)
        Me.ImportFileToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportFileToolStripButton.Name = "ImportFileToolStripButton"
        Me.ImportFileToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.ImportFileToolStripButton.Text = "Import..."
        '
        'ExportFileToolStripButton
        '
        Me.ExportFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportFileToolStripButton.Image = CType(resources.GetObject("ExportFileToolStripButton.Image"), System.Drawing.Image)
        Me.ExportFileToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportFileToolStripButton.Name = "ExportFileToolStripButton"
        Me.ExportFileToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.ExportFileToolStripButton.Text = "Export..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 29)
        '
        'ClearFileToolStripButton
        '
        Me.ClearFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearFileToolStripButton.Image = CType(resources.GetObject("ClearFileToolStripButton.Image"), System.Drawing.Image)
        Me.ClearFileToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClearFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearFileToolStripButton.Name = "ClearFileToolStripButton"
        Me.ClearFileToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.ClearFileToolStripButton.Text = "Clear"
        '
        'tpExtended
        '
        Me.tpExtended.Controls.Add(Me.TabControl1)
        Me.tpExtended.Location = New System.Drawing.Point(4, 22)
        Me.tpExtended.Name = "tpExtended"
        Me.tpExtended.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExtended.Size = New System.Drawing.Size(292, 262)
        Me.tpExtended.TabIndex = 2
        Me.tpExtended.Text = "Extended"
        Me.tpExtended.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpLatin)
        Me.TabControl1.Controls.Add(Me.tpCyrillic)
        Me.TabControl1.Controls.Add(Me.tpGreek)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(286, 256)
        Me.TabControl1.TabIndex = 73
        '
        'tpLatin
        '
        Me.tpLatin.Controls.Add(Me.LatinExtendedLayoutPanel)
        Me.tpLatin.Location = New System.Drawing.Point(4, 22)
        Me.tpLatin.Margin = New System.Windows.Forms.Padding(2)
        Me.tpLatin.Name = "tpLatin"
        Me.tpLatin.Size = New System.Drawing.Size(278, 230)
        Me.tpLatin.TabIndex = 0
        Me.tpLatin.Text = "Latin"
        Me.tpLatin.UseVisualStyleBackColor = True
        '
        'LatinExtendedLayoutPanel
        '
        Me.LatinExtendedLayoutPanel.AutoScroll = True
        Me.LatinExtendedLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.LatinExtendedLayoutPanel.AutoSize = True
        Me.LatinExtendedLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LatinExtendedLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.LatinExtendedLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LatinExtendedLayoutPanel.Name = "LatinExtendedLayoutPanel"
        Me.LatinExtendedLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.LatinExtendedLayoutPanel.Size = New System.Drawing.Size(278, 230)
        Me.LatinExtendedLayoutPanel.TabIndex = 9
        '
        'tpCyrillic
        '
        Me.tpCyrillic.Controls.Add(Me.CyrillicExtendedPanel)
        Me.tpCyrillic.Location = New System.Drawing.Point(4, 22)
        Me.tpCyrillic.Margin = New System.Windows.Forms.Padding(2)
        Me.tpCyrillic.Name = "tpCyrillic"
        Me.tpCyrillic.Size = New System.Drawing.Size(278, 230)
        Me.tpCyrillic.TabIndex = 5
        Me.tpCyrillic.Text = "Cyrillic"
        Me.tpCyrillic.UseVisualStyleBackColor = True
        '
        'CyrillicExtendedPanel
        '
        Me.CyrillicExtendedPanel.AutoScroll = True
        Me.CyrillicExtendedPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.CyrillicExtendedPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CyrillicExtendedPanel.Location = New System.Drawing.Point(0, 0)
        Me.CyrillicExtendedPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CyrillicExtendedPanel.Name = "CyrillicExtendedPanel"
        Me.CyrillicExtendedPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.CyrillicExtendedPanel.Size = New System.Drawing.Size(278, 230)
        Me.CyrillicExtendedPanel.TabIndex = 8
        '
        'tpGreek
        '
        Me.tpGreek.Controls.Add(Me.GreekExtendedPanel)
        Me.tpGreek.Location = New System.Drawing.Point(4, 22)
        Me.tpGreek.Margin = New System.Windows.Forms.Padding(2)
        Me.tpGreek.Name = "tpGreek"
        Me.tpGreek.Size = New System.Drawing.Size(278, 230)
        Me.tpGreek.TabIndex = 1
        Me.tpGreek.Text = "Greek"
        Me.tpGreek.UseVisualStyleBackColor = True
        '
        'GreekExtendedPanel
        '
        Me.GreekExtendedPanel.AutoScroll = True
        Me.GreekExtendedPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.GreekExtendedPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GreekExtendedPanel.Location = New System.Drawing.Point(0, 0)
        Me.GreekExtendedPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.GreekExtendedPanel.Name = "GreekExtendedPanel"
        Me.GreekExtendedPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.GreekExtendedPanel.Size = New System.Drawing.Size(278, 230)
        Me.GreekExtendedPanel.TabIndex = 8
        '
        'tpIPA
        '
        Me.tpIPA.Controls.Add(Me.tcIPA)
        Me.tpIPA.Location = New System.Drawing.Point(4, 22)
        Me.tpIPA.Name = "tpIPA"
        Me.tpIPA.Padding = New System.Windows.Forms.Padding(3)
        Me.tpIPA.Size = New System.Drawing.Size(292, 262)
        Me.tpIPA.TabIndex = 3
        Me.tpIPA.Text = "IPA"
        Me.tpIPA.UseVisualStyleBackColor = True
        '
        'tcIPA
        '
        Me.tcIPA.Controls.Add(Me.ConsonantsTabPage)
        Me.tcIPA.Controls.Add(Me.AffricatesTabPage)
        Me.tcIPA.Controls.Add(Me.VowelsTabPage)
        Me.tcIPA.Controls.Add(Me.ToneIntonationTabPage)
        Me.tcIPA.Controls.Add(Me.DiacriticsTabPage)
        Me.tcIPA.Controls.Add(Me.TabPage1)
        Me.tcIPA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcIPA.Location = New System.Drawing.Point(3, 3)
        Me.tcIPA.Name = "tcIPA"
        Me.tcIPA.SelectedIndex = 0
        Me.tcIPA.Size = New System.Drawing.Size(286, 256)
        Me.tcIPA.TabIndex = 72
        '
        'ConsonantsTabPage
        '
        Me.ConsonantsTabPage.Controls.Add(Me.ConsonantsLayoutPanel)
        Me.ConsonantsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ConsonantsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.ConsonantsTabPage.Name = "ConsonantsTabPage"
        Me.ConsonantsTabPage.Size = New System.Drawing.Size(278, 230)
        Me.ConsonantsTabPage.TabIndex = 0
        Me.ConsonantsTabPage.Text = "Consonants"
        Me.ConsonantsTabPage.UseVisualStyleBackColor = True
        '
        'ConsonantsLayoutPanel
        '
        Me.ConsonantsLayoutPanel.AutoScroll = True
        Me.ConsonantsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.ConsonantsLayoutPanel.AutoSize = True
        Me.ConsonantsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsonantsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ConsonantsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsonantsLayoutPanel.Name = "ConsonantsLayoutPanel"
        Me.ConsonantsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.ConsonantsLayoutPanel.Size = New System.Drawing.Size(278, 230)
        Me.ConsonantsLayoutPanel.TabIndex = 7
        '
        'AffricatesTabPage
        '
        Me.AffricatesTabPage.Controls.Add(Me.AffricatesLayoutPanel)
        Me.AffricatesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AffricatesTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.AffricatesTabPage.Name = "AffricatesTabPage"
        Me.AffricatesTabPage.Size = New System.Drawing.Size(278, 230)
        Me.AffricatesTabPage.TabIndex = 5
        Me.AffricatesTabPage.Text = "Affricates"
        Me.AffricatesTabPage.UseVisualStyleBackColor = True
        '
        'AffricatesLayoutPanel
        '
        Me.AffricatesLayoutPanel.AutoScroll = True
        Me.AffricatesLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AffricatesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AffricatesLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AffricatesLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AffricatesLayoutPanel.Name = "AffricatesLayoutPanel"
        Me.AffricatesLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.AffricatesLayoutPanel.Size = New System.Drawing.Size(278, 230)
        Me.AffricatesLayoutPanel.TabIndex = 8
        '
        'VowelsTabPage
        '
        Me.VowelsTabPage.Controls.Add(Me.VowelsLayoutPanel)
        Me.VowelsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.VowelsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.VowelsTabPage.Name = "VowelsTabPage"
        Me.VowelsTabPage.Size = New System.Drawing.Size(278, 230)
        Me.VowelsTabPage.TabIndex = 1
        Me.VowelsTabPage.Text = "Vowels"
        Me.VowelsTabPage.UseVisualStyleBackColor = True
        '
        'VowelsLayoutPanel
        '
        Me.VowelsLayoutPanel.AutoScroll = True
        Me.VowelsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.VowelsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VowelsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.VowelsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.VowelsLayoutPanel.Name = "VowelsLayoutPanel"
        Me.VowelsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.VowelsLayoutPanel.Size = New System.Drawing.Size(278, 230)
        Me.VowelsLayoutPanel.TabIndex = 8
        '
        'ToneIntonationTabPage
        '
        Me.ToneIntonationTabPage.Controls.Add(Me.ToneIntonationLayoutPanel)
        Me.ToneIntonationTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ToneIntonationTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.ToneIntonationTabPage.Name = "ToneIntonationTabPage"
        Me.ToneIntonationTabPage.Size = New System.Drawing.Size(278, 230)
        Me.ToneIntonationTabPage.TabIndex = 4
        Me.ToneIntonationTabPage.Text = "Tone"
        Me.ToneIntonationTabPage.UseVisualStyleBackColor = True
        '
        'ToneIntonationLayoutPanel
        '
        Me.ToneIntonationLayoutPanel.AutoScroll = True
        Me.ToneIntonationLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.ToneIntonationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToneIntonationLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ToneIntonationLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ToneIntonationLayoutPanel.Name = "ToneIntonationLayoutPanel"
        Me.ToneIntonationLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.ToneIntonationLayoutPanel.Size = New System.Drawing.Size(278, 230)
        Me.ToneIntonationLayoutPanel.TabIndex = 10
        '
        'DiacriticsTabPage
        '
        Me.DiacriticsTabPage.Controls.Add(Me.DiacriticsLayoutPanel)
        Me.DiacriticsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DiacriticsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.DiacriticsTabPage.Name = "DiacriticsTabPage"
        Me.DiacriticsTabPage.Size = New System.Drawing.Size(278, 230)
        Me.DiacriticsTabPage.TabIndex = 2
        Me.DiacriticsTabPage.Text = "Diacritics"
        Me.DiacriticsTabPage.UseVisualStyleBackColor = True
        '
        'DiacriticsLayoutPanel
        '
        Me.DiacriticsLayoutPanel.AutoScroll = True
        Me.DiacriticsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.DiacriticsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DiacriticsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.DiacriticsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.DiacriticsLayoutPanel.Name = "DiacriticsLayoutPanel"
        Me.DiacriticsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.DiacriticsLayoutPanel.Size = New System.Drawing.Size(278, 230)
        Me.DiacriticsLayoutPanel.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SuprasegmentalsLayoutPanel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(278, 230)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "Suprasegmentals"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SuprasegmentalsLayoutPanel
        '
        Me.SuprasegmentalsLayoutPanel.AutoScroll = True
        Me.SuprasegmentalsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.SuprasegmentalsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuprasegmentalsLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.SuprasegmentalsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SuprasegmentalsLayoutPanel.Name = "SuprasegmentalsLayoutPanel"
        Me.SuprasegmentalsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.SuprasegmentalsLayoutPanel.Size = New System.Drawing.Size(272, 224)
        Me.SuprasegmentalsLayoutPanel.TabIndex = 9
        '
        'tpSearch
        '
        Me.tpSearch.Controls.Add(Me.SearchToolStripContainer)
        Me.tpSearch.Location = New System.Drawing.Point(4, 22)
        Me.tpSearch.Name = "tpSearch"
        Me.tpSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSearch.Size = New System.Drawing.Size(332, 262)
        Me.tpSearch.TabIndex = 4
        Me.tpSearch.Text = "Search"
        Me.tpSearch.UseVisualStyleBackColor = True
        '
        'SearchToolStripContainer
        '
        '
        'SearchToolStripContainer.ContentPanel
        '
        Me.SearchToolStripContainer.ContentPanel.Controls.Add(Me.SearchCharactersPanel)
        Me.SearchToolStripContainer.ContentPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchToolStripContainer.ContentPanel.Size = New System.Drawing.Size(326, 227)
        Me.SearchToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchToolStripContainer.Location = New System.Drawing.Point(3, 3)
        Me.SearchToolStripContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchToolStripContainer.Name = "SearchToolStripContainer"
        Me.SearchToolStripContainer.Size = New System.Drawing.Size(326, 256)
        Me.SearchToolStripContainer.TabIndex = 84
        '
        'SearchToolStripContainer.TopToolStripPanel
        '
        Me.SearchToolStripContainer.TopToolStripPanel.Controls.Add(Me.SearchToolStrip)
        '
        'SearchCharactersPanel
        '
        Me.SearchCharactersPanel.AutoScroll = True
        Me.SearchCharactersPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.SearchCharactersPanel.AutoSize = True
        Me.SearchCharactersPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchCharactersPanel.Location = New System.Drawing.Point(0, 0)
        Me.SearchCharactersPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchCharactersPanel.Name = "SearchCharactersPanel"
        Me.SearchCharactersPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.SearchCharactersPanel.Size = New System.Drawing.Size(326, 227)
        Me.SearchCharactersPanel.TabIndex = 8
        '
        'SearchToolStrip
        '
        Me.SearchToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.SearchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SearchToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.SearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchQueryTextBox, Me.ToolStripLabel1, Me.SearchModeDropDown, Me.SearchToolStripButton})
        Me.SearchToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SearchToolStrip.Name = "SearchToolStrip"
        Me.SearchToolStrip.Size = New System.Drawing.Size(326, 29)
        Me.SearchToolStrip.Stretch = True
        Me.SearchToolStrip.TabIndex = 0
        '
        'SearchQueryTextBox
        '
        Me.SearchQueryTextBox.Name = "SearchQueryTextBox"
        Me.SearchQueryTextBox.Size = New System.Drawing.Size(135, 29)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(17, 26)
        Me.ToolStripLabel1.Text = "in"
        '
        'SearchModeDropDown
        '
        Me.SearchModeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchModeDropDown.Items.AddRange(New Object() {"All", "Extended Latin", "Extended Cyrillic", "Extended Green", "IPA (All)", "IPA Consonants", "IPA Affricates", "IPA Vowels", "IPA Tone", "IPA Diacritics", "IPA Suprasegmentals"})
        Me.SearchModeDropDown.Name = "SearchModeDropDown"
        Me.SearchModeDropDown.Size = New System.Drawing.Size(121, 29)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchToolStripButton.Image = CType(resources.GetObject("SearchToolStripButton.Image"), System.Drawing.Image)
        Me.SearchToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.SearchToolStripButton.Text = "Clear"
        '
        'pnlModifyChar
        '
        Me.pnlModifyChar.Controls.Add(Me.gbAccents)
        Me.pnlModifyChar.Controls.Add(Me.GroupBox1)
        Me.pnlModifyChar.Controls.Add(Me.pnlTop)
        Me.pnlModifyChar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlModifyChar.Location = New System.Drawing.Point(0, 0)
        Me.pnlModifyChar.Name = "pnlModifyChar"
        Me.pnlModifyChar.Padding = New System.Windows.Forms.Padding(6)
        Me.pnlModifyChar.Size = New System.Drawing.Size(340, 398)
        Me.pnlModifyChar.TabIndex = 75
        '
        'gbAccents
        '
        Me.gbAccents.Controls.Add(Me.AccentsLayoutPanel)
        Me.gbAccents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbAccents.Location = New System.Drawing.Point(6, 163)
        Me.gbAccents.Name = "gbAccents"
        Me.gbAccents.Size = New System.Drawing.Size(328, 229)
        Me.gbAccents.TabIndex = 78
        Me.gbAccents.TabStop = False
        Me.gbAccents.Text = "Accent Marks"
        '
        'AccentsLayoutPanel
        '
        Me.AccentsLayoutPanel.AutoScroll = True
        Me.AccentsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AccentsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccentsLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.AccentsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AccentsLayoutPanel.Name = "AccentsLayoutPanel"
        Me.AccentsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.AccentsLayoutPanel.Size = New System.Drawing.Size(322, 210)
        Me.AccentsLayoutPanel.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnAffricate)
        Me.GroupBox1.Controls.Add(Me.btnLowercase)
        Me.GroupBox1.Controls.Add(Me.btnUppercase)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(6, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 67)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modify Character"
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClear.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(236, 21)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 32)
        Me.btnClear.TabIndex = 79
        Me.btnClear.Text = "Clear"
        '
        'btnAffricate
        '
        Me.btnAffricate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAffricate.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAffricate.Location = New System.Drawing.Point(180, 21)
        Me.btnAffricate.Name = "btnAffricate"
        Me.btnAffricate.Size = New System.Drawing.Size(50, 32)
        Me.btnAffricate.TabIndex = 78
        Me.btnAffricate.Text = "◌͡◌"
        Me.ttMain.SetToolTip(Me.btnAffricate, "Toggle Affricate")
        '
        'btnLowercase
        '
        Me.btnLowercase.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLowercase.Location = New System.Drawing.Point(28, 21)
        Me.btnLowercase.Name = "btnLowercase"
        Me.btnLowercase.Size = New System.Drawing.Size(70, 32)
        Me.btnLowercase.TabIndex = 78
        Me.btnLowercase.Text = "Lowercase"
        '
        'btnUppercase
        '
        Me.btnUppercase.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUppercase.Location = New System.Drawing.Point(104, 21)
        Me.btnUppercase.Name = "btnUppercase"
        Me.btnUppercase.Size = New System.Drawing.Size(70, 32)
        Me.btnUppercase.TabIndex = 77
        Me.btnUppercase.Text = "Uppercase"
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.btnAddToLocal)
        Me.pnlTop.Controls.Add(Me.btnCharacter)
        Me.pnlTop.Controls.Add(Me.txtCharacter)
        Me.pnlTop.Controls.Add(Me.cbSmartReplace)
        Me.pnlTop.Controls.Add(Me.btnAddToFile)
        Me.pnlTop.Controls.Add(Me.pnlSmartReplace)
        Me.pnlTop.Controls.Add(Me.btnCopyToClipboard)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(6, 6)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(328, 90)
        Me.pnlTop.TabIndex = 90
        '
        'btnAddToLocal
        '
        Me.btnAddToLocal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddToLocal.Location = New System.Drawing.Point(188, 52)
        Me.btnAddToLocal.Name = "btnAddToLocal"
        Me.btnAddToLocal.Size = New System.Drawing.Size(55, 32)
        Me.btnAddToLocal.TabIndex = 1
        Me.btnAddToLocal.Text = "Local"
        '
        'btnCharacter
        '
        Me.btnCharacter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCharacter.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCharacter.Location = New System.Drawing.Point(27, 3)
        Me.btnCharacter.Name = "btnCharacter"
        Me.btnCharacter.Size = New System.Drawing.Size(80, 81)
        Me.btnCharacter.TabIndex = 88
        Me.btnCharacter.Text = "a"
        Me.btnCharacter.UseVisualStyleBackColor = True
        '
        'txtCharacter
        '
        Me.txtCharacter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCharacter.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharacter.Location = New System.Drawing.Point(112, 24)
        Me.txtCharacter.Name = "txtCharacter"
        Me.txtCharacter.Size = New System.Drawing.Size(189, 22)
        Me.txtCharacter.TabIndex = 77
        '
        'cbSmartReplace
        '
        Me.cbSmartReplace.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbSmartReplace.AutoSize = True
        Me.cbSmartReplace.Checked = True
        Me.cbSmartReplace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSmartReplace.Location = New System.Drawing.Point(130, 3)
        Me.cbSmartReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSmartReplace.Name = "cbSmartReplace"
        Me.cbSmartReplace.Size = New System.Drawing.Size(96, 17)
        Me.cbSmartReplace.TabIndex = 86
        Me.cbSmartReplace.Text = "Smart Replace"
        Me.cbSmartReplace.UseVisualStyleBackColor = True
        '
        'btnAddToFile
        '
        Me.btnAddToFile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddToFile.Location = New System.Drawing.Point(249, 52)
        Me.btnAddToFile.Name = "btnAddToFile"
        Me.btnAddToFile.Size = New System.Drawing.Size(52, 32)
        Me.btnAddToFile.TabIndex = 76
        Me.btnAddToFile.Text = "File"
        '
        'btnCopyToClipboard
        '
        Me.btnCopyToClipboard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCopyToClipboard.Location = New System.Drawing.Point(112, 52)
        Me.btnCopyToClipboard.Name = "btnCopyToClipboard"
        Me.btnCopyToClipboard.Size = New System.Drawing.Size(70, 32)
        Me.btnCopyToClipboard.TabIndex = 79
        Me.btnCopyToClipboard.Text = "Clipboard"
        '
        'menuCharButton
        '
        Me.menuCharButton.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToEditorCharacterMenuItem, Me.ReplaceEditorCharacterMenuItem, Me.ToolStripSeparator1, Me.CopyToClipboardMenuItem, Me.CopyToFileMenuItem, Me.CopyToLocalMenuItem, Me.RemoveCharSplitter, Me.RemoveToolStripMenuItem})
        Me.menuCharButton.Name = "menuCharButton"
        Me.menuCharButton.Size = New System.Drawing.Size(204, 148)
        '
        'AddToEditorCharacterMenuItem
        '
        Me.AddToEditorCharacterMenuItem.Name = "AddToEditorCharacterMenuItem"
        Me.AddToEditorCharacterMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AddToEditorCharacterMenuItem.Text = "Add to Editor Character"
        '
        'ReplaceEditorCharacterMenuItem
        '
        Me.ReplaceEditorCharacterMenuItem.Name = "ReplaceEditorCharacterMenuItem"
        Me.ReplaceEditorCharacterMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ReplaceEditorCharacterMenuItem.Text = "Replace Editor Character"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        '
        'CopyToClipboardMenuItem
        '
        Me.CopyToClipboardMenuItem.Name = "CopyToClipboardMenuItem"
        Me.CopyToClipboardMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CopyToClipboardMenuItem.Text = "Copy to Clipboard"
        Me.CopyToClipboardMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'CopyToFileMenuItem
        '
        Me.CopyToFileMenuItem.Name = "CopyToFileMenuItem"
        Me.CopyToFileMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CopyToFileMenuItem.Text = "Copy to File"
        '
        'CopyToLocalMenuItem
        '
        Me.CopyToLocalMenuItem.Name = "CopyToLocalMenuItem"
        Me.CopyToLocalMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CopyToLocalMenuItem.Text = "Copy to Local"
        '
        'RemoveCharSplitter
        '
        Me.RemoveCharSplitter.Name = "RemoveCharSplitter"
        Me.RemoveCharSplitter.Size = New System.Drawing.Size(200, 6)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlModifyChar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tcCharacters)
        Me.SplitContainer1.Size = New System.Drawing.Size(340, 690)
        Me.SplitContainer1.SplitterDistance = 398
        Me.SplitContainer1.TabIndex = 76
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'pnlSmartReplace
        '
        Me.pnlSmartReplace.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlSmartReplace.BackColor = System.Drawing.Color.DimGray
        Me.pnlSmartReplace.Location = New System.Drawing.Point(112, 4)
        Me.pnlSmartReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSmartReplace.Name = "pnlSmartReplace"
        Me.pnlSmartReplace.Size = New System.Drawing.Size(14, 15)
        Me.pnlSmartReplace.TabIndex = 87
        '
        'CharacterEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(340, 0)
        Me.Name = "CharacterEditor"
        Me.Size = New System.Drawing.Size(340, 690)
        Me.tcCharacters.ResumeLayout(False)
        Me.tpLocal.ResumeLayout(False)
        Me.LocalToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.LocalToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.LocalToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.LocalToolStripContainer.ResumeLayout(False)
        Me.LocalToolStripContainer.PerformLayout()
        Me.LocalToolStrip.ResumeLayout(False)
        Me.LocalToolStrip.PerformLayout()
        Me.tpFile.ResumeLayout(False)
        Me.FileToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.FileToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.FileToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.FileToolStripContainer.ResumeLayout(False)
        Me.FileToolStripContainer.PerformLayout()
        Me.FileToolStrip.ResumeLayout(False)
        Me.FileToolStrip.PerformLayout()
        Me.tpExtended.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpLatin.ResumeLayout(False)
        Me.tpLatin.PerformLayout()
        Me.tpCyrillic.ResumeLayout(False)
        Me.tpGreek.ResumeLayout(False)
        Me.tpIPA.ResumeLayout(False)
        Me.tcIPA.ResumeLayout(False)
        Me.ConsonantsTabPage.ResumeLayout(False)
        Me.ConsonantsTabPage.PerformLayout()
        Me.AffricatesTabPage.ResumeLayout(False)
        Me.VowelsTabPage.ResumeLayout(False)
        Me.ToneIntonationTabPage.ResumeLayout(False)
        Me.DiacriticsTabPage.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tpSearch.ResumeLayout(False)
        Me.SearchToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.SearchToolStripContainer.ContentPanel.PerformLayout()
        Me.SearchToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.SearchToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.SearchToolStripContainer.ResumeLayout(False)
        Me.SearchToolStripContainer.PerformLayout()
        Me.SearchToolStrip.ResumeLayout(False)
        Me.SearchToolStrip.PerformLayout()
        Me.pnlModifyChar.ResumeLayout(False)
        Me.gbAccents.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.menuCharButton.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcCharacters As TabControl
    Friend WithEvents tpFile As TabPage
    Friend WithEvents tpLocal As TabPage
    Friend WithEvents tpExtended As TabPage
    Friend WithEvents LatinExtendedLayoutPanel As FlowLayoutPanel
    Friend WithEvents tpIPA As TabPage
    Friend WithEvents tcIPA As TabControl
    Friend WithEvents ConsonantsTabPage As TabPage
    Friend WithEvents ConsonantsLayoutPanel As FlowLayoutPanel
    Friend WithEvents AffricatesTabPage As TabPage
    Friend WithEvents AffricatesLayoutPanel As FlowLayoutPanel
    Friend WithEvents VowelsTabPage As TabPage
    Friend WithEvents VowelsLayoutPanel As FlowLayoutPanel
    Friend WithEvents ToneIntonationTabPage As TabPage
    Friend WithEvents ToneIntonationLayoutPanel As FlowLayoutPanel
    Friend WithEvents DiacriticsTabPage As TabPage
    Friend WithEvents DiacriticsLayoutPanel As FlowLayoutPanel
    Friend WithEvents FilePanel As FlowLayoutPanel
    Friend WithEvents LocalCharPanel As FlowLayoutPanel
    Friend WithEvents pnlModifyChar As Panel
    Friend WithEvents gbAccents As GroupBox
    Friend WithEvents AccentsLayoutPanel As FlowLayoutPanel
    Friend WithEvents txtCharacter As TextBox
    Friend WithEvents btnAddToFile As Button
    Friend WithEvents btnAddToLocal As Button
    Friend WithEvents btnCopyToClipboard As Button
    Friend WithEvents pnlSmartReplace As TundraLib.DoubleBufferedPanel
    Friend WithEvents cbSmartReplace As CheckBox
    Friend WithEvents btnCharacter As Button
    Friend WithEvents menuCharButton As ContextMenuStrip
    Friend WithEvents ReplaceEditorCharacterMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CopyToFileMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToLocalMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToClipboardMenuItem As ToolStripMenuItem
    Friend WithEvents btnLowercase As Button
    Friend WithEvents btnUppercase As Button
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents AddToEditorCharacterMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAffricate As Button
    Friend WithEvents tpSearch As TabPage
    Friend WithEvents SearchCharactersPanel As FlowLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpLatin As TabPage
    Friend WithEvents tpCyrillic As TabPage
    Friend WithEvents CyrillicExtendedPanel As FlowLayoutPanel
    Friend WithEvents tpGreek As TabPage
    Friend WithEvents GreekExtendedPanel As FlowLayoutPanel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SuprasegmentalsLayoutPanel As FlowLayoutPanel
    Friend WithEvents btnClear As Button
    Friend WithEvents RemoveCharSplitter As ToolStripSeparator
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripContainer As ToolStripContainer
    Friend WithEvents FileToolStrip As ToolStrip
    Friend WithEvents ImportFileToolStripButton As ToolStripButton
    Friend WithEvents ExportFileToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ClearFileToolStripButton As ToolStripButton
    Friend WithEvents LocalToolStripContainer As ToolStripContainer
    Friend WithEvents LocalToolStrip As ToolStrip
    Friend WithEvents ImportLocalToolStripButton As ToolStripButton
    Friend WithEvents ExportLocalToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ClearLocalToolStripButton As ToolStripButton
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents SearchToolStripContainer As ToolStripContainer
    Friend WithEvents SearchToolStrip As ToolStrip
    Friend WithEvents SearchQueryTextBox As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents SearchModeDropDown As ToolStripComboBox
    Friend WithEvents SearchToolStripButton As ToolStripButton
End Class
