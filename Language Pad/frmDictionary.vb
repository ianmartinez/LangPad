Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text

Public Class frmDictionary
    Dim c As TextBox
    Dim SelectedCell As DataGridViewCell
    Public Loaded As Boolean = False
    Public Color1 As Color
    Public Color2 As Color
    Dim selectedGrid As New DataGridView
    Public VerticalMenuGradient As Boolean = False

    Public Sub SetTheme(Theme As Theme)
        Color1 = Theme.PanelBack
        Color2 = Theme.PanelBack
        VerticalMenuGradient = Theme.VerticalMenuGradient
        BackColor = Theme.PanelBack
        selectedGrid.BackgroundColor = Theme.PanelBack
        MainToolStrip.Renderer = Theme.GetToolStripRenderer()
        PageNameToolStrip.Renderer = Theme.GetToolStripRenderer()

        Refresh()
    End Sub

    Private Sub ToolStripContainer1_ToolStripPanel_Paint(ByVal sender As System.Object, ByVal e As PaintEventArgs) Handles ToolStripContainer1.TopToolStripPanel.Paint,
        ToolStripContainer1.BottomToolStripPanel.Paint, ToolStripContainer1.LeftToolStripPanel.Paint, ToolStripContainer1.RightToolStripPanel.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, ToolStripContainer1.Width, Me.Height)
        Dim b As New LinearGradientBrush(rect, Color1, Color2, If(VerticalMenuGradient, LinearGradientMode.Vertical, LinearGradientMode.Horizontal))
        g.FillRectangle(b, rect)
    End Sub

    Private Sub ToolStripContainer1_ToolStripPanel_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripContainer1.TopToolStripPanel.SizeChanged,
        ToolStripContainer1.BottomToolStripPanel.SizeChanged, ToolStripContainer1.LeftToolStripPanel.SizeChanged, ToolStripContainer1.RightToolStripPanel.SizeChanged
        ToolStripContainer1.Invalidate()
    End Sub

    Public Sub SelectSection(Pos As Integer)
        lbSections.SelectedIndex = Pos
        tcNotebook.SelectedIndex = Pos
        selectedGrid = tcNotebook.SelectedTab.Controls.Item(0)
    End Sub

    Public Sub LoadDictionary()
        ' selectedGrid.Rows.Clear()
        tcNotebook.TabPages.Clear()
        lbSections.Items.Clear()

        If CurrentDocument.WordDictionary.Sections.Count = 0 Then
            CurrentDocument.WordDictionary.Sections.Add(New DictionarySection())
        End If

        For Each Section As DictionarySection In CurrentDocument.WordDictionary.Sections
            Dim Tab As New TabPage
            Tab.Text = Section.Title

            Dim Word = New DataGridViewTextBoxColumn()
            Dim Pronunciation = New DataGridViewTextBoxColumn()
            Dim Definition = New DataGridViewTextBoxColumn()
            Dim Notes = New DataGridViewTextBoxColumn()

            Word.HeaderText = "Word"

            Pronunciation.HeaderText = "Pronunciation"

            Definition.HeaderText = "Definition"
            Definition.Width = 255

            Notes.HeaderText = "Notes"
            Notes.Width = 255

            Dim dgSection As New DataGridView
            dgSection.Dock = DockStyle.Fill
            dgSection.GridColor = Color.Gainsboro
            dgSection.Location = New Point(3, 3)
            dgSection.Margin = New Padding(2)
            dgSection.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.[Single]
            dgSection.RowTemplate.Height = 24
            dgSection.Columns.AddRange(New DataGridViewColumn() {Word, Pronunciation, Definition, Notes})

            Tab.Controls.Add(dgSection)
            tcNotebook.TabPages.Add(Tab)

            For Each w As DictionaryWord In Section.Words
                Dim r As New DataGridViewRow
                r.CreateCells(dgSection)
                r.Cells.Item(0).Value = w.Word
                r.Cells.Item(1).Value = w.Pronunciation
                r.Cells.Item(2).Value = w.Definition
                r.Cells.Item(3).Value = w.Notes

                dgSection.Rows.Add(r)
            Next

            lbSections.Items.Add(Section.Title)

            SelectSection(0)
            dgSection.Refresh()
        Next
    End Sub

    Public Sub SaveDictionary()

        'CurrentDocument.WordDictionary.Words.Clear()
        For i = 0 To selectedGrid.RowCount - 1
            Dim NewWord As New DictionaryWord
            NewWord.Word = selectedGrid.Rows.Item(i).Cells.Item(0).Value
            NewWord.Pronunciation = selectedGrid.Rows.Item(i).Cells.Item(1).Value
            NewWord.Definition = selectedGrid.Rows.Item(i).Cells.Item(2).Value
            NewWord.Notes = selectedGrid.Rows.Item(i).Cells.Item(3).Value

            '  CurrentDocument.WordDictionary.Words.Add(NewWord)
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
        selectedGrid.Focus()
        selectedGrid.BeginEdit(False)

        InsertText(c, Button.Text)
    End Sub

    Private Sub frmDictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDictionary()

        SplitContainer2.SplitterDistance = Width - 300
        Loaded = True
    End Sub

    Private Sub selectedGrid_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        c = e.Control
    End Sub

    Private Sub frmDictionary_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        SaveDictionary()
        Me.Hide()
    End Sub

    Private Sub selectedGrid_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As Font = Font

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        centerFormat.LineAlignment = StringAlignment.Center

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        If MessageBox.Show("This cannot be undone. Are you sure you want to continue? ", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            selectedGrid.Rows.Clear()
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
                wr.Write("Word,Pronunciation,Definition,Notes")

                cols = selectedGrid.Columns.Count
                For i As Integer = 0 To cols - 1
                    wr.Write(selectedGrid.Columns(i).Name.ToString().ToUpper() + ",")
                Next
                wr.WriteLine()

                ' Write rows to CSV
                For i As Integer = 0 To selectedGrid.Rows.Count - 1
                    For j As Integer = 0 To cols - 1
                        If selectedGrid.Rows(i).Cells(j).Value IsNot Nothing Then
                            wr.Write(selectedGrid.Rows(i).Cells(j).Value + ",")
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

    Private Sub SymbolsToolStripButton_Click(sender As Object, e As EventArgs) Handles SymbolsToolStripButton.Click
        SplitContainer1.Panel1Collapsed = SplitContainer1.Panel1Collapsed Xor True
    End Sub

    Private Sub CustomSymbolsToolStripButton_Click(sender As Object, e As EventArgs) Handles CustomSymbolsToolStripButton.Click
        dlgCustomSymbols.ShowDialog()
    End Sub

    Private Sub AccentMarkToolStripButton_Click(sender As Object, e As EventArgs) Handles AccentMarkToolStripButton.Click
        On Error Resume Next
        selectedGrid.Focus()
        selectedGrid.BeginEdit(False)

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

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        selectedGrid.Rows.Add(1)
    End Sub

    Private Sub RemoveToolStripButton_Click(sender As Object, e As EventArgs) Handles RemoveToolStripButton.Click
        selectedGrid.Rows.RemoveAt(selectedGrid.CurrentCell.RowIndex)
    End Sub

    Private Sub FontToolStripButton_Click(sender As Object, e As EventArgs) Handles FontToolStripButton.Click
        dlgFont.Font = selectedGrid.DefaultCellStyle.Font
        If dlgFont.ShowDialog = DialogResult.OK Then
            selectedGrid.DefaultCellStyle.Font = dlgFont.Font
        End If
    End Sub

    Private Sub tcNotebook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcNotebook.SelectedIndexChanged
        SelectSection(tcNotebook.SelectedIndex)
    End Sub
End Class