Imports TundraLib.Themes

Public NotInheritable Class ssLoading
    Private Sub ssLoading_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblVersion.Text = "Version " + SplashVersion
        BackColor = (New GlacierTheme).PanelBack
    End Sub
End Class
