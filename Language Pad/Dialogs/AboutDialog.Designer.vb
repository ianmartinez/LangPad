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
        Me.MainTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderBorderPanel = New TundraLib.DoubleBufferedPanel()
        Me.HeaderPanel = New TundraLib.DoubleBufferedPanel()
        Me.LanguagePadLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.MainTabControl.SuspendLayout()
        Me.LicenseTab.SuspendLayout()
        Me.ChangelogTab.SuspendLayout()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.HeaderBorderPanel.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.LicenseTab)
        Me.MainTabControl.Controls.Add(Me.ChangelogTab)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(7, 168)
        Me.MainTabControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(868, 556)
        Me.MainTabControl.TabIndex = 9
        '
        'LicenseTab
        '
        Me.LicenseTab.Controls.Add(Me.LicenseTextBox)
        Me.LicenseTab.Location = New System.Drawing.Point(4, 29)
        Me.LicenseTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LicenseTab.Name = "LicenseTab"
        Me.LicenseTab.Padding = New System.Windows.Forms.Padding(9)
        Me.LicenseTab.Size = New System.Drawing.Size(860, 523)
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
        Me.LicenseTextBox.Location = New System.Drawing.Point(9, 9)
        Me.LicenseTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LicenseTextBox.Multiline = True
        Me.LicenseTextBox.Name = "LicenseTextBox"
        Me.LicenseTextBox.ReadOnly = True
        Me.LicenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LicenseTextBox.Size = New System.Drawing.Size(842, 505)
        Me.LicenseTextBox.TabIndex = 7
        Me.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text")
        '
        'ChangelogTab
        '
        Me.ChangelogTab.Controls.Add(Me.ChangelogTextBox)
        Me.ChangelogTab.Location = New System.Drawing.Point(4, 29)
        Me.ChangelogTab.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChangelogTab.Name = "ChangelogTab"
        Me.ChangelogTab.Padding = New System.Windows.Forms.Padding(9)
        Me.ChangelogTab.Size = New System.Drawing.Size(860, 523)
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
        Me.ChangelogTextBox.Location = New System.Drawing.Point(9, 9)
        Me.ChangelogTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChangelogTextBox.Multiline = True
        Me.ChangelogTextBox.Name = "ChangelogTextBox"
        Me.ChangelogTextBox.ReadOnly = True
        Me.ChangelogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ChangelogTextBox.Size = New System.Drawing.Size(842, 505)
        Me.ChangelogTextBox.TabIndex = 8
        Me.ChangelogTextBox.Text = resources.GetString("ChangelogTextBox.Text")
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.ColumnCount = 1
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Controls.Add(Me.HeaderBorderPanel, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.MainTabControl, 0, 1)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(6, 6)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTableLayoutPanel.RowCount = 2
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(882, 732)
        Me.MainTableLayoutPanel.TabIndex = 77
        '
        'HeaderBorderPanel
        '
        Me.HeaderBorderPanel.BackColor = System.Drawing.Color.Black
        Me.HeaderBorderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaderBorderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HeaderBorderPanel.Controls.Add(Me.HeaderPanel)
        Me.HeaderBorderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderBorderPanel.Location = New System.Drawing.Point(6, 6)
        Me.HeaderBorderPanel.Name = "HeaderBorderPanel"
        Me.HeaderBorderPanel.Padding = New System.Windows.Forms.Padding(1)
        Me.HeaderBorderPanel.Size = New System.Drawing.Size(870, 154)
        Me.HeaderBorderPanel.TabIndex = 76
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackgroundImage = CType(resources.GetObject("HeaderPanel.BackgroundImage"), System.Drawing.Image)
        Me.HeaderPanel.Controls.Add(Me.LanguagePadLabel)
        Me.HeaderPanel.Controls.Add(Me.VersionLabel)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderPanel.Location = New System.Drawing.Point(1, 1)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(866, 150)
        Me.HeaderPanel.TabIndex = 76
        '
        'LanguagePadLabel
        '
        Me.LanguagePadLabel.BackColor = System.Drawing.Color.Transparent
        Me.LanguagePadLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LanguagePadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LanguagePadLabel.ForeColor = System.Drawing.Color.White
        Me.LanguagePadLabel.Location = New System.Drawing.Point(0, 0)
        Me.LanguagePadLabel.Margin = New System.Windows.Forms.Padding(9, 5, 4, 5)
        Me.LanguagePadLabel.Name = "LanguagePadLabel"
        Me.LanguagePadLabel.Padding = New System.Windows.Forms.Padding(10, 2, 0, 0)
        Me.LanguagePadLabel.Size = New System.Drawing.Size(866, 105)
        Me.LanguagePadLabel.TabIndex = 12
        Me.LanguagePadLabel.Text = "Language Pad"
        Me.LanguagePadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VersionLabel
        '
        Me.VersionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VersionLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VersionLabel.ForeColor = System.Drawing.Color.White
        Me.VersionLabel.Location = New System.Drawing.Point(0, 105)
        Me.VersionLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.VersionLabel.Size = New System.Drawing.Size(866, 45)
        Me.VersionLabel.TabIndex = 75
        Me.VersionLabel.Text = "Version 1.0"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AboutDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 744)
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDialog"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.MainTabControl.ResumeLayout(False)
        Me.LicenseTab.ResumeLayout(False)
        Me.LicenseTab.PerformLayout()
        Me.ChangelogTab.ResumeLayout(False)
        Me.ChangelogTab.PerformLayout()
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.HeaderBorderPanel.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents LicenseTab As System.Windows.Forms.TabPage
    Friend WithEvents LicenseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChangelogTab As System.Windows.Forms.TabPage
    Friend WithEvents ChangelogTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MainTooltip As ToolTip
    Friend WithEvents LanguagePadLabel As Label
    Friend WithEvents HeaderBorderPanel As TundraLib.DoubleBufferedPanel
    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents VersionLabel As Label
    Friend WithEvents HeaderPanel As TundraLib.DoubleBufferedPanel
End Class
