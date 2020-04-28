''' <summary>
''' Work with AutoUpdaterDotNET
''' </summary>
Module AutoUpdater
    ''' <summary>
    ''' Check for updates and display a dialog if there are any
    ''' </summary>
    Public Sub CheckForUpdates()
        Dim ScreenSize = My.Computer.Screen.Bounds.Size
        Dim OldSize = AutoUpdaterDotNET.AutoUpdater.UpdateFormSize
        AutoUpdaterDotNET.AutoUpdater.UpdateFormSize = New Size(ScreenSize.Width / 2, If(OldSize Is Nothing, ScreenSize.Height / 2, OldSize.Value.Height))
        AutoUpdaterDotNET.AutoUpdater.Start("https://raw.githubusercontent.com/ianmartinez/LangPad/master/update/update.xml")
    End Sub
End Module
