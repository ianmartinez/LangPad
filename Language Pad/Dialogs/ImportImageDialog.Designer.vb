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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PreviewPictureBox = New System.Windows.Forms.PictureBox()
        Me.WidthLabel = New System.Windows.Forms.Label()
        Me.WidthNud = New System.Windows.Forms.NumericUpDown()
        Me.HeightNud = New System.Windows.Forms.NumericUpDown()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.LockAspectCheckBox = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthNud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightNud, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(493, 554)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(114, 5)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'PreviewPictureBox
        '
        Me.PreviewPictureBox.BackColor = System.Drawing.Color.Black
        Me.PreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PreviewPictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PreviewPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PreviewPictureBox.Name = "PreviewPictureBox"
        Me.PreviewPictureBox.Size = New System.Drawing.Size(729, 470)
        Me.PreviewPictureBox.TabIndex = 1
        Me.PreviewPictureBox.TabStop = False
        '
        'WidthLabel
        '
        Me.WidthLabel.AutoSize = True
        Me.WidthLabel.Location = New System.Drawing.Point(13, 502)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(54, 20)
        Me.WidthLabel.TabIndex = 2
        Me.WidthLabel.Text = "Width:"
        '
        'WidthNud
        '
        Me.WidthNud.Location = New System.Drawing.Point(73, 500)
        Me.WidthNud.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.WidthNud.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.WidthNud.Name = "WidthNud"
        Me.WidthNud.Size = New System.Drawing.Size(120, 26)
        Me.WidthNud.TabIndex = 2
        Me.WidthNud.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HeightNud
        '
        Me.HeightNud.Location = New System.Drawing.Point(270, 500)
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
        Me.HeightLabel.Location = New System.Drawing.Point(204, 502)
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
        Me.LockAspectCheckBox.Location = New System.Drawing.Point(542, 501)
        Me.LockAspectCheckBox.Name = "LockAspectCheckBox"
        Me.LockAspectCheckBox.Size = New System.Drawing.Size(165, 24)
        Me.LockAspectCheckBox.TabIndex = 5
        Me.LockAspectCheckBox.Text = "Lock Aspect Ratio"
        Me.LockAspectCheckBox.UseVisualStyleBackColor = True
        '
        'ResizeImageDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(729, 617)
        Me.Controls.Add(Me.LockAspectCheckBox)
        Me.Controls.Add(Me.HeightNud)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.WidthNud)
        Me.Controls.Add(Me.WidthLabel)
        Me.Controls.Add(Me.PreviewPictureBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResizeImageDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Image"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthNud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightNud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents WidthLabel As Label
    Friend WithEvents WidthNud As NumericUpDown
    Friend WithEvents HeightNud As NumericUpDown
    Friend WithEvents HeightLabel As Label
    Friend WithEvents LockAspectCheckBox As CheckBox
    Friend WithEvents PreviewPictureBox As PictureBox
End Class
