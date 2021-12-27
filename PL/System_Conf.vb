Imports System.Configuration
Imports System.Configuration.ConfigurationManager
Public Class System_Conf

    Private Sub BT_SAVE_Click(sender As Object, e As EventArgs) Handles BT_SAVE.Click
        My.Settings.Server = TXT_SERVER.Text
        My.Settings.DataBase = TXT_BASE.Text
        My.Settings.Mode = If(RB_WIN.Checked = True, "Windows", "Windows")
        My.Settings.Counter += 1
        My.Settings.Save()

        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        config.ConnectionStrings.ConnectionStrings("Aim-Connection").ConnectionString = "XpoProvider=MSSqlServer;data source='" & TXT_SERVER.Text & "';integrated security=SSPI;initial catalog='" & TXT_BASE.Text & "'"
        config.Save(ConfigurationSaveMode.Modified, True)
        ConfigurationManager.RefreshSection("connectionStrings")


        config.ConnectionStrings.ConnectionStrings("ahmed").ConnectionString = "XpoProvider=MSSqlServer;data source='" & TXT_SERVER.Text & "';integrated security=SSPI;initial catalog='" & TXT_BASE.Text & "'"
        config.Save(ConfigurationSaveMode.Modified, True)
        ConfigurationManager.RefreshSection("connectionStrings")
        MessageBox.Show("تم حفظ إسم السيرفر بنجاح", "الإتصال بالسيرفر", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
    Private Sub System_Conf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_SERVER.Text = My.Settings.Server
        TXT_BASE.Text = My.Settings.DataBase
        If My.Settings.Mode = "Windows" Then
            RB_WIN.Checked = True
        End If

    End Sub
End Class