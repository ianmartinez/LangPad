Imports LangPadUI

Public Class RtfEditorForm
    Private Sub RtfEditorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RtfCodeTextBox.Text = MainForm.CurrentRtb.Rtf
        SetIcons()
    End Sub

    Public Sub SetIcons()
        Dim Res As IconResolution = GetIconResolution()

        UndoToolStripButton.Image = IconManager.Get("edit-undo", IconSize.Large, Res)
        RedoToolStripButton.Image = IconManager.Get("edit-redo", IconSize.Large, Res)
        CutToolStripButton.Image = IconManager.Get("edit-cut", IconSize.Large, Res)
        CopyToolStripButton.Image = IconManager.Get("edit-copy", IconSize.Large, Res)
        PasteToolStripButton.Image = IconManager.Get("edit-paste", IconSize.Large, Res)
        RefreshToolStripButton.Image = IconManager.Get("refresh", IconSize.Large, Res)
    End Sub

    Private Sub UndoToolStripButton_Click(sender As Object, e As EventArgs) Handles UndoToolStripButton.Click
        On Error Resume Next
        RtfCodeTextBox.Undo()
    End Sub

    Private Sub RedoToolStripButton_Click(sender As Object, e As EventArgs) Handles RedoToolStripButton.Click
        On Error Resume Next
        RtfCodeTextBox.Redo()
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        RtfCodeTextBox.Cut()
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        RtfCodeTextBox.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        RtfCodeTextBox.Paste(DataFormats.GetFormat(DataFormats.UnicodeText))
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshToolStripButton.Click
        On Error Resume Next
        MainForm.CurrentRtb.Rtf = RtfCodeTextBox.Text
        RtfCodeTextBox.Text = MainForm.CurrentRtb.Rtf
    End Sub

    Private Sub RtfEditorForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            RtfCodeTextBox.Text = MainForm.CurrentRtb.Rtf
        End If
    End Sub
End Class