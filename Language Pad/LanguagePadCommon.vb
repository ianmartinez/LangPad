Imports System.Globalization
Imports System.Reflection

Module LanguagePadCommon
    Public CurrentDocument As New NotebookFile
    Public NTVersion As Decimal = 1.3
    Public FirstTabUpdate As Boolean = False
    Public Initialized As Boolean = False
    Public SmartReplaceList As Dictionary(Of String, String)
    Public DecimalSep As String() = {" ", "'", ",", ".", "·", " ", " ", "˙", "٫", "٬", "⎖"}
    Public CurrentVersion As Decimal = Decimal.Parse((Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(0) & "." & Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(1)), CultureInfo.InvariantCulture)
    Public LangPadVersion As String = "Language Pad " & (Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(0) & If(Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(1) = "0", "", "." & Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(1)))
    Public SplashVersion As String = (Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(0) & If(Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(1) = "0", "", "." & Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(1)))

    Public Function GetTextFromRTF(ByVal RTF As String)
        Dim rtb As New RichTextBox
        rtb.Rtf = RTF
        Return rtb.Text
    End Function

    Public Function CloneControl(ByVal control As Object) As Object
        Dim type As Type = control.GetType()
        Dim properties As PropertyInfo() = type.GetProperties()
        Dim retObject As Object = type.InvokeMember("", BindingFlags.CreateInstance, Nothing, control, Nothing)
        For Each p As PropertyInfo In properties
            If p.CanWrite Then
                p.SetValue(retObject, p.GetValue(control, Nothing), Nothing)
            End If
        Next
        Return retObject
    End Function
End Module