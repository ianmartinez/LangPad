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
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtChangelog = New System.Windows.Forms.TextBox()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.DoubleBufferedPanel1 = New TundraLib.DoubleBufferedPanel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblLanguagePad = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.DoubleBufferedPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(9, 151)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(706, 543)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtLicense)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPage1.Size = New System.Drawing.Size(698, 510)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "License"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtLicense
        '
        Me.txtLicense.BackColor = System.Drawing.Color.White
        Me.txtLicense.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLicense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLicense.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLicense.Location = New System.Drawing.Point(9, 9)
        Me.txtLicense.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLicense.Multiline = True
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.ReadOnly = True
        Me.txtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLicense.Size = New System.Drawing.Size(680, 492)
        Me.txtLicense.TabIndex = 7
        Me.txtLicense.Text = resources.GetString("txtLicense.Text")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtChangelog)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(9)
        Me.TabPage2.Size = New System.Drawing.Size(698, 510)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Changelog"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtChangelog
        '
        Me.txtChangelog.BackColor = System.Drawing.Color.White
        Me.txtChangelog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChangelog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChangelog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtChangelog.Location = New System.Drawing.Point(9, 9)
        Me.txtChangelog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChangelog.Multiline = True
        Me.txtChangelog.Name = "txtChangelog"
        Me.txtChangelog.ReadOnly = True
        Me.txtChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChangelog.Size = New System.Drawing.Size(680, 492)
        Me.txtChangelog.TabIndex = 8
        Me.txtChangelog.Text = resources.GetString("txtChangelog.Text")
        '
        'DoubleBufferedPanel1
        '
        Me.DoubleBufferedPanel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.DoubleBufferedPanel1.BackgroundImage = CType(resources.GetObject("DoubleBufferedPanel1.BackgroundImage"), System.Drawing.Image)
        Me.DoubleBufferedPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DoubleBufferedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DoubleBufferedPanel1.Controls.Add(Me.lblVersion)
        Me.DoubleBufferedPanel1.Controls.Add(Me.lblLanguagePad)
        Me.DoubleBufferedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DoubleBufferedPanel1.Location = New System.Drawing.Point(9, 9)
        Me.DoubleBufferedPanel1.Name = "DoubleBufferedPanel1"
        Me.DoubleBufferedPanel1.Size = New System.Drawing.Size(706, 142)
        Me.DoubleBufferedPanel1.TabIndex = 76
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(10, 94)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(9, 5, 4, 5)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(89, 20)
        Me.lblVersion.TabIndex = 74
        Me.lblVersion.Text = "Version 1.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLanguagePad
        '
        Me.lblLanguagePad.AutoSize = True
        Me.lblLanguagePad.BackColor = System.Drawing.Color.Transparent
        Me.lblLanguagePad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguagePad.ForeColor = System.Drawing.Color.White
        Me.lblLanguagePad.Location = New System.Drawing.Point(10, 31)
        Me.lblLanguagePad.Margin = New System.Windows.Forms.Padding(9, 5, 4, 5)
        Me.lblLanguagePad.Name = "lblLanguagePad"
        Me.lblLanguagePad.Size = New System.Drawing.Size(251, 40)
        Me.lblLanguagePad.TabIndex = 12
        Me.lblLanguagePad.Text = "Language Pad"
        Me.lblLanguagePad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dlgAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 703)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DoubleBufferedPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAbout"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.DoubleBufferedPanel1.ResumeLayout(False)
        Me.DoubleBufferedPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtLicense As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtChangelog As System.Windows.Forms.TextBox
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents lblLanguagePad As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents DoubleBufferedPanel1 As TundraLib.DoubleBufferedPanel
End Class
