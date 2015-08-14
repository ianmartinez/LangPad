Imports Tundra

Public Class frmDictionary
    Private Sub StylizedButton3_Click(sender As Object, e As EventArgs) Handles StylizedButton3.Click

    End Sub

    Private Sub StylizedButton4_Click(sender As Object, e As EventArgs) Handles StylizedButton4.Click

    End Sub

    Public Sub InsertIPA(sender As Object, e As EventArgs)
        Dim Button As Button = CType(sender, Button)
        ''  frmMain.InsertText(SelectedDocument, Button.Text)
    End Sub

    Private Sub frmDictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.ForceSansSerif = True Then
            Me.Font = New Font("Microsoft Sans Serif", "8.25")
        End If

        pnlTop.Height = pnlTabs.Height + pnlHome.Height
    End Sub
End Class