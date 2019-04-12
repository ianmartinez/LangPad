Public Class dlgTable
    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
        frmMain.SelectedDocument.InsertTable(nudRows.Value, nudColumns.Value, nudWidth.Value)
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub dlgTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
