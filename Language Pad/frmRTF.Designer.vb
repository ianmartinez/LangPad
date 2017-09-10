<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRTF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRTF))
        Me.txtRTF = New System.Windows.Forms.RichTextBox()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UndoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RedoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRTF
        '
        Me.txtRTF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRTF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRTF.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRTF.ForeColor = System.Drawing.Color.Black
        Me.txtRTF.Location = New System.Drawing.Point(0, 0)
        Me.txtRTF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRTF.Name = "txtRTF"
        Me.txtRTF.Size = New System.Drawing.Size(1360, 933)
        Me.txtRTF.TabIndex = 1
        Me.txtRTF.Text = ""
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.txtRTF)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1360, 933)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1360, 971)
        Me.ToolStripContainer1.TabIndex = 2
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
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripButton, Me.RedoToolStripButton, Me.ToolStripSeparator1, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.ToolStripSeparator2, Me.RefreshToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(1360, 38)
        Me.MainToolStrip.Stretch = True
        Me.MainToolStrip.TabIndex = 0
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoToolStripButton.Image = CType(resources.GetObject("UndoToolStripButton.Image"), System.Drawing.Image)
        Me.UndoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoToolStripButton.Name = "UndoToolStripButton"
        Me.UndoToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.UndoToolStripButton.Text = "Undo"
        '
        'RedoToolStripButton
        '
        Me.RedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RedoToolStripButton.Image = CType(resources.GetObject("RedoToolStripButton.Image"), System.Drawing.Image)
        Me.RedoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RedoToolStripButton.Name = "RedoToolStripButton"
        Me.RedoToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.RedoToolStripButton.Text = "Redo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.CutToolStripButton.Text = "Cut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.CopyToolStripButton.Text = "Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.PasteToolStripButton.Text = "Paste"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'RefreshToolStripButton
        '
        Me.RefreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshToolStripButton.Image = CType(resources.GetObject("RefreshToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshToolStripButton.Name = "RefreshToolStripButton"
        Me.RefreshToolStripButton.Size = New System.Drawing.Size(28, 35)
        Me.RefreshToolStripButton.Text = "Refresh"
        '
        'frmRTF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 971)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRTF"
        Me.ShowIcon = False
        Me.Text = "RTF Editor"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRTF As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents UndoToolStripButton As ToolStripButton
    Friend WithEvents RedoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents RefreshToolStripButton As ToolStripButton
End Class
