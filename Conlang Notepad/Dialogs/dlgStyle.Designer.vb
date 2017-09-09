<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStyle
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgStyle))
        Me.rtbPreview = New System.Windows.Forms.RichTextBox()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.btnFont = New Tundra.StylizedButton()
        Me.btnColor = New Tundra.StylizedColorButton()
        Me.btnRight = New Tundra.StylizedButton()
        Me.btnCenter = New Tundra.StylizedButton()
        Me.btnLeft = New Tundra.StylizedButton()
        Me.nudIndent = New System.Windows.Forms.NumericUpDown()
        Me.btnIndent = New Tundra.StylizedButton()
        Me.btnSave = New Tundra.StylizedButton()
        Me.btnOpen = New Tundra.StylizedButton()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.nudOffset = New System.Windows.Forms.NumericUpDown()
        Me.btnOffset = New Tundra.StylizedButton()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnHighlight = New Tundra.StylizedColorButton()
        Me.btnDeleteAll = New Tundra.StylizedButton()
        Me.btnClose = New Tundra.StylizedButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StylizedPanel1.SuspendLayout()
        CType(Me.nudIndent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbPreview
        '
        Me.rtbPreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbPreview.Location = New System.Drawing.Point(2, 2)
        Me.rtbPreview.Margin = New System.Windows.Forms.Padding(6)
        Me.rtbPreview.Name = "rtbPreview"
        Me.rtbPreview.Size = New System.Drawing.Size(606, 186)
        Me.rtbPreview.TabIndex = 0
        Me.rtbPreview.Text = "Lorem Ipsum"
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.rtbPreview)
        Me.StylizedPanel1.Location = New System.Drawing.Point(13, 13)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedPanel1.Size = New System.Drawing.Size(610, 190)
        Me.StylizedPanel1.Style = "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colors=~255|~255" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Text C" &
    "olor=#252b2f" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0"
        Me.StylizedPanel1.TabIndex = 84
        '
        'btnFont
        '
        Me.btnFont.BackColor = System.Drawing.Color.Transparent
        Me.btnFont.BackgroundImage = CType(resources.GetObject("btnFont.BackgroundImage"), System.Drawing.Image)
        Me.btnFont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFont.FlatAppearance.BorderSize = 0
        Me.btnFont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFont.ForeColor = System.Drawing.Color.Black
        Me.btnFont.Location = New System.Drawing.Point(13, 341)
        Me.btnFont.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnFont.Size = New System.Drawing.Size(608, 46)
        Me.btnFont.Style = resources.GetString("btnFont.Style")
        Me.btnFont.TabIndex = 3
        Me.btnFont.Text = "Font"
        Me.ttMain.SetToolTip(Me.btnFont, "Text font")
        Me.btnFont.UseCompatibleTextRendering = True
        Me.btnFont.UseVisualStyleBackColor = False
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.Transparent
        Me.btnColor.BackgroundImage = CType(resources.GetObject("btnColor.BackgroundImage"), System.Drawing.Image)
        Me.btnColor.Color = System.Drawing.Color.Black
        Me.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnColor.FlatAppearance.BorderSize = 0
        Me.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor.ForeColor = System.Drawing.Color.Black
        Me.btnColor.Image = CType(resources.GetObject("btnColor.Image"), System.Drawing.Image)
        Me.btnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor.Location = New System.Drawing.Point(15, 287)
        Me.btnColor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnColor.MinimumSize = New System.Drawing.Size(4, 46)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnColor.Size = New System.Drawing.Size(288, 46)
        Me.btnColor.Style = resources.GetString("btnColor.Style")
        Me.btnColor.TabIndex = 1
        Me.btnColor.Text = " Text Color"
        Me.btnColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnColor, "Text color")
        Me.btnColor.UseCompatibleTextRendering = True
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.Transparent
        Me.btnRight.BackgroundImage = CType(resources.GetObject("btnRight.BackgroundImage"), System.Drawing.Image)
        Me.btnRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRight.FlatAppearance.BorderSize = 0
        Me.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight.ForeColor = System.Drawing.Color.Black
        Me.btnRight.Image = CType(resources.GetObject("btnRight.Image"), System.Drawing.Image)
        Me.btnRight.Location = New System.Drawing.Point(356, 211)
        Me.btnRight.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(72, 68)
        Me.btnRight.Style = resources.GetString("btnRight.Style")
        Me.btnRight.TabIndex = 6
        Me.btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnRight, "Right align text")
        Me.btnRight.UseCompatibleTextRendering = True
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnCenter
        '
        Me.btnCenter.BackColor = System.Drawing.Color.Transparent
        Me.btnCenter.BackgroundImage = CType(resources.GetObject("btnCenter.BackgroundImage"), System.Drawing.Image)
        Me.btnCenter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCenter.FlatAppearance.BorderSize = 0
        Me.btnCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCenter.ForeColor = System.Drawing.Color.Black
        Me.btnCenter.Image = CType(resources.GetObject("btnCenter.Image"), System.Drawing.Image)
        Me.btnCenter.Location = New System.Drawing.Point(276, 211)
        Me.btnCenter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCenter.Name = "btnCenter"
        Me.btnCenter.Size = New System.Drawing.Size(72, 68)
        Me.btnCenter.Style = resources.GetString("btnCenter.Style")
        Me.btnCenter.TabIndex = 5
        Me.btnCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnCenter, "Center align text")
        Me.btnCenter.UseCompatibleTextRendering = True
        Me.btnCenter.UseVisualStyleBackColor = False
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.Transparent
        Me.btnLeft.BackgroundImage = CType(resources.GetObject("btnLeft.BackgroundImage"), System.Drawing.Image)
        Me.btnLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLeft.FlatAppearance.BorderSize = 0
        Me.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft.ForeColor = System.Drawing.Color.Black
        Me.btnLeft.Image = CType(resources.GetObject("btnLeft.Image"), System.Drawing.Image)
        Me.btnLeft.Location = New System.Drawing.Point(196, 211)
        Me.btnLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(72, 68)
        Me.btnLeft.Style = resources.GetString("btnLeft.Style")
        Me.btnLeft.TabIndex = 4
        Me.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnLeft, "Left align text")
        Me.btnLeft.UseCompatibleTextRendering = True
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'nudIndent
        '
        Me.nudIndent.Location = New System.Drawing.Point(356, 415)
        Me.nudIndent.Margin = New System.Windows.Forms.Padding(4)
        Me.nudIndent.Name = "nudIndent"
        Me.nudIndent.Size = New System.Drawing.Size(267, 31)
        Me.nudIndent.TabIndex = 8
        '
        'btnIndent
        '
        Me.btnIndent.BackColor = System.Drawing.Color.Transparent
        Me.btnIndent.BackgroundImage = CType(resources.GetObject("btnIndent.BackgroundImage"), System.Drawing.Image)
        Me.btnIndent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIndent.FlatAppearance.BorderSize = 0
        Me.btnIndent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnIndent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnIndent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIndent.ForeColor = System.Drawing.Color.Black
        Me.btnIndent.Image = CType(resources.GetObject("btnIndent.Image"), System.Drawing.Image)
        Me.btnIndent.Location = New System.Drawing.Point(276, 395)
        Me.btnIndent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIndent.Name = "btnIndent"
        Me.btnIndent.Size = New System.Drawing.Size(72, 68)
        Me.btnIndent.Style = resources.GetString("btnIndent.Style")
        Me.btnIndent.TabIndex = 7
        Me.btnIndent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnIndent, "Indent text")
        Me.btnIndent.UseCompatibleTextRendering = True
        Me.btnIndent.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(95, 484)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 68)
        Me.btnSave.Style = resources.GetString("btnSave.Style")
        Me.btnSave.TabIndex = 94
        Me.ttMain.SetToolTip(Me.btnSave, "Save")
        Me.btnSave.UseCompatibleTextRendering = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.BackColor = System.Drawing.Color.Transparent
        Me.btnOpen.BackgroundImage = CType(resources.GetObject("btnOpen.BackgroundImage"), System.Drawing.Image)
        Me.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOpen.FlatAppearance.BorderSize = 0
        Me.btnOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.Color.Black
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.Location = New System.Drawing.Point(15, 484)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(72, 68)
        Me.btnOpen.Style = resources.GetString("btnOpen.Style")
        Me.btnOpen.TabIndex = 93
        Me.ttMain.SetToolTip(Me.btnOpen, "Open")
        Me.btnOpen.UseCompatibleTextRendering = True
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'nudOffset
        '
        Me.nudOffset.Location = New System.Drawing.Point(95, 415)
        Me.nudOffset.Margin = New System.Windows.Forms.Padding(4)
        Me.nudOffset.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudOffset.Name = "nudOffset"
        Me.nudOffset.Size = New System.Drawing.Size(173, 31)
        Me.nudOffset.TabIndex = 10
        '
        'btnOffset
        '
        Me.btnOffset.BackColor = System.Drawing.Color.Transparent
        Me.btnOffset.BackgroundImage = CType(resources.GetObject("btnOffset.BackgroundImage"), System.Drawing.Image)
        Me.btnOffset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOffset.FlatAppearance.BorderSize = 0
        Me.btnOffset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOffset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOffset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOffset.ForeColor = System.Drawing.Color.Black
        Me.btnOffset.Image = CType(resources.GetObject("btnOffset.Image"), System.Drawing.Image)
        Me.btnOffset.Location = New System.Drawing.Point(15, 395)
        Me.btnOffset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOffset.Name = "btnOffset"
        Me.btnOffset.Size = New System.Drawing.Size(72, 68)
        Me.btnOffset.Style = resources.GetString("btnOffset.Style")
        Me.btnOffset.TabIndex = 9
        Me.btnOffset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnOffset, "Character Offset")
        Me.btnOffset.UseCompatibleTextRendering = True
        Me.btnOffset.UseVisualStyleBackColor = False
        '
        'btnHighlight
        '
        Me.btnHighlight.BackColor = System.Drawing.Color.Transparent
        Me.btnHighlight.BackgroundImage = CType(resources.GetObject("btnHighlight.BackgroundImage"), System.Drawing.Image)
        Me.btnHighlight.Color = System.Drawing.Color.White
        Me.btnHighlight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHighlight.FlatAppearance.BorderSize = 0
        Me.btnHighlight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHighlight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHighlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighlight.ForeColor = System.Drawing.Color.Black
        Me.btnHighlight.Image = CType(resources.GetObject("btnHighlight.Image"), System.Drawing.Image)
        Me.btnHighlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHighlight.Location = New System.Drawing.Point(311, 287)
        Me.btnHighlight.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHighlight.MinimumSize = New System.Drawing.Size(4, 46)
        Me.btnHighlight.Name = "btnHighlight"
        Me.btnHighlight.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnHighlight.Size = New System.Drawing.Size(310, 46)
        Me.btnHighlight.Style = resources.GetString("btnHighlight.Style")
        Me.btnHighlight.TabIndex = 2
        Me.btnHighlight.Text = " Hightlight Color"
        Me.btnHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHighlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnHighlight, "Text color")
        Me.btnHighlight.UseCompatibleTextRendering = True
        Me.btnHighlight.UseVisualStyleBackColor = False
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteAll.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.BackgroundImage = CType(resources.GetObject("btnDeleteAll.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeleteAll.FlatAppearance.BorderSize = 0
        Me.btnDeleteAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAll.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteAll.Image = CType(resources.GetObject("btnDeleteAll.Image"), System.Drawing.Image)
        Me.btnDeleteAll.Location = New System.Drawing.Point(175, 484)
        Me.btnDeleteAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(72, 68)
        Me.btnDeleteAll.Style = resources.GetString("btnDeleteAll.Style")
        Me.btnDeleteAll.TabIndex = 95
        Me.ttMain.SetToolTip(Me.btnDeleteAll, "Revert to default")
        Me.btnDeleteAll.UseCompatibleTextRendering = True
        Me.btnDeleteAll.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(487, 493)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnClose.Size = New System.Drawing.Size(136, 50)
        Me.btnClose.Style = resources.GetString("btnClose.Style")
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseCompatibleTextRendering = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dlgStyle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 565)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnHighlight)
        Me.Controls.Add(Me.nudOffset)
        Me.Controls.Add(Me.btnOffset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnCenter)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.nudIndent)
        Me.Controls.Add(Me.btnIndent)
        Me.Controls.Add(Me.btnFont)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.StylizedPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStyle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Style"
        Me.StylizedPanel1.ResumeLayout(False)
        CType(Me.nudIndent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbPreview As RichTextBox
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel
    Friend WithEvents btnFont As Tundra.StylizedButton
    Friend WithEvents btnColor As Tundra.StylizedColorButton
    Friend WithEvents btnRight As Tundra.StylizedButton
    Friend WithEvents btnCenter As Tundra.StylizedButton
    Friend WithEvents btnLeft As Tundra.StylizedButton
    Friend WithEvents nudIndent As NumericUpDown
    Friend WithEvents btnIndent As Tundra.StylizedButton
    Friend WithEvents btnSave As Tundra.StylizedButton
    Friend WithEvents btnOpen As Tundra.StylizedButton
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents nudOffset As NumericUpDown
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents btnHighlight As Tundra.StylizedColorButton
    Friend WithEvents btnDeleteAll As Tundra.StylizedButton
    Friend WithEvents btnOffset As Tundra.StylizedButton
    Friend WithEvents btnClose As Tundra.StylizedButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
