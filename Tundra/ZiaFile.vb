Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Module ZiaFile
    Public Enum LineType
        Comment
        KeyValue
        Blank
    End Enum
    Public Structure ZiaLine
        Public LineType As LineType
        Public Key As String
        Public Value As String
        Public Sub New(ByVal _LineType As LineType, Optional ByVal _Key As String = "", Optional ByVal _Value As String = "")
            LineType = _LineType
            Key = _Key
            Value = _Value
        End Sub
    End Structure

    Public Function ReadSectioned(ByVal Data As String) As Dictionary(Of String, Dictionary(Of String, String))
        On Error Resume Next
        Dim Sections As String() = Data.Split(New String() {"["}, StringSplitOptions.RemoveEmptyEntries)
        Dim TemporaryDictionary As New Dictionary(Of String, Dictionary(Of String, String))
        For Each Section As String In Sections
            TemporaryDictionary.Add(Section.Split(vbLf).GetValue(0).ToString.Remove(Section.Split(vbLf).GetValue(0).ToString.Length - 1, 1), Read(Section))
        Next
        Return TemporaryDictionary
    End Function

    Public Function Read(ByVal Data As String) As Dictionary(Of String, String)
        On Error Resume Next
        Dim Lines As String() = Data.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim TemporaryDictionary As New Dictionary(Of String, String)
        For Each Line As String In Lines
            If Line.StartsWith("!") Then Continue For
            If Line.StartsWith("#") Then Continue For
            If Not Line.Contains("=") Then Continue For
            TemporaryDictionary.Add(FromCompatibleString(Line.Split("=").GetValue(0)), FromCompatibleString(Line.Split("=").GetValue(1)))
        Next
        Return TemporaryDictionary
    End Function
    Public Function Write(ByVal Source As List(Of ZiaLine), Optional ByVal MakeCompatible As Boolean = False) As String
        Dim RString As String = ""
        For Each Line As ZiaLine In Source
            If Line.LineType = LineType.Comment Then
                RString = RString.Insert(RString.Length, String.Format("#{0}", Line.Key))
            ElseIf Line.LineType = LineType.KeyValue Then
                If MakeCompatible = True Then
                    RString = RString.Insert(RString.Length, String.Format("{0}={1}", Line.Key, ToCompatibleString(Line.Value)))
                Else
                    RString = RString.Insert(RString.Length, String.Format("{0}={1}", Line.Key, Line.Value))
                End If
            Else

            End If
            RString = RString.Insert(RString.Length, Environment.NewLine)
        Next
        Return RString
    End Function

    Public Function SearchSectioned(ByVal Data As Dictionary(Of String, Dictionary(Of String, String)), ByVal LookupSection As String, ByVal LookupKey As String) As String
        On Error Resume Next
        For Each CurrentSection As KeyValuePair(Of String, Dictionary(Of String, String)) In Data
            If Not CurrentSection.Key = LookupSection Then Continue For
            Return Search(CurrentSection.Value, LookupKey)
        Next
    End Function

    Public Function Search(ByVal Data As Dictionary(Of String, String), ByVal Lookup As String) As String
        On Error Resume Next
        Return Data.Item(Lookup)
    End Function

    Public Function GetValue(ByVal Data As String, ByVal Lookup As String) As String
        On Error Resume Next
        Return ZiaFile.Search(ZiaFile.Read(Data), Lookup)
    End Function

    Public Function ToCompatibleString(ByVal Source As String) As String
        On Error Resume Next
        Source = Source.Replace("=", ":eq:")
        Source = Source.Replace("|", ":pi:")
        Source = Source.Replace(",", ":co:")
        Source = Source.Replace(Environment.NewLine, ":cr:")
        Source = Source.Replace(vbCrLf, ":cr:")
        Source = Source.Replace(vbLf, ":cr:")
        Source = Source.Replace(vbCr, ":cr:")
        Return Source
    End Function

    Public Function ToCompatibleColor(ByVal Source As Color) As String
        On Error Resume Next
        If Source = Color.Transparent Then
            Return "$0"
        ElseIf Source = Color.White Then
            Return "$1"
        ElseIf Source = Color.Black Then
            Return "$2"
        Else
            Return String.Format("{0},{1},{2},{3}", Source.A, Source.R, Source.G, Source.B)
        End If
    End Function

    Public Function ToCompatibleSingleList(ByVal Source() As Single) As String
        On Error Resume Next
        Dim CompatibleSingleList As String = ""
        For Each _Single As Single In Source
            CompatibleSingleList = CompatibleSingleList & _Single & "|"
        Next
        Return CompatibleSingleList
    End Function

    Public Function ToCompatibleStringList(ByVal Source As List(Of String)) As String
        On Error Resume Next
        Dim CompatibleSingleList As String = ""
        For Each _String As String In Source
            If _String = "" Then Continue For
            If _String = " " Then Continue For
            CompatibleSingleList = CompatibleSingleList & _String & "|"
        Next
        Return CompatibleSingleList
    End Function

    Public Function ToCompatibleColorList(ByVal Source() As Color) As String
        On Error Resume Next
        Dim CompatibleSingleList As String = ""
        For Each _Color As Color In Source
            CompatibleSingleList = CompatibleSingleList & ToCompatibleColor(_Color) & "|"
        Next
        Return CompatibleSingleList
    End Function

    Public Function ToCompatibleFont(ByVal Source As Font) As String
        On Error Resume Next
        Return String.Format("{0}|{1}|{2}", Source.Name, Source.Size, Source.Style)
    End Function

    Public Function FromCompatibleString(ByVal Source As String) As String
        On Error Resume Next
        Source = Source.Replace(":eq:", "=")
        Source = Source.Replace(":pi:", "|")
        Source = Source.Replace(":co:", ",")
        Source = Source.Replace(":cr:", Environment.NewLine)
        Return Source
    End Function

    Public Function FromCompatibleColorList(ByVal Source As String) As Color()
        On Error Resume Next
        Dim TempararyColors As New List(Of Color)
        Dim SplitColors As String() = Source.Split(New String() {"|"}, StringSplitOptions.RemoveEmptyEntries)
        For Each ThisColor As String In SplitColors
            If ThisColor = Nothing Then Return Nothing
            If Char.IsWhiteSpace(ThisColor.Chars(1)) = True Then Return Nothing
            TempararyColors.Add(FromCompatibleColor(ThisColor))
        Next
        Return TempararyColors.ToArray
    End Function

    Public Function FromCompatibleIntegerList(ByVal Source As String) As Integer()
        On Error Resume Next
        Dim TempararyIntegers As New List(Of Integer)
        Dim SplitIntegers As String() = Source.Split(New String() {"|"}, StringSplitOptions.RemoveEmptyEntries)
        For Each ThisInteger As String In SplitIntegers
            If ThisInteger = Nothing Then Return Nothing
            If Char.IsWhiteSpace(ThisInteger.Chars(1)) = True Then Return Nothing
            TempararyIntegers.Add(ThisInteger)
        Next
        Return TempararyIntegers.ToArray
    End Function

    Public Function FromCompatibleSingleList(ByVal Source As String) As Single()
        On Error Resume Next
        Dim TempararySingles As New List(Of Single)
        Dim SplitSingles As String() = Source.Split(New String() {"|"}, StringSplitOptions.RemoveEmptyEntries)
        If SplitSingles.Length = 0 Then Return Nothing
        For Each ThisSingle As String In SplitSingles
            If ThisSingle = Nothing Then Return Nothing
            If ThisSingle = "" Then Return Nothing
            If ThisSingle = " " Then Return Nothing
            TempararySingles.Add(ThisSingle)
        Next
        Return TempararySingles.ToArray
    End Function

    Public Function FromCompatibleColor(ByVal Source As String) As Color
        On Error Resume Next
        If Source.StartsWith("?") Then
            Return Color.FromArgb(Source.Split("/").GetValue(0).ToString.Remove(0, 1), FromCompatibleColor(Source.Split("/").GetValue(1)))
            Exit Function
        End If

        If Source.Split(",").Length = 4 Then
            Return Color.FromArgb(Source.Split(",").GetValue(0), Source.Split(",").GetValue(1), Source.Split(",").GetValue(2), Source.Split(",").GetValue(3))
        ElseIf Source.Split(",").Length = 3 Then
            Return Color.FromArgb(Source.Split(",").GetValue(0), Source.Split(",").GetValue(1), Source.Split(",").GetValue(2))
        ElseIf Source.StartsWith("#") Then
            Return ColorTranslator.FromHtml(Source)
        ElseIf Source.StartsWith("~") Then
            Dim B As String = Source.Remove(0, 1)
            Return Color.FromArgb(B, B, B)
        ElseIf Source = "$NULL" Then
            Return Color.Transparent
        ElseIf Source = "$0" Then
            Return Color.Transparent
        ElseIf Source = "$1" Then
            Return Color.White
        ElseIf Source = "$2" Then
            Return Color.Black
        Else
            Return Color.Transparent
        End If
    End Function
    Public Function FromCompatibleFont(ByVal Source As String) As Font
        Dim _Name As String = Source.Split("|").GetValue(0)
        Dim _Single As Single = CType((Source.Split("|").GetValue(1)), Single)
        Dim _FontStyle As FontStyle = Source.Split("|").GetValue(2)
        Return New Font(_Name, _Single, _FontStyle)
    End Function
    Public Function FromCompatibleFont2(ByVal Source As String) As Font
        Dim _Name As String = Source.Split("|").GetValue(0)
        Dim _Single As Single = CType((Source.Split("|").GetValue(1)), Single)
        Dim _FontStyle As FontStyle = CType([Enum].Parse(GetType(FontStyle), Source.Split("|").GetValue(2)), FontStyle)
        Return New Font(_Name, _Single, _FontStyle)
    End Function
    Public Function FromCompatiblePoint(ByVal Source As String) As Point
        Source = Source.Remove(0, 1)
        Source = Source.Remove(Source.Length - 1, 1)
        Return New Point(Source.Split(",").GetValue(0), Source.Split(",").GetValue(1))
    End Function

End Module
