﻿Imports System.IO
Imports LangPadUI
Imports LangPadData

Public Class StyleDialog
    Public StyleFont As Font = New Font("Calibri", 11)
    Public StyleAlignment As New HorizontalAlignment
    Public StyleColor As Color = Color.Black
    Public StyleHighlight As Color = Color.White
    Public StyleIndent As Integer = 0
    Public StyleHangingIndent As Integer = 0
    Public StyleCharOffset As Integer = 0
    Public UpdatingColor As Boolean = False

    Private Sub StyleDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyStyle()
        SetIcons()

        ColorButton.Color = StyleColor
        HighlightButton.Color = StyleHighlight
    End Sub

    Private Sub ApplyStyle()
        PreviewRtb.SelectAll()
        PreviewRtb.SelectionFont = StyleFont
        PreviewRtb.SelectionColor = StyleColor
        PreviewRtb.SelectionBackColor = StyleHighlight
        PreviewRtb.SelectionAlignment = StyleAlignment
        PreviewRtb.SelectionIndent = StyleIndent
        PreviewRtb.SelectionHangingIndent = StyleHangingIndent
        PreviewRtb.SelectionCharOffset = StyleCharOffset
        PreviewRtb.DeselectAll()

        IndentNud.Value = StyleIndent
        HangingIndentNud.Value = StyleHangingIndent
        OffsetNud.Value = StyleCharOffset

        If Not UpdatingColor Then
            ColorButton.Color = StyleColor
            HighlightButton.Color = StyleHighlight
        End If
    End Sub

    Public Sub SetIcons()
        Dim Res As IconResolution = GetIconResolution()

        OpenButton.Image = IconManager.Get("document-open", IconSize.Large, Res)
        SaveButton.Image = IconManager.Get("document-save", IconSize.Large, Res)
        DeleteAllButton.Image = IconManager.Get("edit-clear", IconSize.Large, Res)

        LeftButton.Image = IconManager.Get("format-justify-left", IconSize.Small, Res)
        CenterButton.Image = IconManager.Get("format-justify-center", IconSize.Small, Res)
        RightButton.Image = IconManager.Get("format-justify-right", IconSize.Small, Res)
        OffsetButton.Image = IconManager.Get("align-vertical-center", IconSize.Small, Res)
        IndentButton.Image = IconManager.Get("format-indent-more", IconSize.Small, Res)
        HangingIndentButton.Image = IconManager.Get("format-indent-more", IconSize.Small, Res)
        FontButton.Image = IconManager.Get("font", IconSize.Small, Res)
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        If OpenDialog.ShowDialog = DialogResult.OK Then
            Dim FileData As String = File.ReadAllText(OpenDialog.FileName)
            Dim FileResults = KeyValue.Read(FileData)

            StyleFont = FromCompatibleFont(KeyValue.Search(FileResults, "Font"))
            StyleColor = FromCompatibleColor(KeyValue.Search(FileResults, "Color"))
            StyleHighlight = FromCompatibleColor(KeyValue.Search(FileResults, "Highlight"))
            StyleCharOffset = KeyValue.Search(FileResults, "CharOffset")
            StyleAlignment = CType([Enum].Parse(GetType(HorizontalAlignment), KeyValue.Search(FileResults, "Align")), HorizontalAlignment)
            StyleIndent = KeyValue.Search(FileResults, "Indent")
            StyleHangingIndent = KeyValue.Search(FileResults, "HangingIndent")

            ColorButton.Color = StyleColor
            HighlightButton.Color = StyleHighlight

            ApplyStyle()
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If SaveDialog.ShowDialog = DialogResult.OK Then
            Dim FileData As String = ""

            FileData += $"Font={StyleFont.Name }|{StyleFont.Size }|{StyleFont.Style}{Environment.NewLine}"
            FileData += $"Color={ColorTranslator.ToHtml(StyleColor) }" & Environment.NewLine
            FileData += $"Highlight={ColorTranslator.ToHtml(StyleHighlight) }" & Environment.NewLine
            FileData += $"CharOffset={StyleCharOffset }" & Environment.NewLine
            FileData += $"Align={StyleAlignment }" & Environment.NewLine
            FileData += $"Indent={StyleIndent }" & Environment.NewLine
            FileData += $"HangingIndent={StyleHangingIndent }" & Environment.NewLine
            File.WriteAllText(SaveDialog.FileName, FileData)

            ApplyStyle()
        End If

    End Sub

    Private Sub ColorButton_ColorChanged(sender As Object, e As EventArgs) Handles ColorButton.ColorChanged
        UpdatingColor = True
        StyleColor = ColorButton.Color
        ApplyStyle()
        UpdatingColor = False
    End Sub
    Private Sub HighlightButton_ColorChanged(sender As Object, e As EventArgs) Handles HighlightButton.ColorChanged
        UpdatingColor = True
        StyleHighlight = HighlightButton.Color
        ApplyStyle()
        UpdatingColor = False
    End Sub

    Private Sub FontButton_Click(sender As Object, e As EventArgs) Handles FontButton.Click
        Dim FontPicker As New FontDialog With {
            .AllowSimulations = True,
            .ShowColor = False,
            .ShowEffects = True,
            .Font = StyleFont
        }

        If FontPicker.ShowDialog() = DialogResult.OK Then
            StyleFont = FontPicker.Font
        End If

        ApplyStyle()
    End Sub

    Private Sub LeftButton_Click(sender As Object, e As EventArgs) Handles LeftButton.Click
        StyleAlignment = HorizontalAlignment.Left
        ApplyStyle()
    End Sub

    Private Sub CenterButton_Click(sender As Object, e As EventArgs) Handles CenterButton.Click
        StyleAlignment = HorizontalAlignment.Center
        ApplyStyle()
    End Sub

    Private Sub RightButton_Click(sender As Object, e As EventArgs) Handles RightButton.Click
        StyleAlignment = HorizontalAlignment.Right
        ApplyStyle()
    End Sub

    Private Sub IndentButton_Click(sender As Object, e As EventArgs) Handles IndentButton.Click
        StyleIndent = IndentNud.Value
        ApplyStyle()
    End Sub

    Private Sub HangingIndentButton_Click(sender As Object, e As EventArgs) Handles HangingIndentButton.Click
        StyleHangingIndent = HangingIndentNud.Value
        ApplyStyle()
    End Sub

    Private Sub OffsetButton_Click(sender As Object, e As EventArgs) Handles OffsetButton.Click, OffsetButton.Click
        StyleCharOffset = OffsetNud.Value
        ApplyStyle()
    End Sub

    Private Sub DeleteAllButton_Click(sender As Object, e As EventArgs) Handles DeleteAllButton.Click
        StyleFont = New Font("Calibri", 11)
        StyleAlignment = HorizontalAlignment.Left
        StyleColor = Color.Black
        StyleHighlight = Color.White
        StyleIndent = 0
        StyleHangingIndent = 0
        StyleCharOffset = 0

        IndentNud.Value = StyleIndent
        HangingIndentNud.Value = StyleHangingIndent
        OffsetNud.Value = StyleCharOffset
        ApplyStyle()
    End Sub
End Class
