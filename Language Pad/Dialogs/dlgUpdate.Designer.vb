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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDecription = New System.Windows.Forms.TextBox()
        Me.lblLanguagePad = New System.Windows.Forms.Label()
        Me.btnReddit = New Tundra.StylizedButton()
        Me.btnSource = New Tundra.StylizedButton()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(24, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 54)
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(670, 25)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "A new version of Language Pad is available. Do you want to update?"
        '
        'txtDecription
        '
        Me.txtDecription.BackColor = System.Drawing.Color.White
        Me.txtDecription.ForeColor = System.Drawing.Color.Black
        Me.txtDecription.Location = New System.Drawing.Point(24, 113)
        Me.txtDecription.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDecription.Multiline = True
        Me.txtDecription.Name = "txtDecription"
        Me.txtDecription.ReadOnly = True
        Me.txtDecription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDecription.Size = New System.Drawing.Size(818, 504)
        Me.txtDecription.TabIndex = 75
        Me.txtDecription.Text = "What's new in X.x:"
        '
        'lblLanguagePad
        '
        Me.lblLanguagePad.Font = New System.Drawing.Font("Calibri Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguagePad.ForeColor = System.Drawing.Color.Firebrick
        Me.lblLanguagePad.Location = New System.Drawing.Point(86, 23)
        Me.lblLanguagePad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLanguagePad.Name = "lblLanguagePad"
        Me.lblLanguagePad.Size = New System.Drawing.Size(760, 54)
        Me.lblLanguagePad.TabIndex = 71
        Me.lblLanguagePad.Text = "Language Pad X.x Update"
        Me.lblLanguagePad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnReddit.Location = New System.Drawing.Point(23, 633)
        Me.btnReddit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReddit.Name = "btnReddit"
        Me.btnReddit.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnReddit.Size = New System.Drawing.Size(72, 68)
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
        Me.btnSource.Location = New System.Drawing.Point(103, 633)
        Me.btnSource.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnSource.Size = New System.Drawing.Size(72, 68)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(554, 639)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(292, 56)
        Me.TableLayoutPanel1.TabIndex = 78
        '
        'btnOK
        '
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(140, 50)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Location = New System.Drawing.Point(149, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 50)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dlgUpdate
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(870, 710)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnSource)
        Me.Controls.Add(Me.btnReddit)
        Me.Controls.Add(Me.txtDecription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLanguagePad)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUpdate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDecription As TextBox
    Friend WithEvents lblLanguagePad As Label
    Friend WithEvents btnReddit As Tundra.StylizedButton
    Friend WithEvents btnSource As Tundra.StylizedButton
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
End Class
