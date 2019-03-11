Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class TransparentRichTextBox
    Inherits RichTextBox

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function LoadLibrary(ByVal lpFileName As String) As IntPtr
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim params As CreateParams = MyBase.CreateParams
            If LoadLibrary("msftedit.dll") <> IntPtr.Zero Then
                params.ExStyle = params.ExStyle Or &H20
                params.ClassName = "RICHEDIT50W"
            End If
            Return params
        End Get
    End Property

    Public Sub New()
        DoubleBuffered = True
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub
End Class