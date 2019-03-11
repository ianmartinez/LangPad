Imports System.Windows.Forms

Public Class DoubleBufferedFlowLayoutPanel
    Inherits FlowLayoutPanel
    Public Sub New()
        DoubleBuffered = True
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
    End Sub
End Class
