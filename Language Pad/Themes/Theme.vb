Public Class Theme
    Public Name As String
    Public Color1 As Color = Color.Gray
    Public Color2 As Color = Color.Gray
    Public PanelBack As Color = Color.WhiteSmoke
    Public PanelText As Color = Color.Black

    Public VerticalMenuGradient As Boolean = False

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

Public Class IceTheme
    Inherits Theme

    Public Sub New()
        MyBase.New("Ice")

        Color1 = clrHorBG_Color1
        Color2 = clrHorBG_Color2
    End Sub

    Public Overrides Function GetToolStripRenderer() As ToolStripRenderer
        Return New clsToolstripRenderer
    End Function

    Public Overrides Function GetMenuRenderer() As ToolStripRenderer
        Return New clsMenuRenderer
    End Function
End Class

Public Class NightTheme
    Inherits Theme

    Public Sub New()
        MyBase.New("Aero")

        Color1 = clrNightHorBG_Color1
        Color2 = clrNightHorBG_Color2
        PanelBack = clrNightHorBG_Color2

        VerticalMenuGradient = False
    End Sub

    Public Overrides Function GetToolStripRenderer() As ToolStripRenderer
        Return New clsNightToolstripRenderer
    End Function

    Public Overrides Function GetMenuRenderer() As ToolStripRenderer
        Return New clsNightMenuRenderer
    End Function
End Class