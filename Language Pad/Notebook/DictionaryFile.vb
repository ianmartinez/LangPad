Imports System.IO
Imports Tundra

<Serializable()>
Public Class DictionaryWord
    Public Word As String
    Public Pronunciation As String
    Public Definition As String
    Public Notes As String

    Public Sub New()
        Word = ""
        Pronunciation = ""
        Definition = ""
        Notes = ""
    End Sub
End Class

<Serializable()>
Public Class DictionarySection
    Public Title As String
    Public Words As List(Of DictionaryWord)

    Public Sub New()
        Words = New List(Of DictionaryWord)
        Title = ""
    End Sub
End Class

<Serializable()>
Public Class DictionaryFile
    Public Sections As List(Of DictionarySection)

    Public Sub Save(ByVal FilePath As String)
        If File.Exists(FilePath) Then File.Delete(FilePath)
        DictionaryFileAccess.Save(FilePath, Me)
    End Sub

    Public Sub Open(ByVal FilePath As String)
        Dim NewDictionary As DictionaryFile = DictionaryFileAccess.Open(FilePath)
        Me.Sections = NewDictionary.Sections
    End Sub

    Public Sub OpenCSV(ByVal FilePath As String)
        Dim NewDictionary As DictionaryFile = DictionaryFileAccess.OpenCSV(FilePath)
        Me.Sections = NewDictionary.Sections
    End Sub

    Public Sub New()
        Sections = New List(Of DictionarySection)
    End Sub
End Class

Module DictionaryFileAccess
    Sub Save(ByVal FilePath As String, ByVal Dictionary As DictionaryFile)
        On Error Resume Next
        Dim DictionaryString As New List(Of ZiaLine)
        DictionaryString.Add(New ZiaLine(LineType.Comment, "Dictionary"))
        DictionaryString.Add(New ZiaLine(LineType.Comment, "Language Pad Version:" & LangPadVersion))

        For i = 0 To Dictionary.Sections.Count - 1
            Dim CurrentSection As DictionarySection = Dictionary.Sections.Item(i)
            DictionaryString.Add(New ZiaLine(LineType.KeyValue, "Section" + i + "Title", ToCompatibleString(CurrentSection.Title)))
            Dim WordList As String = ""

            For j = 0 To Dictionary.Sections(i).Words.Count - 1
                Dim CurrentWord As DictionaryWord = CurrentSection.Words.Item(j)
                WordList += String.Format("{0}|{1}|{2}|{3};", ToCompatibleString(CurrentWord.Word), ToCompatibleString(CurrentWord.Pronunciation),
                                                ToCompatibleString(CurrentWord.Definition), ToCompatibleString(CurrentWord.Notes))
            Next
            DictionaryString.Add(New ZiaLine(LineType.KeyValue, "Section" + i + "Words", WordList))
        Next

        File.WriteAllText(FilePath, ZiaFile.Write(DictionaryString))
    End Sub

    Public Function Open(ByVal FilePath As String) As DictionaryFile
        ' On Error Resume Next
        Dim NewDictionary As New DictionaryFile
        NewDictionary.Sections = New List(Of DictionarySection)
        Dim LineList As Dictionary(Of String, String) = ZiaFile.Read(File.ReadAllText(FilePath))

        For Each CurrentLine As KeyValuePair(Of String, String) In LineList
            If CurrentLine.Key.StartsWith("Section") And CurrentLine.Key.EndsWith("Title") Then
                Dim CurrentSection As New DictionarySection
                Dim SectionNumber As String = CurrentLine.Key.Replace("Section", "").Replace("Title", "")
                CurrentSection.Title = FromCompatibleString(CurrentLine.Value)
                CurrentSection.Words = New List(Of DictionaryWord)

                Dim Words As String = ZiaFile.Search(LineList, "Section" + SectionNumber + "Words")
                For Each Word As String In Words.Split({";"}, StringSplitOptions.RemoveEmptyEntries)
                    Dim values As String() = Word.Split("|")

                    Dim w As New DictionaryWord
                    w.Word = FromCompatibleString(values(0))
                    w.Pronunciation = FromCompatibleString(values(1))
                    w.Definition = FromCompatibleString(values(2))
                    w.Notes = FromCompatibleString(values(3))

                    CurrentSection.Words.Add(w)
                Next

                NewDictionary.Sections.Add(CurrentSection)
            End If
        Next

        Return NewDictionary
    End Function

    Public Function OpenCSV(ByVal FilePath As String) As DictionaryFile
        '  On Error Resume Next
        Dim NewDictionary As New DictionaryFile
        Dim Lines As String() = File.ReadAllText(FilePath).Split(New String() {Environment.NewLine, vbCrLf, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries)

        For Each CurrentLine As String In Lines
            If CurrentLine.Trim().Equals("Word,Pronunciation,Definition,Notes") Then Continue For

            Dim NewWord As New DictionaryWord
            NewWord.Word = CurrentLine.Split(",").GetValue(0)
            NewWord.Pronunciation = CurrentLine.Split(",").GetValue(1)
            NewWord.Definition = CurrentLine.Split(",").GetValue(2)
            NewWord.Notes = CurrentLine.Split(",").GetValue(3)

            ' NewDictionary.Words.Add(NewWord)
        Next

        Return NewDictionary
    End Function
End Module