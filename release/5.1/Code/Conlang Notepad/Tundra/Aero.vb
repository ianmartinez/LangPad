Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports Tundra.ZiaFile
Public Module Aero
    Private UnsignedInteger As UInteger = 0
#Region "Interop"
    <DllImport("dwmapi.dll", EntryPoint:="#127", PreserveSig:=False)> _
    Public Sub DwmGetColorizationParameters(ByRef parameters As AeroParameters)
    End Sub

    <DllImport("dwmapi.dll", PreserveSig:=False)> _
    Public Function DwmIsCompositionEnabled() As Boolean
    End Function

    <DllImport("dwmapi.dll", EntryPoint:="#131", PreserveSig:=True)> _
    Public Sub DwmSetColorizationParameters(ByRef parameters As AeroParameters, ByVal uUnknown As UInteger)
    End Sub

    <DllImport("dwmapi.dll")> _
    Public Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function

    <DllImport("DwmApi.dll")> _
    Public Function DwmExtendFrameIntoClientArea(ByVal hwnd As IntPtr, ByRef pMarInset As Margins) As Integer
    End Function

    <DllImport("dwmapi.dll")> _
    Public Function DwmEnableBlurBehindWindow(ByVal hWnd As IntPtr, ByRef blurBehind As BlurBehindStructure) As Integer
    End Function

    Public Structure BlurBehindStructure
        Public Flags As BlurBehindFlags
        Public Enable As Boolean
        Public Region As IntPtr
        Public TransitionOnMaximized As Boolean
    End Structure

    <Flags()> _
    Public Enum BlurBehindFlags As Byte
        DwmBbEnable = 1
        DwmBbBlurregion = 2
        DwmBbTransitiononmaximized = 4
    End Enum

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure Margins
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyBottomHeight As Integer
    End Structure

    Public Structure AeroParameters
        Public ColorizationColor As Integer
        Public ColorizationAfterglow As Integer
        Public ColorizationColorBalance As Integer
        Public ColorizationAfterglowBalance As Integer
        Public ColorizationBlurBalance As Integer
        Public ColorizationGlassReflectionIntensity As Integer
        Public ColorizationOpaqueBlend As Integer
    End Structure

    <DllImport("dwmapi.dll", EntryPoint:="DwmEnableComposition")> _
    Public Function Win32DwmEnableComposition(uCompositionAction As UInteger) As UInteger
    End Function

    Public ReadOnly DWM_EC_DISABLECOMPOSITION As UInteger = 0
    Public ReadOnly DWM_EC_ENABLECOMPOSITION As UInteger = 1
