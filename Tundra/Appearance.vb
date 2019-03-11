Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms

Public Class Appearance
    Public Const SPI_SETDESKWALLPAPER As Integer = 20
    Public Const SPIF_UPDATEINIFILE As Integer = &H1
    Public Const SPIF_SENDWININICHANGE As Integer = &H2

    <DllImport("uxtheme.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function GetCurrentThemeName(ByVal pszThemeFileName As StringBuilder, ByVal dwMaxNameChars As Integer, ByVal pszColorBuff As StringBuilder, ByVal dwMaxColorChars As Integer, ByVal pszSizeBuff As StringBuilder, ByVal cchMaxSizeChars As Integer) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As Integer, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function SystemParametersInfo(ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    End Function

    <DllImport("user32.dll")> _
    Public Shared Function GetClassLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As UInteger
    End Function

    <DllImport("user32.dll")> _
    Public Shared Function GetForegroundWindow() As IntPtr
    End Function

    Public Enum Style As Integer
        Tile
        Center
        Stretch
        Fit
        Fill
    End Enum

    Public Shared Sub SetWallpaper(ByVal Source As Image, ByVal WallpaperStyle As Style)
        Dim TempPath As String = Path.Combine(Path.GetTempPath(), "Desktop Wallpaper.bmp")
        Source.Save(TempPath, Imaging.ImageFormat.Bmp)
        Dim WallpaperStyleKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", True)
        If WallpaperStyle = Style.Tile Then
            WallpaperStyleKey.SetValue("WallpaperStyle", "0")
            WallpaperStyleKey.SetValue("TileWallpaper", "1")
        ElseIf WallpaperStyle = Style.Center Then
            WallpaperStyleKey.SetValue("WallpaperStyle", "0")
            WallpaperStyleKey.SetValue("TileWallpaper", "0")
        ElseIf WallpaperStyle = Style.Stretch Then
            WallpaperStyleKey.SetValue("WallpaperStyle", "2")
            WallpaperStyleKey.SetValue("TileWallpaper", "0")
        ElseIf WallpaperStyle = Style.Fit Then
            WallpaperStyleKey.SetValue("WallpaperStyle", "6")
            WallpaperStyleKey.SetValue("TileWallpaper", "0")
        ElseIf WallpaperStyle = Style.Fill Then
            WallpaperStyleKey.SetValue("WallpaperStyle", "10")
            WallpaperStyleKey.SetValue("TileWallpaper", "0")
        End If

        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, TempPath, SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE)
    End Sub

    Public Class Theme
        Public FileName As String
        Public Color As String
        Public Size As String
        Public Sub New(ByVal SFileName As String, ByVal SColor As String, ByVal SSize As String)
            FileName = SFileName
            Color = SColor
            Size = SSize
        End Sub
    End Class

    Public Shared Function GetTheme() As Theme
        On Error Resume Next
        Dim ThemeNameStringBuilder As New StringBuilder(260)
        Dim ThemeColorStringBuilder As New StringBuilder
        Dim ThemeSizeStringBuilder As New StringBuilder
        GetCurrentThemeName(ThemeNameStringBuilder, ThemeNameStringBuilder.Capacity, ThemeColorStringBuilder, ThemeColorStringBuilder.Capacity, ThemeSizeStringBuilder, ThemeSizeStringBuilder.Capacity)
        GetTheme = New Theme(ThemeNameStringBuilder.ToString, ThemeColorStringBuilder.ToString, ThemeSizeStringBuilder.ToString)
    End Function

    Public Const WM_GETICON As Integer = &H7F
    Public Shared Function GetAppIcon(ByVal hwnd As IntPtr) As System.Drawing.Icon
        Dim iconHandle = IntPtr.Zero
        If iconHandle = IntPtr.Zero Then
            iconHandle = CType(GetClassLong(hwnd, -34), IntPtr)
        End If
        If iconHandle = IntPtr.Zero Then
            iconHandle = CType(GetClassLong(hwnd, -14), IntPtr)
        End If
        If iconHandle = IntPtr.Zero Then
            iconHandle = SendMessage(hwnd, WM_GETICON, 1, IntPtr.Zero)
        End If
        If iconHandle = IntPtr.Zero Then
            iconHandle = SendMessage(hwnd, WM_GETICON, 0, IntPtr.Zero)
        End If

        If iconHandle = IntPtr.Zero Then
            Return Nothing
        End If

        Return Icon.FromHandle(iconHandle)
    End Function

    Public Shared Function GetWallpaper() As Image
        On Error Resume Next
        Dim WallpaperMemoryStream As New MemoryStream(My.Computer.FileSystem.ReadAllBytes(GetWallpaperPath))
        Return New Bitmap(WallpaperMemoryStream)
    End Function

    Public Shared Function GetWallpaperPath() As String
        On Error Resume Next
        Dim RegistryWallpaperPath As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = RegistryWallpaperPath.GetValue("Wallpaper").ToString()
        RegistryWallpaperPath.Close()
        Return WallpaperPath
    End Function

    Public Shared Function TakeScreenshot() As Image
        Dim Screenshot As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim g = Graphics.FromImage(Screenshot)
        g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy)
        Return Screenshot
    End Function
End Class
