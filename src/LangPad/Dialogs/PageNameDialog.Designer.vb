<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageNameDialog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.OkDialogButton = New System.Windows.Forms.Button()
        Me.CancelDialogButton = New System.Windows.Forms.Button()
        Me.ButtonTableLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.Label1.Size = New System.Drawing.Size(55, 26)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.NameTextBox.Location = New System.Drawing.Point(9, 31)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(282, 26)
        Me.NameTextBox.TabIndex = 0
        '
        'ButtonTableLayout
        '
        Me.ButtonTableLayout.AutoSize = True
        Me.ButtonTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonTableLayout.ColumnCount = 2
        Me.ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonTableLayout.Controls.Add(Me.OkDialogButton, 0, 0)
        Me.ButtonTableLayout.Controls.Add(Me.CancelDialogButton, 1, 0)
        Me.ButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonTableLayout.Location = New System.Drawing.Point(9, 82)
        Me.ButtonTableLayout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonTableLayout.Name = "ButtonTableLayout"
        Me.ButtonTableLayout.Padding = New System.Windows.Forms.Padding(0, 9, 0, 5)
        Me.ButtonTableLayout.RowCount = 1
        Me.ButtonTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonTableLayout.Size = New System.Drawing.Size(282, 56)
        Me.ButtonTableLayout.TabIndex = 74
        '
        'OkDialogButton
        '
        Me.OkDialogButton.AutoSize = True
        Me.OkDialogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OkDialogButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OkDialogButton.Location = New System.Drawing.Point(3, 12)
        Me.OkDialogButton.Name = "OkDialogButton"
        Me.OkDialogButton.Padding = New System.Windows.Forms.Padding(3)
        Me.OkDialogButton.Size = New System.Drawing.Size(135, 36)
        Me.OkDialogButton.TabIndex = 1
        Me.OkDialogButton.Text = "OK"
        Me.OkDialogButton.UseVisualStyleBackColor = True
        '
        'CancelDialogButton
        '
        Me.CancelDialogButton.AutoSize = True
        Me.CancelDialogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelDialogButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelDialogButton.Location = New System.Drawing.Point(144, 12)
        Me.CancelDialogButton.Name = "CancelDialogButton"
        Me.CancelDialogButton.Padding = New System.Windows.Forms.Padding(3)
        Me.CancelDialogButton.Size = New System.Drawing.Size(135, 36)
        Me.CancelDialogButton.TabIndex = 0
        Me.CancelDialogButton.Text = "Cancel"
        Me.CancelDialogButton.UseVisualStyleBackColor = True
        '
        'PageNameDialog
        '
        Me.AcceptButton = Me.OkDialogButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 143)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.ButtonTableLayout)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PageNameDialog"
        Me.Padding = New System.Windows.Forms.Padding(9, 5, 9, 5)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ButtonTableLayout.ResumeLayout(False)
        Me.ButtonTableLayout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonTableLayout As TableLayoutPanel
    Friend WithEvents OkDialogButton As Button
    Friend WithEvents CancelDialogButton As Button
End Class
