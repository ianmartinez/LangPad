Public Class CustomZoomDialog
    Private Sub CustomZoomDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ZoomNud.Value = MainForm.CurrentRtb.ZoomFactor
        Catch ex As Exception
            ZoomNud.Value = 1
        End Try
    End Sub

    Private Sub OkDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OkDialogButton.Click
        MainForm.CurrentRtb.ZoomFactor = ZoomNud.Value
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub CancelDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OkDialogButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
