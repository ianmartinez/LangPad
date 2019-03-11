Imports System.Drawing

Public Class FastPixel
    Private rgbValues() As Byte
    Private bmpData As Imaging.BitmapData
    Private bmpPtr As IntPtr
    Private locked As Boolean = False

    Private _isAlpha As Boolean = False
    Private _bitmap As Bitmap
    Private _width As Integer
    Private _height As Integer
    Public ReadOnly Property Width() As Integer
        Get
            Return _width
        End Get
    End Property
    Public ReadOnly Property Height() As Integer
        Get
            Return _height
        End Get
    End Property
    Public ReadOnly Property IsAlphaBitmap() As Boolean
        Get
            Return _isAlpha
        End Get
    End Property
    Public ReadOnly Property Bitmap() As Bitmap
        Get
            Return _bitmap
        End Get
    End Property

    Public Sub New(ByVal bitmap As Bitmap)
        If (bitmap.PixelFormat = (bitmap.PixelFormat Or Imaging.PixelFormat.Indexed)) Then
            Throw New Exception("Cannot lock an Indexed image.")
            Return
        End If
        _bitmap = bitmap
        _isAlpha = (bitmap.PixelFormat = (bitmap.PixelFormat Or Imaging.PixelFormat.Alpha))
        _width = bitmap.Width
        _height = bitmap.Height
    End Sub

    Public Sub Lock()
        If locked Then
            Throw New Exception("Bitmap already locked.")
            Return
        End If

        Dim rect As New Rectangle(0, 0, Width, Height)
        bmpData = Bitmap.LockBits(rect, Imaging.ImageLockMode.ReadWrite, Bitmap.PixelFormat)
        bmpPtr = bmpData.Scan0

        If IsAlphaBitmap Then
            Dim bytes As Integer = (Width * Height) * 4
            ReDim rgbValues(bytes - 1)
            System.Runtime.InteropServices.Marshal.Copy(bmpPtr, rgbValues, 0, rgbValues.Length)
        Else
            Dim bytes As Integer = (Width * Height) * 3
            ReDim rgbValues(bytes - 1)
            Runtime.InteropServices.Marshal.Copy(bmpPtr, rgbValues, 0, rgbValues.Length)
        End If

        locked = True
    End Sub
    Public Sub Unlock(ByVal setPixels As Boolean)
        If Not locked Then
            Throw New Exception("Bitmap not locked.")
            Return
        End If
        ' Copy the RGB values back to the bitmap
        If setPixels Then System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, bmpPtr, rgbValues.Length)
        ' Unlock the bits.
        Bitmap.UnlockBits(bmpData)
        locked = False
    End Sub

    Public Sub Clear(ByVal colour As Color)
        If Not locked Then
            Throw New Exception("Bitmap not locked.")
            Return
        End If

        If IsAlphaBitmap Then
            For index As Integer = 0 To rgbValues.Length - 1 Step 4
                rgbValues(index) = colour.B
                rgbValues(index + 1) = colour.G
                rgbValues(index + 2) = colour.R
                rgbValues(index + 3) = colour.A
            Next index
        Else
            For index As Integer = 0 To rgbValues.Length - 1 Step 3
                rgbValues(index) = colour.B
                rgbValues(index + 1) = colour.G
                rgbValues(index + 2) = colour.R
            Next index
        End If
    End Sub

    Public Sub SetPixel(ByVal location As Point, ByVal colour As Color)
        SetPixel(location.X, location.Y, colour)
    End Sub

    Public Sub SetPixel(ByVal x As Integer, ByVal y As Integer, ByVal colour As Color)
        If Not locked Then
            Throw New Exception("Bitmap not locked.")
            Return
        End If

        If IsAlphaBitmap Then
            Dim index As Integer = ((y * Width + x) * 4)
            rgbValues(index) = colour.B
            rgbValues(index + 1) = colour.G
            rgbValues(index + 2) = colour.R
            rgbValues(index + 3) = colour.A
        Else
            Dim index As Integer = ((y * Width + x) * 3)
            rgbValues(index) = colour.B
            rgbValues(index + 1) = colour.G
            rgbValues(index + 2) = colour.R
        End If
    End Sub
    Public Function GetPixel(ByVal location As Point) As Color
        Return GetPixel(location.X, location.Y)
    End Function
    Public Function GetPixel(ByVal x As Integer, ByVal y As Integer) As Color
        If Not locked Then
            Throw New Exception("Bitmap not locked.")
            Return Nothing
        End If

        If IsAlphaBitmap Then
            Dim index As Integer = ((y * Width + x) * 4)
            Dim b As Integer = rgbValues(index)
            Dim g As Integer = rgbValues(index + 1)
            Dim r As Integer = rgbValues(index + 2)
            Dim a As Integer = rgbValues(index + 3)
            Return Color.FromArgb(a, r, g, b)
        Else
            Dim index As Integer = ((y * Width + x) * 3)
            Dim b As Integer = rgbValues(index)
            Dim g As Integer = rgbValues(index + 1)
            Dim r As Integer = rgbValues(index + 2)
            Return Color.FromArgb(r, g, b)
        End If
    End Function
End Class