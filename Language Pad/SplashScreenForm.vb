Imports TundraLib.Themes

Public NotInheritable Class SplashScreenForm
    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = "Version " + GetVersionString()
        BackColor = (New GlacierTheme).PanelBack
    End Sub
End Class
