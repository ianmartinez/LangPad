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
        ButtonTableLayout = New TableLayoutPanel()
        OkDialogButton = New Button()
        CancelDialogButton = New Button()
        PreviewPictureBox = New PictureBox()
        WidthLabel = New Label()
        WidthNud = New NumericUpDown()
        HeightNud = New NumericUpDown()
        HeightLabel = New Label()
        LockAspectCheckBox = New CheckBox()
        RefreshPreviewButton = New Button()
        ResetSizeButton = New Button()
        ButtonTableLayout.SuspendLayout()
        CType(PreviewPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(WidthNud, ComponentModel.ISupportInitialize).BeginInit()
        CType(HeightNud, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonTableLayout
        ' 
        ButtonTableLayout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonTableLayout.ColumnCount = 2
        ButtonTableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        ButtonTableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        ButtonTableLayout.Controls.Add(OkDialogButton, 0, 0)
        ButtonTableLayout.Controls.Add(CancelDialogButton, 1, 0)
        ButtonTableLayout.Location = New Point(824, 869)
        ButtonTableLayout.Margin = New Padding(4, 6, 4, 6)
        ButtonTableLayout.Name = "ButtonTableLayout"
        ButtonTableLayout.RowCount = 1
        ButtonTableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        ButtonTableLayout.Size = New Size(243, 56)
        ButtonTableLayout.TabIndex = 0
        ' 
        ' OkDialogButton
        ' 
        OkDialogButton.Anchor = AnchorStyles.None
        OkDialogButton.Location = New Point(5, 6)
        OkDialogButton.Margin = New Padding(4, 6, 4, 6)
        OkDialogButton.Name = "OkDialogButton"
        OkDialogButton.Size = New Size(111, 44)
        OkDialogButton.TabIndex = 0
        OkDialogButton.Text = "OK"
        ' 
        ' CancelDialogButton
        ' 
        CancelDialogButton.Anchor = AnchorStyles.None
        CancelDialogButton.DialogResult = DialogResult.Cancel
        CancelDialogButton.Location = New Point(126, 6)
        CancelDialogButton.Margin = New Padding(4, 6, 4, 6)
        CancelDialogButton.Name = "CancelDialogButton"
        CancelDialogButton.Size = New Size(111, 44)
        CancelDialogButton.TabIndex = 1
        CancelDialogButton.Text = "Cancel"
        ' 
        ' PreviewPictureBox
        ' 
        PreviewPictureBox.BackColor = Color.Black
        PreviewPictureBox.BackgroundImageLayout = ImageLayout.Zoom
        PreviewPictureBox.BorderStyle = BorderStyle.FixedSingle
        PreviewPictureBox.Dock = DockStyle.Top
        PreviewPictureBox.Location = New Point(0, 0)
        PreviewPictureBox.Margin = New Padding(3, 4, 3, 4)
        PreviewPictureBox.Name = "PreviewPictureBox"
        PreviewPictureBox.Size = New Size(1087, 766)
        PreviewPictureBox.TabIndex = 1
        PreviewPictureBox.TabStop = False
        ' 
        ' WidthLabel
        ' 
        WidthLabel.AutoSize = True
        WidthLabel.Location = New Point(14, 804)
        WidthLabel.Name = "WidthLabel"
        WidthLabel.Size = New Size(64, 25)
        WidthLabel.TabIndex = 2
        WidthLabel.Text = "Width:"
        ' 
        ' WidthNud
        ' 
        WidthNud.Location = New Point(81, 801)
        WidthNud.Margin = New Padding(3, 4, 3, 4)
        WidthNud.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        WidthNud.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        WidthNud.Name = "WidthNud"
        WidthNud.Size = New Size(133, 31)
        WidthNud.TabIndex = 2
        WidthNud.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' HeightNud
        ' 
        HeightNud.Location = New Point(300, 801)
        HeightNud.Margin = New Padding(3, 4, 3, 4)
        HeightNud.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        HeightNud.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        HeightNud.Name = "HeightNud"
        HeightNud.Size = New Size(133, 31)
        HeightNud.TabIndex = 3
        HeightNud.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' HeightLabel
        ' 
        HeightLabel.AutoSize = True
        HeightLabel.Location = New Point(227, 804)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New Size(69, 25)
        HeightLabel.TabIndex = 4
        HeightLabel.Text = "Height:"
        ' 
        ' LockAspectCheckBox
        ' 
        LockAspectCheckBox.AutoSize = True
        LockAspectCheckBox.Checked = True
        LockAspectCheckBox.CheckState = CheckState.Checked
        LockAspectCheckBox.Location = New Point(451, 802)
        LockAspectCheckBox.Margin = New Padding(3, 4, 3, 4)
        LockAspectCheckBox.Name = "LockAspectCheckBox"
        LockAspectCheckBox.Size = New Size(179, 29)
        LockAspectCheckBox.TabIndex = 4
        LockAspectCheckBox.Text = "Lock Aspect Ratio"
        LockAspectCheckBox.UseVisualStyleBackColor = True
        ' 
        ' RefreshPreviewButton
        ' 
        RefreshPreviewButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RefreshPreviewButton.Location = New Point(907, 795)
        RefreshPreviewButton.Margin = New Padding(4, 6, 4, 6)
        RefreshPreviewButton.Name = "RefreshPreviewButton"
        RefreshPreviewButton.Size = New Size(156, 44)
        RefreshPreviewButton.TabIndex = 6
        RefreshPreviewButton.Text = "Refresh Preview"
        ' 
        ' ResetSizeButton
        ' 
        ResetSizeButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ResetSizeButton.Location = New Point(742, 795)
        ResetSizeButton.Margin = New Padding(4, 6, 4, 6)
        ResetSizeButton.Name = "ResetSizeButton"
        ResetSizeButton.Size = New Size(156, 44)
        ResetSizeButton.TabIndex = 5
        ResetSizeButton.Text = "Reset Size"
        ' 
        ' ImportImageDialog
        ' 
        AcceptButton = OkDialogButton
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = CancelDialogButton
        ClientSize = New Size(1087, 948)
        Controls.Add(ResetSizeButton)
        Controls.Add(RefreshPreviewButton)
        Controls.Add(LockAspectCheckBox)
        Controls.Add(HeightNud)
        Controls.Add(HeightLabel)
        Controls.Add(WidthNud)
        Controls.Add(WidthLabel)
        Controls.Add(PreviewPictureBox)
        Controls.Add(ButtonTableLayout)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 6, 4, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ImportImageDialog"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Import Image"
        ButtonTableLayout.ResumeLayout(False)
        CType(PreviewPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(WidthNud, ComponentModel.ISupportInitialize).EndInit()
        CType(HeightNud, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

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
    Friend WithEvents RefreshPreviewButton As Button
    Friend WithEvents ResetSizeButton As Button
End Class
