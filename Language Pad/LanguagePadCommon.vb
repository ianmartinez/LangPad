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

    Public Function ResizeImage(ByVal sourceImage As Image, ByVal newSize As Size, Optional ByVal preserveAspect As Boolean = True) As Image
        Dim adjustedSize = GetAdjustedSize(sourceImage.Size, newSize, preserveAspect)

        Dim NewImage As Image = New Bitmap(adjustedSize.Width, adjustedSize.Height)
        Using ImageGraphics As Graphics = Graphics.FromImage(NewImage)
            ImageGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            ImageGraphics.DrawImage(sourceImage, 0, 0, adjustedSize.Width, adjustedSize.Height)
        End Using

        Return NewImage
    End Function

    Public Function GetAdjustedSize(ByVal oldSize As Size, ByVal newSize As Size, ByVal preserveAspect As Boolean) As Size
        Dim NewWidth As Integer
        Dim NewHeight As Integer

        If preserveAspect Then
            Dim PercentWidth As Single = newSize.Width / CSng(oldSize.Width)
            Dim PercentHeight As Single = newSize.Height / CSng(oldSize.Height)
            Dim Percent As Single = If(PercentHeight < PercentWidth, PercentHeight, PercentWidth)
            NewWidth = CInt(oldSize.Width * Percent)
            NewHeight = CInt(oldSize.Height * Percent)
        Else
            NewWidth = newSize.Width
            NewHeight = newSize.Height
        End If

        Return New Size(NewWidth, NewHeight)
    End Function
End Module