<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomZoomDialog
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
        ZoomNud = New NumericUpDown()
        Label2 = New Label()
        ButtonTableLayout = New TableLayoutPanel()
        OkDialogButton = New Button()
        CancelDialogButton = New Button()
        CType(ZoomNud, ComponentModel.ISupportInitialize).BeginInit()
        ButtonTableLayout.SuspendLayout()
        SuspendLayout()
        ' 
        ' ZoomNud
        ' 
        ZoomNud.DecimalPlaces = 3
        ZoomNud.Dock = DockStyle.Top
        ZoomNud.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        ZoomNud.Location = New Point(10, 39)
        ZoomNud.Margin = New Padding(4, 2, 4, 2)
        ZoomNud.Maximum = New Decimal(New Integer() {64, 0, 0, 0})
        ZoomNud.Minimum = New Decimal(New Integer() {15626, 0, 0, 393216})
        ZoomNud.Name = "ZoomNud"
        ZoomNud.Size = New Size(422, 31)
        ZoomNud.TabIndex = 6
        ZoomNud.Value = New Decimal(New Integer() {64, 0, 0, 0})
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.Location = New Point(10, 6)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 0, 0, 8)
        Label2.Size = New Size(117, 33)
        Label2.TabIndex = 75
        Label2.Text = "Zoom Factor:"
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
        ButtonTableLayout.Location = New Point(10, 115)
        ButtonTableLayout.Margin = New Padding(5, 6, 5, 6)
        ButtonTableLayout.Name = "ButtonTableLayout"
        ButtonTableLayout.Padding = New Padding(0, 11, 0, 6)
        ButtonTableLayout.RowCount = 1
        ButtonTableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        ButtonTableLayout.Size = New Size(422, 60)
        ButtonTableLayout.TabIndex = 76
        ' 
        ' OkDialogButton
        ' 
        OkDialogButton.AutoSize = True
        OkDialogButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        OkDialogButton.Dock = DockStyle.Fill
        OkDialogButton.Location = New Point(4, 13)
        OkDialogButton.Margin = New Padding(4, 2, 4, 2)
        OkDialogButton.Name = "OkDialogButton"
        OkDialogButton.Padding = New Padding(4, 2, 4, 2)
        OkDialogButton.Size = New Size(203, 39)
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
        CancelDialogButton.Location = New Point(215, 13)
        CancelDialogButton.Margin = New Padding(4, 2, 4, 2)
        CancelDialogButton.Name = "CancelDialogButton"
        CancelDialogButton.Padding = New Padding(4, 2, 4, 2)
        CancelDialogButton.Size = New Size(203, 39)
        CancelDialogButton.TabIndex = 0
        CancelDialogButton.Text = "Cancel"
        CancelDialogButton.UseVisualStyleBackColor = True
        ' 
        ' CustomZoomDialog
        ' 
        AcceptButton = OkDialogButton
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(442, 181)
        Controls.Add(ZoomNud)
        Controls.Add(ButtonTableLayout)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "CustomZoomDialog"
        Padding = New Padding(10, 6, 10, 6)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Custom Zoom"
        CType(ZoomNud, ComponentModel.ISupportInitialize).EndInit()
        ButtonTableLayout.ResumeLayout(False)
        ButtonTableLayout.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ZoomNud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonTableLayout As TableLayoutPanel
    Friend WithEvents OkDialogButton As Button
    Friend WithEvents CancelDialogButton As Button
End Class
