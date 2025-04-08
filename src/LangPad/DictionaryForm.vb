Imports System.IO
Imports System.Text
Imports LangPadData
Imports LangPadData.NotebookNT
Imports LangPadUI

Public Class DictionaryForm
    Dim CurrentTextbox As TextBox
    Public Loaded As Boolean = False

    Private Sub DictionaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcons()
        RefreshDictionary()
        UpdateDisplayFont()
        Loaded = True
        KeyPreview = True

        ' Center buttons relative to text boxes
        ' Because Windows' scaling throws them off
        FindButton.Top = FindTextBox.Top - (FindButton.Height / 2 - FindTextBox.Height / 2)

        GridBorder.Padding = New Padding(0)
        ZoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl++"
        ZoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+-"
        ZoomToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+`"
    End Sub

    Public Sub SetIcons()
        Dim Res As IconResolution = GetIconResolution()

        ' Menu
        NewToolStripMenuItem.Image = IconManager.Get("document-new", IconSize.Small, Res)
        ImportToolStripMenuItem.Image = IconManager.Get("document-import", IconSize.Small, Res)
        SaveToolStripMenuItem.Image = IconManager.Get("document-save", IconSize.Small, Res)
        ExportToolStripMenuItem.Image = IconManager.Get("document-export", IconSize.Small, Res)
        ExportToHtmlToolStripMenuItem.Image = IconManager.Get("filetype-html", IconSize.Small, Res)
        CharacterEditorToolStripMenuItem.Image = IconManager.Get("language", IconSize.Small, Res)
        AddWordToolStripMenuItem.Image = IconManager.Get("list-add", IconSize.Small, Res)
        RemoveWordToolStripMenuItem.Image = IconManager.Get("list-remove", IconSize.Small, Res)
        ZoomInToolStripMenuItem.Image = IconManager.Get("zoom-in", IconSize.Small, Res)
        ZoomOutToolStripMenuItem.Image = IconManager.Get("zoom-out", IconSize.Small, Res)
        ZoomToolStripMenuItem.Image = IconManager.Get("zoom-original", IconSize.Small, Res)
        FindToolStripMenuItem.Image = IconManager.Get("edit-find", IconSize.Small, Res)
        SelectAllToolStripMenuItem.Image = IconManager.Get("edit-select-all", IconSize.Small, Res)

        ' Toolbar
        NewToolStripButton.Image = IconManager.Get("document-new", IconSize.Large, Res)
        ImportToolStripButton.Image = IconManager.Get("document-import", IconSize.Large, Res)
        ExportToolStripButton.Image = IconManager.Get("document-export", IconSize.Large, Res)
        ExportHtmlToolStripButton.Image = IconManager.Get("filetype-html", IconSize.Large, Res)
        CharacterEditorToolStripButton.Image = IconManager.Get("language", IconSize.Large, Res)
        AddToolStripButton.Image = IconManager.Get("list-add", IconSize.Large, Res)
        RemoveToolStripButton.Image = IconManager.Get("list-remove", IconSize.Large, Res)
        FindToolStripButton.Image = IconManager.Get("edit-find", IconSize.Large, Res)
    End Sub

    ''' <summary>
    ''' Update the display font (the font the table renders in)
    ''' </summary>
    Public Sub UpdateDisplayFont()
        DictionaryGrid.DefaultCellStyle.Font = New Font("Calibri", Config.DictionaryFontSize)
        Dim HeaderFont = New Font(DictionaryGrid.DefaultCellStyle.Font, FontStyle.Bold)
        DictionaryGrid.ColumnHeadersDefaultCellStyle.Font = HeaderFont
        DictionaryGrid.Refresh()
    End Sub

    ''' <summary>
    ''' Save the table's current state into the current dictionary
    ''' </summary>
    Public Sub SaveDictionary()
        CurrentNotebook.Dictionary.Words.Clear()
        For i = 0 To DictionaryGrid.RowCount - 1
            Dim NewWord As New WordNT With {
                .Word = DictionaryGrid.Rows.Item(i).Cells.Item(0).Value,
                .Pronunciation = DictionaryGrid.Rows.Item(i).Cells.Item(1).Value,
                .Definition = DictionaryGrid.Rows.Item(i).Cells.Item(2).Value,
                .Notes = DictionaryGrid.Rows.Item(i).Cells.Item(3).Value
            }

            If NewWord.Word = Nothing Then NewWord.Word = ""
            If NewWord.Pronunciation = Nothing Then NewWord.Pronunciation = ""
            If NewWord.Definition = Nothing Then NewWord.Definition = ""
            If NewWord.Notes = Nothing Then NewWord.Notes = ""

            CurrentNotebook.Dictionary.Words.Add(NewWord)
        Next
    End Sub

    ''' <summary>
    ''' Change the target textbox of the character editor 
    ''' to be the current cell of the table.
    ''' </summary>
    Private Sub DictionaryGrid_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DictionaryGrid.EditingControlShowing
        CurrentTextbox = e.Control
    End Sub

    ''' <summary>
    ''' Draw row numbers on the table.
    ''' </summary>
    Private Sub DictionaryGrid_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DictionaryGrid.RowPostPaint
        ' Draw row numbers
        Dim Grid As DataGridView = CType(sender, DataGridView)
        Dim RowIndex As String = (e.RowIndex + 1).ToString()
        Dim RowFont As Font = New Font(DictionaryGrid.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold)

        Dim CenterFormat = New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, Grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(RowIndex, RowFont, New SolidBrush(Color.Black), headerBounds, CenterFormat)
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        NewToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub ImportToolStripButton_Click(sender As Object, e As EventArgs) Handles ImportToolStripButton.Click
        ImportToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub ExportToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportToolStripButton.Click
        ExportToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        AddWordToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub RemoveToolStripButton_Click(sender As Object, e As EventArgs) Handles RemoveToolStripButton.Click
        RemoveWordToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub DictionaryForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        RefreshDictionary()
    End Sub

    Private Sub DictionaryGrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DictionaryGrid.CellEndEdit
        SaveDictionary()
        CurrentNotebook.Modified = True
    End Sub

    Private Sub ExportHtmlToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportHtmlToolStripButton.Click
        ExportToHtmlToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub FindToolStripButton_Click(sender As Object, e As EventArgs) Handles FindToolStripButton.Click
        FindToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        SaveDictionary()
        DictionaryGrid.ClearSelection()

        Dim Matches As Boolean
        Dim CurrentPos As Integer = 0
        Dim NormalizedFindText As String = FindTextBox.Text.ToLower()

        If WordRadio.Checked Then
            For Each Word As WordNT In CurrentNotebook.Dictionary.Words
                Matches = If(StartsWithCheck.Checked, Word.Word.ToLower().StartsWith(NormalizedFindText), Word.Word.ToLower().Equals(NormalizedFindText))
                If Matches Then Exit For
                CurrentPos += 1
            Next
        Else
            For Each Word As WordNT In CurrentNotebook.Dictionary.Words
                Matches = If(StartsWithCheck.Checked, Word.Definition.ToLower().StartsWith(NormalizedFindText), Word.Definition.ToLower().Equals(NormalizedFindText))
                If Matches Then Exit For
                CurrentPos += 1
            Next
        End If

        If Matches Then
            DictionaryGrid.Rows(CurrentPos).Selected = True
            DictionaryGrid.FirstDisplayedScrollingRowIndex = DictionaryGrid.SelectedRows(0).Index
        Else
            MessageBox.Show($"""{FindTextBox.Text}"" was not found ")
        End If
    End Sub

    Private Sub CharacterEditorToolStripButton_Click(sender As Object, e As EventArgs) Handles CharacterEditorToolStripButton.Click
        CharacterEditorToolStripMenuItem_Click(Me, e)
    End Sub

    Private Sub DictionaryForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CharEditWindow.TargetForm = Me
        CharEditWindow.GetCurrentTexbox = Function()
                                              If DictionaryGrid.CurrentCell IsNot Nothing Then
                                                  DictionaryGrid.Focus()
                                                  DictionaryGrid.BeginEdit(False)
                                              End If

                                              Return CurrentTextbox
                                          End Function
    End Sub

    Private Sub DictionaryForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        If MainForm IsNot Nothing Then
            CharEditWindow.TargetForm = MainForm
            MainForm.Activate()
            CharEditWindow.Reshow()
        End If
        SaveDictionary()
        Hide()
    End Sub

    Private Sub DictionaryForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown ', DictionaryGrid.KeyDown
        If e.Modifiers = Keys.Control Then
            CharEditWindow.CharEdit.ShortcutKeyInsert(e)
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If MessageBox.Show("This cannot be undone. Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            DictionaryGrid.Rows.Clear()
        End If
    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        If OpenDialog.ShowDialog = DialogResult.OK Then
            If Path.GetExtension(OpenDialog.FileName).ToLower() = ".csv" Then
                CurrentNotebook.Dictionary.OpenCsv(OpenDialog.FileName, False)
            Else
                CurrentNotebook.Dictionary.Open(OpenDialog.FileName, False)
            End If

            RefreshDictionary()
            CurrentNotebook.Modified = True
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        MainForm.FileSave()
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        SaveDictionary()

        If SaveDialog.ShowDialog() = DialogResult.OK Then
            If Path.GetExtension(SaveDialog.FileName).ToLower() = ".csv" Then
                CurrentNotebook.Dictionary.SaveCsv(SaveDialog.FileName)
            Else
                CurrentNotebook.Dictionary.Save(SaveDialog.FileName)
            End If
        End If
    End Sub

    Private Sub ExportToHtmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToHtmlToolStripMenuItem.Click
        SaveDictionary()
        ExportHtmlDialog.ShowDialog()
    End Sub

    Private Sub CharacterEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterEditorToolStripMenuItem.Click
        CharEditWindow.Hide()
        CharEditWindow.Show()
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        If FindReplacePanel.Visible Then ' Hide it
            FindReplacePanel.Visible = False
            GridBorder.Padding = New Padding(0)
            DictionaryGrid.Focus()
        Else ' Show it
            FindReplacePanel.Visible = True
            FindTextBox.Focus()
            GridBorder.Padding = New Padding(0, 1, 0, 0)
        End If
    End Sub

    Private Sub AddWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddWordToolStripMenuItem.Click
        Dim NewRowIndex = DictionaryGrid.Rows.Add(1)
        DictionaryGrid.ClearSelection()
        DictionaryGrid.Rows(NewRowIndex).Selected = True
        EditCellInCurrentRow(0)
        CurrentNotebook.Modified = True
    End Sub

    Private Sub RemoveWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveWordToolStripMenuItem.Click
        If DictionaryGrid.CurrentCell IsNot Nothing Then
            DictionaryGrid.Rows.RemoveAt(DictionaryGrid.CurrentCell.RowIndex)
            CurrentNotebook.Modified = True
        End If
    End Sub

    Private Sub EditCellInCurrentRow(CellCol As Integer)
        If (DictionaryGrid.SelectedRows.Count > 0) Then
            Dim CurrentRow = DictionaryGrid.SelectedRows(0)
            If CurrentRow IsNot Nothing Then
                DictionaryGrid.CurrentCell = CurrentRow.Cells(CellCol)
                DictionaryGrid.BeginEdit(True)
            End If
        End If
    End Sub

    Private Sub EditCell(Cell As DataGridViewCell)
        If Cell IsNot Nothing Then
            DictionaryGrid.CurrentCell = Cell
            DictionaryGrid.BeginEdit(True)
        End If
    End Sub

    Private Sub SelectCells(Cells As DataGridViewSelectedCellCollection)
        For Each Cell As DataGridViewCell In Cells
            If Cell IsNot Nothing Then
                Cell.Selected = True
            End If
        Next
    End Sub

    Private Sub EditWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditWordToolStripMenuItem.Click
        EditCellInCurrentRow(0)
    End Sub

    Private Sub EditPronunciationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPronunciationToolStripMenuItem.Click
        EditCellInCurrentRow(1)
    End Sub

    Private Sub EditDefinitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDefinitionToolStripMenuItem.Click
        EditCellInCurrentRow(2)
    End Sub

    Private Sub EditNotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditNotesToolStripMenuItem.Click
        EditCellInCurrentRow(3)
    End Sub

    Private Sub BroadTranscriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BroadTranscriptionToolStripMenuItem.Click
        Dim OldSelected = DictionaryGrid.SelectedCells

        For Each Cell In DictionaryGrid.SelectedCells
            EditCell(Cell)

            If CurrentTextbox IsNot Nothing Then
                InsertBrackets(CurrentTextbox, "/", "/")
            End If
        Next

        SelectCells(OldSelected)
    End Sub

    Private Sub NarrowTranscriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NarrowTranscriptionToolStripMenuItem.Click
        Dim OldSelected = DictionaryGrid.SelectedCells

        For Each Cell In DictionaryGrid.SelectedCells
            EditCell(Cell)

            If CurrentTextbox IsNot Nothing Then
                InsertBrackets(CurrentTextbox, "[", "]")
            End If
        Next

        SelectCells(OldSelected)
    End Sub

    Private Sub RemoveBracketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveBracketsToolStripMenuItem.Click
        Dim OldSelected = DictionaryGrid.SelectedCells

        For Each Cell In DictionaryGrid.SelectedCells
            EditCell(Cell)

            If CurrentTextbox IsNot Nothing Then
                RemoveAllBrackets(CurrentTextbox)
            End If
        Next

        SelectCells(OldSelected)
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        If DictionaryGrid.IsCurrentCellInEditMode Then
            If CurrentTextbox IsNot Nothing Then
                CurrentTextbox.SelectAll()
            End If
        Else
            DictionaryGrid.SelectAll()
        End If
    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        Config.DictionaryFontSize += 1
        UpdateDisplayFont()
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        Config.DictionaryFontSize -= 1
        UpdateDisplayFont()
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        Config.DictionaryFontSize = Config.DefaultDictionaryFontSize
        UpdateDisplayFont()
    End Sub
End Class