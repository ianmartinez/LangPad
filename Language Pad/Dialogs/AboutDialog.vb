Public Class AboutDialog
    Private Sub AboutDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionLabel.Text = "Version " + GetVersionString()
    End Sub
End Class