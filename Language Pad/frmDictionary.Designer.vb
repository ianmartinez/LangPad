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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dgvDictionary = New System.Windows.Forms.DataGridView()
        Me.Word = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pronunciation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Definition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.pnlFindReplace = New Tundra.StylizedPanel()
        Me.cbStartsWith = New System.Windows.Forms.CheckBox()
        Me.rbDefinition = New System.Windows.Forms.RadioButton()
        Me.rbWord = New System.Windows.Forms.RadioButton()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnFind = New Tundra.StylizedButton()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExportHtmlToolStripButton = New System.Windows.Forms.ToolStripButton()
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
        Me.FindToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.dlgSaveHtml = New System.Windows.Forms.SaveFileDialog()
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
        CType(Me.dgvDictionary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.pnlFindReplace.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 68)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvDictionary)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(6, 6, 0, 0)
        Me.SplitContainer1.Size = New System.Drawing.Size(1777, 1015)
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
        Me.tcSymbols.Size = New System.Drawing.Size(1777, 120)
        Me.tcSymbols.TabIndex = 73
        '
        'ConsonantsTabPage
        '
        Me.ConsonantsTabPage.Controls.Add(Me.ConsonantsLayoutPanel)
        Me.ConsonantsTabPage.Location = New System.Drawing.Point(8, 39)
        Me.ConsonantsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsonantsTabPage.Name = "ConsonantsTabPage"
        Me.ConsonantsTabPage.Size = New System.Drawing.Size(1761, 73)
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
        Me.ConsonantsLayoutPanel.Size = New System.Drawing.Size(1761, 73)
        Me.ConsonantsLayoutPanel.TabIndex = 7
        '
        'AffricatesTabPage
        '
        Me.AffricatesTabPage.Controls.Add(Me.AffricatesLayoutPanel)
        Me.AffricatesTabPage.Location = New System.Drawing.Point(8, 39)
        Me.AffricatesTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.AffricatesTabPage.Name = "AffricatesTabPage"
        Me.AffricatesTabPage.Size = New System.Drawing.Size(1761, 73)
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
        Me.AffricatesLayoutPanel.Size = New System.Drawing.Size(1761, 73)
        Me.AffricatesLayoutPanel.TabIndex = 8
        '
        'VowelsTabPage
        '
        Me.VowelsTabPage.Controls.Add(Me.VowelsLayoutPanel)
        Me.VowelsTabPage.Location = New System.Drawing.Point(8, 39)
        Me.VowelsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.VowelsTabPage.Name = "VowelsTabPage"
        Me.VowelsTabPage.Size = New System.Drawing.Size(1761, 73)
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
        Me.VowelsLayoutPanel.Size = New System.Drawing.Size(1761, 73)
        Me.VowelsLayoutPanel.TabIndex = 8
        '
        'AccentsTabPage
        '
        Me.AccentsTabPage.Controls.Add(Me.AccentsLayoutPanel)
        Me.AccentsTabPage.Location = New System.Drawing.Point(8, 39)
        Me.AccentsTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.AccentsTabPage.Name = "AccentsTabPage"
        Me.AccentsTabPage.Size = New System.Drawing.Size(1761, 73)
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
        Me.AccentsLayoutPanel.Size = New System.Drawing.Size(1761, 73)
        Me.AccentsLayoutPanel.TabIndex = 9
        '
        'ToneIntonationTabPage
        '
        Me.ToneIntonationTabPage.Controls.Add(Me.ToneIntonationLayoutPanel)
        Me.ToneIntonationTabPage.Location = New System.Drawing.Point(8, 39)
        Me.ToneIntonationTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.ToneIntonationTabPage.Name = "ToneIntonationTabPage"
        Me.ToneIntonationTabPage.Size = New System.Drawing.Size(1761, 73)
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
        Me.ToneIntonationLayoutPanel.Size = New System.Drawing.Size(1761, 73)
        Me.ToneIntonationLayoutPanel.TabIndex = 10
        '
        'OtherTabPage
        '
        Me.OtherTabPage.Controls.Add(Me.OtherLayoutPanel)
        Me.OtherTabPage.Location = New System.Drawing.Point(8, 39)
        Me.OtherTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.OtherTabPage.Name = "OtherTabPage"
        Me.OtherTabPage.Size = New System.Drawing.Size(1761, 73)
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
        Me.OtherLayoutPanel.Size = New System.Drawing.Size(1761, 73)
        Me.OtherLayoutPanel.TabIndex = 8
        '
        'CommonTabPage
        '
        Me.CommonTabPage.Controls.Add(Me.CommonLayoutPanel)
        Me.CommonTabPage.Location = New System.Drawing.Point(8, 39)
        Me.CommonTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.CommonTabPage.Name = "CommonTabPage"
        Me.CommonTabPage.Size = New System.Drawing.Size(1761, 73)
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
        Me.CommonLayoutPanel.Size = New System.Drawing.Size(1761, 73)
        Me.CommonLayoutPanel.TabIndex = 9
        '
        'CustomTabPage
        '
        Me.CustomTabPage.Controls.Add(Me.CustomLayoutPanel)
        Me.CustomTabPage.Location = New System.Drawing.Point(8, 39)
        Me.CustomTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomTabPage.Name = "CustomTabPage"
        Me.CustomTabPage.Size = New System.Drawing.Size(1761, 73)
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
        Me.CustomLayoutPanel.Size = New System.Drawing.Size(1761, 73)
        Me.CustomLayoutPanel.TabIndex = 9
        '
        'dgvDictionary
        '
        Me.dgvDictionary.AllowUserToAddRows = False
        Me.dgvDictionary.BackgroundColor = System.Drawing.Color.White
        Me.dgvDictionary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDictionary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDictionary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Word, Me.Pronunciation, Me.Definition, Me.Notes})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDictionary.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDictionary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDictionary.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvDictionary.Location = New System.Drawing.Point(6, 6)
        Me.dgvDictionary.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDictionary.Name = "dgvDictionary"
        Me.dgvDictionary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDictionary.RowTemplate.Height = 24
        Me.dgvDictionary.Size = New System.Drawing.Size(1771, 881)
        Me.dgvDictionary.TabIndex = 3
        '
        'Word
        '
        Me.Word.HeaderText = "Word"
        Me.Word.Name = "Word"
        '
        'Pronunciation
        '
        Me.Pronunciation.HeaderText = "Pronunciation"
        Me.Pronunciation.Name = "Pronunciation"
        Me.Pronunciation.Width = 150
        '
        'Definition
        '
        Me.Definition.HeaderText = "Definition"
        Me.Definition.Name = "Definition"
        Me.Definition.Width = 255
        '
        'Notes
        '
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.Width = 255
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
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.pnlFindReplace)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1777, 1083)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1777, 1121)
        Me.ToolStripContainer1.TabIndex = 75
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MainToolStrip)
        '
        'pnlFindReplace
        '
        Me.pnlFindReplace.BackColor = System.Drawing.Color.Transparent
        Me.pnlFindReplace.Controls.Add(Me.cbStartsWith)
        Me.pnlFindReplace.Controls.Add(Me.rbDefinition)
        Me.pnlFindReplace.Controls.Add(Me.rbWord)
        Me.pnlFindReplace.Controls.Add(Me.txtFind)
        Me.pnlFindReplace.Controls.Add(Me.Label17)
        Me.pnlFindReplace.Controls.Add(Me.btnFind)
        Me.pnlFindReplace.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFindReplace.Location = New System.Drawing.Point(0, 0)
        Me.pnlFindReplace.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFindReplace.Name = "pnlFindReplace"
        Me.pnlFindReplace.Size = New System.Drawing.Size(1777, 68)
        Me.pnlFindReplace.Style = "Colors=20,0,0,0|0,0,0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=35,0,0," &
    "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.pnlFindReplace.TabIndex = 75
        Me.pnlFindReplace.Visible = False
        '
        'cbStartsWith
        '
        Me.cbStartsWith.AutoSize = True
        Me.cbStartsWith.Location = New System.Drawing.Point(622, 20)
        Me.cbStartsWith.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStartsWith.Name = "cbStartsWith"
        Me.cbStartsWith.Size = New System.Drawing.Size(149, 29)
        Me.cbStartsWith.TabIndex = 69
        Me.cbStartsWith.Text = "Starts With"
        Me.cbStartsWith.UseVisualStyleBackColor = True
        '
        'rbDefinition
        '
        Me.rbDefinition.AutoSize = True
        Me.rbDefinition.Checked = True
        Me.rbDefinition.Location = New System.Drawing.Point(881, 20)
        Me.rbDefinition.Margin = New System.Windows.Forms.Padding(4)
        Me.rbDefinition.Name = "rbDefinition"
        Me.rbDefinition.Size = New System.Drawing.Size(133, 29)
        Me.rbDefinition.TabIndex = 71
        Me.rbDefinition.TabStop = True
        Me.rbDefinition.Text = "Definition"
        Me.rbDefinition.UseVisualStyleBackColor = True
        '
        'rbWord
        '
        Me.rbWord.AutoSize = True
        Me.rbWord.Location = New System.Drawing.Point(779, 19)
        Me.rbWord.Margin = New System.Windows.Forms.Padding(4)
        Me.rbWord.Name = "rbWord"
        Me.rbWord.Size = New System.Drawing.Size(94, 29)
        Me.rbWord.TabIndex = 70
        Me.rbWord.Text = "Word"
        Me.rbWord.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(81, 18)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(533, 31)
        Me.txtFind.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 21)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 25)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Find:"
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.Transparent
        Me.btnFind.BackgroundImage = CType(resources.GetObject("btnFind.BackgroundImage"), System.Drawing.Image)
        Me.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFind.FlatAppearance.BorderSize = 0
        Me.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.ForeColor = System.Drawing.Color.Black
        Me.btnFind.Location = New System.Drawing.Point(1022, 10)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnFind.Size = New System.Drawing.Size(155, 46)
        Me.btnFind.Style = resources.GetString("btnFind.Style")
        Me.btnFind.TabIndex = 67
        Me.btnFind.Text = "Find"
        Me.btnFind.UseCompatibleTextRendering = True
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'MainToolStrip
        '
        Me.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ExportHtmlToolStripButton, Me.ToolStripSeparator1, Me.SymbolsToolStripButton, Me.CustomSymbolsToolStripButton, Me.AccentMarkToolStripButton, Me.ToolStripSeparator2, Me.AddToolStripButton, Me.RemoveToolStripButton, Me.ToolStripSeparator3, Me.FontToolStripButton, Me.ToolStripSeparator4, Me.FindToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(1777, 38)
        Me.MainToolStrip.Stretch = True
        Me.MainToolStrip.TabIndex = 1
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.NewToolStripButton.Text = "New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.OpenToolStripButton.Text = "Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.SaveToolStripButton.Text = "Save"
        '
        'ExportHtmlToolStripButton
        '
        Me.ExportHtmlToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportHtmlToolStripButton.Image = CType(resources.GetObject("ExportHtmlToolStripButton.Image"), System.Drawing.Image)
        Me.ExportHtmlToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExportHtmlToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportHtmlToolStripButton.Name = "ExportHtmlToolStripButton"
        Me.ExportHtmlToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.ExportHtmlToolStripButton.Text = "Export To HTML"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'SymbolsToolStripButton
        '
        Me.SymbolsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SymbolsToolStripButton.Image = CType(resources.GetObject("SymbolsToolStripButton.Image"), System.Drawing.Image)
        Me.SymbolsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SymbolsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SymbolsToolStripButton.Name = "SymbolsToolStripButton"
        Me.SymbolsToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.SymbolsToolStripButton.Text = "Symbols"
        '
        'CustomSymbolsToolStripButton
        '
        Me.CustomSymbolsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomSymbolsToolStripButton.Image = CType(resources.GetObject("CustomSymbolsToolStripButton.Image"), System.Drawing.Image)
        Me.CustomSymbolsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CustomSymbolsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CustomSymbolsToolStripButton.Name = "CustomSymbolsToolStripButton"
        Me.CustomSymbolsToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.CustomSymbolsToolStripButton.Text = "Custom Symbols"
        '
        'AccentMarkToolStripButton
        '
        Me.AccentMarkToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AccentMarkToolStripButton.Image = CType(resources.GetObject("AccentMarkToolStripButton.Image"), System.Drawing.Image)
        Me.AccentMarkToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AccentMarkToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AccentMarkToolStripButton.Name = "AccentMarkToolStripButton"
        Me.AccentMarkToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.AccentMarkToolStripButton.Text = "Accent Mark"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'AddToolStripButton
        '
        Me.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolStripButton.Image = CType(resources.GetObject("AddToolStripButton.Image"), System.Drawing.Image)
        Me.AddToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolStripButton.Name = "AddToolStripButton"
        Me.AddToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.AddToolStripButton.Text = "Add"
        '
        'RemoveToolStripButton
        '
        Me.RemoveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveToolStripButton.Image = CType(resources.GetObject("RemoveToolStripButton.Image"), System.Drawing.Image)
        Me.RemoveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RemoveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveToolStripButton.Name = "RemoveToolStripButton"
        Me.RemoveToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.RemoveToolStripButton.Text = "Remove"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'FontToolStripButton
        '
        Me.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FontToolStripButton.Image = CType(resources.GetObject("FontToolStripButton.Image"), System.Drawing.Image)
        Me.FontToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FontToolStripButton.Name = "FontToolStripButton"
        Me.FontToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.FontToolStripButton.Text = "Font"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 38)
        '
        'FindToolStripButton
        '
        Me.FindToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FindToolStripButton.Image = CType(resources.GetObject("FindToolStripButton.Image"), System.Drawing.Image)
        Me.FindToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FindToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FindToolStripButton.Name = "FindToolStripButton"
        Me.FindToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.FindToolStripButton.Text = "Find"
        '
        'dlgSaveHtml
        '
        Me.dlgSaveHtml.Filter = "Html files (*.html)|*.html|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'frmDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1777, 1121)
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
        CType(Me.dgvDictionary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.pnlFindReplace.ResumeLayout(False)
        Me.pnlFindReplace.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvDictionary As DataGridView
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
    Friend WithEvents Word As DataGridViewTextBoxColumn
    Friend WithEvents Pronunciation As DataGridViewTextBoxColumn
    Friend WithEvents Definition As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents ExportHtmlToolStripButton As ToolStripButton
    Friend WithEvents dlgSaveHtml As SaveFileDialog
    Friend WithEvents pnlFindReplace As Tundra.StylizedPanel
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnFind As Tundra.StylizedButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents FindToolStripButton As ToolStripButton
    Friend WithEvents cbStartsWith As CheckBox
    Friend WithEvents rbDefinition As RadioButton
    Friend WithEvents rbWord As RadioButton
End Class
