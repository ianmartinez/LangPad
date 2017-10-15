Public NotInheritable Class ssLoading
    Private Sub ssLoading_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblVersion.Text = "Version " + SplashVersion
    End Sub
End Class
