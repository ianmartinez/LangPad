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
        Me.CharCategoriesTabs = New System.Windows.Forms.TabControl()
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
        Me.ConsonantsTab = New System.Windows.Forms.TabPage()
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
        Me.BracketsTab = New System.Windows.Forms.TabPage()
        Me.BracketsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ShortcutsTab = New System.Windows.Forms.TabPage()
        Me.ShortcutsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ShortcutButton1 = New LangPadUI.ShortcutButton()
        Me.ShortcutButton2 = New LangPadUI.ShortcutButton()
        Me.ShortcutButton3 = New LangPadUI.ShortcutButton()
        Me.ShortcutButton4 = New LangPadUI.ShortcutButton()
        Me.ShortcutButton5 = New LangPadUI.ShortcutButton()
        Me.ShortcutButton6 = New LangPadUI.ShortcutButton()
        Me.ShortcutButton7 = New LangPadUI.ShortcutButton()
        Me.ShortcutButton8 = New LangPadUI.ShortcutButton()
        Me.ShortcutButton9 = New LangPadUI.ShortcutButton()
        Me.ShortcutButton0 = New LangPadUI.ShortcutButton()
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
        Me.SmartReplaceIndicator = New LangPadUI.DoubleBufferedPanel()
        Me.CopyToClipboardButton = New System.Windows.Forms.Button()
        Me.CharButtonMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToEditorCharacterMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceEditorCharacterMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCharSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToClipboardMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToFileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToLocalMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShortcutKeySeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ShortcutKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRL1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRL2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRL3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRL4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRL5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRL6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRL7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRL8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRL9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRL0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveCharSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ShortcutButtonMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetAllKeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharCategoriesTabs.SuspendLayout()
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
        Me.ConsonantsTab.SuspendLayout()
        Me.AffricatesTab.SuspendLayout()
        Me.VowelsTab.SuspendLayout()
        Me.ToneIntonationTab.SuspendLayout()
        Me.DiacriticsTab.SuspendLayout()
        Me.SuprasegmentalsTab.SuspendLayout()
        Me.BracketsTab.SuspendLayout()
        Me.ShortcutsTab.SuspendLayout()
        Me.ShortcutsPanel.SuspendLayout()
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
        Me.ShortcutButtonMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'CharCategoriesTabs
        '
        Me.CharCategoriesTabs.Controls.Add(Me.LocalTab)
        Me.CharCategoriesTabs.Controls.Add(Me.FileTab)
        Me.CharCategoriesTabs.Controls.Add(Me.ExtendedTab)
        Me.CharCategoriesTabs.Controls.Add(Me.IpaTab)
        Me.CharCategoriesTabs.Controls.Add(Me.BracketsTab)
        Me.CharCategoriesTabs.Controls.Add(Me.ShortcutsTab)
        Me.CharCategoriesTabs.Controls.Add(Me.SearchTab)
        Me.CharCategoriesTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CharCategoriesTabs.Location = New System.Drawing.Point(0, 0)
        Me.CharCategoriesTabs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CharCategoriesTabs.Multiline = True
        Me.CharCategoriesTabs.Name = "CharCategoriesTabs"
        Me.CharCategoriesTabs.SelectedIndex = 0
        Me.CharCategoriesTabs.Size = New System.Drawing.Size(482, 141)
        Me.CharCategoriesTabs.TabIndex = 74
        '
        'LocalTab
        '
        Me.LocalTab.Controls.Add(Me.LocalToolStripContainer)
        Me.LocalTab.Location = New System.Drawing.Point(4, 25)
        Me.LocalTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LocalTab.Name = "LocalTab"
        Me.LocalTab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LocalTab.Size = New System.Drawing.Size(474, 112)
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
        Me.LocalToolStripContainer.ContentPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LocalToolStripContainer.ContentPanel.Size = New System.Drawing.Size(466, 65)
        Me.LocalToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocalToolStripContainer.Location = New System.Drawing.Point(4, 4)
        Me.LocalToolStripContainer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LocalToolStripContainer.Name = "LocalToolStripContainer"
        Me.LocalToolStripContainer.Size = New System.Drawing.Size(466, 104)
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
        Me.LocalPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.LocalPanel.Name = "LocalPanel"
        Me.LocalPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.LocalPanel.Size = New System.Drawing.Size(466, 65)
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
        Me.LocalToolStrip.Size = New System.Drawing.Size(466, 39)
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
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
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
        Me.FileTab.Location = New System.Drawing.Point(4, 25)
        Me.FileTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FileTab.Name = "FileTab"
        Me.FileTab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FileTab.Size = New System.Drawing.Size(474, 112)
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
        Me.FileToolStripContainer.ContentPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FileToolStripContainer.ContentPanel.Size = New System.Drawing.Size(466, 65)
        Me.FileToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileToolStripContainer.Location = New System.Drawing.Point(4, 4)
        Me.FileToolStripContainer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FileToolStripContainer.Name = "FileToolStripContainer"
        Me.FileToolStripContainer.Size = New System.Drawing.Size(466, 104)
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
        Me.FilePanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.FilePanel.Name = "FilePanel"
        Me.FilePanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.FilePanel.Size = New System.Drawing.Size(466, 65)
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
        Me.FileToolStrip.Size = New System.Drawing.Size(466, 39)
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
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
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
        Me.ExtendedTab.Location = New System.Drawing.Point(4, 25)
        Me.ExtendedTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExtendedTab.Name = "ExtendedTab"
        Me.ExtendedTab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExtendedTab.Size = New System.Drawing.Size(474, 112)
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
        Me.ExtendedCharTabControl.Location = New System.Drawing.Point(4, 4)
        Me.ExtendedCharTabControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExtendedCharTabControl.Name = "ExtendedCharTabControl"
        Me.ExtendedCharTabControl.SelectedIndex = 0
        Me.ExtendedCharTabControl.Size = New System.Drawing.Size(466, 104)
        Me.ExtendedCharTabControl.TabIndex = 73
        '
        'LatinTab
        '
        Me.LatinTab.Controls.Add(Me.LatinPanel)
        Me.LatinTab.Location = New System.Drawing.Point(4, 25)
        Me.LatinTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LatinTab.Name = "LatinTab"
        Me.LatinTab.Size = New System.Drawing.Size(458, 75)
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
        Me.LatinPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.LatinPanel.Name = "LatinPanel"
        Me.LatinPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.LatinPanel.Size = New System.Drawing.Size(458, 75)
        Me.LatinPanel.TabIndex = 9
        '
        'CyrillicTab
        '
        Me.CyrillicTab.Controls.Add(Me.CyrillicPanel)
        Me.CyrillicTab.Location = New System.Drawing.Point(4, 25)
        Me.CyrillicTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CyrillicTab.Name = "CyrillicTab"
        Me.CyrillicTab.Size = New System.Drawing.Size(460, 162)
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
        Me.CyrillicPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CyrillicPanel.Name = "CyrillicPanel"
        Me.CyrillicPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.CyrillicPanel.Size = New System.Drawing.Size(460, 162)
        Me.CyrillicPanel.TabIndex = 8
        '
        'GreekTab
        '
        Me.GreekTab.Controls.Add(Me.GreekPanel)
        Me.GreekTab.Location = New System.Drawing.Point(4, 25)
        Me.GreekTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GreekTab.Name = "GreekTab"
        Me.GreekTab.Size = New System.Drawing.Size(460, 162)
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
        Me.GreekPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GreekPanel.Name = "GreekPanel"
        Me.GreekPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.GreekPanel.Size = New System.Drawing.Size(460, 162)
        Me.GreekPanel.TabIndex = 8
        '
        'IpaTab
        '
        Me.IpaTab.Controls.Add(Me.IpaTabControl)
        Me.IpaTab.Location = New System.Drawing.Point(4, 25)
        Me.IpaTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IpaTab.Name = "IpaTab"
        Me.IpaTab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IpaTab.Size = New System.Drawing.Size(474, 112)
        Me.IpaTab.TabIndex = 3
        Me.IpaTab.Text = "IPA"
        Me.IpaTab.UseVisualStyleBackColor = True
        '
        'IpaTabControl
        '
        Me.IpaTabControl.Controls.Add(Me.ConsonantsTab)
        Me.IpaTabControl.Controls.Add(Me.AffricatesTab)
        Me.IpaTabControl.Controls.Add(Me.VowelsTab)
        Me.IpaTabControl.Controls.Add(Me.ToneIntonationTab)
        Me.IpaTabControl.Controls.Add(Me.DiacriticsTab)
        Me.IpaTabControl.Controls.Add(Me.SuprasegmentalsTab)
        Me.IpaTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IpaTabControl.Location = New System.Drawing.Point(4, 4)
        Me.IpaTabControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IpaTabControl.Name = "IpaTabControl"
        Me.IpaTabControl.SelectedIndex = 0
        Me.IpaTabControl.Size = New System.Drawing.Size(466, 104)
        Me.IpaTabControl.TabIndex = 72
        '
        'ConsonantsTab
        '
        Me.ConsonantsTab.Controls.Add(Me.ConsonantsLayoutPanel)
        Me.ConsonantsTab.Location = New System.Drawing.Point(4, 25)
        Me.ConsonantsTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConsonantsTab.Name = "ConsonantsTab"
        Me.ConsonantsTab.Size = New System.Drawing.Size(458, 75)
        Me.ConsonantsTab.TabIndex = 0
        Me.ConsonantsTab.Text = "Consonants"
        Me.ConsonantsTab.UseVisualStyleBackColor = True
        '
        'ConsonantsLayoutPanel
        '
        Me.ConsonantsLayoutPanel.AutoScroll = True
        Me.ConsonantsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.ConsonantsLayoutPanel.AutoSize = True
        Me.ConsonantsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsonantsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ConsonantsLayoutPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ConsonantsLayoutPanel.Name = "ConsonantsLayoutPanel"
        Me.ConsonantsLayoutPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.ConsonantsLayoutPanel.Size = New System.Drawing.Size(458, 75)
        Me.ConsonantsLayoutPanel.TabIndex = 7
        '
        'AffricatesTab
        '
        Me.AffricatesTab.Controls.Add(Me.AffricatesPanel)
        Me.AffricatesTab.Location = New System.Drawing.Point(4, 25)
        Me.AffricatesTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AffricatesTab.Name = "AffricatesTab"
        Me.AffricatesTab.Size = New System.Drawing.Size(460, 162)
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
        Me.AffricatesPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.AffricatesPanel.Name = "AffricatesPanel"
        Me.AffricatesPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.AffricatesPanel.Size = New System.Drawing.Size(460, 162)
        Me.AffricatesPanel.TabIndex = 8
        '
        'VowelsTab
        '
        Me.VowelsTab.Controls.Add(Me.VowelPanel)
        Me.VowelsTab.Location = New System.Drawing.Point(4, 25)
        Me.VowelsTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VowelsTab.Name = "VowelsTab"
        Me.VowelsTab.Size = New System.Drawing.Size(460, 162)
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
        Me.VowelPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.VowelPanel.Name = "VowelPanel"
        Me.VowelPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.VowelPanel.Size = New System.Drawing.Size(460, 162)
        Me.VowelPanel.TabIndex = 8
        '
        'ToneIntonationTab
        '
        Me.ToneIntonationTab.Controls.Add(Me.ToneIntonationPanel)
        Me.ToneIntonationTab.Location = New System.Drawing.Point(4, 25)
        Me.ToneIntonationTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ToneIntonationTab.Name = "ToneIntonationTab"
        Me.ToneIntonationTab.Size = New System.Drawing.Size(460, 162)
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
        Me.ToneIntonationPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ToneIntonationPanel.Name = "ToneIntonationPanel"
        Me.ToneIntonationPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.ToneIntonationPanel.Size = New System.Drawing.Size(460, 162)
        Me.ToneIntonationPanel.TabIndex = 10
        '
        'DiacriticsTab
        '
        Me.DiacriticsTab.Controls.Add(Me.DiacriticsPanel)
        Me.DiacriticsTab.Location = New System.Drawing.Point(4, 25)
        Me.DiacriticsTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DiacriticsTab.Name = "DiacriticsTab"
        Me.DiacriticsTab.Size = New System.Drawing.Size(460, 162)
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
        Me.DiacriticsPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DiacriticsPanel.Name = "DiacriticsPanel"
        Me.DiacriticsPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.DiacriticsPanel.Size = New System.Drawing.Size(460, 162)
        Me.DiacriticsPanel.TabIndex = 8
        '
        'SuprasegmentalsTab
        '
        Me.SuprasegmentalsTab.Controls.Add(Me.SuprasegmentalsPanel)
        Me.SuprasegmentalsTab.Location = New System.Drawing.Point(4, 25)
        Me.SuprasegmentalsTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SuprasegmentalsTab.Name = "SuprasegmentalsTab"
        Me.SuprasegmentalsTab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SuprasegmentalsTab.Size = New System.Drawing.Size(460, 162)
        Me.SuprasegmentalsTab.TabIndex = 6
        Me.SuprasegmentalsTab.Text = "Suprasegmentals"
        Me.SuprasegmentalsTab.UseVisualStyleBackColor = True
        '
        'SuprasegmentalsPanel
        '
        Me.SuprasegmentalsPanel.AutoScroll = True
        Me.SuprasegmentalsPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.SuprasegmentalsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuprasegmentalsPanel.Location = New System.Drawing.Point(4, 4)
        Me.SuprasegmentalsPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.SuprasegmentalsPanel.Name = "SuprasegmentalsPanel"
        Me.SuprasegmentalsPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.SuprasegmentalsPanel.Size = New System.Drawing.Size(452, 154)
        Me.SuprasegmentalsPanel.TabIndex = 9
        '
        'BracketsTab
        '
        Me.BracketsTab.Controls.Add(Me.BracketsPanel)
        Me.BracketsTab.Location = New System.Drawing.Point(4, 25)
        Me.BracketsTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BracketsTab.Name = "BracketsTab"
        Me.BracketsTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BracketsTab.Size = New System.Drawing.Size(474, 112)
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
        Me.BracketsPanel.Location = New System.Drawing.Point(3, 2)
        Me.BracketsPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BracketsPanel.Name = "BracketsPanel"
        Me.BracketsPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.BracketsPanel.Size = New System.Drawing.Size(468, 108)
        Me.BracketsPanel.TabIndex = 8
        '
        'ShortcutsTab
        '
        Me.ShortcutsTab.Controls.Add(Me.ShortcutsPanel)
        Me.ShortcutsTab.Location = New System.Drawing.Point(4, 25)
        Me.ShortcutsTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutsTab.Name = "ShortcutsTab"
        Me.ShortcutsTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutsTab.Size = New System.Drawing.Size(474, 112)
        Me.ShortcutsTab.TabIndex = 6
        Me.ShortcutsTab.Text = "Shortcuts"
        Me.ShortcutsTab.UseVisualStyleBackColor = True
        '
        'ShortcutsPanel
        '
        Me.ShortcutsPanel.AutoScroll = True
        Me.ShortcutsPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.ShortcutsPanel.AutoSize = True
        Me.ShortcutsPanel.Controls.Add(Me.ShortcutButton1)
        Me.ShortcutsPanel.Controls.Add(Me.ShortcutButton2)
        Me.ShortcutsPanel.Controls.Add(Me.ShortcutButton3)
        Me.ShortcutsPanel.Controls.Add(Me.ShortcutButton4)
        Me.ShortcutsPanel.Controls.Add(Me.ShortcutButton5)
        Me.ShortcutsPanel.Controls.Add(Me.ShortcutButton6)
        Me.ShortcutsPanel.Controls.Add(Me.ShortcutButton7)
        Me.ShortcutsPanel.Controls.Add(Me.ShortcutButton8)
        Me.ShortcutsPanel.Controls.Add(Me.ShortcutButton9)
        Me.ShortcutsPanel.Controls.Add(Me.ShortcutButton0)
        Me.ShortcutsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShortcutsPanel.Location = New System.Drawing.Point(3, 2)
        Me.ShortcutsPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ShortcutsPanel.Name = "ShortcutsPanel"
        Me.ShortcutsPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.ShortcutsPanel.Size = New System.Drawing.Size(468, 108)
        Me.ShortcutsPanel.TabIndex = 9
        '
        'ShortcutButton1
        '
        Me.ShortcutButton1.BackColor = System.Drawing.Color.Transparent
        Me.ShortcutButton1.CharValue = ""
        Me.ShortcutButton1.Location = New System.Drawing.Point(8, 7)
        Me.ShortcutButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutButton1.Name = "ShortcutButton1"
        Me.ShortcutButton1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortcutButton1.SettingsValue = "Ctrl1"
        Me.ShortcutButton1.ShortcutText = "CTRL+1"
        Me.ShortcutButton1.Size = New System.Drawing.Size(80, 88)
        Me.ShortcutButton1.TabIndex = 0
        '
        'ShortcutButton2
        '
        Me.ShortcutButton2.BackColor = System.Drawing.Color.Transparent
        Me.ShortcutButton2.CharValue = ""
        Me.ShortcutButton2.Location = New System.Drawing.Point(94, 7)
        Me.ShortcutButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutButton2.Name = "ShortcutButton2"
        Me.ShortcutButton2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortcutButton2.SettingsValue = "Ctrl2"
        Me.ShortcutButton2.ShortcutText = "CTRL+2"
        Me.ShortcutButton2.Size = New System.Drawing.Size(80, 88)
        Me.ShortcutButton2.TabIndex = 1
        '
        'ShortcutButton3
        '
        Me.ShortcutButton3.BackColor = System.Drawing.Color.Transparent
        Me.ShortcutButton3.CharValue = ""
        Me.ShortcutButton3.Location = New System.Drawing.Point(180, 7)
        Me.ShortcutButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutButton3.Name = "ShortcutButton3"
        Me.ShortcutButton3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortcutButton3.SettingsValue = "Ctrl3"
        Me.ShortcutButton3.ShortcutText = "CTRL+3"
        Me.ShortcutButton3.Size = New System.Drawing.Size(80, 88)
        Me.ShortcutButton3.TabIndex = 2
        '
        'ShortcutButton4
        '
        Me.ShortcutButton4.BackColor = System.Drawing.Color.Transparent
        Me.ShortcutButton4.CharValue = ""
        Me.ShortcutButton4.Location = New System.Drawing.Point(266, 7)
        Me.ShortcutButton4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutButton4.Name = "ShortcutButton4"
        Me.ShortcutButton4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortcutButton4.SettingsValue = "Ctrl4"
        Me.ShortcutButton4.ShortcutText = "CTRL+4"
        Me.ShortcutButton4.Size = New System.Drawing.Size(80, 88)
        Me.ShortcutButton4.TabIndex = 3
        '
        'ShortcutButton5
        '
        Me.ShortcutButton5.BackColor = System.Drawing.Color.Transparent
        Me.ShortcutButton5.CharValue = ""
        Me.ShortcutButton5.Location = New System.Drawing.Point(352, 7)
        Me.ShortcutButton5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutButton5.Name = "ShortcutButton5"
        Me.ShortcutButton5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortcutButton5.SettingsValue = "Ctrl5"
        Me.ShortcutButton5.ShortcutText = "CTRL+5"
        Me.ShortcutButton5.Size = New System.Drawing.Size(80, 88)
        Me.ShortcutButton5.TabIndex = 4
        '
        'ShortcutButton6
        '
        Me.ShortcutButton6.BackColor = System.Drawing.Color.Transparent
        Me.ShortcutButton6.CharValue = ""
        Me.ShortcutButton6.Location = New System.Drawing.Point(8, 99)
        Me.ShortcutButton6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutButton6.Name = "ShortcutButton6"
        Me.ShortcutButton6.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortcutButton6.SettingsValue = "Ctrl6"
        Me.ShortcutButton6.ShortcutText = "CTRL+6"
        Me.ShortcutButton6.Size = New System.Drawing.Size(80, 88)
        Me.ShortcutButton6.TabIndex = 5
        '
        'ShortcutButton7
        '
        Me.ShortcutButton7.BackColor = System.Drawing.Color.Transparent
        Me.ShortcutButton7.CharValue = ""
        Me.ShortcutButton7.Location = New System.Drawing.Point(94, 99)
        Me.ShortcutButton7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutButton7.Name = "ShortcutButton7"
        Me.ShortcutButton7.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortcutButton7.SettingsValue = "Ctrl7"
        Me.ShortcutButton7.ShortcutText = "CTRL+7"
        Me.ShortcutButton7.Size = New System.Drawing.Size(80, 88)
        Me.ShortcutButton7.TabIndex = 6
        '
        'ShortcutButton8
        '
        Me.ShortcutButton8.BackColor = System.Drawing.Color.Transparent
        Me.ShortcutButton8.CharValue = ""
        Me.ShortcutButton8.Location = New System.Drawing.Point(180, 99)
        Me.ShortcutButton8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutButton8.Name = "ShortcutButton8"
        Me.ShortcutButton8.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortcutButton8.SettingsValue = "Ctrl8"
        Me.ShortcutButton8.ShortcutText = "CTRL+8"
        Me.ShortcutButton8.Size = New System.Drawing.Size(80, 88)
        Me.ShortcutButton8.TabIndex = 7
        '
        'ShortcutButton9
        '
        Me.ShortcutButton9.BackColor = System.Drawing.Color.Transparent
        Me.ShortcutButton9.CharValue = ""
        Me.ShortcutButton9.Location = New System.Drawing.Point(266, 99)
        Me.ShortcutButton9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutButton9.Name = "ShortcutButton9"
        Me.ShortcutButton9.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortcutButton9.SettingsValue = "Ctrl9"
        Me.ShortcutButton9.ShortcutText = "CTRL+9"
        Me.ShortcutButton9.Size = New System.Drawing.Size(80, 88)
        Me.ShortcutButton9.TabIndex = 8
        '
        'ShortcutButton0
        '
        Me.ShortcutButton0.BackColor = System.Drawing.Color.Transparent
        Me.ShortcutButton0.CharValue = ""
        Me.ShortcutButton0.Location = New System.Drawing.Point(352, 99)
        Me.ShortcutButton0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShortcutButton0.Name = "ShortcutButton0"
        Me.ShortcutButton0.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortcutButton0.SettingsValue = "Ctrl0"
        Me.ShortcutButton0.ShortcutText = "CTRL+0"
        Me.ShortcutButton0.Size = New System.Drawing.Size(80, 88)
        Me.ShortcutButton0.TabIndex = 9
        '
        'SearchTab
        '
        Me.SearchTab.Controls.Add(Me.SearchToolStripContainer)
        Me.SearchTab.Location = New System.Drawing.Point(4, 25)
        Me.SearchTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchTab.Name = "SearchTab"
        Me.SearchTab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchTab.Size = New System.Drawing.Size(474, 112)
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
        Me.SearchToolStripContainer.ContentPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchToolStripContainer.ContentPanel.Size = New System.Drawing.Size(466, 65)
        Me.SearchToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchToolStripContainer.Location = New System.Drawing.Point(4, 4)
        Me.SearchToolStripContainer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchToolStripContainer.Name = "SearchToolStripContainer"
        Me.SearchToolStripContainer.Size = New System.Drawing.Size(466, 104)
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
        Me.SearchCharPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.SearchCharPanel.Name = "SearchCharPanel"
        Me.SearchCharPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.SearchCharPanel.Size = New System.Drawing.Size(466, 65)
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
        Me.SearchToolStrip.Size = New System.Drawing.Size(466, 39)
        Me.SearchToolStrip.Stretch = True
        Me.SearchToolStrip.TabIndex = 0
        '
        'SearchQueryTextBox
        '
        Me.SearchQueryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchQueryTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SearchQueryTextBox.Name = "SearchQueryTextBox"
        Me.SearchQueryTextBox.Size = New System.Drawing.Size(180, 39)
        '
        'CharSearchInLabel
        '
        Me.CharSearchInLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CharSearchInLabel.ForeColor = System.Drawing.Color.Black
        Me.CharSearchInLabel.Name = "CharSearchInLabel"
        Me.CharSearchInLabel.Size = New System.Drawing.Size(21, 36)
        Me.CharSearchInLabel.Text = "in"
        '
        'SearchModeDropDown
        '
        Me.SearchModeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchModeDropDown.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SearchModeDropDown.Items.AddRange(New Object() {"All", "Extended Latin", "Extended Cyrillic", "Extended Greek", "IPA (All)", "IPA Consonants", "IPA Affricates", "IPA Vowels", "IPA Tones", "IPA Diacritics", "IPA Suprasegmentals"})
        Me.SearchModeDropDown.Name = "SearchModeDropDown"
        Me.SearchModeDropDown.Size = New System.Drawing.Size(180, 39)
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
        Me.ModifyCharPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ModifyCharPanel.Name = "ModifyCharPanel"
        Me.ModifyCharPanel.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ModifyCharPanel.Size = New System.Drawing.Size(482, 420)
        Me.ModifyCharPanel.TabIndex = 75
        '
        'AccentGroupBox
        '
        Me.AccentGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.AccentGroupBox.Controls.Add(Me.AccentsPanel)
        Me.AccentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccentGroupBox.Location = New System.Drawing.Point(8, 199)
        Me.AccentGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AccentGroupBox.Name = "AccentGroupBox"
        Me.AccentGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AccentGroupBox.Size = New System.Drawing.Size(466, 214)
        Me.AccentGroupBox.TabIndex = 78
        Me.AccentGroupBox.TabStop = False
        Me.AccentGroupBox.Text = "Accent Marks"
        '
        'AccentsPanel
        '
        Me.AccentsPanel.AutoScroll = True
        Me.AccentsPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AccentsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccentsPanel.Location = New System.Drawing.Point(4, 19)
        Me.AccentsPanel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.AccentsPanel.Name = "AccentsPanel"
        Me.AccentsPanel.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.AccentsPanel.Size = New System.Drawing.Size(458, 191)
        Me.AccentsPanel.TabIndex = 10
        '
        'ModifyCharGroupBox
        '
        Me.ModifyCharGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ModifyCharGroupBox.Controls.Add(Me.ClearButton)
        Me.ModifyCharGroupBox.Controls.Add(Me.AffricateButton)
        Me.ModifyCharGroupBox.Controls.Add(Me.LowercaseButton)
        Me.ModifyCharGroupBox.Controls.Add(Me.UppercaseButton)
        Me.ModifyCharGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModifyCharGroupBox.Location = New System.Drawing.Point(8, 117)
        Me.ModifyCharGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ModifyCharGroupBox.Name = "ModifyCharGroupBox"
        Me.ModifyCharGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ModifyCharGroupBox.Size = New System.Drawing.Size(466, 82)
        Me.ModifyCharGroupBox.TabIndex = 89
        Me.ModifyCharGroupBox.TabStop = False
        Me.ModifyCharGroupBox.Text = "Modify Character"
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClearButton.BackColor = System.Drawing.Color.Transparent
        Me.ClearButton.ForeColor = System.Drawing.Color.Firebrick
        Me.ClearButton.Location = New System.Drawing.Point(329, 26)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(87, 39)
        Me.ClearButton.TabIndex = 79
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'AffricateButton
        '
        Me.AffricateButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AffricateButton.BackColor = System.Drawing.Color.Transparent
        Me.AffricateButton.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AffricateButton.ForeColor = System.Drawing.Color.Black
        Me.AffricateButton.Location = New System.Drawing.Point(254, 26)
        Me.AffricateButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AffricateButton.Name = "AffricateButton"
        Me.AffricateButton.Size = New System.Drawing.Size(67, 39)
        Me.AffricateButton.TabIndex = 78
        Me.AffricateButton.Text = "◌͡◌"
        Me.MainTooltip.SetToolTip(Me.AffricateButton, "Toggle Affricate")
        Me.AffricateButton.UseVisualStyleBackColor = False
        '
        'LowercaseButton
        '
        Me.LowercaseButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LowercaseButton.BackColor = System.Drawing.Color.Transparent
        Me.LowercaseButton.ForeColor = System.Drawing.Color.Black
        Me.LowercaseButton.Location = New System.Drawing.Point(52, 26)
        Me.LowercaseButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LowercaseButton.Name = "LowercaseButton"
        Me.LowercaseButton.Size = New System.Drawing.Size(93, 39)
        Me.LowercaseButton.TabIndex = 78
        Me.LowercaseButton.Text = "Lowercase"
        Me.LowercaseButton.UseVisualStyleBackColor = False
        '
        'UppercaseButton
        '
        Me.UppercaseButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UppercaseButton.BackColor = System.Drawing.Color.Transparent
        Me.UppercaseButton.ForeColor = System.Drawing.Color.Black
        Me.UppercaseButton.Location = New System.Drawing.Point(153, 26)
        Me.UppercaseButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UppercaseButton.Name = "UppercaseButton"
        Me.UppercaseButton.Size = New System.Drawing.Size(93, 39)
        Me.UppercaseButton.TabIndex = 77
        Me.UppercaseButton.Text = "Uppercase"
        Me.UppercaseButton.UseVisualStyleBackColor = False
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
        Me.TopPanel.Location = New System.Drawing.Point(8, 7)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(466, 110)
        Me.TopPanel.TabIndex = 90
        '
        'AddToLocalButton
        '
        Me.AddToLocalButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddToLocalButton.BackColor = System.Drawing.Color.Transparent
        Me.AddToLocalButton.ForeColor = System.Drawing.Color.Black
        Me.AddToLocalButton.Location = New System.Drawing.Point(265, 64)
        Me.AddToLocalButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddToLocalButton.Name = "AddToLocalButton"
        Me.AddToLocalButton.Size = New System.Drawing.Size(73, 39)
        Me.AddToLocalButton.TabIndex = 1
        Me.AddToLocalButton.Text = "Local"
        Me.AddToLocalButton.UseVisualStyleBackColor = False
        '
        'CharacterButton
        '
        Me.CharacterButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CharacterButton.BackColor = System.Drawing.Color.Transparent
        Me.CharacterButton.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterButton.ForeColor = System.Drawing.Color.Black
        Me.CharacterButton.Location = New System.Drawing.Point(50, 4)
        Me.CharacterButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CharacterButton.Name = "CharacterButton"
        Me.CharacterButton.Size = New System.Drawing.Size(107, 100)
        Me.CharacterButton.TabIndex = 88
        Me.CharacterButton.Text = "a"
        Me.CharacterButton.UseVisualStyleBackColor = False
        '
        'CharacterTextBox
        '
        Me.CharacterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CharacterTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharacterTextBox.Location = New System.Drawing.Point(164, 30)
        Me.CharacterTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CharacterTextBox.Name = "CharacterTextBox"
        Me.CharacterTextBox.Size = New System.Drawing.Size(251, 26)
        Me.CharacterTextBox.TabIndex = 77
        '
        'SmartReplaceCheck
        '
        Me.SmartReplaceCheck.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SmartReplaceCheck.AutoSize = True
        Me.SmartReplaceCheck.Checked = True
        Me.SmartReplaceCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SmartReplaceCheck.Location = New System.Drawing.Point(188, 4)
        Me.SmartReplaceCheck.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SmartReplaceCheck.Name = "SmartReplaceCheck"
        Me.SmartReplaceCheck.Size = New System.Drawing.Size(123, 21)
        Me.SmartReplaceCheck.TabIndex = 86
        Me.SmartReplaceCheck.Text = "Smart Replace"
        Me.SmartReplaceCheck.UseVisualStyleBackColor = True
        '
        'AddToFileButton
        '
        Me.AddToFileButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddToFileButton.BackColor = System.Drawing.Color.Transparent
        Me.AddToFileButton.ForeColor = System.Drawing.Color.Black
        Me.AddToFileButton.Location = New System.Drawing.Point(347, 64)
        Me.AddToFileButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddToFileButton.Name = "AddToFileButton"
        Me.AddToFileButton.Size = New System.Drawing.Size(69, 39)
        Me.AddToFileButton.TabIndex = 76
        Me.AddToFileButton.Text = "File"
        Me.AddToFileButton.UseVisualStyleBackColor = False
        '
        'SmartReplaceIndicator
        '
        Me.SmartReplaceIndicator.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SmartReplaceIndicator.BackColor = System.Drawing.Color.DimGray
        Me.SmartReplaceIndicator.Location = New System.Drawing.Point(164, 5)
        Me.SmartReplaceIndicator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SmartReplaceIndicator.Name = "SmartReplaceIndicator"
        Me.SmartReplaceIndicator.Size = New System.Drawing.Size(19, 18)
        Me.SmartReplaceIndicator.TabIndex = 87
        '
        'CopyToClipboardButton
        '
        Me.CopyToClipboardButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CopyToClipboardButton.BackColor = System.Drawing.Color.Transparent
        Me.CopyToClipboardButton.ForeColor = System.Drawing.Color.Black
        Me.CopyToClipboardButton.Location = New System.Drawing.Point(164, 64)
        Me.CopyToClipboardButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CopyToClipboardButton.Name = "CopyToClipboardButton"
        Me.CopyToClipboardButton.Size = New System.Drawing.Size(93, 39)
        Me.CopyToClipboardButton.TabIndex = 79
        Me.CopyToClipboardButton.Text = "Clipboard"
        Me.CopyToClipboardButton.UseVisualStyleBackColor = False
        '
        'CharButtonMenu
        '
        Me.CharButtonMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CharButtonMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToEditorCharacterMenuItem, Me.ReplaceEditorCharacterMenuItem, Me.CopyCharSeparator, Me.CopyToClipboardMenuItem, Me.CopyToFileMenuItem, Me.CopyToLocalMenuItem, Me.ShortcutKeySeparator, Me.ShortcutKeyToolStripMenuItem, Me.RemoveCharSeparator, Me.RemoveToolStripMenuItem})
        Me.CharButtonMenu.Name = "CharButtonMenu"
        Me.CharButtonMenu.Size = New System.Drawing.Size(243, 190)
        '
        'AddToEditorCharacterMenuItem
        '
        Me.AddToEditorCharacterMenuItem.Name = "AddToEditorCharacterMenuItem"
        Me.AddToEditorCharacterMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.AddToEditorCharacterMenuItem.Text = "Add to Editor Character"
        '
        'ReplaceEditorCharacterMenuItem
        '
        Me.ReplaceEditorCharacterMenuItem.Name = "ReplaceEditorCharacterMenuItem"
        Me.ReplaceEditorCharacterMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.ReplaceEditorCharacterMenuItem.Text = "Replace Editor Character"
        '
        'CopyCharSeparator
        '
        Me.CopyCharSeparator.Name = "CopyCharSeparator"
        Me.CopyCharSeparator.Size = New System.Drawing.Size(239, 6)
        '
        'CopyToClipboardMenuItem
        '
        Me.CopyToClipboardMenuItem.Name = "CopyToClipboardMenuItem"
        Me.CopyToClipboardMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.CopyToClipboardMenuItem.Text = "Copy to Clipboard"
        Me.CopyToClipboardMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'CopyToFileMenuItem
        '
        Me.CopyToFileMenuItem.Name = "CopyToFileMenuItem"
        Me.CopyToFileMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.CopyToFileMenuItem.Text = "Copy to File"
        '
        'CopyToLocalMenuItem
        '
        Me.CopyToLocalMenuItem.Name = "CopyToLocalMenuItem"
        Me.CopyToLocalMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.CopyToLocalMenuItem.Text = "Copy to Local"
        '
        'ShortcutKeySeparator
        '
        Me.ShortcutKeySeparator.Name = "ShortcutKeySeparator"
        Me.ShortcutKeySeparator.Size = New System.Drawing.Size(239, 6)
        '
        'ShortcutKeyToolStripMenuItem
        '
        Me.ShortcutKeyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTRL1ToolStripMenuItem, Me.CTRL2ToolStripMenuItem, Me.CTRL3ToolStripMenuItem, Me.CTRL4ToolStripMenuItem, Me.CTRL5ToolStripMenuItem, Me.CTRL6ToolStripMenuItem, Me.CTRL7ToolStripMenuItem, Me.CTRL8ToolStripMenuItem, Me.CTRL9ToolStripMenuItem, Me.CTRL0ToolStripMenuItem})
        Me.ShortcutKeyToolStripMenuItem.Name = "ShortcutKeyToolStripMenuItem"
        Me.ShortcutKeyToolStripMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.ShortcutKeyToolStripMenuItem.Text = "Shortcut Key"
        '
        'CTRL1ToolStripMenuItem
        '
        Me.CTRL1ToolStripMenuItem.Name = "CTRL1ToolStripMenuItem"
        Me.CTRL1ToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.CTRL1ToolStripMenuItem.Text = "CTRL+1"
        '
        'CTRL2ToolStripMenuItem
        '
        Me.CTRL2ToolStripMenuItem.Name = "CTRL2ToolStripMenuItem"
        Me.CTRL2ToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.CTRL2ToolStripMenuItem.Text = "CTRL+2"
        '
        'CTRL3ToolStripMenuItem
        '
        Me.CTRL3ToolStripMenuItem.Name = "CTRL3ToolStripMenuItem"
        Me.CTRL3ToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.CTRL3ToolStripMenuItem.Text = "CTRL+3"
        '
        'CTRL4ToolStripMenuItem
        '
        Me.CTRL4ToolStripMenuItem.Name = "CTRL4ToolStripMenuItem"
        Me.CTRL4ToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.CTRL4ToolStripMenuItem.Text = "CTRL+4"
        '
        'CTRL5ToolStripMenuItem
        '
        Me.CTRL5ToolStripMenuItem.Name = "CTRL5ToolStripMenuItem"
        Me.CTRL5ToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.CTRL5ToolStripMenuItem.Text = "CTRL+5"
        '
        'CTRL6ToolStripMenuItem
        '
        Me.CTRL6ToolStripMenuItem.Name = "CTRL6ToolStripMenuItem"
        Me.CTRL6ToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.CTRL6ToolStripMenuItem.Text = "CTRL+6"
        '
        'CTRL7ToolStripMenuItem
        '
        Me.CTRL7ToolStripMenuItem.Name = "CTRL7ToolStripMenuItem"
        Me.CTRL7ToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.CTRL7ToolStripMenuItem.Text = "CTRL+7"
        '
        'CTRL8ToolStripMenuItem
        '
        Me.CTRL8ToolStripMenuItem.Name = "CTRL8ToolStripMenuItem"
        Me.CTRL8ToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.CTRL8ToolStripMenuItem.Text = "CTRL+8"
        '
        'CTRL9ToolStripMenuItem
        '
        Me.CTRL9ToolStripMenuItem.Name = "CTRL9ToolStripMenuItem"
        Me.CTRL9ToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.CTRL9ToolStripMenuItem.Text = "CTRL+9"
        '
        'CTRL0ToolStripMenuItem
        '
        Me.CTRL0ToolStripMenuItem.Name = "CTRL0ToolStripMenuItem"
        Me.CTRL0ToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.CTRL0ToolStripMenuItem.Text = "CTRL+0"
        '
        'RemoveCharSeparator
        '
        Me.RemoveCharSeparator.Name = "RemoveCharSeparator"
        Me.RemoveCharSeparator.Size = New System.Drawing.Size(239, 6)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ModifyCharPanel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CharCategoriesTabs)
        Me.SplitContainer1.Size = New System.Drawing.Size(482, 566)
        Me.SplitContainer1.SplitterDistance = 420
        Me.SplitContainer1.SplitterWidth = 5
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
        'ShortcutButtonMenu
        '
        Me.ShortcutButtonMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ShortcutButtonMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetKeyToolStripMenuItem, Me.ResetAllKeysToolStripMenuItem})
        Me.ShortcutButtonMenu.Name = "CharButtonMenu"
        Me.ShortcutButtonMenu.Size = New System.Drawing.Size(171, 52)
        '
        'ResetKeyToolStripMenuItem
        '
        Me.ResetKeyToolStripMenuItem.Name = "ResetKeyToolStripMenuItem"
        Me.ResetKeyToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.ResetKeyToolStripMenuItem.Text = "Reset Key"
        '
        'ResetAllKeysToolStripMenuItem
        '
        Me.ResetAllKeysToolStripMenuItem.Name = "ResetAllKeysToolStripMenuItem"
        Me.ResetAllKeysToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.ResetAllKeysToolStripMenuItem.Text = "Reset All Keys"
        '
        'CharacterEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(453, 0)
        Me.Name = "CharacterEditor"
        Me.Size = New System.Drawing.Size(482, 566)
        Me.CharCategoriesTabs.ResumeLayout(False)
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
        Me.ConsonantsTab.ResumeLayout(False)
        Me.ConsonantsTab.PerformLayout()
        Me.AffricatesTab.ResumeLayout(False)
        Me.VowelsTab.ResumeLayout(False)
        Me.ToneIntonationTab.ResumeLayout(False)
        Me.DiacriticsTab.ResumeLayout(False)
        Me.SuprasegmentalsTab.ResumeLayout(False)
        Me.BracketsTab.ResumeLayout(False)
        Me.BracketsTab.PerformLayout()
        Me.ShortcutsTab.ResumeLayout(False)
        Me.ShortcutsTab.PerformLayout()
        Me.ShortcutsPanel.ResumeLayout(False)
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
        Me.ShortcutButtonMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

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
