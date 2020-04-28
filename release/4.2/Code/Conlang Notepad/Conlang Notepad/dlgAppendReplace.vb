Imports System.Windows.Forms

Public Class dlgAppendReplace
    Public Enum AppendReplaceDialogResult
        Append
        Replace
        Cancel
    End Enum
    Public Result As AppendReplaceDialogResult = AppendReplaceDialogResult.Cancel
    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Me.Result = AppendReplaceDialogResult.Append
        Me.Close()
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        Me.Result = AppendReplaceDialogResult.Replace
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Result = AppendReplaceDialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgAppendReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.BringToFront()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
