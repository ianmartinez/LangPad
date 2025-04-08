<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsDialog
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
        Me.UpdatesOnStartupCheck = New System.Windows.Forms.CheckBox()
        Me.ButtonTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.OkDialogButton = New System.Windows.Forms.Button()
        Me.CancelDialogButton = New System.Windows.Forms.Button()
        Me.LargeIconsCheck = New System.Windows.Forms.CheckBox()
        Me.ShowCharEditCheck = New System.Windows.Forms.CheckBox()
        Me.ButtonTableLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdatesOnStartupCheck
        '
        Me.UpdatesOnStartupCheck.AutoSize = True
        Me.UpdatesOnStartupCheck.Checked = True
        Me.UpdatesOnStartupCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UpdatesOnStartupCheck.Location = New System.Drawing.Point(46, 46)
        Me.UpdatesOnStartupCheck.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UpdatesOnStartupCheck.Name = "UpdatesOnStartupCheck"
        Me.UpdatesOnStartupCheck.Size = New System.Drawing.Size(241, 24)
        Me.UpdatesOnStartupCheck.TabIndex = 8
        Me.UpdatesOnStartupCheck.Text = "Check for updates on startup"
        Me.UpdatesOnStartupCheck.UseVisualStyleBackColor = True
        '
        'ButtonTableLayout
        '
        Me.ButtonTableLayout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTableLayout.ColumnCount = 2
        Me.ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonTableLayout.Controls.Add(Me.OkDialogButton, 0, 0)
        Me.ButtonTableLayout.Controls.Add(Me.CancelDialogButton, 1, 0)
        Me.ButtonTableLayout.Location = New System.Drawing.Point(135, 190)
        Me.ButtonTableLayout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonTableLayout.Name = "ButtonTableLayout"
        Me.ButtonTableLayout.RowCount = 1
        Me.ButtonTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.ButtonTableLayout.Size = New System.Drawing.Size(219, 45)
        Me.ButtonTableLayout.TabIndex = 75
        '
        'OkDialogButton
        '
        Me.OkDialogButton.BackColor = System.Drawing.Color.Transparent
        Me.OkDialogButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OkDialogButton.Location = New System.Drawing.Point(3, 3)
        Me.OkDialogButton.Name = "OkDialogButton"
        Me.OkDialogButton.Size = New System.Drawing.Size(103, 39)
        Me.OkDialogButton.TabIndex = 1
        Me.OkDialogButton.Text = "OK"
        Me.OkDialogButton.UseVisualStyleBackColor = False
        '
        'CancelDialogButton
        '
        Me.CancelDialogButton.BackColor = System.Drawing.Color.Transparent
        Me.CancelDialogButton.DialogResult = DialogResult.Cancel
        Me.CancelDialogButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelDialogButton.Location = New System.Drawing.Point(112, 3)
        Me.CancelDialogButton.Name = "CancelDialogButton"
        Me.CancelDialogButton.Size = New System.Drawing.Size(104, 39)
        Me.CancelDialogButton.TabIndex = 0
        Me.CancelDialogButton.Text = "Cancel"
        Me.CancelDialogButton.UseVisualStyleBackColor = False
        '
        'LargeIconsCheck
        '
        Me.LargeIconsCheck.AutoSize = True
        Me.LargeIconsCheck.Location = New System.Drawing.Point(46, 114)
        Me.LargeIconsCheck.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LargeIconsCheck.Name = "LargeIconsCheck"
        Me.LargeIconsCheck.Size = New System.Drawing.Size(200, 24)
        Me.LargeIconsCheck.TabIndex = 76
        Me.LargeIconsCheck.Text = "Use large icons (HiDPI)"
        Me.LargeIconsCheck.UseVisualStyleBackColor = True
        '
        'ShowCharEditCheck
        '
        Me.ShowCharEditCheck.AutoSize = True
        Me.ShowCharEditCheck.Checked = True
        Me.ShowCharEditCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowCharEditCheck.Location = New System.Drawing.Point(46, 80)
        Me.ShowCharEditCheck.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ShowCharEditCheck.Name = "ShowCharEditCheck"
        Me.ShowCharEditCheck.Size = New System.Drawing.Size(266, 24)
        Me.ShowCharEditCheck.TabIndex = 77
        Me.ShowCharEditCheck.Text = "Show character editor on startup"
        Me.ShowCharEditCheck.UseVisualStyleBackColor = True
        '
        'SettingsDialog
        '
        Me.AcceptButton = Me.OkDialogButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelDialogButton
        Me.ClientSize = New System.Drawing.Size(365, 247)
        Me.Controls.Add(Me.ShowCharEditCheck)
        Me.Controls.Add(Me.LargeIconsCheck)
        Me.Controls.Add(Me.UpdatesOnStartupCheck)
        Me.Controls.Add(Me.ButtonTableLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ButtonTableLayout.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdatesOnStartupCheck As CheckBox
    Friend WithEvents ButtonTableLayout As TableLayoutPanel
    Friend WithEvents OkDialogButton As Button
    Friend WithEvents CancelDialogButton As Button
    Friend WithEvents LargeIconsCheck As CheckBox
    Friend WithEvents ShowCharEditCheck As CheckBox
End Class
