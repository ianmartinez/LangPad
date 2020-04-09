Imports System.Drawing.Drawing2D
Imports TundraLib
Imports TundraLib.Themes

Module LanguagePadCommon
    Public CurrentDocument As New NotebookFile
    Public CharEditor As CharacterEditorToolWindow
    Public NTVersion As Decimal = 2.1
    Public FirstTabUpdate As Boolean = False
    Public Initialized As Boolean = False
    Public SmartReplaceList As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Public StartupTheme As Theme

    Public Function GetIconResolution() As IconResolution
        If My.Settings.HiDPI Then
            Return IconResolution.HiDPI
        Else
            Return IconResolution.Normal
        End If
    End Function

    Public Function GetCurrentVersion() As Version
        Return Reflection.Assembly.GetEntryAssembly().GetName().Version
    End Function

    Public Function GetCurrentVersionDecimal() As Decimal
        Dim AppVersion = GetCurrentVersion()
        Return Decimal.Parse(AppVersion.Major & "." & AppVersion.Minor)
    End Function

    Public Function GetVersionString() As String
        Dim AppVersion = GetCurrentVersion()
        Return AppVersion.Major & If(AppVersion.Minor = 0, "", "." & AppVersion.Minor)
    End Function

    Public Function ResizeImage(ByVal sourceImage As Image, ByVal imageSize As Size, Optional ByVal preserveAspect As Boolean = True) As Image
        Dim NewWidth As Integer
        Dim NewHeight As Integer

        If preserveAspect Then
            Dim OriginalWidth As Integer = sourceImage.Width
            Dim OriginalHeight As Integer = sourceImage.Height
            Dim PercentWidth As Single = imageSize.Width / CSng(OriginalWidth)
            Dim PercentHeight As Single = imageSize.Height / CSng(OriginalHeight)
            Dim Percent As Single = If(PercentHeight < PercentWidth, PercentHeight, PercentWidth)
            NewWidth = CInt(OriginalWidth * Percent)
            NewHeight = CInt(OriginalHeight * Percent)
        Else
            NewWidth = imageSize.Width
            NewHeight = imageSize.Height
        End If

        Dim NewImage As Image = New Bitmap(NewWidth, NewHeight)
        Using ImageGraphics As Graphics = Graphics.FromImage(NewImage)
            ImageGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            ImageGraphics.DrawImage(sourceImage, 0, 0, NewWidth, NewHeight)
        End Using

        Return NewImage
    End Function
End Module