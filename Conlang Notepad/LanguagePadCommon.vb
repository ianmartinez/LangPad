Imports System.Reflection

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

    Public Function CloneControl(ByVal control As Object) As Object
        Dim type As Type = control.GetType()
        Dim properties As PropertyInfo() = type.GetProperties()
        Dim retObject As Object = type.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, Nothing, control, Nothing)
        For Each p As PropertyInfo In properties
            If p.CanWrite Then
                p.SetValue(retObject, p.GetValue(control, Nothing), Nothing)
            End If
        Next
        Return retObject
    End Function
End Module
