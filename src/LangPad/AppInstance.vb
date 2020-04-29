Imports LangPadSupport
Imports LangPadSupport.Themes

''' <summary>
''' Contains information about the current instance of the application.
''' </summary>
Module AppInstance
    ''' <summary>
    ''' The document open in this instance of LangPad.
    ''' </summary>
    Public CurrentDocument As New NotebookFile

    ''' <summary>
    ''' The character editor tools window used between windows.
    ''' </summary>
    Public CharEditWindow As CharacterEditorToolWindow

    ''' <summary>
    ''' The internal file version for *.nt files.
    ''' </summary>
    Public Const NTVersion As Decimal = 2.1

    ''' <summary>
    ''' If the first tab has been updated on the main form.
    ''' </summary>
    Public FirstTabUpdate As Boolean = False

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
        If My.Settings.HiDPI Then
            Return IconResolution.HiDPI
        Else
            Return IconResolution.Normal
        End If
    End Function

    ''' <summary>
    ''' Get the current version of the application.
    ''' </summary>
    ''' 
    ''' <returns>The current version.</returns>
    Public Function GetCurrentVersion() As Version
        Return Reflection.Assembly.GetEntryAssembly().GetName().Version
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
End Module