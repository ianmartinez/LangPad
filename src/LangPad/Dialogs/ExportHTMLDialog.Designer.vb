<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExportHtmlDialog
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
        Me.ButtonTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.OkDialogButton = New System.Windows.Forms.Button()
        Me.CancelDialogButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PronunciationColCheck = New System.Windows.Forms.CheckBox()
        Me.DefinitionColCheck = New System.Windows.Forms.CheckBox()
        Me.NotesColCheck = New System.Windows.Forms.CheckBox()
        Me.WordColCheck = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PElementCheck = New System.Windows.Forms.CheckBox()
        Me.ButtonTableLayout.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonTableLayout
        '
        Me.ButtonTableLayout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTableLayout.ColumnCount = 2
        Me.ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonTableLayout.Controls.Add(Me.OkDialogButton, 0, 0)
        Me.ButtonTableLayout.Controls.Add(Me.CancelDialogButton, 1, 0)
        Me.ButtonTableLayout.Location = New System.Drawing.Point(462, 485)
        Me.ButtonTableLayout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonTableLayout.Name = "ButtonTableLayout"
        Me.ButtonTableLayout.RowCount = 1
        Me.ButtonTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonTableLayout.Size = New System.Drawing.Size(219, 45)
        Me.ButtonTableLayout.TabIndex = 0
        '
        'OkDialogButton
        '
        Me.OkDialogButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OkDialogButton.BackColor = System.Drawing.Color.Transparent
        Me.OkDialogButton.Location = New System.Drawing.Point(4, 5)
        Me.OkDialogButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OkDialogButton.Name = "OkDialogButton"
        Me.OkDialogButton.Size = New System.Drawing.Size(100, 35)
        Me.OkDialogButton.TabIndex = 0
        Me.OkDialogButton.Text = "OK"
        Me.OkDialogButton.UseVisualStyleBackColor = False
        '
        'CancelDialogButton
        '
        Me.CancelDialogButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CancelDialogButton.BackColor = System.Drawing.Color.Transparent
        Me.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelDialogButton.Location = New System.Drawing.Point(114, 5)
        Me.CancelDialogButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelDialogButton.Name = "CancelDialogButton"
        Me.CancelDialogButton.Size = New System.Drawing.Size(100, 35)
        Me.CancelDialogButton.TabIndex = 1
        Me.CancelDialogButton.Text = "Cancel"
        Me.CancelDialogButton.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PronunciationColCheck)
        Me.GroupBox2.Controls.Add(Me.DefinitionColCheck)
        Me.GroupBox2.Controls.Add(Me.NotesColCheck)
        Me.GroupBox2.Controls.Add(Me.WordColCheck)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 329)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(669, 148)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Columns"
        '
        'PronunciationColCheck
        '
        Me.PronunciationColCheck.AutoSize = True
        Me.PronunciationColCheck.Checked = True
        Me.PronunciationColCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PronunciationColCheck.Location = New System.Drawing.Point(9, 52)
        Me.PronunciationColCheck.Name = "PronunciationColCheck"
        Me.PronunciationColCheck.Size = New System.Drawing.Size(132, 24)
        Me.PronunciationColCheck.TabIndex = 6
        Me.PronunciationColCheck.Text = "Pronunciation"
        Me.PronunciationColCheck.UseVisualStyleBackColor = True
        '
        'DefinitionColCheck
        '
        Me.DefinitionColCheck.AutoSize = True
        Me.DefinitionColCheck.Checked = True
        Me.DefinitionColCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DefinitionColCheck.Location = New System.Drawing.Point(9, 80)
        Me.DefinitionColCheck.Name = "DefinitionColCheck"
        Me.DefinitionColCheck.Size = New System.Drawing.Size(102, 24)
        Me.DefinitionColCheck.TabIndex = 7
        Me.DefinitionColCheck.Text = "Definition"
        Me.DefinitionColCheck.UseVisualStyleBackColor = True
        '
        'NotesColCheck
        '
        Me.NotesColCheck.AutoSize = True
        Me.NotesColCheck.Checked = True
        Me.NotesColCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NotesColCheck.Location = New System.Drawing.Point(9, 108)
        Me.NotesColCheck.Name = "NotesColCheck"
        Me.NotesColCheck.Size = New System.Drawing.Size(77, 24)
        Me.NotesColCheck.TabIndex = 8
        Me.NotesColCheck.Text = "Notes"
        Me.NotesColCheck.UseVisualStyleBackColor = True
        '
        'WordColCheck
        '
        Me.WordColCheck.AutoSize = True
        Me.WordColCheck.Checked = True
        Me.WordColCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WordColCheck.Location = New System.Drawing.Point(9, 25)
        Me.WordColCheck.Name = "WordColCheck"
        Me.WordColCheck.Size = New System.Drawing.Size(73, 24)
        Me.WordColCheck.TabIndex = 5
        Me.WordColCheck.Text = "Word"
        Me.WordColCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(14, 37)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(670, 26)
        Me.TitleTextBox.TabIndex = 2
        Me.TitleTextBox.Text = "Dictionary"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(14, 100)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(670, 189)
        Me.DescriptionTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Description:"
        '
        'PElementCheck
        '
        Me.PElementCheck.AutoSize = True
        Me.PElementCheck.Checked = True
        Me.PElementCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PElementCheck.Location = New System.Drawing.Point(14, 297)
        Me.PElementCheck.Name = "PElementCheck"
        Me.PElementCheck.Size = New System.Drawing.Size(298, 24)
        Me.PElementCheck.TabIndex = 4
        Me.PElementCheck.Text = "Make <p> element with each new line"
        Me.PElementCheck.UseVisualStyleBackColor = True
        '
        'ExportHtmlDialog
        '
        Me.AcceptButton = Me.OkDialogButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelDialogButton
        Me.ClientSize = New System.Drawing.Size(699, 548)
        Me.Controls.Add(Me.PElementCheck)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonTableLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExportHtmlDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export To HTML"
        Me.ButtonTableLayout.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OkDialogButton As System.Windows.Forms.Button
    Friend WithEvents CancelDialogButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PronunciationColCheck As CheckBox
    Friend WithEvents DefinitionColCheck As CheckBox
    Friend WithEvents NotesColCheck As CheckBox
    Friend WithEvents WordColCheck As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PElementCheck As CheckBox
End Class
