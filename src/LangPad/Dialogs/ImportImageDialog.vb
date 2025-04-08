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
            Updating = False

            ' The WinForms RTB control does not handle images, 
            ' especially larger ones, gracefully. Use images
            ' larger than 1080p at your own peril.
            WidthNud.Value = Math.Min(WidthNud.Value, 1920)
            LockAspectCheckBox.Checked = True
            RenderAdjustedImage(True)
        End Set
    End Property

    Private Sub OkDialogButton_Click(sender As Object, e As EventArgs) Handles OkDialogButton.Click
        RenderAdjustedImage()
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub CancelDialogButton_Click(sender As Object, e As EventArgs) Handles CancelDialogButton.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub RenderAdjustedImage(Optional UpdatePreview As Boolean = False)
        If (ImportedImage IsNot Nothing) Then
            ' Force the width And height to update to match
            ' scaling, if needed.
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

            ' Resize image
            AdjustedImage = ResizeImage(ImportedImage, New Size(WidthNud.Value, HeightNud.Value), False)

            ' Update preview image
            If UpdatePreview Then
                ' Adjust display to best preview image
                If AdjustedImage.Width > PreviewPictureBox.Width OrElse AdjustedImage.Height > PreviewPictureBox.Height Then
                    PreviewPictureBox.BackgroundImageLayout = ImageLayout.Zoom
                Else
                    PreviewPictureBox.BackgroundImageLayout = ImageLayout.Center
                End If

                PreviewPictureBox.BackgroundImage = AdjustedImage
            End If
        Else
            PreviewPictureBox.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub WidthNud_ValueChanged(sender As Object, e As EventArgs) Handles WidthNud.ValueChanged
        If Not Updating Then
            If LockAspectCheckBox.Checked Then
                Updating = True
                HeightNud.Value = Math.Min(HeightNud.Maximum, WidthAfterHeightAdjust(ImportedImage.Size, New Size(WidthNud.Value, HeightNud.Value), True))
                Updating = False
            End If
        End If
    End Sub

    Private Sub HeightNud_ValueChanged(sender As Object, e As EventArgs) Handles HeightNud.ValueChanged
        If Not Updating Then
            If LockAspectCheckBox.Checked Then
                Updating = True
                WidthNud.Value = Math.Min(WidthNud.Maximum, HeightAfterWidthAdjust(ImportedImage.Size, New Size(WidthNud.Value, HeightNud.Value), True))
                Updating = False
            End If
        End If
    End Sub

    Private Sub RefreshPreviewButton_Click(sender As Object, e As EventArgs) Handles RefreshPreviewButton.Click
        RenderAdjustedImage(True)
    End Sub

    Private Sub LockAspectCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LockAspectCheckBox.CheckedChanged
        Updating = True
        If ImportedImage IsNot Nothing Then
            WidthNud.Value = HeightAfterWidthAdjust(ImportedImage.Size, New Size(WidthNud.Value, HeightNud.Value), LockAspectCheckBox.Checked)
            HeightNud.Value = WidthAfterHeightAdjust(ImportedImage.Size, New Size(WidthNud.Value, HeightNud.Value), LockAspectCheckBox.Checked)
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
