Module clsOliveColors
    Public clrOliveHorBG_GrayBlue As Color = Color.FromArgb(255, 233, 236, 250)
    Public clrOliveHorBG_White As Color = Color.FromArgb(255, 244, 247, 252)
    Public clrOliveSubmenuBG As Color = Color.FromArgb(255, 246, 246, 246)
    Public clrOliveImageMarginBlue As Color = Color.FromArgb(255, 217, 217, 168)
    Public clrOliveImageMarginWhite As Color = Color.FromArgb(255, 255, 255, 255)
    Public clrOliveImageMarginLine As Color = Color.FromArgb(255, 96, 128, 89)
    Public clrOliveSelectedBG_Blue As Color = Color.FromArgb(255, 186, 228, 246)
    Public clrOliveSelectedBG_Header_Blue As Color = Color.FromArgb(255, 146, 202, 230)
    Public clrOliveSelectedBG_White As Color = Color.FromArgb(255, 241, 248, 251)
    Public clrOliveSelectedBG_Border As Color = Color.FromArgb(255, 150, 217, 249)
    Public clrOliveSelectedBG_Drop_Blue As Color = Color.FromArgb(255, 139, 195, 225)
    Public clrOliveSelectedBG_Drop_Border As Color = Color.FromArgb(255, 48, 127, 177)
    Public clrOliveMenuBorder As Color = Color.FromArgb(255, 160, 160, 160)
    Public clrOliveCheckBG As Color = Color.FromArgb(255, 206, 237, 250)

    Public clrOliveVerBG_GrayBlue As Color = Color.FromArgb(255, 196, 203, 219)
    Public clrOliveVerBG_White As Color = Color.FromArgb(255, 250, 250, 253)
    Public clrOliveVerBG_Shadow As Color = Color.FromArgb(255, 96, 128, 89)

    Public clrOliveToolstripBtnGrad_Blue As Color = Color.FromArgb(255, 129, 192, 224)
    Public clrOliveToolstripBtnGrad_White As Color = Color.FromArgb(255, 237, 248, 253)
    Public clrOliveToolstripBtn_Border As Color = Color.FromArgb(255, 124, 133, 150)
    Public clrOliveToolstripBtnGrad_Blue_Pressed As Color = Color.FromArgb(255, 124, 177, 204)
    Public clrOliveToolstripBtnGrad_White_Pressed As Color = Color.FromArgb(255, 228, 245, 252)

    Public clrOliveHorBG_Color1 As Color = Color.FromArgb(255, 217, 217, 168)
    Public clrOliveHorBG_Color2 As Color = Color.FromArgb(255, 242, 240, 228)

    Public clrOliveImageMarginBG_Color1 As Color = Color.FromArgb(255, 191, 204, 154)
    Public clrOliveImageMarginBG_Color2 As Color = Color.FromArgb(255, 244, 247, 222)

    Public clOlive_Selected1 As Color = Color.FromArgb(255, 245, 227, 194)
    Public clOlive_Selected2 As Color = Color.FromArgb(255, 237, 194, 118)
    Public clOlive_SelectedBorder As Color = Color.FromArgb(255, 205, 149, 63)
    Public clOlive_SelectedShadow As Color = Color.FromArgb(255, 238, 230, 215)

    Public clOlive_Drop1 As Color = Color.FromArgb(255, 255, 243, 188)
    Public clOlive_Drop2 As Color = Color.FromArgb(255, 255, 218, 134)
    Public clOlive_DropBorder As Color = Color.FromArgb(255, 205, 149, 63)
    Public clOlive_DropShadow As Color = Color.FromArgb(255, 238, 230, 215)


    Public clrOliveSep As Color = Color.FromArgb(255, 96, 128, 89)
    Public clrOliveSepWhite As Color = Color.FromArgb(255, 255, 255, 255)

    Public Sub DrawRoundedRectangle(ByVal objGraphics As Graphics,
                                ByVal m_intxAxis As Integer,
                                ByVal m_intyAxis As Integer,
                                ByVal m_intWidth As Integer,
                                ByVal m_intHeight As Integer,
                                ByVal m_diameter As Integer, ByVal color As Color)

        Dim pen As New Pen(color)

        'Dim g As Graphics
        Dim BaseRect As New RectangleF(m_intxAxis, m_intyAxis, m_intWidth, m_intHeight)
        Dim ArcRect As New RectangleF(BaseRect.Location, New SizeF(m_diameter, m_diameter))
        'top left Arc
        objGraphics.DrawArc(pen, ArcRect, 180, 90)
        objGraphics.DrawLine(pen, m_intxAxis + CInt(m_diameter / 2), m_intyAxis, m_intxAxis + m_intWidth - CInt(m_diameter / 2), m_intyAxis)

        ' top right arc
        ArcRect.X = BaseRect.Right - m_diameter
        objGraphics.DrawArc(pen, ArcRect, 270, 90)
        objGraphics.DrawLine(pen, m_intxAxis + m_intWidth, m_intyAxis + CInt(m_diameter / 2), m_intxAxis + m_intWidth, m_intyAxis + m_intHeight - CInt(m_diameter / 2))

        ' bottom right arc
        ArcRect.Y = BaseRect.Bottom - m_diameter
        objGraphics.DrawArc(pen, ArcRect, 0, 90)
        objGraphics.DrawLine(pen, m_intxAxis + CInt(m_diameter / 2), m_intyAxis + m_intHeight, m_intxAxis + m_intWidth - CInt(m_diameter / 2), m_intyAxis + m_intHeight)

        ' bottom left arc
        ArcRect.X = BaseRect.Left
        objGraphics.DrawArc(pen, ArcRect, 90, 90)
        objGraphics.DrawLine(pen, m_intxAxis, m_intyAxis + CInt(m_diameter / 2), m_intxAxis, m_intyAxis + m_intHeight - CInt(m_diameter / 2))

    End Sub
