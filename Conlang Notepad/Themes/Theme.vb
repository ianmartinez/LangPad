Public Class Theme
    Public Name As String
    Public Color1 As Color = Color.Gray
    Public Color2 As Color = Color.Gray

    Public Overridable Function GetToolStripRenderer() As ToolStripRenderer
        Return New ToolStripProfessionalRenderer()
    End Function

    Public Overridable Function GetMenuRenderer() As ToolStripRenderer
        Return New ToolStripProfessionalRenderer()
    End Function

    Public Sub New(Name As String)
        Me.Name = Name
    End Sub
End Class

Public Class AeroTheme
    Inherits Theme

    Public Sub New()
        MyBase.New("Aero")

        Color1 = clrHorBG_GrayBlue
        Color2 = clrHorBG_White
    End Sub

    Public Overrides Function GetToolStripRenderer() As ToolStripRenderer
        Return New clsToolstripRenderer
    End Function

    Public Overrides Function GetMenuRenderer() As ToolStripRenderer
        Return New clsMenuRenderer
    End Function
End Class
