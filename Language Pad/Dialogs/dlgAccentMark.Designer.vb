<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAccentMark
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAccentMark))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCharacter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.AccentsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 371)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Character:"
        '
        'txtCharacter
        '
        Me.txtCharacter.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharacter.Location = New System.Drawing.Point(13, 404)
        Me.txtCharacter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCharacter.MaxLength = 100
        Me.txtCharacter.Name = "txtCharacter"
        Me.txtCharacter.Size = New System.Drawing.Size(992, 43)
        Me.txtCharacter.TabIndex = 2
        Me.txtCharacter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 466)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Accent:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(704, 891)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(292, 56)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(140, 50)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Location = New System.Drawing.Point(149, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 50)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Black
        Me.lblResult.Location = New System.Drawing.Point(13, 110)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(992, 253)
        Me.lblResult.TabIndex = 69
        Me.lblResult.Text = "a"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(820, 334)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(185, 29)
        Me.CheckBox1.TabIndex = 72
        Me.CheckBox1.Text = "Smart Replace"
        Me.ttMain.SetToolTip(Me.CheckBox1, "Combine certain combined characters into single characters." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A + ◌́ -> Á")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'AccentsLayoutPanel
        '
        Me.AccentsLayoutPanel.AutoScroll = True
        Me.AccentsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AccentsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.AccentsLayoutPanel.Location = New System.Drawing.Point(13, 499)
        Me.AccentsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AccentsLayoutPanel.Name = "AccentsLayoutPanel"
        Me.AccentsLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.AccentsLayoutPanel.Size = New System.Drawing.Size(992, 382)
        Me.AccentsLayoutPanel.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(13, 13)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(214, 89)
        Me.btnAdd.TabIndex = 70
        Me.btnAdd.Text = "Add Character"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.Location = New System.Drawing.Point(235, 13)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(214, 89)
        Me.btnCopy.TabIndex = 71
        Me.btnCopy.Text = "Copy Character"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'dlgAccentMark
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1018, 970)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.AccentsLayoutPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCharacter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAccentMark"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Accent Mark"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCharacter As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents AccentsLayoutPanel As FlowLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
