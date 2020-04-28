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
        Me.CharCategoriesTab = New System.Windows.Forms.TabControl()
        Me.LocalTab = New System.Windows.Forms.TabPage()
        Me.LocalToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.LocalPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.LocalToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ImportLocalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExportLocalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearLocalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FileTab = New System.Windows.Forms.TabPage()
        Me.FileToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.FilePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.FileToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ImportFileToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExportFileToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearFileToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExtendedTab = New System.Windows.Forms.TabPage()
        Me.ExtendedCharTabControl = New System.Windows.Forms.TabControl()
        Me.LatinTab = New System.Windows.Forms.TabPage()
        Me.LatinPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CyrillicTab = New System.Windows.Forms.TabPage()
        Me.CyrillicPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.GreekTab = New System.Windows.Forms.TabPage()
        Me.GreekPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.IpaTab = New System.Windows.Forms.TabPage()
        Me.IpaTabControl = New System.Windows.Forms.TabControl()
        Me.ConsonantsTabPage = New System.Windows.Forms.TabPage()
        Me.ConsonantsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AffricatesTab = New System.Windows.Forms.TabPage()
        Me.AffricatesPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.VowelsTab = New System.Windows.Forms.TabPage()
        Me.VowelPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToneIntonationTab = New System.Windows.Forms.TabPage()
        Me.ToneIntonationPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.DiacriticsTab = New System.Windows.Forms.TabPage()
        Me.DiacriticsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuprasegmentalsTab = New System.Windows.Forms.TabPage()
        Me.SuprasegmentalsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SearchTab = New System.Windows.Forms.TabPage()
        Me.SearchToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.SearchCharPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SearchQueryTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CharSearchInLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SearchModeDropDown = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ModifyCharPanel = New System.Windows.Forms.Panel()
        Me.AccentGroupBox = New System.Windows.Forms.GroupBox()
        Me.AccentsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ModifyCharGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.AffricateButton = New System.Windows.Forms.Button()
        Me.LowercaseButton = New System.Windows.Forms.Button()
        Me.UppercaseButton = New System.Windows.Forms.Button()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.AddToLocalButton = New System.Windows.Forms.Button()
        Me.CharacterButton = New System.Windows.Forms.Button()
        Me.CharacterTextBox = New System.Windows.Forms.TextBox()
        Me.SmartReplaceCheck = New System.Windows.Forms.CheckBox()
        Me.AddToFileButton = New System.Windows.Forms.Button()
        Me.SmartReplaceIndicator = New LangPadSupport.DoubleBufferedPanel()
        Me.CopyToClipboardButton = New System.Windows.Forms.Button()
        Me.CharButtonMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToEditorCharacterMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceEditorCharacterMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToClipboardMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToFileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToLocalMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveCharSplitter = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BracketsTab = New System.Windows.Forms.TabPage()
        Me.BracketsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CharCategoriesTab.SuspendLayout()
        Me.LocalTab.SuspendLayout()
        Me.LocalToolStripContainer.ContentPanel.SuspendLayout()
        Me.LocalToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.LocalToolStripContainer.SuspendLayout()
        Me.LocalToolStrip.SuspendLayout()
        Me.FileTab.SuspendLayout()
        Me.FileToolStripContainer.ContentPanel.SuspendLayout()
        Me.FileToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.FileToolStripContainer.SuspendLayout()
        Me.FileToolStrip.SuspendLayout()
        Me.ExtendedTab.SuspendLayout()
        Me.ExtendedCharTabControl.SuspendLayout()
        Me.LatinTab.SuspendLayout()
        Me.CyrillicTab.SuspendLayout()
        Me.GreekTab.SuspendLayout()
        Me.IpaTab.SuspendLayout()
        Me.IpaTabControl.SuspendLayout()
        Me.ConsonantsTabPage.SuspendLayout()
        Me.AffricatesTab.SuspendLayout()
        Me.VowelsTab.SuspendLayout()
        Me.ToneIntonationTab.SuspendLayout()
        Me.DiacriticsTab.SuspendLayout()
        Me.SuprasegmentalsTab.SuspendLayout()
        Me.SearchTab.SuspendLayout()
        Me.SearchToolStripContainer.ContentPanel.SuspendLayout()
        Me.SearchToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.SearchToolStripContainer.SuspendLayout()
        Me.SearchToolStrip.SuspendLayout()
        Me.ModifyCharPanel.SuspendLayout()
        Me.AccentGroupBox.SuspendLayout()
        Me.ModifyCharGroupBox.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.CharButtonMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.BracketsTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'CharCategoriesTab
        '
        Me.CharCategoriesTab.Controls.Add(Me.LocalTab)
        Me.CharCategoriesTab.Controls.Add(Me.FileTab)
        Me.CharCategoriesTab.Controls.Add(Me.ExtendedTab)
        Me.CharCategoriesTab.Controls.Add(Me.IpaTab)
        Me.CharCategoriesTab.Controls.Add(Me.BracketsTab)
        Me.CharCategoriesTab.Controls.Add(Me.SearchTab)
        Me.CharCategoriesTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CharCategoriesTab.Location = New System.Drawing.Point(0, 0)
        Me.CharCategoriesTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CharCategoriesTab.Multiline = True
        Me.CharCategoriesTab.Name = "CharCategoriesTab"
        Me.CharCategoriesTab.SelectedIndex = 0
        Me.CharCategoriesTab.Size = New System.Drawing.Size(542, 282)
        Me.CharCategoriesTab.TabIndex = 74
        '
        'LocalTab
        '
        Me.LocalTab.Controls.Add(Me.LocalToolStripContainer)
        Me.LocalTab.Location = New System.Drawing.Point(4, 29)
        Me.LocalTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LocalTab.Name = "LocalTab"
        Me.LocalTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LocalTab.Size = New System.Drawing.Size(534, 249)
        Me.LocalTab.TabIndex = 1
        Me.LocalTab.Text = "Local"
        Me.LocalTab.UseVisualStyleBackColor = True
        '
        'LocalToolStripContainer
        '
        '
        'LocalToolStripContainer.ContentPanel
        '
        Me.LocalToolStripContainer.ContentPanel.Controls.Add(Me.LocalPanel)
        Me.LocalToolStripContainer.ContentPanel.Size = New System.Drawing.Size(526, 198)
        Me.LocalToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalToolStripContainer.Location = New System.Drawing.Point(4, 5)
        Me.LocalToolStripContainer.Name = "LocalToolStripContainer"
        Me.LocalToolStripContainer.Size = New System.Drawing.Size(526, 239)
        Me.LocalToolStripContainer.TabIndex = 83
        '
        'LocalToolStripContainer.TopToolStripPanel
        '
        Me.LocalToolStripContainer.TopToolStripPanel.Controls.Add(Me.LocalToolStrip)
        '
        'LocalPanel
        '
        Me.LocalPanel.AutoScroll = True
        Me.LocalPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.LocalPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalPanel.Location = New System.Drawing.Point(0, 0)
        Me.LocalPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.LocalPanel.Name = "LocalPanel"
        Me.LocalPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.LocalPanel.Size = New System.Drawing.Size(526, 198)
        Me.LocalPanel.TabIndex = 10
        '
        'LocalToolStrip
        '
        Me.LocalToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.LocalToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.LocalToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.LocalToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportLocalToolStripButton, Me.ExportLocalToolStripButton, Me.ToolStripSeparator2, Me.ClearLocalToolStripButton})
        Me.LocalToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.LocalToolStrip.Name = "LocalToolStrip"
        Me.LocalToolStrip.Size = New System.Drawing.Size(526, 41)
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
        Me.ImportLocalToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ImportLocalToolStripButton.Text = "Import..."
        '
        'ExportLocalToolStripButton
        '
        Me.ExportLocalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportLocalToolStripButton.Image = CType(resources.GetObject("ExportLocalToolStripButton.Image"), System.Drawing.Image)
        Me.ExportLocalToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportLocalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportLocalToolStripButton.Name = "ExportLocalToolStripButton"
        Me.ExportLocalToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ExportLocalToolStripButton.Text = "Export..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 41)
        '
        'ClearLocalToolStripButton
        '
        Me.ClearLocalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearLocalToolStripButton.Image = CType(resources.GetObject("ClearLocalToolStripButton.Image"), System.Drawing.Image)
        Me.ClearLocalToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClearLocalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearLocalToolStripButton.Name = "ClearLocalToolStripButton"
        Me.ClearLocalToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ClearLocalToolStripButton.Text = "Clear"
        '
        'FileTab
        '
        Me.FileTab.Controls.Add(Me.FileToolStripContainer)
        Me.FileTab.Location = New System.Drawing.Point(4, 29)
        Me.FileTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FileTab.Name = "FileTab"
        Me.FileTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FileTab.Size = New System.Drawing.Size(534, 249)
        Me.FileTab.TabIndex = 0
        Me.FileTab.Text = "File"
        Me.FileTab.UseVisualStyleBackColor = True
        '
        'FileToolStripContainer
        '
        '
        'FileToolStripContainer.ContentPanel
        '
        Me.FileToolStripContainer.ContentPanel.Controls.Add(Me.FilePanel)
        Me.FileToolStripContainer.ContentPanel.Size = New System.Drawing.Size(526, 198)
        Me.FileToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileToolStripContainer.Location = New System.Drawing.Point(4, 5)
        Me.FileToolStripContainer.Name = "FileToolStripContainer"
        Me.FileToolStripContainer.Size = New System.Drawing.Size(526, 239)
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
        Me.FilePanel.Margin = New System.Windows.Forms.Padding(6)
        Me.FilePanel.Name = "FilePanel"
        Me.FilePanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.FilePanel.Size = New System.Drawing.Size(526, 198)
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
        Me.FileToolStrip.Size = New System.Drawing.Size(526, 41)
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
        Me.ImportFileToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ImportFileToolStripButton.Text = "Import..."
        '
        'ExportFileToolStripButton
        '
        Me.ExportFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportFileToolStripButton.Image = CType(resources.GetObject("ExportFileToolStripButton.Image"), System.Drawing.Image)
        Me.ExportFileToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportFileToolStripButton.Name = "ExportFileToolStripButton"
        Me.ExportFileToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ExportFileToolStripButton.Text = "Export..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 41)
        '
        'ClearFileToolStripButton
        '
        Me.ClearFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearFileToolStripButton.Image = CType(resources.GetObject("ClearFileToolStripButton.Image"), System.Drawing.Image)
        Me.ClearFileToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClearFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearFileToolStripButton.Name = "ClearFileToolStripButton"
        Me.ClearFileToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ClearFileToolStripButton.Text = "Clear"
        '
        'ExtendedTab
        '
        Me.ExtendedTab.Controls.Add(Me.ExtendedCharTabControl)
        Me.ExtendedTab.Location = New System.Drawing.Point(4, 29)
        Me.ExtendedTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ExtendedTab.Name = "ExtendedTab"
        Me.ExtendedTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ExtendedTab.Size = New System.Drawing.Size(534, 249)
        Me.ExtendedTab.TabIndex = 2
        Me.ExtendedTab.Text = "Extended"
        Me.ExtendedTab.UseVisualStyleBackColor = True
        '
        'ExtendedCharTabControl
        '
        Me.ExtendedCharTabControl.Controls.Add(Me.LatinTab)
        Me.ExtendedCharTabControl.Controls.Add(Me.CyrillicTab)
        Me.ExtendedCharTabControl.Controls.Add(Me.GreekTab)
        Me.ExtendedCharTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExtendedCharTabControl.Location = New System.Drawing.Point(4, 5)
        Me.ExtendedCharTabControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ExtendedCharTabControl.Name = "ExtendedCharTabControl"
        Me.ExtendedCharTabControl.SelectedIndex = 0
        Me.ExtendedCharTabControl.Size = New System.Drawing.Size(526, 239)
        Me.ExtendedCharTabControl.TabIndex = 73
        '
        'LatinTab
        '
        Me.LatinTab.Controls.Add(Me.LatinPanel)
        Me.LatinTab.Location = New System.Drawing.Point(4, 29)
        Me.LatinTab.Name = "LatinTab"
        Me.LatinTab.Size = New System.Drawing.Size(518, 206)
        Me.LatinTab.TabIndex = 0
        Me.LatinTab.Text = "Latin"
        Me.LatinTab.UseVisualStyleBackColor = True
        '
        'LatinPanel
        '
        Me.LatinPanel.AutoScroll = True
        Me.LatinPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.LatinPanel.AutoSize = True
        Me.LatinPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LatinPanel.Location = New System.Drawing.Point(0, 0)
        Me.LatinPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.LatinPanel.Name = "LatinPanel"
        Me.LatinPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.LatinPanel.Size = New System.Drawing.Size(518, 206)
        Me.LatinPanel.TabIndex = 9
        '
        'CyrillicTab
        '
        Me.CyrillicTab.Controls.Add(Me.CyrillicPanel)
        Me.CyrillicTab.Location = New System.Drawing.Point(4, 29)
        Me.CyrillicTab.Name = "CyrillicTab"
        Me.CyrillicTab.Size = New System.Drawing.Size(486, 206)
        Me.CyrillicTab.TabIndex = 5
        Me.CyrillicTab.Text = "Cyrillic"
        Me.CyrillicTab.UseVisualStyleBackColor = True
        '
        'CyrillicPanel
        '
        Me.CyrillicPanel.AutoScroll = True
        Me.CyrillicPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.CyrillicPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CyrillicPanel.Location = New System.Drawing.Point(0, 0)
        Me.CyrillicPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.CyrillicPanel.Name = "CyrillicPanel"
        Me.CyrillicPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.CyrillicPanel.Size = New System.Drawing.Size(486, 206)
        Me.CyrillicPanel.TabIndex = 8
        '
        'GreekTab
        '
        Me.GreekTab.Controls.Add(Me.GreekPanel)
        Me.GreekTab.Location = New System.Drawing.Point(4, 29)
        Me.GreekTab.Name = "GreekTab"
        Me.GreekTab.Size = New System.Drawing.Size(486, 206)
        Me.GreekTab.TabIndex = 1
        Me.GreekTab.Text = "Greek"
        Me.GreekTab.UseVisualStyleBackColor = True
        '
        'GreekPanel
        '
        Me.GreekPanel.AutoScroll = True
        Me.GreekPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.GreekPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GreekPanel.Location = New System.Drawing.Point(0, 0)
        Me.GreekPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.GreekPanel.Name = "GreekPanel"
        Me.GreekPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.GreekPanel.Size = New System.Drawing.Size(486, 206)
        Me.GreekPanel.TabIndex = 8
        '
        'IpaTab
        '
        Me.IpaTab.Controls.Add(Me.IpaTabControl)
        Me.IpaTab.Location = New System.Drawing.Point(4, 29)
        Me.IpaTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IpaTab.Name = "IpaTab"
        Me.IpaTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IpaTab.Size = New System.Drawing.Size(534, 249)
        Me.IpaTab.TabIndex = 3
        Me.IpaTab.Text = "IPA"
        Me.IpaTab.UseVisualStyleBackColor = True
        '
        'IpaTabControl
        '
        Me.IpaTabControl.Controls.Add(Me.ConsonantsTabPage)
        Me.IpaTabControl.Controls.Add(Me.AffricatesTab)
        Me.IpaTabControl.Controls.Add(Me.VowelsTab)
        Me.IpaTabControl.Controls.Add(Me.ToneIntonationTab)
        Me.IpaTabControl.Controls.Add(Me.DiacriticsTab)
        Me.IpaTabControl.Controls.Add(Me.SuprasegmentalsTab)
        Me.IpaTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IpaTabControl.Location = New System.Drawing.Point(4, 5)
        Me.IpaTabControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IpaTabControl.Name = "IpaTabControl"
        Me.IpaTabControl.SelectedIndex = 0
        Me.IpaTabControl.Size = New System.Drawing.Size(526, 239)
        Me.IpaTabControl.TabIndex = 72
        '
        'ConsonantsTabPage
        '
        Me.ConsonantsTabPage.Controls.Add(Me.ConsonantsLayoutPanel)
        Me.ConsonantsTabPage.Location = New System.Drawing.Point(4, 29)
        Me.ConsonantsTabPage.Name = "ConsonantsTabPage"
        Me.ConsonantsTabPage.Size = New System.Drawing.Size(518, 206)
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
        Me.ConsonantsLayoutPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.ConsonantsLayoutPanel.Name = "ConsonantsLayoutPanel"
        Me.ConsonantsLayoutPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.ConsonantsLayoutPanel.Size = New System.Drawing.Size(518, 206)
        Me.ConsonantsLayoutPanel.TabIndex = 7
        '
        'AffricatesTab
        '
        Me.AffricatesTab.Controls.Add(Me.AffricatesPanel)
        Me.AffricatesTab.Location = New System.Drawing.Point(4, 29)
        Me.AffricatesTab.Name = "AffricatesTab"
        Me.AffricatesTab.Size = New System.Drawing.Size(518, 206)
        Me.AffricatesTab.TabIndex = 5
        Me.AffricatesTab.Text = "Affricates"
        Me.AffricatesTab.UseVisualStyleBackColor = True
        '
        'AffricatesPanel
        '
        Me.AffricatesPanel.AutoScroll = True
        Me.AffricatesPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AffricatesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AffricatesPanel.Location = New System.Drawing.Point(0, 0)
        Me.AffricatesPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.AffricatesPanel.Name = "AffricatesPanel"
        Me.AffricatesPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.AffricatesPanel.Size = New System.Drawing.Size(518, 206)
        Me.AffricatesPanel.TabIndex = 8
        '
        'VowelsTab
        '
        Me.VowelsTab.Controls.Add(Me.VowelPanel)
        Me.VowelsTab.Location = New System.Drawing.Point(4, 29)
        Me.VowelsTab.Name = "VowelsTab"
        Me.VowelsTab.Size = New System.Drawing.Size(518, 206)
        Me.VowelsTab.TabIndex = 1
        Me.VowelsTab.Text = "Vowels"
        Me.VowelsTab.UseVisualStyleBackColor = True
        '
        'VowelPanel
        '
        Me.VowelPanel.AutoScroll = True
        Me.VowelPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.VowelPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VowelPanel.Location = New System.Drawing.Point(0, 0)
        Me.VowelPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.VowelPanel.Name = "VowelPanel"
        Me.VowelPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.VowelPanel.Size = New System.Drawing.Size(518, 206)
        Me.VowelPanel.TabIndex = 8
        '
        'ToneIntonationTab
        '
        Me.ToneIntonationTab.Controls.Add(Me.ToneIntonationPanel)
        Me.ToneIntonationTab.Location = New System.Drawing.Point(4, 29)
        Me.ToneIntonationTab.Name = "ToneIntonationTab"
        Me.ToneIntonationTab.Size = New System.Drawing.Size(518, 206)
        Me.ToneIntonationTab.TabIndex = 4
        Me.ToneIntonationTab.Text = "Tones"
        Me.ToneIntonationTab.UseVisualStyleBackColor = True
        '
        'ToneIntonationPanel
        '
        Me.ToneIntonationPanel.AutoScroll = True
        Me.ToneIntonationPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.ToneIntonationPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToneIntonationPanel.Location = New System.Drawing.Point(0, 0)
        Me.ToneIntonationPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.ToneIntonationPanel.Name = "ToneIntonationPanel"
        Me.ToneIntonationPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.ToneIntonationPanel.Size = New System.Drawing.Size(518, 206)
        Me.ToneIntonationPanel.TabIndex = 10
        '
        'DiacriticsTab
        '
        Me.DiacriticsTab.Controls.Add(Me.DiacriticsPanel)
        Me.DiacriticsTab.Location = New System.Drawing.Point(4, 29)
        Me.DiacriticsTab.Name = "DiacriticsTab"
        Me.DiacriticsTab.Size = New System.Drawing.Size(518, 206)
        Me.DiacriticsTab.TabIndex = 2
        Me.DiacriticsTab.Text = "Diacritics"
        Me.DiacriticsTab.UseVisualStyleBackColor = True
        '
        'DiacriticsPanel
        '
        Me.DiacriticsPanel.AutoScroll = True
        Me.DiacriticsPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.DiacriticsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DiacriticsPanel.Location = New System.Drawing.Point(0, 0)
        Me.DiacriticsPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.DiacriticsPanel.Name = "DiacriticsPanel"
        Me.DiacriticsPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.DiacriticsPanel.Size = New System.Drawing.Size(518, 206)
        Me.DiacriticsPanel.TabIndex = 8
        '
        'SuprasegmentalsTab
        '
        Me.SuprasegmentalsTab.Controls.Add(Me.SuprasegmentalsPanel)
        Me.SuprasegmentalsTab.Location = New System.Drawing.Point(4, 29)
        Me.SuprasegmentalsTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SuprasegmentalsTab.Name = "SuprasegmentalsTab"
        Me.SuprasegmentalsTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SuprasegmentalsTab.Size = New System.Drawing.Size(518, 206)
        Me.SuprasegmentalsTab.TabIndex = 6
        Me.SuprasegmentalsTab.Text = "Suprasegmentals"
        Me.SuprasegmentalsTab.UseVisualStyleBackColor = True
        '
        'SuprasegmentalsPanel
        '
        Me.SuprasegmentalsPanel.AutoScroll = True
        Me.SuprasegmentalsPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.SuprasegmentalsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuprasegmentalsPanel.Location = New System.Drawing.Point(4, 5)
        Me.SuprasegmentalsPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.SuprasegmentalsPanel.Name = "SuprasegmentalsPanel"
        Me.SuprasegmentalsPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.SuprasegmentalsPanel.Size = New System.Drawing.Size(510, 196)
        Me.SuprasegmentalsPanel.TabIndex = 9
        '
        'SearchTab
        '
        Me.SearchTab.Controls.Add(Me.SearchToolStripContainer)
        Me.SearchTab.Location = New System.Drawing.Point(4, 29)
        Me.SearchTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchTab.Name = "SearchTab"
        Me.SearchTab.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchTab.Size = New System.Drawing.Size(534, 249)
        Me.SearchTab.TabIndex = 4
        Me.SearchTab.Text = "Search"
        Me.SearchTab.UseVisualStyleBackColor = True
        '
        'SearchToolStripContainer
        '
        '
        'SearchToolStripContainer.ContentPanel
        '
        Me.SearchToolStripContainer.ContentPanel.Controls.Add(Me.SearchCharPanel)
        Me.SearchToolStripContainer.ContentPanel.Size = New System.Drawing.Size(526, 198)
        Me.SearchToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchToolStripContainer.Location = New System.Drawing.Point(4, 5)
        Me.SearchToolStripContainer.Name = "SearchToolStripContainer"
        Me.SearchToolStripContainer.Size = New System.Drawing.Size(526, 239)
        Me.SearchToolStripContainer.TabIndex = 84
        '
        'SearchToolStripContainer.TopToolStripPanel
        '
        Me.SearchToolStripContainer.TopToolStripPanel.Controls.Add(Me.SearchToolStrip)
        '
        'SearchCharPanel
        '
        Me.SearchCharPanel.AutoScroll = True
        Me.SearchCharPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.SearchCharPanel.AutoSize = True
        Me.SearchCharPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchCharPanel.Location = New System.Drawing.Point(0, 0)
        Me.SearchCharPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.SearchCharPanel.Name = "SearchCharPanel"
        Me.SearchCharPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.SearchCharPanel.Size = New System.Drawing.Size(526, 198)
        Me.SearchCharPanel.TabIndex = 8
        '
        'SearchToolStrip
        '
        Me.SearchToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.SearchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SearchToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.SearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchQueryTextBox, Me.CharSearchInLabel, Me.SearchModeDropDown, Me.SearchToolStripButton})
        Me.SearchToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.SearchToolStrip.Name = "SearchToolStrip"
        Me.SearchToolStrip.Size = New System.Drawing.Size(526, 41)
        Me.SearchToolStrip.Stretch = True
        Me.SearchToolStrip.TabIndex = 0
        '
        'SearchQueryTextBox
        '
        Me.SearchQueryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchQueryTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SearchQueryTextBox.Name = "SearchQueryTextBox"
        Me.SearchQueryTextBox.Size = New System.Drawing.Size(180, 41)
        '
        'CharSearchInLabel
        '
        Me.CharSearchInLabel.Name = "CharSearchInLabel"
        Me.CharSearchInLabel.Size = New System.Drawing.Size(26, 36)
        Me.CharSearchInLabel.Text = "in"
        '
        'SearchModeDropDown
        '
        Me.SearchModeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchModeDropDown.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SearchModeDropDown.Items.AddRange(New Object() {"All", "Extended Latin", "Extended Cyrillic", "Extended Greek", "IPA (All)", "IPA Consonants", "IPA Affricates", "IPA Vowels", "IPA Tones", "IPA Diacritics", "IPA Suprasegmentals"})
        Me.SearchModeDropDown.Name = "SearchModeDropDown"
        Me.SearchModeDropDown.Size = New System.Drawing.Size(180, 41)
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchToolStripButton.Image = CType(resources.GetObject("SearchToolStripButton.Image"), System.Drawing.Image)
        Me.SearchToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.SearchToolStripButton.Text = "Search"
        '
        'ModifyCharPanel
        '
        Me.ModifyCharPanel.Controls.Add(Me.AccentGroupBox)
        Me.ModifyCharPanel.Controls.Add(Me.ModifyCharGroupBox)
        Me.ModifyCharPanel.Controls.Add(Me.TopPanel)
        Me.ModifyCharPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModifyCharPanel.Location = New System.Drawing.Point(0, 0)
        Me.ModifyCharPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifyCharPanel.Name = "ModifyCharPanel"
        Me.ModifyCharPanel.Padding = New System.Windows.Forms.Padding(9)
        Me.ModifyCharPanel.Size = New System.Drawing.Size(542, 420)
        Me.ModifyCharPanel.TabIndex = 75
        '
        'AccentGroupBox
        '
        Me.AccentGroupBox.Controls.Add(Me.AccentsPanel)
        Me.AccentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccentGroupBox.Location = New System.Drawing.Point(9, 250)
        Me.AccentGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AccentGroupBox.Name = "AccentGroupBox"
        Me.AccentGroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AccentGroupBox.Size = New System.Drawing.Size(524, 161)
        Me.AccentGroupBox.TabIndex = 78
        Me.AccentGroupBox.TabStop = False
        Me.AccentGroupBox.Text = "Accent Marks"
        '
        'AccentsPanel
        '
        Me.AccentsPanel.AutoScroll = True
        Me.AccentsPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AccentsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccentsPanel.Location = New System.Drawing.Point(4, 24)
        Me.AccentsPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.AccentsPanel.Name = "AccentsPanel"
        Me.AccentsPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.AccentsPanel.Size = New System.Drawing.Size(516, 132)
        Me.AccentsPanel.TabIndex = 10
        '
        'ModifyCharGroupBox
        '
        Me.ModifyCharGroupBox.Controls.Add(Me.ClearButton)
        Me.ModifyCharGroupBox.Controls.Add(Me.AffricateButton)
        Me.ModifyCharGroupBox.Controls.Add(Me.LowercaseButton)
        Me.ModifyCharGroupBox.Controls.Add(Me.UppercaseButton)
        Me.ModifyCharGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModifyCharGroupBox.Location = New System.Drawing.Point(9, 147)
        Me.ModifyCharGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifyCharGroupBox.Name = "ModifyCharGroupBox"
        Me.ModifyCharGroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ModifyCharGroupBox.Size = New System.Drawing.Size(524, 103)
        Me.ModifyCharGroupBox.TabIndex = 89
        Me.ModifyCharGroupBox.TabStop = False
        Me.ModifyCharGroupBox.Text = "Modify Character"
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClearButton.ForeColor = System.Drawing.Color.Firebrick
        Me.ClearButton.Location = New System.Drawing.Point(370, 32)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(98, 49)
        Me.ClearButton.TabIndex = 79
        Me.ClearButton.Text = "Clear"
        '
        'AffricateButton
        '
        Me.AffricateButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AffricateButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AffricateButton.Location = New System.Drawing.Point(286, 32)
        Me.AffricateButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AffricateButton.Name = "AffricateButton"
        Me.AffricateButton.Size = New System.Drawing.Size(75, 49)
        Me.AffricateButton.TabIndex = 78
        Me.AffricateButton.Text = "◌͡◌"
        Me.MainTooltip.SetToolTip(Me.AffricateButton, "Toggle Affricate")
        '
        'LowercaseButton
        '
        Me.LowercaseButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LowercaseButton.Location = New System.Drawing.Point(58, 32)
        Me.LowercaseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LowercaseButton.Name = "LowercaseButton"
        Me.LowercaseButton.Size = New System.Drawing.Size(105, 49)
        Me.LowercaseButton.TabIndex = 78
        Me.LowercaseButton.Text = "Lowercase"
        '
        'UppercaseButton
        '
        Me.UppercaseButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UppercaseButton.Location = New System.Drawing.Point(172, 32)
        Me.UppercaseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UppercaseButton.Name = "UppercaseButton"
        Me.UppercaseButton.Size = New System.Drawing.Size(105, 49)
        Me.UppercaseButton.TabIndex = 77
        Me.UppercaseButton.Text = "Uppercase"
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.AddToLocalButton)
        Me.TopPanel.Controls.Add(Me.CharacterButton)
        Me.TopPanel.Controls.Add(Me.CharacterTextBox)
        Me.TopPanel.Controls.Add(Me.SmartReplaceCheck)
        Me.TopPanel.Controls.Add(Me.AddToFileButton)
        Me.TopPanel.Controls.Add(Me.SmartReplaceIndicator)
        Me.TopPanel.Controls.Add(Me.CopyToClipboardButton)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(9, 9)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(524, 138)
        Me.TopPanel.TabIndex = 90
        '
        'AddToLocalButton
        '
        Me.AddToLocalButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddToLocalButton.Location = New System.Drawing.Point(298, 80)
        Me.AddToLocalButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddToLocalButton.Name = "AddToLocalButton"
        Me.AddToLocalButton.Size = New System.Drawing.Size(82, 49)
        Me.AddToLocalButton.TabIndex = 1
        Me.AddToLocalButton.Text = "Local"
        '
        'CharacterButton
        '
        Me.CharacterButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CharacterButton.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterButton.Location = New System.Drawing.Point(56, 5)
        Me.CharacterButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CharacterButton.Name = "CharacterButton"
        Me.CharacterButton.Size = New System.Drawing.Size(120, 125)
        Me.CharacterButton.TabIndex = 88
        Me.CharacterButton.Text = "a"
        Me.CharacterButton.UseVisualStyleBackColor = True
        '
        'CharacterTextBox
        '
        Me.CharacterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CharacterTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterTextBox.Location = New System.Drawing.Point(184, 37)
        Me.CharacterTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CharacterTextBox.Name = "CharacterTextBox"
        Me.CharacterTextBox.Size = New System.Drawing.Size(282, 29)
        Me.CharacterTextBox.TabIndex = 77
        '
        'SmartReplaceCheck
        '
        Me.SmartReplaceCheck.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SmartReplaceCheck.AutoSize = True
        Me.SmartReplaceCheck.Checked = True
        Me.SmartReplaceCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SmartReplaceCheck.Location = New System.Drawing.Point(211, 5)
        Me.SmartReplaceCheck.Name = "SmartReplaceCheck"
        Me.SmartReplaceCheck.Size = New System.Drawing.Size(141, 24)
        Me.SmartReplaceCheck.TabIndex = 86
        Me.SmartReplaceCheck.Text = "Smart Replace"
        Me.SmartReplaceCheck.UseVisualStyleBackColor = True
        '
        'AddToFileButton
        '
        Me.AddToFileButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddToFileButton.Location = New System.Drawing.Point(390, 80)
        Me.AddToFileButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddToFileButton.Name = "AddToFileButton"
        Me.AddToFileButton.Size = New System.Drawing.Size(78, 49)
        Me.AddToFileButton.TabIndex = 76
        Me.AddToFileButton.Text = "File"
        '
        'SmartReplaceIndicator
        '
        Me.SmartReplaceIndicator.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SmartReplaceIndicator.BackColor = System.Drawing.Color.DimGray
        Me.SmartReplaceIndicator.Location = New System.Drawing.Point(184, 6)
        Me.SmartReplaceIndicator.Name = "SmartReplaceIndicator"
        Me.SmartReplaceIndicator.Size = New System.Drawing.Size(21, 23)
        Me.SmartReplaceIndicator.TabIndex = 87
        '
        'CopyToClipboardButton
        '
        Me.CopyToClipboardButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CopyToClipboardButton.Location = New System.Drawing.Point(184, 80)
        Me.CopyToClipboardButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CopyToClipboardButton.Name = "CopyToClipboardButton"
        Me.CopyToClipboardButton.Size = New System.Drawing.Size(105, 49)
        Me.CopyToClipboardButton.TabIndex = 79
        Me.CopyToClipboardButton.Text = "Clipboard"
        '
        'CharButtonMenu
        '
        Me.CharButtonMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CharButtonMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToEditorCharacterMenuItem, Me.ReplaceEditorCharacterMenuItem, Me.ToolStripSeparator1, Me.CopyToClipboardMenuItem, Me.CopyToFileMenuItem, Me.CopyToLocalMenuItem, Me.RemoveCharSplitter, Me.RemoveToolStripMenuItem})
        Me.CharButtonMenu.Name = "CharButtonMenu"
        Me.CharButtonMenu.Size = New System.Drawing.Size(276, 208)
        '
        'AddToEditorCharacterMenuItem
        '
        Me.AddToEditorCharacterMenuItem.Name = "AddToEditorCharacterMenuItem"
        Me.AddToEditorCharacterMenuItem.Size = New System.Drawing.Size(275, 32)
        Me.AddToEditorCharacterMenuItem.Text = "Add to Editor Character"
        '
        'ReplaceEditorCharacterMenuItem
        '
        Me.ReplaceEditorCharacterMenuItem.Name = "ReplaceEditorCharacterMenuItem"
        Me.ReplaceEditorCharacterMenuItem.Size = New System.Drawing.Size(275, 32)
        Me.ReplaceEditorCharacterMenuItem.Text = "Replace Editor Character"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(272, 6)
        '
        'CopyToClipboardMenuItem
        '
        Me.CopyToClipboardMenuItem.Name = "CopyToClipboardMenuItem"
        Me.CopyToClipboardMenuItem.Size = New System.Drawing.Size(275, 32)
        Me.CopyToClipboardMenuItem.Text = "Copy to Clipboard"
        Me.CopyToClipboardMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'CopyToFileMenuItem
        '
        Me.CopyToFileMenuItem.Name = "CopyToFileMenuItem"
        Me.CopyToFileMenuItem.Size = New System.Drawing.Size(275, 32)
        Me.CopyToFileMenuItem.Text = "Copy to File"
        '
        'CopyToLocalMenuItem
        '
        Me.CopyToLocalMenuItem.Name = "CopyToLocalMenuItem"
        Me.CopyToLocalMenuItem.Size = New System.Drawing.Size(275, 32)
        Me.CopyToLocalMenuItem.Text = "Copy to Local"
        '
        'RemoveCharSplitter
        '
        Me.RemoveCharSplitter.Name = "RemoveCharSplitter"
        Me.RemoveCharSplitter.Size = New System.Drawing.Size(272, 6)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(275, 32)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ModifyCharPanel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CharCategoriesTab)
        Me.SplitContainer1.Size = New System.Drawing.Size(542, 708)
        Me.SplitContainer1.SplitterDistance = 420
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 76
        '
        'SaveDialog
        '
        Me.SaveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'OpenDialog
        '
        Me.OpenDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'BracketsTab
        '
        Me.BracketsTab.Controls.Add(Me.BracketsPanel)
        Me.BracketsTab.Location = New System.Drawing.Point(4, 29)
        Me.BracketsTab.Name = "BracketsTab"
        Me.BracketsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BracketsTab.Size = New System.Drawing.Size(534, 249)
        Me.BracketsTab.TabIndex = 5
        Me.BracketsTab.Text = "Brackets"
        Me.BracketsTab.UseVisualStyleBackColor = True
        '
        'BracketsPanel
        '
        Me.BracketsPanel.AutoScroll = True
        Me.BracketsPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.BracketsPanel.AutoSize = True
        Me.BracketsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BracketsPanel.Location = New System.Drawing.Point(3, 3)
        Me.BracketsPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.BracketsPanel.Name = "BracketsPanel"
        Me.BracketsPanel.Padding = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.BracketsPanel.Size = New System.Drawing.Size(528, 243)
        Me.BracketsPanel.TabIndex = 8
        '
        'CharacterEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(510, 0)
        Me.Name = "CharacterEditor"
        Me.Size = New System.Drawing.Size(542, 708)
        Me.CharCategoriesTab.ResumeLayout(False)
        Me.LocalTab.ResumeLayout(False)
        Me.LocalToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.LocalToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.LocalToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.LocalToolStripContainer.ResumeLayout(False)
        Me.LocalToolStripContainer.PerformLayout()
        Me.LocalToolStrip.ResumeLayout(False)
        Me.LocalToolStrip.PerformLayout()
        Me.FileTab.ResumeLayout(False)
        Me.FileToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.FileToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.FileToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.FileToolStripContainer.ResumeLayout(False)
        Me.FileToolStripContainer.PerformLayout()
        Me.FileToolStrip.ResumeLayout(False)
        Me.FileToolStrip.PerformLayout()
        Me.ExtendedTab.ResumeLayout(False)
        Me.ExtendedCharTabControl.ResumeLayout(False)
        Me.LatinTab.ResumeLayout(False)
        Me.LatinTab.PerformLayout()
        Me.CyrillicTab.ResumeLayout(False)
        Me.GreekTab.ResumeLayout(False)
        Me.IpaTab.ResumeLayout(False)
        Me.IpaTabControl.ResumeLayout(False)
        Me.ConsonantsTabPage.ResumeLayout(False)
        Me.ConsonantsTabPage.PerformLayout()
        Me.AffricatesTab.ResumeLayout(False)
        Me.VowelsTab.ResumeLayout(False)
        Me.ToneIntonationTab.ResumeLayout(False)
        Me.DiacriticsTab.ResumeLayout(False)
        Me.SuprasegmentalsTab.ResumeLayout(False)
        Me.SearchTab.ResumeLayout(False)
        Me.SearchToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.SearchToolStripContainer.ContentPanel.PerformLayout()
        Me.SearchToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.SearchToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.SearchToolStripContainer.ResumeLayout(False)
        Me.SearchToolStripContainer.PerformLayout()
        Me.SearchToolStrip.ResumeLayout(False)
        Me.SearchToolStrip.PerformLayout()
        Me.ModifyCharPanel.ResumeLayout(False)
        Me.AccentGroupBox.ResumeLayout(False)
        Me.ModifyCharGroupBox.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.CharButtonMenu.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.BracketsTab.ResumeLayout(False)
        Me.BracketsTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CharCategoriesTab As TabControl
    Friend WithEvents FileTab As TabPage
    Friend WithEvents LocalTab As TabPage
    Friend WithEvents ExtendedTab As TabPage
    Friend WithEvents LatinPanel As FlowLayoutPanel
    Friend WithEvents IpaTab As TabPage
    Friend WithEvents IpaTabControl As TabControl
    Friend WithEvents ConsonantsTabPage As TabPage
    Friend WithEvents ConsonantsLayoutPanel As FlowLayoutPanel
    Friend WithEvents AffricatesTab As TabPage
    Friend WithEvents AffricatesPanel As FlowLayoutPanel
    Friend WithEvents VowelsTab As TabPage
    Friend WithEvents VowelPanel As FlowLayoutPanel
    Friend WithEvents ToneIntonationTab As TabPage
    Friend WithEvents ToneIntonationPanel As FlowLayoutPanel
    Friend WithEvents DiacriticsTab As TabPage
    Friend WithEvents DiacriticsPanel As FlowLayoutPanel
    Friend WithEvents FilePanel As FlowLayoutPanel
    Friend WithEvents LocalPanel As FlowLayoutPanel
    Friend WithEvents ModifyCharPanel As Panel
    Friend WithEvents AccentGroupBox As GroupBox
    Friend WithEvents AccentsPanel As FlowLayoutPanel
    Friend WithEvents CharacterTextBox As TextBox
    Friend WithEvents AddToFileButton As Button
    Friend WithEvents AddToLocalButton As Button
    Friend WithEvents CopyToClipboardButton As Button
    Friend WithEvents SmartReplaceIndicator As LangPadSupport.DoubleBufferedPanel
    Friend WithEvents SmartReplaceCheck As CheckBox
    Friend WithEvents CharacterButton As Button
    Friend WithEvents CharButtonMenu As ContextMenuStrip
    Friend WithEvents ReplaceEditorCharacterMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CopyToFileMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToLocalMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToClipboardMenuItem As ToolStripMenuItem
    Friend WithEvents LowercaseButton As Button
    Friend WithEvents UppercaseButton As Button
    Friend WithEvents AddToEditorCharacterMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyCharGroupBox As GroupBox
    Friend WithEvents AffricateButton As Button
    Friend WithEvents SearchTab As TabPage
    Friend WithEvents SearchCharPanel As FlowLayoutPanel
    Friend WithEvents ExtendedCharTabControl As TabControl
    Friend WithEvents LatinTab As TabPage
    Friend WithEvents CyrillicTab As TabPage
    Friend WithEvents CyrillicPanel As FlowLayoutPanel
    Friend WithEvents GreekTab As TabPage
    Friend WithEvents GreekPanel As FlowLayoutPanel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SuprasegmentalsTab As TabPage
    Friend WithEvents SuprasegmentalsPanel As FlowLayoutPanel
    Friend WithEvents ClearButton As Button
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
    Friend WithEvents SaveDialog As SaveFileDialog
    Friend WithEvents OpenDialog As OpenFileDialog
    Friend WithEvents SearchToolStripContainer As ToolStripContainer
    Friend WithEvents SearchToolStrip As ToolStrip
    Friend WithEvents SearchQueryTextBox As ToolStripTextBox
    Friend WithEvents CharSearchInLabel As ToolStripLabel
    Friend WithEvents SearchModeDropDown As ToolStripComboBox
    Friend WithEvents SearchToolStripButton As ToolStripButton
    Friend WithEvents MainTooltip As ToolTip
    Friend WithEvents BracketsTab As TabPage
    Friend WithEvents BracketsPanel As FlowLayoutPanel
End Class
