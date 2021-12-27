Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Windows.Forms
Imports System.Threading.Tasks
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class Form_Log
    
    Public log As CLS_login = New CLS_login()
    Public log_name As String
    Public lo_name As String
    Public lo_pass As String
    Public LOG_ID As String

    Private Sub BTCLOSE_CheckedChanged(sender As Object, e As EventArgs) Handles closeBtn.CheckedChanged
        Application.Exit()
    End Sub

    Sub check()
        lo_name = NameTxt.Text
        lo_pass = passTxt.Text

        If NameTxt.Text Is String.Empty Or passTxt.Text Is String.Empty Then
            MessageBox.Show("!يوجد خطأ في تسجيل الدخول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Dim DT As DataTable = log.Login(NameTxt.Text, passTxt.Text)
        If DT.Rows.Count > 0 Then
            If DT.Rows(0)(4).ToString() = "ADMIN" Then
                log_name = DT.Rows(0)("User_FullName").ToString()
                LOG_ID = DT.Rows(0)("USER_ID").ToString()
                Me.Hide()
                SplashScreen.Show()
            End If
        End If
        If DT.Rows.Count > 0 Then
            If DT.Rows(0)(4).ToString() = "USER" Then
                log_name = DT.Rows(0)("User_FullName").ToString()
                LOG_ID = DT.Rows(0)("USER_ID").ToString()
                Me.Hide()
                SplashScreen.Show()
            End If
        Else
            MessageBox.Show("!فشل تسجيل الدخول", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub Form_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If My.Settings.Counter >= 1 Then
                Return
            ElseIf My.Settings.Counter = 0 Then
                System_Conf.ShowDialog()
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox("فشل الإتصال بالسيرفر")
        End Try
        NameTxt.Focus()
    End Sub

    Private Sub loginBtn_CheckedChanged(sender As Object, e As EventArgs) Handles loginBtn.CheckedChanged
        check()
    End Sub

    Private Sub Form_Log_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub PictureEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles PictureEdit2.EditValueChanged

    End Sub
End Class