Public Class NamePageDialog
    Public AddPage As Boolean = False
    Public DuplicatePage As Boolean = False
    Public CurrentPos As Integer = 0

    Private Sub NamePageDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Width = Width - (NameTextBox.Left + NameTextBox.Margin.Left + NameTextBox.Margin.Right)
    End Sub

    Private Sub OkDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OkDialogButton.Click
        MainForm.SaveTabs()
        Dim CurrentPage As Integer = MainForm.NotebookTabs.SelectedIndex

        If AddPage = True Then
            Dim NewPage As New NotebookPage With {
                .Title = NameTextBox.Text
            }

            CurrentDocument.Pages.Add(NewPage)
            MainForm.UpdateTabs()
        ElseIf DuplicatePage = True Then
            Dim NewPage As New NotebookPage With {
                .Title = NameTextBox.Text,
                .RTF = CurrentDocument.Pages(CurrentPage).RTF
            }

            CurrentDocument.Pages.Add(NewPage)
            MainForm.UpdateTabs()
        Else
            CurrentDocument.Pages.Item(MainForm.NotebookTabs.SelectedIndex).Title = NameTextBox.Text
            MainForm.UpdateTabs()
        End If

        If CurrentPage = -1 Then
            MainForm.NotebookTabs.SelectedIndex = 0
        Else
            MainForm.NotebookTabs.SelectedIndex = CurrentPage
        End If

        CurrentDocument.Modified = True
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub CancelDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancelDialogButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
