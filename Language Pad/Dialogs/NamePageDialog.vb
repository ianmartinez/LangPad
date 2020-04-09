Public Class NamePageDialog
    Public AddPage As Boolean = False
    Public DuplicatePage As Boolean = False
    Public CurrentPos As Integer = 0

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        MainForm.SaveTabs()
        Dim CurrentPage As Integer = MainForm.tcNotebook.SelectedIndex

        If AddPage = True Then
            Dim p As New NotebookPage With {
                .Title = txtName.Text
            }
            CurrentDocument.Pages.Add(p)
            MainForm.UpdateTabs()
        ElseIf DuplicatePage = True Then
            Dim p As New NotebookPage With {
                .Title = txtName.Text,
                .RTF = CurrentDocument.Pages(CurrentPage).RTF
            }
            CurrentDocument.Pages.Add(p)
            MainForm.UpdateTabs()
        Else
            CurrentDocument.Pages.Item(MainForm.tcNotebook.SelectedIndex).Title = txtName.Text
            MainForm.UpdateTabs()
        End If

        If CurrentPage = -1 Then
            MainForm.tcNotebook.SelectedIndex = 0
        Else
            MainForm.tcNotebook.SelectedIndex = CurrentPage
        End If

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
