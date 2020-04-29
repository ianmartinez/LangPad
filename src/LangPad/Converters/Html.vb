''' <summary>
''' Handles conversion to HTML
''' </summary>
Module Html
    ''' <summary>
    ''' Convert RTF to HTML.
    ''' </summary>
    ''' 
    ''' <param name="Rtf">The RTF source.</param>
    ''' <param name="Title">The title, if not only body.</param>
    ''' <param name="OnlyBody">If only the contents inside the body tag of the HTML
    ''' document should be returned.</param>
    ''' 
    ''' <returns>The RTF that has been converted to HTML.</returns>
    Function RtfToHtml(Rtf As String, Optional Title As String = "", Optional OnlyBody As Boolean = False) As String
        Dim Body = RtfPipe.Rtf.ToHtml(Rtf).ToString()

        If OnlyBody Then
            Return Body
        Else
            Dim Base = My.Resources.PageExportHtml
            Return String.Format(Base, Title, Body)
        End If
    End Function
End Module
