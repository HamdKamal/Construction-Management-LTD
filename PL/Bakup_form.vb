Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports System.ComponentModel
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co


Public Class Bakup_form
     Dim cmd As SqlCommand = New SqlCommand()
    Dim logs As Main_Form = New Main_Form
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")> Private Sub simpleButton2_Click(sender As Object, e As EventArgs) Handles bt_save_backup.Click
        Try
            If txt_path.Text Is String.Empty Then
                MsgBox("الرجاء تحديد المسار ")
                Return
            End If
            Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
            Dim filename As String = txt_path.Text & "//construction_DB" + DateTime.Now.ToLongDateString().Replace("/"c, "-"c) & " ^ " + DateTime.Now.ToShortTimeString().Replace(":"c, "-"c)
            Dim strqry As String = "Backup Database construction to Disk ='" & filename & ".bak'"
            cmd = New SqlCommand(strqry, DAL.sqlconn)
            DAL.sqlconn.Open()
            cmd.ExecuteNonQuery()
            DAL.sqlconn.Close()
            MessageBox.Show("تم عمل النسخة الإحتياطية بنجاح", "عمل نسخة  إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information)
           
            Me.Dispose()
        Catch ex As Exception
            Return
        End Try
     
    End Sub

    Private Sub simpleButton3_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Dispose()
        Me.Close()
    End Sub

    Private Sub bt_select_path_Click(sender As Object, e As EventArgs) Handles bt_select_path.Click
        If FBD.ShowDialog() = DialogResult.OK Then
            txt_path.Text = FBD.SelectedPath
        End If
    End Sub

    Private Sub Bakup_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_name.Text = Form_Log.log_name
    End Sub
End Class