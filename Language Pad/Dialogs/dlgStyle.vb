Imports System.IO
Imports TundraLib
Imports TundraLib.ZiaFile

Public Class dlgStyle
    Public StyleFont As Font = New Font("Calibri", 11)
    Public StyleAlignment As New HorizontalAlignment
    Public StyleColor As Color = Color.Black
    Public StyleHighlight As Color = Color.White
    Public StyleIndent As Integer = 0
    Public StyleCharOffset As Integer = 0
    Public UpdatingColor As Boolean = False

    Private Sub ApplyStyle()
        rtbPreview.SelectAll()
        rtbPreview.SelectionFont = StyleFont
        rtbPreview.SelectionColor = StyleColor
        rtbPreview.SelectionBackColor = StyleHighlight
        rtbPreview.SelectionAlignment = StyleAlignment
        rtbPreview.SelectionIndent = StyleIndent
        rtbPreview.SelectionCharOffset = StyleCharOffset
        rtbPreview.DeselectAll()

        nudIndent.Value = StyleIndent
        nudOffset.Value = StyleCharOffset
        If Not UpdatingColor Then
            btnColor.Color = StyleColor
            btnHighlight.Color = StyleHighlight
        End If
    End Sub

    Public Sub SetIcons()
        Dim res As IconResolution = GetIconResolution()

        btnOpen.Image = IconManager.Get("document-open", IconSize.Large, res)
        btnSave.Image = IconManager.Get("document-save", IconSize.Large, res)
        btnDeleteAll.Image = IconManager.Get("edit-clear", IconSize.Large, res)

        btnLeft.Image = IconManager.Get("format-justify-left", IconSize.Small, res)
        btnCenter.Image = IconManager.Get("format-justify-center", IconSize.Small, res)
        btnRight.Image = IconManager.Get("format-justify-right", IconSize.Small, res)
        btnOffset.Image = IconManager.Get("align-vertical-center", IconSize.Small, res)
        btnIndent.Image = IconManager.Get("format-indent-more", IconSize.Small, res)
        btnFont.Image = IconManager.Get("font", IconSize.Small, res)
    End Sub

    Private Sub dlgStyle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyStyle()
        SetIcons()

        btnColor.Color = StyleColor
        btnHighlight.Color = StyleHighlight
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim FileData As String = File.ReadAllText(dlgOpen.FileName)
            StyleFont = FromCompatibleFont(GetValue(FileData, "Font"))
            StyleColor = FromCompatibleColor(GetValue(FileData, "Color"))
            StyleHighlight = FromCompatibleColor(GetValue(FileData, "Highlight"))
            StyleCharOffset = GetValue(FileData, "CharOffset")
            StyleAlignment = CType([Enum].Parse(GetType(HorizontalAlignment), GetValue(FileData, "Align")), HorizontalAlignment)
            StyleIndent = GetValue(FileData, "Indent")

            btnColor.Color = StyleColor
            btnHighlight.Color = StyleHighlight

            ApplyStyle()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim FileData As String = ""
            FileData += String.Format("Font={0}|{1}|{2}", StyleFont.Name, StyleFont.Size, StyleFont.Style.ToString) & Environment.NewLine
            FileData += String.Format("Color={0}", ColorTranslator.ToHtml(StyleColor)) & Environment.NewLine
            FileData += String.Format("Highlight={0}", ColorTranslator.ToHtml(StyleHighlight)) & Environment.NewLine
            FileData += String.Format("CharOffset={0}", StyleCharOffset) & Environment.NewLine
            FileData += String.Format("Align={0}", StyleAlignment) & Environment.NewLine
            FileData += String.Format("Indent={0}", StyleIndent) & Environment.NewLine

            File.WriteAllText(dlgSave.FileName, FileData)

            ApplyStyle()
        End If

    End Sub

    Private Sub btnColor_ColorChanged(sender As Object, e As EventArgs) Handles btnColor.ColorChanged
        UpdatingColor = True
        StyleColor = btnColor.Color
        ApplyStyle()
        UpdatingColor = False
    End Sub
    Private Sub btnHighlight_ColorChanged(sender As Object, e As EventArgs) Handles btnHighlight.ColorChanged
        UpdatingColor = True
        StyleHighlight = btnHighlight.Color
        ApplyStyle()
        UpdatingColor = False
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        Dim dlgFont As New FontDialog With {
            .AllowSimulations = True,
            .ShowColor = False,
            .ShowEffects = True,
            .Font = StyleFont
        }
        If dlgFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            StyleFont = dlgFont.Font
        End If

        ApplyStyle()
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        StyleAlignment = HorizontalAlignment.Left
        ApplyStyle()
    End Sub

    Private Sub btnCenter_Click(sender As Object, e As EventArgs) Handles btnCenter.Click
        StyleAlignment = HorizontalAlignment.Center
        ApplyStyle()
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        StyleAlignment = HorizontalAlignment.Right
        ApplyStyle()
    End Sub

    Private Sub btnIndent_Click(sender As Object, e As EventArgs) Handles btnIndent.Click
        StyleIndent = nudIndent.Value
        ApplyStyle()
    End Sub

    Private Sub btnOffset_Click(sender As Object, e As EventArgs) Handles btnOffset.Click, btnOffset.Click
        StyleCharOffset = nudOffset.Value
        ApplyStyle()
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        StyleFont = New Font("Calibri", 11)
        StyleAlignment = HorizontalAlignment.Left
        StyleColor = Color.Black
        StyleHighlight = Color.White
        StyleIndent = 0
        StyleCharOffset = 0

        nudIndent.Value = StyleIndent
        nudOffset.Value = StyleCharOffset
        ApplyStyle()
    End Sub
End Class
