Imports System.IO
Imports System.Windows.Forms

Public Class dlgStyle
    Public StyleFont As Font = New Font("Calibri", 11)
    Public StyleAlignment As HorizontalAlignment = HorizontalAlignment.Left
    Public StyleColor As Color = Color.Black
    Public StyleHighlight As Color = Color.White
    Public StyleIndent As Integer = 0
    Public StyleCharOffset As Integer = 0

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
    End Sub

    Private Sub dlgStyle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyStyle()

        btnColor.Color = StyleColor
        btnHighlight.Color = StyleHighlight
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim FileData As String = File.ReadAllText(dlgOpen.FileName)
            StyleFont = Tundra.ZiaFile.FromCompatibleFont2(Tundra.ZiaFile.GetValue(FileData, "Font"))
            StyleColor = Tundra.ZiaFile.FromCompatibleColor(Tundra.ZiaFile.GetValue(FileData, "Color"))
            StyleHighlight = Tundra.ZiaFile.FromCompatibleColor(Tundra.ZiaFile.GetValue(FileData, "Highlight"))
            StyleCharOffset = Tundra.ZiaFile.GetValue(FileData, "CharOffset")
            StyleAlignment = CType([Enum].Parse(GetType(HorizontalAlignment), Tundra.ZiaFile.GetValue(FileData, "Align")), HorizontalAlignment)
            StyleIndent = Tundra.ZiaFile.GetValue(FileData, "Indent")

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

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

    End Sub

    Private Sub btnColor_ColorChanged(sender As Object, e As EventArgs) Handles btnColor.ColorChanged
        StyleColor = btnColor.Color
        ApplyStyle()
    End Sub
    Private Sub btnHighlight_ColorChanged(sender As Object, e As EventArgs) Handles btnHighlight.ColorChanged
        StyleHighlight = btnHighlight.Color
        ApplyStyle()
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        Dim dlgFont As New FontDialog
        dlgFont.AllowSimulations = True
        dlgFont.ShowColor = False
        dlgFont.ShowEffects = True

        dlgFont.Font = StyleFont
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

    Private Sub btnOK_Click(sender As Object, e As EventArgs)

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
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnHighlight_Click(sender As Object, e As EventArgs) Handles btnHighlight.Click

    End Sub
End Class
