Public Class dlgCustomZoom

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        frmMain.SelectedDocument.ZoomFactor = nudZoom.Value
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub dlgCustomZoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        nudZoom.Value = frmMain.SelectedDocument.ZoomFactor
    End Sub
End Class
