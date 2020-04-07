Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text
Imports TundraLib
Imports TundraLib.Themes

Public Class frmDictionary
    Dim CurrentTextbox As TextBox
    Public Loaded As Boolean = False
    Public Color1 As Color
    Public Color2 As Color
    Public VerticalMenuGradient As Boolean = False

    Public Sub SetTheme(Theme As Theme)
        Color1 = Theme.PanelBack
        Color2 = Theme.PanelBack
        VerticalMenuGradient = Theme.VerticalMenuGradient
        BackColor = Theme.PanelBack
        dgvDictionary.BackgroundColor = Theme.PanelBack

        MainToolStrip.Renderer = Theme.GetToolStripRenderer()

        ' Center buttons relative to text boxes
        ' Because Windows' scaling throws them off
        btnFind.Top = txtFind.Top - (btnFind.Height / 2 - txtFind.Height / 2)

        Refresh()
    End Sub

    Public Sub SetIcons()
        Dim res As IconResolution = GetIconResolution()

        NewToolStripButton.Image = IconManager.Get("document-new", IconSize.Large, res)
        OpenToolStripButton.Image = IconManager.Get("document-open", IconSize.Large, res)
        SaveToolStripButton.Image = IconManager.Get("document-save", IconSize.Large, res)
        ExportHtmlToolStripButton.Image = IconManager.Get("filetype-html", IconSize.Large, res)
        CharacterEditorToolStripButton.Image = IconManager.Get("language", IconSize.Large, res)
        AddToolStripButton.Image = IconManager.Get("list-add", IconSize.Large, res)
        RemoveToolStripButton.Image = IconManager.Get("list-remove", IconSize.Large, res)
        FontToolStripButton.Image = IconManager.Get("font", IconSize.Large, res)
        FindToolStripButton.Image = IconManager.Get("edit-find", IconSize.Large, res)
    End Sub


    Private Sub ToolStripContainer1_ToolStripPanel_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles ToolStripContainer1.TopToolStripPanel.Paint,
        ToolStripContainer1.BottomToolStripPanel.Paint, ToolStripContainer1.LeftToolStripPanel.Paint, ToolStripContainer1.RightToolStripPanel.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, ToolStripContainer1.Width, Height)
        Dim b As New LinearGradientBrush(rect, Color1, Color2, If(VerticalMenuGradient, LinearGradientMode.Vertical, LinearGradientMode.Horizontal))
        g.FillRectangle(b, rect)
    End Sub

    Private Sub ToolStripContainer1_ToolStripPanel_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ToolStripContainer1.TopToolStripPanel.SizeChanged,
        ToolStripContainer1.BottomToolStripPanel.SizeChanged, ToolStripContainer1.LeftToolStripPanel.SizeChanged, ToolStripContainer1.RightToolStripPanel.SizeChanged
        ToolStripContainer1.Invalidate()
    End Sub

    Public Sub LoadDictionary()
        dgvDictionary.Rows.Clear()
        Dim words = CurrentDocument.WordDictionary.Words
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
            Dim NewWord As New DictionaryWord With {
                .Word = dgvDictionary.Rows.Item(i).Cells.Item(0).Value,
                .Pronunciation = dgvDictionary.Rows.Item(i).Cells.Item(1).Value,
                .Definition = dgvDictionary.Rows.Item(i).Cells.Item(2).Value,
                .Notes = dgvDictionary.Rows.Item(i).Cells.Item(3).Value
            }

            If NewWord.Word = Nothing Then NewWord.Word = ""
            If NewWord.Pronunciation = Nothing Then NewWord.Pronunciation = ""
            If NewWord.Definition = Nothing Then NewWord.Definition = ""
            If NewWord.Notes = Nothing Then NewWord.Notes = ""

            CurrentDocument.WordDictionary.Words.Add(NewWord)
        Next
    End Sub

    Private Sub frmDictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetIcons()
        LoadDictionary()
        Loaded = True
    End Sub

    Private Sub dgvDictionary_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvDictionary.EditingControlShowing
        CurrentTextbox = e.Control
    End Sub

    Private Sub frmDictionary_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        If frmMain IsNot Nothing Then
            CharTool.Owner = frmMain
            frmMain.frmMain_Activated(sender, e)
            CharTool.Show()
        End If
        SaveDictionary()
        Hide()
    End Sub

    Private Sub dgvDictionary_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgvDictionary.RowPostPaint
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As Font = Font

        Dim centerFormat = New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        If MessageBox.Show("This cannot be undone. Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            dgvDictionary.Rows.Clear()
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        If dlgOpen.ShowDialog = DialogResult.OK Then
            If Path.GetExtension(dlgOpen.FileName).ToLower() = ".csv" Then
                CurrentDocument.WordDictionary.OpenCSV(dlgOpen.FileName)
            Else
                CurrentDocument.WordDictionary.Open(dlgOpen.FileName)
            End If

            LoadDictionary()
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveDictionary()
        If dlgSave.ShowDialog = DialogResult.OK Then
            If Path.GetExtension(dlgSave.FileName).ToLower() = ".csv" Then
                Dim cols As Integer
                Dim wr As New StreamWriter(New FileStream(dlgSave.FileName, FileMode.Create, FileAccess.ReadWrite), Encoding.UTF8)
                cols = dgvDictionary.Columns.Count
                For i As Integer = 0 To cols - 1
                    wr.Write(dgvDictionary.Columns(i).Name.ToString().ToUpper() + ",")
                Next
                wr.WriteLine()

                ' Write rows to CSV
                For i As Integer = 0 To dgvDictionary.Rows.Count - 1
                    For j As Integer = 0 To cols - 1
                        If dgvDictionary.Rows(i).Cells(j).Value IsNot Nothing Then
                            wr.Write(dgvDictionary.Rows(i).Cells(j).Value + ",")
                        Else
                            wr.Write(",")
                        End If
                    Next

                    wr.WriteLine()
                Next
                wr.Close()
            Else
                CurrentDocument.WordDictionary.Save(dlgSave.FileName)
            End If
        End If
    End Sub

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        dgvDictionary.Rows.Add(1)
    End Sub

    Private Sub RemoveToolStripButton_Click(sender As Object, e As EventArgs) Handles RemoveToolStripButton.Click
        If dgvDictionary.CurrentCell IsNot Nothing Then
            dgvDictionary.Rows.RemoveAt(dgvDictionary.CurrentCell.RowIndex)
        End If
    End Sub

    Private Sub FontToolStripButton_Click(sender As Object, e As EventArgs) Handles FontToolStripButton.Click
        dlgFont.Color = dgvDictionary.DefaultCellStyle.ForeColor
        dlgFont.Font = dgvDictionary.DefaultCellStyle.Font
        If dlgFont.ShowDialog = DialogResult.OK Then
            dgvDictionary.DefaultCellStyle.Font = dlgFont.Font
            dgvDictionary.DefaultCellStyle.ForeColor = dlgFont.Color
        End If
    End Sub

    Private Sub frmDictionary_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        LoadDictionary()
    End Sub

    Private Sub dgvDictionary_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDictionary.CellEndEdit
        SaveDictionary()
    End Sub

    Private Sub ExportHtmlToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportHtmlToolStripButton.Click
        SaveDictionary()
        If dlgSaveHtml.ShowDialog = DialogResult.OK Then
            dlgHtml.FilePath = dlgSaveHtml.FileName
            dlgHtml.ShowDialog()
        End If
    End Sub

    Private Sub FindToolStripButton_Click(sender As Object, e As EventArgs) Handles FindToolStripButton.Click
        pnlFindReplace.Visible = pnlFindReplace.Visible Xor True
        If pnlFindReplace.Visible = True Then txtFind.Focus()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        SaveDictionary()
        dgvDictionary.ClearSelection()

        Dim matches As Boolean
        Dim selectedPosition As Integer = 0

        If rbWord.Checked Then
            For Each w As DictionaryWord In CurrentDocument.WordDictionary.Words
                matches = If(cbStartsWith.Checked, w.Word.ToLower().StartsWith(txtFind.Text.ToLower()), w.Word.ToLower().Equals(txtFind.Text.ToLower()))
                If matches Then Exit For
                selectedPosition += 1
            Next
        Else
            For Each w As DictionaryWord In CurrentDocument.WordDictionary.Words
                matches = If(cbStartsWith.Checked, w.Definition.ToLower().StartsWith(txtFind.Text.ToLower()), w.Definition.ToLower().Equals(txtFind.Text.ToLower()))
                If matches Then Exit For
                selectedPosition += 1
            Next
        End If
        If matches Then
            dgvDictionary.Rows(selectedPosition).Selected = True
            dgvDictionary.FirstDisplayedScrollingRowIndex = dgvDictionary.SelectedRows(0).Index
        Else
            MessageBox.Show("""" + txtFind.Text + """ was not found " + "")
        End If
    End Sub

    Private Sub CharacterEditorToolStripButton_Click(sender As Object, e As EventArgs) Handles CharacterEditorToolStripButton.Click
        CharTool.Show()
    End Sub

    Private Sub frmDictionary_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        CharTool.Owner = Me
        CharTool.GetCurrentTexbox = Function()
                                        If dgvDictionary.CurrentCell IsNot Nothing Then
                                            dgvDictionary.Focus()
                                            dgvDictionary.BeginEdit(False)
                                        End If

                                        Return CurrentTextbox
                                    End Function
    End Sub
End Class