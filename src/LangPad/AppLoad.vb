﻿Imports LangPadData

''' <summary>
''' Load all of the controls in the character editor and check for updates at startup.
''' </summary>
Module AppLoad
    ''' <summary>
    ''' Update the splash screen.
    ''' </summary>
    ''' 
    ''' <param name="ProgressValue">The progress bar value.</param>
    ''' <param name="ProgressText">The progress text saying what is currently being loaded.</param>
    Public Sub UpdateSplash(ProgressValue As Integer, ProgressText As String)
        SplashScreenForm.Invoke(Sub()
                                    SplashScreenForm.LoadingLabel.Text = ProgressText
                                    SplashScreenForm.LoadingProgressBar.Value = ProgressValue
                                    SplashScreenForm.Refresh()
                                End Sub)
    End Sub

    ''' <summary>
    ''' Load the application.
    ''' </summary>
    Public Sub LoadApplication()
        SplashScreenForm.Show()
        BeginOperation(MainForm)
        BeginOperation(CharEditWindow)

        UpdateSplash(0, "Loading Accent Marks...")
        For Each AccentMark As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.Accents)
            CharEditWindow.CharEdit.InsertAccentButton(AccentMark.Value, AccentMark.Key)
        Next

        UpdateSplash(10, "Loading IPA Affricates...")
        For Each Affricate As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.Affricates)
            CharEditWindow.CharEdit.InsertCharacterButton(Affricate.Value, CharEditWindow.CharEdit.AffricatesPanel, Affricate.Key, True, True, CharacterType.IPAAffricate)
        Next

        UpdateSplash(20, "Loading IPA Consonants...")
        For Each Consonant As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.Consonants)
            CharEditWindow.CharEdit.InsertCharacterButton(Consonant.Value, CharEditWindow.CharEdit.ConsonantsLayoutPanel, Consonant.Key, True, True, CharacterType.IPAConsonant)
        Next

        UpdateSplash(30, "Loading IPA Tones...")
        For Each Tone As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.ToneIntonation)
            CharEditWindow.CharEdit.InsertCharacterButton(Tone.Value, CharEditWindow.CharEdit.ToneIntonationPanel, Tone.Key, True, True, CharacterType.IPATone)
        Next

        UpdateSplash(40, "Loading IPA Vowels...")
        For Each Vowel As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.Vowels)
            CharEditWindow.CharEdit.InsertCharacterButton(Vowel.Value, CharEditWindow.CharEdit.VowelPanel, Vowel.Key, True, True, CharacterType.IPAVowel)
        Next

        UpdateSplash(50, "Loading IPA Diactritics...")
        For Each Diacritic As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.Diacritics)
            CharEditWindow.CharEdit.InsertCharacterButton(Diacritic.Value, CharEditWindow.CharEdit.DiacriticsPanel, Diacritic.Key, True, True, CharacterType.IPADiacritic)
        Next

        UpdateSplash(60, "Loading IPA Suprasegmentals...")
        For Each Suprasegmental As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.Suprasegmentals)
            CharEditWindow.CharEdit.InsertCharacterButton(Suprasegmental.Value, CharEditWindow.CharEdit.SuprasegmentalsPanel, Suprasegmental.Key, True, True, CharacterType.IPASuprasegmental)
        Next

        UpdateSplash(70, "Loading Extended Characters...")
        For Each LatinExtended As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.Common)
            CharEditWindow.CharEdit.InsertCharacterButton(LatinExtended.Value, CharEditWindow.CharEdit.LatinPanel, LatinExtended.Key, False, True, CharacterType.ExtendedLatin)
        Next

        For Each CyrillicExtended As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.Cyrillic)
            CharEditWindow.CharEdit.InsertCharacterButton(CyrillicExtended.Value, CharEditWindow.CharEdit.CyrillicPanel, CyrillicExtended.Key, False, True, CharacterType.ExtendedCyrillic)
        Next

        For Each GreekExtended As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.Greek)
            CharEditWindow.CharEdit.InsertCharacterButton(GreekExtended.Value, CharEditWindow.CharEdit.GreekPanel, GreekExtended.Key, False, True, CharacterType.ExtendedGreek)
        Next

        UpdateSplash(80, "Loading Local Custom Characters...")
        For Each LocalCharacter As String In Config.LocalChars
            CharEditWindow.CharEdit.InsertCharacterButton(LocalCharacter, CharEditWindow.CharEdit.LocalPanel)
        Next

        UpdateSplash(90, "Loading Smart Replace...")
        If Config.SmartReplace = True Then
            SplashScreenForm.LoadingLabel.Text = "Loading Smart Replace..."
            For Each pair As KeyValuePair(Of String, String) In KeyValue.Read(My.Resources.SmartReplace)
                SmartReplaceList.Add(pair.Key, pair.Value)
            Next
        End If

        If Config.UpdateOnStartup = True Then
            UpdateSplash(95, "Checking for Updates...")
            SplashScreenForm.LoadingLabel.Text = "Checking for updates..."
            CheckForUpdates()
        End If

        CharEditWindow.CharEdit.RefreshPanels()
        UpdateSplash(100, "Loading Main Window...")

        EndOperation(MainForm)
        EndOperation(CharEditWindow)
        SplashScreenForm.Close()
    End Sub
End Module
