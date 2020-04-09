Imports System.IO
Imports System.Text

Public Class ExportHtmlDialog
    Public FilePath As String = ""

    Private Sub ExportHtmlDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitleTextBox.Text = CurrentDocument.Language
        DescriptionTextBox.Text = CurrentDocument.Info
    End Sub

    Private Sub OkDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OkDialogButton.Click
        Dim Writer As New StreamWriter(New FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite), Encoding.UTF8)
        Dim SortedWords As List(Of DictionaryWord) = New List(Of DictionaryWord)

        For Each Word As DictionaryWord In CurrentDocument.WordDictionary.Words
            SortedWords.Add(Word)
        Next

        SortedWords.Sort()

        Dim DescriptionIndent As String = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab
        Dim Description As String = DescriptionIndent + DescriptionTextBox.Text

        If PElementCheck.Checked Then
            Description = ""
            Dim Lines As String() = DescriptionTextBox.Text.Split(New String() {Environment.NewLine, vbCrLf, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries)

            For Each Line As String In Lines
                Description += DescriptionIndent + "<p>" + Environment.NewLine
                Description += DescriptionIndent + ControlChars.Tab + Line + Environment.NewLine
                Description += DescriptionIndent + "</p>" + Environment.NewLine
            Next
        End If

        Dim RowList As String = ""
        Dim RowIndent As String = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab
        Dim RowDataIndent As String = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab + ControlChars.Tab

        If WordColCheck.Checked Or PronunciationColCheck.Checked Or DefinitionColCheck.Checked Or NotesColCheck.Checked Then
            RowList += RowIndent + "<tr>" + Environment.NewLine
            RowList += If(WordColCheck.Checked, RowDataIndent + "<th>Word</th>" + Environment.NewLine, "")
            RowList += If(PronunciationColCheck.Checked, RowDataIndent + "<th>Pronunciation</th>" + Environment.NewLine, "")
            RowList += If(DefinitionColCheck.Checked, RowDataIndent + "<th>Definition</th>" + Environment.NewLine, "")
            RowList += If(NotesColCheck.Checked, RowDataIndent + "<th>Notes</th>" + Environment.NewLine, "")
            RowList += RowIndent + "</tr>" + Environment.NewLine
        End If

        For i As Integer = 0 To SortedWords.Count - 1
            Dim word As DictionaryWord = SortedWords(i)
            RowList += RowIndent + "<tr>" + Environment.NewLine
            RowList += If(WordColCheck.Checked, RowDataIndent + String.Format("<td>{0}</td>", word.Word) + Environment.NewLine, "")
            RowList += If(PronunciationColCheck.Checked, RowDataIndent + String.Format("<td>{0}</td>", word.Pronunciation) + Environment.NewLine, "")
            RowList += If(DefinitionColCheck.Checked, RowDataIndent + String.Format("<td>{0}</td>", word.Definition) + Environment.NewLine, "")
            RowList += If(NotesColCheck.Checked, RowDataIndent + String.Format("<td>{0}</td>", word.Notes) + Environment.NewLine, "")
            RowList += RowIndent + "</tr>" + Environment.NewLine
        Next

        Dim HtmlBody As String = String.Format(My.Resources.TableTemplate, RowList)
        Writer.Write(String.Format(My.Resources.HtmlTemplate, TitleTextBox.Text, Description, My.Resources.HtmlStyle, HtmlBody))
        Writer.Close()

        Process.Start(FilePath)

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub CancelDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancelDialogButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
