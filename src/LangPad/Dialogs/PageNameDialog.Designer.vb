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
        Label1 = New Label()
        NameTextBox = New TextBox()
        ButtonTableLayout = New TableLayoutPanel()
        OkDialogButton = New Button()
        CancelDialogButton = New Button()
        ButtonTableLayout.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Location = New Point(10, 6)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(0, 0, 0, 8)
        Label1.Size = New Size(63, 33)
        Label1.TabIndex = 73
        Label1.Text = "Name:"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Dock = DockStyle.Top
        NameTextBox.Location = New Point(10, 39)
        NameTextBox.Margin = New Padding(4, 3, 4, 3)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(314, 31)
        NameTextBox.TabIndex = 0
        ' 
        ' ButtonTableLayout
        ' 
        ButtonTableLayout.AutoSize = True
        ButtonTableLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ButtonTableLayout.ColumnCount = 2
        ButtonTableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        ButtonTableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        ButtonTableLayout.Controls.Add(OkDialogButton, 0, 0)
        ButtonTableLayout.Controls.Add(CancelDialogButton, 1, 0)
        ButtonTableLayout.Dock = DockStyle.Bottom
        ButtonTableLayout.Location = New Point(10, 108)
        ButtonTableLayout.Margin = New Padding(5, 6, 5, 6)
        ButtonTableLayout.Name = "ButtonTableLayout"
        ButtonTableLayout.Padding = New Padding(0, 11, 0, 6)
        ButtonTableLayout.RowCount = 1
        ButtonTableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        ButtonTableLayout.Size = New Size(314, 64)
        ButtonTableLayout.TabIndex = 74
        ' 
        ' OkDialogButton
        ' 
        OkDialogButton.AutoSize = True
        OkDialogButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        OkDialogButton.Dock = DockStyle.Fill
        OkDialogButton.Location = New Point(4, 14)
        OkDialogButton.Margin = New Padding(4, 3, 4, 3)
        OkDialogButton.Name = "OkDialogButton"
        OkDialogButton.Padding = New Padding(4, 3, 4, 3)
        OkDialogButton.Size = New Size(149, 41)
        OkDialogButton.TabIndex = 1
        OkDialogButton.Text = "OK"
        OkDialogButton.UseVisualStyleBackColor = True
        ' 
        ' CancelDialogButton
        ' 
        CancelDialogButton.AutoSize = True
        CancelDialogButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        CancelDialogButton.DialogResult = DialogResult.Cancel
        CancelDialogButton.Dock = DockStyle.Fill
        CancelDialogButton.Location = New Point(161, 14)
        CancelDialogButton.Margin = New Padding(4, 3, 4, 3)
        CancelDialogButton.Name = "CancelDialogButton"
        CancelDialogButton.Padding = New Padding(4, 3, 4, 3)
        CancelDialogButton.Size = New Size(149, 41)
        CancelDialogButton.TabIndex = 0
        CancelDialogButton.Text = "Cancel"
        CancelDialogButton.UseVisualStyleBackColor = True
        ' 
        ' PageNameDialog
        ' 
        AcceptButton = OkDialogButton
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = CancelDialogButton
        ClientSize = New Size(334, 178)
        Controls.Add(NameTextBox)
        Controls.Add(ButtonTableLayout)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PageNameDialog"
        Padding = New Padding(10, 6, 10, 6)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        ButtonTableLayout.ResumeLayout(False)
        ButtonTableLayout.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonTableLayout As TableLayoutPanel
    Friend WithEvents OkDialogButton As Button
    Friend WithEvents CancelDialogButton As Button
End Class
