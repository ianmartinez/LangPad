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
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.lblLanguagePad = New System.Windows.Forms.Label()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.pbLoading = New Tundra.StylizedProgressBar()
        Me.StylizedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.lblLanguagePad)
        Me.StylizedPanel1.Controls.Add(Me.lblLoading)
        Me.StylizedPanel1.Controls.Add(Me.pbLoading)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Size = New System.Drawing.Size(547, 165)
        Me.StylizedPanel1.Style = "Colors=#cf6c36|#b21e54" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=98, 44" &
    ", 44" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No Border=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No AA=1"
        Me.StylizedPanel1.TabIndex = 9
        '
        'lblLanguagePad
        '
        Me.lblLanguagePad.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguagePad.ForeColor = System.Drawing.Color.White
        Me.lblLanguagePad.Location = New System.Drawing.Point(13, 20)
        Me.lblLanguagePad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLanguagePad.Name = "lblLanguagePad"
        Me.lblLanguagePad.Size = New System.Drawing.Size(521, 54)
        Me.lblLanguagePad.TabIndex = 9
        Me.lblLanguagePad.Text = "Language Pad X.x"
        Me.lblLanguagePad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoading
        '
        Me.lblLoading.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.MistyRose
        Me.lblLoading.Location = New System.Drawing.Point(15, 74)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(519, 32)
        Me.lblLoading.TabIndex = 8
        Me.lblLoading.Text = "Loading"
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbLoading
        '
        Me.pbLoading.BackColor = System.Drawing.Color.Transparent
        Me.pbLoading.BackgroundImage = CType(resources.GetObject("pbLoading.BackgroundImage"), System.Drawing.Image)
        Me.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbLoading.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbLoading.Location = New System.Drawing.Point(0, 132)
        Me.pbLoading.Margin = New System.Windows.Forms.Padding(6)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(547, 33)
        Me.pbLoading.Style = resources.GetString("pbLoading.Style")
        Me.pbLoading.TabIndex = 6
        '
        'ssLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(547, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.StylizedPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ssLoading"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.PaleTurquoise
        Me.StylizedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbLoading As Tundra.StylizedProgressBar
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
    Friend WithEvents lblLanguagePad As System.Windows.Forms.Label

End Class
