Imports LangPadData
Imports LangPadUI
Imports LangPadUI.Theming

''' <summary>
''' Contains information about the current instance of the application.
''' </summary>
Module AppInstance
    ''' <summary>
    ''' Get the current version of the application.
    ''' </summary>
    ''' 
    ''' <returns>The current version.</returns>
    Public Function GetCurrentVersion() As Version
        Return New Version(12, 0, 0)
    End Function

    ''' <summary>
    ''' The character editor tools window used between windows.
    ''' </summary>
    Public CharEditWindow As CharacterEditorToolWindow = New CharacterEditorToolWindow()

    ''' <summary>
    ''' A list of accent+base character combinations to replace with
    ''' a single character.
    ''' </summary>
    Public SmartReplaceList As Dictionary(Of String, String) = New Dictionary(Of String, String)

    ''' <summary>
    ''' The theme of the application's interface.
    ''' </summary>
    Public ApplicationTheme As Theme

    ''' <summary>
    ''' Get the icon resolution set by the user.
    ''' </summary>
    ''' 
    ''' <returns>The user's icon resolution.</returns>
    Public Function GetIconResolution() As IconResolution
        If Config.HiDPI Then
            Return IconResolution.HiDPI
        Else
            Return IconResolution.Normal
        End If
    End Function

    ''' <summary>
    ''' Get the application version, formatted as a string.
    ''' </summary>
    ''' 
    ''' <returns>The application version string.</returns>
    Public Function GetVersionString() As String
        Dim AppVersion = GetCurrentVersion()
        Return AppVersion.Major & If(AppVersion.Minor = 0, "", "." & AppVersion.Minor)
    End Function

    ''' <summary>
    ''' Get the application name, plus its version number as a 
    ''' string.
    ''' </summary>
    ''' 
    ''' <returns>The display name used throughout the application.</returns>
    Public Function GetAppDisplayName() As String
        Return "LangPad " + GetVersionString()
    End Function

    ''' <summary>
    ''' Opens the Patreon link.
    ''' </summary>
    Public Sub GoToPatreon()
        OpenUrl("https://www.patreon.com/ianmartinez")
    End Sub

    ''' <summary>
    ''' Opens the GitHub link.
    ''' </summary>
    Public Sub GoToGitHub()
        OpenUrl("https://github.com/ianmartinez/LangPad")
    End Sub

    ''' <summary>
    ''' Opens the website link.
    ''' </summary>
    Public Sub GoToWebsite()
        OpenUrl("http://www.ianmtz.com/LangPad")
    End Sub
End Module