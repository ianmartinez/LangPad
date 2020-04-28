Imports System.Windows.Forms

Public Class dlgSettings


    Private Sub dlgSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbQuickUp.Checked = My.Settings.QuickUp
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        My.Settings.QuickUp = cbQuickUp.Checked
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
