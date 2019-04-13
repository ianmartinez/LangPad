Imports System.IO
Imports TundraLib.ZiaFile
Imports System.IO.Compression

<Serializable()>
Public Class NotebookPage
    Public Title As String
    Public RTF As String
End Class

<Serializable()>
Public Class NotebookFile
    Public Modified As Boolean = False
    Public EmbedSymbols As Boolean = False
    Public DocumentPath As String
    Public LangpadVersion As Decimal = LangpadVersion
    Public NTSpecificationVersion As Decimal = NTVersion

    Public Title As String
    Public Language As String
    Public Author As String
    Public Website As String
    Public CustomSymbols As String
    Public Info As String

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
        LangpadVersion = NewNotebook.LangpadVersion
        NTSpecificationVersion = NewNotebook.NTSpecificationVersion
        Title = NewNotebook.Title
        Language = NewNotebook.Language
        Website = NewNotebook.Website
        Pages = NewNotebook.Pages
        DocumentPath = FilePath
        Info = NewNotebook.Info
        CustomSymbols = NewNotebook.CustomSymbols
        EmbedSymbols = NewNotebook.EmbedSymbols
        WordDictionary = NewNotebook.WordDictionary
    End Sub

    Public Sub New()
    End Sub
End Class

Module NotebookFileAccess
    Dim PagesFolder As String
    Sub Save(ByVal FilePath As String, ByVal Notebook As NotebookFile)
        On Error Resume Next
        frmMain.SaveTabs()

        If frmDictionary.Loaded = False Then
            frmDictionary.LoadDictionary()
        End If

        frmDictionary.SaveDictionary()

        Dim guid As Guid = Guid.NewGuid
        Dim tmp As String = Application.LocalUserAppDataPath & "\zip-" & guid.ToString
        Directory.Delete(tmp, True)
        Directory.CreateDirectory(tmp)

        PagesFolder = tmp & "\pages\"
        Directory.CreateDirectory(PagesFolder)

        'Settings
        Dim DataFile As New List(Of ZiaLine)
        DataFile.Add(New ZiaLine(LineType.Comment, "Settings"))

        DataFile.Add(New ZiaLine(LineType.KeyValue, "Title", Notebook.Title))
        DataFile.Add(New ZiaLine(LineType.KeyValue, "Language", Notebook.Language))
        DataFile.Add(New ZiaLine(LineType.KeyValue, "Author", Notebook.Author))
        DataFile.Add(New ZiaLine(LineType.KeyValue, "Website", Notebook.Website))
        DataFile.Add(New ZiaLine(LineType.KeyValue, "NTVersion", NTVersion))
        DataFile.Add(New ZiaLine(LineType.KeyValue, "LangPadVersion", LangPadVersion))

        'Pages
        DataFile.Add(New ZiaLine(LineType.Comment, "Pages"))

        For i = 0 To Notebook.Pages.Count - 1
            Dim Page = Notebook.Pages.Item(i)
            DataFile.Add(New ZiaLine(LineType.KeyValue, "Page" & i, ToCompatibleString(Page.Title)))

            Dim txtWriter As StreamWriter
            txtWriter = New StreamWriter(PagesFolder & i & ".rtf")
            txtWriter.Write(Page.RTF)
            txtWriter.Close()
        Next

        If Notebook.EmbedSymbols = True Then
            Notebook.CustomSymbols = My.Settings.CustomSymbols
        Else
            Notebook.CustomSymbols = ""
        End If

        'Write to disk
        File.WriteAllText(tmp & "\data.txt", Write(DataFile))
        File.WriteAllText(tmp & "\info.txt", Notebook.Info)
        File.WriteAllText(tmp & "\custom_symbols.txt", Notebook.CustomSymbols)
        Notebook.WordDictionary.Save(tmp & "\dictionary.txt")
        Notebook.DocumentPath = FilePath

        ZipFile.CreateFromDirectory(tmp, FilePath, CompressionLevel.Optimal, False)
    End Sub

    Public Function Open(ByVal FilePath As String) As NotebookFile
        On Error Resume Next
        Dim NewNotebook As New NotebookFile
        Dim guid As Guid = Guid.NewGuid
        Dim tmp As String = Application.LocalUserAppDataPath & "\zip-" & guid.ToString

        Directory.Delete(tmp, True)
        Directory.CreateDirectory(tmp)

        ZipFile.ExtractToDirectory(FilePath, tmp)
        PagesFolder = tmp & "\pages\"

        Dim LineList = Read(File.ReadAllText(tmp & "\data.txt"))
        Dim PageOrder = Search(LineList, "Page Order").Split({"|"}, StringSplitOptions.RemoveEmptyEntries)
        For Each PageTitle As String In PageOrder
            Dim Page As New NotebookPage
            Page.Title = PageTitle
            Page.RTF = File.ReadAllText(PagesFolder & PageTitle & ".rtf")
            NewNotebook.Pages.Add(Page)
        Next

        NewNotebook.Title = Search(LineList, "Title")
        NewNotebook.Language = Search(LineList, "Language")
        NewNotebook.Author = Search(LineList, "Author")
        NewNotebook.Website = Search(LineList, "Website")
        NewNotebook.NTSpecificationVersion = Search(LineList, "NTVersion")
        NewNotebook.LangpadVersion = Search(LineList, "LangPadVersion")
        NewNotebook.CustomSymbols = File.ReadAllText(tmp & "\custom_symbols.txt")
        NewNotebook.Info = File.ReadAllText(tmp & "\info.txt")
        NewNotebook.WordDictionary.Open(tmp & "\dictionary.txt")

        If Not (NewNotebook.CustomSymbols = "") Then NewNotebook.EmbedSymbols = True

        If NewNotebook.CustomSymbols = "" Then
        ElseIf NewNotebook.CustomSymbols = My.Settings.CustomSymbols Then
        ElseIf My.Settings.CustomSymbols.StartsWith(NewNotebook.CustomSymbols) Then
        Else
            dlgAppendReplace.ShowDialog()
            If dlgAppendReplace.Result = dlgAppendReplace.AppendReplaceDialogResult.Append Then
                My.Settings.CustomSymbols = My.Settings.CustomSymbols & NewNotebook.CustomSymbols
            ElseIf dlgAppendReplace.Result = dlgAppendReplace.AppendReplaceDialogResult.Replace Then
                My.Settings.CustomSymbols = NewNotebook.CustomSymbols
            Else
            End If

            frmMain.CustomLayoutPanel.Controls.Clear()
            frmDictionary.CustomLayoutPanel.Controls.Clear()

            Dim LineList2 As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each IPA As String In LineList2
                Dim SymbolButton As New SymbolButton
                SymbolButton.Text = IPA
                AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                frmMain.CustomLayoutPanel.Controls.Add(SymbolButton)

                Dim SymbolButtonDictionary As New SymbolButton
                SymbolButtonDictionary.Text = IPA
                AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                frmDictionary.CustomLayoutPanel.Controls.Add(SymbolButtonDictionary)
            Next
        End If

        Return NewNotebook
    End Function
End Module