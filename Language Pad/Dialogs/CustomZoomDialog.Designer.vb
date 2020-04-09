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
        Me.ZoomNud = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.OkDialogButton = New System.Windows.Forms.Button()
        Me.CancelDialogButton = New System.Windows.Forms.Button()
        CType(Me.ZoomNud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonTableLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'ZoomNud
        '
        Me.ZoomNud.DecimalPlaces = 3
        Me.ZoomNud.Dock = System.Windows.Forms.DockStyle.Top
        Me.ZoomNud.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ZoomNud.Location = New System.Drawing.Point(9, 31)
        Me.ZoomNud.Maximum = New Decimal(New Integer() {64, 0, 0, 0})
        Me.ZoomNud.Minimum = New Decimal(New Integer() {15626, 0, 0, 393216})
        Me.ZoomNud.Name = "ZoomNud"
        Me.ZoomNud.Size = New System.Drawing.Size(380, 26)
        Me.ZoomNud.TabIndex = 6
        Me.ZoomNud.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(9, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.Label2.Size = New System.Drawing.Size(104, 26)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Zoom Factor:"
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
        Me.ButtonTableLayout.Location = New System.Drawing.Point(9, 84)
        Me.ButtonTableLayout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonTableLayout.Name = "ButtonTableLayout"
        Me.ButtonTableLayout.Padding = New System.Windows.Forms.Padding(0, 9, 0, 5)
        Me.ButtonTableLayout.RowCount = 1
        Me.ButtonTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ButtonTableLayout.Size = New System.Drawing.Size(380, 56)
        Me.ButtonTableLayout.TabIndex = 76
        '
        'OkDialogButton
        '
        Me.OkDialogButton.AutoSize = True
        Me.OkDialogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OkDialogButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OkDialogButton.Location = New System.Drawing.Point(3, 12)
        Me.OkDialogButton.Name = "OkDialogButton"
        Me.OkDialogButton.Padding = New System.Windows.Forms.Padding(3)
        Me.OkDialogButton.Size = New System.Drawing.Size(184, 36)
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
        Me.CancelDialogButton.Location = New System.Drawing.Point(193, 12)
        Me.CancelDialogButton.Name = "CancelDialogButton"
        Me.CancelDialogButton.Padding = New System.Windows.Forms.Padding(3)
        Me.CancelDialogButton.Size = New System.Drawing.Size(184, 36)
        Me.CancelDialogButton.TabIndex = 0
        Me.CancelDialogButton.Text = "Cancel"
        Me.CancelDialogButton.UseVisualStyleBackColor = True
        '
        'CustomZoomDialog
        '
        Me.AcceptButton = Me.OkDialogButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 145)
        Me.Controls.Add(Me.ZoomNud)
        Me.Controls.Add(Me.ButtonTableLayout)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomZoomDialog"
        Me.Padding = New System.Windows.Forms.Padding(9, 5, 9, 5)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Custom Zoom"
        CType(Me.ZoomNud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonTableLayout.ResumeLayout(False)
        Me.ButtonTableLayout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZoomNud As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonTableLayout As TableLayoutPanel
    Friend WithEvents OkDialogButton As Button
    Friend WithEvents CancelDialogButton As Button
End Class
