Imports LangPadSupport.Themes

Public NotInheritable Class SplashScreenForm
    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LangPadLabel.Text = GetDisplayVersion()
        BackColor = (New GlacierTheme).PanelBack
    End Sub
End Class
