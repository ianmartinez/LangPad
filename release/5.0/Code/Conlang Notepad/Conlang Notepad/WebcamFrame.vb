Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms

Public Class WebcamFrame
    Inherits Tundra.DoubleBufferedPanel
    Private VideoSource As VideoCaptureDevice
    Private WebcamImage As Image
    Public Shine As Boolean = False
    Public Event NewFrame(ByVal sender As Object, ByVal e As EventArgs)
    Private UneditedWebcamImage As Image
    Private Function Crop(image As Image, selection As Rectangle) As Image
        Dim bmp As Bitmap = TryCast(image, Bitmap)

        ' Check if it is a bitmap:
        If bmp Is Nothing Then
            Throw New ArgumentException("No valid bitmap")
        End If

        ' Crop the image:
        Dim cropBmp As Bitmap = bmp.Clone(selection, bmp.PixelFormat)

        ' Release the resources:
        image.Dispose()

        Return cropBmp
    End Function
    Public Sub ActivateWebcam()
        Dim VideoSources As New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If VideoSources IsNot Nothing Then
            VideoSource = New VideoCaptureDevice(VideoSources(0).MonikerString)
            Try
                If VideoSource.VideoCapabilities.Length > 0 Then
                    Dim highestSolution As String = "0;0"
                    For i As Integer = 0 To VideoSource.VideoCapabilities.Length - 1
                        If VideoSource.VideoCapabilities(i).FrameSize.Width > Convert.ToInt32(highestSolution.Split(";"c)(0)) Then
                            highestSolution = VideoSource.VideoCapabilities(i).FrameSize.Width.ToString() & ";" & i.ToString()
                        End If
                    Next
                    VideoSource.DesiredFrameSize = VideoSource.VideoCapabilities(Convert.ToInt32(highestSolution.Split(";"c)(1))).FrameSize
                End If
            Catch
            End Try
            AddHandler VideoSource.NewFrame, New AForge.Video.NewFrameEventHandler(AddressOf videoSource_NewFrame)
            Play()
        End If
    End Sub
    Public Sub DeactivateWebcam()
        If VideoSource IsNot Nothing AndAlso VideoSource.IsRunning Then
            VideoSource.SignalToStop()
            VideoSource = Nothing
        End If
    End Sub
    Public Sub Pause()
        VideoSource.Stop()
    End Sub
    Public Sub Play()
        VideoSource.Start()
    End Sub
    Public Function GetSnapshot(Optional ByVal CropSides As Boolean = False) As Image
        If CropSides = True Then
            Dim Cropped As Graphics = Graphics.FromImage(UneditedWebcamImage)
            Return Crop(UneditedWebcamImage, New Rectangle(1, 1, UneditedWebcamImage.Width - 1, UneditedWebcamImage.Height - 2))
        Else
            Return UneditedWebcamImage
        End If
    End Function
    Private Sub SetWebcamPicture()
        On Error Resume Next

        Me.BackgroundImage = Crop(WebcamImage, New Rectangle(1, 1, WebcamImage.Width - 1, WebcamImage.Height - 2))
    End Sub
    Private Sub VideoSource_NewFrame(ByVal sender As Object, ByVal eventArgs As AForge.Video.NewFrameEventArgs)
        WebcamImage = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        UneditedWebcamImage = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        SetWebcamPicture()
        RaiseEvent NewFrame(Me, Nothing)

    End Sub

    Private Sub WebcamFrame_NewFrame(sender As Object, e As EventArgs) Handles Me.NewFrame

    End Sub
End Class