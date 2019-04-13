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
        Me.cbSmartReplace = New System.Windows.Forms.CheckBox()
        Me.pnlSmartReplace = New TundraLib.DoubleBufferedPanel()
        Me.AccentsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnPreviewFont = New System.Windows.Forms.Button()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.StylizedPanel1 = New TundraLib.DoubleBufferedPanel()
        Me.TableLayoutPanel1.SuspendLayout
        Me.StylizedPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 205)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Character:"
        '
        'txtCharacter
        '
        Me.txtCharacter.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharacter.Location = New System.Drawing.Point(6, 222)
        Me.txtCharacter.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCharacter.MaxLength = 100
        Me.txtCharacter.Name = "txtCharacter"
        Me.txtCharacter.Size = New System.Drawing.Size(498, 25)
        Me.txtCharacter.TabIndex = 2
        Me.txtCharacter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 251)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(352, 480)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.Location = New System.Drawing.Point(2, 2)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(69, 25)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Location = New System.Drawing.Point(75, 2)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(69, 25)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.White
        Me.lblResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResult.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Black
        Me.lblResult.Location = New System.Drawing.Point(1, 1)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(492, 128)
        Me.lblResult.TabIndex = 69
        Me.lblResult.Text = "a"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbSmartReplace
        '
        Me.cbSmartReplace.AutoSize = True
        Me.cbSmartReplace.Checked = True
        Me.cbSmartReplace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSmartReplace.Location = New System.Drawing.Point(410, 37)
        Me.cbSmartReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.cbSmartReplace.Name = "cbSmartReplace"
        Me.cbSmartReplace.Size = New System.Drawing.Size(96, 17)
        Me.cbSmartReplace.TabIndex = 72
        Me.cbSmartReplace.Text = "Smart Replace"
        Me.ttMain.SetToolTip(Me.cbSmartReplace, "Combine certain Unicode combined characters into single characters." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A + ◌́ -> Á")
        Me.cbSmartReplace.UseVisualStyleBackColor = True
        '
        'pnlSmartReplace
        '
        Me.pnlSmartReplace.BackColor = System.Drawing.Color.LimeGreen
        Me.pnlSmartReplace.Location = New System.Drawing.Point(392, 37)
        Me.pnlSmartReplace.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSmartReplace.Name = "pnlSmartReplace"
        Me.pnlSmartReplace.Size = New System.Drawing.Size(14, 15)
        Me.pnlSmartReplace.TabIndex = 85
        Me.ttMain.SetToolTip(Me.pnlSmartReplace, "Replacement Found")
        Me.pnlSmartReplace.Visible = False
        '
        'AccentsLayoutPanel
        '
        Me.AccentsLayoutPanel.AutoScroll = True
        Me.AccentsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AccentsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.AccentsLayoutPanel.Location = New System.Drawing.Point(6, 268)
        Me.AccentsLayoutPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.AccentsLayoutPanel.Name = "AccentsLayoutPanel"
        Me.AccentsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.AccentsLayoutPanel.Size = New System.Drawing.Size(496, 199)
        Me.AccentsLayoutPanel.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(6, 7)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 58)
        Me.btnAdd.TabIndex = 70
        Me.btnAdd.Text = "Add Character"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.Location = New System.Drawing.Point(118, 7)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(107, 58)
        Me.btnCopy.TabIndex = 71
        Me.btnCopy.Text = "Copy Character"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnPreviewFont
        '
        Me.btnPreviewFont.Image = CType(resources.GetObject("btnPreviewFont.Image"), System.Drawing.Image)
        Me.btnPreviewFont.Location = New System.Drawing.Point(228, 7)
        Me.btnPreviewFont.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPreviewFont.Name = "btnPreviewFont"
        Me.btnPreviewFont.Size = New System.Drawing.Size(131, 58)
        Me.btnPreviewFont.TabIndex = 73
        Me.btnPreviewFont.Text = "Change Preview Font"
        Me.btnPreviewFont.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPreviewFont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPreviewFont.UseVisualStyleBackColor = True
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StylizedPanel1.Controls.Add(Me.lblResult)
        Me.StylizedPanel1.Location = New System.Drawing.Point(6, 69)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel1.Size = New System.Drawing.Size(496, 132)
        Me.StylizedPanel1.TabIndex = 84
        '
        'dlgAccentMark
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(509, 521)
        Me.Controls.Add(Me.pnlSmartReplace)
        Me.Controls.Add(Me.StylizedPanel1)
        Me.Controls.Add(Me.btnPreviewFont)
        Me.Controls.Add(Me.cbSmartReplace)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.AccentsLayoutPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCharacter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAccentMark"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Accent Mark"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.StylizedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

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
    Friend WithEvents cbSmartReplace As CheckBox
    Friend WithEvents btnPreviewFont As Button
    Friend WithEvents dlgFont As FontDialog
    Friend WithEvents StylizedPanel1 As TundraLib.DoubleBufferedPanel
    Friend WithEvents pnlSmartReplace As TundraLib.DoubleBufferedPanel
End Class
