Imports LangPadSupport
''' <summary>
''' Handles operations on the current notebook used by LangPad.
''' </summary>
Module AppNoteboo
    ''' <summary>
    ''' The internal file version for notebook (*.nt) files
    ''' created with this version.
    ''' </summary>
    Public Const NTVersion As Decimal = 2.1

    Private _Notebook As New NotebookFile
    Public RtbList As New List(Of ExtendedRichTextBox)

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
    Public Property PageIndex As Integer
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

    Private Sub LoadNotebook(Notebook As NotebookFile)

    End Sub

    Private Sub GoToPage(Index As Integer)
        If Not PageInRange(Index) Then
            MainForm.NotebookTabs.SelectedIndex = -1
            MainForm.NotebookEditorPanel.PagesListBox.SelectedIndex = -1
        ElseIf Index = -1 Then
            MainForm.NotebookTabs.SelectedIndex = 0
            MainForm.NotebookEditorPanel.PagesListBox.SelectedIndex = 0
        Else
            MainForm.NotebookTabs.SelectedIndex = Index
            MainForm.NotebookEditorPanel.PagesListBox.SelectedIndex = Index
        End If
    End Sub

    Private Sub GoToCurrent()
        GoToPage(PageIndex)
    End Sub

    ''' <summary>
    ''' Signal to the user that an operation is being processed.
    ''' </summary>
    Private Sub BeginOperation()
        MainForm.Cursor = Cursors.WaitCursor
        MainForm.Enabled = False
        MainForm.SuspendLayout()
    End Sub

    ''' <summary>
    ''' Signal to the user that an operation has completed.
    ''' </summary>
    Private Sub EndOperation()
        MainForm.Cursor = Cursors.Default
        MainForm.Enabled = True
        MainForm.ResumeLayout()
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
        ' Insert after the current index, and if not at 
        ' a valid index, then insert at the end
        If Not PageInRange(PageIndex) Then Index = _Notebook.Pages.Count

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

        ' If there isn't a valid page selected (i.e. the notebook had no pages 
        ' before this one), select the new page
        If Not PageInRange(PageIndex) Then
            GoToPage(Index)
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
        If PageInRange(Index) Then
            Dim WasCurrent = PageIndex = Index

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
            GoToPage(NewPageIndex)
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
            BeginOperation()
            MainForm.Moving = True

            MoveItem(Of ExtendedRichTextBox)(RtbList, OldIndex, NewIndex)
            MoveItem(Of NotebookPage)(CurrentNotebook.Pages, OldIndex, NewIndex)
            MoveItem(Of TabPage)(MainForm.NotebookTabs.TabPages, OldIndex, NewIndex)
            MoveItem(Of String)(MainForm.NotebookEditorPanel.PagesListBox.Items, OldIndex, NewIndex)

            CurrentNotebook.Modified = True
            GoToPage(NewIndex)
            MainForm.Moving = False
            EndOperation()
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
