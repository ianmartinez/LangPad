Imports System.Net
Imports TundraLib.ZiaFile
Public Class UpdateDialog
    Public UpdateFileText As String
    Public StartupCheck As Boolean = True
    Public NewestVersion As Decimal
    Public Description As String = ""
    Public DownloadLink As String = ""
    Public RedditThread As String = ""
    Public SkipFetch As Boolean = False
    Public FetchError As Boolean = False

    Private Sub UpdateDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not SkipFetch = True Then FetchUpdateData()

        If Not NewestVersion > GetCurrentVersionDecimal() And FetchError = False Then
            MessageBox.Show("You have the latest version.")
            Close()
        End If
    End Sub

    Public Sub FetchUpdateData()
        Try
            Dim UpdateFile As String = "https://raw.githubusercontent.com/ianmartinez/Language-Pad/master/Conlang%20Notepad/Update.txt"
            Dim FileName As String = Application.LocalUserAppDataPath & "\update.txt"
            If IO.File.Exists(FileName) Then IO.File.Delete(FileName)

            Dim DownloadClient As New WebClient()
            DownloadClient.DownloadFile(UpdateFile, FileName)

            UpdateFileText = IO.File.ReadAllText(FileName)

            NewestVersion = GetValue(UpdateFileText, "Version")
            Description = FromCompatibleString(GetValue(UpdateFileText, "Description"))
            DownloadLink = FromCompatibleString(GetValue(UpdateFileText, "DownloadLink"))
            RedditThread = FromCompatibleString(GetValue(UpdateFileText, "RedditThread"))

            LanguagePadLabel.Text = "Language Pad " & NewestVersion.ToString()
            StatusLabel.Text = String.Format("The update ""Language Pad {0}"" is available.", NewestVersion.ToString())
            DescriptionTextBox.Text = Description
            DescriptionTextBox.DeselectAll()
            FetchError = False
        Catch Ex As Exception
            If Not StartupCheck Then MessageBox.Show("Could not fetch update information.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FetchError = True
            Close()
        End Try
    End Sub

    Private Sub OkDialogButton_Click(sender As Object, e As EventArgs) Handles OkDialogButton.Click
        If Not DownloadLink.StartsWith("https") Then
            DownloadLink = "https://" + DownloadLink
        End If

        Process.Start(DownloadLink)
        Close()
    End Sub

    Private Sub CancelDialogButton_Click(sender As Object, e As EventArgs) Handles CancelDialogButton.Click
        Close()
    End Sub

    Private Sub RedditButton_Click(sender As Object, e As EventArgs) Handles RedditButton.Click
        If Not RedditThread.StartsWith("https") Then
            RedditThread = "https://" + RedditThread
        End If

        Process.Start(RedditThread)
    End Sub

    Private Sub SourceButton_Click(sender As Object, e As EventArgs) Handles SourceButton.Click
        Process.Start("https://github.com/ianmartinez/Language-Pad")
    End Sub

    Private Sub UpdateDialog_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        DescriptionTextBox.DeselectAll()
    End Sub

    Private Sub DescriptionTextBox_Click(sender As Object, e As EventArgs) Handles DescriptionTextBox.Click
        DescriptionTextBox.DeselectAll()
    End Sub
End Class
