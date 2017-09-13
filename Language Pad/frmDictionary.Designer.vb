<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDictionary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDictionary))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tcSymbols = New System.Windows.Forms.TabControl()
        Me.ConsonantsTabPage = New System.Windows.Forms.TabPage()
        Me.ConsonantsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AffricatesTabPage = New System.Windows.Forms.TabPage()
        Me.AffricatesLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.VowelsTabPage = New System.Windows.Forms.TabPage()
        Me.VowelsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AccentsTabPage = New System.Windows.Forms.TabPage()
        Me.AccentsLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToneIntonationTabPage = New System.Windows.Forms.TabPage()
        Me.ToneIntonationLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.OtherTabPage = New System.Windows.Forms.TabPage()
        Me.OtherLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CommonTabPage = New System.Windows.Forms.TabPage()
        Me.CommonLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CustomTabPage = New System.Windows.Forms.TabPage()
        Me.CustomLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.tcNotebook = New System.Windows.Forms.TabControl()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.DocumentToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.StylizedPanel2 = New Tundra.StylizedPanel()
        Me.lbSections = New System.Windows.Forms.ListBox()
        Me.PageNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtSectionName = New System.Windows.Forms.ToolStripTextBox()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SymbolsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomSymbolsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AccentMarkToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RemoveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MoveLeftToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MoveRightToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddSectionToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RemoveSectionToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tcSymbols.SuspendLayout()
        Me.ConsonantsTabPage.SuspendLayout()
        Me.AffricatesTabPage.SuspendLayout()
        Me.VowelsTabPage.SuspendLayout()
        Me.AccentsTabPage.SuspendLayout()
        Me.ToneIntonationTabPage.SuspendLayout()
        Me.OtherTabPage.SuspendLayout()
        Me.CommonTabPage.SuspendLayout()
        Me.CustomTabPage.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.DocumentToolStripContainer.ContentPanel.SuspendLayout()
        Me.DocumentToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.DocumentToolStripContainer.SuspendLayout()
        Me.StylizedPanel2.SuspendLayout()
        Me.PageNameToolStrip.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tcSymbols)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(6, 6, 0, 0)
        Me.SplitContainer1.Size = New System.Drawing.Size(2015, 1409)
        Me.SplitContainer1.SplitterDistance = 124
        Me.SplitContainer1.TabIndex = 74
        '
        'tcSymbols
        '
        Me.tcSymbols.Controls.Add(Me.ConsonantsTabPage)
        Me.tcSymbols.Controls.Add(Me.AffricatesTabPage)
        Me.tcSymbols.Controls.Add(Me.VowelsTabPage)
        Me.tcSymbols.Controls.Add(Me.AccentsTabPage)
        Me.tcSymbols.Controls.Add(Me.ToneIntonationTabPage)
        Me.tcSymbols.Controls.Add(Me.OtherTabPage)
        Me.tcSymbols.Controls.Add(Me.CommonTabPage)
        Me.tcSymbols.Controls.Add(Me.CustomTabPage)
        Me.tcSymbols.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcSymbols.Location = New System.Drawing.Point(0, 4)
        Me.tcSymbols.Margin = New System.Windows.Forms.Padding(4)
        Me.tcSymbols.Name = "tcSymbols"
        Me.tcSymbols.SelectedIndex = 0
        Me.tcSymbols.Size = New System.Drawing.Size(2015, 120)
        Me.tcSymbols.TabIndex = 73
        '
        'ConsonantsTabPage
        '
        Me.ConsonantsTabPage.Controls.Add(Me.ConsonantsLayoutPanel)
        Me.ConsonantsTabPage.Location = New System.Drawing.Point(8, 39)
        Me.ConsonantsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsonantsTabPage.Name = "ConsonantsTabPage"
        Me.ConsonantsTabPage.Size = New System.Drawing.Size(1999, 73)
        Me.ConsonantsTabPage.TabIndex = 0
        Me.ConsonantsTabPage.Text = "Consonants"
        Me.ConsonantsTabPage.UseVisualStyleBackColor = True
        '
        'ConsonantsLayoutPanel
        '
        Me.ConsonantsLayoutPanel.AutoScroll = True
        Me.ConsonantsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(15, 5)
        Me.ConsonantsLayoutPanel.AutoSize = True
        Me.ConsonantsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsonantsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ConsonantsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ConsonantsLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.ConsonantsLayoutPanel.Name = "ConsonantsLayoutPanel"
        Me.ConsonantsLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.ConsonantsLayoutPanel.Size = New System.Drawing.Size(1999, 73)
        Me.ConsonantsLayoutPanel.TabIndex = 7
        '
        'AffricatesTabPage
        '
        Me.AffricatesTabPage.Controls.Add(Me.AffricatesLayoutPanel)
        Me.AffricatesTabPage.Location = New System.Drawing.Point(8, 39)
        Me.AffricatesTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.AffricatesTabPage.Name = "AffricatesTabPage"
        Me.AffricatesTabPage.Size = New System.Drawing.Size(1724, 73)
        Me.AffricatesTabPage.TabIndex = 5
        Me.AffricatesTabPage.Text = "Affricates"
        Me.AffricatesTabPage.UseVisualStyleBackColor = True
        '
        'AffricatesLayoutPanel
        '
        Me.AffricatesLayoutPanel.AutoScroll = True
        Me.AffricatesLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AffricatesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AffricatesLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.AffricatesLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AffricatesLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.AffricatesLayoutPanel.Name = "AffricatesLayoutPanel"
        Me.AffricatesLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.AffricatesLayoutPanel.Size = New System.Drawing.Size(1724, 73)
        Me.AffricatesLayoutPanel.TabIndex = 8
        '
        'VowelsTabPage
        '
        Me.VowelsTabPage.Controls.Add(Me.VowelsLayoutPanel)
        Me.VowelsTabPage.Location = New System.Drawing.Point(8, 39)
        Me.VowelsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.VowelsTabPage.Name = "VowelsTabPage"
        Me.VowelsTabPage.Size = New System.Drawing.Size(1724, 73)
        Me.VowelsTabPage.TabIndex = 1
        Me.VowelsTabPage.Text = "Vowels"
        Me.VowelsTabPage.UseVisualStyleBackColor = True
        '
        'VowelsLayoutPanel
        '
        Me.VowelsLayoutPanel.AutoScroll = True
        Me.VowelsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.VowelsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VowelsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.VowelsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.VowelsLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.VowelsLayoutPanel.Name = "VowelsLayoutPanel"
        Me.VowelsLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.VowelsLayoutPanel.Size = New System.Drawing.Size(1724, 73)
        Me.VowelsLayoutPanel.TabIndex = 8
        '
        'AccentsTabPage
        '
        Me.AccentsTabPage.Controls.Add(Me.AccentsLayoutPanel)
        Me.AccentsTabPage.Location = New System.Drawing.Point(8, 39)
        Me.AccentsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.AccentsTabPage.Name = "AccentsTabPage"
        Me.AccentsTabPage.Size = New System.Drawing.Size(1724, 73)
        Me.AccentsTabPage.TabIndex = 3
        Me.AccentsTabPage.Text = "Accents"
        Me.AccentsTabPage.UseVisualStyleBackColor = True
        '
        'AccentsLayoutPanel
        '
        Me.AccentsLayoutPanel.AutoScroll = True
        Me.AccentsLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.AccentsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccentsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.AccentsLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.AccentsLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.AccentsLayoutPanel.Name = "AccentsLayoutPanel"
        Me.AccentsLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.AccentsLayoutPanel.Size = New System.Drawing.Size(1724, 73)
        Me.AccentsLayoutPanel.TabIndex = 9
        '
        'ToneIntonationTabPage
        '
        Me.ToneIntonationTabPage.Controls.Add(Me.ToneIntonationLayoutPanel)
        Me.ToneIntonationTabPage.Location = New System.Drawing.Point(8, 39)
        Me.ToneIntonationTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.ToneIntonationTabPage.Name = "ToneIntonationTabPage"
        Me.ToneIntonationTabPage.Size = New System.Drawing.Size(1724, 73)
        Me.ToneIntonationTabPage.TabIndex = 4
        Me.ToneIntonationTabPage.Text = "Tone & Intonation"
        Me.ToneIntonationTabPage.UseVisualStyleBackColor = True
        '
        'ToneIntonationLayoutPanel
        '
        Me.ToneIntonationLayoutPanel.AutoScroll = True
        Me.ToneIntonationLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.ToneIntonationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToneIntonationLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ToneIntonationLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ToneIntonationLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.ToneIntonationLayoutPanel.Name = "ToneIntonationLayoutPanel"
        Me.ToneIntonationLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.ToneIntonationLayoutPanel.Size = New System.Drawing.Size(1724, 73)
        Me.ToneIntonationLayoutPanel.TabIndex = 10
        '
        'OtherTabPage
        '
        Me.OtherTabPage.Controls.Add(Me.OtherLayoutPanel)
        Me.OtherTabPage.Location = New System.Drawing.Point(8, 39)
        Me.OtherTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.OtherTabPage.Name = "OtherTabPage"
        Me.OtherTabPage.Size = New System.Drawing.Size(1724, 73)
        Me.OtherTabPage.TabIndex = 2
        Me.OtherTabPage.Text = "Other"
        Me.OtherTabPage.UseVisualStyleBackColor = True
        '
        'OtherLayoutPanel
        '
        Me.OtherLayoutPanel.AutoScroll = True
        Me.OtherLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.OtherLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OtherLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.OtherLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.OtherLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.OtherLayoutPanel.Name = "OtherLayoutPanel"
        Me.OtherLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.OtherLayoutPanel.Size = New System.Drawing.Size(1724, 73)
        Me.OtherLayoutPanel.TabIndex = 8
        '
        'CommonTabPage
        '
        Me.CommonTabPage.Controls.Add(Me.CommonLayoutPanel)
        Me.CommonTabPage.Location = New System.Drawing.Point(8, 39)
        Me.CommonTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.CommonTabPage.Name = "CommonTabPage"
        Me.CommonTabPage.Size = New System.Drawing.Size(1724, 73)
        Me.CommonTabPage.TabIndex = 7
        Me.CommonTabPage.Text = "Common"
        Me.CommonTabPage.UseVisualStyleBackColor = True
        '
        'CommonLayoutPanel
        '
        Me.CommonLayoutPanel.AutoScroll = True
        Me.CommonLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.CommonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommonLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.CommonLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.CommonLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.CommonLayoutPanel.Name = "CommonLayoutPanel"
        Me.CommonLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.CommonLayoutPanel.Size = New System.Drawing.Size(1724, 73)
        Me.CommonLayoutPanel.TabIndex = 9
        '
        'CustomTabPage
        '
        Me.CustomTabPage.Controls.Add(Me.CustomLayoutPanel)
        Me.CustomTabPage.Location = New System.Drawing.Point(8, 39)
        Me.CustomTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomTabPage.Name = "CustomTabPage"
        Me.CustomTabPage.Size = New System.Drawing.Size(1724, 73)
        Me.CustomTabPage.TabIndex = 6
        Me.CustomTabPage.Text = "Custom"
        Me.CustomTabPage.UseVisualStyleBackColor = True
        '
        'CustomLayoutPanel
        '
        Me.CustomLayoutPanel.AutoScroll = True
        Me.CustomLayoutPanel.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.CustomLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.CustomLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.CustomLayoutPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.CustomLayoutPanel.Name = "CustomLayoutPanel"
        Me.CustomLayoutPanel.Padding = New System.Windows.Forms.Padding(8, 8, 0, 8)
        Me.CustomLayoutPanel.Size = New System.Drawing.Size(1724, 73)
        Me.CustomLayoutPanel.TabIndex = 9
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(6, 6)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.tcNotebook)
        Me.SplitContainer2.Panel1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.StylizedPanel1)
        Me.SplitContainer2.Panel2MinSize = 235
        Me.SplitContainer2.Size = New System.Drawing.Size(2009, 1275)
        Me.SplitContainer2.SplitterDistance = 1661
        Me.SplitContainer2.TabIndex = 4
        '
        'tcNotebook
        '
        Me.tcNotebook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcNotebook.Location = New System.Drawing.Point(0, 4)
        Me.tcNotebook.Margin = New System.Windows.Forms.Padding(4)
        Me.tcNotebook.Name = "tcNotebook"
        Me.tcNotebook.SelectedIndex = 0
        Me.tcNotebook.Size = New System.Drawing.Size(1661, 1271)
        Me.tcNotebook.TabIndex = 73
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.AutoScroll = True
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.DocumentToolStripContainer)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Size = New System.Drawing.Size(344, 1275)
        Me.StylizedPanel1.Style = "Colors=~245|~245" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight" &
    " Color=$0"
        Me.StylizedPanel1.TabIndex = 13
        '
        'DocumentToolStripContainer
        '
        '
        'DocumentToolStripContainer.ContentPanel
        '
        Me.DocumentToolStripContainer.ContentPanel.Controls.Add(Me.StylizedPanel2)
        Me.DocumentToolStripContainer.ContentPanel.Size = New System.Drawing.Size(344, 1236)
        Me.DocumentToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.DocumentToolStripContainer.Name = "DocumentToolStripContainer"
        Me.DocumentToolStripContainer.Size = New System.Drawing.Size(344, 1275)
        Me.DocumentToolStripContainer.TabIndex = 82
        Me.DocumentToolStripContainer.Text = "ToolStripContainer1"
        '
        'DocumentToolStripContainer.TopToolStripPanel
        '
        Me.DocumentToolStripContainer.TopToolStripPanel.Controls.Add(Me.PageNameToolStrip)
        '
        'StylizedPanel2
        '
        Me.StylizedPanel2.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel2.Controls.Add(Me.lbSections)
        Me.StylizedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedPanel2.Location = New System.Drawing.Point(0, 0)
        Me.StylizedPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.StylizedPanel2.Name = "StylizedPanel2"
        Me.StylizedPanel2.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.StylizedPanel2.Size = New System.Drawing.Size(344, 1236)
        Me.StylizedPanel2.Style = "Colors=$1|$1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Col" &
    "or$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0"
        Me.StylizedPanel2.TabIndex = 80
        '
        'lbSections
        '
        Me.lbSections.BackColor = System.Drawing.Color.White
        Me.lbSections.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbSections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbSections.ForeColor = System.Drawing.Color.Black
        Me.lbSections.IntegralHeight = False
        Me.lbSections.ItemHeight = 25
        Me.lbSections.Location = New System.Drawing.Point(2, 0)
        Me.lbSections.Margin = New System.Windows.Forms.Padding(4)
        Me.lbSections.Name = "lbSections"
        Me.lbSections.Size = New System.Drawing.Size(342, 1236)
        Me.lbSections.TabIndex = 15
        '
        'PageNameToolStrip
        '
        Me.PageNameToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.PageNameToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PageNameToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.PageNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtSectionName})
        Me.PageNameToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.PageNameToolStrip.Name = "PageNameToolStrip"
        Me.PageNameToolStrip.Size = New System.Drawing.Size(344, 39)
        Me.PageNameToolStrip.Stretch = True
        Me.PageNameToolStrip.TabIndex = 16
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(99, 36)
        Me.ToolStripLabel1.Text = "Section:"
        '
        'txtSectionName
        '
        Me.txtSectionName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSectionName.Name = "txtSectionName"
        Me.txtSectionName.Size = New System.Drawing.Size(150, 39)
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Dictionary file (*.dict)|*.dict|CSV file (*.csv)|*.csv|Text files (*.txt)|*.txt|A" &
    "ll files (*.*)|*.*"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Dictionary file (*.dict)|*.dict|CSV file (*.csv)|*.csv|Text files (*.txt)|*.txt|A" &
    "ll files (*.*)|*.*"
        '
        'dlgFont
        '
        Me.dlgFont.ShowColor = True
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(2015, 1409)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.Size = New System.Drawing.Size(2015, 1472)
        Me.ToolStripContainer1.TabIndex = 75
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MainToolStrip)
        '
        'MainToolStrip
        '
        Me.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.SymbolsToolStripButton, Me.CustomSymbolsToolStripButton, Me.AccentMarkToolStripButton, Me.ToolStripSeparator2, Me.AddToolStripButton, Me.RemoveToolStripButton, Me.ToolStripSeparator3, Me.FontToolStripButton, Me.ToolStripSeparator4, Me.MoveLeftToolStripButton, Me.MoveRightToolStripButton, Me.ToolStripSeparator5, Me.AddSectionToolStripButton, Me.RemoveSectionToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(2015, 63)
        Me.MainToolStrip.Stretch = True
        Me.MainToolStrip.TabIndex = 1
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(67, 60)
        Me.NewToolStripButton.Text = "New"
        Me.NewToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(78, 60)
        Me.OpenToolStripButton.Text = "Open"
        Me.OpenToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(69, 60)
        Me.SaveToolStripButton.Text = "Save"
        Me.SaveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 63)
        '
        'SymbolsToolStripButton
        '
        Me.SymbolsToolStripButton.Image = CType(resources.GetObject("SymbolsToolStripButton.Image"), System.Drawing.Image)
        Me.SymbolsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SymbolsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SymbolsToolStripButton.Name = "SymbolsToolStripButton"
        Me.SymbolsToolStripButton.Size = New System.Drawing.Size(108, 60)
        Me.SymbolsToolStripButton.Text = "Symbols"
        Me.SymbolsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CustomSymbolsToolStripButton
        '
        Me.CustomSymbolsToolStripButton.Image = CType(resources.GetObject("CustomSymbolsToolStripButton.Image"), System.Drawing.Image)
        Me.CustomSymbolsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CustomSymbolsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CustomSymbolsToolStripButton.Name = "CustomSymbolsToolStripButton"
        Me.CustomSymbolsToolStripButton.Size = New System.Drawing.Size(197, 60)
        Me.CustomSymbolsToolStripButton.Text = "Custom Symbols"
        Me.CustomSymbolsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AccentMarkToolStripButton
        '
        Me.AccentMarkToolStripButton.Image = CType(resources.GetObject("AccentMarkToolStripButton.Image"), System.Drawing.Image)
        Me.AccentMarkToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AccentMarkToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AccentMarkToolStripButton.Name = "AccentMarkToolStripButton"
        Me.AccentMarkToolStripButton.Size = New System.Drawing.Size(152, 60)
        Me.AccentMarkToolStripButton.Text = "Accent Mark"
        Me.AccentMarkToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 63)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.Image = CType(resources.GetObject("AddToolStripButton.Image"), System.Drawing.Image)
        Me.AddToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(126, 60)
        Me.AddToolStripButton.Text = "Add Word"
        Me.AddToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RemoveToolStripButton
        '
        Me.RemoveToolStripButton.Image = CType(resources.GetObject("RemoveToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveToolStripButton.Name = "RemoveToolStripButton"
        Me.RemoveToolStripButton.Size = New System.Drawing.Size(169, 60)
        Me.RemoveToolStripButton.Text = "Remove Word"
        Me.RemoveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 63)
        '
        'FontToolStripButton
        '
        Me.FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), System.Drawing.Image)
        Me.FontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontToolStripButton.Name = "FontToolStripButton"
        Me.FontToolStripButton.Size = New System.Drawing.Size(67, 60)
        Me.FontToolStripButton.Text = "Font"
        Me.FontToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 63)
        '
        'MoveLeftToolStripButton
        '
        Me.MoveLeftToolStripButton.Image = CType(resources.GetObject("MoveLeftToolStripButton.Image"), System.Drawing.Image)
        Me.MoveLeftToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MoveLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MoveLeftToolStripButton.Name = "MoveLeftToolStripButton"
        Me.MoveLeftToolStripButton.Size = New System.Drawing.Size(115, 60)
        Me.MoveLeftToolStripButton.Text = "Shift Left"
        Me.MoveLeftToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MoveRightToolStripButton
        '
        Me.MoveRightToolStripButton.Image = CType(resources.GetObject("MoveRightToolStripButton.Image"), System.Drawing.Image)
        Me.MoveRightToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MoveRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MoveRightToolStripButton.Name = "MoveRightToolStripButton"
        Me.MoveRightToolStripButton.Size = New System.Drawing.Size(131, 60)
        Me.MoveRightToolStripButton.Text = "Shift Right"
        Me.MoveRightToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 63)
        '
        'AddSectionToolStripButton
        '
        Me.AddSectionToolStripButton.Image = CType(resources.GetObject("AddSectionToolStripButton.Image"), System.Drawing.Image)
        Me.AddSectionToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddSectionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddSectionToolStripButton.Name = "AddSectionToolStripButton"
        Me.AddSectionToolStripButton.Size = New System.Drawing.Size(148, 60)
        Me.AddSectionToolStripButton.Text = "Add Section"
        Me.AddSectionToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RemoveSectionToolStripButton
        '
        Me.RemoveSectionToolStripButton.Image = CType(resources.GetObject("RemoveSectionToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveSectionToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveSectionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveSectionToolStripButton.Name = "RemoveSectionToolStripButton"
        Me.RemoveSectionToolStripButton.Size = New System.Drawing.Size(191, 60)
        Me.RemoveSectionToolStripButton.Text = "Remove Section"
        Me.RemoveSectionToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2015, 1472)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmDictionary"
        Me.ShowIcon = False
        Me.Text = "Dictionary"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tcSymbols.ResumeLayout(False)
        Me.ConsonantsTabPage.ResumeLayout(False)
        Me.ConsonantsTabPage.PerformLayout()
        Me.AffricatesTabPage.ResumeLayout(False)
        Me.VowelsTabPage.ResumeLayout(False)
        Me.AccentsTabPage.ResumeLayout(False)
        Me.ToneIntonationTabPage.ResumeLayout(False)
        Me.OtherTabPage.ResumeLayout(False)
        Me.CommonTabPage.ResumeLayout(False)
        Me.CustomTabPage.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.StylizedPanel1.ResumeLayout(False)
        Me.DocumentToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.DocumentToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.DocumentToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.DocumentToolStripContainer.ResumeLayout(False)
        Me.DocumentToolStripContainer.PerformLayout()
        Me.StylizedPanel2.ResumeLayout(False)
        Me.PageNameToolStrip.ResumeLayout(False)
        Me.PageNameToolStrip.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tcSymbols As TabControl
    Friend WithEvents ConsonantsTabPage As TabPage
    Friend WithEvents ConsonantsLayoutPanel As FlowLayoutPanel
    Friend WithEvents AffricatesTabPage As TabPage
    Friend WithEvents AffricatesLayoutPanel As FlowLayoutPanel
    Friend WithEvents VowelsTabPage As TabPage
    Friend WithEvents VowelsLayoutPanel As FlowLayoutPanel
    Friend WithEvents AccentsTabPage As TabPage
    Friend WithEvents AccentsLayoutPanel As FlowLayoutPanel
    Friend WithEvents ToneIntonationTabPage As TabPage
    Friend WithEvents ToneIntonationLayoutPanel As FlowLayoutPanel
    Friend WithEvents OtherTabPage As TabPage
    Friend WithEvents OtherLayoutPanel As FlowLayoutPanel
    Friend WithEvents CommonTabPage As TabPage
    Friend WithEvents CommonLayoutPanel As FlowLayoutPanel
    Friend WithEvents CustomTabPage As TabPage
    Friend WithEvents CustomLayoutPanel As FlowLayoutPanel
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents dlgFont As FontDialog
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SymbolsToolStripButton As ToolStripButton
    Friend WithEvents CustomSymbolsToolStripButton As ToolStripButton
    Friend WithEvents AccentMarkToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FontToolStripButton As ToolStripButton
    Friend WithEvents AddToolStripButton As ToolStripButton
    Friend WithEvents RemoveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents tcNotebook As TabControl
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents MoveLeftToolStripButton As ToolStripButton
    Friend WithEvents MoveRightToolStripButton As ToolStripButton
    Friend WithEvents DocumentToolStripContainer As ToolStripContainer
    Friend WithEvents StylizedPanel2 As Tundra.StylizedPanel
    Friend WithEvents lbSections As ListBox
    Friend WithEvents PageNameToolStrip As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtSectionName As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AddSectionToolStripButton As ToolStripButton
    Friend WithEvents RemoveSectionToolStripButton As ToolStripButton
End Class
