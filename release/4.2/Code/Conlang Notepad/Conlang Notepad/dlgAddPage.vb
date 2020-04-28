Imports System.Windows.Forms

Public Class dlgAddPage
    Public AddPage As Boolean = False
    Public DuplicatePage As Boolean = False
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        On Error Resume Next
        frmMain.SaveTabs()
        Dim CurrentPage As Integer = frmMain.tcNotebook.SelectedIndex
        For Each p As NotebookPage In LanguagePadCommon.CurrentDocument.Pages
            If txtName.Text = p.Title Then
                MessageBox.Show("A page already exists with that name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        If AddPage = True Then
            Dim p As New NotebookPage
            p.Title = txtName.Text
            LanguagePadCommon.CurrentDocument.Pages.Add(p)
            frmMain.UpdateTabs()
        ElseIf DuplicatePage = True Then
            Dim p As New NotebookPage
            p.Title = txtName.Text
            p.RTF = CurrentDocument.Pages(CurrentPage).RTF
            LanguagePadCommon.CurrentDocument.Pages.Add(p)
            frmMain.UpdateTabs()
        Else
            LanguagePadCommon.CurrentDocument.Pages.Item(frmMain.tcNotebook.SelectedIndex).Title = txtName.Text
            frmMain.UpdateTabs()
        End If

        frmMain.tcNotebook.SelectedIndex = CurrentPage
        frmMain.Modified = True
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgAddPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
