Public Class dlgAbout
    Private Sub btnGitHub_Click(sender As Object, e As EventArgs)
        Process.Start("https://github.com/ianmartinez/Language-Pad")
    End Sub

    Private Sub dlgAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLanguagePad.Text = LangPadVersion
    End Sub

    Private Sub btnCheckUpdates_Click(sender As Object, e As EventArgs)
        dlgUpdate.SkipFetch = False
        dlgUpdate.TopMost = False
        dlgUpdate.ShowDialog()
    End Sub
End Class