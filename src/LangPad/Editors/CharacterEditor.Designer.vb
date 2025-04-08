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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharacterEditor))
        CharCategoriesTabs = New TabControl()
        LocalTab = New TabPage()
        LocalToolStripContainer = New ToolStripContainer()
        LocalPanel = New FlowLayoutPanel()
        LocalToolStrip = New ToolStrip()
        ImportLocalToolStripButton = New ToolStripButton()
        ExportLocalToolStripButton = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        ClearLocalToolStripButton = New ToolStripButton()
        FileTab = New TabPage()
        FileToolStripContainer = New ToolStripContainer()
        FilePanel = New FlowLayoutPanel()
        FileToolStrip = New ToolStrip()
        ImportFileToolStripButton = New ToolStripButton()
        ExportFileToolStripButton = New ToolStripButton()
        ToolStripSeparator5 = New ToolStripSeparator()
        ClearFileToolStripButton = New ToolStripButton()
        ExtendedTab = New TabPage()
        ExtendedCharTabControl = New TabControl()
        LatinTab = New TabPage()
        LatinPanel = New FlowLayoutPanel()
        CyrillicTab = New TabPage()
        CyrillicPanel = New FlowLayoutPanel()
        GreekTab = New TabPage()
        GreekPanel = New FlowLayoutPanel()
        IpaTab = New TabPage()
        IpaTabControl = New TabControl()
        ConsonantsTab = New TabPage()
        ConsonantsLayoutPanel = New FlowLayoutPanel()
        AffricatesTab = New TabPage()
        AffricatesPanel = New FlowLayoutPanel()
        VowelsTab = New TabPage()
        VowelPanel = New FlowLayoutPanel()
        ToneIntonationTab = New TabPage()
        ToneIntonationPanel = New FlowLayoutPanel()
        DiacriticsTab = New TabPage()
        DiacriticsPanel = New FlowLayoutPanel()
        SuprasegmentalsTab = New TabPage()
        SuprasegmentalsPanel = New FlowLayoutPanel()
        BracketsTab = New TabPage()
        BracketsPanel = New FlowLayoutPanel()
        ShortcutsTab = New TabPage()
        ShortcutsPanel = New FlowLayoutPanel()
        ShortcutButton1 = New LangPadUI.ShortcutButton()
        ShortcutButton2 = New LangPadUI.ShortcutButton()
        ShortcutButton3 = New LangPadUI.ShortcutButton()
        ShortcutButton4 = New LangPadUI.ShortcutButton()
        ShortcutButton5 = New LangPadUI.ShortcutButton()
        ShortcutButton6 = New LangPadUI.ShortcutButton()
        ShortcutButton7 = New LangPadUI.ShortcutButton()
        ShortcutButton8 = New LangPadUI.ShortcutButton()
        ShortcutButton9 = New LangPadUI.ShortcutButton()
        ShortcutButton0 = New LangPadUI.ShortcutButton()
        SearchTab = New TabPage()
        SearchToolStripContainer = New ToolStripContainer()
        SearchCharPanel = New FlowLayoutPanel()
        SearchToolStrip = New ToolStrip()
        SearchQueryTextBox = New ToolStripTextBox()
        CharSearchInLabel = New ToolStripLabel()
        SearchModeDropDown = New ToolStripComboBox()
        SearchToolStripButton = New ToolStripButton()
        ModifyCharPanel = New Panel()
        AccentGroupBox = New GroupBox()
        AccentsPanel = New FlowLayoutPanel()
        ModifyCharGroupBox = New GroupBox()
        ClearButton = New Button()
        AffricateButton = New Button()
        LowercaseButton = New Button()
        UppercaseButton = New Button()
        TopPanel = New Panel()
        AddToLocalButton = New Button()
        CharacterButton = New Button()
        CharButtonMenu = New ContextMenuStrip(components)
        AddToEditorCharacterMenuItem = New ToolStripMenuItem()
        ReplaceEditorCharacterMenuItem = New ToolStripMenuItem()
        CopyCharSeparator = New ToolStripSeparator()
        CopyToClipboardMenuItem = New ToolStripMenuItem()
        CopyToFileMenuItem = New ToolStripMenuItem()
        CopyToLocalMenuItem = New ToolStripMenuItem()
        ShortcutKeySeparator = New ToolStripSeparator()
        ShortcutKeyToolStripMenuItem = New ToolStripMenuItem()
        CTRL1ToolStripMenuItem = New ToolStripMenuItem()
        CTRL2ToolStripMenuItem = New ToolStripMenuItem()
        CTRL3ToolStripMenuItem = New ToolStripMenuItem()
        CTRL4ToolStripMenuItem = New ToolStripMenuItem()
        CTRL5ToolStripMenuItem = New ToolStripMenuItem()
        CTRL6ToolStripMenuItem = New ToolStripMenuItem()
        CTRL7ToolStripMenuItem = New ToolStripMenuItem()
        CTRL8ToolStripMenuItem = New ToolStripMenuItem()
        CTRL9ToolStripMenuItem = New ToolStripMenuItem()
        CTRL0ToolStripMenuItem = New ToolStripMenuItem()
        RemoveCharSeparator = New ToolStripSeparator()
        RemoveToolStripMenuItem = New ToolStripMenuItem()
        CharacterTextBox = New TextBox()
        SmartReplaceCheck = New CheckBox()
        AddToFileButton = New Button()
        SmartReplaceIndicator = New LangPadUI.DoubleBufferedPanel()
        CopyToClipboardButton = New Button()
        MainTooltip = New ToolTip(components)
        SplitContainer1 = New SplitContainer()
        SaveDialog = New SaveFileDialog()
        OpenDialog = New OpenFileDialog()
        ShortcutButtonMenu = New ContextMenuStrip(components)
        ResetKeyToolStripMenuItem = New ToolStripMenuItem()
        ResetAllKeysToolStripMenuItem = New ToolStripMenuItem()
        CharCategoriesTabs.SuspendLayout()
        LocalTab.SuspendLayout()
        LocalToolStripContainer.ContentPanel.SuspendLayout()
        LocalToolStripContainer.TopToolStripPanel.SuspendLayout()
        LocalToolStripContainer.SuspendLayout()
        LocalToolStrip.SuspendLayout()
        FileTab.SuspendLayout()
        FileToolStripContainer.ContentPanel.SuspendLayout()
        FileToolStripContainer.TopToolStripPanel.SuspendLayout()
        FileToolStripContainer.SuspendLayout()
        FileToolStrip.SuspendLayout()
        ExtendedTab.SuspendLayout()
        ExtendedCharTabControl.SuspendLayout()
        LatinTab.SuspendLayout()
        CyrillicTab.SuspendLayout()
        GreekTab.SuspendLayout()
        IpaTab.SuspendLayout()
        IpaTabControl.SuspendLayout()
        ConsonantsTab.SuspendLayout()
        AffricatesTab.SuspendLayout()
        VowelsTab.SuspendLayout()
        ToneIntonationTab.SuspendLayout()
        DiacriticsTab.SuspendLayout()
        SuprasegmentalsTab.SuspendLayout()
        BracketsTab.SuspendLayout()
        ShortcutsTab.SuspendLayout()
        ShortcutsPanel.SuspendLayout()
        SearchTab.SuspendLayout()
        SearchToolStripContainer.ContentPanel.SuspendLayout()
        SearchToolStripContainer.TopToolStripPanel.SuspendLayout()
        SearchToolStripContainer.SuspendLayout()
        SearchToolStrip.SuspendLayout()
        ModifyCharPanel.SuspendLayout()
        AccentGroupBox.SuspendLayout()
        ModifyCharGroupBox.SuspendLayout()
        TopPanel.SuspendLayout()
        CharButtonMenu.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        ShortcutButtonMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' CharCategoriesTabs
        ' 
        CharCategoriesTabs.Controls.Add(LocalTab)
        CharCategoriesTabs.Controls.Add(FileTab)
        CharCategoriesTabs.Controls.Add(ExtendedTab)
        CharCategoriesTabs.Controls.Add(IpaTab)
        CharCategoriesTabs.Controls.Add(BracketsTab)
        CharCategoriesTabs.Controls.Add(ShortcutsTab)
        CharCategoriesTabs.Controls.Add(SearchTab)
        CharCategoriesTabs.Dock = DockStyle.Fill
        CharCategoriesTabs.Location = New Point(0, 0)
        CharCategoriesTabs.Margin = New Padding(5, 6, 5, 6)
        CharCategoriesTabs.Multiline = True
        CharCategoriesTabs.Name = "CharCategoriesTabs"
        CharCategoriesTabs.SelectedIndex = 0
        CharCategoriesTabs.Size = New Size(602, 221)
        CharCategoriesTabs.TabIndex = 74
        ' 
        ' LocalTab
        ' 
        LocalTab.Controls.Add(LocalToolStripContainer)
        LocalTab.Location = New Point(4, 34)
        LocalTab.Margin = New Padding(5, 6, 5, 6)
        LocalTab.Name = "LocalTab"
        LocalTab.Padding = New Padding(5, 6, 5, 6)
        LocalTab.Size = New Size(594, 183)
        LocalTab.TabIndex = 1
        LocalTab.Text = "Local"
        LocalTab.UseVisualStyleBackColor = True
        ' 
        ' LocalToolStripContainer
        ' 
        ' 
        ' LocalToolStripContainer.ContentPanel
        ' 
        LocalToolStripContainer.ContentPanel.Controls.Add(LocalPanel)
        LocalToolStripContainer.ContentPanel.Margin = New Padding(4, 2, 4, 2)
        LocalToolStripContainer.ContentPanel.Size = New Size(584, 130)
        LocalToolStripContainer.Dock = DockStyle.Fill
        LocalToolStripContainer.Location = New Point(5, 6)
        LocalToolStripContainer.Margin = New Padding(4, 2, 4, 2)
        LocalToolStripContainer.Name = "LocalToolStripContainer"
        LocalToolStripContainer.Size = New Size(584, 171)
        LocalToolStripContainer.TabIndex = 83
        ' 
        ' LocalToolStripContainer.TopToolStripPanel
        ' 
        LocalToolStripContainer.TopToolStripPanel.Controls.Add(LocalToolStrip)
        ' 
        ' LocalPanel
        ' 
        LocalPanel.AutoScroll = True
        LocalPanel.AutoScrollMargin = New Size(0, 5)
        LocalPanel.Dock = DockStyle.Fill
        LocalPanel.Location = New Point(0, 0)
        LocalPanel.Margin = New Padding(6, 8, 6, 8)
        LocalPanel.Name = "LocalPanel"
        LocalPanel.Padding = New Padding(6, 8, 0, 8)
        LocalPanel.Size = New Size(584, 130)
        LocalPanel.TabIndex = 10
        ' 
        ' LocalToolStrip
        ' 
        LocalToolStrip.Dock = DockStyle.None
        LocalToolStrip.GripStyle = ToolStripGripStyle.Hidden
        LocalToolStrip.ImageScalingSize = New Size(32, 32)
        LocalToolStrip.Items.AddRange(New ToolStripItem() {ImportLocalToolStripButton, ExportLocalToolStripButton, ToolStripSeparator2, ClearLocalToolStripButton})
        LocalToolStrip.Location = New Point(0, 0)
        LocalToolStrip.Name = "LocalToolStrip"
        LocalToolStrip.Size = New Size(584, 41)
        LocalToolStrip.Stretch = True
        LocalToolStrip.TabIndex = 0
        ' 
        ' ImportLocalToolStripButton
        ' 
        ImportLocalToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ImportLocalToolStripButton.Image = CType(resources.GetObject("ImportLocalToolStripButton.Image"), Image)
        ImportLocalToolStripButton.ImageScaling = ToolStripItemImageScaling.None
        ImportLocalToolStripButton.ImageTransparentColor = Color.Magenta
        ImportLocalToolStripButton.Name = "ImportLocalToolStripButton"
        ImportLocalToolStripButton.Size = New Size(36, 36)
        ImportLocalToolStripButton.Text = "Import..."
        ' 
        ' ExportLocalToolStripButton
        ' 
        ExportLocalToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ExportLocalToolStripButton.Image = CType(resources.GetObject("ExportLocalToolStripButton.Image"), Image)
        ExportLocalToolStripButton.ImageScaling = ToolStripItemImageScaling.None
        ExportLocalToolStripButton.ImageTransparentColor = Color.Magenta
        ExportLocalToolStripButton.Name = "ExportLocalToolStripButton"
        ExportLocalToolStripButton.Size = New Size(36, 36)
        ExportLocalToolStripButton.Text = "Export..."
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 41)
        ' 
        ' ClearLocalToolStripButton
        ' 
        ClearLocalToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ClearLocalToolStripButton.Image = CType(resources.GetObject("ClearLocalToolStripButton.Image"), Image)
        ClearLocalToolStripButton.ImageScaling = ToolStripItemImageScaling.None
        ClearLocalToolStripButton.ImageTransparentColor = Color.Magenta
        ClearLocalToolStripButton.Name = "ClearLocalToolStripButton"
        ClearLocalToolStripButton.Size = New Size(36, 36)
        ClearLocalToolStripButton.Text = "Clear"
        ' 
        ' FileTab
        ' 
        FileTab.Controls.Add(FileToolStripContainer)
        FileTab.Location = New Point(4, 34)
        FileTab.Margin = New Padding(5, 6, 5, 6)
        FileTab.Name = "FileTab"
        FileTab.Padding = New Padding(5, 6, 5, 6)
        FileTab.Size = New Size(594, 183)
        FileTab.TabIndex = 0
        FileTab.Text = "File"
        FileTab.UseVisualStyleBackColor = True
        ' 
        ' FileToolStripContainer
        ' 
        ' 
        ' FileToolStripContainer.ContentPanel
        ' 
        FileToolStripContainer.ContentPanel.Controls.Add(FilePanel)
        FileToolStripContainer.ContentPanel.Margin = New Padding(4, 2, 4, 2)
        FileToolStripContainer.ContentPanel.Size = New Size(584, 130)
        FileToolStripContainer.Dock = DockStyle.Fill
        FileToolStripContainer.Location = New Point(5, 6)
        FileToolStripContainer.Margin = New Padding(4, 2, 4, 2)
        FileToolStripContainer.Name = "FileToolStripContainer"
        FileToolStripContainer.Size = New Size(584, 171)
        FileToolStripContainer.TabIndex = 82
        ' 
        ' FileToolStripContainer.TopToolStripPanel
        ' 
        FileToolStripContainer.TopToolStripPanel.Controls.Add(FileToolStrip)
        ' 
        ' FilePanel
        ' 
        FilePanel.AutoScroll = True
        FilePanel.AutoScrollMargin = New Size(0, 5)
        FilePanel.Dock = DockStyle.Fill
        FilePanel.Location = New Point(0, 0)
        FilePanel.Margin = New Padding(6, 8, 6, 8)
        FilePanel.Name = "FilePanel"
        FilePanel.Padding = New Padding(6, 8, 0, 8)
        FilePanel.Size = New Size(584, 130)
        FilePanel.TabIndex = 10
        ' 
        ' FileToolStrip
        ' 
        FileToolStrip.Dock = DockStyle.None
        FileToolStrip.GripStyle = ToolStripGripStyle.Hidden
        FileToolStrip.ImageScalingSize = New Size(32, 32)
        FileToolStrip.Items.AddRange(New ToolStripItem() {ImportFileToolStripButton, ExportFileToolStripButton, ToolStripSeparator5, ClearFileToolStripButton})
        FileToolStrip.Location = New Point(0, 0)
        FileToolStrip.Name = "FileToolStrip"
        FileToolStrip.Size = New Size(584, 41)
        FileToolStrip.Stretch = True
        FileToolStrip.TabIndex = 0
        ' 
        ' ImportFileToolStripButton
        ' 
        ImportFileToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ImportFileToolStripButton.Image = CType(resources.GetObject("ImportFileToolStripButton.Image"), Image)
        ImportFileToolStripButton.ImageScaling = ToolStripItemImageScaling.None
        ImportFileToolStripButton.ImageTransparentColor = Color.Magenta
        ImportFileToolStripButton.Name = "ImportFileToolStripButton"
        ImportFileToolStripButton.Size = New Size(36, 36)
        ImportFileToolStripButton.Text = "Import..."
        ' 
        ' ExportFileToolStripButton
        ' 
        ExportFileToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ExportFileToolStripButton.Image = CType(resources.GetObject("ExportFileToolStripButton.Image"), Image)
        ExportFileToolStripButton.ImageScaling = ToolStripItemImageScaling.None
        ExportFileToolStripButton.ImageTransparentColor = Color.Magenta
        ExportFileToolStripButton.Name = "ExportFileToolStripButton"
        ExportFileToolStripButton.Size = New Size(36, 36)
        ExportFileToolStripButton.Text = "Export..."
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(6, 41)
        ' 
        ' ClearFileToolStripButton
        ' 
        ClearFileToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ClearFileToolStripButton.Image = CType(resources.GetObject("ClearFileToolStripButton.Image"), Image)
        ClearFileToolStripButton.ImageScaling = ToolStripItemImageScaling.None
        ClearFileToolStripButton.ImageTransparentColor = Color.Magenta
        ClearFileToolStripButton.Name = "ClearFileToolStripButton"
        ClearFileToolStripButton.Size = New Size(36, 36)
        ClearFileToolStripButton.Text = "Clear"
        ' 
        ' ExtendedTab
        ' 
        ExtendedTab.Controls.Add(ExtendedCharTabControl)
        ExtendedTab.Location = New Point(4, 34)
        ExtendedTab.Margin = New Padding(5, 6, 5, 6)
        ExtendedTab.Name = "ExtendedTab"
        ExtendedTab.Padding = New Padding(5, 6, 5, 6)
        ExtendedTab.Size = New Size(594, 183)
        ExtendedTab.TabIndex = 2
        ExtendedTab.Text = "Extended"
        ExtendedTab.UseVisualStyleBackColor = True
        ' 
        ' ExtendedCharTabControl
        ' 
        ExtendedCharTabControl.Controls.Add(LatinTab)
        ExtendedCharTabControl.Controls.Add(CyrillicTab)
        ExtendedCharTabControl.Controls.Add(GreekTab)
        ExtendedCharTabControl.Dock = DockStyle.Fill
        ExtendedCharTabControl.Location = New Point(5, 6)
        ExtendedCharTabControl.Margin = New Padding(5, 6, 5, 6)
        ExtendedCharTabControl.Name = "ExtendedCharTabControl"
        ExtendedCharTabControl.SelectedIndex = 0
        ExtendedCharTabControl.Size = New Size(584, 171)
        ExtendedCharTabControl.TabIndex = 73
        ' 
        ' LatinTab
        ' 
        LatinTab.Controls.Add(LatinPanel)
        LatinTab.Location = New Point(4, 34)
        LatinTab.Margin = New Padding(4, 2, 4, 2)
        LatinTab.Name = "LatinTab"
        LatinTab.Size = New Size(576, 133)
        LatinTab.TabIndex = 0
        LatinTab.Text = "Latin"
        LatinTab.UseVisualStyleBackColor = True
        ' 
        ' LatinPanel
        ' 
        LatinPanel.AutoScroll = True
        LatinPanel.AutoScrollMargin = New Size(0, 5)
        LatinPanel.AutoSize = True
        LatinPanel.Dock = DockStyle.Fill
        LatinPanel.Location = New Point(0, 0)
        LatinPanel.Margin = New Padding(6, 8, 6, 8)
        LatinPanel.Name = "LatinPanel"
        LatinPanel.Padding = New Padding(6, 8, 0, 8)
        LatinPanel.Size = New Size(576, 133)
        LatinPanel.TabIndex = 9
        ' 
        ' CyrillicTab
        ' 
        CyrillicTab.Controls.Add(CyrillicPanel)
        CyrillicTab.Location = New Point(4, 34)
        CyrillicTab.Margin = New Padding(4, 2, 4, 2)
        CyrillicTab.Name = "CyrillicTab"
        CyrillicTab.Size = New Size(574, 130)
        CyrillicTab.TabIndex = 5
        CyrillicTab.Text = "Cyrillic"
        CyrillicTab.UseVisualStyleBackColor = True
        ' 
        ' CyrillicPanel
        ' 
        CyrillicPanel.AutoScroll = True
        CyrillicPanel.AutoScrollMargin = New Size(0, 5)
        CyrillicPanel.Dock = DockStyle.Fill
        CyrillicPanel.Location = New Point(0, 0)
        CyrillicPanel.Margin = New Padding(6, 8, 6, 8)
        CyrillicPanel.Name = "CyrillicPanel"
        CyrillicPanel.Padding = New Padding(6, 8, 0, 8)
        CyrillicPanel.Size = New Size(574, 130)
        CyrillicPanel.TabIndex = 8
        ' 
        ' GreekTab
        ' 
        GreekTab.Controls.Add(GreekPanel)
        GreekTab.Location = New Point(4, 34)
        GreekTab.Margin = New Padding(4, 2, 4, 2)
        GreekTab.Name = "GreekTab"
        GreekTab.Size = New Size(574, 130)
        GreekTab.TabIndex = 1
        GreekTab.Text = "Greek"
        GreekTab.UseVisualStyleBackColor = True
        ' 
        ' GreekPanel
        ' 
        GreekPanel.AutoScroll = True
        GreekPanel.AutoScrollMargin = New Size(0, 5)
        GreekPanel.Dock = DockStyle.Fill
        GreekPanel.Location = New Point(0, 0)
        GreekPanel.Margin = New Padding(6, 8, 6, 8)
        GreekPanel.Name = "GreekPanel"
        GreekPanel.Padding = New Padding(6, 8, 0, 8)
        GreekPanel.Size = New Size(574, 130)
        GreekPanel.TabIndex = 8
        ' 
        ' IpaTab
        ' 
        IpaTab.Controls.Add(IpaTabControl)
        IpaTab.Location = New Point(4, 34)
        IpaTab.Margin = New Padding(5, 6, 5, 6)
        IpaTab.Name = "IpaTab"
        IpaTab.Padding = New Padding(5, 6, 5, 6)
        IpaTab.Size = New Size(594, 183)
        IpaTab.TabIndex = 3
        IpaTab.Text = "IPA"
        IpaTab.UseVisualStyleBackColor = True
        ' 
        ' IpaTabControl
        ' 
        IpaTabControl.Controls.Add(ConsonantsTab)
        IpaTabControl.Controls.Add(AffricatesTab)
        IpaTabControl.Controls.Add(VowelsTab)
        IpaTabControl.Controls.Add(ToneIntonationTab)
        IpaTabControl.Controls.Add(DiacriticsTab)
        IpaTabControl.Controls.Add(SuprasegmentalsTab)
        IpaTabControl.Dock = DockStyle.Fill
        IpaTabControl.Location = New Point(5, 6)
        IpaTabControl.Margin = New Padding(5, 6, 5, 6)
        IpaTabControl.Name = "IpaTabControl"
        IpaTabControl.SelectedIndex = 0
        IpaTabControl.Size = New Size(584, 171)
        IpaTabControl.TabIndex = 72
        ' 
        ' ConsonantsTab
        ' 
        ConsonantsTab.Controls.Add(ConsonantsLayoutPanel)
        ConsonantsTab.Location = New Point(4, 34)
        ConsonantsTab.Margin = New Padding(4, 2, 4, 2)
        ConsonantsTab.Name = "ConsonantsTab"
        ConsonantsTab.Size = New Size(576, 133)
        ConsonantsTab.TabIndex = 0
        ConsonantsTab.Text = "Consonants"
        ConsonantsTab.UseVisualStyleBackColor = True
        ' 
        ' ConsonantsLayoutPanel
        ' 
        ConsonantsLayoutPanel.AutoScroll = True
        ConsonantsLayoutPanel.AutoScrollMargin = New Size(0, 5)
        ConsonantsLayoutPanel.AutoSize = True
        ConsonantsLayoutPanel.Dock = DockStyle.Fill
        ConsonantsLayoutPanel.Location = New Point(0, 0)
        ConsonantsLayoutPanel.Margin = New Padding(6, 8, 6, 8)
        ConsonantsLayoutPanel.Name = "ConsonantsLayoutPanel"
        ConsonantsLayoutPanel.Padding = New Padding(6, 8, 0, 8)
        ConsonantsLayoutPanel.Size = New Size(576, 133)
        ConsonantsLayoutPanel.TabIndex = 7
        ' 
        ' AffricatesTab
        ' 
        AffricatesTab.Controls.Add(AffricatesPanel)
        AffricatesTab.Location = New Point(4, 34)
        AffricatesTab.Margin = New Padding(4, 2, 4, 2)
        AffricatesTab.Name = "AffricatesTab"
        AffricatesTab.Size = New Size(574, 130)
        AffricatesTab.TabIndex = 5
        AffricatesTab.Text = "Affricates"
        AffricatesTab.UseVisualStyleBackColor = True
        ' 
        ' AffricatesPanel
        ' 
        AffricatesPanel.AutoScroll = True
        AffricatesPanel.AutoScrollMargin = New Size(0, 5)
        AffricatesPanel.Dock = DockStyle.Fill
        AffricatesPanel.Location = New Point(0, 0)
        AffricatesPanel.Margin = New Padding(6, 8, 6, 8)
        AffricatesPanel.Name = "AffricatesPanel"
        AffricatesPanel.Padding = New Padding(6, 8, 0, 8)
        AffricatesPanel.Size = New Size(574, 130)
        AffricatesPanel.TabIndex = 8
        ' 
        ' VowelsTab
        ' 
        VowelsTab.Controls.Add(VowelPanel)
        VowelsTab.Location = New Point(4, 34)
        VowelsTab.Margin = New Padding(4, 2, 4, 2)
        VowelsTab.Name = "VowelsTab"
        VowelsTab.Size = New Size(574, 130)
        VowelsTab.TabIndex = 1
        VowelsTab.Text = "Vowels"
        VowelsTab.UseVisualStyleBackColor = True
        ' 
        ' VowelPanel
        ' 
        VowelPanel.AutoScroll = True
        VowelPanel.AutoScrollMargin = New Size(0, 5)
        VowelPanel.Dock = DockStyle.Fill
        VowelPanel.Location = New Point(0, 0)
        VowelPanel.Margin = New Padding(6, 8, 6, 8)
        VowelPanel.Name = "VowelPanel"
        VowelPanel.Padding = New Padding(6, 8, 0, 8)
        VowelPanel.Size = New Size(574, 130)
        VowelPanel.TabIndex = 8
        ' 
        ' ToneIntonationTab
        ' 
        ToneIntonationTab.Controls.Add(ToneIntonationPanel)
        ToneIntonationTab.Location = New Point(4, 34)
        ToneIntonationTab.Margin = New Padding(4, 2, 4, 2)
        ToneIntonationTab.Name = "ToneIntonationTab"
        ToneIntonationTab.Size = New Size(574, 130)
        ToneIntonationTab.TabIndex = 4
        ToneIntonationTab.Text = "Tones"
        ToneIntonationTab.UseVisualStyleBackColor = True
        ' 
        ' ToneIntonationPanel
        ' 
        ToneIntonationPanel.AutoScroll = True
        ToneIntonationPanel.AutoScrollMargin = New Size(0, 5)
        ToneIntonationPanel.Dock = DockStyle.Fill
        ToneIntonationPanel.Location = New Point(0, 0)
        ToneIntonationPanel.Margin = New Padding(6, 8, 6, 8)
        ToneIntonationPanel.Name = "ToneIntonationPanel"
        ToneIntonationPanel.Padding = New Padding(6, 8, 0, 8)
        ToneIntonationPanel.Size = New Size(574, 130)
        ToneIntonationPanel.TabIndex = 10
        ' 
        ' DiacriticsTab
        ' 
        DiacriticsTab.Controls.Add(DiacriticsPanel)
        DiacriticsTab.Location = New Point(4, 34)
        DiacriticsTab.Margin = New Padding(4, 2, 4, 2)
        DiacriticsTab.Name = "DiacriticsTab"
        DiacriticsTab.Size = New Size(574, 130)
        DiacriticsTab.TabIndex = 2
        DiacriticsTab.Text = "Diacritics"
        DiacriticsTab.UseVisualStyleBackColor = True
        ' 
        ' DiacriticsPanel
        ' 
        DiacriticsPanel.AutoScroll = True
        DiacriticsPanel.AutoScrollMargin = New Size(0, 5)
        DiacriticsPanel.Dock = DockStyle.Fill
        DiacriticsPanel.Location = New Point(0, 0)
        DiacriticsPanel.Margin = New Padding(6, 8, 6, 8)
        DiacriticsPanel.Name = "DiacriticsPanel"
        DiacriticsPanel.Padding = New Padding(6, 8, 0, 8)
        DiacriticsPanel.Size = New Size(574, 130)
        DiacriticsPanel.TabIndex = 8
        ' 
        ' SuprasegmentalsTab
        ' 
        SuprasegmentalsTab.Controls.Add(SuprasegmentalsPanel)
        SuprasegmentalsTab.Location = New Point(4, 34)
        SuprasegmentalsTab.Margin = New Padding(5, 6, 5, 6)
        SuprasegmentalsTab.Name = "SuprasegmentalsTab"
        SuprasegmentalsTab.Padding = New Padding(5, 6, 5, 6)
        SuprasegmentalsTab.Size = New Size(574, 130)
        SuprasegmentalsTab.TabIndex = 6
        SuprasegmentalsTab.Text = "Suprasegmentals"
        SuprasegmentalsTab.UseVisualStyleBackColor = True
        ' 
        ' SuprasegmentalsPanel
        ' 
        SuprasegmentalsPanel.AutoScroll = True
        SuprasegmentalsPanel.AutoScrollMargin = New Size(0, 5)
        SuprasegmentalsPanel.Dock = DockStyle.Fill
        SuprasegmentalsPanel.Location = New Point(5, 6)
        SuprasegmentalsPanel.Margin = New Padding(6, 8, 6, 8)
        SuprasegmentalsPanel.Name = "SuprasegmentalsPanel"
        SuprasegmentalsPanel.Padding = New Padding(6, 8, 0, 8)
        SuprasegmentalsPanel.Size = New Size(564, 118)
        SuprasegmentalsPanel.TabIndex = 9
        ' 
        ' BracketsTab
        ' 
        BracketsTab.Controls.Add(BracketsPanel)
        BracketsTab.Location = New Point(4, 34)
        BracketsTab.Margin = New Padding(4, 2, 4, 2)
        BracketsTab.Name = "BracketsTab"
        BracketsTab.Padding = New Padding(4, 2, 4, 2)
        BracketsTab.Size = New Size(594, 183)
        BracketsTab.TabIndex = 5
        BracketsTab.Text = "Brackets"
        BracketsTab.UseVisualStyleBackColor = True
        ' 
        ' BracketsPanel
        ' 
        BracketsPanel.AutoScroll = True
        BracketsPanel.AutoScrollMargin = New Size(0, 5)
        BracketsPanel.AutoSize = True
        BracketsPanel.Dock = DockStyle.Fill
        BracketsPanel.Location = New Point(4, 2)
        BracketsPanel.Margin = New Padding(6, 8, 6, 8)
        BracketsPanel.Name = "BracketsPanel"
        BracketsPanel.Padding = New Padding(6, 8, 0, 8)
        BracketsPanel.Size = New Size(586, 179)
        BracketsPanel.TabIndex = 8
        ' 
        ' ShortcutsTab
        ' 
        ShortcutsTab.Controls.Add(ShortcutsPanel)
        ShortcutsTab.Location = New Point(4, 34)
        ShortcutsTab.Margin = New Padding(4, 2, 4, 2)
        ShortcutsTab.Name = "ShortcutsTab"
        ShortcutsTab.Padding = New Padding(4, 2, 4, 2)
        ShortcutsTab.Size = New Size(594, 183)
        ShortcutsTab.TabIndex = 6
        ShortcutsTab.Text = "Shortcuts"
        ShortcutsTab.UseVisualStyleBackColor = True
        ' 
        ' ShortcutsPanel
        ' 
        ShortcutsPanel.AutoScroll = True
        ShortcutsPanel.AutoScrollMargin = New Size(0, 5)
        ShortcutsPanel.AutoSize = True
        ShortcutsPanel.Controls.Add(ShortcutButton1)
        ShortcutsPanel.Controls.Add(ShortcutButton2)
        ShortcutsPanel.Controls.Add(ShortcutButton3)
        ShortcutsPanel.Controls.Add(ShortcutButton4)
        ShortcutsPanel.Controls.Add(ShortcutButton5)
        ShortcutsPanel.Controls.Add(ShortcutButton6)
        ShortcutsPanel.Controls.Add(ShortcutButton7)
        ShortcutsPanel.Controls.Add(ShortcutButton8)
        ShortcutsPanel.Controls.Add(ShortcutButton9)
        ShortcutsPanel.Controls.Add(ShortcutButton0)
        ShortcutsPanel.Dock = DockStyle.Fill
        ShortcutsPanel.Location = New Point(4, 2)
        ShortcutsPanel.Margin = New Padding(6, 8, 6, 8)
        ShortcutsPanel.Name = "ShortcutsPanel"
        ShortcutsPanel.Padding = New Padding(6, 8, 0, 8)
        ShortcutsPanel.Size = New Size(586, 179)
        ShortcutsPanel.TabIndex = 9
        ' 
        ' ShortcutButton1
        ' 
        ShortcutButton1.BackColor = Color.Transparent
        ShortcutButton1.CharValue = ""
        ShortcutButton1.Location = New Point(10, 10)
        ShortcutButton1.Margin = New Padding(4, 2, 4, 2)
        ShortcutButton1.Name = "ShortcutButton1"
        ShortcutButton1.Padding = New Padding(5, 5, 5, 5)
        ShortcutButton1.SettingsValue = "Ctrl1"
        ShortcutButton1.ShortcutText = "CTRL+1"
        ShortcutButton1.Size = New Size(100, 138)
        ShortcutButton1.TabIndex = 0
        ' 
        ' ShortcutButton2
        ' 
        ShortcutButton2.BackColor = Color.Transparent
        ShortcutButton2.CharValue = ""
        ShortcutButton2.Location = New Point(118, 10)
        ShortcutButton2.Margin = New Padding(4, 2, 4, 2)
        ShortcutButton2.Name = "ShortcutButton2"
        ShortcutButton2.Padding = New Padding(5, 5, 5, 5)
        ShortcutButton2.SettingsValue = "Ctrl2"
        ShortcutButton2.ShortcutText = "CTRL+2"
        ShortcutButton2.Size = New Size(100, 138)
        ShortcutButton2.TabIndex = 1
        ' 
        ' ShortcutButton3
        ' 
        ShortcutButton3.BackColor = Color.Transparent
        ShortcutButton3.CharValue = ""
        ShortcutButton3.Location = New Point(226, 10)
        ShortcutButton3.Margin = New Padding(4, 2, 4, 2)
        ShortcutButton3.Name = "ShortcutButton3"
        ShortcutButton3.Padding = New Padding(5, 5, 5, 5)
        ShortcutButton3.SettingsValue = "Ctrl3"
        ShortcutButton3.ShortcutText = "CTRL+3"
        ShortcutButton3.Size = New Size(100, 138)
        ShortcutButton3.TabIndex = 2
        ' 
        ' ShortcutButton4
        ' 
        ShortcutButton4.BackColor = Color.Transparent
        ShortcutButton4.CharValue = ""
        ShortcutButton4.Location = New Point(334, 10)
        ShortcutButton4.Margin = New Padding(4, 2, 4, 2)
        ShortcutButton4.Name = "ShortcutButton4"
        ShortcutButton4.Padding = New Padding(5, 5, 5, 5)
        ShortcutButton4.SettingsValue = "Ctrl4"
        ShortcutButton4.ShortcutText = "CTRL+4"
        ShortcutButton4.Size = New Size(100, 138)
        ShortcutButton4.TabIndex = 3
        ' 
        ' ShortcutButton5
        ' 
        ShortcutButton5.BackColor = Color.Transparent
        ShortcutButton5.CharValue = ""
        ShortcutButton5.Location = New Point(442, 10)
        ShortcutButton5.Margin = New Padding(4, 2, 4, 2)
        ShortcutButton5.Name = "ShortcutButton5"
        ShortcutButton5.Padding = New Padding(5, 5, 5, 5)
        ShortcutButton5.SettingsValue = "Ctrl5"
        ShortcutButton5.ShortcutText = "CTRL+5"
        ShortcutButton5.Size = New Size(100, 138)
        ShortcutButton5.TabIndex = 4
        ' 
        ' ShortcutButton6
        ' 
        ShortcutButton6.BackColor = Color.Transparent
        ShortcutButton6.CharValue = ""
        ShortcutButton6.Location = New Point(10, 152)
        ShortcutButton6.Margin = New Padding(4, 2, 4, 2)
        ShortcutButton6.Name = "ShortcutButton6"
        ShortcutButton6.Padding = New Padding(5, 5, 5, 5)
        ShortcutButton6.SettingsValue = "Ctrl6"
        ShortcutButton6.ShortcutText = "CTRL+6"
        ShortcutButton6.Size = New Size(100, 138)
        ShortcutButton6.TabIndex = 5
        ' 
        ' ShortcutButton7
        ' 
        ShortcutButton7.BackColor = Color.Transparent
        ShortcutButton7.CharValue = ""
        ShortcutButton7.Location = New Point(118, 152)
        ShortcutButton7.Margin = New Padding(4, 2, 4, 2)
        ShortcutButton7.Name = "ShortcutButton7"
        ShortcutButton7.Padding = New Padding(5, 5, 5, 5)
        ShortcutButton7.SettingsValue = "Ctrl7"
        ShortcutButton7.ShortcutText = "CTRL+7"
        ShortcutButton7.Size = New Size(100, 138)
        ShortcutButton7.TabIndex = 6
        ' 
        ' ShortcutButton8
        ' 
        ShortcutButton8.BackColor = Color.Transparent
        ShortcutButton8.CharValue = ""
        ShortcutButton8.Location = New Point(226, 152)
        ShortcutButton8.Margin = New Padding(4, 2, 4, 2)
        ShortcutButton8.Name = "ShortcutButton8"
        ShortcutButton8.Padding = New Padding(5, 5, 5, 5)
        ShortcutButton8.SettingsValue = "Ctrl8"
        ShortcutButton8.ShortcutText = "CTRL+8"
        ShortcutButton8.Size = New Size(100, 138)
        ShortcutButton8.TabIndex = 7
        ' 
        ' ShortcutButton9
        ' 
        ShortcutButton9.BackColor = Color.Transparent
        ShortcutButton9.CharValue = ""
        ShortcutButton9.Location = New Point(334, 152)
        ShortcutButton9.Margin = New Padding(4, 2, 4, 2)
        ShortcutButton9.Name = "ShortcutButton9"
        ShortcutButton9.Padding = New Padding(5, 5, 5, 5)
        ShortcutButton9.SettingsValue = "Ctrl9"
        ShortcutButton9.ShortcutText = "CTRL+9"
        ShortcutButton9.Size = New Size(100, 138)
        ShortcutButton9.TabIndex = 8
        ' 
        ' ShortcutButton0
        ' 
        ShortcutButton0.BackColor = Color.Transparent
        ShortcutButton0.CharValue = ""
        ShortcutButton0.Location = New Point(442, 152)
        ShortcutButton0.Margin = New Padding(4, 2, 4, 2)
        ShortcutButton0.Name = "ShortcutButton0"
        ShortcutButton0.Padding = New Padding(5, 5, 5, 5)
        ShortcutButton0.SettingsValue = "Ctrl0"
        ShortcutButton0.ShortcutText = "CTRL+0"
        ShortcutButton0.Size = New Size(100, 138)
        ShortcutButton0.TabIndex = 9
        ' 
        ' SearchTab
        ' 
        SearchTab.Controls.Add(SearchToolStripContainer)
        SearchTab.Location = New Point(4, 34)
        SearchTab.Margin = New Padding(5, 6, 5, 6)
        SearchTab.Name = "SearchTab"
        SearchTab.Padding = New Padding(5, 6, 5, 6)
        SearchTab.Size = New Size(594, 183)
        SearchTab.TabIndex = 4
        SearchTab.Text = "Search"
        SearchTab.UseVisualStyleBackColor = True
        ' 
        ' SearchToolStripContainer
        ' 
        ' 
        ' SearchToolStripContainer.ContentPanel
        ' 
        SearchToolStripContainer.ContentPanel.Controls.Add(SearchCharPanel)
        SearchToolStripContainer.ContentPanel.Margin = New Padding(4, 2, 4, 2)
        SearchToolStripContainer.ContentPanel.Size = New Size(584, 130)
        SearchToolStripContainer.Dock = DockStyle.Fill
        SearchToolStripContainer.Location = New Point(5, 6)
        SearchToolStripContainer.Margin = New Padding(4, 2, 4, 2)
        SearchToolStripContainer.Name = "SearchToolStripContainer"
        SearchToolStripContainer.Size = New Size(584, 171)
        SearchToolStripContainer.TabIndex = 84
        ' 
        ' SearchToolStripContainer.TopToolStripPanel
        ' 
        SearchToolStripContainer.TopToolStripPanel.Controls.Add(SearchToolStrip)
        ' 
        ' SearchCharPanel
        ' 
        SearchCharPanel.AutoScroll = True
        SearchCharPanel.AutoScrollMargin = New Size(0, 5)
        SearchCharPanel.AutoSize = True
        SearchCharPanel.Dock = DockStyle.Fill
        SearchCharPanel.Location = New Point(0, 0)
        SearchCharPanel.Margin = New Padding(6, 8, 6, 8)
        SearchCharPanel.Name = "SearchCharPanel"
        SearchCharPanel.Padding = New Padding(6, 8, 0, 8)
        SearchCharPanel.Size = New Size(584, 130)
        SearchCharPanel.TabIndex = 8
        ' 
        ' SearchToolStrip
        ' 
        SearchToolStrip.Dock = DockStyle.None
        SearchToolStrip.GripStyle = ToolStripGripStyle.Hidden
        SearchToolStrip.ImageScalingSize = New Size(32, 32)
        SearchToolStrip.Items.AddRange(New ToolStripItem() {SearchQueryTextBox, CharSearchInLabel, SearchModeDropDown, SearchToolStripButton})
        SearchToolStrip.Location = New Point(0, 0)
        SearchToolStrip.Name = "SearchToolStrip"
        SearchToolStrip.Size = New Size(584, 41)
        SearchToolStrip.Stretch = True
        SearchToolStrip.TabIndex = 0
        ' 
        ' SearchQueryTextBox
        ' 
        SearchQueryTextBox.BorderStyle = BorderStyle.FixedSingle
        SearchQueryTextBox.Name = "SearchQueryTextBox"
        SearchQueryTextBox.Size = New Size(180, 41)
        ' 
        ' CharSearchInLabel
        ' 
        CharSearchInLabel.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(0), CByte(0))
        CharSearchInLabel.ForeColor = Color.Black
        CharSearchInLabel.Name = "CharSearchInLabel"
        CharSearchInLabel.Size = New Size(26, 36)
        CharSearchInLabel.Text = "in"
        ' 
        ' SearchModeDropDown
        ' 
        SearchModeDropDown.DropDownStyle = ComboBoxStyle.DropDownList
        SearchModeDropDown.FlatStyle = FlatStyle.System
        SearchModeDropDown.Items.AddRange(New Object() {"All", "Extended Latin", "Extended Cyrillic", "Extended Greek", "IPA (All)", "IPA Consonants", "IPA Affricates", "IPA Vowels", "IPA Tones", "IPA Diacritics", "IPA Suprasegmentals"})
        SearchModeDropDown.Name = "SearchModeDropDown"
        SearchModeDropDown.Size = New Size(180, 41)
        ' 
        ' SearchToolStripButton
        ' 
        SearchToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SearchToolStripButton.Image = CType(resources.GetObject("SearchToolStripButton.Image"), Image)
        SearchToolStripButton.ImageScaling = ToolStripItemImageScaling.None
        SearchToolStripButton.ImageTransparentColor = Color.Magenta
        SearchToolStripButton.Name = "SearchToolStripButton"
        SearchToolStripButton.Size = New Size(36, 36)
        SearchToolStripButton.Text = "Search"
        ' 
        ' ModifyCharPanel
        ' 
        ModifyCharPanel.Controls.Add(AccentGroupBox)
        ModifyCharPanel.Controls.Add(ModifyCharGroupBox)
        ModifyCharPanel.Controls.Add(TopPanel)
        ModifyCharPanel.Dock = DockStyle.Fill
        ModifyCharPanel.Location = New Point(0, 0)
        ModifyCharPanel.Margin = New Padding(5, 6, 5, 6)
        ModifyCharPanel.Name = "ModifyCharPanel"
        ModifyCharPanel.Padding = New Padding(10, 11, 10, 11)
        ModifyCharPanel.Size = New Size(602, 656)
        ModifyCharPanel.TabIndex = 75
        ' 
        ' AccentGroupBox
        ' 
        AccentGroupBox.BackColor = Color.Transparent
        AccentGroupBox.Controls.Add(AccentsPanel)
        AccentGroupBox.Dock = DockStyle.Fill
        AccentGroupBox.Location = New Point(10, 311)
        AccentGroupBox.Margin = New Padding(5, 6, 5, 6)
        AccentGroupBox.Name = "AccentGroupBox"
        AccentGroupBox.Padding = New Padding(5, 6, 5, 6)
        AccentGroupBox.Size = New Size(582, 334)
        AccentGroupBox.TabIndex = 78
        AccentGroupBox.TabStop = False
        AccentGroupBox.Text = "Accent Marks"
        ' 
        ' AccentsPanel
        ' 
        AccentsPanel.AutoScroll = True
        AccentsPanel.AutoScrollMargin = New Size(0, 5)
        AccentsPanel.Dock = DockStyle.Fill
        AccentsPanel.Location = New Point(5, 30)
        AccentsPanel.Margin = New Padding(6, 8, 6, 8)
        AccentsPanel.Name = "AccentsPanel"
        AccentsPanel.Padding = New Padding(6, 8, 0, 8)
        AccentsPanel.Size = New Size(572, 298)
        AccentsPanel.TabIndex = 10
        ' 
        ' ModifyCharGroupBox
        ' 
        ModifyCharGroupBox.BackColor = Color.Transparent
        ModifyCharGroupBox.Controls.Add(ClearButton)
        ModifyCharGroupBox.Controls.Add(AffricateButton)
        ModifyCharGroupBox.Controls.Add(LowercaseButton)
        ModifyCharGroupBox.Controls.Add(UppercaseButton)
        ModifyCharGroupBox.Dock = DockStyle.Top
        ModifyCharGroupBox.Location = New Point(10, 183)
        ModifyCharGroupBox.Margin = New Padding(5, 6, 5, 6)
        ModifyCharGroupBox.Name = "ModifyCharGroupBox"
        ModifyCharGroupBox.Padding = New Padding(5, 6, 5, 6)
        ModifyCharGroupBox.Size = New Size(582, 128)
        ModifyCharGroupBox.TabIndex = 89
        ModifyCharGroupBox.TabStop = False
        ModifyCharGroupBox.Text = "Modify Character"
        ' 
        ' ClearButton
        ' 
        ClearButton.Anchor = AnchorStyles.Top
        ClearButton.BackColor = Color.Transparent
        ClearButton.ForeColor = Color.Firebrick
        ClearButton.Location = New Point(411, 40)
        ClearButton.Margin = New Padding(5, 6, 5, 6)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(109, 61)
        ClearButton.TabIndex = 79
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' AffricateButton
        ' 
        AffricateButton.Anchor = AnchorStyles.Top
        AffricateButton.BackColor = Color.Transparent
        AffricateButton.Font = New Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AffricateButton.ForeColor = Color.Black
        AffricateButton.Location = New Point(318, 40)
        AffricateButton.Margin = New Padding(5, 6, 5, 6)
        AffricateButton.Name = "AffricateButton"
        AffricateButton.Size = New Size(84, 61)
        AffricateButton.TabIndex = 78
        AffricateButton.Text = "◌͡◌"
        MainTooltip.SetToolTip(AffricateButton, "Toggle Affricate")
        AffricateButton.UseVisualStyleBackColor = False
        ' 
        ' LowercaseButton
        ' 
        LowercaseButton.Anchor = AnchorStyles.Top
        LowercaseButton.BackColor = Color.Transparent
        LowercaseButton.ForeColor = Color.Black
        LowercaseButton.Location = New Point(65, 40)
        LowercaseButton.Margin = New Padding(5, 6, 5, 6)
        LowercaseButton.Name = "LowercaseButton"
        LowercaseButton.Size = New Size(116, 61)
        LowercaseButton.TabIndex = 78
        LowercaseButton.Text = "Lowercase"
        LowercaseButton.UseVisualStyleBackColor = False
        ' 
        ' UppercaseButton
        ' 
        UppercaseButton.Anchor = AnchorStyles.Top
        UppercaseButton.BackColor = Color.Transparent
        UppercaseButton.ForeColor = Color.Black
        UppercaseButton.Location = New Point(191, 40)
        UppercaseButton.Margin = New Padding(5, 6, 5, 6)
        UppercaseButton.Name = "UppercaseButton"
        UppercaseButton.Size = New Size(116, 61)
        UppercaseButton.TabIndex = 77
        UppercaseButton.Text = "Uppercase"
        UppercaseButton.UseVisualStyleBackColor = False
        ' 
        ' TopPanel
        ' 
        TopPanel.Controls.Add(AddToLocalButton)
        TopPanel.Controls.Add(CharacterButton)
        TopPanel.Controls.Add(CharacterTextBox)
        TopPanel.Controls.Add(SmartReplaceCheck)
        TopPanel.Controls.Add(AddToFileButton)
        TopPanel.Controls.Add(SmartReplaceIndicator)
        TopPanel.Controls.Add(CopyToClipboardButton)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(10, 11)
        TopPanel.Margin = New Padding(5, 6, 5, 6)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(582, 172)
        TopPanel.TabIndex = 90
        ' 
        ' AddToLocalButton
        ' 
        AddToLocalButton.Anchor = AnchorStyles.Top
        AddToLocalButton.BackColor = Color.Transparent
        AddToLocalButton.ForeColor = Color.Black
        AddToLocalButton.Location = New Point(331, 100)
        AddToLocalButton.Margin = New Padding(5, 6, 5, 6)
        AddToLocalButton.Name = "AddToLocalButton"
        AddToLocalButton.Size = New Size(91, 61)
        AddToLocalButton.TabIndex = 1
        AddToLocalButton.Text = "Local"
        AddToLocalButton.UseVisualStyleBackColor = False
        ' 
        ' CharacterButton
        ' 
        CharacterButton.Anchor = AnchorStyles.Top
        CharacterButton.BackColor = Color.Transparent
        CharacterButton.ContextMenuStrip = CharButtonMenu
        CharacterButton.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CharacterButton.ForeColor = Color.Black
        CharacterButton.Location = New Point(62, 6)
        CharacterButton.Margin = New Padding(5, 6, 5, 6)
        CharacterButton.Name = "CharacterButton"
        CharacterButton.Size = New Size(134, 156)
        CharacterButton.TabIndex = 88
        CharacterButton.Text = "a"
        CharacterButton.UseVisualStyleBackColor = False
        ' 
        ' CharButtonMenu
        ' 
        CharButtonMenu.ImageScalingSize = New Size(24, 24)
        CharButtonMenu.Items.AddRange(New ToolStripItem() {AddToEditorCharacterMenuItem, ReplaceEditorCharacterMenuItem, CopyCharSeparator, CopyToClipboardMenuItem, CopyToFileMenuItem, CopyToLocalMenuItem, ShortcutKeySeparator, ShortcutKeyToolStripMenuItem, RemoveCharSeparator, RemoveToolStripMenuItem})
        CharButtonMenu.Name = "CharButtonMenu"
        CharButtonMenu.Size = New Size(276, 246)
        ' 
        ' AddToEditorCharacterMenuItem
        ' 
        AddToEditorCharacterMenuItem.Name = "AddToEditorCharacterMenuItem"
        AddToEditorCharacterMenuItem.Size = New Size(275, 32)
        AddToEditorCharacterMenuItem.Text = "Add to Editor Character"
        ' 
        ' ReplaceEditorCharacterMenuItem
        ' 
        ReplaceEditorCharacterMenuItem.Name = "ReplaceEditorCharacterMenuItem"
        ReplaceEditorCharacterMenuItem.Size = New Size(275, 32)
        ReplaceEditorCharacterMenuItem.Text = "Replace Editor Character"
        ' 
        ' CopyCharSeparator
        ' 
        CopyCharSeparator.Name = "CopyCharSeparator"
        CopyCharSeparator.Size = New Size(272, 6)
        ' 
        ' CopyToClipboardMenuItem
        ' 
        CopyToClipboardMenuItem.Name = "CopyToClipboardMenuItem"
        CopyToClipboardMenuItem.Size = New Size(275, 32)
        CopyToClipboardMenuItem.Text = "Copy to Clipboard"
        CopyToClipboardMenuItem.TextImageRelation = TextImageRelation.Overlay
        ' 
        ' CopyToFileMenuItem
        ' 
        CopyToFileMenuItem.Name = "CopyToFileMenuItem"
        CopyToFileMenuItem.Size = New Size(275, 32)
        CopyToFileMenuItem.Text = "Copy to File"
        ' 
        ' CopyToLocalMenuItem
        ' 
        CopyToLocalMenuItem.Name = "CopyToLocalMenuItem"
        CopyToLocalMenuItem.Size = New Size(275, 32)
        CopyToLocalMenuItem.Text = "Copy to Local"
        ' 
        ' ShortcutKeySeparator
        ' 
        ShortcutKeySeparator.Name = "ShortcutKeySeparator"
        ShortcutKeySeparator.Size = New Size(272, 6)
        ' 
        ' ShortcutKeyToolStripMenuItem
        ' 
        ShortcutKeyToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CTRL1ToolStripMenuItem, CTRL2ToolStripMenuItem, CTRL3ToolStripMenuItem, CTRL4ToolStripMenuItem, CTRL5ToolStripMenuItem, CTRL6ToolStripMenuItem, CTRL7ToolStripMenuItem, CTRL8ToolStripMenuItem, CTRL9ToolStripMenuItem, CTRL0ToolStripMenuItem})
        ShortcutKeyToolStripMenuItem.Name = "ShortcutKeyToolStripMenuItem"
        ShortcutKeyToolStripMenuItem.Size = New Size(275, 32)
        ShortcutKeyToolStripMenuItem.Text = "Shortcut Key"
        ' 
        ' CTRL1ToolStripMenuItem
        ' 
        CTRL1ToolStripMenuItem.Name = "CTRL1ToolStripMenuItem"
        CTRL1ToolStripMenuItem.Size = New Size(175, 34)
        CTRL1ToolStripMenuItem.Text = "CTRL+1"
        ' 
        ' CTRL2ToolStripMenuItem
        ' 
        CTRL2ToolStripMenuItem.Name = "CTRL2ToolStripMenuItem"
        CTRL2ToolStripMenuItem.Size = New Size(175, 34)
        CTRL2ToolStripMenuItem.Text = "CTRL+2"
        ' 
        ' CTRL3ToolStripMenuItem
        ' 
        CTRL3ToolStripMenuItem.Name = "CTRL3ToolStripMenuItem"
        CTRL3ToolStripMenuItem.Size = New Size(175, 34)
        CTRL3ToolStripMenuItem.Text = "CTRL+3"
        ' 
        ' CTRL4ToolStripMenuItem
        ' 
        CTRL4ToolStripMenuItem.Name = "CTRL4ToolStripMenuItem"
        CTRL4ToolStripMenuItem.Size = New Size(175, 34)
        CTRL4ToolStripMenuItem.Text = "CTRL+4"
        ' 
        ' CTRL5ToolStripMenuItem
        ' 
        CTRL5ToolStripMenuItem.Name = "CTRL5ToolStripMenuItem"
        CTRL5ToolStripMenuItem.Size = New Size(175, 34)
        CTRL5ToolStripMenuItem.Text = "CTRL+5"
        ' 
        ' CTRL6ToolStripMenuItem
        ' 
        CTRL6ToolStripMenuItem.Name = "CTRL6ToolStripMenuItem"
        CTRL6ToolStripMenuItem.Size = New Size(175, 34)
        CTRL6ToolStripMenuItem.Text = "CTRL+6"
        ' 
        ' CTRL7ToolStripMenuItem
        ' 
        CTRL7ToolStripMenuItem.Name = "CTRL7ToolStripMenuItem"
        CTRL7ToolStripMenuItem.Size = New Size(175, 34)
        CTRL7ToolStripMenuItem.Text = "CTRL+7"
        ' 
        ' CTRL8ToolStripMenuItem
        ' 
        CTRL8ToolStripMenuItem.Name = "CTRL8ToolStripMenuItem"
        CTRL8ToolStripMenuItem.Size = New Size(175, 34)
        CTRL8ToolStripMenuItem.Text = "CTRL+8"
        ' 
        ' CTRL9ToolStripMenuItem
        ' 
        CTRL9ToolStripMenuItem.Name = "CTRL9ToolStripMenuItem"
        CTRL9ToolStripMenuItem.Size = New Size(175, 34)
        CTRL9ToolStripMenuItem.Text = "CTRL+9"
        ' 
        ' CTRL0ToolStripMenuItem
        ' 
        CTRL0ToolStripMenuItem.Name = "CTRL0ToolStripMenuItem"
        CTRL0ToolStripMenuItem.Size = New Size(175, 34)
        CTRL0ToolStripMenuItem.Text = "CTRL+0"
        ' 
        ' RemoveCharSeparator
        ' 
        RemoveCharSeparator.Name = "RemoveCharSeparator"
        RemoveCharSeparator.Size = New Size(272, 6)
        ' 
        ' RemoveToolStripMenuItem
        ' 
        RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        RemoveToolStripMenuItem.Size = New Size(275, 32)
        RemoveToolStripMenuItem.Text = "Remove"
        ' 
        ' CharacterTextBox
        ' 
        CharacterTextBox.Anchor = AnchorStyles.Top
        CharacterTextBox.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CharacterTextBox.Location = New Point(205, 48)
        CharacterTextBox.Margin = New Padding(5, 6, 5, 6)
        CharacterTextBox.Name = "CharacterTextBox"
        CharacterTextBox.Size = New Size(313, 29)
        CharacterTextBox.TabIndex = 77
        ' 
        ' SmartReplaceCheck
        ' 
        SmartReplaceCheck.Anchor = AnchorStyles.Top
        SmartReplaceCheck.AutoSize = True
        SmartReplaceCheck.Checked = True
        SmartReplaceCheck.CheckState = CheckState.Checked
        SmartReplaceCheck.Location = New Point(235, 6)
        SmartReplaceCheck.Margin = New Padding(4, 2, 4, 2)
        SmartReplaceCheck.Name = "SmartReplaceCheck"
        SmartReplaceCheck.Size = New Size(150, 29)
        SmartReplaceCheck.TabIndex = 86
        SmartReplaceCheck.Text = "Smart Replace"
        SmartReplaceCheck.UseVisualStyleBackColor = True
        ' 
        ' AddToFileButton
        ' 
        AddToFileButton.Anchor = AnchorStyles.Top
        AddToFileButton.BackColor = Color.Transparent
        AddToFileButton.ForeColor = Color.Black
        AddToFileButton.Location = New Point(434, 100)
        AddToFileButton.Margin = New Padding(5, 6, 5, 6)
        AddToFileButton.Name = "AddToFileButton"
        AddToFileButton.Size = New Size(86, 61)
        AddToFileButton.TabIndex = 76
        AddToFileButton.Text = "File"
        AddToFileButton.UseVisualStyleBackColor = False
        ' 
        ' SmartReplaceIndicator
        ' 
        SmartReplaceIndicator.Anchor = AnchorStyles.Top
        SmartReplaceIndicator.BackColor = Color.DimGray
        SmartReplaceIndicator.Location = New Point(205, 8)
        SmartReplaceIndicator.Margin = New Padding(4, 2, 4, 2)
        SmartReplaceIndicator.Name = "SmartReplaceIndicator"
        SmartReplaceIndicator.Size = New Size(24, 28)
        SmartReplaceIndicator.TabIndex = 87
        ' 
        ' CopyToClipboardButton
        ' 
        CopyToClipboardButton.Anchor = AnchorStyles.Top
        CopyToClipboardButton.BackColor = Color.Transparent
        CopyToClipboardButton.ForeColor = Color.Black
        CopyToClipboardButton.Location = New Point(205, 100)
        CopyToClipboardButton.Margin = New Padding(5, 6, 5, 6)
        CopyToClipboardButton.Name = "CopyToClipboardButton"
        CopyToClipboardButton.Size = New Size(116, 61)
        CopyToClipboardButton.TabIndex = 79
        CopyToClipboardButton.Text = "Clipboard"
        CopyToClipboardButton.UseVisualStyleBackColor = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel1
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Margin = New Padding(5, 6, 5, 6)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(ModifyCharPanel)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(CharCategoriesTabs)
        SplitContainer1.Size = New Size(602, 885)
        SplitContainer1.SplitterDistance = 656
        SplitContainer1.SplitterWidth = 8
        SplitContainer1.TabIndex = 76
        ' 
        ' SaveDialog
        ' 
        SaveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        ' 
        ' OpenDialog
        ' 
        OpenDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        ' 
        ' ShortcutButtonMenu
        ' 
        ShortcutButtonMenu.ImageScalingSize = New Size(24, 24)
        ShortcutButtonMenu.Items.AddRange(New ToolStripItem() {ResetKeyToolStripMenuItem, ResetAllKeysToolStripMenuItem})
        ShortcutButtonMenu.Name = "CharButtonMenu"
        ShortcutButtonMenu.Size = New Size(193, 68)
        ' 
        ' ResetKeyToolStripMenuItem
        ' 
        ResetKeyToolStripMenuItem.Name = "ResetKeyToolStripMenuItem"
        ResetKeyToolStripMenuItem.Size = New Size(192, 32)
        ResetKeyToolStripMenuItem.Text = "Reset Key"
        ' 
        ' ResetAllKeysToolStripMenuItem
        ' 
        ResetAllKeysToolStripMenuItem.Name = "ResetAllKeysToolStripMenuItem"
        ResetAllKeysToolStripMenuItem.Size = New Size(192, 32)
        ResetAllKeysToolStripMenuItem.Text = "Reset All Keys"
        ' 
        ' CharacterEditor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(SplitContainer1)
        DoubleBuffered = True
        Margin = New Padding(5, 6, 5, 6)
        MinimumSize = New Size(566, 0)
        Name = "CharacterEditor"
        Size = New Size(602, 885)
        CharCategoriesTabs.ResumeLayout(False)
        LocalTab.ResumeLayout(False)
        LocalToolStripContainer.ContentPanel.ResumeLayout(False)
        LocalToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        LocalToolStripContainer.TopToolStripPanel.PerformLayout()
        LocalToolStripContainer.ResumeLayout(False)
        LocalToolStripContainer.PerformLayout()
        LocalToolStrip.ResumeLayout(False)
        LocalToolStrip.PerformLayout()
        FileTab.ResumeLayout(False)
        FileToolStripContainer.ContentPanel.ResumeLayout(False)
        FileToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        FileToolStripContainer.TopToolStripPanel.PerformLayout()
        FileToolStripContainer.ResumeLayout(False)
        FileToolStripContainer.PerformLayout()
        FileToolStrip.ResumeLayout(False)
        FileToolStrip.PerformLayout()
        ExtendedTab.ResumeLayout(False)
        ExtendedCharTabControl.ResumeLayout(False)
        LatinTab.ResumeLayout(False)
        LatinTab.PerformLayout()
        CyrillicTab.ResumeLayout(False)
        GreekTab.ResumeLayout(False)
        IpaTab.ResumeLayout(False)
        IpaTabControl.ResumeLayout(False)
        ConsonantsTab.ResumeLayout(False)
        ConsonantsTab.PerformLayout()
        AffricatesTab.ResumeLayout(False)
        VowelsTab.ResumeLayout(False)
        ToneIntonationTab.ResumeLayout(False)
        DiacriticsTab.ResumeLayout(False)
        SuprasegmentalsTab.ResumeLayout(False)
        BracketsTab.ResumeLayout(False)
        BracketsTab.PerformLayout()
        ShortcutsTab.ResumeLayout(False)
        ShortcutsTab.PerformLayout()
        ShortcutsPanel.ResumeLayout(False)
        SearchTab.ResumeLayout(False)
        SearchToolStripContainer.ContentPanel.ResumeLayout(False)
        SearchToolStripContainer.ContentPanel.PerformLayout()
        SearchToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        SearchToolStripContainer.TopToolStripPanel.PerformLayout()
        SearchToolStripContainer.ResumeLayout(False)
        SearchToolStripContainer.PerformLayout()
        SearchToolStrip.ResumeLayout(False)
        SearchToolStrip.PerformLayout()
        ModifyCharPanel.ResumeLayout(False)
        AccentGroupBox.ResumeLayout(False)
        ModifyCharGroupBox.ResumeLayout(False)
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        CharButtonMenu.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ShortcutButtonMenu.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents CharCategoriesTabs As TabControl
    Friend WithEvents FileTab As TabPage
    Friend WithEvents LocalTab As TabPage
    Friend WithEvents ExtendedTab As TabPage
    Friend WithEvents LatinPanel As FlowLayoutPanel
    Friend WithEvents IpaTab As TabPage
    Friend WithEvents IpaTabControl As TabControl
    Friend WithEvents ConsonantsTab As TabPage
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
    Friend WithEvents SmartReplaceIndicator As LangPadUI.DoubleBufferedPanel
    Friend WithEvents SmartReplaceCheck As CheckBox
    Friend WithEvents CharacterButton As Button
    Friend WithEvents CharButtonMenu As ContextMenuStrip
    Friend WithEvents ReplaceEditorCharacterMenuItem As ToolStripMenuItem
    Friend WithEvents CopyCharSeparator As ToolStripSeparator
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
    Friend WithEvents RemoveCharSeparator As ToolStripSeparator
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
    Friend WithEvents ShortcutsTab As TabPage
    Friend WithEvents ShortcutsPanel As FlowLayoutPanel
    Friend WithEvents ShortcutButton1 As LangPadUI.ShortcutButton
    Friend WithEvents ShortcutButton2 As LangPadUI.ShortcutButton
    Friend WithEvents ShortcutButton3 As LangPadUI.ShortcutButton
    Friend WithEvents ShortcutButton4 As LangPadUI.ShortcutButton
    Friend WithEvents ShortcutButton5 As LangPadUI.ShortcutButton
    Friend WithEvents ShortcutButton6 As LangPadUI.ShortcutButton
    Friend WithEvents ShortcutButton7 As LangPadUI.ShortcutButton
    Friend WithEvents ShortcutButton8 As LangPadUI.ShortcutButton
    Friend WithEvents ShortcutButton9 As LangPadUI.ShortcutButton
    Friend WithEvents ShortcutButton0 As LangPadUI.ShortcutButton
    Friend WithEvents ShortcutKeySeparator As ToolStripSeparator
    Friend WithEvents ShortcutKeyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTRL1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTRL2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTRL3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTRL4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTRL5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTRL6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTRL7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTRL8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTRL9ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CTRL0ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShortcutButtonMenu As ContextMenuStrip
    Friend WithEvents ResetKeyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetAllKeysToolStripMenuItem As ToolStripMenuItem
End Class
