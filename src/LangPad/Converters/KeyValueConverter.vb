Module KeyValueConverter
    Public Function FromCompatibleColor(ByVal sourceStr As String) As Color
        If sourceStr.Split(","c).Length = 4 Then
            Return Color.FromArgb(Integer.Parse(sourceStr.Split(","c)(0)), Integer.Parse(sourceStr.Split(","c)(1)), Integer.Parse(sourceStr.Split(","c)(2)), Integer.Parse(sourceStr.Split(","c)(3)))
        ElseIf sourceStr.Split(","c).Length = 3 Then
            Return Color.FromArgb(Integer.Parse(sourceStr.Split(","c)(0)), Integer.Parse(sourceStr.Split(","c)(1)), Integer.Parse(sourceStr.Split(","c)(2)))
        ElseIf sourceStr.StartsWith("#") Then
            Return ColorTranslator.FromHtml(sourceStr)
        ElseIf sourceStr.StartsWith("~") Then
            Dim black As Integer = Integer.Parse(sourceStr.Remove(0, 1))
            Return Color.FromArgb(black, black, black)
        ElseIf sourceStr = "$NULL" Then
            Return Color.Transparent
        ElseIf sourceStr = "$0" Then
            Return Color.Transparent
        ElseIf sourceStr = "$1" Then
            Return Color.White
        ElseIf sourceStr = "$2" Then
            Return Color.Black
        Else
            Return Color.Transparent
        End If
    End Function

    Public Function FromCompatibleFont(ByVal sourceStr As String) As Font
        Dim _Name As String = sourceStr.Split("|"c)(0)
        Dim _Size As Single = (Single.Parse(sourceStr.Split("|"c)(1)))
        Dim _FontStyle As FontStyle = CType([Enum].Parse(GetType(FontStyle), sourceStr.Split("|"c)(2)), FontStyle)
        Return New Font(_Name, _Size, _FontStyle)
    End Function
End Module