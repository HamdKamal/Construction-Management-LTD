Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co


Public Class main_item
    Dim prd As ClS_project = New ClS_project()
    Public Sub filldatagrid()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        DAL.sqlconn.Open()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = prd.get_all_mainCat()
        Grid_MainCat.DataSource = dt
    End Sub
    Public Sub FILL_COMBOBOX()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = prd.get_last_id_MainCat()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_ID.Text = id.ToString()
        txt_name.Focus()
    End Sub

    Private Sub main_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldatagrid()
        bt_edit.Enabled = False
        bt_del.Enabled = False
        bt_add.Enabled = False

    End Sub

    Private Sub bt_add_Click(sender As Object, e As EventArgs) Handles bt_add.Click
        If TXT_ID.Text Is String.Empty Or TXT_NAME.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        prd.add_main_catgeories(Convert.ToInt16(TXT_ID.Text), TXT_NAME.Text)
        MessageBox.Show("تمت إضافة البند بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TXT_ID.Text = ""
        TXT_NAME.Text = ""
        filldatagrid()
        bt_add.Enabled = False
        bt_edit.Enabled = False
        bt_del.Enabled = False
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        If TXT_ID.Text Is String.Empty Or TXT_NAME.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        prd.edite_mainCat(Convert.ToInt16(TXT_ID.Text), TXT_NAME.Text)
        MessageBox.Show("تم التعديل  بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TXT_ID.Text = ""
        TXT_NAME.Text = ""
        filldatagrid()
        bt_edit.Enabled = False
        bt_add.Enabled = False
        bt_del.Enabled = False

    End Sub

    Private Sub bt_del_Click(sender As Object, e As EventArgs) Handles bt_del.Click
        If TXT_ID.Text Is String.Empty Or TXT_NAME.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        prd.Delete_MainCat(Convert.ToInt16(TXT_ID.Text))
        MessageBox.Show("تم حذف البند  بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TXT_ID.Text = ""
        TXT_NAME.Text = ""
        filldatagrid()
        bt_del.Enabled = False
    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        bt_edit.Enabled = True
        bt_add.Enabled = False
        bt_del.Enabled = True
        Try
            TXT_ID.Text = ""
            TXT_NAME.Text = ""
            TXT_ID.Text = CStr(GridView1.GetFocusedRowCellValue("معرف البند الرئيسي"))
            TXT_NAME.Text = CStr(GridView1.GetFocusedRowCellValue("اسم البند"))
        Catch ex As Exception
            MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        TXT_ID.Text = ""
        TXT_NAME.Text = ""
        FILL_COMBOBOX()
        bt_edit.Enabled = False
        bt_add.Enabled = True
        bt_del.Enabled = False
    End Sub

    Private Sub main_item_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class