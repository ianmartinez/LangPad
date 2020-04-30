Imports System.IO
Imports LangPadSupport

''' <summary>
''' Handles operations on the current notebook used by LangPad.
''' </summary>
Module NotebookController
    ''' <summary>
    ''' The internal file version for notebook (*.nt) files
    ''' created with this version.
    ''' </summary>
    Public Const NTVersion As Decimal = 2.1


    Public RtbList As New List(Of ExtendedRichTextBox)
    ''' <summary>
    ''' If the first tab has been updated on the main form.
    ''' </summary>
    Public FirstTabUpdate As Boolean = False

    Private _Notebook As New NotebookFile
    ''' <summary>
    ''' The document open in this instance of LangPad.
    ''' </summary>
    Public Property CurrentNotebook As NotebookFile
        Get
            Return _Notebook
        End Get

        Set(value As NotebookFile)
            _Notebook = value
            LoadNotebook(_Notebook)
        End Set
    End Property

    ''' <summary>
    ''' The index of the currently open page in the
    ''' notebook.
    ''' </summary>
    Public Property CurrentPageIndex As Integer
        Get
            If _Notebook.Pages.Count = 0 Then
                Return -1
            Else
                Return MainForm.NotebookEditorPanel.PagesListBox.SelectedIndex
            End If
        End Get

        Set(value As Integer)
            GoToPage(value)
        End Set
    End Property

    ''' <summary>
    ''' The file characters as a string array.
    ''' </summary>
    Public ReadOnly Property CurrentNotebookCharacters As String()
        Get
            Return CurrentNotebook.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        End Get
    End Property


    Private Sub LoadNotebook(Notebook As NotebookFile)
        BeginOperation(MainForm)

        ' Clear controls
        MainForm.NotebookTabs.TabPages.Clear()
        RtbList.Clear()
        MainForm.NotebookEditorPanel.PagesListBox.Items.Clear()

        ' Process each page into the UI
        For Each Page As NotebookPage In Notebook.Pages
            Dim PageTab As New TabPage With {
                .Text = Page.Title
            }

            Dim PageRtb = CreateNotebookRtb(Page.RTF)
            PageTab.Controls.Add(PageRtb)
            RtbList.Add(PageRtb)
            MainForm.NotebookTabs.TabPages.Add(PageTab)
            MainForm.NotebookEditorPanel.PagesListBox.Items.Add(Page.Title)
        Next

        ' Go to the first page, if it exists
        If Notebook.Pages.Count > 0 Then
            GoToPage(0)
        End If

        ' Update notebook properties forms
        MainForm.NotebookEditorPanel.TitleTextBox.Text = CurrentNotebook.Title
        MainForm.NotebookEditorPanel.LanguageTextBox.Text = CurrentNotebook.Language
        MainForm.NotebookEditorPanel.AuthorTextBox.Text = CurrentNotebook.Author
        MainForm.NotebookEditorPanel.WebsiteTextBox.Text = CurrentNotebook.Website
        MainForm.NotebookEditorPanel.InfoTextBox.Text = CurrentNotebook.Info

        ' Load dictionary
        RefreshDictionary()

        ' Load file characters
        RefreshFileCharacters()

        ' A newly loaded document isn't modfied
        CurrentNotebook.Modified = False
        FirstTabUpdate = True
        UpdatePageStats()

        EndOperation(MainForm)
    End Sub

    Public Sub RefreshDictionary()
        BeginOperation(DictionaryForm)

        DictionaryForm.DictionaryGrid.Rows.Clear()
        For Each Word As DictionaryWord In CurrentNotebook.WordDictionary.Words
            Dim Row As New DataGridViewRow
            Row.CreateCells(DictionaryForm.DictionaryGrid)
            Row.Cells.Item(0).Value = Word.Word
            Row.Cells.Item(1).Value = Word.Pronunciation
            Row.Cells.Item(2).Value = Word.Definition
            Row.Cells.Item(3).Value = Word.Notes

            DictionaryForm.DictionaryGrid.Rows.Add(Row)
        Next
        DictionaryForm.DictionaryGrid.Refresh()

        EndOperation(DictionaryForm)
    End Sub

    Public Sub RefreshFileCharacters()
        BeginOperation(CharEditWindow)

        ' Clear controls
        CharEditWindow.CharEdit.FilePanel.Controls.Clear()

        ' Add each character
        For Each FileCharacter In CurrentNotebookCharacters
            CharEditWindow.CharEdit.InsertCharacterButton(FileCharacter, CharEditWindow.CharEdit.FilePanel)
        Next

        EndOperation(CharEditWindow)
    End Sub

    Private Sub GoToPage(Index As Integer)
        Index = If(PageInRange(Index), Index, 0)

        If CurrentNotebook.Pages.Count = 0 Then ' If no pages
            MainForm.NotebookTabs.SelectedIndex = -1
            MainForm.NotebookEditorPanel.PagesListBox.SelectedIndex = -1
        ElseIf PageInRange(Index) Then ' If there are pages
            MainForm.NotebookTabs.SelectedIndex = Index
            MainForm.NotebookEditorPanel.PagesListBox.SelectedIndex = Index
            MainForm.CurrentRtb = RtbList(Index)
        End If

        UpdatePageStats()
    End Sub

    Private Sub GoToCurrent()
        GoToPage(CurrentPageIndex)
    End Sub

    ''' <summary>
    ''' Signal to the user that an operation is being processed.
    ''' 
    ''' <param name="TargetForm">The form that is the target of the operation.</param>
    ''' </summary>
    Private Sub BeginOperation(TargetForm As Form)
        TargetForm.Cursor = Cursors.WaitCursor
        TargetForm.Enabled = False
        TargetForm.SuspendLayout()
    End Sub

    ''' <summary>
    ''' Signal to the user that an operation has completed.
    ''' 
    ''' <param name="TargetForm">The form that is the target of the operation.</param>
    ''' </summary>
    Private Sub EndOperation(TargetForm As Form)
        TargetForm.Cursor = Cursors.Default
        TargetForm.Enabled = True
        TargetForm.ResumeLayout()
    End Sub

    Public Sub UpdatePageStats()
        MainForm.PageCountLabel.Text = "Page Count: " & CurrentNotebook.Pages.Count
        MainForm.WordWrapToolStripMenuItem.Checked = MainForm.CurrentRtb.WordWrap
        UpdateLineNumber()
        UpdateWordCount()
    End Sub

    Public Sub UpdateWordCount()
        MainForm.CharCountToolStripLabel.Text = "Character Count: " & MainForm.CurrentRtb.TextLength
        MainForm.WordCountToolStripLabel.Text = "Word Count: " & WordCount(MainForm.CurrentRtb.Text)
    End Sub

    Public Sub UpdateLineNumber()
        MainForm.CurrentLineToolStripLabel.Text = "Line: " & (MainForm.CurrentRtb.GetLineFromCharIndex(MainForm.CurrentRtb.SelectionStart) + 1)
    End Sub

    ''' <summary>
    ''' Check if a page is within range of the current notebook's pages.
    ''' </summary>
    ''' 
    ''' <param name="Index">The index of the page.</param>
    ''' 
    ''' <returns>If a page exists at that index.</returns>
    Public Function PageInRange(Index As Integer) As Boolean
        Return Index >= 0 And Index < CurrentNotebook.Pages.Count
    End Function

    ''' <summary>
    ''' Insert a page to the current notebook.
    ''' </summary>
    ''' 
    ''' <param name="Index">The index to place it at.</param>
    ''' <param name="Title">The page's title.</param>
    ''' <param name="Rtf">The page's RTF data.</param>
    Public Sub InsertPage(Index As Integer, Title As String, Optional Rtf As String = "")
        BeginOperation(MainForm)

        ' Insert after the current index, and if not at 
        ' a valid index, then insert at the end
        If Not PageInRange(CurrentPageIndex) Then Index = _Notebook.Pages.Count

        ' Create a new page
        Dim NewPage As New NotebookPage With {
            .Title = Title,
            .RTF = Rtf
        }
        _Notebook.Pages.Insert(Index, NewPage)

        ' Create an RTB with the page's RTF
        Dim NewRtb = CreateNotebookRtb(NewPage.RTF)
        RtbList.Insert(Index, NewRtb)

        ' Create a new tab with the RTB inside
        Dim NewTab As New TabPage With {
            .Text = Title
        }
        NewTab.Controls.Add(NewRtb)
        MainForm.NotebookTabs.TabPages.Insert(Index, NewTab)

        ' Add new list item in properties panel
        MainForm.NotebookEditorPanel.PagesListBox.Items.Insert(Index, NewPage.Title)
        CurrentNotebook.Modified = True

        ' Go to the newly created page
        GoToPage(Index)

        EndOperation(MainForm)
    End Sub

    ''' <summary>
    ''' Import a file into the notebook at a specific index.
    ''' </summary>
    ''' 
    ''' <param name="Index">The index to import the file to.</param>
    ''' <param name="FileName">The file's path.</param>
    Public Sub ImportPage(Index As Integer, FileName As String)
        If File.Exists(FileName) Then
            Dim PageTitle = Path.GetFileNameWithoutExtension(FileName)
            Dim ImportedExt = Path.GetExtension(FileName).ToUpper()

            ' Read the text file
            Dim Reader = New StreamReader(FileName)
            Dim FileContent = Reader.ReadToEnd()
            Reader.Close()

            ' Import the text file's data
            Select Case ImportedExt
                Case ".RTF" ' If RTF, import directly
                    InsertPage(Index, PageTitle, FileContent)
                Case Else ' If not, create a temp RTB to get it in the proper RTF format
                    Dim TempRichTextBox As New ExtendedRichTextBox With {
                        .Text = FileContent
                    }
                    InsertPage(Index, PageTitle, TempRichTextBox.Rtf)
            End Select
        End If
    End Sub

    ''' <summary>
    ''' Remove a page at an index. If it's the current page, navigate back 
    ''' one page.
    ''' </summary>
    ''' 
    ''' <param name="Index">The index of the page to remove.</param>
    ''' <param name="NavigateBack">If the UI should navigate to the previous page after 
    ''' deletion, if the page deleted was the current page.</param>
    Public Sub RemovePage(Index As Integer, Optional NavigateBack As Boolean = True)
        BeginOperation(MainForm)

        If PageInRange(Index) Then
            Dim WasCurrent = CurrentPageIndex = Index

            CurrentNotebook.Pages.RemoveAt(Index)
            RtbList.RemoveAt(Index)
            MainForm.NotebookTabs.TabPages.RemoveAt(Index)
            MainForm.NotebookEditorPanel.PagesListBox.Items.RemoveAt(Index)

            ' If the page deleted was the current page, go back one page
            If WasCurrent AndAlso NavigateBack Then
                GoToPage(Math.Max(0, Index - 1))
            End If

            CurrentNotebook.Modified = True
        End If

        EndOperation(MainForm)
    End Sub

    ''' <summary>
    ''' Duplicate a page at an index, and optionally change its 
    ''' title. Navigates to new page after duplicating.
    ''' </summary>
    ''' 
    ''' <param name="SourceIndex">The page index to duplicate.</param>
    ''' <param name="NewTitle">The duplicated page's title, by default the same as the old page</param>
    Public Sub DuplicatePage(SourceIndex As Integer, Optional NewTitle As String = Nothing)
        If PageInRange(SourceIndex) Then
            Dim SourcePage = CurrentNotebook.Pages(SourceIndex)
            Dim NewPageIndex = SourceIndex + 1
            If NewTitle Is Nothing Then NewTitle = SourcePage.Title
            InsertPage(NewPageIndex, NewTitle, SourcePage.RTF)
            CurrentNotebook.Modified = True
        End If
    End Sub

    ''' <summary>
    ''' Give a page a new title.
    ''' </summary>
    ''' 
    ''' <param name="Index">The index of the page to rename.</param>
    ''' <param name="NewTitle">The page's new title.</param>
    Public Sub RenamePage(Index As Integer, NewTitle As String)
        If PageInRange(Index) Then
            CurrentNotebook.Pages(Index).Title = NewTitle
            MainForm.NotebookTabs.TabPages(Index).Text = NewTitle
            MainForm.NotebookEditorPanel.PagesListBox.Items(Index) = NewTitle
            CurrentNotebook.Modified = True
        End If
    End Sub

    ''' <summary>
    ''' Move a page from an old index to a new index.
    ''' </summary>
    ''' 
    ''' <param name="OldIndex">The index of the page to move.</param>
    ''' <param name="NewIndex">The index to move the page to.</param>
    Public Sub MovePage(OldIndex As Integer, NewIndex As Integer)
        If OldIndex = NewIndex Then Exit Sub ' Nothing to do

        If PageInRange(OldIndex) AndAlso PageInRange(NewIndex) Then
            BeginOperation(MainForm)
            MainForm.Moving = True

            MoveItem(Of ExtendedRichTextBox)(RtbList, OldIndex, NewIndex)
            MoveItem(Of NotebookPage)(CurrentNotebook.Pages, OldIndex, NewIndex)
            MoveItem(Of TabPage)(MainForm.NotebookTabs.TabPages, OldIndex, NewIndex)
            MoveItem(Of String)(MainForm.NotebookEditorPanel.PagesListBox.Items, OldIndex, NewIndex)

            CurrentNotebook.Modified = True
            GoToPage(NewIndex)
            MainForm.Moving = False
            EndOperation(MainForm)
        End If
    End Sub

    Private Sub ModifiedHandler()
        CurrentNotebook.Modified = True
    End Sub

    Public Function CreateNotebookRtb(Rtf As String) As ExtendedRichTextBox
        Dim NewRichTextBox As New ExtendedRichTextBox With {
            .Font = New Font("Calibri", 11, FontStyle.Regular),
            .Rtf = Rtf,
            .Dock = DockStyle.Fill,
            .ScrollBars = RichTextBoxScrollBars.Both,
            .BorderStyle = BorderStyle.None,
            .ContextMenuStrip = MainForm.MainContextMenu,
            .HideSelection = False
        }

        AddHandler NewRichTextBox.TextChanged, AddressOf ModifiedHandler

        Return NewRichTextBox
    End Function
End Module
