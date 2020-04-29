Imports System.Drawing.Drawing2D

''' <summary>
''' Module handling the resizing of images.
''' </summary>
Module ImageResizer
    ''' <summary>
    ''' Resize an image to a new size, with or without preserving its aspect ratio.
    ''' Does not modify the original image.
    ''' </summary>
    ''' 
    ''' <param name="sourceImage">The image to resize.</param>
    ''' <param name="newSize">The image's new size.</param>
    ''' <param name="preserveAspect">If the aspect ratio of the source image should be preserved.</param>
    ''' 
    ''' <returns>A copy of the source image, resized to the new size.</returns>
    Public Function ResizeImage(ByVal sourceImage As Image, ByVal newSize As Size, Optional ByVal preserveAspect As Boolean = True) As Image
        Dim AdjustedWidth = HeightAfterWidthAdjust(sourceImage.Size, newSize, preserveAspect)
        Dim AdjustedHeight = WidthAfterHeightAdjust(sourceImage.Size, newSize, preserveAspect)

        Dim NewImage As Image = New Bitmap(AdjustedWidth, AdjustedHeight)
        Using ImageGraphics As Graphics = Graphics.FromImage(NewImage)
            ImageGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            ImageGraphics.DrawImage(sourceImage, 0, 0, AdjustedWidth, AdjustedHeight)
        End Using

        Return NewImage
    End Function

    ''' <summary>
    ''' Get the height value of a rectangle after adjusting its width.
    ''' </summary>
    ''' 
    ''' <param name="oldSize">The old size.</param>
    ''' <param name="newSize">The new size.</param>
    ''' <param name="preserveAspect">If the aspect ratio should be preserved</param>
    ''' 
    ''' <returns>The height value of the new rectangle.</returns>
    Public Function HeightAfterWidthAdjust(ByVal oldSize As Size, ByVal newSize As Size, ByVal preserveAspect As Boolean) As Integer
        If preserveAspect Then
            Return CDec(oldSize.Width) * newSize.Height / oldSize.Height
        Else
            Return newSize.Width
        End If
    End Function

    ''' <summary>
    ''' Get the width value of a rectangle after adjusting its height.
    ''' </summary>
    ''' 
    ''' <param name="oldSize">The old size.</param>
    ''' <param name="newSize">The new size.</param>
    ''' <param name="preserveAspect">If the aspect ratio should be preserved</param>
    ''' 
    ''' <returns>The width value of the new rectangle.</returns>
    Public Function WidthAfterHeightAdjust(ByVal oldSize As Size, ByVal newSize As Size, ByVal preserveAspect As Boolean) As Integer
        If preserveAspect Then
            Return CDec(oldSize.Height) * newSize.Width / oldSize.Width
        Else
            Return newSize.Height
        End If
    End Function
End Module
