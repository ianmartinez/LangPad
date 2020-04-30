<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NotebookEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotebookEditor))
        Me.MainTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DocumentToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.ListBoxContainerPanel = New LangPadSupport.DoubleBufferedPanel()
        Me.PagesListBox = New System.Windows.Forms.ListBox()
        Me.DocumentToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PageUpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PageDownToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RemoveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DuplicateToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExportToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InfoTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.LanguageTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PropertiesTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.GoButtonPanel = New System.Windows.Forms.Panel()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.PagesTab = New System.Windows.Forms.TabPage()
        Me.PropertiesTab = New System.Windows.Forms.TabPage()
        Me.DocumentToolStripContainer.ContentPanel.SuspendLayout()
        Me.DocumentToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.DocumentToolStripContainer.SuspendLayout()
        Me.ListBoxContainerPanel.SuspendLayout()
        Me.DocumentToolStrip.SuspendLayout()
        Me.PropertiesTableLayoutPanel.SuspendLayout()
        Me.GoButtonPanel.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.PagesTab.SuspendLayout()
        Me.PropertiesTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'DocumentToolStripContainer
        '
        '
        'DocumentToolStripContainer.BottomToolStripPanel
        '
        '
        'DocumentToolStripContainer.ContentPanel
        '
        Me.DocumentToolStripContainer.ContentPanel.Controls.Add(Me.ListBoxContainerPanel)
        Me.DocumentToolStripContainer.ContentPanel.Size = New System.Drawing.Size(328, 394)
        Me.DocumentToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'DocumentToolStripContainer.LeftToolStripPanel
        '
        Me.DocumentToolStripContainer.Location = New System.Drawing.Point(1, 1)
        Me.DocumentToolStripContainer.Name = "DocumentToolStripContainer"
        '
        'DocumentToolStripContainer.RightToolStripPanel
        '
        Me.DocumentToolStripContainer.Size = New System.Drawing.Size(328, 435)
        Me.DocumentToolStripContainer.TabIndex = 81
        Me.DocumentToolStripContainer.Text = "MainToolStripContainer"
        '
        'DocumentToolStripContainer.TopToolStripPanel
        '
        Me.DocumentToolStripContainer.TopToolStripPanel.Controls.Add(Me.DocumentToolStrip)
        '
        'ListBoxContainerPanel
        '
        Me.ListBoxContainerPanel.BackColor = System.Drawing.Color.Transparent
        Me.ListBoxContainerPanel.Controls.Add(Me.PagesListBox)
        Me.ListBoxContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxContainerPanel.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxContainerPanel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.ListBoxContainerPanel.Name = "ListBoxContainerPanel"
        Me.ListBoxContainerPanel.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.ListBoxContainerPanel.Size = New System.Drawing.Size(328, 394)
        Me.ListBoxContainerPanel.TabIndex = 80
        '
        'PagesListBox
        '
        Me.PagesListBox.BackColor = System.Drawing.Color.White
        Me.PagesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PagesListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagesListBox.ForeColor = System.Drawing.Color.Black
        Me.PagesListBox.IntegralHeight = False
        Me.PagesListBox.ItemHeight = 20
        Me.PagesListBox.Location = New System.Drawing.Point(2, 0)
        Me.PagesListBox.Name = "PagesListBox"
        Me.PagesListBox.Size = New System.Drawing.Size(326, 394)
        Me.PagesListBox.TabIndex = 15
        '
        'DocumentToolStrip
        '
        Me.DocumentToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.DocumentToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DocumentToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.DocumentToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PageUpToolStripButton, Me.PageDownToolStripButton, Me.ToolStripSeparator1, Me.AddToolStripButton, Me.RemoveToolStripButton, Me.DuplicateToolStripButton, Me.ToolStripSeparator3, Me.RenameToolStripButton, Me.ToolStripSeparator2, Me.ImportToolStripButton, Me.ExportToolStripButton})
        Me.DocumentToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DocumentToolStrip.Name = "DocumentToolStrip"
        Me.DocumentToolStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.DocumentToolStrip.Size = New System.Drawing.Size(328, 41)
        Me.DocumentToolStrip.Stretch = True
        Me.DocumentToolStrip.TabIndex = 0
        '
        'PageUpToolStripButton
        '
        Me.PageUpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PageUpToolStripButton.Image = CType(resources.GetObject("PageUpToolStripButton.Image"), System.Drawing.Image)
        Me.PageUpToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PageUpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PageUpToolStripButton.Name = "PageUpToolStripButton"
        Me.PageUpToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.PageUpToolStripButton.Text = "Move Page Up"
        '
        'PageDownToolStripButton
        '
        Me.PageDownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PageDownToolStripButton.Image = CType(resources.GetObject("PageDownToolStripButton.Image"), System.Drawing.Image)
        Me.PageDownToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PageDownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PageDownToolStripButton.Name = "PageDownToolStripButton"
        Me.PageDownToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.PageDownToolStripButton.Text = "Move Page Down"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 41)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = CType(resources.GetObject("AddToolStripButton.Image"), System.Drawing.Image)
        Me.AddToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.AddToolStripButton.Text = "Add Page"
        '
        'RemoveToolStripButton
        '
        Me.RemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveToolStripButton.Image = CType(resources.GetObject("RemoveToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveToolStripButton.Name = "RemoveToolStripButton"
        Me.RemoveToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.RemoveToolStripButton.Text = "Remove Page"
        '
        'DuplicateToolStripButton
        '
        Me.DuplicateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DuplicateToolStripButton.Image = CType(resources.GetObject("DuplicateToolStripButton.Image"), System.Drawing.Image)
        Me.DuplicateToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DuplicateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DuplicateToolStripButton.Name = "DuplicateToolStripButton"
        Me.DuplicateToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DuplicateToolStripButton.Text = "Duplicate Page"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 41)
        '
        'RenameToolStripButton
        '
        Me.RenameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RenameToolStripButton.Image = CType(resources.GetObject("RenameToolStripButton.Image"), System.Drawing.Image)
        Me.RenameToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RenameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RenameToolStripButton.Name = "RenameToolStripButton"
        Me.RenameToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.RenameToolStripButton.Text = "Rename Page"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 41)
        '
        'ImportToolStripButton
        '
        Me.ImportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportToolStripButton.Image = CType(resources.GetObject("ImportToolStripButton.Image"), System.Drawing.Image)
        Me.ImportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportToolStripButton.Name = "ImportToolStripButton"
        Me.ImportToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ImportToolStripButton.Text = "Import Page"
        '
        'ExportToolStripButton
        '
        Me.ExportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportToolStripButton.Image = CType(resources.GetObject("ExportToolStripButton.Image"), System.Drawing.Image)
        Me.ExportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportToolStripButton.Name = "ExportToolStripButton"
        Me.ExportToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ExportToolStripButton.Text = "Export Page"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(23, 307)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(282, 20)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Notes:"
        '
        'InfoTextBox
        '
        Me.InfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoTextBox.Location = New System.Drawing.Point(23, 336)
        Me.InfoTextBox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.InfoTextBox.Multiline = True
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InfoTextBox.Size = New System.Drawing.Size(282, 89)
        Me.InfoTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(23, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Website:"
        '
        'GoButton
        '
        Me.GoButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.GoButton.Location = New System.Drawing.Point(188, 0)
        Me.GoButton.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.GoButton.MinimumSize = New System.Drawing.Size(80, 0)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(94, 35)
        Me.GoButton.TabIndex = 79
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebsiteTextBox.Location = New System.Drawing.Point(23, 231)
        Me.WebsiteTextBox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(282, 26)
        Me.WebsiteTextBox.TabIndex = 3
        '
        'LanguageTextBox
        '
        Me.LanguageTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LanguageTextBox.Location = New System.Drawing.Point(23, 103)
        Me.LanguageTextBox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.LanguageTextBox.Name = "LanguageTextBox"
        Me.LanguageTextBox.Size = New System.Drawing.Size(282, 26)
        Me.LanguageTextBox.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(23, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 20)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Language:"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AuthorTextBox.Location = New System.Drawing.Point(23, 167)
        Me.AuthorTextBox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(282, 26)
        Me.AuthorTextBox.TabIndex = 2
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleTextBox.Location = New System.Drawing.Point(23, 39)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(282, 26)
        Me.TitleTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(23, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Author:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(23, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Title:"
        '
        'PropertiesTableLayoutPanel
        '
        Me.PropertiesTableLayoutPanel.ColumnCount = 1
        Me.PropertiesTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.GoButtonPanel, 0, 10)
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.WebsiteTextBox, 0, 9)
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.InfoTextBox, 0, 12)
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.Label4, 0, 11)
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.LanguageTextBox, 0, 4)
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.Label1, 0, 0)
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.Label3, 0, 8)
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.TitleTextBox, 0, 1)
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.Label5, 0, 3)
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.Label2, 0, 5)
        Me.PropertiesTableLayoutPanel.Controls.Add(Me.AuthorTextBox, 0, 6)
        Me.PropertiesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertiesTableLayoutPanel.Location = New System.Drawing.Point(1, 1)
        Me.PropertiesTableLayoutPanel.Name = "PropertiesTableLayoutPanel"
        Me.PropertiesTableLayoutPanel.Padding = New System.Windows.Forms.Padding(20, 4, 20, 4)
        Me.PropertiesTableLayoutPanel.RowCount = 13
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTableLayoutPanel.Size = New System.Drawing.Size(328, 435)
        Me.PropertiesTableLayoutPanel.TabIndex = 82
        '
        'GoButtonPanel
        '
        Me.GoButtonPanel.Controls.Add(Me.GoButton)
        Me.GoButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GoButtonPanel.Location = New System.Drawing.Point(23, 263)
        Me.GoButtonPanel.Name = "GoButtonPanel"
        Me.GoButtonPanel.Size = New System.Drawing.Size(282, 35)
        Me.GoButtonPanel.TabIndex = 16
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.PagesTab)
        Me.MainTabControl.Controls.Add(Me.PropertiesTab)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(340, 470)
        Me.MainTabControl.TabIndex = 84
        '
        'PagesTab
        '
        Me.PagesTab.Controls.Add(Me.DocumentToolStripContainer)
        Me.PagesTab.Location = New System.Drawing.Point(4, 29)
        Me.PagesTab.Name = "PagesTab"
        Me.PagesTab.Padding = New System.Windows.Forms.Padding(1, 1, 3, 1)
        Me.PagesTab.Size = New System.Drawing.Size(332, 437)
        Me.PagesTab.TabIndex = 1
        Me.PagesTab.Text = "Pages"
        Me.PagesTab.UseVisualStyleBackColor = True
        '
        'PropertiesTab
        '
        Me.PropertiesTab.Controls.Add(Me.PropertiesTableLayoutPanel)
        Me.PropertiesTab.Location = New System.Drawing.Point(4, 29)
        Me.PropertiesTab.Name = "PropertiesTab"
        Me.PropertiesTab.Padding = New System.Windows.Forms.Padding(1, 1, 3, 1)
        Me.PropertiesTab.Size = New System.Drawing.Size(332, 437)
        Me.PropertiesTab.TabIndex = 0
        Me.PropertiesTab.Text = "Properties"
        Me.PropertiesTab.UseVisualStyleBackColor = True
        '
        'NotebookEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainTabControl)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(340, 470)
        Me.Name = "NotebookEditor"
        Me.Size = New System.Drawing.Size(340, 470)
        Me.DocumentToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.DocumentToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.DocumentToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.DocumentToolStripContainer.ResumeLayout(False)
        Me.DocumentToolStripContainer.PerformLayout()
        Me.ListBoxContainerPanel.ResumeLayout(False)
        Me.DocumentToolStrip.ResumeLayout(False)
        Me.DocumentToolStrip.PerformLayout()
        Me.PropertiesTableLayoutPanel.ResumeLayout(False)
        Me.PropertiesTableLayoutPanel.PerformLayout()
        Me.GoButtonPanel.ResumeLayout(False)
        Me.MainTabControl.ResumeLayout(False)
        Me.PagesTab.ResumeLayout(False)
        Me.PropertiesTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PagesListBox As System.Windows.Forms.ListBox
    Friend WithEvents MainTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxContainerPanel As LangPadSupport.DoubleBufferedPanel
    Friend WithEvents PageUpToolStripButton As ToolStripButton
    Friend WithEvents PageDownToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddToolStripButton As ToolStripButton
    Friend WithEvents RemoveToolStripButton As ToolStripButton
    Friend WithEvents DuplicateToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents RenameToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ImportToolStripButton As ToolStripButton
    Friend WithEvents ExportToolStripButton As ToolStripButton
    Friend WithEvents DocumentToolStrip As ToolStrip
    Friend WithEvents DocumentToolStripContainer As ToolStripContainer
    Friend WithEvents GoButton As Button
    Friend WithEvents LanguageTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PropertiesTableLayoutPanel As TableLayoutPanel
    Friend WithEvents GoButtonPanel As Panel
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents PropertiesTab As TabPage
    Friend WithEvents PagesTab As TabPage
End Class