#End Region

    Public Function DWMEnabled() As Boolean
        Return (System.Environment.OSVersion.Version.Major >= 6 AndAlso System.Environment.OSVersion.Version.Build >= 5600) AndAlso File.Exists(System.Environment.SystemDirectory & "\dwmapi.dll")
    End Function

    Public Sub DisableComposition()
        If DWMEnabled() Then Win32DwmEnableComposition(DWM_EC_DISABLECOMPOSITION)
    End Sub

    Public Sub EnableComposition()
        If DWMEnabled() Then Win32DwmEnableComposition(DWM_EC_ENABLECOMPOSITION)
    End Sub

    Public Sub RemoveFromAeroPeek(ByVal Window As Form)
        If DWMEnabled() AndAlso System.Environment.OSVersion.Version.Minor = 1 Then
            Dim attrValue = 1
            DwmSetWindowAttribute(Window.Handle, 12, attrValue, 4)
        End If
    End Sub

    Public Sub AddToAeroPeek(ByVal Window As Form)
        If DWMEnabled() AndAlso System.Environment.OSVersion.Version.Minor = 1 Then
            Dim attrValue = 0
            DwmSetWindowAttribute(Window.Handle, 12, attrValue, 4)
        End If
    End Sub

    Public Sub Extend(ByVal Window As Form, ByVal Left As Integer, ByVal Right As Integer, ByVal Top As Integer, ByVal Bottom As Integer, Optional ByVal AutomaticColor As Boolean = True)
        If DWMEnabled() Then
            If AutomaticColor = True Then Window.BackColor = Color.Black
            Dim AeroMargins As New Margins
            AeroMargins.cxLeftWidth = Left
            AeroMargins.cxRightWidth = Right
            AeroMargins.cyTopHeight = Top
            AeroMargins.cyBottomHeight = Bottom
            DwmExtendFrameIntoClientArea(Window.Handle, AeroMargins)
        Else
            If AutomaticColor = True Then Window.BackColor = SystemColors.Control
        End If
    End Sub

    Public Sub Retract(ByVal Window As Form, Optional ByVal AutomaticColor As Boolean = True)
        If DWMEnabled() Then
            If AutomaticColor = True Then Window.BackColor = SystemColors.Control
            Dim AeroMargins As New Margins
            AeroMargins.cxLeftWidth = 0
            AeroMargins.cxRightWidth = 0
            AeroMargins.cyTopHeight = 0
            AeroMargins.cyBottomHeight = 0
            DwmExtendFrameIntoClientArea(Window.Handle, AeroMargins)
        Else
            If AutomaticColor = True Then Window.BackColor = SystemColors.Control
        End If
    End Sub

    Public Sub Fill(ByVal Window As Form)
        If DWMEnabled() Then
            Aero.Extend(Window, -1, -1, -1, -1)
        End If
    End Sub

    Public Sub Surround(ByVal Window As Form, ByVal Control As Control, Optional ByVal AutomaticColor As Boolean = True, Optional ByVal Padding As Integer = 0)
        If DWMEnabled() Then
            If AutomaticColor = True Then Aero.Extend(Window, Control.Left + Padding, Window.ClientSize.Width - Control.Right + Padding, Control.Top + Padding, Window.ClientSize.Height - Control.Bottom + Padding)
        End If
    End Sub

    Public Sub SetColor(ByVal AeroColor As System.Drawing.Color)
        If DWMEnabled() = False Then Exit Sub
        Dim AeroParameters As AeroParameters = GetParameters()
        AeroParameters.ColorizationColor = System.Drawing.Color.FromArgb(255, AeroColor.R, AeroColor.G, AeroColor.B).ToArgb()
        SetParameters(AeroParameters)
    End Sub

    Public Sub SetAllColors(ByVal AeroColor As System.Drawing.Color)
        If DWMEnabled() = False Then Exit Sub
        Dim AeroParameters As AeroParameters = GetParameters()
        AeroParameters.ColorizationColor = System.Drawing.Color.FromArgb(255, AeroColor.R, AeroColor.G, AeroColor.B).ToArgb()
        AeroParameters.ColorizationAfterglow = System.Drawing.Color.FromArgb(255, AeroColor.R, AeroColor.G, AeroColor.B).ToArgb()
        SetParameters(AeroParameters)
    End Sub

    Public Sub SetAfterglowColor(ByVal AfterglowColor As System.Drawing.Color)
        If DWMEnabled() = False Then Exit Sub
        Dim AeroParameters As AeroParameters = GetParameters()
        AeroParameters.ColorizationAfterglow = System.Drawing.Color.FromArgb(255, AfterglowColor.R, AfterglowColor.G, AfterglowColor.B).ToArgb()
        SetParameters(AeroParameters)
    End Sub

    Public Sub SetBlurBalance(ByVal BlurBalance As Integer)
        If DWMEnabled() = False Then Exit Sub
        Dim AeroParameters As AeroParameters = GetParameters()
        AeroParameters.ColorizationBlurBalance = BlurBalance
        SetParameters(AeroParameters)
    End Sub

    Public Sub SetAfterglowBalance(ByVal AfterglowBalance As Integer)
        If DWMEnabled() = False Then Exit Sub
        Dim AeroParameters As AeroParameters = GetParameters()
        AeroParameters.ColorizationAfterglowBalance = AfterglowBalance
        SetParameters(AeroParameters)
    End Sub

    Public Sub SetGlassReflectionIntensity(ByVal GlassReflectionIntensity As Integer)
        If DWMEnabled() = False Then Exit Sub
        Dim AeroParameters As AeroParameters = GetParameters()
        AeroParameters.ColorizationGlassReflectionIntensity = GlassReflectionIntensity
        SetParameters(AeroParameters)
    End Sub

    Public Sub SetColorBalance(ByVal ColorBalance As Integer)
        If DWMEnabled() = False Then Exit Sub
        Dim AeroParameters As AeroParameters = GetParameters()
        AeroParameters.ColorizationColorBalance = ColorBalance
        SetParameters(AeroParameters)
    End Sub

    Public Function GetColorBalance() As Integer
        If DWMEnabled() = False Then Return Nothing
        Dim AeroParameters As AeroParameters = GetParameters()
        Return AeroParameters.ColorizationColorBalance
    End Function

    Public Function GetAfterglowBalance() As Integer
        If DWMEnabled() = False Then Return Nothing
        Dim AeroParameters As AeroParameters = GetParameters()
        Return AeroParameters.ColorizationAfterglowBalance
    End Function

    Public Function GetBlurBalance() As Integer
        If DWMEnabled() = False Then Return Nothing
        Dim AeroParameters As AeroParameters = GetParameters()
        Return AeroParameters.ColorizationBlurBalance
    End Function

    Public Function GetGlassReflectionIntensity() As Integer
        If DWMEnabled() = False Then Return Nothing
        Dim AeroParameters As AeroParameters = GetParameters()
        Return AeroParameters.ColorizationGlassReflectionIntensity
    End Function

    Public Function GetColor() As Color
        If DWMEnabled() = False Then Return Nothing
        Dim AeroParameters As AeroParameters = GetParameters()
        Return Color.FromArgb(AeroParameters.ColorizationColor)
    End Function

    Public Function GetAfterglowColor() As Color
        If DWMEnabled() = False Then Return Nothing
        Dim AeroParameters As AeroParameters = GetParameters()
        Return Color.FromArgb(AeroParameters.ColorizationAfterglow)
    End Function

    Public Function GetOpacity() As Boolean
        If DWMEnabled() = False Then Return Nothing
        Return GetParameters.ColorizationOpaqueBlend
    End Function
    Public Sub SetOpacity(ByVal Opaque As Boolean)
        If DWMEnabled() = False Then Exit Sub
        Dim AeroParameters As AeroParameters = GetParameters()
        AeroParameters.ColorizationOpaqueBlend = Opaque
        SetParameters(AeroParameters)
    End Sub

    Public Function GetParameters() As AeroParameters
        If DWMEnabled() = True Then
            Dim AeroParameters As AeroParameters
            DwmGetColorizationParameters(AeroParameters)
            Return AeroParameters
        Else
            Return Nothing
        End If
    End Function

    Public Sub SetParameters(ByVal AeroParameters As AeroParameters)
        If DWMEnabled() = True Then DwmSetColorizationParameters(AeroParameters, UnsignedInteger)
    End Sub
    Public Sub SetAeroParametersFromFile(ByVal FilePath As String)
        Dim Source As String = System.IO.File.ReadAllText(FilePath, System.Text.Encoding.Unicode)
        Dim FromFileParameters As New AeroParameters
        FromFileParameters.ColorizationAfterglow = CInt(GetValue(Source, "Afterglow Color"))
        FromFileParameters.ColorizationAfterglowBalance = CInt(GetValue(Source, "Afterglow Color Balance"))
        FromFileParameters.ColorizationBlurBalance = CInt(GetValue(Source, "Blur Balance"))
        FromFileParameters.ColorizationColor = CInt(GetValue(Source, "Color"))
        FromFileParameters.ColorizationColorBalance = CInt(GetValue(Source, "Color Balance"))
        FromFileParameters.ColorizationGlassReflectionIntensity = CInt(GetValue(Source, "Glass Reflection Intensity"))
        FromFileParameters.ColorizationOpaqueBlend = CInt(GetValue(Source, "IsTransparent"))
        SetParameters(FromFileParameters)
    End Sub

End Module