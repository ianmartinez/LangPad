<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutDialog
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutDialog))
        MainTabControl = New TabControl()
        LicenseTab = New TabPage()
        LicenseTextBox = New TextBox()
        ChangelogTab = New TabPage()
        ChangelogTextBox = New TextBox()
        CreditsTab = New TabPage()
        CreditsTextBox = New TextBox()
        MainTooltip = New ToolTip(components)
        MainTableLayoutPanel = New TableLayoutPanel()
        HeaderBorderPanel = New LangPadUI.DoubleBufferedPanel()
        HeaderPanel = New LangPadUI.DoubleBufferedPanel()
        LangPadLabel = New Label()
        PictureBox1 = New PictureBox()
        ButtonTableLayout = New TableLayoutPanel()
        GitHubButton = New Button()
        PatreonButton = New Button()
        WebsiteButton = New Button()
        MainTabControl.SuspendLayout()
        LicenseTab.SuspendLayout()
        ChangelogTab.SuspendLayout()
        CreditsTab.SuspendLayout()
        MainTableLayoutPanel.SuspendLayout()
        HeaderBorderPanel.SuspendLayout()
        HeaderPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ButtonTableLayout.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainTabControl
        ' 
        MainTabControl.Controls.Add(LicenseTab)
        MainTabControl.Controls.Add(ChangelogTab)
        MainTabControl.Controls.Add(CreditsTab)
        MainTabControl.Dock = DockStyle.Fill
        MainTabControl.Location = New Point(8, 355)
        MainTabControl.Margin = New Padding(4, 6, 4, 6)
        MainTabControl.Name = "MainTabControl"
        MainTabControl.SelectedIndex = 0
        MainTabControl.Size = New Size(966, 771)
        MainTabControl.TabIndex = 9
        ' 
        ' LicenseTab
        ' 
        LicenseTab.Controls.Add(LicenseTextBox)
        LicenseTab.Location = New Point(4, 34)
        LicenseTab.Margin = New Padding(4, 6, 4, 6)
        LicenseTab.Name = "LicenseTab"
        LicenseTab.Padding = New Padding(10, 11, 10, 11)
        LicenseTab.Size = New Size(958, 733)
        LicenseTab.TabIndex = 0
        LicenseTab.Text = "License"
        LicenseTab.UseVisualStyleBackColor = True
        ' 
        ' LicenseTextBox
        ' 
        LicenseTextBox.BackColor = Color.White
        LicenseTextBox.BorderStyle = BorderStyle.None
        LicenseTextBox.Dock = DockStyle.Fill
        LicenseTextBox.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LicenseTextBox.Location = New Point(10, 11)
        LicenseTextBox.Margin = New Padding(4, 6, 4, 6)
        LicenseTextBox.Multiline = True
        LicenseTextBox.Name = "LicenseTextBox"
        LicenseTextBox.ReadOnly = True
        LicenseTextBox.ScrollBars = ScrollBars.Vertical
        LicenseTextBox.Size = New Size(938, 711)
        LicenseTextBox.TabIndex = 7
        LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text")
        ' 
        ' ChangelogTab
        ' 
        ChangelogTab.Controls.Add(ChangelogTextBox)
        ChangelogTab.Location = New Point(4, 34)
        ChangelogTab.Margin = New Padding(4, 6, 4, 6)
        ChangelogTab.Name = "ChangelogTab"
        ChangelogTab.Padding = New Padding(10, 11, 10, 11)
        ChangelogTab.Size = New Size(958, 733)
        ChangelogTab.TabIndex = 1
        ChangelogTab.Text = "Changelog"
        ChangelogTab.UseVisualStyleBackColor = True
        ' 
        ' ChangelogTextBox
        ' 
        ChangelogTextBox.BackColor = Color.White
        ChangelogTextBox.BorderStyle = BorderStyle.None
        ChangelogTextBox.Dock = DockStyle.Fill
        ChangelogTextBox.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ChangelogTextBox.Location = New Point(10, 11)
        ChangelogTextBox.Margin = New Padding(4, 6, 4, 6)
        ChangelogTextBox.Multiline = True
        ChangelogTextBox.Name = "ChangelogTextBox"
        ChangelogTextBox.ReadOnly = True
        ChangelogTextBox.ScrollBars = ScrollBars.Vertical
        ChangelogTextBox.Size = New Size(938, 711)
        ChangelogTextBox.TabIndex = 8
        ChangelogTextBox.Text = resources.GetString("ChangelogTextBox.Text")
        ' 
        ' CreditsTab
        ' 
        CreditsTab.Controls.Add(CreditsTextBox)
        CreditsTab.Location = New Point(4, 34)
        CreditsTab.Margin = New Padding(4, 4, 4, 4)
        CreditsTab.Name = "CreditsTab"
        CreditsTab.Padding = New Padding(10, 11, 10, 11)
        CreditsTab.Size = New Size(958, 733)
        CreditsTab.TabIndex = 2
        CreditsTab.Text = "Credits"
        CreditsTab.UseVisualStyleBackColor = True
        ' 
        ' CreditsTextBox
        ' 
        CreditsTextBox.BackColor = Color.White
        CreditsTextBox.BorderStyle = BorderStyle.None
        CreditsTextBox.Dock = DockStyle.Fill
        CreditsTextBox.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CreditsTextBox.Location = New Point(10, 11)
        CreditsTextBox.Margin = New Padding(4, 6, 4, 6)
        CreditsTextBox.Multiline = True
        CreditsTextBox.Name = "CreditsTextBox"
        CreditsTextBox.ReadOnly = True
        CreditsTextBox.ScrollBars = ScrollBars.Vertical
        CreditsTextBox.Size = New Size(938, 711)
        CreditsTextBox.TabIndex = 8
        CreditsTextBox.Text = resources.GetString("CreditsTextBox.Text")
        ' 
        ' MainTableLayoutPanel
        ' 
        MainTableLayoutPanel.ColumnCount = 1
        MainTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        MainTableLayoutPanel.Controls.Add(HeaderBorderPanel, 0, 0)
        MainTableLayoutPanel.Controls.Add(ButtonTableLayout, 0, 1)
        MainTableLayoutPanel.Controls.Add(MainTabControl, 0, 2)
        MainTableLayoutPanel.Dock = DockStyle.Fill
        MainTableLayoutPanel.Location = New Point(6, 8)
        MainTableLayoutPanel.Margin = New Padding(4, 4, 4, 4)
        MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        MainTableLayoutPanel.Padding = New Padding(4, 4, 4, 4)
        MainTableLayoutPanel.RowCount = 3
        MainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 225F))
        MainTableLayoutPanel.RowStyles.Add(New RowStyle())
        MainTableLayoutPanel.RowStyles.Add(New RowStyle())
        MainTableLayoutPanel.Size = New Size(982, 1131)
        MainTableLayoutPanel.TabIndex = 77
        ' 
        ' HeaderBorderPanel
        ' 
        HeaderBorderPanel.BackColor = Color.Black
        HeaderBorderPanel.BackgroundImageLayout = ImageLayout.Stretch
        HeaderBorderPanel.BorderStyle = BorderStyle.FixedSingle
        HeaderBorderPanel.Controls.Add(HeaderPanel)
        HeaderBorderPanel.Dock = DockStyle.Fill
        HeaderBorderPanel.Location = New Point(8, 8)
        HeaderBorderPanel.Margin = New Padding(4, 4, 4, 4)
        HeaderBorderPanel.Name = "HeaderBorderPanel"
        HeaderBorderPanel.Padding = New Padding(1)
        HeaderBorderPanel.Size = New Size(966, 217)
        HeaderBorderPanel.TabIndex = 76
        ' 
        ' HeaderPanel
        ' 
        HeaderPanel.BackgroundImage = CType(resources.GetObject("HeaderPanel.BackgroundImage"), Image)
        HeaderPanel.BackgroundImageLayout = ImageLayout.Stretch
        HeaderPanel.Controls.Add(LangPadLabel)
        HeaderPanel.Controls.Add(PictureBox1)
        HeaderPanel.Dock = DockStyle.Fill
        HeaderPanel.Location = New Point(1, 1)
        HeaderPanel.Margin = New Padding(4, 4, 4, 4)
        HeaderPanel.Name = "HeaderPanel"
        HeaderPanel.Padding = New Padding(18, 40, 18, 40)
        HeaderPanel.Size = New Size(962, 213)
        HeaderPanel.TabIndex = 77
        ' 
        ' LangPadLabel
        ' 
        LangPadLabel.BackColor = Color.Transparent
        LangPadLabel.Dock = DockStyle.Fill
        LangPadLabel.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold)
        LangPadLabel.ForeColor = Color.White
        LangPadLabel.Location = New Point(154, 40)
        LangPadLabel.Margin = New Padding(10, 6, 4, 6)
        LangPadLabel.Name = "LangPadLabel"
        LangPadLabel.Padding = New Padding(18, 2, 0, 0)
        LangPadLabel.Size = New Size(790, 133)
        LangPadLabel.TabIndex = 12
        LangPadLabel.Text = "LangPad"
        LangPadLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Location = New Point(18, 40)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(136, 133)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' ButtonTableLayout
        ' 
        ButtonTableLayout.AutoSize = True
        ButtonTableLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ButtonTableLayout.ColumnCount = 3
        ButtonTableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        ButtonTableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        ButtonTableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        ButtonTableLayout.Controls.Add(GitHubButton, 0, 0)
        ButtonTableLayout.Controls.Add(PatreonButton, 0, 0)
        ButtonTableLayout.Controls.Add(WebsiteButton, 1, 0)
        ButtonTableLayout.Dock = DockStyle.Fill
        ButtonTableLayout.Location = New Point(8, 235)
        ButtonTableLayout.Margin = New Padding(4, 6, 4, 6)
        ButtonTableLayout.Name = "ButtonTableLayout"
        ButtonTableLayout.Padding = New Padding(0, 11, 0, 6)
        ButtonTableLayout.RowCount = 1
        ButtonTableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        ButtonTableLayout.Size = New Size(966, 108)
        ButtonTableLayout.TabIndex = 78
        ' 
        ' GitHubButton
        ' 
        GitHubButton.AutoSize = True
        GitHubButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GitHubButton.Dock = DockStyle.Fill
        GitHubButton.Image = CType(resources.GetObject("GitHubButton.Image"), Image)
        GitHubButton.Location = New Point(326, 15)
        GitHubButton.Margin = New Padding(4, 4, 4, 4)
        GitHubButton.Name = "GitHubButton"
        GitHubButton.Padding = New Padding(6, 8, 6, 8)
        GitHubButton.Size = New Size(314, 83)
        GitHubButton.TabIndex = 2
        GitHubButton.Text = "GitHub"
        GitHubButton.TextImageRelation = TextImageRelation.ImageAboveText
        GitHubButton.UseVisualStyleBackColor = True
        ' 
        ' PatreonButton
        ' 
        PatreonButton.AutoSize = True
        PatreonButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        PatreonButton.Dock = DockStyle.Fill
        PatreonButton.Image = CType(resources.GetObject("PatreonButton.Image"), Image)
        PatreonButton.Location = New Point(4, 15)
        PatreonButton.Margin = New Padding(4, 4, 4, 4)
        PatreonButton.Name = "PatreonButton"
        PatreonButton.Padding = New Padding(6, 8, 6, 8)
        PatreonButton.Size = New Size(314, 83)
        PatreonButton.TabIndex = 1
        PatreonButton.Text = "Support on Patreon"
        PatreonButton.TextImageRelation = TextImageRelation.ImageAboveText
        PatreonButton.UseVisualStyleBackColor = True
        ' 
        ' WebsiteButton
        ' 
        WebsiteButton.AutoSize = True
        WebsiteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink
        WebsiteButton.Dock = DockStyle.Fill
        WebsiteButton.Image = CType(resources.GetObject("WebsiteButton.Image"), Image)
        WebsiteButton.Location = New Point(648, 15)
        WebsiteButton.Margin = New Padding(4, 4, 4, 4)
        WebsiteButton.Name = "WebsiteButton"
        WebsiteButton.Padding = New Padding(6, 8, 6, 8)
        WebsiteButton.Size = New Size(314, 83)
        WebsiteButton.TabIndex = 3
        WebsiteButton.Text = "Website"
        WebsiteButton.TextImageRelation = TextImageRelation.ImageAboveText
        WebsiteButton.UseVisualStyleBackColor = True
        ' 
        ' AboutDialog
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(994, 1151)
        Controls.Add(MainTableLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 6, 4, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AboutDialog"
        Padding = New Padding(6, 8, 6, 12)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "About"
        MainTabControl.ResumeLayout(False)
        LicenseTab.ResumeLayout(False)
        LicenseTab.PerformLayout()
        ChangelogTab.ResumeLayout(False)
        ChangelogTab.PerformLayout()
        CreditsTab.ResumeLayout(False)
        CreditsTab.PerformLayout()
        MainTableLayoutPanel.ResumeLayout(False)
        MainTableLayoutPanel.PerformLayout()
        HeaderBorderPanel.ResumeLayout(False)
        HeaderPanel.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ButtonTableLayout.ResumeLayout(False)
        ButtonTableLayout.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents LicenseTab As System.Windows.Forms.TabPage
    Friend WithEvents LicenseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChangelogTab As System.Windows.Forms.TabPage
    Friend WithEvents ChangelogTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MainTooltip As ToolTip
    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents HeaderBorderPanel As LangPadUI.DoubleBufferedPanel
    Friend WithEvents HeaderPanel As LangPadUI.DoubleBufferedPanel
    Friend WithEvents LangPadLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonTableLayout As TableLayoutPanel
    Friend WithEvents GitHubButton As Button
    Friend WithEvents PatreonButton As Button
    Friend WithEvents WebsiteButton As Button
    Friend WithEvents CreditsTab As TabPage
    Friend WithEvents CreditsTextBox As TextBox
End Class
