Imports System.Globalization
Imports TundraLib
Imports TundraLib.Themes

Module LanguagePadCommon
    Public CurrentDocument As New NotebookFile
    Public CharEditor As CharacterEditorToolWindow
    Public NTVersion As Decimal = 2.1
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

    Public StartupTheme As Theme

    Public Function GetIconResolution() As IconResolution
        If My.Settings.HiDPI Then
            Return IconResolution.HiDPI
        Else
            Return IconResolution.Normal
        End If
    End Function
End Module