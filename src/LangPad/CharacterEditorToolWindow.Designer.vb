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
        CharEdit = New CharacterEditor()
        SuspendLayout()
        ' 
        ' CharEdit
        ' 
        CharEdit.Character = "a"
        CharEdit.Dock = DockStyle.Fill
        CharEdit.Location = New Point(0, 0)
        CharEdit.Margin = New Padding(5, 8, 5, 8)
        CharEdit.MinimumSize = New Size(391, 0)
        CharEdit.Name = "CharEdit"
        CharEdit.Size = New Size(492, 853)
        CharEdit.TabIndex = 0
        ' 
        ' CharacterEditorToolWindow
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(492, 853)
        Controls.Add(CharEdit)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "CharacterEditorToolWindow"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Character Editor"
        ResumeLayout(False)

    End Sub

    Friend WithEvents CharEdit As CharacterEditor
End Class
