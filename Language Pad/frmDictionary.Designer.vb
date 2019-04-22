<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDictionary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDictionary))
        Me.dgvDictionary = New System.Windows.Forms.DataGridView()
        Me.Word = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pronunciation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Definition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
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
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.dlgSaveHtml = New System.Windows.Forms.SaveFileDialog()
        Me.pnlFindReplace = New TundraLib.DoubleBufferedPanel()
        Me.cbStartsWith = New System.Windows.Forms.CheckBox()
        Me.rbDefinition = New System.Windows.Forms.RadioButton()
        Me.rbWord = New System.Windows.Forms.RadioButton()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        CType(Me.dgvDictionary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout
        Me.ToolStripContainer1.SuspendLayout
        Me.MainToolStrip.SuspendLayout
        Me.pnlFindReplace.SuspendLayout
        Me.SuspendLayout
        '
        'dgvDictionary
        '
        Me.dgvDictionary.AllowUserToAddRows = False
        Me.dgvDictionary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDictionary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDictionary.BackgroundColor = System.Drawing.Color.White
        Me.dgvDictionary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDictionary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDictionary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Word, Me.Pronunciation, Me.Definition, Me.Notes})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDictionary.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDictionary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDictionary.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvDictionary.Location = New System.Drawing.Point(0, 35)
        Me.dgvDictionary.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDictionary.Name = "dgvDictionary"
        Me.dgvDictionary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDictionary.RowTemplate.Height = 24
        Me.dgvDictionary.Size = New System.Drawing.Size(888, 488)
        Me.dgvDictionary.TabIndex = 3
        '
        'Word
        '
        Me.Word.HeaderText = "Word"
        Me.Word.Name = "Word"
        Me.Word.Width = 58
        '
        'Pronunciation
        '
        Me.Pronunciation.HeaderText = "Pronunciation"
        Me.Pronunciation.Name = "Pronunciation"
        Me.Pronunciation.Width = 97
        '
        'Definition
        '
        Me.Definition.HeaderText = "Definition"
        Me.Definition.Name = "Definition"
        Me.Definition.Width = 76
        '
        'Notes
        '
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.Width = 60
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Dictionary file (*.dict)|*.dict|CSV file (*.csv)|*.csv|Text files (*.txt)|*.txt|A" &
    "ll files (*.*)|*.*"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Dictionary file (*.dict)|*.dict|CSV file (*.csv)|*.csv|Text files (*.txt)|*.txt|A" &
    "ll files (*.*)|*.*"
        '
        'dlgFont
        '
        Me.dlgFont.ShowColor = True
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.dgvDictionary)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.pnlFindReplace)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(888, 523)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.Size = New System.Drawing.Size(888, 552)
        Me.ToolStripContainer1.TabIndex = 75
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MainToolStrip)
        '
        'MainToolStrip
        '
        Me.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ExportHtmlToolStripButton, Me.ToolStripSeparator1, Me.CharacterEditorToolStripButton, Me.ToolStripSeparator2, Me.AddToolStripButton, Me.RemoveToolStripButton, Me.ToolStripSeparator3, Me.FontToolStripButton, Me.ToolStripSeparator4, Me.FindToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(888, 29)
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
        Me.NewToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.NewToolStripButton.Text = "New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.OpenToolStripButton.Text = "Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.SaveToolStripButton.Text = "Save"
        '
        'ExportHtmlToolStripButton
        '
        Me.ExportHtmlToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportHtmlToolStripButton.Image = CType(resources.GetObject("ExportHtmlToolStripButton.Image"), System.Drawing.Image)
        Me.ExportHtmlToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportHtmlToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportHtmlToolStripButton.Name = "ExportHtmlToolStripButton"
        Me.ExportHtmlToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.ExportHtmlToolStripButton.Text = "Export To HTML"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'CharacterEditorToolStripButton
        '
        Me.CharacterEditorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CharacterEditorToolStripButton.Image = CType(resources.GetObject("CharacterEditorToolStripButton.Image"), System.Drawing.Image)
        Me.CharacterEditorToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CharacterEditorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CharacterEditorToolStripButton.Name = "CharacterEditorToolStripButton"
        Me.CharacterEditorToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.CharacterEditorToolStripButton.Text = "Character Editor"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = CType(resources.GetObject("AddToolStripButton.Image"), System.Drawing.Image)
        Me.AddToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.AddToolStripButton.Text = "Add"
        '
        'RemoveToolStripButton
        '
        Me.RemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveToolStripButton.Image = CType(resources.GetObject("RemoveToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveToolStripButton.Name = "RemoveToolStripButton"
        Me.RemoveToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.RemoveToolStripButton.Text = "Remove"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'FontToolStripButton
        '
        Me.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), System.Drawing.Image)
        Me.FontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontToolStripButton.Name = "FontToolStripButton"
        Me.FontToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.FontToolStripButton.Text = "Font"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 29)
        '
        'FindToolStripButton
        '
        Me.FindToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FindToolStripButton.Image = CType(resources.GetObject("FindToolStripButton.Image"), System.Drawing.Image)
        Me.FindToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FindToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FindToolStripButton.Name = "FindToolStripButton"
        Me.FindToolStripButton.Size = New System.Drawing.Size(26, 26)
        Me.FindToolStripButton.Text = "Find"
        '
        'dlgSaveHtml
        '
        Me.dlgSaveHtml.Filter = "HTML Page (*.html)|*.html|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'pnlFindReplace
        '
        Me.pnlFindReplace.BackColor = System.Drawing.Color.Transparent
        Me.pnlFindReplace.Controls.Add(Me.cbStartsWith)
        Me.pnlFindReplace.Controls.Add(Me.rbDefinition)
        Me.pnlFindReplace.Controls.Add(Me.rbWord)
        Me.pnlFindReplace.Controls.Add(Me.txtFind)
        Me.pnlFindReplace.Controls.Add(Me.Label17)
        Me.pnlFindReplace.Controls.Add(Me.btnFind)
        Me.pnlFindReplace.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFindReplace.Location = New System.Drawing.Point(0, 0)
        Me.pnlFindReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlFindReplace.Name = "pnlFindReplace"
        Me.pnlFindReplace.Size = New System.Drawing.Size(888, 35)
        Me.pnlFindReplace.TabIndex = 75
        Me.pnlFindReplace.Visible = False
        '
        'cbStartsWith
        '
        Me.cbStartsWith.AutoSize = True
        Me.cbStartsWith.Location = New System.Drawing.Point(312, 10)
        Me.cbStartsWith.Margin = New System.Windows.Forms.Padding(2)
        Me.cbStartsWith.Name = "cbStartsWith"
        Me.cbStartsWith.Size = New System.Drawing.Size(78, 17)
        Me.cbStartsWith.TabIndex = 69
        Me.cbStartsWith.Text = "Starts With"
        Me.cbStartsWith.UseVisualStyleBackColor = True
        '
        'rbDefinition
        '
        Me.rbDefinition.AutoSize = True
        Me.rbDefinition.Checked = True
        Me.rbDefinition.Location = New System.Drawing.Point(449, 9)
        Me.rbDefinition.Margin = New System.Windows.Forms.Padding(2)
        Me.rbDefinition.Name = "rbDefinition"
        Me.rbDefinition.Size = New System.Drawing.Size(69, 17)
        Me.rbDefinition.TabIndex = 71
        Me.rbDefinition.TabStop = True
        Me.rbDefinition.Text = "Definition"
        Me.rbDefinition.UseVisualStyleBackColor = True
        '
        'rbWord
        '
        Me.rbWord.AutoSize = True
        Me.rbWord.Location = New System.Drawing.Point(394, 9)
        Me.rbWord.Margin = New System.Windows.Forms.Padding(2)
        Me.rbWord.Name = "rbWord"
        Me.rbWord.Size = New System.Drawing.Size(51, 17)
        Me.rbWord.TabIndex = 70
        Me.rbWord.Text = "Word"
        Me.rbWord.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(40, 9)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(268, 20)
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
        'btnFind
        '
        Me.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFind.FlatAppearance.BorderSize = 0
        Me.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFind.Location = New System.Drawing.Point(522, 5)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(78, 24)
        Me.btnFind.TabIndex = 67
        Me.btnFind.Text = "Find"
        '
        'frmDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 552)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDictionary"
        Me.Text = "Dictionary"
        CType(Me.dgvDictionary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout
        Me.pnlFindReplace.ResumeLayout(False)
        Me.pnlFindReplace.PerformLayout
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDictionary As DataGridView
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents dlgFont As FontDialog
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CharacterEditorToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FontToolStripButton As ToolStripButton
    Friend WithEvents AddToolStripButton As ToolStripButton
    Friend WithEvents RemoveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Word As DataGridViewTextBoxColumn
    Friend WithEvents Pronunciation As DataGridViewTextBoxColumn
    Friend WithEvents Definition As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents ExportHtmlToolStripButton As ToolStripButton
    Friend WithEvents dlgSaveHtml As SaveFileDialog
    Friend WithEvents pnlFindReplace As TundraLib.DoubleBufferedPanel
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents FindToolStripButton As ToolStripButton
    Friend WithEvents cbStartsWith As CheckBox
    Friend WithEvents rbDefinition As RadioButton
    Friend WithEvents rbWord As RadioButton
End Class
