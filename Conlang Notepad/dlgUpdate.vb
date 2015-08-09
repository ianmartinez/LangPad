Imports System.Net
Imports Tundra.ZiaFile
Imports System.Windows.Forms
Public Class dlgUpdate
    Public UpdateFileText As String
    Public CurrentVersion As Decimal = (Application.ProductVersion.Split(".").GetValue(0) & "." & Application.ProductVersion.Split(".").GetValue(1))
    Public NewestVersion As Decimal
    Public Description As String = ""
    Public DownloadLink As String = ""
    Public RedditThread As String = ""
    Public SkipFetch As Boolean = False
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not SkipFetch = True Then FetchUpdateData()

        If Not NewestVersion > CurrentVersion Then
            MessageBox.Show("You have the latest version")
            Me.Close()
        End If

    End Sub

    Public Sub FetchUpdateData()
        'On Error Resume Next
        Dim updatefile As String = "https://raw.githubusercontent.com/ianmartinez/Language-Pad/master/Conlang%20Notepad/Update.txt"
        Dim fileName As String = Application.LocalUserAppDataPath & "\update.txt"
        If System.IO.File.Exists(fileName) Then System.IO.File.Delete(fileName)

        Dim downloadclient As New WebClient()
        downloadclient.DownloadFile(updatefile, fileName)

        UpdateFileText = IO.File.ReadAllText(fileName)

        NewestVersion = GetValue(UpdateFileText, "Version")
        Description = FromCompatibleString(GetValue(UpdateFileText, "Description"))
        DownloadLink = FromCompatibleString(GetValue(UpdateFileText, "DownloadLink"))
        RedditThread = FromCompatibleString(GetValue(UpdateFileText, "RedditThread"))

        lblLanguagePad.Text = "Language Pad " & NewestVersion.ToString & " Update"
        txtDecription.Text = "What's new:" & Environment.NewLine & Description

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Process.Start(DownloadLink)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnReddit_Click(sender As Object, e As EventArgs) Handles btnReddit.Click
        Process.Start(RedditThread)
    End Sub
End Class
