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
        Me.CharEdit = New Language_Pad.CharacterEditor()
        Me.SuspendLayout
        '
        'CharEdit
        '
        Me.CharEdit.Character = "a"
        Me.CharEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CharEdit.Location = New System.Drawing.Point(0, 0)
        Me.CharEdit.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CharEdit.MinimumSize = New System.Drawing.Size(440, 0)
        Me.CharEdit.Name = "CharEdit"
        Me.CharEdit.Size = New System.Drawing.Size(508, 1151)
        Me.CharEdit.TabIndex = 0
        '
        'CharacterEditorToolWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 1151)
        Me.Controls.Add(Me.CharEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CharacterEditorToolWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Characters"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CharacterEditor1 As CharacterEditor
    Friend WithEvents CharEdit As CharacterEditor
End Class
