Public Class SplashScreen
    Sub New
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub marqueeProgressBarControl1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Main_Form.Show()
        Timer1.Stop()
        Me.Hide()
       

    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
