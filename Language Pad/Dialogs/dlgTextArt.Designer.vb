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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.nudAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShadowX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudShadowY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StylizedPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StylizedText1
        '
        Me.StylizedText1.BackgroundImage = CType(resources.GetObject("StylizedText1.BackgroundImage"), System.Drawing.Image)
        Me.StylizedText1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StylizedText1.ControlText = "Text Art"
        Me.StylizedText1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StylizedText1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StylizedText1.Location = New System.Drawing.Point(2, 2)
        Me.StylizedText1.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedText1.Name = "StylizedText1"
        Me.StylizedText1.Size = New System.Drawing.Size(798, 279)
        Me.StylizedText1.Style = "Colors=#e6832a|#c74c4f" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=$1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shadow Color=$2" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shadow Offset=(2,2)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Size=1 "
        Me.StylizedText1.TabIndex = 69
        '
        'btnColor2
        '
        Me.btnColor2.BackColor = System.Drawing.Color.Transparent
        Me.btnColor2.BackgroundImage = CType(resources.GetObject("btnColor2.BackgroundImage"), System.Drawing.Image)
        Me.btnColor2.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnColor2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnColor2.FlatAppearance.BorderSize = 0
        Me.btnColor2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnColor2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor2.ForeColor = System.Drawing.Color.Black
        Me.btnColor2.Image = CType(resources.GetObject("btnColor2.Image"), System.Drawing.Image)
        Me.btnColor2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor2.Location = New System.Drawing.Point(172, 313)
        Me.btnColor2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnColor2.MinimumSize = New System.Drawing.Size(4, 46)
        Me.btnColor2.Name = "btnColor2"
        Me.btnColor2.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnColor2.Size = New System.Drawing.Size(140, 46)
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
        Me.btnColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnColor1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnColor1.FlatAppearance.BorderSize = 0
        Me.btnColor1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnColor1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor1.ForeColor = System.Drawing.Color.Black
        Me.btnColor1.Image = CType(resources.GetObject("btnColor1.Image"), System.Drawing.Image)
        Me.btnColor1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor1.Location = New System.Drawing.Point(22, 313)
        Me.btnColor1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnColor1.MinimumSize = New System.Drawing.Size(4, 46)
        Me.btnColor1.Name = "btnColor1"
        Me.btnColor1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnColor1.Size = New System.Drawing.Size(140, 46)
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
        Me.btnBorderColor.Location = New System.Drawing.Point(322, 313)
        Me.btnBorderColor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorderColor.MinimumSize = New System.Drawing.Size(4, 46)
        Me.btnBorderColor.Name = "btnBorderColor"
        Me.btnBorderColor.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnBorderColor.Size = New System.Drawing.Size(178, 46)
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
        Me.btnShadowColor.Location = New System.Drawing.Point(510, 313)
        Me.btnShadowColor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShadowColor.MinimumSize = New System.Drawing.Size(4, 46)
        Me.btnShadowColor.Name = "btnShadowColor"
        Me.btnShadowColor.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnShadowColor.Size = New System.Drawing.Size(178, 46)
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
        Me.Label1.Location = New System.Drawing.Point(20, 379)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Angle:"
        '
        'nudAngle
        '
        Me.nudAngle.Location = New System.Drawing.Point(101, 375)
        Me.nudAngle.Margin = New System.Windows.Forms.Padding(4)
        Me.nudAngle.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudAngle.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.nudAngle.Name = "nudAngle"
        Me.nudAngle.Size = New System.Drawing.Size(76, 31)
        Me.nudAngle.TabIndex = 7
        Me.nudAngle.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'nudShadowX
        '
        Me.nudShadowX.Location = New System.Drawing.Point(308, 375)
        Me.nudShadowX.Margin = New System.Windows.Forms.Padding(4)
        Me.nudShadowX.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudShadowX.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.nudShadowX.Name = "nudShadowX"
        Me.nudShadowX.Size = New System.Drawing.Size(76, 31)
        Me.nudShadowX.TabIndex = 8
        Me.nudShadowX.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 379)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Shadow X:"
        '
        'nudShadowY
        '
        Me.nudShadowY.Location = New System.Drawing.Point(516, 375)
        Me.nudShadowY.Margin = New System.Windows.Forms.Padding(4)
        Me.nudShadowY.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudShadowY.Minimum = New Decimal(New Integer() {360, 0, 0, -2147483648})
        Me.nudShadowY.Name = "nudShadowY"
        Me.nudShadowY.Size = New System.Drawing.Size(76, 31)
        Me.nudShadowY.TabIndex = 9
        Me.nudShadowY.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(392, 379)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 25)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Shadow Y:"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(22, 425)
        Me.txtText.Margin = New System.Windows.Forms.Padding(4)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(799, 150)
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
        Me.btnFont.Location = New System.Drawing.Point(696, 313)
        Me.btnFont.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnFont.Size = New System.Drawing.Size(128, 46)
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
        Me.nudSize.Location = New System.Drawing.Point(738, 375)
        Me.nudSize.Margin = New System.Windows.Forms.Padding(4)
        Me.nudSize.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudSize.Name = "nudSize"
        Me.nudSize.Size = New System.Drawing.Size(83, 31)
        Me.nudSize.TabIndex = 10
        Me.nudSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(600, 377)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Border Size:"
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.StylizedText1)
        Me.StylizedPanel1.Location = New System.Drawing.Point(22, 21)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedPanel1.Size = New System.Drawing.Size(802, 283)
        Me.StylizedPanel1.Style = "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colors=~255|~255" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Text C" &
    "olor=#252b2f" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0"
        Me.StylizedPanel1.TabIndex = 83
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(532, 585)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(292, 56)
        Me.TableLayoutPanel1.TabIndex = 84
        '
        'btnOK
        '
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(140, 50)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.Location = New System.Drawing.Point(149, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 50)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dlgTextArt
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(850, 656)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.nudSize)
        Me.Controls.Add(Me.StylizedPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudAngle)
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
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTextArt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Text Art"
        CType(Me.nudAngle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShadowX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudShadowY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StylizedPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
End Class
