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

            If My.Settings.AccentMarks = True Then
                For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Accents)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.AccentsLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.AccentsLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.AccentsTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.AccentsTabPage)
            End If

            If My.Settings.IPAAffricates = True Then
                For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Affricates)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.AffricatesLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.AffricatesLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.AffricatesTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.AffricatesTabPage)
            End If

            If My.Settings.IPAConsonants = True Then
                For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Consonants)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.ConsonantsLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.ConsonantsLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.ConsonantsTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.ConsonantsTabPage)
            End If

            If My.Settings.IPATones = True Then
                For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.ToneIntonation)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.ToneIntonationLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.ToneIntonationLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.ToneIntonationTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.ToneIntonationTabPage)
            End If

            If My.Settings.IPAVowels = True Then
                For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Vowels)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.VowelsLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.VowelsLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.VowelsTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.VowelsTabPage)
            End If

            If My.Settings.OtherIPA = True Then
                For Each IPA As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.Other)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA.Value
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.OtherLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA.Value
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.OtherLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.OtherTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.OtherTabPage)
            End If

            If My.Settings.CommonChar = True Then
                For Each IPA As String In My.Resources.Common.Split({"|"}, StringSplitOptions.RemoveEmptyEntries)
                    Dim SymbolButton As New SymbolButton
                    SymbolButton.Text = IPA
                    AddHandler SymbolButton.Click, AddressOf frmMain.InsertIPA
                    frmMain.CommonLayoutPanel.Controls.Add(SymbolButton)

                    Dim SymbolButtonDictionary As New SymbolButton
                    SymbolButtonDictionary.Text = IPA
                    AddHandler SymbolButtonDictionary.Click, AddressOf frmDictionary.InsertIPA
                    frmDictionary.CommonLayoutPanel.Controls.Add(SymbolButtonDictionary)
                Next
            Else
                frmMain.tcSymbols.TabPages.Remove(frmMain.CommonTabPage)
                frmDictionary.tcSymbols.TabPages.Remove(frmMain.CommonTabPage)
            End If

            Dim LineList As String() = My.Settings.CustomSymbols.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
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

            If My.Settings.SmartReplace = True Then
                For Each pair As KeyValuePair(Of String, String) In ZiaFile.Read(My.Resources.SmartReplace)
                    SmartReplaceList.Add(pair.Key, pair.Value)
                Next
            End If

            If My.Settings.Updates = True Then
                dlgUpdate.FetchUpdateData()
            End If

            dlgUpdate.StartupCheck = False
        End Sub
    End Class
End Namespace

