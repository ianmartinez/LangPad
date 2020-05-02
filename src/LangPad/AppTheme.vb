Imports LangPadUI.Themes
''' <summary>
''' Handles the application's theme and icons.
''' </summary>
Module AppTheme
    Public Themer As ThemeManager = Nothing

    Public Sub InitThemes()
        If Themer Is Nothing Then ' No themes have been loaded yet
            Themer = New ThemeManager()
        End If
    End Sub
End Module
