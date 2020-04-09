<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreenForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreenForm))
        Me.LoadingProgressBar = New System.Windows.Forms.ProgressBar()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.LanguagePadLabel = New System.Windows.Forms.Label()
        Me.LoadingLabel = New System.Windows.Forms.Label()
        Me.TopPanel = New TundraLib.DoubleBufferedPanel()
        Me.TopPanel.SuspendLayout
        Me.SuspendLayout
        '
        'LoadingProgressBar
        '
        Me.LoadingProgressBar.Location = New System.Drawing.Point(9, 236)
        Me.LoadingProgressBar.Name = "LoadingProgressBar"
        Me.LoadingProgressBar.Size = New System.Drawing.Size(601, 32)
        Me.LoadingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.LoadingProgressBar.TabIndex = 81
        '
        'VersionLabel
        '
        Me.VersionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VersionLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VersionLabel.ForeColor = System.Drawing.Color.White
        Me.VersionLabel.Location = New System.Drawing.Point(0, 138)
        Me.VersionLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(622, 52)
        Me.VersionLabel.TabIndex = 74
        Me.VersionLabel.Text = "Version 1.0"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LanguagePadLabel
        '
        Me.LanguagePadLabel.BackColor = System.Drawing.Color.Transparent
        Me.LanguagePadLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LanguagePadLabel.Font = New System.Drawing.Font("Tahoma", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LanguagePadLabel.ForeColor = System.Drawing.Color.White
        Me.LanguagePadLabel.Location = New System.Drawing.Point(0, 0)
        Me.LanguagePadLabel.Name = "LanguagePadLabel"
        Me.LanguagePadLabel.Size = New System.Drawing.Size(622, 138)
        Me.LanguagePadLabel.TabIndex = 12
        Me.LanguagePadLabel.Text = "Language Pad"
        Me.LanguagePadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoadingLabel
        '
        Me.LoadingLabel.AutoSize = True
        Me.LoadingLabel.Location = New System.Drawing.Point(12, 206)
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(78, 20)
        Me.LoadingLabel.TabIndex = 82
        Me.LoadingLabel.Text = "Loading..."
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TopPanel.BackgroundImage = CType(resources.GetObject("TopPanel.BackgroundImage"), System.Drawing.Image)
        Me.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopPanel.Controls.Add(Me.LanguagePadLabel)
        Me.TopPanel.Controls.Add(Me.VersionLabel)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(9)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(622, 190)
        Me.TopPanel.TabIndex = 83
        '
        'SplashScreenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 284)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.LoadingLabel)
        Me.Controls.Add(Me.LoadingProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreenForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadingProgressBar As ProgressBar
    Friend WithEvents VersionLabel As Label
    Friend WithEvents LanguagePadLabel As Label
    Friend WithEvents LoadingLabel As Label
    Friend WithEvents TopPanel As TundraLib.DoubleBufferedPanel
End Class
