Imports System.IO
Imports System.Text

Public Class dlgHtml
    Public FilePath As String = ""
    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK_Button.Click
        Dim wr As New StreamWriter(New FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite), Encoding.UTF8)
        Dim SortedWordList As List(Of DictionaryWord) = New List(Of DictionaryWord)

        For Each word As DictionaryWord In CurrentDocument.WordDictionary.Words

            SortedWordList.Add(word)
        Next

        SortedWordList.Sort()

        Dim descriptionIndent As String = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab
        Dim description As String = descriptionIndent + txtDescription.Text

        If cbPElement.Checked Then
            description = ""
            Dim Lines As String() = txtDescription.Text.Split(New String() {Environment.NewLine, vbCrLf, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries)

            For Each Line As String In Lines
                description += descriptionIndent + "<p>" + Environment.NewLine
                description += descriptionIndent + ControlChars.Tab + Line + Environment.NewLine
                description += descriptionIndent + "</p>" + Environment.NewLine
            Next
        End If

        Dim rowList As String = ""
        Dim rowIndent As String = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab
        Dim rowDataIndent As String = ControlChars.Tab + ControlChars.Tab + ControlChars.Tab + ControlChars.Tab

        If cbWord.Checked Or cbPronunciation.Checked Or cbDefinition.Checked Or cbNotes.Checked Then
            rowList += rowIndent + "<tr>" + Environment.NewLine
            rowList += If(cbWord.Checked, rowDataIndent + "<th>Word</th>" + Environment.NewLine, "")
            rowList += If(cbPronunciation.Checked, rowDataIndent + "<th>Pronunciation</th>" + Environment.NewLine, "")
            rowList += If(cbDefinition.Checked, rowDataIndent + "<th>Definition</th>" + Environment.NewLine, "")
            rowList += If(cbNotes.Checked, rowDataIndent + "<th>Notes</th>" + Environment.NewLine, "")
            rowList += rowIndent + "</tr>" + Environment.NewLine
        End If

        For i As Integer = 0 To SortedWordList.Count - 1
            Dim word As DictionaryWord = SortedWordList(i)
            rowList += rowIndent + "<tr>" + Environment.NewLine
            rowList += If(cbWord.Checked, rowDataIndent + String.Format("<td>{0}</td>", word.Word) + Environment.NewLine, "")
            rowList += If(cbPronunciation.Checked, rowDataIndent + String.Format("<td>{0}</td>", word.Pronunciation) + Environment.NewLine, "")
            rowList += If(cbDefinition.Checked, rowDataIndent + String.Format("<td>{0}</td>", word.Definition) + Environment.NewLine, "")
            rowList += If(cbNotes.Checked, rowDataIndent + String.Format("<td>{0}</td>", word.Notes) + Environment.NewLine, "")
            rowList += rowIndent + "</tr>" + Environment.NewLine
        Next

        Dim htmlBody As String = String.Format(My.Resources.TableTemplate, rowList)

        wr.Write(String.Format(My.Resources.HtmlTemplate, txtTitle.Text, description, My.Resources.HtmlStyle, htmlBody))
        wr.Close()

        Process.Start(FilePath)

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub dlgHtml_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTitle.Text = CurrentDocument.Language
        txtDescription.Text = CurrentDocument.Info
    End Sub
End Class
