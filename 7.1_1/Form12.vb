Imports System.Configuration

Public Class FormChangeConnection
    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        UpdateConnectionString(ConfigurationManager.ConnectionStrings("Home._7._1_1.My.MySettings.WorkersConnectionString").ConnectionString)
    End Sub

    Private Sub ButtonCollege_Click(sender As Object, e As EventArgs) Handles ButtonCollege.Click
        UpdateConnectionString(ConfigurationManager.ConnectionStrings("_7._1_1.My.MySettings.WorkersConnectionString").ConnectionString)
    End Sub

    Private Sub UpdateConnectionString(newConnectionString As String)
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)


        config.ConnectionStrings.ConnectionStrings("_7._1_1.My.MySettings.WorkersConnectionString").ConnectionString = newConnectionString


        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")

        My.Settings.Reload()
        Form1.Show()
        Me.Hide()
    End Sub
End Class