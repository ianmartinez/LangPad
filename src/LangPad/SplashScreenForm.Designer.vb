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
        Me.LoadingLabel = New System.Windows.Forms.Label()
        Me.HeaderBorderPanel = New LangPadUI.DoubleBufferedPanel()
        Me.HeaderPanel = New LangPadUI.DoubleBufferedPanel()
        Me.LangPadLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HeaderBorderPanel.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadingProgressBar
        '
        Me.LoadingProgressBar.Location = New System.Drawing.Point(20, 318)
        Me.LoadingProgressBar.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.LoadingProgressBar.Name = "LoadingProgressBar"
        Me.LoadingProgressBar.Size = New System.Drawing.Size(845, 40)
        Me.LoadingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.LoadingProgressBar.TabIndex = 81
        '
        'LoadingLabel
        '
        Me.LoadingLabel.AutoSize = True
        Me.LoadingLabel.Location = New System.Drawing.Point(20, 278)
        Me.LoadingLabel.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(107, 25)
        Me.LoadingLabel.TabIndex = 82
        Me.LoadingLabel.Text = "Loading..."
        '
        'HeaderBorderPanel
        '
        Me.HeaderBorderPanel.BackColor = System.Drawing.Color.Black
        Me.HeaderBorderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaderBorderPanel.Controls.Add(Me.HeaderPanel)
        Me.HeaderBorderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderBorderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderBorderPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HeaderBorderPanel.Name = "HeaderBorderPanel"
        Me.HeaderBorderPanel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.HeaderBorderPanel.Size = New System.Drawing.Size(885, 255)
        Me.HeaderBorderPanel.TabIndex = 83
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackgroundImage = CType(resources.GetObject("HeaderPanel.BackgroundImage"), System.Drawing.Image)
        Me.HeaderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaderPanel.Controls.Add(Me.LangPadLabel)
        Me.HeaderPanel.Controls.Add(Me.PictureBox1)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Padding = New System.Windows.Forms.Padding(21, 40, 21, 40)
        Me.HeaderPanel.Size = New System.Drawing.Size(885, 254)
        Me.HeaderPanel.TabIndex = 76
        '
        'LangPadLabel
        '
        Me.LangPadLabel.BackColor = System.Drawing.Color.Transparent
        Me.LangPadLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LangPadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LangPadLabel.ForeColor = System.Drawing.Color.White
        Me.LangPadLabel.Location = New System.Drawing.Point(184, 40)
        Me.LangPadLabel.Margin = New System.Windows.Forms.Padding(12, 6, 5, 6)
        Me.LangPadLabel.Name = "LangPadLabel"
        Me.LangPadLabel.Padding = New System.Windows.Forms.Padding(21, 2, 0, 0)
        Me.LangPadLabel.Size = New System.Drawing.Size(680, 174)
        Me.LangPadLabel.TabIndex = 12
        Me.LangPadLabel.Text = "LangPad"
        Me.LangPadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(21, 40)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 174)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'SplashScreenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 376)
        Me.Controls.Add(Me.HeaderBorderPanel)
        Me.Controls.Add(Me.LoadingLabel)
        Me.Controls.Add(Me.LoadingProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreenForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderBorderPanel.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadingProgressBar As ProgressBar
    Friend WithEvents LoadingLabel As Label
    Friend WithEvents HeaderBorderPanel As LangPadUI.DoubleBufferedPanel
    Friend WithEvents HeaderPanel As LangPadUI.DoubleBufferedPanel
    Friend WithEvents LangPadLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
