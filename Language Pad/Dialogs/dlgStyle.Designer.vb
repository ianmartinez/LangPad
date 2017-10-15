<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgStyle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgStyle))
        Me.rtbPreview = New System.Windows.Forms.RichTextBox()
        Me.StylizedPanel1 = New Tundra.StylizedPanel()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.btnColor = New Tundra.StylizedColorButton()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnCenter = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.nudIndent = New System.Windows.Forms.NumericUpDown()
        Me.btnIndent = New System.Windows.Forms.Button()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.nudOffset = New System.Windows.Forms.NumericUpDown()
        Me.btnOffset = New System.Windows.Forms.Button()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnHighlight = New Tundra.StylizedColorButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
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
        Me.rtbPreview.Size = New System.Drawing.Size(654, 186)
        Me.rtbPreview.TabIndex = 0
        Me.rtbPreview.Text = "Lorem Ipsum"
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StylizedPanel1.Controls.Add(Me.rtbPreview)
        Me.StylizedPanel1.Location = New System.Drawing.Point(13, 110)
        Me.StylizedPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.StylizedPanel1.Size = New System.Drawing.Size(658, 190)
        Me.StylizedPanel1.Style = "Radius=0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colors=~255|~255" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Positions=0|1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Angle=-90" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Border Color=~220" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Text C" &
    "olor=#252b2f" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Highlight Color=$0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bottom Only=0"
        Me.StylizedPanel1.TabIndex = 84
        '
        'btnFont
        '
        Me.btnFont.BackColor = System.Drawing.Color.Transparent
        Me.btnFont.Image = CType(resources.GetObject("btnFont.Image"), System.Drawing.Image)
        Me.btnFont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFont.Location = New System.Drawing.Point(497, 384)
        Me.btnFont.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.btnFont.Size = New System.Drawing.Size(174, 68)
        Me.btnFont.TabIndex = 3
        Me.btnFont.Text = "Font"
        Me.btnFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnFont, "Text font")
        Me.btnFont.UseVisualStyleBackColor = False
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.Transparent
        Me.btnColor.Color = System.Drawing.Color.Black
        Me.btnColor.Image = CType(resources.GetObject("btnColor.Image"), System.Drawing.Image)
        Me.btnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor.Location = New System.Drawing.Point(253, 308)
        Me.btnColor.Margin = New System.Windows.Forms.Padding(4)
        Me.btnColor.MinimumSize = New System.Drawing.Size(4, 46)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.RightClickMode = False
        Me.btnColor.Size = New System.Drawing.Size(144, 68)
        Me.btnColor.TabIndex = 1
        Me.btnColor.Text = " Text"
        Me.btnColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnColor, "Text color")
        Me.btnColor.UseCompatibleTextRendering = True
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.Transparent
        Me.btnRight.Image = CType(resources.GetObject("btnRight.Image"), System.Drawing.Image)
        Me.btnRight.Location = New System.Drawing.Point(173, 308)
        Me.btnRight.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnRight.Size = New System.Drawing.Size(72, 68)
        Me.btnRight.TabIndex = 6
        Me.btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnRight, "Right align text")
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnCenter
        '
        Me.btnCenter.BackColor = System.Drawing.Color.Transparent
        Me.btnCenter.Image = CType(resources.GetObject("btnCenter.Image"), System.Drawing.Image)
        Me.btnCenter.Location = New System.Drawing.Point(93, 308)
        Me.btnCenter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCenter.Name = "btnCenter"
        Me.btnCenter.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnCenter.Size = New System.Drawing.Size(72, 68)
        Me.btnCenter.TabIndex = 5
        Me.btnCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnCenter, "Center align text")
        Me.btnCenter.UseVisualStyleBackColor = False
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.Transparent
        Me.btnLeft.Image = CType(resources.GetObject("btnLeft.Image"), System.Drawing.Image)
        Me.btnLeft.Location = New System.Drawing.Point(13, 308)
        Me.btnLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnLeft.Size = New System.Drawing.Size(72, 68)
        Me.btnLeft.TabIndex = 4
        Me.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnLeft, "Left align text")
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'nudIndent
        '
        Me.nudIndent.Location = New System.Drawing.Point(337, 404)
        Me.nudIndent.Margin = New System.Windows.Forms.Padding(4)
        Me.nudIndent.Name = "nudIndent"
        Me.nudIndent.Size = New System.Drawing.Size(152, 31)
        Me.nudIndent.TabIndex = 8
        '
        'btnIndent
        '
        Me.btnIndent.BackColor = System.Drawing.Color.Transparent
        Me.btnIndent.Image = CType(resources.GetObject("btnIndent.Image"), System.Drawing.Image)
        Me.btnIndent.Location = New System.Drawing.Point(257, 384)
        Me.btnIndent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIndent.Name = "btnIndent"
        Me.btnIndent.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnIndent.Size = New System.Drawing.Size(72, 68)
        Me.btnIndent.TabIndex = 7
        Me.btnIndent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnIndent, "Indent text")
        Me.btnIndent.UseVisualStyleBackColor = False
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
        Me.nudOffset.Location = New System.Drawing.Point(97, 404)
        Me.nudOffset.Margin = New System.Windows.Forms.Padding(4)
        Me.nudOffset.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudOffset.Name = "nudOffset"
        Me.nudOffset.Size = New System.Drawing.Size(152, 31)
        Me.nudOffset.TabIndex = 10
        '
        'btnOffset
        '
        Me.btnOffset.BackColor = System.Drawing.Color.Transparent
        Me.btnOffset.Image = CType(resources.GetObject("btnOffset.Image"), System.Drawing.Image)
        Me.btnOffset.Location = New System.Drawing.Point(15, 384)
        Me.btnOffset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOffset.Name = "btnOffset"
        Me.btnOffset.Padding = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.btnOffset.Size = New System.Drawing.Size(72, 68)
        Me.btnOffset.TabIndex = 9
        Me.btnOffset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnOffset, "Character Offset")
        Me.btnOffset.UseVisualStyleBackColor = False
        '
        'btnHighlight
        '
        Me.btnHighlight.BackColor = System.Drawing.Color.Transparent
        Me.btnHighlight.Color = System.Drawing.Color.White
        Me.btnHighlight.Image = CType(resources.GetObject("btnHighlight.Image"), System.Drawing.Image)
        Me.btnHighlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHighlight.Location = New System.Drawing.Point(405, 308)
        Me.btnHighlight.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHighlight.MinimumSize = New System.Drawing.Size(4, 46)
        Me.btnHighlight.Name = "btnHighlight"
        Me.btnHighlight.RightClickMode = False
        Me.btnHighlight.Size = New System.Drawing.Size(266, 68)
        Me.btnHighlight.TabIndex = 2
        Me.btnHighlight.Text = " Highlight"
        Me.btnHighlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHighlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttMain.SetToolTip(Me.btnHighlight, "Text color")
        Me.btnHighlight.UseCompatibleTextRendering = True
        Me.btnHighlight.UseVisualStyleBackColor = False
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Image = CType(resources.GetObject("btnDeleteAll.Image"), System.Drawing.Image)
        Me.btnDeleteAll.Location = New System.Drawing.Point(457, 13)
        Me.btnDeleteAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(214, 89)
        Me.btnDeleteAll.TabIndex = 87
        Me.btnDeleteAll.Text = "Clear Style"
        Me.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(235, 13)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(214, 89)
        Me.btnSave.TabIndex = 86
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.Location = New System.Drawing.Point(13, 13)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(214, 89)
        Me.btnOpen.TabIndex = 85
        Me.btnOpen.Text = "Open"
        Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'dlgStyle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 478)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnHighlight)
        Me.Controls.Add(Me.nudOffset)
        Me.Controls.Add(Me.btnOffset)
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
    Friend WithEvents btnColor As Tundra.StylizedColorButton
    Friend WithEvents nudIndent As NumericUpDown
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents dlgSave As SaveFileDialog
    Friend WithEvents nudOffset As NumericUpDown
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents btnHighlight As Tundra.StylizedColorButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnFont As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnCenter As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnIndent As Button
    Friend WithEvents btnOffset As Button
    Friend WithEvents btnDeleteAll As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnOpen As Button
End Class
