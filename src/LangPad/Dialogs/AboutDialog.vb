Public Class AboutDialog
    Private Sub AboutDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LangPadLabel.Text = GetAppDisplayName()
    End Sub
End Class