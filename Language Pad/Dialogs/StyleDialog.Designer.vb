<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StyleDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StyleDialog))
        Me.PreviewRtb = New System.Windows.Forms.RichTextBox()
        Me.StylizedPanel1 = New TundraLib.DoubleBufferedPanel()
        Me.FontButton = New System.Windows.Forms.Button()
        Me.ColorButton = New TundraLib.StylizedColorButton()
        Me.RightButton = New System.Windows.Forms.Button()
        Me.CenterButton = New System.Windows.Forms.Button()
        Me.LeftButton = New System.Windows.Forms.Button()
        Me.IndentNud = New System.Windows.Forms.NumericUpDown()
        Me.IndentButton = New System.Windows.Forms.Button()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OffsetNud = New System.Windows.Forms.NumericUpDown()
        Me.OffsetButton = New System.Windows.Forms.Button()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.HighlightButton = New TundraLib.StylizedColorButton()
        Me.DeleteAllButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.StylizedPanel1.SuspendLayout()
        CType(Me.IndentNud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OffsetNud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PreviewRtb
        '
        Me.PreviewRtb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PreviewRtb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreviewRtb.Location = New System.Drawing.Point(1, 1)
        Me.PreviewRtb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PreviewRtb.Name = "PreviewRtb"
        Me.PreviewRtb.Size = New System.Drawing.Size(492, 150)
        Me.PreviewRtb.TabIndex = 0
        Me.PreviewRtb.Text = "Lorem Ipsum"
        '
        'StylizedPanel1
        '
        Me.StylizedPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StylizedPanel1.Controls.Add(Me.PreviewRtb)
        Me.StylizedPanel1.Location = New System.Drawing.Point(9, 106)
        Me.StylizedPanel1.Name = "StylizedPanel1"
        Me.StylizedPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.StylizedPanel1.Size = New System.Drawing.Size(494, 152)
        Me.StylizedPanel1.TabIndex = 84
        '
        'FontButton
        '
        Me.FontButton.BackColor = System.Drawing.Color.Transparent
        Me.FontButton.Image = CType(resources.GetObject("FontButton.Image"), System.Drawing.Image)
        Me.FontButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FontButton.Location = New System.Drawing.Point(372, 326)
        Me.FontButton.Name = "FontButton"
        Me.FontButton.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.FontButton.Size = New System.Drawing.Size(130, 54)
        Me.FontButton.TabIndex = 11
        Me.FontButton.Text = "Font"
        Me.FontButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FontButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainToolTip.SetToolTip(Me.FontButton, "Text font")
        Me.FontButton.UseVisualStyleBackColor = False
        '
        'ColorButton
        '
        Me.ColorButton.BackColor = System.Drawing.Color.Transparent
        Me.ColorButton.Color = System.Drawing.Color.Black
        Me.ColorButton.Image = CType(resources.GetObject("ColorButton.Image"), System.Drawing.Image)
        Me.ColorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ColorButton.Location = New System.Drawing.Point(189, 265)
        Me.ColorButton.MinimumSize = New System.Drawing.Size(3, 37)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.ColorButton.RightClickMode = False
        Me.ColorButton.Size = New System.Drawing.Size(108, 54)
        Me.ColorButton.TabIndex = 7
        Me.ColorButton.Text = " Text"
        Me.ColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ColorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainToolTip.SetToolTip(Me.ColorButton, "Text color")
        Me.ColorButton.UseCompatibleTextRendering = True
        Me.ColorButton.UseVisualStyleBackColor = False
        '
        'RightButton
        '
        Me.RightButton.BackColor = System.Drawing.Color.Transparent
        Me.RightButton.Image = CType(resources.GetObject("RightButton.Image"), System.Drawing.Image)
        Me.RightButton.Location = New System.Drawing.Point(129, 265)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RightButton.Size = New System.Drawing.Size(54, 54)
        Me.RightButton.TabIndex = 6
        Me.RightButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainToolTip.SetToolTip(Me.RightButton, "Right align text")
        Me.RightButton.UseVisualStyleBackColor = False
        '
        'CenterButton
        '
        Me.CenterButton.BackColor = System.Drawing.Color.Transparent
        Me.CenterButton.Image = CType(resources.GetObject("CenterButton.Image"), System.Drawing.Image)
        Me.CenterButton.Location = New System.Drawing.Point(69, 265)
        Me.CenterButton.Name = "CenterButton"
        Me.CenterButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.CenterButton.Size = New System.Drawing.Size(54, 54)
        Me.CenterButton.TabIndex = 5
        Me.CenterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CenterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainToolTip.SetToolTip(Me.CenterButton, "Center align text")
        Me.CenterButton.UseVisualStyleBackColor = False
        '
        'LeftButton
        '
        Me.LeftButton.BackColor = System.Drawing.Color.Transparent
        Me.LeftButton.Image = CType(resources.GetObject("LeftButton.Image"), System.Drawing.Image)
        Me.LeftButton.Location = New System.Drawing.Point(9, 265)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.LeftButton.Size = New System.Drawing.Size(54, 54)
        Me.LeftButton.TabIndex = 4
        Me.LeftButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LeftButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainToolTip.SetToolTip(Me.LeftButton, "Left align text")
        Me.LeftButton.UseVisualStyleBackColor = False
        '
        'IndentNud
        '
        Me.IndentNud.Location = New System.Drawing.Point(252, 342)
        Me.IndentNud.Name = "IndentNud"
        Me.IndentNud.Size = New System.Drawing.Size(114, 26)
        Me.IndentNud.TabIndex = 8
        '
        'IndentButton
        '
        Me.IndentButton.BackColor = System.Drawing.Color.Transparent
        Me.IndentButton.Image = CType(resources.GetObject("IndentButton.Image"), System.Drawing.Image)
        Me.IndentButton.Location = New System.Drawing.Point(192, 326)
        Me.IndentButton.Name = "IndentButton"
        Me.IndentButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.IndentButton.Size = New System.Drawing.Size(54, 54)
        Me.IndentButton.TabIndex = 10
        Me.IndentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainToolTip.SetToolTip(Me.IndentButton, "Indent text")
        Me.IndentButton.UseVisualStyleBackColor = False
        '
        'OpenDialog
        '
        Me.OpenDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'SaveDialog
        '
        Me.SaveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'OffsetNud
        '
        Me.OffsetNud.Location = New System.Drawing.Point(72, 342)
        Me.OffsetNud.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.OffsetNud.Name = "OffsetNud"
        Me.OffsetNud.Size = New System.Drawing.Size(114, 26)
        Me.OffsetNud.TabIndex = 10
        '
        'OffsetButton
        '
        Me.OffsetButton.BackColor = System.Drawing.Color.Transparent
        Me.OffsetButton.Image = CType(resources.GetObject("OffsetButton.Image"), System.Drawing.Image)
        Me.OffsetButton.Location = New System.Drawing.Point(12, 326)
        Me.OffsetButton.Name = "OffsetButton"
        Me.OffsetButton.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.OffsetButton.Size = New System.Drawing.Size(54, 54)
        Me.OffsetButton.TabIndex = 9
        Me.OffsetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainToolTip.SetToolTip(Me.OffsetButton, "Character Offset")
        Me.OffsetButton.UseVisualStyleBackColor = False
        '
        'HighlightButton
        '
        Me.HighlightButton.BackColor = System.Drawing.Color.Transparent
        Me.HighlightButton.Color = System.Drawing.Color.White
        Me.HighlightButton.Image = CType(resources.GetObject("HighlightButton.Image"), System.Drawing.Image)
        Me.HighlightButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HighlightButton.Location = New System.Drawing.Point(303, 265)
        Me.HighlightButton.MinimumSize = New System.Drawing.Size(3, 37)
        Me.HighlightButton.Name = "HighlightButton"
        Me.HighlightButton.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.HighlightButton.RightClickMode = False
        Me.HighlightButton.Size = New System.Drawing.Size(200, 54)
        Me.HighlightButton.TabIndex = 8
        Me.HighlightButton.Text = " Highlight"
        Me.HighlightButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HighlightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MainToolTip.SetToolTip(Me.HighlightButton, "Text color")
        Me.HighlightButton.UseCompatibleTextRendering = True
        Me.HighlightButton.UseVisualStyleBackColor = False
        '
        'DeleteAllButton
        '
        Me.DeleteAllButton.Image = CType(resources.GetObject("DeleteAllButton.Image"), System.Drawing.Image)
        Me.DeleteAllButton.Location = New System.Drawing.Point(342, 11)
        Me.DeleteAllButton.Name = "DeleteAllButton"
        Me.DeleteAllButton.Size = New System.Drawing.Size(160, 89)
        Me.DeleteAllButton.TabIndex = 3
        Me.DeleteAllButton.Text = "Clear Style"
        Me.DeleteAllButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.DeleteAllButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.Location = New System.Drawing.Point(177, 11)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(160, 89)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'OpenButton
        '
        Me.OpenButton.Image = CType(resources.GetObject("OpenButton.Image"), System.Drawing.Image)
        Me.OpenButton.Location = New System.Drawing.Point(9, 11)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(160, 89)
        Me.OpenButton.TabIndex = 1
        Me.OpenButton.Text = "Open"
        Me.OpenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.OpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'StyleDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 391)
        Me.Controls.Add(Me.DeleteAllButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.HighlightButton)
        Me.Controls.Add(Me.OffsetNud)
        Me.Controls.Add(Me.OffsetButton)
        Me.Controls.Add(Me.RightButton)
        Me.Controls.Add(Me.CenterButton)
        Me.Controls.Add(Me.LeftButton)
        Me.Controls.Add(Me.IndentNud)
        Me.Controls.Add(Me.IndentButton)
        Me.Controls.Add(Me.FontButton)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.StylizedPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StyleDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Style"
        Me.StylizedPanel1.ResumeLayout(False)
        CType(Me.IndentNud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OffsetNud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PreviewRtb As RichTextBox
    Friend WithEvents StylizedPanel1 As TundraLib.DoubleBufferedPanel
    Friend WithEvents ColorButton As TundraLib.StylizedColorButton
    Friend WithEvents IndentNud As NumericUpDown
    Friend WithEvents OpenDialog As OpenFileDialog
    Friend WithEvents SaveDialog As SaveFileDialog
    Friend WithEvents OffsetNud As NumericUpDown
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents HighlightButton As TundraLib.StylizedColorButton
    Friend WithEvents FontButton As Button
    Friend WithEvents RightButton As Button
    Friend WithEvents CenterButton As Button
    Friend WithEvents LeftButton As Button
    Friend WithEvents IndentButton As Button
    Friend WithEvents OffsetButton As Button
    Friend WithEvents DeleteAllButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents OpenButton As Button
End Class
