Public Class NotebookEditor

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        If LanguagePadCommon.FirstTabUpdate = True Then LanguagePadCommon.CurrentDocument.Title = txtTitle.Text
    End Sub

    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged
        If LanguagePadCommon.FirstTabUpdate = True Then LanguagePadCommon.CurrentDocument.Author = txtAuthor.Text
    End Sub

    Private Sub txtWebsite_TextChanged(sender As Object, e As EventArgs) Handles txtWebsite.TextChanged
        If LanguagePadCommon.FirstTabUpdate = True Then LanguagePadCommon.CurrentDocument.Website = txtWebsite.Text
    End Sub

    Private Sub btnGoWebsite_Click(sender As Object, e As EventArgs) Handles btnGoWebsite.Click
        If Not txtWebsite.Text.StartsWith("http://") Then
            Process.Start("http://" & txtWebsite.Text)
        ElseIf txtWebsite.Text = "" Then
            Process.Start(txtWebsite.Text)
        Else
            Process.Start(txtWebsite.Text)
        End If
    End Sub
    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        frmMain.SaveTabs()

        If lbPages.SelectedIndex > 0 Then
            frmMain.Moving = True
            frmMain.SuspendLayout()
            Dim I = lbPages.SelectedIndex - 1
            LanguagePadCommon.CurrentDocument.Pages.Insert(I, LanguagePadCommon.CurrentDocument.Pages.Item(lbPages.SelectedIndex))
            LanguagePadCommon.CurrentDocument.Pages.RemoveAt(lbPages.SelectedIndex + 1)
            frmMain.UpdateTabs()
            frmMain.Moving = False
            frmMain.ResumeLayout()
            lbPages.SelectedIndex = I
        End If
    End Sub

    Private Sub lbPages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPages.SelectedIndexChanged
        On Error Resume Next
        If frmMain.Moving = False Then frmMain.tcNotebook.SelectedIndex = lbPages.SelectedIndex
        lbPages.Focus()
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        frmMain.SaveTabs()

        If lbPages.SelectedIndex < LanguagePadCommon.CurrentDocument.Pages.Count - 1 Then
            frmMain.SuspendLayout()
            frmMain.Moving = True
            Dim I = lbPages.SelectedIndex + 2
            LanguagePadCommon.CurrentDocument.Pages.Insert(I, LanguagePadCommon.CurrentDocument.Pages.Item(lbPages.SelectedIndex))
            LanguagePadCommon.CurrentDocument.Pages.RemoveAt(lbPages.SelectedIndex)
            frmMain.UpdateTabs()
            frmMain.Moving = False
            frmMain.ResumeLayout()
            lbPages.SelectedIndex = I - 1
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmMain.btnAdd_Click(Me, e)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        frmMain.btnRemove_Click(Me, e)
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        frmMain.btnImportPage_Click(Me, e)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        frmMain.btnExportPage_Click(Me, e)
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        frmMain.btnRenamePage_Click(Me, e)
    End Sub

    Private Sub cbEmbed_CheckedChanged(sender As Object, e As EventArgs) Handles cbEmbed.CheckedChanged
        If LanguagePadCommon.FirstTabUpdate = True Then LanguagePadCommon.CurrentDocument.EmbedSymbols = cbEmbed.Checked
    End Sub

    Private Sub txtInfo_TextChanged(sender As Object, e As EventArgs) Handles txtInfo.TextChanged
        If LanguagePadCommon.FirstTabUpdate = True Then LanguagePadCommon.CurrentDocument.Info = txtInfo.Text
    End Sub

    Private Sub DoubleBufferedPanel2_Paint(sender As Object, e As PaintEventArgs) Handles DoubleBufferedPanel2.Paint

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmMain.btnSave_Click(Me, e)
    End Sub

    Private Sub btnDuplicate_Click(sender As Object, e As EventArgs) Handles btnDuplicate.Click
        frmMain.btnDuplicate_Click(Me, e)
    End Sub
End Class
