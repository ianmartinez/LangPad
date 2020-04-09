Public Class ImportImageDialog
    Private ImportedImage As Image
    Private AdjustedImage As Image
    Private Loading As Boolean = False

    Public Property SelectedImage As Image
        Get
            Return AdjustedImage
        End Get

        Set(value As Image)
            Loading = True
            ImportedImage = value
            WidthNud.Value = ImportedImage.Width
            HeightNud.Value = ImportedImage.Height
            AdjustPreview()
            Loading = False
        End Set
    End Property

    Private Sub ImportImageDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
            AdjustedImage = ResizeImage(ImportedImage, New Size(WidthNud.Value, HeightNud.Value), False)
            PreviewPictureBox.BackgroundImage = AdjustedImage
        End If
    End Sub

    Private Sub WidthNud_ValueChanged(sender As Object, e As EventArgs) Handles WidthNud.ValueChanged
        If Not Loading Then
            If LockAspectCheckBox.Checked Then
                Dim AdjustedSize = GetAdjustedSize(ImportedImage.Size, New Size(WidthNud.Value, HeightNud.Value), True)
                HeightNud.Value = AdjustedSize.Height
            End If
        End If
    End Sub

    Private Sub HeightNud_ValueChanged(sender As Object, e As EventArgs) Handles HeightNud.ValueChanged
        If Not Loading Then
            If LockAspectCheckBox.Checked Then
                Dim AdjustedSize = GetAdjustedSize(ImportedImage.Size, New Size(WidthNud.Value, HeightNud.Value), True)
                WidthNud.Value = AdjustedSize.Width
            End If
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        AdjustPreview()
    End Sub
End Class
