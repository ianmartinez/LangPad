Public Class CharacterEditorToolWindow
    Private _GetCurrentTexbox As Func(Of TextBoxBase)

    Private Sub CharacterEditorToolWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CharEdit.GetCurrentTexbox = GetCurrentTexbox()
        MinimumSize = New Size(CharEdit.MinimumSize.Width + 10, CharEdit.MinimumSize.Height + 10)
        SetIcons()
    End Sub

    Public Property GetCurrentTexbox As Func(Of TextBoxBase)
        Get
            Return _GetCurrentTexbox
        End Get

        Set(value As Func(Of TextBoxBase))
            _GetCurrentTexbox = Function()
                                    CharEditWindow.Focus()
                                    Return value()
                                End Function

            CharEdit.GetCurrentTexbox = _GetCurrentTexbox
        End Set
    End Property

    Public Property TargetForm As Form
        Get
            Return Owner
        End Get

        Set(value As Form)
            Owner = value
        End Set
    End Property

    Public Sub SetIcons()
        CharEdit.SetIcons()
    End Sub

    Private Sub CharacterEditorToolWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Visible = False
        ElseIf e.CloseReason = CloseReason.FormOwnerClosing AndAlso Owner Is DictionaryForm AndAlso MainForm IsNot Nothing Then
            Owner = MainForm
            e.Cancel = True
        End If
    End Sub
End Class