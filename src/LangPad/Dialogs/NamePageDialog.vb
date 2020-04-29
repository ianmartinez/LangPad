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
        Enabled = False
        Cursor.Current = Cursors.WaitCursor
        MainForm.SaveTabs()

        If Mode = PageNameMode.Add Then
            InsertPage(CurrentPageIndex + 1, NameTextBox.Text)
        ElseIf Mode = PageNameMode.Duplicate Then
            DuplicatePage(CurrentPageIndex, NameTextBox.Text)
        ElseIf Mode = PageNameMode.Rename Then
            RenamePage(CurrentPageIndex, NameTextBox.Text)
        End If

        If CurrentPageIndex = -1 Then
            MainForm.NotebookTabs.SelectedIndex = 0
        Else
            MainForm.NotebookTabs.SelectedIndex = CurrentPageIndex
        End If

        Enabled = True
        Cursor.Current = Cursors.Default
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub CancelDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancelDialogButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
