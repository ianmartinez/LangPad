Public Class CharacterEditorToolWindow
    Private _GetCurrentTexbox As Func(Of TextBoxBase)

    Private Sub CharacterEditorToolWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CharEdit.GetCurrentTexbox = GetCurrentTexbox()
        MinimumSize = New Size(CharEdit.MinimumSize.Width + 10, CharEdit.MinimumSize.Height + 10)
        KeyPreview = True
        SetIcons()
    End Sub

    ''' <summary>
    ''' The current text box that text will be inserted into.
    ''' </summary>
    Public Property GetCurrentTexbox As Func(Of TextBoxBase)
        Get
            Return _GetCurrentTexbox
        End Get

        Set(value As Func(Of TextBoxBase))
            _GetCurrentTexbox = Function()
                                    Return value()
                                End Function

            CharEdit.GetCurrentTexbox = _GetCurrentTexbox
        End Set
    End Property

    ''' <summary>
    ''' The target form of the character editor.
    ''' </summary>
    Public Property TargetForm As Form
        Get
            Return Owner
        End Get

        Set(value As Form)
            Owner = value
        End Set
    End Property

    ''' <summary>
    ''' Update the icons to match the current resolution.
    ''' </summary>
    Public Sub SetIcons()
        CharEdit.SetIcons()
    End Sub

    ''' <summary>
    ''' Catch closing events to prevent the window from closing automatically
    ''' when it shouldn't.
    ''' </summary>
    Private Sub CharacterEditorToolWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Visible = False
        ElseIf e.CloseReason = CloseReason.FormOwnerClosing AndAlso Owner Is DictionaryForm AndAlso MainForm IsNot Nothing Then
            Owner = MainForm
            e.Cancel = True
        End If
    End Sub

    ''' <summary>
    ''' Catch CTRL+S to enable saving on forms besides the main one.
    ''' </summary>
    Private Sub CharacterEditorToolWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, CharEdit.KeyDown
        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            MainForm.FileSave()
        End If
    End Sub

    ''' <summary>
    ''' If visible, hide and show again.
    ''' </summary>
    Public Sub Reshow()
        If Visible Then
            Hide()
            Show()
        End If
    End Sub
End Class