Imports System.IO
Imports System.Text
Imports LangPadData
Imports LangPadData.NotebookNT

Public Class ExportHtmlDialog
    Private Sub ExportHtmlDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleTextBox.Text = CurrentNotebook.Language
        DescriptionTextBox.Text = CurrentNotebook.Info
    End Sub

    Private Sub OkDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OkDialogButton.Click
        If SaveHtmlDialog.ShowDialog = DialogResult.OK Then
            Dim ExportSettings = New HtmlExportSettings() With {
                .Title = TitleTextBox.Text,
                .Description = DescriptionTextBox.Text,
                .DescriptionParagraphs = PElementCheck.Checked,
                .WordCol = WordColCheck.Checked,
                .PronunciationCol = PronunciationColCheck.Checked,
                .DefinitionCol = DefinitionColCheck.Checked,
                .NotesCol = NotesColCheck.Checked
            }

            CurrentNotebook.Dictionary.SaveHtml(SaveHtmlDialog.FileName, ExportSettings)
            Process.Start(SaveHtmlDialog.FileName)
        End If

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub CancelDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancelDialogButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
