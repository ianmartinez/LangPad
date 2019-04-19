Public Class CharacterEditorToolWindow
    Private _GetCurrentTexbox As Func(Of TextBoxBase)
    Public Property GetCurrentTexbox As Func(Of TextBoxBase)
        Get
            Return _GetCurrentTexbox
        End Get

        Set(value As Func(Of TextBoxBase))
            _GetCurrentTexbox = Function()
                                    CharTool.Focus()
                                    Return value()
                                End Function

            charEdit.GetCurrentTexbox = _GetCurrentTexbox
        End Set
    End Property

    Private Sub CharacterEditorToolWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        charEdit.GetCurrentTexbox = GetCurrentTexbox
    End Sub
End Class