Imports System.Globalization
Imports System.Reflection

Module LanguagePadCommon
    Public CurrentDocument As New NotebookFile
    Public NTVersion As Decimal = 1.3
    Public FirstTabUpdate As Boolean = False
    Public Initialized As Boolean = False
    Public SmartReplaceList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Public DecimalSep As String() = {" ", "'", ",", ".", "·", " ", " ", "˙", "٫", "٬", "⎖"}
    Public CurrentVersion As Decimal = Decimal.Parse((Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(0) &
                                                     "." &
                                                     Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(1)), CultureInfo.InvariantCulture)

    Public LangPadVersion As String = "Language Pad " &
        (Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(0) &
        If(Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(1) = "0", "", "." &
        Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(1)))

    Public SplashVersion As String = (Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(0) &
        If(Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(1) = "0", "", "." &
        Application.ProductVersion.Split(DecimalSep, StringSplitOptions.RemoveEmptyEntries).GetValue(1)))
End Module