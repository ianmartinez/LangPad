<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateDialog))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDecription = New System.Windows.Forms.TextBox()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReddit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.StylizedPanel1 = New TundraLib.DoubleBufferedPanel()
        Me.lblLanguagePad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(868, 43)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "The update ""Language Pad {0}"" is available."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDecription
        '
        Me.txtDecription.BackColor = System.Drawing.SystemColors.Window
        Me.txtDecription.Location = New System.Drawing.Point(16, 220)
        Me.txtDecription.Multiline = True
        Me.txtDecription.Name = "txtDecription"
        Me.txtDecription.ReadOnly = True
        Me.txtDecription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDecription.Size = New System.Drawing.Size(834, 493)
        Me.txtDecription.TabIndex = 75
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSource, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReddit, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 721)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(868, 64)
        Me.TableLayoutPanel1.TabIndex = 78
        '
        'btnReddit
        '
        Me.btnReddit.BackColor = System.Drawing.Color.Transparent
        Me.btnReddit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReddit.Location = New System.Drawing.Point(222, 8)
        Me.btnReddit.Name = "btnReddit"
        Me.btnReddit.Size = New System.Drawing.Size(208, 48)
        Me.btnReddit.TabIndex = 2
        Me.btnReddit.Text = "View Reddit Thread"
        Me.btnReddit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Location = New System.Drawing.Point(650, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(210, 48)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.Location = New System.Drawing.Point(436, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(208, 48)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "Download Update"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.BackgroundImage = CType(resources.GetObject("StylizedPanel1.BackgroundImage"), System.Drawing.Image)
        Me.StylizedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StylizedPanel1.Controls.Add(Me.lblLanguagePad)
        Me.StylizedPanel1.Controls.Add(Me.Label3)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Size = New System.Drawing.Size(868, 174)
        Me.StylizedPanel1.TabIndex = 79
        '
        'lblLanguagePad
        '
        Me.lblLanguagePad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLanguagePad.Font = New System.Drawing.Font("Tahoma", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguagePad.ForeColor = System.Drawing.Color.White
        Me.lblLanguagePad.Location = New System.Drawing.Point(0, 0)
        Me.lblLanguagePad.Name = "lblLanguagePad"
        Me.lblLanguagePad.Size = New System.Drawing.Size(868, 131)
        Me.lblLanguagePad.TabIndex = 12
        Me.lblLanguagePad.Text = "Language Pad"
        Me.lblLanguagePad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 188)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Changelog:"
        '
        'btnSource
        '
        Me.btnSource.BackColor = System.Drawing.Color.Transparent
        Me.btnSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSource.Location = New System.Drawing.Point(8, 8)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(208, 48)
        Me.btnSource.TabIndex = 3
        Me.btnSource.Text = "View Source"
        Me.btnSource.UseVisualStyleBackColor = False
        '
        'dlgUpdate
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(868, 785)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StylizedPanel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtDecription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents StylizedPanel1 As TundraLib.DoubleBufferedPanel
    Friend WithEvents lblLanguagePad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReddit As Button
    Friend WithEvents btnSource As Button
End Class
