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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.FindReplaceDialog = New TundraLib.DoubleBufferedPanel()
        Me.StartsWithCheck = New System.Windows.Forms.CheckBox()
        Me.DefinitionRadio = New System.Windows.Forms.RadioButton()
        Me.WordRadio = New System.Windows.Forms.RadioButton()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.FindButton = New System.Windows.Forms.Button()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
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
        Me.SaveHtmlDialog = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DictionaryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainToolStripContainer.ContentPanel.SuspendLayout()
        Me.MainToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.MainToolStripContainer.SuspendLayout()
        Me.FindReplaceDialog.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DictionaryGrid
        '
        Me.DictionaryGrid.AllowUserToAddRows = False
        Me.DictionaryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DictionaryGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DictionaryGrid.BackgroundColor = System.Drawing.Color.White
        Me.DictionaryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DictionaryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DictionaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DictionaryGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Word, Me.Pronunciation, Me.Definition, Me.Notes})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DictionaryGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DictionaryGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DictionaryGrid.GridColor = System.Drawing.Color.Gainsboro
        Me.DictionaryGrid.Location = New System.Drawing.Point(0, 54)
        Me.DictionaryGrid.Name = "DictionaryGrid"
        Me.DictionaryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DictionaryGrid.RowHeadersWidth = 62
        Me.DictionaryGrid.RowTemplate.Height = 24
        Me.DictionaryGrid.Size = New System.Drawing.Size(1332, 754)
        Me.DictionaryGrid.TabIndex = 3
        '
        'Word
        '
        Me.Word.HeaderText = "Word"
        Me.Word.MinimumWidth = 8
        Me.Word.Name = "Word"
        Me.Word.Width = 83
        '
        'Pronunciation
        '
        Me.Pronunciation.HeaderText = "Pronunciation"
        Me.Pronunciation.MinimumWidth = 8
        Me.Pronunciation.Name = "Pronunciation"
        Me.Pronunciation.Width = 142
        '
        'Definition
        '
        Me.Definition.HeaderText = "Definition"
        Me.Definition.MinimumWidth = 8
        Me.Definition.Name = "Definition"
        Me.Definition.Width = 112
        '
        'Notes
        '
        Me.Notes.HeaderText = "Notes"
        Me.Notes.MinimumWidth = 8
        Me.Notes.Name = "Notes"
        Me.Notes.Width = 87
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
        'MainToolStripContainer.BottomToolStripPanel
        '
        '
        'MainToolStripContainer.ContentPanel
        '
        Me.MainToolStripContainer.ContentPanel.Controls.Add(Me.DictionaryGrid)
        Me.MainToolStripContainer.ContentPanel.Controls.Add(Me.FindReplaceDialog)
        Me.MainToolStripContainer.ContentPanel.Size = New System.Drawing.Size(1332, 808)
        Me.MainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'MainToolStripContainer.LeftToolStripPanel
        '
        Me.MainToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStripContainer.Name = "MainToolStripContainer"
        '
        'MainToolStripContainer.RightToolStripPanel
        '
        Me.MainToolStripContainer.Size = New System.Drawing.Size(1332, 849)
        Me.MainToolStripContainer.TabIndex = 75
        Me.MainToolStripContainer.Text = "MainToolStripContainer"
        '
        'MainToolStripContainer.TopToolStripPanel
        '
        Me.MainToolStripContainer.TopToolStripPanel.Controls.Add(Me.MainToolStrip)
        '
        'FindReplaceDialog
        '
        Me.FindReplaceDialog.BackColor = System.Drawing.Color.Transparent
        Me.FindReplaceDialog.Controls.Add(Me.StartsWithCheck)
        Me.FindReplaceDialog.Controls.Add(Me.DefinitionRadio)
        Me.FindReplaceDialog.Controls.Add(Me.WordRadio)
        Me.FindReplaceDialog.Controls.Add(Me.FindTextBox)
        Me.FindReplaceDialog.Controls.Add(Me.Label17)
        Me.FindReplaceDialog.Controls.Add(Me.FindButton)
        Me.FindReplaceDialog.Dock = System.Windows.Forms.DockStyle.Top
        Me.FindReplaceDialog.Location = New System.Drawing.Point(0, 0)
        Me.FindReplaceDialog.Name = "FindReplaceDialog"
        Me.FindReplaceDialog.Size = New System.Drawing.Size(1332, 54)
        Me.FindReplaceDialog.TabIndex = 75
        Me.FindReplaceDialog.Visible = False
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
        Me.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ExportHtmlToolStripButton, Me.ToolStripSeparator1, Me.CharacterEditorToolStripButton, Me.ToolStripSeparator2, Me.AddToolStripButton, Me.RemoveToolStripButton, Me.ToolStripSeparator3, Me.FontToolStripButton, Me.ResetFontToolStripButton, Me.ToolStripSeparator4, Me.FindToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(1332, 41)
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
        Me.AddToolStripButton.Text = "Add"
        '
        'RemoveToolStripButton
        '
        Me.RemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveToolStripButton.Image = CType(resources.GetObject("RemoveToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveToolStripButton.Name = "RemoveToolStripButton"
        Me.RemoveToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.RemoveToolStripButton.Text = "Remove"
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
        'SaveHtmlDialog
        '
        Me.SaveHtmlDialog.Filter = "HTML Page (*.html)|*.html|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'DictionaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 849)
        Me.Controls.Add(Me.MainToolStripContainer)
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
        Me.FindReplaceDialog.ResumeLayout(False)
        Me.FindReplaceDialog.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DictionaryGrid As DataGridView
    Friend WithEvents OpenDialog As OpenFileDialog
    Friend WithEvents SaveDialog As SaveFileDialog
    Friend WithEvents FontPicker As FontDialog
    Friend WithEvents MainToolStripContainer As ToolStripContainer
    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
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
    Friend WithEvents SaveHtmlDialog As SaveFileDialog
    Friend WithEvents FindReplaceDialog As TundraLib.DoubleBufferedPanel
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
End Class
