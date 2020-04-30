Imports ReverseMarkdown

''' <summary>
''' Handles the conversion to Markdown
''' </summary>
Module Markdown
    Public Function RtfToMarkdown(Rtf As String) As String
        Dim MdConverter = New Converter()
        Dim Html = RtfToHtml(Rtf, "", True)
        Return MdConverter.Convert(Html).Trim()
    End Function
End Module
