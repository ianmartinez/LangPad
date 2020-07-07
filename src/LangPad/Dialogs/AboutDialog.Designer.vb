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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutDialog))
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.LicenseTab = New System.Windows.Forms.TabPage()
        Me.LicenseTextBox = New System.Windows.Forms.TextBox()
        Me.ChangelogTab = New System.Windows.Forms.TabPage()
        Me.ChangelogTextBox = New System.Windows.Forms.TextBox()
        Me.CreditsTab = New System.Windows.Forms.TabPage()
        Me.CreditsTextBox = New System.Windows.Forms.TextBox()
        Me.MainTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderBorderPanel = New LangPadUI.DoubleBufferedPanel()
        Me.HeaderPanel = New LangPadUI.DoubleBufferedPanel()
        Me.LangPadLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.GitHubButton = New System.Windows.Forms.Button()
        Me.PatreonButton = New System.Windows.Forms.Button()
        Me.WebsiteButton = New System.Windows.Forms.Button()
        Me.MainTabControl.SuspendLayout()
        Me.LicenseTab.SuspendLayout()
        Me.ChangelogTab.SuspendLayout()
        Me.CreditsTab.SuspendLayout()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.HeaderBorderPanel.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonTableLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.LicenseTab)
        Me.MainTabControl.Controls.Add(Me.ChangelogTab)
        Me.MainTabControl.Controls.Add(Me.CreditsTab)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(9, 355)
        Me.MainTabControl.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(1158, 766)
        Me.MainTabControl.TabIndex = 9
        '
        'LicenseTab
        '
        Me.LicenseTab.Controls.Add(Me.LicenseTextBox)
        Me.LicenseTab.Location = New System.Drawing.Point(8, 39)
        Me.LicenseTab.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LicenseTab.Name = "LicenseTab"
        Me.LicenseTab.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.LicenseTab.Size = New System.Drawing.Size(1142, 719)
        Me.LicenseTab.TabIndex = 0
        Me.LicenseTab.Text = "License"
        Me.LicenseTab.UseVisualStyleBackColor = True
        '
        'LicenseTextBox
        '
        Me.LicenseTextBox.BackColor = System.Drawing.Color.White
        Me.LicenseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LicenseTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LicenseTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LicenseTextBox.Location = New System.Drawing.Point(12, 11)
        Me.LicenseTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LicenseTextBox.Multiline = True
        Me.LicenseTextBox.Name = "LicenseTextBox"
        Me.LicenseTextBox.ReadOnly = True
        Me.LicenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LicenseTextBox.Size = New System.Drawing.Size(1118, 697)
        Me.LicenseTextBox.TabIndex = 7
        Me.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text")
        '
        'ChangelogTab
        '
        Me.ChangelogTab.Controls.Add(Me.ChangelogTextBox)
        Me.ChangelogTab.Location = New System.Drawing.Point(8, 39)
        Me.ChangelogTab.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ChangelogTab.Name = "ChangelogTab"
        Me.ChangelogTab.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.ChangelogTab.Size = New System.Drawing.Size(1141, 709)
        Me.ChangelogTab.TabIndex = 1
        Me.ChangelogTab.Text = "Changelog"
        Me.ChangelogTab.UseVisualStyleBackColor = True
        '
        'ChangelogTextBox
        '
        Me.ChangelogTextBox.BackColor = System.Drawing.Color.White
        Me.ChangelogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChangelogTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangelogTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChangelogTextBox.Location = New System.Drawing.Point(12, 11)
        Me.ChangelogTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ChangelogTextBox.Multiline = True
        Me.ChangelogTextBox.Name = "ChangelogTextBox"
        Me.ChangelogTextBox.ReadOnly = True
        Me.ChangelogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ChangelogTextBox.Size = New System.Drawing.Size(1117, 687)
        Me.ChangelogTextBox.TabIndex = 8
        Me.ChangelogTextBox.Text = resources.GetString("ChangelogTextBox.Text")
        '
        'CreditsTab
        '
        Me.CreditsTab.Controls.Add(Me.CreditsTextBox)
        Me.CreditsTab.Location = New System.Drawing.Point(8, 39)
        Me.CreditsTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CreditsTab.Name = "CreditsTab"
        Me.CreditsTab.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CreditsTab.Size = New System.Drawing.Size(1141, 709)
        Me.CreditsTab.TabIndex = 2
        Me.CreditsTab.Text = "Credits"
        Me.CreditsTab.UseVisualStyleBackColor = True
        '
        'CreditsTextBox
        '
        Me.CreditsTextBox.BackColor = System.Drawing.Color.White
        Me.CreditsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CreditsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreditsTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CreditsTextBox.Location = New System.Drawing.Point(12, 11)
        Me.CreditsTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CreditsTextBox.Multiline = True
        Me.CreditsTextBox.Name = "CreditsTextBox"
        Me.CreditsTextBox.ReadOnly = True
        Me.CreditsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CreditsTextBox.Size = New System.Drawing.Size(1117, 687)
        Me.CreditsTextBox.TabIndex = 8
        Me.CreditsTextBox.Text = resources.GetString("CreditsTextBox.Text")
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.ColumnCount = 1
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Controls.Add(Me.HeaderBorderPanel, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.ButtonTableLayout, 0, 1)
        Me.MainTableLayoutPanel.Controls.Add(Me.MainTabControl, 0, 2)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(8, 8)
        Me.MainTableLayoutPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MainTableLayoutPanel.RowCount = 3
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225.0!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(1176, 1131)
        Me.MainTableLayoutPanel.TabIndex = 77
        '
        'HeaderBorderPanel
        '
        Me.HeaderBorderPanel.BackColor = System.Drawing.Color.Black
        Me.HeaderBorderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaderBorderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HeaderBorderPanel.Controls.Add(Me.HeaderPanel)
        Me.HeaderBorderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderBorderPanel.Location = New System.Drawing.Point(8, 8)
        Me.HeaderBorderPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HeaderBorderPanel.Name = "HeaderBorderPanel"
        Me.HeaderBorderPanel.Padding = New System.Windows.Forms.Padding(1)
        Me.HeaderBorderPanel.Size = New System.Drawing.Size(1160, 217)
        Me.HeaderBorderPanel.TabIndex = 76
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackgroundImage = CType(resources.GetObject("HeaderPanel.BackgroundImage"), System.Drawing.Image)
        Me.HeaderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaderPanel.Controls.Add(Me.LangPadLabel)
        Me.HeaderPanel.Controls.Add(Me.PictureBox1)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderPanel.Location = New System.Drawing.Point(1, 1)
        Me.HeaderPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Padding = New System.Windows.Forms.Padding(21, 40, 21, 40)
        Me.HeaderPanel.Size = New System.Drawing.Size(1156, 213)
        Me.HeaderPanel.TabIndex = 77
        '
        'LangPadLabel
        '
        Me.LangPadLabel.BackColor = System.Drawing.Color.Transparent
        Me.LangPadLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LangPadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LangPadLabel.ForeColor = System.Drawing.Color.White
        Me.LangPadLabel.Location = New System.Drawing.Point(184, 40)
        Me.LangPadLabel.Margin = New System.Windows.Forms.Padding(12, 6, 5, 6)
        Me.LangPadLabel.Name = "LangPadLabel"
        Me.LangPadLabel.Padding = New System.Windows.Forms.Padding(21, 2, 0, 0)
        Me.LangPadLabel.Size = New System.Drawing.Size(951, 133)
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
        Me.PictureBox1.Size = New System.Drawing.Size(163, 133)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ButtonTableLayout
        '
        Me.ButtonTableLayout.AutoSize = True
        Me.ButtonTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonTableLayout.ColumnCount = 3
        Me.ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ButtonTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ButtonTableLayout.Controls.Add(Me.GitHubButton, 0, 0)
        Me.ButtonTableLayout.Controls.Add(Me.PatreonButton, 0, 0)
        Me.ButtonTableLayout.Controls.Add(Me.WebsiteButton, 1, 0)
        Me.ButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonTableLayout.Location = New System.Drawing.Point(9, 235)
        Me.ButtonTableLayout.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ButtonTableLayout.Name = "ButtonTableLayout"
        Me.ButtonTableLayout.Padding = New System.Windows.Forms.Padding(0, 11, 0, 6)
        Me.ButtonTableLayout.RowCount = 1
        Me.ButtonTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ButtonTableLayout.Size = New System.Drawing.Size(1158, 108)
        Me.ButtonTableLayout.TabIndex = 78
        '
        'GitHubButton
        '
        Me.GitHubButton.AutoSize = True
        Me.GitHubButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GitHubButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GitHubButton.Image = CType(resources.GetObject("GitHubButton.Image"), System.Drawing.Image)
        Me.GitHubButton.Location = New System.Drawing.Point(390, 15)
        Me.GitHubButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GitHubButton.Name = "GitHubButton"
        Me.GitHubButton.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.GitHubButton.Size = New System.Drawing.Size(378, 83)
        Me.GitHubButton.TabIndex = 2
        Me.GitHubButton.Text = "GitHub"
        Me.GitHubButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.GitHubButton.UseVisualStyleBackColor = True
        '
        'PatreonButton
        '
        Me.PatreonButton.AutoSize = True
        Me.PatreonButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PatreonButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PatreonButton.Image = CType(resources.GetObject("PatreonButton.Image"), System.Drawing.Image)
        Me.PatreonButton.Location = New System.Drawing.Point(4, 15)
        Me.PatreonButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PatreonButton.Name = "PatreonButton"
        Me.PatreonButton.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.PatreonButton.Size = New System.Drawing.Size(378, 83)
        Me.PatreonButton.TabIndex = 1
        Me.PatreonButton.Text = "Support on Patreon"
        Me.PatreonButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.PatreonButton.UseVisualStyleBackColor = True
        '
        'WebsiteButton
        '
        Me.WebsiteButton.AutoSize = True
        Me.WebsiteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.WebsiteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebsiteButton.Image = CType(resources.GetObject("WebsiteButton.Image"), System.Drawing.Image)
        Me.WebsiteButton.Location = New System.Drawing.Point(776, 15)
        Me.WebsiteButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WebsiteButton.Name = "WebsiteButton"
        Me.WebsiteButton.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.WebsiteButton.Size = New System.Drawing.Size(378, 83)
        Me.WebsiteButton.TabIndex = 3
        Me.WebsiteButton.Text = "Website"
        Me.WebsiteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.WebsiteButton.UseVisualStyleBackColor = True
        '
        'AboutDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 1151)
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDialog"
        Me.Padding = New System.Windows.Forms.Padding(8, 8, 8, 12)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.MainTabControl.ResumeLayout(False)
        Me.LicenseTab.ResumeLayout(False)
        Me.LicenseTab.PerformLayout()
        Me.ChangelogTab.ResumeLayout(False)
        Me.ChangelogTab.PerformLayout()
        Me.CreditsTab.ResumeLayout(False)
        Me.CreditsTab.PerformLayout()
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.MainTableLayoutPanel.PerformLayout()
        Me.HeaderBorderPanel.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonTableLayout.ResumeLayout(False)
        Me.ButtonTableLayout.PerformLayout()
        Me.ResumeLayout(False)

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
