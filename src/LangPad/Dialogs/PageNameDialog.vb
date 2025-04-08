Public Enum PageNameMode
    Add
    Duplicate
    Rename
End Enum

Public Class PageNameDialog
    Public Mode As PageNameMode = PageNameMode.Rename
    Public CurrentPos As Integer = 0

    Private Sub PageNameDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Width = Width - (NameTextBox.Left + NameTextBox.Margin.Left + NameTextBox.Margin.Right)
    End Sub

    Private Sub OkDialogButton_Click(sender As Object, e As EventArgs) Handles OkDialogButton.Click
        Enabled = False
        Cursor.Current = Cursors.WaitCursor
        SavePages()

        If Mode = PageNameMode.Add Then
            InsertPage(CurrentPageIndex + 1, NameTextBox.Text)
        ElseIf Mode = PageNameMode.Duplicate Then
            DuplicatePage(CurrentPageIndex, NameTextBox.Text)
        ElseIf Mode = PageNameMode.Rename Then
            RenamePage(CurrentPageIndex, NameTextBox.Text)
        End If

        Enabled = True
        Cursor.Current = Cursors.Default
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub CancelDialogButton_Click(sender As Object, e As EventArgs) Handles CancelDialogButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub PageNameDialog_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        NameTextBox.Select()

        Select Case Mode
            Case PageNameMode.Add
                Text = "Add Page"
            Case PageNameMode.Duplicate
                Text = "Duplicate Page"
            Case PageNameMode.Rename
                Text = "Rename Page"
        End Select
    End Sub
End Class
