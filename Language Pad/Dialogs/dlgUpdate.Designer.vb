<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgUpdate))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDecription = New System.Windows.Forms.TextBox()
        Me.btnReddit = New Tundra.StylizedButton()
        Me.btnSource = New Tundra.StylizedButton()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.lblLanguagePad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 164)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(911, 54)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "The update ""Language Pad {0}"" is available."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDecription
        '
        Me.txtDecription.BackColor = System.Drawing.SystemColors.Window
        Me.txtDecription.Location = New System.Drawing.Point(13, 275)
        Me.txtDecription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDecription.Multiline = True
        Me.txtDecription.Name = "txtDecription"
        Me.txtDecription.ReadOnly = True
        Me.txtDecription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDecription.Size = New System.Drawing.Size(885, 615)
        Me.txtDecription.TabIndex = 75
        '
        'btnReddit
        '
        Me.btnReddit.BackColor = System.Drawing.Color.Transparent
        Me.btnReddit.BackgroundImage = CType(resources.GetObject("btnReddit.BackgroundImage"), System.Drawing.Image)
        Me.btnReddit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReddit.FlatAppearance.BorderSize = 0
        Me.btnReddit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnReddit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReddit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReddit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReddit.ForeColor = System.Drawing.Color.Black
        Me.btnReddit.Image = CType(resources.GetObject("btnReddit.Image"), System.Drawing.Image)
        Me.btnReddit.Location = New System.Drawing.Point(13, 13)
        Me.btnReddit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReddit.Name = "btnReddit"
        Me.btnReddit.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnReddit.Size = New System.Drawing.Size(68, 68)
        Me.btnReddit.Style = resources.GetString("btnReddit.Style")
        Me.btnReddit.TabIndex = 76
        Me.ttMain.SetToolTip(Me.btnReddit, "Reddit")
        Me.btnReddit.UseCompatibleTextRendering = True
        Me.btnReddit.UseVisualStyleBackColor = False
        '
        'btnSource
        '
        Me.btnSource.BackColor = System.Drawing.Color.Transparent
        Me.btnSource.BackgroundImage = CType(resources.GetObject("btnSource.BackgroundImage"), System.Drawing.Image)
        Me.btnSource.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSource.FlatAppearance.BorderSize = 0
        Me.btnSource.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSource.ForeColor = System.Drawing.Color.Black
        Me.btnSource.Image = CType(resources.GetObject("btnSource.Image"), System.Drawing.Image)
        Me.btnSource.Location = New System.Drawing.Point(13, 88)
        Me.btnSource.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnSource.Size = New System.Drawing.Size(68, 68)
        Me.btnSource.Style = resources.GetString("btnSource.Style")
        Me.btnSource.TabIndex = 77
        Me.ttMain.SetToolTip(Me.btnSource, "Source")
        Me.btnSource.UseCompatibleTextRendering = True
        Me.btnSource.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(441, 910)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(446, 56)
        Me.TableLayoutPanel1.TabIndex = 78
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(217, 50)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "Download Update"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Location = New System.Drawing.Point(226, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(217, 50)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.btnReddit)
        Me.StylizedPanel1.Controls.Add(Me.btnSource)
        Me.StylizedPanel1.Controls.Add(Me.lblLanguagePad)
        Me.StylizedPanel1.Controls.Add(Me.Label3)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Size = New System.Drawing.Size(911, 218)
        Me.StylizedPanel1.Style = "Colors=#cf6c36|#b21e54" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=45" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=98, 44," &
    " 44" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No Border=1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No AA=1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.StylizedPanel1.TabIndex = 79
        '
        'lblLanguagePad
        '
        Me.lblLanguagePad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLanguagePad.Font = New System.Drawing.Font("Tahoma", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguagePad.ForeColor = System.Drawing.Color.White
        Me.lblLanguagePad.Location = New System.Drawing.Point(0, 0)
        Me.lblLanguagePad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLanguagePad.Name = "lblLanguagePad"
        Me.lblLanguagePad.Size = New System.Drawing.Size(911, 164)
        Me.lblLanguagePad.TabIndex = 12
        Me.lblLanguagePad.Text = "Language Pad"
        Me.lblLanguagePad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 242)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 25)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Changelog:"
        '
        'dlgUpdate
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(911, 981)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StylizedPanel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtDecription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUpdate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.StylizedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDecription As TextBox
    Friend WithEvents btnReddit As Tundra.StylizedButton
    Friend WithEvents btnSource As Tundra.StylizedButton
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
    Friend WithEvents lblLanguagePad As Label
    Friend WithEvents Label1 As Label
End Class
