<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterEditorToolWindow
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
        Me.charEdit = New Language_Pad.CharacterEditor()
        Me.SuspendLayout()
        '
        'charEdit
        '
        Me.charEdit.Character = "a"
        Me.charEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.charEdit.Location = New System.Drawing.Point(0, 0)
        Me.charEdit.MinimumSize = New System.Drawing.Size(293, 0)
        Me.charEdit.Name = "charEdit"
        Me.charEdit.Size = New System.Drawing.Size(339, 748)
        Me.charEdit.TabIndex = 0
        '
        'CharacterEditorToolWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 748)
        Me.Controls.Add(Me.charEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CharacterEditorToolWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Characters"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CharacterEditor1 As CharacterEditor
    Friend WithEvents charEdit As CharacterEditor
End Class
