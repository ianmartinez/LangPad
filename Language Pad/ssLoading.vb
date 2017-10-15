Public NotInheritable Class ssLoading
    Private Sub ssLoading_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblVersion.Text = "Version " + SplashVersion

        If My.Settings.Theme = "Snow" Then
            BackColor = Color.White
        Else
            BackColor = SystemColors.Control
        End If
    End Sub
End Class
