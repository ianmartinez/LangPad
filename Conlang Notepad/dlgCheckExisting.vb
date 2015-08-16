Imports System.Windows.Forms

Public Class dlgCheckExisting
    Dim FoundRows As New List(Of Integer)
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        For i = 0 To frmDictionary.dgvDictionary.RowCount - 1
            If frmDictionary.dgvDictionary.Rows.Item(i).Cells.Item(0).Value = txtWord.Text Then

                FoundRows.Add(i)
                MessageBox.Show("")
            End If
        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
