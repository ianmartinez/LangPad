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
        Me.ZoomNud.Location = New System.Drawing.Point(8, 26)
        Me.ZoomNud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ZoomNud.Maximum = New Decimal(New Integer() {64, 0, 0, 0})
        Me.ZoomNud.Minimum = New Decimal(New Integer() {15626, 0, 0, 393216})
        Me.ZoomNud.Name = "ZoomNud"
        Me.ZoomNud.Size = New System.Drawing.Size(338, 22)
        Me.ZoomNud.TabIndex = 6
        Me.ZoomNud.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(8, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Label2.Size = New System.Drawing.Size(92, 22)
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
        Me.ButtonTableLayout.Location = New System.Drawing.Point(8, 66)
        Me.ButtonTableLayout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonTableLayout.Name = "ButtonTableLayout"
        Me.ButtonTableLayout.Padding = New System.Windows.Forms.Padding(0, 7, 0, 4)
        Me.ButtonTableLayout.RowCount = 1
        Me.ButtonTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ButtonTableLayout.Size = New System.Drawing.Size(338, 46)
        Me.ButtonTableLayout.TabIndex = 76
        '
        'OkDialogButton
        '
        Me.OkDialogButton.AutoSize = True
        Me.OkDialogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OkDialogButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OkDialogButton.Location = New System.Drawing.Point(3, 9)
        Me.OkDialogButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OkDialogButton.Name = "OkDialogButton"
        Me.OkDialogButton.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OkDialogButton.Size = New System.Drawing.Size(163, 31)
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
        Me.CancelDialogButton.Location = New System.Drawing.Point(172, 9)
        Me.CancelDialogButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CancelDialogButton.Name = "CancelDialogButton"
        Me.CancelDialogButton.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CancelDialogButton.Size = New System.Drawing.Size(163, 31)
        Me.CancelDialogButton.TabIndex = 0
        Me.CancelDialogButton.Text = "Cancel"
        Me.CancelDialogButton.UseVisualStyleBackColor = True
        '
        'CustomZoomDialog
        '
        Me.AcceptButton = Me.OkDialogButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 116)
        Me.Controls.Add(Me.ZoomNud)
        Me.Controls.Add(Me.ButtonTableLayout)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomZoomDialog"
        Me.Padding = New System.Windows.Forms.Padding(8, 4, 8, 4)
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
