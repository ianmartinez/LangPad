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
        If Index = -1 Then
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
    ''' Insert a page to the current notebook.
    ''' </summary>
    ''' 
    ''' <param name="Index">The index to place it at.</param>
    ''' <param name="Title">The page's title.</param>
    Public Sub InsertPage(Index As Integer, Title As String)
        ' Insert after the current index
        If Index = -1 Then Index = _Notebook.Pages.Count

        ' Create a new page
        Dim NewPage As New NotebookPage With {
            .Title = Title
        }
        _Notebook.Pages.Insert(Index, NewPage)

        ' Create an RTB with the page's RTF
        Dim NewRtb = CreateRichTextBox(NewPage.RTF)
        RtbList.Insert(Index, NewRtb)

        ' Create a new tab with the RTB inside
        Dim NewTab As New TabPage With {
            .Text = Title
        }
        NewTab.Controls.Add(NewRtb)
        MainForm.NotebookTabs.TabPages.Insert(Index, NewTab)

        ' Add new list item in properties panel
        MainForm.NotebookEditorPanel.PagesListBox.Items.Insert(Index, NewPage.Title)
    End Sub

    Public Sub RemovePage(Index As Integer)

    End Sub

    Public Sub RenamePage(Index As Integer, NewTitle As String)

    End Sub

    Public Sub DuplicatePage(Index As Integer)

    End Sub

    Private Sub ModifiedHandler()
        CurrentNotebook.Modified = True
    End Sub

    Public Function CreateRichTextBox(Rtf As String) As ExtendedRichTextBox
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
