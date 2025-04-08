''' <summary>
''' Old functions for interpreting values from
''' KeyValue files, to be re-written later.
''' </summary>
Module KeyValueConverter

    ''' <summary>
    ''' Convert from a serialized color to a color object.
    ''' </summary>
    ''' 
    ''' <param name="SourceStr">The serialized color.</param>
    ''' 
    ''' <returns>The color that was parsed.</returns>
    Public Function FromCompatibleColor(SourceStr As String) As Color
        Dim ColorParts = SourceStr.Split(","c)
        If ColorParts.Length = 4 Then
            Return Color.FromArgb(Integer.Parse((0)), Integer.Parse(ColorParts(1)), Integer.Parse(ColorParts(2)), Integer.Parse(ColorParts(3)))
        ElseIf ColorParts.Length = 3 Then
            Return Color.FromArgb(Integer.Parse(ColorParts(0)), Integer.Parse(ColorParts(1)), Integer.Parse(ColorParts(2)))
        ElseIf SourceStr.StartsWith("#") Then
            Return ColorTranslator.FromHtml(SourceStr)
        ElseIf SourceStr.StartsWith("~") Then
            Dim LightnessValue As Integer = Integer.Parse(SourceStr.Remove(0, 1))
            Return Color.FromArgb(LightnessValue, LightnessValue, LightnessValue)
        ElseIf SourceStr = "$NULL" Then
            Return Color.Transparent
        ElseIf SourceStr = "$0" Then
            Return Color.Transparent
        ElseIf SourceStr = "$1" Then
            Return Color.White
        ElseIf SourceStr = "$2" Then
            Return Color.Black
        Else
            Return Color.Transparent
        End If
    End Function

    ''' <summary>
    ''' Convert from a serialized font to a font object.
    ''' </summary>
    ''' 
    ''' <param name="SourceStr">The serialized font.</param>
    ''' 
    ''' <returns>The font that was parsed.</returns>
    Public Function FromCompatibleFont(SourceStr As String) As Font
        Dim FontParts = SourceStr.Split("|"c)
        Dim Name As String = FontParts(0)
        Dim Size As Single = (Single.Parse(FontParts(1)))
        Dim FontStyle As FontStyle = CType([Enum].Parse(GetType(FontStyle), FontParts(2)), FontStyle)

        Return New Font(Name, Size, FontStyle)
    End Function
End Module