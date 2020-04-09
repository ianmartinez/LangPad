Public Class AboutDialog
    Private Sub btnGitHub_Click(sender As Object, e As EventArgs)
        Process.Start("https://github.com/ianmartinez/Language-Pad")
    End Sub

    Private Sub dlgAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = "Version " + SplashVersion
    End Sub
End Class