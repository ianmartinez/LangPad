Imports System.Windows.Forms

Public Class dlgCustomZoom

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        frmMain.SelectedDocument.ZoomFactor = nudZoom.Value
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgCustomZoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        nudZoom.Value = frmMain.SelectedDocument.ZoomFactor
    End Sub
End Class
