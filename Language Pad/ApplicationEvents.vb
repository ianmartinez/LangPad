Imports Tundra
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

            ssLoading.pbLoading.Value = 0
            ssLoading.lblLoading.Text = "Loading..."

            If Settings.AccentMarks = True Then
                ssLoading.lblLoading.Text = "Loading Accent Marks..."
                For Each IPA As KeyValuePair(Of String, String) In Read(Resources.Accents)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.AccentsLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.AccentsLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 10
                ssLoading.Refresh()
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.AccentsTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.AccentsTabPage)
            End If

            If Settings.IPAAffricates = True Then
                ssLoading.lblLoading.Text = "Loading IPA Affricates..."
                For Each IPA As KeyValuePair(Of String, String) In Read(Resources.Affricates)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.AffricatesLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.AffricatesLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 20
                ssLoading.Refresh()
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.AffricatesTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.AffricatesTabPage)
            End If

            If Settings.IPAConsonants = True Then
                ssLoading.lblLoading.Text = "Loading IPA Consonants..."
                For Each IPA As KeyValuePair(Of String, String) In Read(Resources.Consonants)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.ConsonantsLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.ConsonantsLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 30
                ssLoading.Refresh()
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.ConsonantsTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.ConsonantsTabPage)
            End If

            If Settings.IPATones = True Then
                ssLoading.lblLoading.Text = "Loading IPA Tones..."
                For Each IPA As KeyValuePair(Of String, String) In Read(Resources.ToneIntonation)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.ToneIntonationLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.ToneIntonationLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 40
                ssLoading.Refresh()
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.ToneIntonationTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.ToneIntonationTabPage)
            End If

            If Settings.IPAVowels = True Then
                ssLoading.lblLoading.Text = "Loading IPA Vowels..."
                For Each IPA As KeyValuePair(Of String, String) In Read(Resources.Vowels)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.VowelsLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.VowelsLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 50
                ssLoading.Refresh()
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.VowelsTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.VowelsTabPage)
            End If

            If Settings.OtherIPA = True Then
                ssLoading.lblLoading.Text = "Loading Other IPA Characters..."
                For Each IPA As KeyValuePair(Of String, String) In Read(Resources.Other)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.OtherLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.OtherLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 60
                ssLoading.Refresh()
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.OtherTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.OtherTabPage)
            End If

            If Settings.CommonChar = True Then
                ssLoading.lblLoading.Text = "Loading Common Characters..."
                For Each IPA As String In Resources.Common.Split({"|"}, StringSplitOptions.RemoveEmptyEntries)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.CommonLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.CommonLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
                ssLoading.pbLoading.Value = 70
                ssLoading.Refresh()
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.CommonTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.CommonTabPage)
            End If

            ssLoading.lblLoading.Text = "Loading Custom Characters..."
            Dim LineList As String() = Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            For Each IPA As String In LineList
                Dim SymbolButton As New SymbolButton
                SymbolButton.Text = IPA
                AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                frmMain.CustomLayoutPanel.Controls.Add(SymbolButton)

                Dim SymbolButtonDictionary As New SymbolButton
                SymbolButtonDictionary.Text = IPA
                AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                frmDictionary.CustomLayoutPanel.Controls.Add(SymbolButtonDictionary)
            Next
            ssLoading.pbLoading.Value = 80
            ssLoading.Refresh()

            If Settings.SmartReplace = True Then
                ssLoading.lblLoading.Text = "Loading Smart Replace..."
                For Each pair As KeyValuePair(Of String, String) In Read(Resources.SmartReplace)
                    SmartReplaceList.Add(pair.Key, pair.Value)
                Next
            End If
            ssLoading.pbLoading.Value = 90
            ssLoading.Refresh()

            If Settings.Updates = True Then
                ssLoading.lblLoading.Text = "Checking for updates..."
                dlgUpdate.FetchUpdateData()
            End If

            dlgUpdate.StartupCheck = False
            ssLoading.pbLoading.Value = 100
            ssLoading.Refresh()
        End Sub
    End Class
End Namespace
