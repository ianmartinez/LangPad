<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DictionaryForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DictionaryForm))
        Me.DictionaryGrid = New System.Windows.Forms.DataGridView()
        Me.Word = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pronunciation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Definition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.FontPicker = New System.Windows.Forms.FontDialog()
        Me.MainToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.GridBorder = New LangPadUI.DoubleBufferedPanel()
        Me.FindReplacePanel = New LangPadUI.DoubleBufferedPanel()
        Me.StartsWithCheck = New System.Windows.Forms.CheckBox()
        Me.DefinitionRadio = New System.Windows.Forms.RadioButton()
        Me.WordRadio = New System.Windows.Forms.RadioButton()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImportToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExportToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExportHtmlToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CharacterEditorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RemoveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ResetFontToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToHtmlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDisplayFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetDisplayFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPronunciationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDefinitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditNotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinguisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.BroadTranscriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NarrowTranscriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveBracketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DictionaryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainToolStripContainer.ContentPanel.SuspendLayout()
        Me.MainToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.MainToolStripContainer.SuspendLayout()
        Me.GridBorder.SuspendLayout()
        Me.FindReplacePanel.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DictionaryGrid
        '
        Me.DictionaryGrid.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DictionaryGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DictionaryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DictionaryGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DictionaryGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DictionaryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DictionaryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DictionaryGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DictionaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DictionaryGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Word, Me.Pronunciation, Me.Definition, Me.Notes})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DictionaryGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.DictionaryGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DictionaryGrid.GridColor = System.Drawing.Color.Gainsboro
        Me.DictionaryGrid.Location = New System.Drawing.Point(1, 1)
        Me.DictionaryGrid.Name = "DictionaryGrid"
        Me.DictionaryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DictionaryGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DictionaryGrid.RowHeadersWidth = 62
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.DictionaryGrid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DictionaryGrid.RowTemplate.Height = 24
        Me.DictionaryGrid.Size = New System.Drawing.Size(1176, 514)
        Me.DictionaryGrid.TabIndex = 3
        '
        'Word
        '
        Me.Word.HeaderText = "Word"
        Me.Word.MinimumWidth = 8
        Me.Word.Name = "Word"
        Me.Word.Width = 87
        '
        'Pronunciation
        '
        Me.Pronunciation.HeaderText = "Pronunciation"
        Me.Pronunciation.MinimumWidth = 8
        Me.Pronunciation.Name = "Pronunciation"
        Me.Pronunciation.Width = 155
        '
        'Definition
        '
        Me.Definition.HeaderText = "Definition"
        Me.Definition.MinimumWidth = 8
        Me.Definition.Name = "Definition"
        Me.Definition.Width = 122
        '
        'Notes
        '
        Me.Notes.HeaderText = "Notes"
        Me.Notes.MinimumWidth = 8
        Me.Notes.Name = "Notes"
        Me.Notes.Width = 92
        '
        'OpenDialog
        '
        Me.OpenDialog.Filter = "Dictionary file (*.dict)|*.dict|CSV file (*.csv)|*.csv|Text files (*.txt)|*.txt|A" &
    "ll files (*.*)|*.*"
        '
        'SaveDialog
        '
        Me.SaveDialog.Filter = "Dictionary file (*.dict)|*.dict|CSV file (*.csv)|*.csv|Text files (*.txt)|*.txt|A" &
    "ll files (*.*)|*.*"
        '
        'FontPicker
        '
        Me.FontPicker.ShowColor = True
        '
        'MainToolStripContainer
        '
        '
        'MainToolStripContainer.ContentPanel
        '
        Me.MainToolStripContainer.ContentPanel.Controls.Add(Me.GridBorder)
        Me.MainToolStripContainer.ContentPanel.Controls.Add(Me.FindReplacePanel)
        Me.MainToolStripContainer.ContentPanel.Size = New System.Drawing.Size(1178, 570)
        Me.MainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainToolStripContainer.Location = New System.Drawing.Point(0, 33)
        Me.MainToolStripContainer.Name = "MainToolStripContainer"
        Me.MainToolStripContainer.Size = New System.Drawing.Size(1178, 611)
        Me.MainToolStripContainer.TabIndex = 75
        Me.MainToolStripContainer.Text = "MainToolStripContainer"
        '
        'MainToolStripContainer.TopToolStripPanel
        '
        Me.MainToolStripContainer.TopToolStripPanel.Controls.Add(Me.MainToolStrip)
        '
        'GridBorder
        '
        Me.GridBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridBorder.Controls.Add(Me.DictionaryGrid)
        Me.GridBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBorder.Location = New System.Drawing.Point(0, 54)
        Me.GridBorder.Name = "GridBorder"
        Me.GridBorder.Padding = New System.Windows.Forms.Padding(1)
        Me.GridBorder.Size = New System.Drawing.Size(1178, 516)
        Me.GridBorder.TabIndex = 77
        '
        'FindReplacePanel
        '
        Me.FindReplacePanel.BackColor = System.Drawing.Color.Transparent
        Me.FindReplacePanel.Controls.Add(Me.StartsWithCheck)
        Me.FindReplacePanel.Controls.Add(Me.DefinitionRadio)
        Me.FindReplacePanel.Controls.Add(Me.WordRadio)
        Me.FindReplacePanel.Controls.Add(Me.FindTextBox)
        Me.FindReplacePanel.Controls.Add(Me.Label17)
        Me.FindReplacePanel.Controls.Add(Me.FindButton)
        Me.FindReplacePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FindReplacePanel.Location = New System.Drawing.Point(0, 0)
        Me.FindReplacePanel.Name = "FindReplacePanel"
        Me.FindReplacePanel.Size = New System.Drawing.Size(1178, 54)
        Me.FindReplacePanel.TabIndex = 75
        Me.FindReplacePanel.Visible = False
        '
        'StartsWithCheck
        '
        Me.StartsWithCheck.AutoSize = True
        Me.StartsWithCheck.Location = New System.Drawing.Point(468, 15)
        Me.StartsWithCheck.Name = "StartsWithCheck"
        Me.StartsWithCheck.Size = New System.Drawing.Size(114, 24)
        Me.StartsWithCheck.TabIndex = 69
        Me.StartsWithCheck.Text = "Starts With"
        Me.StartsWithCheck.UseVisualStyleBackColor = True
        '
        'DefinitionRadio
        '
        Me.DefinitionRadio.AutoSize = True
        Me.DefinitionRadio.Checked = True
        Me.DefinitionRadio.Location = New System.Drawing.Point(674, 14)
        Me.DefinitionRadio.Name = "DefinitionRadio"
        Me.DefinitionRadio.Size = New System.Drawing.Size(101, 24)
        Me.DefinitionRadio.TabIndex = 71
        Me.DefinitionRadio.TabStop = True
        Me.DefinitionRadio.Text = "Definition"
        Me.DefinitionRadio.UseVisualStyleBackColor = True
        '
        'WordRadio
        '
        Me.WordRadio.AutoSize = True
        Me.WordRadio.Location = New System.Drawing.Point(591, 14)
        Me.WordRadio.Name = "WordRadio"
        Me.WordRadio.Size = New System.Drawing.Size(72, 24)
        Me.WordRadio.TabIndex = 70
        Me.WordRadio.Text = "Word"
        Me.WordRadio.UseVisualStyleBackColor = True
        '
        'FindTextBox
        '
        Me.FindTextBox.Location = New System.Drawing.Point(60, 14)
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(400, 26)
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
        'FindButton
        '
        Me.FindButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FindButton.FlatAppearance.BorderSize = 0
        Me.FindButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.FindButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FindButton.Location = New System.Drawing.Point(783, 8)
        Me.FindButton.Name = "FindButton"
        Me.FindButton.Size = New System.Drawing.Size(117, 37)
        Me.FindButton.TabIndex = 67
        Me.FindButton.Text = "Find"
        '
        'MainToolStrip
        '
        Me.MainToolStrip.CanOverflow = False
        Me.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.ImportToolStripButton, Me.ExportToolStripButton, Me.ExportHtmlToolStripButton, Me.ToolStripSeparator1, Me.CharacterEditorToolStripButton, Me.ToolStripSeparator2, Me.AddToolStripButton, Me.RemoveToolStripButton, Me.ToolStripSeparator3, Me.FontToolStripButton, Me.ResetFontToolStripButton, Me.ToolStripSeparator4, Me.FindToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(1178, 41)
        Me.MainToolStrip.Stretch = True
        Me.MainToolStrip.TabIndex = 1
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
        'ImportToolStripButton
        '
        Me.ImportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportToolStripButton.Image = CType(resources.GetObject("ImportToolStripButton.Image"), System.Drawing.Image)
        Me.ImportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportToolStripButton.Name = "ImportToolStripButton"
        Me.ImportToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ImportToolStripButton.Text = "Import"
        '
        'ExportToolStripButton
        '
        Me.ExportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportToolStripButton.Image = CType(resources.GetObject("ExportToolStripButton.Image"), System.Drawing.Image)
        Me.ExportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportToolStripButton.Name = "ExportToolStripButton"
        Me.ExportToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ExportToolStripButton.Text = "Export"
        '
        'ExportHtmlToolStripButton
        '
        Me.ExportHtmlToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportHtmlToolStripButton.Image = CType(resources.GetObject("ExportHtmlToolStripButton.Image"), System.Drawing.Image)
        Me.ExportHtmlToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportHtmlToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportHtmlToolStripButton.Name = "ExportHtmlToolStripButton"
        Me.ExportHtmlToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ExportHtmlToolStripButton.Text = "Export To HTML"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 41)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 41)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = CType(resources.GetObject("AddToolStripButton.Image"), System.Drawing.Image)
        Me.AddToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.AddToolStripButton.Text = "Add Word"
        '
        'RemoveToolStripButton
        '
        Me.RemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveToolStripButton.Image = CType(resources.GetObject("RemoveToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveToolStripButton.Name = "RemoveToolStripButton"
        Me.RemoveToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.RemoveToolStripButton.Text = "Remove Word"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 41)
        '
        'FontToolStripButton
        '
        Me.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), System.Drawing.Image)
        Me.FontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontToolStripButton.Name = "FontToolStripButton"
        Me.FontToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.FontToolStripButton.Text = "Display Font"
        '
        'ResetFontToolStripButton
        '
        Me.ResetFontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ResetFontToolStripButton.Image = CType(resources.GetObject("ResetFontToolStripButton.Image"), System.Drawing.Image)
        Me.ResetFontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ResetFontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ResetFontToolStripButton.Name = "ResetFontToolStripButton"
        Me.ResetFontToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ResetFontToolStripButton.Text = "Reset Display Font"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 41)
        '
        'FindToolStripButton
        '
        Me.FindToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FindToolStripButton.Image = CType(resources.GetObject("FindToolStripButton.Image"), System.Drawing.Image)
        Me.FindToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FindToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FindToolStripButton.Name = "FindToolStripButton"
        Me.FindToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.FindToolStripButton.Text = "Find"
        '
        'MainMenu
        '
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.WordToolStripMenuItem, Me.LinguisticsToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MainMenu.Size = New System.Drawing.Size(1178, 33)
        Me.MainMenu.TabIndex = 76
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripSeparator6, Me.ImportToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ExportToHtmlToolStripMenuItem})
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
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(358, 34)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(358, 34)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(355, 6)
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(358, 34)
        Me.ImportToolStripMenuItem.Text = "Import..."
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(358, 34)
        Me.ExportToolStripMenuItem.Text = "Export..."
        '
        'ExportToHtmlToolStripMenuItem
        '
        Me.ExportToHtmlToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportToHtmlToolStripMenuItem.Name = "ExportToHtmlToolStripMenuItem"
        Me.ExportToHtmlToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ExportToHtmlToolStripMenuItem.Size = New System.Drawing.Size(358, 34)
        Me.ExportToHtmlToolStripMenuItem.Text = "Export to HTML..."
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem, Me.ToolStripSeparator7, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(245, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(248, 34)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditDisplayFontToolStripMenuItem, Me.ResetDisplayFontToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'EditDisplayFontToolStripMenuItem
        '
        Me.EditDisplayFontToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditDisplayFontToolStripMenuItem.Name = "EditDisplayFontToolStripMenuItem"
        Me.EditDisplayFontToolStripMenuItem.Size = New System.Drawing.Size(260, 34)
        Me.EditDisplayFontToolStripMenuItem.Text = "Display Font..."
        '
        'ResetDisplayFontToolStripMenuItem
        '
        Me.ResetDisplayFontToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ResetDisplayFontToolStripMenuItem.Name = "ResetDisplayFontToolStripMenuItem"
        Me.ResetDisplayFontToolStripMenuItem.Size = New System.Drawing.Size(260, 34)
        Me.ResetDisplayFontToolStripMenuItem.Text = "Reset Display Font"
        '
        'WordToolStripMenuItem
        '
        Me.WordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddWordToolStripMenuItem, Me.RemoveWordToolStripMenuItem, Me.ToolStripSeparator8, Me.EditWordToolStripMenuItem, Me.EditPronunciationToolStripMenuItem, Me.EditDefinitionToolStripMenuItem, Me.EditNotesToolStripMenuItem})
        Me.WordToolStripMenuItem.Name = "WordToolStripMenuItem"
        Me.WordToolStripMenuItem.Size = New System.Drawing.Size(72, 29)
        Me.WordToolStripMenuItem.Text = "Word"
        '
        'AddWordToolStripMenuItem
        '
        Me.AddWordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddWordToolStripMenuItem.Name = "AddWordToolStripMenuItem"
        Me.AddWordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.AddWordToolStripMenuItem.Size = New System.Drawing.Size(319, 34)
        Me.AddWordToolStripMenuItem.Text = "Add Word"
        '
        'RemoveWordToolStripMenuItem
        '
        Me.RemoveWordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveWordToolStripMenuItem.Name = "RemoveWordToolStripMenuItem"
        Me.RemoveWordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RemoveWordToolStripMenuItem.Size = New System.Drawing.Size(319, 34)
        Me.RemoveWordToolStripMenuItem.Text = "Remove Word"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(316, 6)
        '
        'EditWordToolStripMenuItem
        '
        Me.EditWordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditWordToolStripMenuItem.Name = "EditWordToolStripMenuItem"
        Me.EditWordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditWordToolStripMenuItem.Size = New System.Drawing.Size(319, 34)
        Me.EditWordToolStripMenuItem.Text = "Edit Word"
        '
        'EditPronunciationToolStripMenuItem
        '
        Me.EditPronunciationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditPronunciationToolStripMenuItem.Name = "EditPronunciationToolStripMenuItem"
        Me.EditPronunciationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.EditPronunciationToolStripMenuItem.Size = New System.Drawing.Size(319, 34)
        Me.EditPronunciationToolStripMenuItem.Text = "Edit Pronunciation"
        '
        'EditDefinitionToolStripMenuItem
        '
        Me.EditDefinitionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditDefinitionToolStripMenuItem.Name = "EditDefinitionToolStripMenuItem"
        Me.EditDefinitionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.EditDefinitionToolStripMenuItem.Size = New System.Drawing.Size(319, 34)
        Me.EditDefinitionToolStripMenuItem.Text = "Edit Definition"
        '
        'EditNotesToolStripMenuItem
        '
        Me.EditNotesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditNotesToolStripMenuItem.Name = "EditNotesToolStripMenuItem"
        Me.EditNotesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.EditNotesToolStripMenuItem.Size = New System.Drawing.Size(319, 34)
        Me.EditNotesToolStripMenuItem.Text = "Edit Notes"
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
        'DictionaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 644)
        Me.Controls.Add(Me.MainToolStripContainer)
        Me.Controls.Add(Me.MainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DictionaryForm"
        Me.Text = "Dictionary"
        CType(Me.DictionaryGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.MainToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.MainToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.MainToolStripContainer.ResumeLayout(False)
        Me.MainToolStripContainer.PerformLayout()
        Me.GridBorder.ResumeLayout(False)
        Me.FindReplacePanel.ResumeLayout(False)
        Me.FindReplacePanel.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DictionaryGrid As DataGridView
    Friend WithEvents OpenDialog As OpenFileDialog
    Friend WithEvents SaveDialog As SaveFileDialog
    Friend WithEvents FontPicker As FontDialog
    Friend WithEvents MainToolStripContainer As ToolStripContainer
    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents ImportToolStripButton As ToolStripButton
    Friend WithEvents ExportToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CharacterEditorToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AddToolStripButton As ToolStripButton
    Friend WithEvents RemoveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Word As DataGridViewTextBoxColumn
    Friend WithEvents Pronunciation As DataGridViewTextBoxColumn
    Friend WithEvents Definition As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents ExportHtmlToolStripButton As ToolStripButton
    Friend WithEvents FindReplacePanel As LangPadUI.DoubleBufferedPanel
    Friend WithEvents FindTextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents FindButton As Button
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents FindToolStripButton As ToolStripButton
    Friend WithEvents StartsWithCheck As CheckBox
    Friend WithEvents DefinitionRadio As RadioButton
    Friend WithEvents WordRadio As RadioButton
    Friend WithEvents FontToolStripButton As ToolStripButton
    Friend WithEvents ResetFontToolStripButton As ToolStripButton
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ExportToHtmlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDisplayFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetDisplayFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents EditWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPronunciationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDefinitionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditNotesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinguisticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CharacterEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator25 As ToolStripSeparator
    Friend WithEvents BroadTranscriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NarrowTranscriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveBracketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GridBorder As LangPadUI.DoubleBufferedPanel
End Class