End Module

Public Class clsOliveMenuRenderer
    Inherits System.Windows.Forms.ToolStripRenderer
    '// Make sure the textcolor is black
    Protected Overrides Sub InitializeItem(ByVal item As System.Windows.Forms.ToolStripItem)
        MyBase.InitializeItem(item)
        item.ForeColor = Color.Black
    End Sub

    Protected Overrides Sub Initialize(ByVal toolStrip As System.Windows.Forms.ToolStrip)
        MyBase.Initialize(toolStrip)
        toolStrip.ForeColor = Color.Black
    End Sub

    '// Render horizontal bakcground gradient
    Protected Overrides Sub OnRenderToolStripBackground(ByVal e As ToolStripRenderEventArgs)
        MyBase.OnRenderToolStripBackground(e)

        Dim b As New Drawing2D.LinearGradientBrush(e.AffectedBounds, clrOliveHorBG_Color1, clrOliveHorBG_Color2,
            Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(b, e.AffectedBounds)
    End Sub

    '// Render Image Margin and gray itembackground
    Protected Overrides Sub OnRenderImageMargin(ByVal e As System.Windows.Forms.ToolStripRenderEventArgs)
        MyBase.OnRenderImageMargin(e)

        '// Draw ImageMargin background gradient
        Dim b As New Drawing2D.LinearGradientBrush(e.AffectedBounds, clrOliveImageMarginBG_Color2, clrOliveImageMarginBG_Color1,
            Drawing2D.LinearGradientMode.Horizontal)

        '// Shadow at the right of image margin
        Dim DarkLine As New Drawing.SolidBrush(clrOliveImageMarginLine)
        Dim WhiteLine As New Drawing.SolidBrush(Color.White)
        Dim rect As New Rectangle(e.AffectedBounds.Width, 2, 1, e.AffectedBounds.Height)
        Dim rect2 As New Rectangle(e.AffectedBounds.Width + 1, 2, 1, e.AffectedBounds.Height)

        '// Gray background
        Dim SubmenuBGbrush As New Drawing.SolidBrush(clrOliveSubmenuBG)
        Dim rect3 As New Rectangle(0, 0, e.ToolStrip.Width, e.ToolStrip.Height)

        '// Border
        Dim borderPen As New Pen(clrOliveMenuBorder)
        Dim rect4 As New Rectangle(0, 1, e.ToolStrip.Width - 1, e.ToolStrip.Height - 2)

        e.Graphics.FillRectangle(SubmenuBGbrush, rect3)
        e.Graphics.FillRectangle(b, e.AffectedBounds)
        e.Graphics.FillRectangle(DarkLine, rect)
        e.Graphics.FillRectangle(WhiteLine, rect2)
        e.Graphics.DrawRectangle(borderPen, rect4)
    End Sub

    '// Render Checkmark 
    Protected Overrides Sub OnRenderItemCheck(ByVal e As ToolStripItemImageRenderEventArgs)
        MyBase.OnRenderItemCheck(e)
        If e.Item.Selected Then
            Dim rect As New Rectangle(3, 1, 20, 20)
            Dim rect2 As New Rectangle(4, 2, 18, 18)
            Dim b As New Drawing.SolidBrush(clrOliveToolstripBtn_Border)
            Dim b2 As New Drawing.SolidBrush(clrOliveCheckBG)

            e.Graphics.FillRectangle(b, rect)
            e.Graphics.FillRectangle(b2, rect2)
            e.Graphics.DrawImage(e.Image, New Point(5, 3))
        Else
            Dim rect As New Rectangle(3, 1, 20, 20)
            Dim rect2 As New Rectangle(4, 2, 18, 18)
            Dim b As New Drawing.SolidBrush(clrOliveSelectedBG_Drop_Border)
            Dim b2 As New Drawing.SolidBrush(clrOliveCheckBG)

            e.Graphics.FillRectangle(b, rect)
            e.Graphics.FillRectangle(b2, rect2)
            e.Graphics.DrawImage(e.Image, New Point(5, 3))
        End If
    End Sub

    '// Render separator
    Protected Overrides Sub OnRenderSeparator(ByVal e As System.Windows.Forms.ToolStripSeparatorRenderEventArgs)
        MyBase.OnRenderSeparator(e)

        Dim DarkLine As New Drawing.SolidBrush(clrOliveImageMarginLine)
        Dim WhiteLine As New Drawing.SolidBrush(Color.White)
        Dim rect As New Rectangle(32, 3, e.Item.Width - 32, 1)
        Dim rect2 As New Rectangle(32, 4, e.Item.Width - 32, 1)
        e.Graphics.FillRectangle(DarkLine, rect)
        e.Graphics.FillRectangle(WhiteLine, rect2)
    End Sub

    '// Render arrow
    Protected Overrides Sub OnRenderArrow(ByVal e As System.Windows.Forms.ToolStripArrowRenderEventArgs)
        e.ArrowColor = Color.Black
        MyBase.OnRenderArrow(e)
    End Sub

    '// Render Menuitem background: lightblue if selected, darkblue if dropped down
    Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
        MyBase.OnRenderMenuItemBackground(e)

        If e.Item.Enabled Then
            If e.Item.IsOnDropDown = False AndAlso e.Item.Selected Then
                '// If item is MenuHeader and selected: draw darkblue border

                Dim rect As New Rectangle(3, 2, e.Item.Width - 6, e.Item.Height - 4)
                Dim b As New Drawing2D.LinearGradientBrush(rect, clOlive_Selected1, clOlive_Selected2, Drawing2D.LinearGradientMode.Vertical)
                Dim b2 As New Drawing.SolidBrush(clrOliveToolstripBtn_Border)

                e.Graphics.FillRectangle(b, rect)
                clsColors.DrawRoundedRectangle(e.Graphics, rect.Left - 1, rect.Top - 1, rect.Width, rect.Height + 1, 4, clrOliveToolstripBtn_Border)
                clsColors.DrawRoundedRectangle(e.Graphics, rect.Left - 2, rect.Top - 2, rect.Width + 2, rect.Height + 3, 4, clOlive_SelectedShadow)
                e.Item.ForeColor = Color.Black

            ElseIf e.Item.IsOnDropDown AndAlso e.Item.Selected Then
                '// If item is NOT menuheader (but subitem) and selected: draw lightblue border

                Dim rect As New Rectangle(4, 2, e.Item.Width - 6, e.Item.Height - 4)
                Dim b As New Drawing2D.LinearGradientBrush(rect, clOlive_Selected1, clOlive_Selected2, Drawing2D.LinearGradientMode.Vertical)
                Dim b2 As New Drawing.SolidBrush(clrOliveToolstripBtn_Border)

                e.Graphics.FillRectangle(b, rect)
                clsColors.DrawRoundedRectangle(e.Graphics, rect.Left - 1, rect.Top - 1, rect.Width, rect.Height + 1, 6, clrOliveToolstripBtn_Border)
                e.Item.ForeColor = Color.Black

            End If

            '// If item is MenuHeader and menu is dropped down: selection rectangle is now darker
            If CType(e.Item, ToolStripMenuItem).DropDown.Visible AndAlso e.Item.IsOnDropDown = False Then 'CType(e.Item, ToolStripMenuItem).OwnerItem Is Nothing Then
                Dim rect As New Rectangle(3, 2, e.Item.Width - 6, e.Item.Height - 4)
                Dim b As New Drawing2D.LinearGradientBrush(rect, clOlive_Drop1, clOlive_Drop2, Drawing2D.LinearGradientMode.Vertical)
                Dim b2 As New Drawing.SolidBrush(clrOliveSelectedBG_Drop_Border)

                e.Graphics.FillRectangle(b, rect)
                clsColors.DrawRoundedRectangle(e.Graphics, rect.Left - 1, rect.Top - 1, rect.Width, rect.Height + 1, 4, clrOliveSelectedBG_Drop_Border)
                clsColors.DrawRoundedRectangle(e.Graphics, rect.Left - 2, rect.Top - 2, rect.Width + 2, rect.Height + 3, 4, clOlive_DropShadow)
                e.Item.ForeColor = Color.Black
            End If
        End If
    End Sub

End Class

Public Class clsOliveToolstripRenderer
    Inherits ToolStripProfessionalRenderer

    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        'MyBase.OnRenderToolStripBorder(e)

        Dim shadow As New Pen(Color.FromArgb(90, 255, 255, 255))
        Dim rect As New Rectangle(e.AffectedBounds.X, e.AffectedBounds.Y, e.AffectedBounds.Width - 1, e.AffectedBounds.Height)
        e.Graphics.DrawRectangle(shadow, rect)
    End Sub

    '// Render separator
    Protected Overrides Sub OnRenderSeparator(ByVal e As ToolStripSeparatorRenderEventArgs)
        MyBase.OnRenderSeparator(e)

        If e.ToolStrip.Orientation = Orientation.Vertical Then
            Dim rect As New Rectangle(2, 3, e.Item.Width - 4, 1)
            Dim rect2 As New Rectangle(3, 4, e.Item.Width - 5, 1)
            e.Graphics.FillRectangle(New SolidBrush(clrOliveSep), rect)
            e.Graphics.FillRectangle(New SolidBrush(clrOliveSepWhite), rect2)
        Else
            Dim rect As New Rectangle(3, 5, 1, e.Item.Height - 10)
            Dim rect2 As New Rectangle(4, 6, 1, e.Item.Height - 10)
            e.Graphics.FillRectangle(New SolidBrush(clrOliveSep), rect)
            e.Graphics.FillRectangle(New SolidBrush(clrOliveSepWhite), rect2)
        End If
    End Sub


    '// Render container background gradient
    Protected Overrides Sub OnRenderToolStripBackground(ByVal e As ToolStripRenderEventArgs)
        MyBase.OnRenderToolStripBackground(e)

        Dim b As New Drawing2D.LinearGradientBrush(e.AffectedBounds, Color.FromArgb(255, 244, 247, 222), Color.FromArgb(255, 191, 204, 154),
            Drawing2D.LinearGradientMode.Vertical)
        Dim shadow As New SolidBrush(clrOliveVerBG_Shadow)
        Dim rect As New Rectangle(0, e.ToolStrip.Height - 2, e.ToolStrip.Width, 1)
        e.Graphics.FillRectangle(b, e.AffectedBounds)
        e.Graphics.FillRectangle(shadow, rect)
    End Sub

    '// Render button selected and pressed state
    Protected Overrides Sub OnRenderButtonBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
        MyBase.OnRenderButtonBackground(e)
        If e.Item.Selected Or CType(e.Item, ToolStripButton).Checked Then
            Dim rectBorder As New Rectangle(0, 0, e.Item.Width - 0, e.Item.Height - 0)
            Dim rect As New Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2)
            Dim b As New Drawing2D.LinearGradientBrush(rect, clOlive_Selected1, clOlive_Selected2, Drawing2D.LinearGradientMode.Vertical)
            Dim b2 As New SolidBrush(Color.FromArgb(255, 205, 149, 63))

            e.Graphics.FillRectangle(b2, rectBorder)
            e.Graphics.FillRectangle(b, rect)
        End If
        If e.Item.Pressed Then
            Dim rectBorder As New Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1)
            Dim rect As New Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2)
            Dim b As New Drawing2D.LinearGradientBrush(rect, clOlive_Drop1, clOlive_Drop2, Drawing2D.LinearGradientMode.Vertical)
            Dim b2 As New Drawing.SolidBrush(clOlive_DropBorder)

            e.Graphics.FillRectangle(b2, rectBorder)
            e.Graphics.FillRectangle(b, rect)
        End If
    End Sub
End Class