Public Class dlgAddPage
    Public AddPage As Boolean = False
    Public DuplicatePage As Boolean = False
    Public CurrentPos As Integer = 0

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        On Error Resume Next
        frmMain.SaveTabs()
        Dim CurrentPage As Integer = frmMain.tcNotebook.SelectedIndex

        If AddPage = True Then
            Dim p As New NotebookPage With {
                .Title = txtName.Text
            }
            CurrentDocument.Pages.Add(p)
            frmMain.UpdateTabs()
        ElseIf DuplicatePage = True Then
            Dim p As New NotebookPage With {
                .Title = txtName.Text,
                .RTF = CurrentDocument.Pages(CurrentPage).RTF
            }
            CurrentDocument.Pages.Add(p)
            frmMain.UpdateTabs()
        Else
            CurrentDocument.Pages.Item(frmMain.tcNotebook.SelectedIndex).Title = txtName.Text
            frmMain.UpdateTabs()
        End If

        frmMain.tcNotebook.SelectedIndex = CurrentPage
        CurrentDocument.Modified = True
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub dlgAddPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Width = Width - (txtName.Left + txtName.Margin.Left + txtName.Margin.Right)
    End Sub
End Class
