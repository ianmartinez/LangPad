<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSettings
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
        Me.cbUpdates = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbHidpi = New System.Windows.Forms.CheckBox()
        Me.cbShowCharacterEditor = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbUpdates
        '
        Me.cbUpdates.AutoSize = True
        Me.cbUpdates.Checked = True
        Me.cbUpdates.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUpdates.Location = New System.Drawing.Point(46, 46)
        Me.cbUpdates.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbUpdates.Name = "cbUpdates"
        Me.cbUpdates.Size = New System.Drawing.Size(241, 24)
        Me.cbUpdates.TabIndex = 8
        Me.cbUpdates.Text = "Check for updates on startup"
        Me.cbUpdates.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(135, 190)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 45)
        Me.TableLayoutPanel1.TabIndex = 75
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(103, 39)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Location = New System.Drawing.Point(112, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 39)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cbHidpi
        '
        Me.cbHidpi.AutoSize = True
        Me.cbHidpi.Location = New System.Drawing.Point(46, 114)
        Me.cbHidpi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbHidpi.Name = "cbHidpi"
        Me.cbHidpi.Size = New System.Drawing.Size(200, 24)
        Me.cbHidpi.TabIndex = 76
        Me.cbHidpi.Text = "Use large icons (HiDPI)"
        Me.cbHidpi.UseVisualStyleBackColor = True
        '
        'cbShowCharacterEditor
        '
        Me.cbShowCharacterEditor.AutoSize = True
        Me.cbShowCharacterEditor.Checked = True
        Me.cbShowCharacterEditor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowCharacterEditor.Location = New System.Drawing.Point(46, 80)
        Me.cbShowCharacterEditor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbShowCharacterEditor.Name = "cbShowCharacterEditor"
        Me.cbShowCharacterEditor.Size = New System.Drawing.Size(266, 24)
        Me.cbShowCharacterEditor.TabIndex = 77
        Me.cbShowCharacterEditor.Text = "Show character editor on startup"
        Me.cbShowCharacterEditor.UseVisualStyleBackColor = True
        '
        'dlgSettings
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(365, 247)
        Me.Controls.Add(Me.cbShowCharacterEditor)
        Me.Controls.Add(Me.cbHidpi)
        Me.Controls.Add(Me.cbUpdates)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbUpdates As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cbHidpi As CheckBox
    Friend WithEvents cbShowCharacterEditor As CheckBox
End Class
