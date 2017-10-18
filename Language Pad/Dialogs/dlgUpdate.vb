Imports System.Net
Imports Tundra.ZiaFile
Imports System.Windows.Forms
Public Class dlgUpdate
    Public UpdateFileText As String

    Public NewestVersion As Decimal
    Public Description As String = ""
    Public DownloadLink As String = ""
    Public RedditThread As String = ""
    Public SkipFetch As Boolean = False
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not SkipFetch = True Then FetchUpdateData()

        If Not NewestVersion > CurrentVersion Then
            MessageBox.Show("You have the latest version.")
            Close()
        End If

    End Sub

    Public Sub FetchUpdateData()
        'On Error Resume Next
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
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Not DownloadLink.StartsWith("https") Then
            DownloadLink = "https://" + DownloadLink
        End If
        Process.Start(DownloadLink)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
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
