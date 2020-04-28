Public Class CustomZoomDialog
    Private Sub CustomZoomDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        ZoomNud.Value = MainForm.CurrentRtb.ZoomFactor
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
