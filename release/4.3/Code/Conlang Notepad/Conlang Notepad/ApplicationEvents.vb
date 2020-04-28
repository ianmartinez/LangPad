Imports Tundra
Imports System.IO
Imports System.Linq
Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            On Error Resume Next
            ssLoading.pbLoading.SetProgress(0)
            Dim IPAFont = New Font("Segoe UI", 11, FontStyle.Regular)
            Dim IPAPadding = New Padding(0)
            Dim IPAMargin = New Padding(1)
            Dim IPAMin = New Size(45, 32)

            ssLoading.lblLoading.Text = "Loading Accent Marks..."
            For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Accents)
                Dim IPAButton As New StylizedButton
                IPAButton.Style = My.Resources.KeyStyle
                IPAButton.Padding = IPAPadding
                IPAButton.Font = IPAFont
                IPAButton.AutoSize = True
                IPAButton.MinimumSize = IPAMin
                IPAButton.Margin = IPAMargin
                IPAButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
                IPAButton.Text = IPA.Value
                AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
                frmMain.AccentsLayoutPanel.Controls.Add(IPAButton)
            Next
            ssLoading.pbLoading.SetProgress(10)
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading IPA Affricates..."
            For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Affricates)
                Dim IPAButton As New StylizedButton
                IPAButton.Style = My.Resources.KeyStyle
                IPAButton.Padding = IPAPadding
                IPAButton.Font = IPAFont
                IPAButton.AutoSize = True
                IPAButton.MinimumSize = IPAMin
                IPAButton.Margin = IPAMargin
                IPAButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
                IPAButton.Text = IPA.Value
                AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
                frmMain.AffricatesLayoutPanel.Controls.Add(IPAButton)
            Next
            ssLoading.pbLoading.SetProgress(20)
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading IPA Consonants..."
            For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Consonants)
                Dim IPAButton As New StylizedButton
                IPAButton.Style = My.Resources.KeyStyle
                IPAButton.Padding = IPAPadding
                IPAButton.Font = IPAFont
                IPAButton.AutoSize = True
                IPAButton.MinimumSize = IPAMin
                IPAButton.Margin = IPAMargin
                IPAButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
                IPAButton.Text = IPA.Value
                AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
                frmMain.ConsonantsLayoutPanel.Controls.Add(IPAButton)
            Next
            ssLoading.pbLoading.SetProgress(30)
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading IPA Tones..."
            For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.ToneIntonation)
                Dim IPAButton As New StylizedButton
                IPAButton.Style = My.Resources.KeyStyle
                IPAButton.Padding = IPAPadding
                IPAButton.Font = IPAFont
                IPAButton.AutoSize = True
                IPAButton.MinimumSize = IPAMin
                IPAButton.Margin = IPAMargin
                IPAButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
                IPAButton.Text = IPA.Value
                AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
                frmMain.ToneIntonationLayoutPanel.Controls.Add(IPAButton)
            Next
            ssLoading.pbLoading.SetProgress(40)
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading IPA Vowels..."
            For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Vowels)
                Dim IPAButton As New StylizedButton
                IPAButton.Style = My.Resources.KeyStyle
                IPAButton.Padding = IPAPadding
                IPAButton.Font = IPAFont
                IPAButton.AutoSize = True
                IPAButton.MinimumSize = IPAMin
                IPAButton.Margin = IPAMargin
                IPAButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
                IPAButton.Text = IPA.Value
                AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
                frmMain.VowelsLayoutPanel.Controls.Add(IPAButton)
            Next
            ssLoading.pbLoading.SetProgress(50)
            ssLoading.Refresh()



            ssLoading.lblLoading.Text = "Loading Other IPA Characters..."
            For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Other)
                Dim IPAButton As New StylizedButton
                IPAButton.Style = My.Resources.KeyStyle
                IPAButton.Padding = IPAPadding
                IPAButton.Font = IPAFont
                IPAButton.AutoSize = True
                IPAButton.MinimumSize = IPAMin
                IPAButton.Margin = IPAMargin
                IPAButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
                IPAButton.Text = IPA.Value
                AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
                frmMain.OtherLayoutPanel.Controls.Add(IPAButton)
            Next
            ssLoading.pbLoading.SetProgress(60)
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading Common Characters..."
            For Each IPA As String In My.Resources.Common.Split({"|"}, StringSplitOptions.RemoveEmptyEntries)
                Dim IPAButton As New StylizedButton
                IPAButton.Style = My.Resources.KeyStyle
                IPAButton.Padding = IPAPadding
                IPAButton.Font = IPAFont
                IPAButton.AutoSize = True
                IPAButton.MinimumSize = IPAMin
                IPAButton.Margin = IPAMargin
                IPAButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
                IPAButton.Text = IPA
                AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
                frmMain.CommonLayoutPanel.Controls.Add(IPAButton)
            Next
            ssLoading.pbLoading.SetProgress(70)
            ssLoading.Refresh()

            ssLoading.lblLoading.Text = "Loading Custom Characters..."
            Dim LineList As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each IPA As String In LineList
                Dim IPAButton As New StylizedButton
                IPAButton.Style = My.Resources.KeyStyle
                IPAButton.Padding = IPAPadding
                IPAButton.Font = IPAFont
                IPAButton.AutoSize = True
                IPAButton.MinimumSize = IPAMin
                IPAButton.Margin = IPAMargin
                IPAButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
                IPAButton.Text = IPA
                AddHandler IPAButton.Click, AddressOf frmMain.InsertIPA
                frmMain.CustomLayoutPanel.Controls.Add(IPAButton)
            Next
            ssLoading.pbLoading.SetProgress(80)
            ssLoading.Refresh()


            If Directory.Exists(Windows.Forms.Application.StartupPath & "\Clip Art") Then
                ssLoading.lblLoading.Text = "Loading Clip Art..."
                Dim FilePaths As List(Of String) = Directory.EnumerateFiles(Windows.Forms.Application.StartupPath & "\Clip Art").ToList

                For i = 0 To FilePaths.Count - 1
                    If Not FilePaths.Item(i).Split(".").GetValue(1) = "png" Then Continue For
                    ssLoading.lblLoading.Text = String.Format("Loading Clip Art ({0}/{1})...", i + 1, FilePaths.Count)
                    Dim ImageFile = Image.FromFile(FilePaths.Item(i))
                    Dim ImageButton As New StylizedButton
                    ImageButton.Style = My.Resources.KeyStyle
                    ImageButton.Padding = IPAPadding
                    ImageButton.Font = IPAFont
                    ImageButton.ImageAlign = ContentAlignment.MiddleCenter
                    ImageButton.Size = New Size(76, 76)
                    ImageButton.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
                    ImageButton.Margin = New Padding(2)
                    ImageButton.Padding = New Padding(2, 2, 3, 3)
                    ImageButton.Text = ""
                    ImageButton.Image = ImageFile
                    AddHandler ImageButton.Click, AddressOf frmMain.InsertImageHandler
                    frmMain.ClipArtLayoutPanel.Controls.Add(ImageButton)
                Next
                ssLoading.pbLoading.SetProgress(90)
                ssLoading.Refresh()
            End If

            ssLoading.pbLoading.SetProgress(100)
            ssLoading.Refresh()
        End Sub
    End Class


End Namespace

