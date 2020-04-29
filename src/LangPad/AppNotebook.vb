''' <summary>
''' Handles operations on the current notebook used by LangPad.
''' </summary>
Module AppNotebook

    ''' <summary>
    ''' The document open in this instance of LangPad.
    ''' </summary>
    Private _Notebook As New NotebookFile

    Public Property CurrentNotebook As NotebookFile
        Get
            Return _Notebook
        End Get
        Set(value As NotebookFile)
            _Notebook = value
            LoadNotebookFile(_Notebook)
        End Set
    End Property

    Private Sub LoadNotebookFile(Notebook As NotebookFile)

    End Sub

    ''' <summary>
    ''' The internal file version for notebook (*.nt) files
    ''' created with this version.
    ''' </summary>
    Public Const NTVersion As Decimal = 2.1

    ''' <summary>
    ''' Add a page to the current notebook.
    ''' </summary>
    ''' 
    ''' <param name="Index">The index to place it at.</param>
    ''' <param name="Title">The page's title</param>
    Public Sub AddPage(Index As Integer, Title As String)

    End Sub

    Public Sub RemovePage(Index As Integer)

    End Sub

    Public Sub RenamePage(Index As Integer, NewTitle As String)

    End Sub

    Public Sub DuplicatePage(Index As Integer)

    End Sub
End Module
