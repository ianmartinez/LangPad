<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAbout
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAbout))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnOK = New Tundra.StylizedButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLanguagePad = New System.Windows.Forms.Label()
        Me.btnGitHub = New Tundra.StylizedButton()
        Me.btnCheckUpdates = New Tundra.StylizedButton()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(11, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(380, 192)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(372, 166)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "License"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(366, 160)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(372, 166)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Changelog"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(3, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(366, 160)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(372, 166)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Credits"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(2, 2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(368, 162)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "Most of the icons" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   •Fat Cow Free Icons - http://www.fatcow.com/free-icons" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emo" &
    "tes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   •Fugue Icons - http://p.yusukekamiyamane.com/"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Location = New System.Drawing.Point(323, 244)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnOK.Size = New System.Drawing.Size(68, 25)
        Me.btnOK.Style = resources.GetString("btnOK.Style")
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseCompatibleTextRendering = True
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 28)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lblLanguagePad
        '
        Me.lblLanguagePad.Font = New System.Drawing.Font("Calibri Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguagePad.ForeColor = System.Drawing.Color.Sienna
        Me.lblLanguagePad.Location = New System.Drawing.Point(43, 12)
        Me.lblLanguagePad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLanguagePad.Name = "lblLanguagePad"
        Me.lblLanguagePad.Size = New System.Drawing.Size(348, 28)
        Me.lblLanguagePad.TabIndex = 12
        Me.lblLanguagePad.Text = "Language Pad X.x"
        Me.lblLanguagePad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGitHub
        '
        Me.btnGitHub.BackColor = System.Drawing.Color.Transparent
        Me.btnGitHub.BackgroundImage = CType(resources.GetObject("btnGitHub.BackgroundImage"), System.Drawing.Image)
        Me.btnGitHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGitHub.FlatAppearance.BorderSize = 0
        Me.btnGitHub.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnGitHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGitHub.ForeColor = System.Drawing.Color.Black
        Me.btnGitHub.Image = CType(resources.GetObject("btnGitHub.Image"), System.Drawing.Image)
        Me.btnGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGitHub.Location = New System.Drawing.Point(11, 244)
        Me.btnGitHub.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGitHub.Name = "btnGitHub"
        Me.btnGitHub.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnGitHub.Size = New System.Drawing.Size(25, 25)
        Me.btnGitHub.Style = resources.GetString("btnGitHub.Style")
        Me.btnGitHub.TabIndex = 77
        Me.btnGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGitHub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnGitHub, "View source on github")
        Me.btnGitHub.UseCompatibleTextRendering = True
        Me.btnGitHub.UseVisualStyleBackColor = False
        '
        'btnCheckUpdates
        '
        Me.btnCheckUpdates.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckUpdates.BackgroundImage = CType(resources.GetObject("btnCheckUpdates.BackgroundImage"), System.Drawing.Image)
        Me.btnCheckUpdates.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCheckUpdates.FlatAppearance.BorderSize = 0
        Me.btnCheckUpdates.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnCheckUpdates.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCheckUpdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCheckUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckUpdates.ForeColor = System.Drawing.Color.Black
        Me.btnCheckUpdates.Image = CType(resources.GetObject("btnCheckUpdates.Image"), System.Drawing.Image)
        Me.btnCheckUpdates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckUpdates.Location = New System.Drawing.Point(40, 244)
        Me.btnCheckUpdates.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckUpdates.Name = "btnCheckUpdates"
        Me.btnCheckUpdates.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnCheckUpdates.Size = New System.Drawing.Size(25, 25)
        Me.btnCheckUpdates.Style = resources.GetString("btnCheckUpdates.Style")
        Me.btnCheckUpdates.TabIndex = 78
        Me.btnCheckUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckUpdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnCheckUpdates, "Check for updates")
        Me.btnCheckUpdates.UseCompatibleTextRendering = True
        Me.btnCheckUpdates.UseVisualStyleBackColor = False
        '
        'dlgAbout
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(401, 278)
        Me.Controls.Add(Me.btnCheckUpdates)
        Me.Controls.Add(Me.btnGitHub)
        Me.Controls.Add(Me.lblLanguagePad)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As Tundra.StylizedButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblLanguagePad As Label
    Friend WithEvents btnGitHub As Tundra.StylizedButton
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents btnCheckUpdates As Tundra.StylizedButton
End Class
