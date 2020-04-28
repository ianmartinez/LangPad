Imports System.IO
Imports LangPadSupport.ZiaFile
Imports System.IO.Compression

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
    Public NTSpecificationVersion As Decimal = NTVersion

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
        MainForm.SaveTabs()

        If DictionaryForm.Loaded = False Then
            DictionaryForm.LoadDictionary()
        End If

        DictionaryForm.SaveDictionary()

        Dim TempGuid As Guid = Guid.NewGuid
        Dim TempPath As String = Application.LocalUserAppDataPath & "\zip-" & TempGuid.ToString
        If Directory.Exists(TempPath) Then
            Directory.Delete(TempPath, True)
        End If

        Directory.CreateDirectory(TempPath)
        PagesFolder = TempPath & "\pages\"
        Directory.CreateDirectory(PagesFolder)

        Dim DataFile As New List(Of ZiaLine) From {
            New ZiaLine(LineType.Comment, "Settings"),
            New ZiaLine(LineType.KeyValue, "Title", Notebook.Title),
            New ZiaLine(LineType.KeyValue, "Language", Notebook.Language),
            New ZiaLine(LineType.KeyValue, "Author", Notebook.Author),
            New ZiaLine(LineType.KeyValue, "Website", Notebook.Website),
            New ZiaLine(LineType.KeyValue, "NTVersion", NTVersion),
            New ZiaLine(LineType.KeyValue, "LangPadVersion", "LangPad " & GetVersionString()),
            New ZiaLine(LineType.Blank),
            New ZiaLine(LineType.Comment, "Pages")
        }

        For i = 0 To Notebook.Pages.Count - 1
            Dim Page = Notebook.Pages.Item(i)
            DataFile.Add(New ZiaLine(LineType.KeyValue, "Page" & i, ToCompatibleString(Page.Title)))

            Dim Writer As StreamWriter
            Writer = New StreamWriter(PagesFolder & i & ".rtf")
            Writer.Write(Page.RTF)
            Writer.Close()
        Next

        'Write to disk
        File.WriteAllText(TempPath & "\data.txt", Write(DataFile))
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

        Dim LineList = Read(File.ReadAllText(TempPath & "\data.txt"))
        NewNotebook.NTSpecificationVersion = Search(LineList, "NTVersion")
        Dim CompatMode As Boolean = (NewNotebook.NTSpecificationVersion < 2)

        If CompatMode Then ' Use the legacy method of storing pages
            Dim PageOrder = Search(LineList, "Page Order").Split({"|"}, StringSplitOptions.RemoveEmptyEntries)
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
                Dim PageName As String = Search(LineList, "Page" & i)

                If PageName Is Nothing Then
                    PageName = i + 1
                End If

                Page.Title = PageName
                Page.RTF = File.ReadAllText(PagesFolder & i & ".rtf")
                NewNotebook.Pages.Add(Page)
            Next
        End If

        NewNotebook.Title = Search(LineList, "Title")
        NewNotebook.Language = Search(LineList, "Language")
        NewNotebook.Author = Search(LineList, "Author")
        NewNotebook.Website = Search(LineList, "Website")
        NewNotebook.ProgramVersion = Search(LineList, "LangPadVersion")
        NewNotebook.CustomSymbols = File.ReadAllText(TempPath & "\custom_symbols.txt")
        NewNotebook.Info = File.ReadAllText(TempPath & "\info.txt")
        NewNotebook.WordDictionary.Open(TempPath & "\dictionary.txt")

        If NewNotebook.CustomSymbols <> "" Then
            CharEditWindow.CharEdit.FilePanel.Controls.Clear()

            Dim FileChars As String() = NewNotebook.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each FileChar As String In FileChars
                CharEditWindow.CharEdit.InsertCharacterButton(FileChar, CharEditWindow.CharEdit.FilePanel)
            Next
        End If

        Return NewNotebook
    End Function
End Module