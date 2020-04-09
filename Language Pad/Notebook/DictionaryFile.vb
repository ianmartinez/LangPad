Imports System.IO
Imports TundraLib.ZiaFile

<Serializable()>
Public Class DictionaryWord
    Implements IComparable, IComparer
    Public Word As String = ""
    Public Pronunciation As String = ""
    Public Definition As String = ""
    Public Notes As String = ""

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Return Word.CompareTo(CType(obj, DictionaryWord).Word)
    End Function

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Return CType(x, DictionaryWord).CompareTo(y)
    End Function
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
        Words = NewDictionary.Words
    End Sub

    Public Sub OpenCSV(ByVal FilePath As String)
        Dim NewDictionary As DictionaryFile = DictionaryFileAccess.OpenCSV(FilePath)
        Words = NewDictionary.Words
    End Sub

    Public Sub New()
        Words = New List(Of DictionaryWord)
    End Sub
End Class

Module DictionaryFileAccess
    Sub Save(ByVal FilePath As String, ByVal Dictionary As DictionaryFile)
        Dim DictionaryString As New List(Of ZiaLine) From {
            New ZiaLine(LineType.Comment, "Dictionary"),
            New ZiaLine(LineType.Comment, "Language Pad Version:" & "Language Pad " & GetVersionString())
        }

        For i = 0 To Dictionary.Words.Count - 1
            Dim CurrentWord As DictionaryWord = Dictionary.Words.Item(i)
            Dim Value As String = String.Format("{0}|{1}|{2}|{3}", ToCompatibleString(CurrentWord.Word), ToCompatibleString(CurrentWord.Pronunciation),
                                                ToCompatibleString(CurrentWord.Definition), ToCompatibleString(CurrentWord.Notes))
            DictionaryString.Add(New ZiaLine(LineType.KeyValue, "Word " & i, Value))
        Next

        File.WriteAllText(FilePath, Write(DictionaryString))
    End Sub

    Public Function Open(ByVal FilePath As String) As DictionaryFile
        Dim NewDictionary As New DictionaryFile
        Dim LineList As Dictionary(Of String, String) = Read(File.ReadAllText(FilePath))

        For Each CurrentLine As KeyValuePair(Of String, String) In LineList
            If Not CurrentLine.Key.StartsWith("Word") Or CurrentLine.Value.Split("|").Count <> 4 Then Continue For
            Dim NewWord As New DictionaryWord With {
                .Word = FromCompatibleString(CurrentLine.Value.Split("|").GetValue(0)),
                .Pronunciation = FromCompatibleString(CurrentLine.Value.Split("|").GetValue(1)),
                .Definition = FromCompatibleString(CurrentLine.Value.Split("|").GetValue(2)),
                .Notes = FromCompatibleString(CurrentLine.Value.Split("|").GetValue(3))
            }

            NewDictionary.Words.Add(NewWord)
        Next

        Return NewDictionary
    End Function

    Public Function OpenCSV(ByVal FilePath As String) As DictionaryFile
        Dim NewDictionary As New DictionaryFile
        Dim Lines As String() = File.ReadAllText(FilePath).Split(New String() {Environment.NewLine, vbCrLf, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries)

        For Each CurrentLine As String In Lines
            If CurrentLine.Trim().Equals("Word,Pronunciation,Definition,Notes") Then Continue For

            Dim NewWord As New DictionaryWord With {
                .Word = CurrentLine.Split(",").GetValue(0),
                .Pronunciation = CurrentLine.Split(",").GetValue(1),
                .Definition = CurrentLine.Split(",").GetValue(2),
                .Notes = CurrentLine.Split(",").GetValue(3)
            }

            NewDictionary.Words.Add(NewWord)
        Next

        Return NewDictionary
    End Function
End Module