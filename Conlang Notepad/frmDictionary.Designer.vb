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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTop = New Tundra.StylizedPanel()
        Me.pnlHome = New Tundra.DoubleBufferedPanel()
        Me.btnRemove = New Tundra.StylizedButton()
        Me.btnAdd = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel1 = New Tundra.DoubleBufferedPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCustomSymbols = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel15 = New Tundra.DoubleBufferedPanel()
        Me.DoubleBufferedPanel10 = New Tundra.DoubleBufferedPanel()
        Me.btnAccentMark = New Tundra.StylizedButton()
        Me.btnOpen = New Tundra.StylizedButton()
        Me.btnSymbols = New Tundra.StylizedButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSave = New Tundra.StylizedButton()
        Me.btnNew = New Tundra.StylizedButton()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.pnlTop.SuspendLayout()
        Me.pnlHome.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.AutoScroll = True
        Me.pnlTop.BackColor = System.Drawing.Color.Transparent
        Me.pnlTop.Controls.Add(Me.pnlHome)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(757, 116)
        Me.pnlTop.Style = "Colors=~245|~245|~239" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|0.8|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Highlight Color=$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0"
        Me.pnlTop.TabIndex = 13
        '
        'pnlHome
        '
        Me.pnlHome.AutoScroll = True
        Me.pnlHome.BackColor = System.Drawing.Color.Transparent
        Me.pnlHome.Controls.Add(Me.btnRemove)
        Me.pnlHome.Controls.Add(Me.btnAdd)
        Me.pnlHome.Controls.Add(Me.DoubleBufferedPanel1)
        Me.pnlHome.Controls.Add(Me.Label1)
        Me.pnlHome.Controls.Add(Me.btnCustomSymbols)
        Me.pnlHome.Controls.Add(Me.DoubleBufferedPanel15)
        Me.pnlHome.Controls.Add(Me.DoubleBufferedPanel10)
        Me.pnlHome.Controls.Add(Me.btnAccentMark)
        Me.pnlHome.Controls.Add(Me.btnOpen)
        Me.pnlHome.Controls.Add(Me.btnSymbols)
        Me.pnlHome.Controls.Add(Me.Label8)
        Me.pnlHome.Controls.Add(Me.btnSave)
        Me.pnlHome.Controls.Add(Me.btnNew)
        Me.pnlHome.Controls.Add(Me.Label16)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(757, 83)
        Me.pnlHome.TabIndex = 75
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.BackgroundImage = CType(resources.GetObject("btnRemove.BackgroundImage"), System.Drawing.Image)
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.Location = New System.Drawing.Point(412, 35)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnRemove.Size = New System.Drawing.Size(85, 26)
        Me.btnRemove.Style = resources.GetString("btnRemove.Style")
        Me.btnRemove.TabIndex = 70
        Me.btnRemove.Text = " Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemove.UseCompatibleTextRendering = True
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(412, 4)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnAdd.Size = New System.Drawing.Size(85, 26)
        Me.btnAdd.Style = resources.GetString("btnAdd.Style")
        Me.btnAdd.TabIndex = 69
        Me.btnAdd.Text = " Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseCompatibleTextRendering = True
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel1
        '
        Me.DoubleBufferedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel1.Location = New System.Drawing.Point(501, 9)
        Me.DoubleBufferedPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel1.Name = "DoubleBufferedPanel1"
        Me.DoubleBufferedPanel1.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel1.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(410, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Words"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCustomSymbols
        '
        Me.btnCustomSymbols.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomSymbols.BackgroundImage = CType(resources.GetObject("btnCustomSymbols.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomSymbols.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCustomSymbols.FlatAppearance.BorderSize = 0
        Me.btnCustomSymbols.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCustomSymbols.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCustomSymbols.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomSymbols.ForeColor = System.Drawing.Color.Black
        Me.btnCustomSymbols.Image = CType(resources.GetObject("btnCustomSymbols.Image"), System.Drawing.Image)
        Me.btnCustomSymbols.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomSymbols.Location = New System.Drawing.Point(267, 4)
        Me.btnCustomSymbols.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomSymbols.Name = "btnCustomSymbols"
        Me.btnCustomSymbols.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnCustomSymbols.Size = New System.Drawing.Size(134, 26)
        Me.btnCustomSymbols.Style = resources.GetString("btnCustomSymbols.Style")
        Me.btnCustomSymbols.TabIndex = 39
        Me.btnCustomSymbols.Text = " Custom Symbols"
        Me.btnCustomSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomSymbols.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomSymbols.UseCompatibleTextRendering = True
        Me.btnCustomSymbols.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel15
        '
        Me.DoubleBufferedPanel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel15.Location = New System.Drawing.Point(158, 9)
        Me.DoubleBufferedPanel15.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel15.Name = "DoubleBufferedPanel15"
        Me.DoubleBufferedPanel15.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel15.TabIndex = 51
        '
        'DoubleBufferedPanel10
        '
        Me.DoubleBufferedPanel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DoubleBufferedPanel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel10.Location = New System.Drawing.Point(407, 9)
        Me.DoubleBufferedPanel10.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel10.Name = "DoubleBufferedPanel10"
        Me.DoubleBufferedPanel10.Size = New System.Drawing.Size(1, 70)
        Me.DoubleBufferedPanel10.TabIndex = 51
        '
        'btnAccentMark
        '
        Me.btnAccentMark.BackColor = System.Drawing.Color.Transparent
        Me.btnAccentMark.BackgroundImage = CType(resources.GetObject("btnAccentMark.BackgroundImage"), System.Drawing.Image)
        Me.btnAccentMark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAccentMark.FlatAppearance.BorderSize = 0
        Me.btnAccentMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAccentMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAccentMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccentMark.ForeColor = System.Drawing.Color.Black
        Me.btnAccentMark.Image = CType(resources.GetObject("btnAccentMark.Image"), System.Drawing.Image)
        Me.btnAccentMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccentMark.Location = New System.Drawing.Point(163, 35)
        Me.btnAccentMark.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAccentMark.Name = "btnAccentMark"
        Me.btnAccentMark.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnAccentMark.Size = New System.Drawing.Size(98, 26)
        Me.btnAccentMark.Style = resources.GetString("btnAccentMark.Style")
        Me.btnAccentMark.TabIndex = 38
        Me.btnAccentMark.Text = " Accent Mark"
        Me.btnAccentMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccentMark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccentMark.UseCompatibleTextRendering = True
        Me.btnAccentMark.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.Transparent
        Me.btnOpen.BackgroundImage = CType(resources.GetObject("btnOpen.BackgroundImage"), System.Drawing.Image)
        Me.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOpen.FlatAppearance.BorderSize = 0
        Me.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.ForeColor = System.Drawing.Color.Black
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpen.Location = New System.Drawing.Point(8, 35)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnOpen.Size = New System.Drawing.Size(66, 26)
        Me.btnOpen.Style = resources.GetString("btnOpen.Style")
        Me.btnOpen.TabIndex = 7
        Me.btnOpen.Text = " Open"
        Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpen.UseCompatibleTextRendering = True
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'btnSymbols
        '
        Me.btnSymbols.BackColor = System.Drawing.Color.Transparent
        Me.btnSymbols.BackgroundImage = CType(resources.GetObject("btnSymbols.BackgroundImage"), System.Drawing.Image)
        Me.btnSymbols.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSymbols.FlatAppearance.BorderSize = 0
        Me.btnSymbols.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSymbols.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSymbols.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSymbols.ForeColor = System.Drawing.Color.Black
        Me.btnSymbols.Image = CType(resources.GetObject("btnSymbols.Image"), System.Drawing.Image)
        Me.btnSymbols.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSymbols.Location = New System.Drawing.Point(163, 4)
        Me.btnSymbols.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSymbols.Name = "btnSymbols"
        Me.btnSymbols.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnSymbols.Size = New System.Drawing.Size(98, 26)
        Me.btnSymbols.Style = resources.GetString("btnSymbols.Style")
        Me.btnSymbols.TabIndex = 37
        Me.btnSymbols.Text = " Symbols"
        Me.btnSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSymbols.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSymbols.UseCompatibleTextRendering = True
        Me.btnSymbols.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(163, 62)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Symbols"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(76, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnSave.Size = New System.Drawing.Size(76, 26)
        Me.btnSave.Style = resources.GetString("btnSave.Style")
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = " Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseCompatibleTextRendering = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(8, 4)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Padding = New System.Windows.Forms.Padding(0, 0, 2, 1)
        Me.btnNew.Size = New System.Drawing.Size(66, 26)
        Me.btnNew.Style = resources.GetString("btnNew.Style")
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = " New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseCompatibleTextRendering = True
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Gray
        Me.Label16.Location = New System.Drawing.Point(4, 63)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 19)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "File"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 116)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tcSymbols)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvDictionary)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.SplitContainer1.Size = New System.Drawing.Size(757, 391)
        Me.SplitContainer1.SplitterDistance = 124
        Me.SplitContainer1.SplitterWidth = 2
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
        Me.tcSymbols.Location = New System.Drawing.Point(0, 2)
        Me.tcSymbols.Margin = New System.Windows.Forms.Padding(2)
        Me.tcSymbols.Name = "tcSymbols"
        Me.tcSymbols.SelectedIndex = 0
        Me.tcSymbols.Size = New System.Drawing.Size(757, 122)
        Me.tcSymbols.TabIndex = 73
        '
        'ConsonantsTabPage
        '
        Me.ConsonantsTabPage.Controls.Add(Me.ConsonantsLayoutPanel)
        Me.ConsonantsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ConsonantsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.ConsonantsTabPage.Name = "ConsonantsTabPage"
        Me.ConsonantsTabPage.Size = New System.Drawing.Size(749, 96)
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
        Me.ConsonantsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsonantsLayoutPanel.Name = "ConsonantsLayoutPanel"
        Me.ConsonantsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.ConsonantsLayoutPanel.Size = New System.Drawing.Size(749, 96)
        Me.ConsonantsLayoutPanel.TabIndex = 7
        '
        'AffricatesTabPage
        '
        Me.AffricatesTabPage.Controls.Add(Me.AffricatesLayoutPanel)
        Me.AffricatesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AffricatesTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.AffricatesTabPage.Name = "AffricatesTabPage"
        Me.AffricatesTabPage.Size = New System.Drawing.Size(749, 96)
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
        Me.AffricatesLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AffricatesLayoutPanel.Name = "AffricatesLayoutPanel"
        Me.AffricatesLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.AffricatesLayoutPanel.Size = New System.Drawing.Size(749, 96)
        Me.AffricatesLayoutPanel.TabIndex = 8
        '
        'VowelsTabPage
        '
        Me.VowelsTabPage.Controls.Add(Me.VowelsLayoutPanel)
        Me.VowelsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.VowelsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.VowelsTabPage.Name = "VowelsTabPage"
        Me.VowelsTabPage.Size = New System.Drawing.Size(749, 96)
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
        Me.VowelsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.VowelsLayoutPanel.Name = "VowelsLayoutPanel"
        Me.VowelsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.VowelsLayoutPanel.Size = New System.Drawing.Size(749, 96)
        Me.VowelsLayoutPanel.TabIndex = 8
        '
        'AccentsTabPage
        '
        Me.AccentsTabPage.Controls.Add(Me.AccentsLayoutPanel)
        Me.AccentsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AccentsTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.AccentsTabPage.Name = "AccentsTabPage"
        Me.AccentsTabPage.Size = New System.Drawing.Size(749, 96)
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
        Me.AccentsLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.AccentsLayoutPanel.Name = "AccentsLayoutPanel"
        Me.AccentsLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.AccentsLayoutPanel.Size = New System.Drawing.Size(749, 96)
        Me.AccentsLayoutPanel.TabIndex = 9
        '
        'ToneIntonationTabPage
        '
        Me.ToneIntonationTabPage.Controls.Add(Me.ToneIntonationLayoutPanel)
        Me.ToneIntonationTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ToneIntonationTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.ToneIntonationTabPage.Name = "ToneIntonationTabPage"
        Me.ToneIntonationTabPage.Size = New System.Drawing.Size(749, 96)
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
        Me.ToneIntonationLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ToneIntonationLayoutPanel.Name = "ToneIntonationLayoutPanel"
        Me.ToneIntonationLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.ToneIntonationLayoutPanel.Size = New System.Drawing.Size(749, 96)
        Me.ToneIntonationLayoutPanel.TabIndex = 10
        '
        'OtherTabPage
        '
        Me.OtherTabPage.Controls.Add(Me.OtherLayoutPanel)
        Me.OtherTabPage.Location = New System.Drawing.Point(4, 22)
        Me.OtherTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.OtherTabPage.Name = "OtherTabPage"
        Me.OtherTabPage.Size = New System.Drawing.Size(749, 96)
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
        Me.OtherLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.OtherLayoutPanel.Name = "OtherLayoutPanel"
        Me.OtherLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.OtherLayoutPanel.Size = New System.Drawing.Size(749, 96)
        Me.OtherLayoutPanel.TabIndex = 8
        '
        'CommonTabPage
        '
        Me.CommonTabPage.Controls.Add(Me.CommonLayoutPanel)
        Me.CommonTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CommonTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.CommonTabPage.Name = "CommonTabPage"
        Me.CommonTabPage.Size = New System.Drawing.Size(749, 96)
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
        Me.CommonLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CommonLayoutPanel.Name = "CommonLayoutPanel"
        Me.CommonLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.CommonLayoutPanel.Size = New System.Drawing.Size(749, 96)
        Me.CommonLayoutPanel.TabIndex = 9
        '
        'CustomTabPage
        '
        Me.CustomTabPage.Controls.Add(Me.CustomLayoutPanel)
        Me.CustomTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CustomTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.CustomTabPage.Name = "CustomTabPage"
        Me.CustomTabPage.Size = New System.Drawing.Size(749, 96)
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
        Me.CustomLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomLayoutPanel.Name = "CustomLayoutPanel"
        Me.CustomLayoutPanel.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.CustomLayoutPanel.Size = New System.Drawing.Size(749, 96)
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDictionary.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDictionary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDictionary.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvDictionary.Location = New System.Drawing.Point(3, 3)
        Me.dgvDictionary.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDictionary.Name = "dgvDictionary"
        Me.dgvDictionary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDictionary.RowTemplate.Height = 24
        Me.dgvDictionary.Size = New System.Drawing.Size(754, 262)
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
        Me.dlgOpen.Filter = "Dictionary file (*.dict)|*.dict|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Dictionary file (*.dict)|*.dict|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'frmDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(757, 507)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlTop)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmDictionary"
        Me.ShowIcon = False
        Me.Text = "Dictionary"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlHome.ResumeLayout(False)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Tundra.StylizedPanel
    Friend WithEvents btnCustomSymbols As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel10 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnAccentMark As Tundra.StylizedButton
    Friend WithEvents btnSymbols As Tundra.StylizedButton
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlHome As Tundra.DoubleBufferedPanel
    Friend WithEvents DoubleBufferedPanel15 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnOpen As Tundra.StylizedButton
    Friend WithEvents btnSave As Tundra.StylizedButton
    Friend WithEvents btnNew As Tundra.StylizedButton
    Friend WithEvents Label16 As Label
    Friend WithEvents btnRemove As Tundra.StylizedButton
    Friend WithEvents btnAdd As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel1 As Tundra.DoubleBufferedPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvDictionary As DataGridView
    Friend WithEvents Word As DataGridViewTextBoxColumn
    Friend WithEvents Pronunciation As DataGridViewTextBoxColumn
    Friend WithEvents Definition As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
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
End Class
