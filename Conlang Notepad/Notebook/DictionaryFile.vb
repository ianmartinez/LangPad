Imports System.IO
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.CodeDom.Compiler
Imports System.Resources
Imports System.Reflection
Imports System.Drawing
Imports System.Windows.Forms
Imports Tundra
Imports Ionic.Zip
Imports System.Text.RegularExpressions

<Serializable()>
Public Class DictionaryWord
    Public Word As String
    Public Pronunciation As String
    Public Definition As String
    Public Notes As String
    Public Marked As Boolean = False
End Class

<Serializable()>
Public Class DictionaryFile
    Public Words As List(Of DictionaryWord)

    Public Sub Save(ByVal FilePath As String)
        If File.Exists(FilePath) Then File.Delete(FilePath)
        DictionaryFileAccess.Save(FilePath, Me)
    End Sub

    Public Sub Open(ByVal FilePath As String, Optional ByVal Opening As Boolean = False)
        Dim NewDictionary As DictionaryFile = DictionaryFileAccess.Open(FilePath)
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
            Dim Value As String = String.Format("{0}|{1}|{2}|{3}|{4}", ToCompatibleString(CurrentWord.Word), ToCompatibleString(CurrentWord.Pronunciation),
                                                ToCompatibleString(CurrentWord.Definition), ToCompatibleString(CurrentWord.Notes), CurrentWord.Marked)
            DictionaryString.Add(New ZiaLine(LineType.KeyValue, "Word " & i, Value))
        Next

        'Write to disk
        System.IO.File.WriteAllText(FilePath, ZiaFile.Write(DictionaryString))
    End Sub

    Public Function Open(ByVal FilePath As String) As DictionaryFile
        On Error Resume Next
        Dim NewDictionary As New DictionaryFile

        Dim LineList As Dictionary(Of String, String) = ZiaFile.Read(File.ReadAllText(FilePath))
        For Each PageTitle As KeyValuePair(Of String, String) In LineList

        Next

        Return NewDictionary
    End Function

End Module