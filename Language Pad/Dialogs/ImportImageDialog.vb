Public Class ImportImageDialog
    Private ImportedImage As Image
    Private AdjustedImage As Image
    Private Updating As Boolean = False
    Private LastFocused As NumericUpDown

    Public Property SelectedImage As Image
        Get
            Return AdjustedImage
        End Get

        Set(value As Image)
            Updating = True
            ImportedImage = value
            WidthNud.Value = ImportedImage.Width
            HeightNud.Value = ImportedImage.Height
            AdjustPreview()
            Updating = False
        End Set
    End Property

    Private Sub OkDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OkDialogButton.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub CancelDialogButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancelDialogButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub AdjustPreview()
        If (ImportedImage IsNot Nothing) Then
            Dim OldUpdating = Updating

            If LastFocused Is WidthNud Then
                Updating = False
                WidthNud_ValueChanged(Me, Nothing)
            ElseIf LastFocused Is HeightNud Then
                Updating = False
                HeightNud_ValueChanged(Me, Nothing)
            End If
            LastFocused = Nothing

            Updating = OldUpdating

            AdjustedImage = ResizeImage(ImportedImage, New Size(WidthNud.Value, HeightNud.Value), False)

            If AdjustedImage.Width > PreviewPictureBox.Width OrElse AdjustedImage.Height > PreviewPictureBox.Height Then
                PreviewPictureBox.BackgroundImageLayout = ImageLayout.Zoom
            Else
                PreviewPictureBox.BackgroundImageLayout = ImageLayout.Center
            End If

            PreviewPictureBox.BackgroundImage = AdjustedImage
        End If
    End Sub

    Private Sub WidthNud_ValueChanged(sender As Object, e As EventArgs) Handles WidthNud.ValueChanged
        If Not Updating Then
            If LockAspectCheckBox.Checked Then
                Updating = True
                HeightNud.Value = Math.Min(HeightNud.Maximum, AdjustHeight(ImportedImage.Size, New Size(WidthNud.Value, HeightNud.Value), True))
                Updating = False
            End If
        End If
    End Sub

    Private Sub HeightNud_ValueChanged(sender As Object, e As EventArgs) Handles HeightNud.ValueChanged
        If Not Updating Then
            If LockAspectCheckBox.Checked Then
                Updating = True
                WidthNud.Value = Math.Min(WidthNud.Maximum, AdjustWidth(ImportedImage.Size, New Size(WidthNud.Value, HeightNud.Value), True))
                Updating = False
            End If
        End If
    End Sub

    Private Sub RefreshPreviewButton_Click(sender As Object, e As EventArgs) Handles RefreshPreviewButton.Click
        AdjustPreview()
    End Sub

    Private Sub LockAspectCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LockAspectCheckBox.CheckedChanged
        Updating = True
        If ImportedImage IsNot Nothing Then
            WidthNud.Value = AdjustWidth(ImportedImage.Size, New Size(WidthNud.Value, HeightNud.Value), LockAspectCheckBox.Checked)
            HeightNud.Value = AdjustHeight(ImportedImage.Size, New Size(WidthNud.Value, HeightNud.Value), LockAspectCheckBox.Checked)
        End If
        Updating = False
    End Sub

    Private Sub ResetSizeButton_Click(sender As Object, e As EventArgs) Handles ResetSizeButton.Click
        Updating = True
        HeightNud.Value = ImportedImage.Height
        WidthNud.Value = ImportedImage.Width
        Updating = False
    End Sub

    Private Sub WidthNud_Enter(sender As Object, e As EventArgs) Handles WidthNud.Enter
        LastFocused = WidthNud
    End Sub

    Private Sub HeightNud_Enter(sender As Object, e As EventArgs) Handles HeightNud.Enter
        LastFocused = HeightNud
    End Sub
End Class
