Imports System.IO
Imports LangPadData.NotebookNT
Imports System.IO.Compression
Imports LangPadData

<Serializable()>
Public Class NotebookPage
    Public Title As String
    Public RTF As String
End Class

<Serializable()>
Public Class NotebookFile
    Public Property Modified As Boolean = False

    Public DocumentPath As String = ""
    Public ProgramVersion As String = ProgramVersion
    Public NTSpecificationVersion As Decimal = NotebookNT.NT_VERSION

    Public Title As String = ""
    Public Language As String = ""
    Public Author As String = ""
    Public Website As String = ""
    Public CustomSymbols As String = ""
    Public Info As String = ""

    Public Pages As New List(Of NotebookPage)
    Public WordDictionary As New DictionaryFile

    Public Sub Save(ByVal FilePath As String)
        If File.Exists(FilePath) Then File.Delete(FilePath)
        NotebookFileAccess.Save(FilePath, Me)
        Modified = False
    End Sub

    Public Sub Open(ByVal FilePath As String, Optional ByVal Opening As Boolean = False)
        Dim NewNotebook As NotebookFile = NotebookFileAccess.Open(FilePath)
        Author = NewNotebook.Author
        ProgramVersion = NewNotebook.ProgramVersion
        NTSpecificationVersion = NewNotebook.NTSpecificationVersion
        Title = NewNotebook.Title
        Language = NewNotebook.Language
        Website = NewNotebook.Website
        Pages = NewNotebook.Pages
        DocumentPath = FilePath
        Info = NewNotebook.Info
        CustomSymbols = NewNotebook.CustomSymbols
        WordDictionary = NewNotebook.WordDictionary
    End Sub

    Public Sub New()
    End Sub
End Class

Module NotebookFileAccess
    Dim PagesFolder As String
    Sub Save(ByVal FilePath As String, ByVal Notebook As NotebookFile)
        Dim TempGuid As Guid = Guid.NewGuid
        Dim TempPath As String = Application.LocalUserAppDataPath & "\zip-" & TempGuid.ToString
        If Directory.Exists(TempPath) Then
            Directory.Delete(TempPath, True)
        End If

        Directory.CreateDirectory(TempPath)
        PagesFolder = TempPath & "\pages\"
        Directory.CreateDirectory(PagesFolder)

        Dim DataFile As New List(Of KvLine) From {
            New KvLine(KvLineType.Comment, "Settings"),
            New KvLine(KvLineType.KeyValue, "Title", Notebook.Title),
            New KvLine(KvLineType.KeyValue, "Language", Notebook.Language),
            New KvLine(KvLineType.KeyValue, "Author", Notebook.Author),
            New KvLine(KvLineType.KeyValue, "Website", Notebook.Website),
            New KvLine(KvLineType.KeyValue, "NTVersion", NotebookNT.NT_VERSION),
            New KvLine(KvLineType.KeyValue, "LangPadVersion", GetAppDisplayName()),
            New KvLine(KvLineType.Blank),
            New KvLine(KvLineType.Comment, "Pages")
        }

        For i = 0 To Notebook.Pages.Count - 1
            Dim Page = Notebook.Pages.Item(i)
            DataFile.Add(New KvLine(KvLineType.KeyValue, "Page" & i, KeyValue.FormatString(Page.Title)))

            Dim Writer As StreamWriter
            Writer = New StreamWriter(PagesFolder & i & ".rtf")
            Writer.Write(Page.RTF)
            Writer.Close()
        Next

        'Write to disk
        File.WriteAllText(TempPath & "\data.txt", KeyValue.Write(DataFile))
        File.WriteAllText(TempPath & "\info.txt", Notebook.Info)
        File.WriteAllText(TempPath & "\custom_symbols.txt", Notebook.CustomSymbols)
        Notebook.WordDictionary.Save(TempPath & "\dictionary.txt")
        Notebook.DocumentPath = FilePath

        ZipFile.CreateFromDirectory(TempPath, FilePath, CompressionLevel.Optimal, False)
    End Sub

    Public Function Open(ByVal FilePath As String) As NotebookFile
        Dim NewNotebook As New NotebookFile
        Dim TempGuid As Guid = Guid.NewGuid
        Dim TempPath As String = Application.LocalUserAppDataPath & "\zip-" & TempGuid.ToString

        If (Directory.Exists(TempPath)) Then
            Directory.Delete(TempPath, True)
        End If

        Directory.CreateDirectory(TempPath)
        ZipFile.ExtractToDirectory(FilePath, TempPath)
        PagesFolder = TempPath & "\pages\"

        Dim LineList = KeyValue.Read(File.ReadAllText(TempPath & "\data.txt"))

        ' Check the version of the notebook format so that we can adjust 
        ' the loading to support older formats
        Dim NTVersionString = KeyValue.Search(LineList, "NTVersion")

        ' Versions prior to NT 1.2 didn't actually declare their spec version,
        ' so a lookup will fail
        If String.IsNullOrEmpty(NTVersionString) Then
            NewNotebook.NTSpecificationVersion = 1
        Else
            NewNotebook.NTSpecificationVersion = NTVersionString
        End If

        If NewNotebook.NTSpecificationVersion < 2 Then ' Use the legacy method of storing pages
            Dim PageOrder = KeyValue.Search(LineList, "Page Order").Split({"|"}, StringSplitOptions.RemoveEmptyEntries)
            For Each PageTitle As String In PageOrder
                Dim Page As New NotebookPage With {
                    .Title = PageTitle,
                    .RTF = File.ReadAllText(PagesFolder & PageTitle & ".rtf")
                }
                NewNotebook.Pages.Add(Page)
            Next
        Else ' Use the new method of storing pages that allows for arbitrary names
            Dim PageCount As Integer = Directory.EnumerateFiles(PagesFolder).Count
            For i = 0 To PageCount - 1
                Dim Page As New NotebookPage
                Dim PageName As String = KeyValue.Search(LineList, "Page" & i)

                If PageName Is Nothing Then
                    PageName = i + 1
                End If

                Page.Title = PageName
                Page.RTF = File.ReadAllText(PagesFolder & i & ".rtf")
                NewNotebook.Pages.Add(Page)
            Next
        End If

        NewNotebook.Title = KeyValue.Search(LineList, "Title")
        NewNotebook.Language = KeyValue.Search(LineList, "Language")
        NewNotebook.Author = KeyValue.Search(LineList, "Author")
        NewNotebook.Website = KeyValue.Search(LineList, "Website")
        NewNotebook.ProgramVersion = KeyValue.Search(LineList, "LangPadVersion")

        ' The first release of the notebook format lacked embedded
        ' custom symbols, so check if they exist before trying to
        ' load them
        Dim CustomSymbolsFile = TempPath & "\custom_symbols.txt"
        If File.Exists(CustomSymbolsFile) Then
            NewNotebook.CustomSymbols = File.ReadAllText(CustomSymbolsFile)
        End If

        ' The first release also lacked an info file, so check if it exists
        Dim InfoFile = TempPath & "\info.txt"
        If File.Exists(InfoFile) Then
            NewNotebook.Info = File.ReadAllText(TempPath & "\info.txt")
        Else
            NewNotebook.Info = String.Empty
        End If

        ' Some older versions (4.0-5.3) lacked a dictionary, so check 
        ' if it exists before trying to load it
        Dim DictionaryFile = TempPath & "\dictionary.txt"
        If File.Exists(DictionaryFile) Then
            NewNotebook.WordDictionary.Open(DictionaryFile)
        End If

        Return NewNotebook
    End Function
End Module