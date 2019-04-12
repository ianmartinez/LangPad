Imports System.IO
Imports Tundra
Imports Ionic.Zip

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

        Dim zip As New ZipFile
        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression

        Dim guid As Guid = Guid.NewGuid

        Dim tmp As String = Application.LocalUserAppDataPath & "\zip-" & guid.ToString
        Directory.Delete(tmp, True)
        Directory.CreateDirectory(tmp)

        PagesFolder = tmp & "\pages\"
        Directory.CreateDirectory(PagesFolder)

        'Settings
        Dim SettingsString As New List(Of ZiaLine)
        SettingsString.Add(New ZiaLine(LineType.Comment, "Settings"))

        SettingsString.Add(New ZiaLine(LineType.KeyValue, "Title", Notebook.Title))
        SettingsString.Add(New ZiaLine(LineType.KeyValue, "Language", Notebook.Language))
        SettingsString.Add(New ZiaLine(LineType.KeyValue, "Author", Notebook.Author))
        SettingsString.Add(New ZiaLine(LineType.KeyValue, "Website", Notebook.Website))
        SettingsString.Add(New ZiaLine(LineType.KeyValue, "NTVersion", NTVersion))
        SettingsString.Add(New ZiaLine(LineType.KeyValue, "LangPadVersion", LangPadVersion))

        'Pages
        SettingsString.Add(New ZiaLine(LineType.Comment, "Pages"))

        Dim PageOrder As String = ""
        For i = 0 To Notebook.Pages.Count - 1
            PageOrder = PageOrder & Notebook.Pages.Item(i).Title & "|"
        Next

        SettingsString.Add(New ZiaLine(LineType.KeyValue, "Page Order", PageOrder))
        SettingsString.Add(New ZiaLine(LineType.Blank))

        Dim SettingsFile As String = Write(SettingsString)

        If Notebook.EmbedSymbols = True Then
            Notebook.CustomSymbols = My.Settings.CustomSymbols
        Else
            Notebook.CustomSymbols = ""
        End If

        For Each Page As NotebookPage In Notebook.Pages
            Dim txtWriter As StreamWriter
            txtWriter = New StreamWriter(PagesFolder & Page.Title & ".rtf")
            txtWriter.Write(Page.RTF)
            txtWriter.Close()
            txtWriter = Nothing
        Next


        'Write to disk
        File.WriteAllText(tmp & "\data.txt", SettingsFile)
        File.WriteAllText(tmp & "\info.txt", Notebook.Info)
        File.WriteAllText(tmp & "\custom_symbols.txt", Notebook.CustomSymbols)
        Notebook.WordDictionary.Save(tmp & "\dictionary.txt")

        Notebook.DocumentPath = FilePath
        zip.AddDirectory(tmp)
        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression
        zip.Save(FilePath)
    End Sub

    Public Function Open(ByVal FilePath As String) As NotebookFile
        On Error Resume Next
        Dim NewNotebook As New NotebookFile
        Dim zip As New ZipFile(FilePath)

        Dim guid As Guid = Guid.NewGuid

        Dim tmp As String = Application.LocalUserAppDataPath & "\zip-" & guid.ToString

        Directory.Delete(tmp, True)
        Directory.CreateDirectory(tmp)

        zip.ExtractAll(tmp)
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

        zip.Dispose()
        Return NewNotebook
    End Function

End Module