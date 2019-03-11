Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization

'Random crap used throughout the software. May or may not be obsolete.
Public Module Common
    Public Function GetAveragePixel(ByVal Source As Bitmap) As Color
        On Error Resume Next
        Dim GraphicsBitmap = New Bitmap(1, 1)
        Using g = Graphics.FromImage(GraphicsBitmap)
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.DrawImage(Source, New Rectangle(0, 0, 1, 1))
        End Using
        Dim AverageColorPixel = GraphicsBitmap.GetPixel(0, 0)
        GraphicsBitmap.Dispose()
        Return AverageColorPixel
    End Function

    Public Function CloneObject(obj As Object) As Object
        Using memStream As New MemoryStream()
            Dim binaryFormatter As New BinaryFormatter(Nothing, New StreamingContext(StreamingContextStates.Clone))
            binaryFormatter.Serialize(memStream, obj)
            memStream.Seek(0, SeekOrigin.Begin)
            Return binaryFormatter.Deserialize(memStream)
        End Using
    End Function

    Public Function GetAverageColor(ByVal Source As Bitmap, Optional ByVal Optimize As Boolean = False) As Color
        On Error Resume Next
        Dim r As Integer = 0
        Dim g As Integer = 0
        Dim b As Integer = 0

        If Optimize = True AndAlso Source.Width > 256 Then
            Source = ResizeImageWidth(Source, 256)
        End If

        Dim total As Integer = 0
        Dim FP As New FastPixel(Source)
        FP.Lock()
        For x As Integer = 0 To Source.Width - 1
            For y As Integer = 0 To Source.Height - 1
                Dim clr As Color = FP.GetPixel(x, y)

                r += clr.R
                g += clr.G
                b += clr.B

                total += 1
            Next
        Next
        FP.Unlock(False)
        r /= total
        g /= total
        b /= total

        Return Color.FromArgb(r, g, b)
    End Function

    Public Function CompareBitmaps(ByVal Image1 As Image, ByVal Image2 As Image, Optional ByVal Optimize As Boolean = False) As Boolean
        If Object.Equals(Image1, Image2) Then
            Return True
        End If
        If Image1 Is Nothing OrElse Image2 Is Nothing Then
            Return False
        End If

        If Optimize = True AndAlso Image1.Width > 256 Then
            Image1 = ResizeImageWidth(Image1, 256)
            Image2 = ResizeImageWidth(Image2, 256)
        End If

        If Not Image1.Size.Equals(Image2.Size) OrElse Not Image1.PixelFormat.Equals(Image2.PixelFormat) Then
            Return False
        End If

        Dim Image1Bitmap As Bitmap = TryCast(Image1, Bitmap)
        Dim Image2Bitmap As Bitmap = TryCast(Image2, Bitmap)
        If Image1Bitmap Is Nothing OrElse Image2Bitmap Is Nothing Then
            Return True
        End If

        Dim bytes As Integer = Image1.Width * Image1.Height * (Image.GetPixelFormatSize(Image1.PixelFormat) / 8)

        Dim result As Boolean = True
        Dim b1bytes As Byte() = New Byte(bytes - 1) {}
        Dim b2bytes As Byte() = New Byte(bytes - 1) {}

        Dim bmd1 As BitmapData = Image1Bitmap.LockBits(New Rectangle(0, 0, Image1Bitmap.Width - 1, Image1Bitmap.Height - 1), ImageLockMode.[ReadOnly], Image1Bitmap.PixelFormat)
        Dim bmd2 As BitmapData = Image2Bitmap.LockBits(New Rectangle(0, 0, Image2Bitmap.Width - 1, Image2Bitmap.Height - 1), ImageLockMode.[ReadOnly], Image2Bitmap.PixelFormat)

        Marshal.Copy(bmd1.Scan0, b1bytes, 0, bytes)
        Marshal.Copy(bmd2.Scan0, b2bytes, 0, bytes)

        For n As Integer = 0 To bytes - 1
            If b1bytes(n) <> b2bytes(n) Then
                result = False
                Exit For
            End If
        Next

        Image1Bitmap.UnlockBits(bmd1)
        Image2Bitmap.UnlockBits(bmd2)

        Return result
    End Function

    Public Function RoundedRectangle(ByVal Area As Rectangle, ByVal Roundness As Integer) As GraphicsPath
        Dim RoundedRectanglePath As New GraphicsPath

        If Area.Width < Roundness * 2 OrElse Area.Height < Roundness * 2 Then
            RoundedRectanglePath.AddEllipse(Area)
            Return RoundedRectanglePath
        End If

        Dim CurvePoints() As PointF = {New PointF(Area.X, Area.Y + Roundness), New PointF(Area.X + Roundness / 3, Area.Y + Roundness / 3), New PointF(Area.X + Roundness, Area.Y)}

        RoundedRectanglePath.AddCurve(CurvePoints, 1)
        RoundedRectanglePath.AddLine(CurvePoints(2), New PointF(Area.Right - Roundness, Area.Y))

        CurvePoints(0) = New PointF(Area.Right - Roundness, Area.Y)
        CurvePoints(1) = New PointF(Area.Right - Roundness / 3, Area.Y + Roundness / 3)
        CurvePoints(2) = New PointF(Area.Right, Area.Y + Roundness)

        RoundedRectanglePath.AddCurve(CurvePoints, 1)
        RoundedRectanglePath.AddLine(CurvePoints(2), New PointF(Area.Right, Area.Bottom - Roundness))

        CurvePoints(0) = New PointF(Area.Right, Area.Bottom - Roundness)
        CurvePoints(1) = New PointF(Area.Right - Roundness / 3, Area.Bottom - Roundness / 3)
        CurvePoints(2) = New PointF(Area.Right - Roundness, Area.Bottom)

        RoundedRectanglePath.AddCurve(CurvePoints, 1)
        RoundedRectanglePath.AddLine(CurvePoints(2), New PointF(Area.X + Roundness, Area.Bottom))

        CurvePoints(0) = New PointF(Area.X + Roundness, Area.Bottom)
        CurvePoints(1) = New PointF(Area.X + Roundness / 3, Area.Bottom - Roundness / 3)
        CurvePoints(2) = New PointF(Area.X, Area.Bottom - Roundness)

        RoundedRectanglePath.AddCurve(CurvePoints, 1)
        RoundedRectanglePath.AddLine(CurvePoints(2), New PointF(Area.X, Area.Y + Roundness))

        Return RoundedRectanglePath
    End Function

    Public Function ResizeImage(ByVal SourceImage As Image, ByVal Width As Integer, ByVal Height As Integer) As Bitmap
        Dim ImageThumb As New Bitmap(Width, Height)
        Dim ImageGraphics As Graphics = Graphics.FromImage(ImageThumb)
        ImageGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        ImageGraphics.DrawImage(SourceImage, New Rectangle(0, 0, ImageThumb.Width, ImageThumb.Height), New Rectangle(0, 0, SourceImage.Width, SourceImage.Height), GraphicsUnit.Pixel)
        ResizeImage = ImageThumb
    End Function

    Public Function ResizeImageWidth(ByVal SourceImage As Image, ByVal Width As Integer) As Bitmap
        Dim Height As Integer = (SourceImage.Width / Width) * SourceImage.Height
        Return ResizeImage(SourceImage, Width, Height)
    End Function
End Module
