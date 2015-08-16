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
        Me.btnSave = New Tundra.StylizedButton()
        Me.btnExport = New Tundra.StylizedButton()
        Me.btnImport = New Tundra.StylizedButton()
        Me.btnRename = New Tundra.StylizedButton()
        Me.btnRemove = New Tundra.StylizedButton()
        Me.btnAdd = New Tundra.StylizedButton()
        Me.btnDown = New Tundra.StylizedButton()
        Me.btnUp = New Tundra.StylizedButton()
        Me.btnGoWebsite = New Tundra.StylizedButton()
        Me.btnDuplicate = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel1 = New Tundra.DoubleBufferedPanel()
        Me.DoubleBufferedPanel3 = New Tundra.DoubleBufferedPanel()
        Me.DoubleBufferedPanel4 = New Tundra.DoubleBufferedPanel()
        Me.DoubleBufferedPanel18 = New Tundra.DoubleBufferedPanel()
        Me.DoubleBufferedPanel2 = New Tundra.DoubleBufferedPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEmbed = New System.Windows.Forms.CheckBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlControls = New Tundra.StylizedPanel()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.btnDictionary = New Tundra.StylizedButton()
        Me.DoubleBufferedPanel1.SuspendLayout()
        Me.DoubleBufferedPanel2.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.StylizedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbPages
        '
        Me.lbPages.BackColor = System.Drawing.Color.White
        Me.lbPages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPages.ForeColor = System.Drawing.Color.Black
        Me.lbPages.IntegralHeight = False
        Me.lbPages.Location = New System.Drawing.Point(1, 0)
        Me.lbPages.Margin = New System.Windows.Forms.Padding(2)
        Me.lbPages.Name = "lbPages"
        Me.lbPages.Size = New System.Drawing.Size(224, 265)
        Me.lbPages.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(196, 1)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnSave.Size = New System.Drawing.Size(24, 24)
        Me.btnSave.Style = resources.GetString("btnSave.Style")
        Me.btnSave.TabIndex = 14
        Me.ttMain.SetToolTip(Me.btnSave, "Save notebook")
        Me.btnSave.UseCompatibleTextRendering = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Transparent
        Me.btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), System.Drawing.Image)
        Me.btnExport.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.Black
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(171, 1)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnExport.Size = New System.Drawing.Size(24, 24)
        Me.btnExport.Style = resources.GetString("btnExport.Style")
        Me.btnExport.TabIndex = 13
        Me.ttMain.SetToolTip(Me.btnExport, "Export page")
        Me.btnExport.UseCompatibleTextRendering = True
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.Color.Transparent
        Me.btnImport.BackgroundImage = CType(resources.GetObject("btnImport.BackgroundImage"), System.Drawing.Image)
        Me.btnImport.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnImport.FlatAppearance.BorderSize = 0
        Me.btnImport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.ForeColor = System.Drawing.Color.Black
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.Location = New System.Drawing.Point(147, 1)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnImport.Size = New System.Drawing.Size(24, 24)
        Me.btnImport.Style = resources.GetString("btnImport.Style")
        Me.btnImport.TabIndex = 12
        Me.ttMain.SetToolTip(Me.btnImport, "Import page")
        Me.btnImport.UseCompatibleTextRendering = True
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'btnRename
        '
        Me.btnRename.BackColor = System.Drawing.Color.Transparent
        Me.btnRename.BackgroundImage = CType(resources.GetObject("btnRename.BackgroundImage"), System.Drawing.Image)
        Me.btnRename.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRename.FlatAppearance.BorderSize = 0
        Me.btnRename.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRename.ForeColor = System.Drawing.Color.Black
        Me.btnRename.Image = CType(resources.GetObject("btnRename.Image"), System.Drawing.Image)
        Me.btnRename.Location = New System.Drawing.Point(98, 1)
        Me.btnRename.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnRename.Size = New System.Drawing.Size(24, 24)
        Me.btnRename.Style = resources.GetString("btnRename.Style")
        Me.btnRename.TabIndex = 10
        Me.ttMain.SetToolTip(Me.btnRename, "Rename page")
        Me.btnRename.UseCompatibleTextRendering = True
        Me.btnRename.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.BackgroundImage = CType(resources.GetObject("btnRemove.BackgroundImage"), System.Drawing.Image)
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(74, 1)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnRemove.Size = New System.Drawing.Size(24, 24)
        Me.btnRemove.Style = resources.GetString("btnRemove.Style")
        Me.btnRemove.TabIndex = 9
        Me.ttMain.SetToolTip(Me.btnRemove, "Remove page")
        Me.btnRemove.UseCompatibleTextRendering = True
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(50, 1)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnAdd.Size = New System.Drawing.Size(24, 24)
        Me.btnAdd.Style = resources.GetString("btnAdd.Style")
        Me.btnAdd.TabIndex = 8
        Me.ttMain.SetToolTip(Me.btnAdd, "Add page")
        Me.btnAdd.UseCompatibleTextRendering = True
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.Transparent
        Me.btnDown.BackgroundImage = CType(resources.GetObject("btnDown.BackgroundImage"), System.Drawing.Image)
        Me.btnDown.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDown.FlatAppearance.BorderSize = 0
        Me.btnDown.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.ForeColor = System.Drawing.Color.Black
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(25, 1)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnDown.Size = New System.Drawing.Size(24, 24)
        Me.btnDown.Style = resources.GetString("btnDown.Style")
        Me.btnDown.TabIndex = 7
        Me.ttMain.SetToolTip(Me.btnDown, "Move page down")
        Me.btnDown.UseCompatibleTextRendering = True
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.Transparent
        Me.btnUp.BackgroundImage = CType(resources.GetObject("btnUp.BackgroundImage"), System.Drawing.Image)
        Me.btnUp.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUp.FlatAppearance.BorderSize = 0
        Me.btnUp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.ForeColor = System.Drawing.Color.Black
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(1, 1)
        Me.btnUp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnUp.Size = New System.Drawing.Size(24, 24)
        Me.btnUp.Style = resources.GetString("btnUp.Style")
        Me.btnUp.TabIndex = 6
        Me.ttMain.SetToolTip(Me.btnUp, "Move page up")
        Me.btnUp.UseCompatibleTextRendering = True
        Me.btnUp.UseVisualStyleBackColor = False
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
        Me.btnGoWebsite.Location = New System.Drawing.Point(202, 71)
        Me.btnGoWebsite.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGoWebsite.Name = "btnGoWebsite"
        Me.btnGoWebsite.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnGoWebsite.Size = New System.Drawing.Size(20, 20)
        Me.btnGoWebsite.Style = resources.GetString("btnGoWebsite.Style")
        Me.btnGoWebsite.TabIndex = 4
        Me.ttMain.SetToolTip(Me.btnGoWebsite, "Launch in web browser")
        Me.btnGoWebsite.UseCompatibleTextRendering = True
        Me.btnGoWebsite.UseVisualStyleBackColor = False
        '
        'btnDuplicate
        '
        Me.btnDuplicate.BackColor = System.Drawing.Color.Transparent
        Me.btnDuplicate.BackgroundImage = CType(resources.GetObject("btnDuplicate.BackgroundImage"), System.Drawing.Image)
        Me.btnDuplicate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDuplicate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDuplicate.FlatAppearance.BorderSize = 0
        Me.btnDuplicate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnDuplicate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDuplicate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuplicate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDuplicate.ForeColor = System.Drawing.Color.Black
        Me.btnDuplicate.Image = CType(resources.GetObject("btnDuplicate.Image"), System.Drawing.Image)
        Me.btnDuplicate.Location = New System.Drawing.Point(122, 1)
        Me.btnDuplicate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnDuplicate.Size = New System.Drawing.Size(24, 24)
        Me.btnDuplicate.Style = resources.GetString("btnDuplicate.Style")
        Me.btnDuplicate.TabIndex = 11
        Me.ttMain.SetToolTip(Me.btnDuplicate, "Duplicate page")
        Me.btnDuplicate.UseCompatibleTextRendering = True
        Me.btnDuplicate.UseVisualStyleBackColor = False
        '
        'DoubleBufferedPanel1
        '
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnSave)
        Me.DoubleBufferedPanel1.Controls.Add(Me.DoubleBufferedPanel3)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnExport)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnImport)
        Me.DoubleBufferedPanel1.Controls.Add(Me.DoubleBufferedPanel4)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnDuplicate)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnRename)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnRemove)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnAdd)
        Me.DoubleBufferedPanel1.Controls.Add(Me.DoubleBufferedPanel18)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnDown)
        Me.DoubleBufferedPanel1.Controls.Add(Me.btnUp)
        Me.DoubleBufferedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DoubleBufferedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DoubleBufferedPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel1.Name = "DoubleBufferedPanel1"
        Me.DoubleBufferedPanel1.Padding = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.DoubleBufferedPanel1.Size = New System.Drawing.Size(225, 26)
        Me.DoubleBufferedPanel1.TabIndex = 75
        '
        'DoubleBufferedPanel3
        '
        Me.DoubleBufferedPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DoubleBufferedPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.DoubleBufferedPanel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel3.Location = New System.Drawing.Point(195, 1)
        Me.DoubleBufferedPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel3.Name = "DoubleBufferedPanel3"
        Me.DoubleBufferedPanel3.Size = New System.Drawing.Size(1, 24)
        Me.DoubleBufferedPanel3.TabIndex = 85
        '
        'DoubleBufferedPanel4
        '
        Me.DoubleBufferedPanel4.BackColor = System.Drawing.Color.Transparent
        Me.DoubleBufferedPanel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.DoubleBufferedPanel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel4.Location = New System.Drawing.Point(146, 1)
        Me.DoubleBufferedPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel4.Name = "DoubleBufferedPanel4"
        Me.DoubleBufferedPanel4.Size = New System.Drawing.Size(1, 24)
        Me.DoubleBufferedPanel4.TabIndex = 86
        '
        'DoubleBufferedPanel18
        '
        Me.DoubleBufferedPanel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DoubleBufferedPanel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.DoubleBufferedPanel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DoubleBufferedPanel18.Location = New System.Drawing.Point(49, 1)
        Me.DoubleBufferedPanel18.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel18.Name = "DoubleBufferedPanel18"
        Me.DoubleBufferedPanel18.Size = New System.Drawing.Size(1, 24)
        Me.DoubleBufferedPanel18.TabIndex = 84
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
        Me.DoubleBufferedPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.DoubleBufferedPanel2.Name = "DoubleBufferedPanel2"
        Me.DoubleBufferedPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.DoubleBufferedPanel2.Size = New System.Drawing.Size(225, 177)
        Me.DoubleBufferedPanel2.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Info:"
        '
        'txtInfo
        '
        Me.txtInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtInfo.Location = New System.Drawing.Point(56, 93)
        Me.txtInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo.Size = New System.Drawing.Size(166, 51)
        Me.txtInfo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Website:"
        '
        'cbEmbed
        '
        Me.cbEmbed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbEmbed.AutoSize = True
        Me.cbEmbed.Checked = True
        Me.cbEmbed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbEmbed.Location = New System.Drawing.Point(4, 3)
        Me.cbEmbed.Margin = New System.Windows.Forms.Padding(2)
        Me.cbEmbed.Name = "cbEmbed"
        Me.cbEmbed.Size = New System.Drawing.Size(136, 17)
        Me.cbEmbed.TabIndex = 0
        Me.cbEmbed.Text = "Embed custom symbols"
        Me.cbEmbed.UseVisualStyleBackColor = True
        '
        'txtAuthor
        '
        Me.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAuthor.Location = New System.Drawing.Point(56, 48)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(166, 20)
        Me.txtAuthor.TabIndex = 2
        '
        'txtWebsite
        '
        Me.txtWebsite.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtWebsite.Location = New System.Drawing.Point(56, 71)
        Me.txtWebsite.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(142, 20)
        Me.txtWebsite.TabIndex = 3
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTitle.Location = New System.Drawing.Point(56, 25)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(166, 20)
        Me.txtTitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Author:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Title:"
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.Color.Transparent
        Me.pnlControls.Controls.Add(Me.DoubleBufferedPanel1)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControls.Location = New System.Drawing.Point(0, 177)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(225, 26)
        Me.pnlControls.Style = "Colors=~235|~235" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight" &
    " Color$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0"
        Me.pnlControls.TabIndex = 79
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.lbPages)
        Me.StylizedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedPanel1.Location = New System.Drawing.Point(0, 203)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.StylizedPanel1.Size = New System.Drawing.Size(225, 265)
        Me.StylizedPanel1.Style = "Colors=$1|$1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Col" &
    "or$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0"
        Me.StylizedPanel1.TabIndex = 80
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
        Me.btnDictionary.Image = CType(resources.GetObject("btnDictionary.Image"), System.Drawing.Image)
        Me.btnDictionary.Location = New System.Drawing.Point(4, 148)
        Me.btnDictionary.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDictionary.Name = "btnDictionary"
        Me.btnDictionary.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnDictionary.Size = New System.Drawing.Size(218, 24)
        Me.btnDictionary.Style = resources.GetString("btnDictionary.Style")
        Me.btnDictionary.TabIndex = 79
        Me.btnDictionary.Text = " Dictionary"
        Me.btnDictionary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDictionary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDictionary.UseCompatibleTextRendering = True
        Me.btnDictionary.UseVisualStyleBackColor = False
        '
        'NotebookEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.StylizedPanel1)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.DoubleBufferedPanel2)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "NotebookEditor"
        Me.Size = New System.Drawing.Size(225, 468)
        Me.DoubleBufferedPanel1.ResumeLayout(False)
        Me.DoubleBufferedPanel2.ResumeLayout(False)
        Me.DoubleBufferedPanel2.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.StylizedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents btnUp As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel1 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnDown As Tundra.StylizedButton
    Friend WithEvents lbPages As System.Windows.Forms.ListBox
    Friend WithEvents DoubleBufferedPanel2 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnRemove As Tundra.StylizedButton
    Friend WithEvents btnAdd As Tundra.StylizedButton
    Friend WithEvents btnExport As Tundra.StylizedButton
    Friend WithEvents btnImport As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel3 As Tundra.DoubleBufferedPanel
    Friend WithEvents DoubleBufferedPanel18 As Tundra.DoubleBufferedPanel
    Friend WithEvents ttMain As System.Windows.Forms.ToolTip
    Friend WithEvents btnRename As Tundra.StylizedButton
    Friend WithEvents cbEmbed As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnGoWebsite As Tundra.StylizedButton
    Friend WithEvents btnSave As Tundra.StylizedButton
    Friend WithEvents DoubleBufferedPanel4 As Tundra.DoubleBufferedPanel
    Friend WithEvents btnDuplicate As Tundra.StylizedButton
    Friend WithEvents pnlControls As Tundra.StylizedPanel
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
    Friend WithEvents btnDictionary As Tundra.StylizedButton
End Class
