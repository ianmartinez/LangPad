Module LanguagePadCommon

    Public CurrentDocument As New NotebookFile
    Public NTVersion As Decimal = 1.1
    Public FirstTabUpdate As Boolean = False
    Public Initialized As Boolean = False
    Public CurrentVersion As Decimal = (Application.ProductVersion.Split(".").GetValue(0) & "." & Application.ProductVersion.Split(".").GetValue(1))
    Public LangPadVersion As String = "Language Pad " & CurrentVersion.ToString
    Public Function GetTextFromRTF(ByVal RTF As String)
        Dim rtb As New RichTextBox
        rtb.Rtf = RTF
        Return rtb.Text
    End Function
End Module
