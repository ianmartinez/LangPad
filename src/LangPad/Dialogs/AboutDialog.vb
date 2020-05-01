Imports LangPadUI

Public Class AboutDialog
    Private Sub AboutDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LangPadLabel.Text = GetAppDisplayName()
        SetIcons()
    End Sub

    Public Sub SetIcons()
        Dim Res As IconResolution = GetIconResolution()

        PatreonButton.Image = IconManager.Get("patreon", IconSize.Large, Res)
        GitHubButton.Image = IconManager.Get("github", IconSize.Large, Res)
        WebsiteButton.Image = IconManager.Get("web", IconSize.Large, Res)

        ' Some weird bug in the WinForms TableLayout doesn't calculate the
        ' autosize correctly until you force it to re-calculate after adding
        ' the icons
        MainTabControl.Height = 100
    End Sub

    Private Sub PatreonButton_Click(sender As Object, e As EventArgs) Handles PatreonButton.Click
        GoToPatreon()
    End Sub

    Private Sub GitHubButton_Click(sender As Object, e As EventArgs) Handles GitHubButton.Click
        GoToGitHub()
    End Sub

    Private Sub WebsiteButton_Click(sender As Object, e As EventArgs) Handles WebsiteButton.Click
        GoToWebsite()
    End Sub
End Class