<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTextArt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTextArt))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancel = New Tundra.StylizedButton()
        Me.btnOK = New Tundra.StylizedButton()
        Me.StylizedText1 = New Tundra.StylizedText()
        Me.btnColor2 = New Tundra.StylizedColorButton()
        Me.btnColor1 = New Tundra.StylizedColorButton()
        Me.btnBorderColor = New Tundra.StylizedColorButton()
        Me.btnShadowColor = New Tundra.StylizedColorButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudAngle = New System.Windows.Forms.NumericUpDown()
        Me.nudShadowX = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudShadowY = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.btnFont = New Tundra.StylizedButton()
        Me.dlgFont = New System.Windows.Forms.FontDialog()
        Me.nudSize = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShadowX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShadowY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StylizedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(267, 303)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 28)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(75, 2)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnCancel.Size = New System.Drawing.Size(69, 24)
        Me.btnCancel.Style = resources.GetString("btnCancel.Style")
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseCompatibleTextRendering = True
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BackgroundImage = CType(resources.GetObject("btnOK.BackgroundImage"), System.Drawing.Image)
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Location = New System.Drawing.Point(2, 2)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnOK.Size = New System.Drawing.Size(69, 24)
        Me.btnOK.Style = resources.GetString("btnOK.Style")
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseCompatibleTextRendering = True
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'StylizedText1
        '
        Me.StylizedText1.BackgroundImage = CType(resources.GetObject("StylizedText1.BackgroundImage"), System.Drawing.Image)
        Me.StylizedText1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StylizedText1.ControlText = "Text Art"
        Me.StylizedText1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedText1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StylizedText1.Location = New System.Drawing.Point(1, 1)
        Me.StylizedText1.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedText1.Name = "StylizedText1"
        Me.StylizedText1.Size = New System.Drawing.Size(400, 145)
        Me.StylizedText1.Style = "Colors=#e6832a|#c74c4f" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=$1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shadow Color=$2" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shadow Offset=(2,2)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Size=1 "
        Me.StylizedText1.TabIndex = 69
        '
        'btnColor2
        '
        Me.btnColor2.BackColor = System.Drawing.Color.Transparent
        Me.btnColor2.BackgroundImage = CType(resources.GetObject("btnColor2.BackgroundImage"), System.Drawing.Image)
        Me.btnColor2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnColor2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnColor2.FlatAppearance.BorderSize = 0
        Me.btnColor2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnColor2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor2.ForeColor = System.Drawing.Color.Black
        Me.btnColor2.Image = CType(resources.GetObject("btnColor2.Image"), System.Drawing.Image)
        Me.btnColor2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor2.Location = New System.Drawing.Point(86, 163)
        Me.btnColor2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnColor2.MinimumSize = New System.Drawing.Size(2, 24)
        Me.btnColor2.Name = "btnColor2"
        Me.btnColor2.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnColor2.Size = New System.Drawing.Size(70, 24)
        Me.btnColor2.Style = resources.GetString("btnColor2.Style")
        Me.btnColor2.TabIndex = 3
        Me.btnColor2.Text = " End"
        Me.btnColor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnColor2.UseCompatibleTextRendering = True
        Me.btnColor2.UseVisualStyleBackColor = False
        '
        'btnColor1
        '
        Me.btnColor1.BackColor = System.Drawing.Color.Transparent
        Me.btnColor1.BackgroundImage = CType(resources.GetObject("btnColor1.BackgroundImage"), System.Drawing.Image)
        Me.btnColor1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnColor1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnColor1.FlatAppearance.BorderSize = 0
        Me.btnColor1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnColor1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor1.ForeColor = System.Drawing.Color.Black
        Me.btnColor1.Image = CType(resources.GetObject("btnColor1.Image"), System.Drawing.Image)
        Me.btnColor1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor1.Location = New System.Drawing.Point(11, 163)
        Me.btnColor1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnColor1.MinimumSize = New System.Drawing.Size(2, 24)
        Me.btnColor1.Name = "btnColor1"
        Me.btnColor1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnColor1.Size = New System.Drawing.Size(70, 24)
        Me.btnColor1.Style = resources.GetString("btnColor1.Style")
        Me.btnColor1.TabIndex = 2
        Me.btnColor1.Text = " Start"
        Me.btnColor1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnColor1.UseCompatibleTextRendering = True
        Me.btnColor1.UseVisualStyleBackColor = False
        '
        'btnBorderColor
        '
        Me.btnBorderColor.BackColor = System.Drawing.Color.Transparent
        Me.btnBorderColor.BackgroundImage = CType(resources.GetObject("btnBorderColor.BackgroundImage"), System.Drawing.Image)
        Me.btnBorderColor.Color = System.Drawing.Color.Black
        Me.btnBorderColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBorderColor.FlatAppearance.BorderSize = 0
        Me.btnBorderColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBorderColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBorderColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorderColor.ForeColor = System.Drawing.Color.Black
        Me.btnBorderColor.Image = CType(resources.GetObject("btnBorderColor.Image"), System.Drawing.Image)
        Me.btnBorderColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorderColor.Location = New System.Drawing.Point(161, 163)
        Me.btnBorderColor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBorderColor.MinimumSize = New System.Drawing.Size(2, 24)
        Me.btnBorderColor.Name = "btnBorderColor"
        Me.btnBorderColor.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnBorderColor.Size = New System.Drawing.Size(89, 24)
        Me.btnBorderColor.Style = resources.GetString("btnBorderColor.Style")
        Me.btnBorderColor.TabIndex = 4
        Me.btnBorderColor.Text = " Border"
        Me.btnBorderColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorderColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorderColor.UseCompatibleTextRendering = True
        Me.btnBorderColor.UseVisualStyleBackColor = False
        '
        'btnShadowColor
        '
        Me.btnShadowColor.BackColor = System.Drawing.Color.Transparent
        Me.btnShadowColor.BackgroundImage = CType(resources.GetObject("btnShadowColor.BackgroundImage"), System.Drawing.Image)
        Me.btnShadowColor.Color = System.Drawing.Color.Black
        Me.btnShadowColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShadowColor.FlatAppearance.BorderSize = 0
        Me.btnShadowColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnShadowColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnShadowColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShadowColor.ForeColor = System.Drawing.Color.Black
        Me.btnShadowColor.Image = CType(resources.GetObject("btnShadowColor.Image"), System.Drawing.Image)
        Me.btnShadowColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShadowColor.Location = New System.Drawing.Point(255, 163)
        Me.btnShadowColor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShadowColor.MinimumSize = New System.Drawing.Size(2, 24)
        Me.btnShadowColor.Name = "btnShadowColor"
        Me.btnShadowColor.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnShadowColor.Size = New System.Drawing.Size(89, 24)
        Me.btnShadowColor.Style = resources.GetString("btnShadowColor.Style")
        Me.btnShadowColor.TabIndex = 5
        Me.btnShadowColor.Text = " Shadow"
        Me.btnShadowColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShadowColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShadowColor.UseCompatibleTextRendering = True
        Me.btnShadowColor.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 197)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Angle:"
        '
        'nudAngle
        '
        Me.nudAngle.Location = New System.Drawing.Point(50, 195)
        Me.nudAngle.Margin = New System.Windows.Forms.Padding(2)
        Me.nudAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudAngle.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.nudAngle.Name = "nudAngle"
        Me.nudAngle.Size = New System.Drawing.Size(38, 20)
        Me.nudAngle.TabIndex = 7
        Me.nudAngle.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'nudShadowX
        '
        Me.nudShadowX.Location = New System.Drawing.Point(154, 195)
        Me.nudShadowX.Margin = New System.Windows.Forms.Padding(2)
        Me.nudShadowX.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudShadowX.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.nudShadowX.Name = "nudShadowX"
        Me.nudShadowX.Size = New System.Drawing.Size(38, 20)
        Me.nudShadowX.TabIndex = 8
        Me.nudShadowX.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 197)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Shadow X:"
        '
        'nudShadowY
        '
        Me.nudShadowY.Location = New System.Drawing.Point(258, 195)
        Me.nudShadowY.Margin = New System.Windows.Forms.Padding(2)
        Me.nudShadowY.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudShadowY.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.nudShadowY.Name = "nudShadowY"
        Me.nudShadowY.Size = New System.Drawing.Size(38, 20)
        Me.nudShadowY.TabIndex = 9
        Me.nudShadowY.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 197)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Shadow Y:"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(11, 221)
        Me.txtText.Margin = New System.Windows.Forms.Padding(2)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(402, 77)
        Me.txtText.TabIndex = 11
        Me.txtText.Text = "Text Art"
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
        Me.btnFont.Location = New System.Drawing.Point(348, 163)
        Me.btnFont.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btnFont.Size = New System.Drawing.Size(64, 24)
        Me.btnFont.Style = resources.GetString("btnFont.Style")
        Me.btnFont.TabIndex = 6
        Me.btnFont.Text = "Font"
        Me.btnFont.UseCompatibleTextRendering = True
        Me.btnFont.UseVisualStyleBackColor = False
        '
        'dlgFont
        '
        Me.dlgFont.ShowColor = True
        '
        'nudSize
        '
        Me.nudSize.Location = New System.Drawing.Point(369, 195)
        Me.nudSize.Margin = New System.Windows.Forms.Padding(2)
        Me.nudSize.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudSize.Name = "nudSize"
        Me.nudSize.Size = New System.Drawing.Size(44, 20)
        Me.nudSize.TabIndex = 10
        Me.nudSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Border Size:"
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.StylizedText1)
        Me.StylizedPanel1.Location = New System.Drawing.Point(11, 11)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel1.Size = New System.Drawing.Size(402, 147)
        Me.StylizedPanel1.Style = "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colors=~255|~255" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Text C" &
    "olor=#252b2f" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0"
        Me.StylizedPanel1.TabIndex = 83
        '
        'dlgTextArt
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(420, 341)
        Me.Controls.Add(Me.nudSize)
        Me.Controls.Add(Me.StylizedPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudAngle)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFont)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnColor1)
        Me.Controls.Add(Me.nudShadowX)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.btnShadowColor)
        Me.Controls.Add(Me.btnColor2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudShadowY)
        Me.Controls.Add(Me.btnBorderColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTextArt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Text Art"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.nudAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShadowX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShadowY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StylizedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnCancel As Tundra.StylizedButton
    Friend WithEvents btnOK As Tundra.StylizedButton
    Friend WithEvents StylizedText1 As Tundra.StylizedText
    Friend WithEvents btnColor2 As Tundra.StylizedColorButton
    Friend WithEvents btnColor1 As Tundra.StylizedColorButton
    Friend WithEvents btnBorderColor As Tundra.StylizedColorButton
    Friend WithEvents btnShadowColor As Tundra.StylizedColorButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudAngle As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudShadowX As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudShadowY As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents btnFont As Tundra.StylizedButton
    Friend WithEvents dlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents nudSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StylizedPanel1 As Tundra.StylizedPanel

End Class
