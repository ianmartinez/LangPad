<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RtfEditorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RtfEditorForm))
        Me.RtfCodeTextBox = New System.Windows.Forms.RichTextBox()
        Me.MainToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UndoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RedoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MainToolStripContainer.ContentPanel.SuspendLayout()
        Me.MainToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.MainToolStripContainer.SuspendLayout()
        Me.MainToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RtfCodeTextBox
        '
        Me.RtfCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RtfCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtfCodeTextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtfCodeTextBox.ForeColor = System.Drawing.Color.Black
        Me.RtfCodeTextBox.Location = New System.Drawing.Point(0, 1)
        Me.RtfCodeTextBox.Name = "RtfCodeTextBox"
        Me.RtfCodeTextBox.Size = New System.Drawing.Size(1020, 735)
        Me.RtfCodeTextBox.TabIndex = 1
        Me.RtfCodeTextBox.Text = ""
        '
        'MainToolStripContainer
        '
        '
        'MainToolStripContainer.BottomToolStripPanel
        '
        '
        'MainToolStripContainer.ContentPanel
        '
        Me.MainToolStripContainer.ContentPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MainToolStripContainer.ContentPanel.Controls.Add(Me.RtfCodeTextBox)
        Me.MainToolStripContainer.ContentPanel.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.MainToolStripContainer.ContentPanel.Size = New System.Drawing.Size(1020, 736)
        Me.MainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'MainToolStripContainer.LeftToolStripPanel
        '
        Me.MainToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStripContainer.Name = "MainToolStripContainer"
        '
        'MainToolStripContainer.RightToolStripPanel
        '
        Me.MainToolStripContainer.Size = New System.Drawing.Size(1020, 777)
        Me.MainToolStripContainer.TabIndex = 2
        Me.MainToolStripContainer.Text = "MainToolStripContainer"
        '
        'MainToolStripContainer.TopToolStripPanel
        '
        Me.MainToolStripContainer.TopToolStripPanel.Controls.Add(Me.MainToolStrip)
        '
        'MainToolStrip
        '
        Me.MainToolStrip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MainToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripButton, Me.RedoToolStripButton, Me.ToolStripSeparator1, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.ToolStripSeparator2, Me.RefreshToolStripButton})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(1020, 41)
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
        Me.UndoToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.UndoToolStripButton.Text = "Undo"
        '
        'RedoToolStripButton
        '
        Me.RedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RedoToolStripButton.Image = CType(resources.GetObject("RedoToolStripButton.Image"), System.Drawing.Image)
        Me.RedoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RedoToolStripButton.Name = "RedoToolStripButton"
        Me.RedoToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.RedoToolStripButton.Text = "Redo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 41)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.CutToolStripButton.Text = "Cut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.CopyToolStripButton.Text = "Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.PasteToolStripButton.Text = "Paste"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 41)
        '
        'RefreshToolStripButton
        '
        Me.RefreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshToolStripButton.Image = CType(resources.GetObject("RefreshToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshToolStripButton.Name = "RefreshToolStripButton"
        Me.RefreshToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.RefreshToolStripButton.Text = "Refresh"
        '
        'RtfEditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 777)
        Me.Controls.Add(Me.MainToolStripContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RtfEditorForm"
        Me.ShowIcon = False
        Me.Text = "RTF Editor"
        Me.MainToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.MainToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.MainToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.MainToolStripContainer.ResumeLayout(False)
        Me.MainToolStripContainer.PerformLayout()
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RtfCodeTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents MainToolStripContainer As ToolStripContainer
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
