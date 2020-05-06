''' <summary>
''' Old functions for interpreting values from
''' KeyValue files, to be re-written later.
''' </summary>
Module KeyValueConverter
    Public Function FromCompatibleColor(ByVal SourceSter As String) As Color
        If SourceSter.Split(","c).Length = 4 Then
            Return Color.FromArgb(Integer.Parse(SourceSter.Split(","c)(0)), Integer.Parse(SourceSter.Split(","c)(1)), Integer.Parse(SourceSter.Split(","c)(2)), Integer.Parse(SourceSter.Split(","c)(3)))
        ElseIf SourceSter.Split(","c).Length = 3 Then
            Return Color.FromArgb(Integer.Parse(SourceSter.Split(","c)(0)), Integer.Parse(SourceSter.Split(","c)(1)), Integer.Parse(SourceSter.Split(","c)(2)))
        ElseIf SourceSter.StartsWith("#") Then
            Return ColorTranslator.FromHtml(SourceSter)
        ElseIf SourceSter.StartsWith("~") Then
            Dim LightnessValue As Integer = Integer.Parse(SourceSter.Remove(0, 1))
            Return Color.FromArgb(LightnessValue, LightnessValue, LightnessValue)
        ElseIf SourceSter = "$NULL" Then
            Return Color.Transparent
        ElseIf SourceSter = "$0" Then
            Return Color.Transparent
        ElseIf SourceSter = "$1" Then
            Return Color.White
        ElseIf SourceSter = "$2" Then
            Return Color.Black
        Else
            Return Color.Transparent
        End If
    End Function

    Public Function FromCompatibleFont(ByVal SourceStr As String) As Font
        Dim Name As String = SourceStr.Split("|"c)(0)
        Dim Size As Single = (Single.Parse(SourceStr.Split("|"c)(1)))
        Dim FontStyle As FontStyle = CType([Enum].Parse(GetType(FontStyle), SourceStr.Split("|"c)(2)), FontStyle)
        Return New Font(Name, Size, FontStyle)
    End Function
End Module