Public Class frmRTF

    Private Sub frmRTF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlTop.Height = pnlTabs.Height + pnlMain.Height
        Me.txtRTF.Text = frmMain.SelectedDocument.Rtf
    End Sub
   

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        On Error Resume Next
        txtRTF.Undo()
    End Sub

    Private Sub btnRedo_Click(sender As Object, e As EventArgs) Handles btnRedo.Click
        On Error Resume Next
        txtRTF.Redo()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        txtRTF.Copy()
    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        Dim df As DataFormats.Format = DataFormats.GetFormat(DataFormats.UnicodeText)
        txtRTF.Paste(df)
    End Sub

    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click
        txtRTF.Cut()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        On Error Resume Next
        frmMain.SelectedDocument.Rtf = Me.txtRTF.Text
        Me.txtRTF.Text = frmMain.SelectedDocument.Rtf
    End Sub
End Class