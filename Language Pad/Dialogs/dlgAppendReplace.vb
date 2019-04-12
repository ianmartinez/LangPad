Public Class dlgAppendReplace
    Public Enum AppendReplaceDialogResult
        Append
        Replace
        Cancel
    End Enum
    Public Result As AppendReplaceDialogResult = AppendReplaceDialogResult.Cancel
    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Result = AppendReplaceDialogResult.Append
        Close()
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        Result = AppendReplaceDialogResult.Replace
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Result = AppendReplaceDialogResult.Cancel
        Close()
    End Sub

    Private Sub dlgAppendReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
        BringToFront()
    End Sub
End Class
