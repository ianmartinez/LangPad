Imports System.Windows.Forms
Imports System.Text

Public Class dlgTable
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        frmMain.SelectedDocument.InsertTable(nudRows.Value, nudColumns.Value, nudWidth.Value)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
