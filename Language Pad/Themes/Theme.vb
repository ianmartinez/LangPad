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
        MyBase.New("Night")

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

Public Class LunaTheme
    Inherits Theme

    Public Sub New()
        MyBase.New("Luna")

        Color1 = clrLunaHorBG_Color1
        Color2 = clrLunaHorBG_Color2
        PanelBack = Color.FromArgb(255, 221, 236, 255)

        VerticalMenuGradient = False
    End Sub

    Public Overrides Function GetToolStripRenderer() As ToolStripRenderer
        Return New clsLunaToolstripRenderer
    End Function

    Public Overrides Function GetMenuRenderer() As ToolStripRenderer
        Return New clsLunaMenuRenderer
    End Function
End Class

Public Class OliveTheme
    Inherits Theme

    Public Sub New()
        MyBase.New("Olive")

        Color1 = clrOliveHorBG_Color1
        Color2 = clrOliveHorBG_Color2
        PanelBack = Color.FromArgb(255, 241, 240, 228)

        VerticalMenuGradient = False
    End Sub

    Public Overrides Function GetToolStripRenderer() As ToolStripRenderer
        Return New clsOliveToolstripRenderer
    End Function

    Public Overrides Function GetMenuRenderer() As ToolStripRenderer
        Return New clsOliveMenuRenderer
    End Function
End Class

Public Class DesertTheme
    Inherits Theme

    Public Sub New()
        MyBase.New("Desert")

        Color1 = clrDesertHorBG_Color1
        Color2 = clrDesertHorBG_Color2
        PanelBack = clrDesertHorBG_Color1

        VerticalMenuGradient = False
    End Sub

    Public Overrides Function GetToolStripRenderer() As ToolStripRenderer
        Return New clsDesertToolstripRenderer
    End Function

    Public Overrides Function GetMenuRenderer() As ToolStripRenderer
        Return New clsDesertMenuRenderer
    End Function
End Class