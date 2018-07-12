<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgHtml
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbPronunciation = New System.Windows.Forms.CheckBox()
        Me.cbDefinition = New System.Windows.Forms.CheckBox()
        Me.cbNotes = New System.Windows.Forms.CheckBox()
        Me.cbWord = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPElement = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(617, 546)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(292, 56)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.Transparent
        Me.OK_Button.Location = New System.Drawing.Point(6, 6)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(134, 44)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(152, 6)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(134, 44)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbPronunciation)
        Me.GroupBox2.Controls.Add(Me.cbDefinition)
        Me.GroupBox2.Controls.Add(Me.cbNotes)
        Me.GroupBox2.Controls.Add(Me.cbWord)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 333)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(891, 184)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Columns"
        '
        'cbPronunciation
        '
        Me.cbPronunciation.AutoSize = True
        Me.cbPronunciation.Checked = True
        Me.cbPronunciation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPronunciation.Location = New System.Drawing.Point(11, 65)
        Me.cbPronunciation.Name = "cbPronunciation"
        Me.cbPronunciation.Size = New System.Drawing.Size(176, 29)
        Me.cbPronunciation.TabIndex = 6
        Me.cbPronunciation.Text = "Pronunciation"
        Me.cbPronunciation.UseVisualStyleBackColor = True
        '
        'cbDefinition
        '
        Me.cbDefinition.AutoSize = True
        Me.cbDefinition.Checked = True
        Me.cbDefinition.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDefinition.Location = New System.Drawing.Point(11, 100)
        Me.cbDefinition.Name = "cbDefinition"
        Me.cbDefinition.Size = New System.Drawing.Size(134, 29)
        Me.cbDefinition.TabIndex = 7
        Me.cbDefinition.Text = "Definition"
        Me.cbDefinition.UseVisualStyleBackColor = True
        '
        'cbNotes
        '
        Me.cbNotes.AutoSize = True
        Me.cbNotes.Checked = True
        Me.cbNotes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNotes.Location = New System.Drawing.Point(11, 135)
        Me.cbNotes.Name = "cbNotes"
        Me.cbNotes.Size = New System.Drawing.Size(100, 29)
        Me.cbNotes.TabIndex = 8
        Me.cbNotes.Text = "Notes"
        Me.cbNotes.UseVisualStyleBackColor = True
        '
        'cbWord
        '
        Me.cbWord.AutoSize = True
        Me.cbWord.Checked = True
        Me.cbWord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbWord.Location = New System.Drawing.Point(11, 30)
        Me.cbWord.Name = "cbWord"
        Me.cbWord.Size = New System.Drawing.Size(95, 29)
        Me.cbWord.TabIndex = 5
        Me.cbWord.Text = "Word"
        Me.cbWord.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(18, 46)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(891, 31)
        Me.txtTitle.TabIndex = 2
        Me.txtTitle.Text = "Dictionary"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(18, 118)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(891, 170)
        Me.txtDescription.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Description:"
        '
        'cbPElement
        '
        Me.cbPElement.AutoSize = True
        Me.cbPElement.Checked = True
        Me.cbPElement.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPElement.Location = New System.Drawing.Point(18, 296)
        Me.cbPElement.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPElement.Name = "cbPElement"
        Me.cbPElement.Size = New System.Drawing.Size(403, 29)
        Me.cbPElement.TabIndex = 4
        Me.cbPElement.Text = "Make <p> element with each new line"
        Me.cbPElement.UseVisualStyleBackColor = True
        '
        'dlgHtml
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(933, 625)
        Me.Controls.Add(Me.cbPElement)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHtml"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export To HTML"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbPronunciation As CheckBox
    Friend WithEvents cbDefinition As CheckBox
    Friend WithEvents cbNotes As CheckBox
    Friend WithEvents cbWord As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbPElement As CheckBox
End Class
