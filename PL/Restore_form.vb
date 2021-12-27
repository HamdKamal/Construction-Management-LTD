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


Public Class Restore_form
    Dim cmd As SqlCommand = New SqlCommand()

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")> Private Sub simpleButton3_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub bt_select_path_Click(sender As Object, e As EventArgs) Handles bt_select_path.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txt_path.Text = OpenFileDialog1.FileName
        End If
    End Sub

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")> Private Sub bt_Restore_Click(sender As Object, e As EventArgs) Handles bt_Restore.Click
        If txt_path.Text Is String.Empty Then
            MsgBox("قم بإختيار المسار")
            Return
        End If
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        Dim strqry As String = "ALTER Database construction SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database construction From Disk ='" & txt_path.Text & "'"
        cmd = New SqlCommand(strqry, DAL.sqlconn)
        DAL.sqlconn.Open()
        cmd.ExecuteNonQuery()
        DAL.sqlconn.Close()
        MessageBox.Show("تم إستعادة النسخة الإحتياطية بنجاح", "إستعادة نسخة  إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Restore_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_name.Text = Form_Log.log_name
    End Sub
End Class