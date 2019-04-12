<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssLoading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssLoading))
        Me.pbLoading = New System.Windows.Forms.ProgressBar()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblLanguagePad = New System.Windows.Forms.Label()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.pnlTop = New TundraLib.DoubleBufferedPanel()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbLoading
        '
        Me.pbLoading.Location = New System.Drawing.Point(6, 192)
        Me.pbLoading.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(459, 21)
        Me.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbLoading.TabIndex = 81
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(0, 132)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(476, 28)
        Me.lblVersion.TabIndex = 74
        Me.lblVersion.Text = "Version 1.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLanguagePad
        '
        Me.lblLanguagePad.BackColor = System.Drawing.Color.Transparent
        Me.lblLanguagePad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLanguagePad.Font = New System.Drawing.Font("Tahoma", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguagePad.ForeColor = System.Drawing.Color.White
        Me.lblLanguagePad.Location = New System.Drawing.Point(0, 0)
        Me.lblLanguagePad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLanguagePad.Name = "lblLanguagePad"
        Me.lblLanguagePad.Size = New System.Drawing.Size(476, 132)
        Me.lblLanguagePad.TabIndex = 12
        Me.lblLanguagePad.Text = "Language Pad"
        Me.lblLanguagePad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Location = New System.Drawing.Point(4, 166)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(54, 13)
        Me.lblLoading.TabIndex = 82
        Me.lblLoading.Text = "Loading..."
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"), System.Drawing.Image)
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTop.Controls.Add(Me.lblLanguagePad)
        Me.pnlTop.Controls.Add(Me.lblVersion)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(476, 160)
        Me.pnlTop.TabIndex = 83
        '
        'ssLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(476, 221)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.pbLoading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ssLoading"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlTop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLoading As ProgressBar
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblLanguagePad As Label
    Friend WithEvents lblLoading As Label
    Friend WithEvents pnlTop As TundraLib.DoubleBufferedPanel
End Class
