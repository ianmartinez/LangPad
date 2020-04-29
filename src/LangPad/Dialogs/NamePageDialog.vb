Public Enum PageNameMode
    Add
    Duplicate
    Rename
End Enum

Public Class NamePageDialog
    Public Mode As PageNameMode = PageNameMode.Rename
    Public CurrentPos As Integer = 0

    Private Sub NamePageDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Width = Width - (NameTextBox.Left + NameTextBox.Margin.Left + NameTextBox.Margin.Right)
    End Sub

    Private Sub OkDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OkDialogButton.Click
        MainForm.SaveTabs()
        Dim CurrentPage As Integer = MainForm.NotebookTabs.SelectedIndex

        If Mode = PageNameMode.Add Then
            Dim NewPage As New NotebookPage With {
                .Title = NameTextBox.Text
            }

            CurrentNotebook.Pages.Add(NewPage)
            MainForm.UpdateTabs()
        ElseIf Mode = PageNameMode.Duplicate Then
            Dim NewPage As New NotebookPage With {
                .Title = NameTextBox.Text,
                .RTF = CurrentNotebook.Pages(CurrentPage).RTF
            }

            CurrentNotebook.Pages.Add(NewPage)
            MainForm.UpdateTabs()
        ElseIf Mode = PageNameMode.Rename Then
            CurrentNotebook.Pages.Item(MainForm.NotebookTabs.SelectedIndex).Title = NameTextBox.Text
            MainForm.UpdateTabs()
        End If

        If CurrentPage = -1 Then
            MainForm.NotebookTabs.SelectedIndex = 0
        Else
            MainForm.NotebookTabs.SelectedIndex = CurrentPage
        End If

        CurrentNotebook.Modified = True
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub CancelDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancelDialogButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
