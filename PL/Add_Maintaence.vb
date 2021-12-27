Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class Add_Maintaence
    Dim oo As Car_Res = New Car_Res()
    Dim BILS As CLS_Bills = New CLS_Bills()

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If txt_name.Text Is String.Empty Then
            MsgBox("الرجاء أدخال البيانات")
            Return
        End If
        BILS.Add_Maintance(txt_name.Text)
        MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
       
        Me.Dispose()
        Me.Close()
        Car_Res.ref_form()
    End Sub

  
    Private Sub Add_Maintaence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_name.Text = Form_Log.log_name
    End Sub

    Private Sub Add_Maintaence_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class