<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportImageDialog
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
        Me.ButtonTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.OkDialogButton = New System.Windows.Forms.Button()
        Me.CancelDialogButton = New System.Windows.Forms.Button()
        Me.PreviewPictureBox = New System.Windows.Forms.PictureBox()
        Me.WidthLabel = New System.Windows.Forms.Label()
        Me.WidthNud = New System.Windows.Forms.NumericUpDown()
        Me.HeightNud = New System.Windows.Forms.NumericUpDown()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.LockAspectCheckBox = New System.Windows.Forms.CheckBox()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.ButtonTableLayout.SuspendLayout()
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthNud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightNud, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ButtonTableLayout.Location = New System.Drawing.Point(742, 681)
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
        Me.OkDialogButton.Location = New System.Drawing.Point(4, 5)
        Me.OkDialogButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OkDialogButton.Name = "OkDialogButton"
        Me.OkDialogButton.Size = New System.Drawing.Size(100, 35)
        Me.OkDialogButton.TabIndex = 0
        Me.OkDialogButton.Text = "OK"
        '
        'CancelDialogButton
        '
        Me.CancelDialogButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelDialogButton.Location = New System.Drawing.Point(114, 5)
        Me.CancelDialogButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelDialogButton.Name = "CancelDialogButton"
        Me.CancelDialogButton.Size = New System.Drawing.Size(100, 35)
        Me.CancelDialogButton.TabIndex = 1
        Me.CancelDialogButton.Text = "Cancel"
        '
        'PreviewPictureBox
        '
        Me.PreviewPictureBox.BackColor = System.Drawing.Color.Black
        Me.PreviewPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PreviewPictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PreviewPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PreviewPictureBox.Name = "PreviewPictureBox"
        Me.PreviewPictureBox.Size = New System.Drawing.Size(978, 613)
        Me.PreviewPictureBox.TabIndex = 1
        Me.PreviewPictureBox.TabStop = False
        '
        'WidthLabel
        '
        Me.WidthLabel.AutoSize = True
        Me.WidthLabel.Location = New System.Drawing.Point(13, 643)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(54, 20)
        Me.WidthLabel.TabIndex = 2
        Me.WidthLabel.Text = "Width:"
        '
        'WidthNud
        '
        Me.WidthNud.Location = New System.Drawing.Point(73, 641)
        Me.WidthNud.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.WidthNud.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.WidthNud.Name = "WidthNud"
        Me.WidthNud.Size = New System.Drawing.Size(120, 26)
        Me.WidthNud.TabIndex = 2
        Me.WidthNud.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HeightNud
        '
        Me.HeightNud.Location = New System.Drawing.Point(270, 641)
        Me.HeightNud.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.HeightNud.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HeightNud.Name = "HeightNud"
        Me.HeightNud.Size = New System.Drawing.Size(120, 26)
        Me.HeightNud.TabIndex = 3
        Me.HeightNud.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(204, 643)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(60, 20)
        Me.HeightLabel.TabIndex = 4
        Me.HeightLabel.Text = "Height:"
        '
        'LockAspectCheckBox
        '
        Me.LockAspectCheckBox.AutoSize = True
        Me.LockAspectCheckBox.Checked = True
        Me.LockAspectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LockAspectCheckBox.Location = New System.Drawing.Point(406, 642)
        Me.LockAspectCheckBox.Name = "LockAspectCheckBox"
        Me.LockAspectCheckBox.Size = New System.Drawing.Size(165, 24)
        Me.LockAspectCheckBox.TabIndex = 4
        Me.LockAspectCheckBox.Text = "Lock Aspect Ratio"
        Me.LockAspectCheckBox.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.Location = New System.Drawing.Point(865, 636)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(100, 35)
        Me.RefreshButton.TabIndex = 6
        Me.RefreshButton.Text = "Refresh"
        '
        'ImportImageDialog
        '
        Me.AcceptButton = Me.OkDialogButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelDialogButton
        Me.ClientSize = New System.Drawing.Size(978, 744)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.LockAspectCheckBox)
        Me.Controls.Add(Me.HeightNud)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.WidthNud)
        Me.Controls.Add(Me.WidthLabel)
        Me.Controls.Add(Me.PreviewPictureBox)
        Me.Controls.Add(Me.ButtonTableLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImportImageDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Image"
        Me.ButtonTableLayout.ResumeLayout(False)
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthNud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightNud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonTableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OkDialogButton As System.Windows.Forms.Button
    Friend WithEvents CancelDialogButton As System.Windows.Forms.Button
    Friend WithEvents WidthLabel As Label
    Friend WithEvents WidthNud As NumericUpDown
    Friend WithEvents HeightNud As NumericUpDown
    Friend WithEvents HeightLabel As Label
    Friend WithEvents LockAspectCheckBox As CheckBox
    Friend WithEvents PreviewPictureBox As PictureBox
    Friend WithEvents RefreshButton As Button
End Class
