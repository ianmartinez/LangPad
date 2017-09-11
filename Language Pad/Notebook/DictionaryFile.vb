Imports System.IO
Imports Tundra

<Serializable()>
Public Class DictionaryWord
    Public Word As String
    Public Pronunciation As String
    Public Definition As String
    Public Notes As String
End Class

<Serializable()>
Public Class DictionaryFile
    Public Words As List(Of DictionaryWord)

    Public Sub Save(ByVal FilePath As String)
        If File.Exists(FilePath) Then File.Delete(FilePath)
        DictionaryFileAccess.Save(FilePath, Me)
    End Sub

    Public Sub Open(ByVal FilePath As String)
        Dim NewDictionary As DictionaryFile = DictionaryFileAccess.Open(FilePath)
        Me.Words = NewDictionary.Words
    End Sub

    Public Sub OpenCSV(ByVal FilePath As String)
        Dim NewDictionary As DictionaryFile = DictionaryFileAccess.OpenCSV(FilePath)
        Me.Words = NewDictionary.Words
    End Sub

    Public Sub New()
        Me.Words = New List(Of DictionaryWord)
    End Sub
End Class

Module DictionaryFileAccess
    Sub Save(ByVal FilePath As String, ByVal Dictionary As DictionaryFile)
        On Error Resume Next
        Dim DictionaryString As New List(Of ZiaLine)
        DictionaryString.Add(New ZiaLine(LineType.Comment, "Dictionary"))
        DictionaryString.Add(New ZiaLine(LineType.Comment, "Language Pad Version:" & LangPadVersion))

        For i = 0 To Dictionary.Words.Count - 1
            Dim CurrentWord As DictionaryWord = Dictionary.Words.Item(i)
            Dim Value As String = String.Format("{0}|{1}|{2}|{3}", ToCompatibleString(CurrentWord.Word), ToCompatibleString(CurrentWord.Pronunciation),
                                                ToCompatibleString(CurrentWord.Definition), ToCompatibleString(CurrentWord.Notes))
            DictionaryString.Add(New ZiaLine(LineType.KeyValue, "Word " & i, Value))
        Next

        File.WriteAllText(FilePath, ZiaFile.Write(DictionaryString))
    End Sub

    Public Function Open(ByVal FilePath As String) As DictionaryFile
        On Error Resume Next
        Dim NewDictionary As New DictionaryFile
        Dim LineList As Dictionary(Of String, String) = ZiaFile.Read(File.ReadAllText(FilePath))

        For Each CurrentLine As KeyValuePair(Of String, String) In LineList
            If Not CurrentLine.Key.StartsWith("Word") Then Continue For
            Dim NewWord As New DictionaryWord
            NewWord.Word = FromCompatibleString(CurrentLine.Value.Split("|").GetValue(0))
            NewWord.Pronunciation = FromCompatibleString(CurrentLine.Value.Split("|").GetValue(1))
            NewWord.Definition = FromCompatibleString(CurrentLine.Value.Split("|").GetValue(2))
            NewWord.Notes = FromCompatibleString(CurrentLine.Value.Split("|").GetValue(3))

            NewDictionary.Words.Add(NewWord)
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

            NewDictionary.Words.Add(NewWord)
        Next

        Return NewDictionary
    End Function
End Module