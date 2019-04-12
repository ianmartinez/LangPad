Imports System.Net
Imports TundraLib.ZiaFile
Public Class dlgUpdate
    Public UpdateFileText As String
    Public StartupCheck As Boolean = True
    Public NewestVersion As Decimal
    Public Description As String = ""
    Public DownloadLink As String = ""
    Public RedditThread As String = ""
    Public SkipFetch As Boolean = False
    Public FetchError As Boolean = False
    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub dlgUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not SkipFetch = True Then FetchUpdateData()

        If Not NewestVersion > CurrentVersion And FetchError = False Then
            MessageBox.Show("You have the latest version.")
            Close()
        End If
    End Sub

    Public Sub FetchUpdateData()
        Try
            Dim updatefile As String = "https://raw.githubusercontent.com/ianmartinez/Language-Pad/master/Conlang%20Notepad/Update.txt"
            Dim fileName As String = Application.LocalUserAppDataPath & "\update.txt"
            If IO.File.Exists(fileName) Then IO.File.Delete(fileName)

            Dim downloadclient As New WebClient()
            downloadclient.DownloadFile(updatefile, fileName)

            UpdateFileText = IO.File.ReadAllText(fileName)

            NewestVersion = GetValue(UpdateFileText, "Version")
            Description = FromCompatibleString(GetValue(UpdateFileText, "Description"))
            DownloadLink = FromCompatibleString(GetValue(UpdateFileText, "DownloadLink"))
            RedditThread = FromCompatibleString(GetValue(UpdateFileText, "RedditThread"))

            lblLanguagePad.Text = "Language Pad " & NewestVersion.ToString
            Label3.Text = String.Format("The update ""Language Pad {0}"" is available.", NewestVersion.ToString())
            txtDecription.Text = Description
            txtDecription.DeselectAll()
            FetchError = False
        Catch ex As Exception
            If Not StartupCheck Then MessageBox.Show("Could not fetch update information.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FetchError = True
            Close()
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Not DownloadLink.StartsWith("https") Then
            DownloadLink = "https://" + DownloadLink
        End If
        Process.Start(DownloadLink)
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnReddit_Click(sender As Object, e As EventArgs) Handles btnReddit.Click
        If Not RedditThread.StartsWith("https") Then
            RedditThread = "https://" + RedditThread
        End If

        Process.Start(RedditThread)
    End Sub

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        Process.Start("https://github.com/ianmartinez/Language-Pad")
    End Sub

    Private Sub dlgUpdate_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        txtDecription.DeselectAll()
    End Sub

    Private Sub txtDecription_TextChanged(sender As Object, e As EventArgs) Handles txtDecription.TextChanged

    End Sub

    Private Sub txtDecription_Click(sender As Object, e As EventArgs) Handles txtDecription.Click
        txtDecription.DeselectAll()
    End Sub
End Class
