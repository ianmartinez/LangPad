Imports System.Windows.Forms
Public Class DoubleBufferedPanel
    Inherits Panel
    Public Sub New()
        Me.DoubleBuffered = True
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub
End Class
