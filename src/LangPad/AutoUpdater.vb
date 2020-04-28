Imports AutoUpdaterDotNET

Module AutoUpdater
    Public Sub Update()
        Dim ScreenSize = My.Computer.Screen.Bounds.Size
        Dim OldSize = AutoUpdaterDotNET.AutoUpdater.UpdateFormSize
        AutoUpdaterDotNET.AutoUpdater.UpdateFormSize = New Size(ScreenSize.Width / 2, If(OldSize Is Nothing, ScreenSize.Height / 2, OldSize.Value.Height))

        AutoUpdaterDotNET.AutoUpdater.Start("https://raw.githubusercontent.com/ianmartinez/LangPad/master/update/update.xml")
    End Sub
End Module
