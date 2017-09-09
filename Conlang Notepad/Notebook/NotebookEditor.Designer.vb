<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotebookEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotebookEditor))
        Me.lbPages = New System.Windows.Forms.ListBox()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGoWebsite = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel2 = New Tundra.DoubleBufferedPanel()
        Me.btnDictionary = New Tundra.StylizedButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEmbed = New System.Windows.Forms.CheckBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
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
        Me.DocumentToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.DoubleBufferedPanel2.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.DocumentToolStrip.SuspendLayout()
        Me.DocumentToolStripContainer.ContentPanel.SuspendLayout()
        Me.DocumentToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.DocumentToolStripContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbPages
        '
        Me.lbPages.BackColor = System.Drawing.Color.White
        Me.lbPages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPages.ForeColor = System.Drawing.Color.Black
        Me.lbPages.IntegralHeight = False
        Me.lbPages.ItemHeight = 25
        Me.lbPages.Location = New System.Drawing.Point(2, 0)
        Me.lbPages.Margin = New System.Windows.Forms.Padding(4)
        Me.lbPages.Name = "lbPages"
        Me.lbPages.Size = New System.Drawing.Size(522, 466)
        Me.lbPages.TabIndex = 15
        '
        'btnGoWebsite
        '
        Me.btnGoWebsite.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGoWebsite.BackColor = System.Drawing.Color.Transparent
        Me.btnGoWebsite.BackgroundImage = CType(resources.GetObject("btnGoWebsite.BackgroundImage"), System.Drawing.Image)
        Me.btnGoWebsite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGoWebsite.FlatAppearance.BorderSize = 0
        Me.btnGoWebsite.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnGoWebsite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGoWebsite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGoWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoWebsite.ForeColor = System.Drawing.Color.Black
        Me.btnGoWebsite.Image = CType(resources.GetObject("btnGoWebsite.Image"), System.Drawing.Image)
        Me.btnGoWebsite.Location = New System.Drawing.Point(479, 137)
        Me.btnGoWebsite.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGoWebsite.Name = "btnGoWebsite"
        Me.btnGoWebsite.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnGoWebsite.Size = New System.Drawing.Size(40, 38)
        Me.btnGoWebsite.Style = resources.GetString("btnGoWebsite.Style")
        Me.btnGoWebsite.TabIndex = 4
        Me.ttMain.SetToolTip(Me.btnGoWebsite, "Launch in web browser")
        Me.btnGoWebsite.UseCompatibleTextRendering = True
        Me.btnGoWebsite.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel2
        '
        Me.DoubleBufferedPanel2.BackColor = System.Drawing.Color.Transparent
        Me.DoubleBufferedPanel2.Controls.Add(Me.btnDictionary)
        Me.DoubleBufferedPanel2.Controls.Add(Me.Label4)
        Me.DoubleBufferedPanel2.Controls.Add(Me.txtInfo)
        Me.DoubleBufferedPanel2.Controls.Add(Me.btnGoWebsite)
        Me.DoubleBufferedPanel2.Controls.Add(Me.Label3)
        Me.DoubleBufferedPanel2.Controls.Add(Me.cbEmbed)
        Me.DoubleBufferedPanel2.Controls.Add(Me.txtAuthor)
        Me.DoubleBufferedPanel2.Controls.Add(Me.txtWebsite)
        Me.DoubleBufferedPanel2.Controls.Add(Me.txtTitle)
        Me.DoubleBufferedPanel2.Controls.Add(Me.Label2)
        Me.DoubleBufferedPanel2.Controls.Add(Me.Label1)
        Me.DoubleBufferedPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DoubleBufferedPanel2.Location = New System.Drawing.Point(0, 0)
        Me.DoubleBufferedPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.DoubleBufferedPanel2.Name = "DoubleBufferedPanel2"
        Me.DoubleBufferedPanel2.Padding = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel2.Size = New System.Drawing.Size(524, 403)
        Me.DoubleBufferedPanel2.TabIndex = 78
        '
        'btnDictionary
        '
        Me.btnDictionary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDictionary.BackColor = System.Drawing.Color.Transparent
        Me.btnDictionary.BackgroundImage = CType(resources.GetObject("btnDictionary.BackgroundImage"), System.Drawing.Image)
        Me.btnDictionary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDictionary.FlatAppearance.BorderSize = 0
        Me.btnDictionary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDictionary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDictionary.ForeColor = System.Drawing.Color.Black
        Me.btnDictionary.Location = New System.Drawing.Point(5, 348)
        Me.btnDictionary.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDictionary.Name = "btnDictionary"
        Me.btnDictionary.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnDictionary.Size = New System.Drawing.Size(514, 49)
        Me.btnDictionary.Style = resources.GetString("btnDictionary.Style")
        Me.btnDictionary.TabIndex = 6
        Me.btnDictionary.Text = "Dictionary"
        Me.btnDictionary.UseCompatibleTextRendering = True
        Me.btnDictionary.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 185)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 25)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Info:"
        '
        'txtInfo
        '
        Me.txtInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtInfo.Location = New System.Drawing.Point(110, 179)
        Me.txtInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo.Size = New System.Drawing.Size(408, 154)
        Me.txtInfo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Website:"
        '
        'cbEmbed
        '
        Me.cbEmbed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbEmbed.AutoSize = True
        Me.cbEmbed.Checked = True
        Me.cbEmbed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbEmbed.Location = New System.Drawing.Point(11, 6)
        Me.cbEmbed.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEmbed.Name = "cbEmbed"
        Me.cbEmbed.Size = New System.Drawing.Size(271, 29)
        Me.cbEmbed.TabIndex = 0
        Me.cbEmbed.Text = "Embed custom symbols"
        Me.cbEmbed.UseVisualStyleBackColor = True
        '
        'txtAuthor
        '
        Me.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAuthor.Location = New System.Drawing.Point(110, 92)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(408, 31)
        Me.txtAuthor.TabIndex = 2
        '
        'txtWebsite
        '
        Me.txtWebsite.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtWebsite.Location = New System.Drawing.Point(110, 137)
        Me.txtWebsite.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(361, 31)
        Me.txtWebsite.TabIndex = 3
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTitle.Location = New System.Drawing.Point(110, 48)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(408, 31)
        Me.txtTitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Author:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Title:"
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.lbPages)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.StylizedPanel1.Size = New System.Drawing.Size(524, 466)
        Me.StylizedPanel1.Style = "Colors=$1|$1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Col" &
    "or$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0"
        Me.StylizedPanel1.TabIndex = 80
        '
        'DocumentToolStrip
        '
        Me.DocumentToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.DocumentToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DocumentToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.DocumentToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PageUpToolStripButton, Me.PageDownToolStripButton, Me.ToolStripSeparator1, Me.AddToolStripButton, Me.RemoveToolStripButton, Me.DuplicateToolStripButton, Me.ToolStripSeparator3, Me.RenameToolStripButton, Me.ToolStripSeparator2, Me.ImportToolStripButton, Me.ExportToolStripButton})
        Me.DocumentToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.DocumentToolStrip.Name = "DocumentToolStrip"
        Me.DocumentToolStrip.Size = New System.Drawing.Size(245, 31)
        Me.DocumentToolStrip.TabIndex = 0
        '
        'PageUpToolStripButton
        '
        Me.PageUpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PageUpToolStripButton.Image = CType(resources.GetObject("PageUpToolStripButton.Image"), System.Drawing.Image)
        Me.PageUpToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PageUpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PageUpToolStripButton.Name = "PageUpToolStripButton"
        Me.PageUpToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.PageUpToolStripButton.Text = "Move Page Up"
        '
        'PageDownToolStripButton
        '
        Me.PageDownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PageDownToolStripButton.Image = CType(resources.GetObject("PageDownToolStripButton.Image"), System.Drawing.Image)
        Me.PageDownToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PageDownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PageDownToolStripButton.Name = "PageDownToolStripButton"
        Me.PageDownToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.PageDownToolStripButton.Text = "Move Page Down"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = CType(resources.GetObject("AddToolStripButton.Image"), System.Drawing.Image)
        Me.AddToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.AddToolStripButton.Text = "Add Page"
        '
        'RemoveToolStripButton
        '
        Me.RemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveToolStripButton.Image = CType(resources.GetObject("RemoveToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveToolStripButton.Name = "RemoveToolStripButton"
        Me.RemoveToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.RemoveToolStripButton.Text = "Remove Page"
        '
        'DuplicateToolStripButton
        '
        Me.DuplicateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DuplicateToolStripButton.Image = CType(resources.GetObject("DuplicateToolStripButton.Image"), System.Drawing.Image)
        Me.DuplicateToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DuplicateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DuplicateToolStripButton.Name = "DuplicateToolStripButton"
        Me.DuplicateToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.DuplicateToolStripButton.Text = "Duplicate Page"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'RenameToolStripButton
        '
        Me.RenameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RenameToolStripButton.Image = CType(resources.GetObject("RenameToolStripButton.Image"), System.Drawing.Image)
        Me.RenameToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RenameToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RenameToolStripButton.Name = "RenameToolStripButton"
        Me.RenameToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.RenameToolStripButton.Text = "Rename Page"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ImportToolStripButton
        '
        Me.ImportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportToolStripButton.Image = CType(resources.GetObject("ImportToolStripButton.Image"), System.Drawing.Image)
        Me.ImportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportToolStripButton.Name = "ImportToolStripButton"
        Me.ImportToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.ImportToolStripButton.Text = "Import Page"
        '
        'ExportToolStripButton
        '
        Me.ExportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportToolStripButton.Image = CType(resources.GetObject("ExportToolStripButton.Image"), System.Drawing.Image)
        Me.ExportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportToolStripButton.Name = "ExportToolStripButton"
        Me.ExportToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.ExportToolStripButton.Text = "Export Page"
        '
        'DocumentToolStripContainer
        '
        '
        'DocumentToolStripContainer.ContentPanel
        '
        Me.DocumentToolStripContainer.ContentPanel.Controls.Add(Me.StylizedPanel1)
        Me.DocumentToolStripContainer.ContentPanel.Size = New System.Drawing.Size(524, 466)
        Me.DocumentToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentToolStripContainer.Location = New System.Drawing.Point(0, 403)
        Me.DocumentToolStripContainer.Name = "DocumentToolStripContainer"
        Me.DocumentToolStripContainer.Size = New System.Drawing.Size(524, 497)
        Me.DocumentToolStripContainer.TabIndex = 81
        Me.DocumentToolStripContainer.Text = "ToolStripContainer1"
        '
        'DocumentToolStripContainer.TopToolStripPanel
        '
        Me.DocumentToolStripContainer.TopToolStripPanel.Controls.Add(Me.DocumentToolStrip)
        '
        'NotebookEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.DocumentToolStripContainer)
        Me.Controls.Add(Me.DoubleBufferedPanel2)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(524, 0)
        Me.Name = "NotebookEditor"
        Me.Size = New System.Drawing.Size(524, 900)
        Me.DoubleBufferedPanel2.ResumeLayout(False)
        Me.DoubleBufferedPanel2.PerformLayout()
        Me.StylizedPanel1.ResumeLayout(False)
        Me.DocumentToolStrip.ResumeLayout(False)
        Me.DocumentToolStrip.PerformLayout()
        Me.DocumentToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.DocumentToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.DocumentToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.DocumentToolStripContainer.ResumeLayout(False)
        Me.DocumentToolStripContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents lbPages As System.Windows.Forms.ListBox
    Friend WithEvents DoubleBufferedPanel2 As Tundra.DoubleBufferedPanel
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents cbEmbed As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnGoWebsite As Tundra.StylizedButton
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
    Friend WithEvents btnDictionary As Tundra.StylizedButton
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
End Class
