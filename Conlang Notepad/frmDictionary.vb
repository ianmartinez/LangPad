Imports System.ComponentModel
Imports Tundra

Public Class frmDictionary
    Dim c As TextBox
    Dim SelectedCell As DataGridViewCell
    Public Sub LoadDictionary()
        dgvDictionary.Rows.Clear()

        For Each w As DictionaryWord In CurrentDocument.WordDictionary.Words
            Dim r As New DataGridViewRow
            r.CreateCells(dgvDictionary)
            r.Cells.Item(0).Value = w.Word
            r.Cells.Item(1).Value = w.Pronunciation
            r.Cells.Item(2).Value = w.Definition
            r.Cells.Item(3).Value = w.Notes

            dgvDictionary.Rows.Add(r)
        Next

        dgvDictionary.Refresh()
    End Sub

    Public Sub SaveDictionary()
        CurrentDocument.WordDictionary.Words.Clear()
        For i = 0 To dgvDictionary.RowCount - 1
            Dim NewWord As New DictionaryWord
            NewWord.Word = dgvDictionary.Rows.Item(i).Cells.Item(0).Value
            NewWord.Pronunciation = dgvDictionary.Rows.Item(i).Cells.Item(1).Value
            NewWord.Definition = dgvDictionary.Rows.Item(i).Cells.Item(2).Value
            NewWord.Notes = dgvDictionary.Rows.Item(i).Cells.Item(3).Value

            CurrentDocument.WordDictionary.Words.Add(NewWord)
        Next
    End Sub

    Public Sub InsertText(ByVal Textbox As TextBox, ByVal Text As String)
        On Error Resume Next
        Dim CurrentPos As Integer = Textbox.SelectionStart
        Dim obj As Object = Clipboard.GetDataObject
        Clipboard.SetText(Text)
        Textbox.Paste()
        Clipboard.SetDataObject(obj)

        Textbox.Focus()
        Textbox.SelectionStart = CurrentPos + Text.Length
        Textbox.SelectionLength = 0
    End Sub



    Public Sub InsertIPA(sender As Object, e As EventArgs)
        On Error Resume Next
        Dim Button As Button = CType(sender, Button)
        dgvDictionary.Focus()
        dgvDictionary.BeginEdit(False)

        InsertText(c, Button.Text)
    End Sub

    Private Sub frmDictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.ForceSansSerif = True Then
            Me.Font = New Font("Microsoft Sans Serif", "8.25")
        End If

        pnlTop.Height = pnlHome.Height

        LoadDictionary()

    End Sub

    Private Sub dgvDictionary_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDictionary.CellContentClick

    End Sub

    Private Sub dgvDictionary_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvDictionary.EditingControlShowing
        c = e.Control
    End Sub

    Private Sub dgvDictionary_EditModeChanged(sender As Object, e As EventArgs) Handles dgvDictionary.EditModeChanged

    End Sub

    Private Sub dgvDictionary_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles dgvDictionary.GiveFeedback

    End Sub

    Private Sub dgvDictionary_LostFocus(sender As Object, e As EventArgs) Handles dgvDictionary.LostFocus

    End Sub

    Private Sub dgvDictionary_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDictionary.CellEndEdit

    End Sub

    Private Sub frmDictionary_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub btnSymbols_Click(sender As Object, e As EventArgs) Handles btnSymbols.Click
        SplitContainer1.Panel1Collapsed = SplitContainer1.Panel1Collapsed Xor True
    End Sub

    Private Sub btnCustomSymbols_Click(sender As Object, e As EventArgs) Handles btnCustomSymbols.Click
        dlgCustomSymbols.ShowDialog()
    End Sub

    Private Sub btnAccentMark_Click(sender As Object, e As EventArgs) Handles btnAccentMark.Click
        On Error Resume Next
        dgvDictionary.Focus()
        dgvDictionary.BeginEdit(False)

        If c.SelectionLength > 0 Then
            dlgAccentMark.Character = c.SelectedText
        Else
            dlgAccentMark.Character = ""
        End If

        If dlgAccentMark.ShowDialog = DialogResult.OK Then
            InsertText(c, dlgAccentMark.Character)
            dlgAccentMark.Character = ""
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dgvDictionary.Rows.Add(1)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        dgvDictionary.Rows.RemoveAt(dgvDictionary.CurrentCell.RowIndex)
    End Sub

    Private Sub dgvDictionary_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvDictionary.RowPostPaint
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As System.Drawing.Font = Me.Font

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        centerFormat.LineAlignment = StringAlignment.Center

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If MessageBox.Show("This cannot be undone. Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            dgvDictionary.Rows.Clear()
        End If
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If dlgOpen.ShowDialog = DialogResult.OK Then
            CurrentDocument.WordDictionary.Open(dlgOpen.FileName)
            LoadDictionary()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveDictionary()
        If dlgSave.ShowDialog = DialogResult.OK Then
            CurrentDocument.WordDictionary.Save(dlgSave.FileName)
        End If
    End Sub
End Class