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
            Return Me._width
        End Get
    End Property
    Public ReadOnly Property Height() As Integer
        Get
            Return Me._height
        End Get
    End Property
    Public ReadOnly Property IsAlphaBitmap() As Boolean
        Get
            Return Me._isAlpha
        End Get
    End Property
    Public ReadOnly Property Bitmap() As Bitmap
        Get
            Return Me._bitmap
        End Get
    End Property

    Public Sub New(ByVal bitmap As Bitmap)
        If (bitmap.PixelFormat = (bitmap.PixelFormat Or Imaging.PixelFormat.Indexed)) Then
            Throw New Exception("Cannot lock an Indexed image.")
            Return
        End If
        Me._bitmap = bitmap
        Me._isAlpha = (Me.Bitmap.PixelFormat = (Me.Bitmap.PixelFormat Or Imaging.PixelFormat.Alpha))
        Me._width = bitmap.Width
        Me._height = bitmap.Height
    End Sub

    Public Sub Lock()
        If Me.locked Then
            Throw New Exception("Bitmap already locked.")
            Return
        End If

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Me.bmpData = Me.Bitmap.LockBits(rect, Drawing.Imaging.ImageLockMode.ReadWrite, Me.Bitmap.PixelFormat)
        Me.bmpPtr = Me.bmpData.Scan0

        If Me.IsAlphaBitmap Then
            Dim bytes As Integer = (Me.Width * Me.Height) * 4
            ReDim Me.rgbValues(bytes - 1)
            System.Runtime.InteropServices.Marshal.Copy(Me.bmpPtr, rgbValues, 0, Me.rgbValues.Length)
        Else
            Dim bytes As Integer = (Me.Width * Me.Height) * 3
            ReDim Me.rgbValues(bytes - 1)
            System.Runtime.InteropServices.Marshal.Copy(Me.bmpPtr, rgbValues, 0, Me.rgbValues.Length)
        End If

        Me.locked = True
    End Sub
    Public Sub Unlock(ByVal setPixels As Boolean)
        If Not Me.locked Then
            Throw New Exception("Bitmap not locked.")
            Return
        End If
        ' Copy the RGB values back to the bitmap
        If setPixels Then System.Runtime.InteropServices.Marshal.Copy(Me.rgbValues, 0, Me.bmpPtr, Me.rgbValues.Length)
        ' Unlock the bits.
        Me.Bitmap.UnlockBits(bmpData)
        Me.locked = False
    End Sub

    Public Sub Clear(ByVal colour As Color)
        If Not Me.locked Then
            Throw New Exception("Bitmap not locked.")
            Return
        End If

        If Me.IsAlphaBitmap Then
            For index As Integer = 0 To Me.rgbValues.Length - 1 Step 4
                Me.rgbValues(index) = colour.B
                Me.rgbValues(index + 1) = colour.G
                Me.rgbValues(index + 2) = colour.R
                Me.rgbValues(index + 3) = colour.A
            Next index
        Else
            For index As Integer = 0 To Me.rgbValues.Length - 1 Step 3
                Me.rgbValues(index) = colour.B
                Me.rgbValues(index + 1) = colour.G
                Me.rgbValues(index + 2) = colour.R
            Next index
        End If
    End Sub
    Public Sub SetPixel(ByVal location As Point, ByVal colour As Color)
        Me.SetPixel(location.X, location.Y, colour)
    End Sub
    Public Sub SetPixel(ByVal x As Integer, ByVal y As Integer, ByVal colour As Color)
        If Not Me.locked Then
            Throw New Exception("Bitmap not locked.")
            Return
        End If

        If Me.IsAlphaBitmap Then
            Dim index As Integer = ((y * Me.Width + x) * 4)
            Me.rgbValues(index) = colour.B
            Me.rgbValues(index + 1) = colour.G
            Me.rgbValues(index + 2) = colour.R
            Me.rgbValues(index + 3) = colour.A
        Else
            Dim index As Integer = ((y * Me.Width + x) * 3)
            Me.rgbValues(index) = colour.B
            Me.rgbValues(index + 1) = colour.G
            Me.rgbValues(index + 2) = colour.R
        End If
    End Sub
    Public Function GetPixel(ByVal location As Point) As Color
        Return Me.GetPixel(location.X, location.Y)
    End Function
    Public Function GetPixel(ByVal x As Integer, ByVal y As Integer) As Color
        If Not Me.locked Then
            Throw New Exception("Bitmap not locked.")
            Return Nothing
        End If

        If Me.IsAlphaBitmap Then
            Dim index As Integer = ((y * Me.Width + x) * 4)
            Dim b As Integer = Me.rgbValues(index)
            Dim g As Integer = Me.rgbValues(index + 1)
            Dim r As Integer = Me.rgbValues(index + 2)
            Dim a As Integer = Me.rgbValues(index + 3)
            Return Color.FromArgb(a, r, g, b)
        Else
            Dim index As Integer = ((y * Me.Width + x) * 3)
            Dim b As Integer = Me.rgbValues(index)
            Dim g As Integer = Me.rgbValues(index + 1)
            Dim r As Integer = Me.rgbValues(index + 2)
            Return Color.FromArgb(r, g, b)
        End If
    End Function
End Class