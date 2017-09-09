Imports Tundra
Public NotInheritable Class ssLoading

    Dim PreviousPosition As New Point
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub StylizedPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles StylizedPanel1.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub

    Private Sub lblLoading_MouseMove(sender As Object, e As MouseEventArgs) Handles lblLoading.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub

    Private Sub pbLoading_MouseMove(sender As Object, e As MouseEventArgs) Handles pbLoading.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub

    Private Sub lblLanguagePad_MouseMove(sender As Object, e As MouseEventArgs) Handles lblLanguagePad.MouseMove
        Dim delta As New Size(e.X - PreviousPosition.X, e.Y - PreviousPosition.Y)
        If (e.Button = MouseButtons.Left) Then
            Me.Location += delta
            PreviousPosition = e.Location - delta
        Else
            PreviousPosition = e.Location
        End If
    End Sub

    Private Sub ssLoading_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblLanguagePad.Text = LangPadVersion
    End Sub

    Private Sub StylizedPanel1_Paint(sender As Object, e As PaintEventArgs) Handles StylizedPanel1.Paint

    End Sub
End Class
