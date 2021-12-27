Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Globalization
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co


Public Class Project_M
    Dim prd As ClS_project = New ClS_project()
    Public Sub clearTolls()
        txt_iden.Text = ""
        txt_name.Text = ""
        txt_loc.Text = ""
        txt_woner.Text = ""
        txt_cost.Text = ""
        Date_start.Text = ""
        Date_End.Text = ""
        bt_new.Enabled = True
        bt_save.Enabled = False
        bt_delete.Enabled = False
        bt_edit.Enabled = False
        bt_new.Focus()
    End Sub
    Public Sub FILL_COMBOBOX()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = prd.get_last_id_project()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        txt_iden.Text = id.ToString()
        txt_name.Focus()
    End Sub
    Public Sub filldatagrid()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = prd.get_all_projects()
        Grid_Project.DataSource = dt
    End Sub
    Private Sub PM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_name.Text = Form_Log.log_name
        filldatagrid()
        txt_name.Focus()
        setv(False)
    End Sub

    Sub setv(ByVal x As Boolean)
        txt_cost.Enabled = x
        txt_loc.Enabled = x
        txt_name.Enabled = x
        txt_woner.Enabled = x
        Date_start.Enabled = x
        Date_End.Enabled = x
    End Sub

    Private Sub bt_back_Click_1(sender As Object, e As EventArgs) Handles bt_back.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub bt_new_Click(sender As Object, e As EventArgs) Handles bt_new.Click
        setv(True)
        clearTolls()
        FILL_COMBOBOX()
        bt_new.Enabled = False
        bt_save.Enabled = True
        bt_delete.Enabled = False
        bt_edit.Enabled = False
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If txt_cost.Text Is String.Empty Or txt_iden.Text Is String.Empty Or txt_name.Text Is String.Empty Or txt_woner.Text Is String.Empty Or txt_loc.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        prd.Add_Project(Convert.ToInt16(txt_iden.Text), txt_name.Text, txt_loc.Text, txt_woner.Text, txt_cost.Text, Convert.ToDateTime(Date_start.Text), Convert.ToDateTime(Date_End.Text), lbl_name.Text, Now)
        MessageBox.Show("تمت إضافة المشروع بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        filldatagrid()
        clearTolls()
        bt_save.Enabled = False
        bt_new.Enabled = True
        setv(False)
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        If txt_cost.Text Is String.Empty Or txt_iden.Text Is String.Empty Or txt_name.Text Is String.Empty Or txt_woner.Text Is String.Empty Or txt_loc.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        prd.Edite_Projects(Convert.ToInt16(txt_iden.Text), txt_name.Text, txt_loc.Text, txt_woner.Text, txt_cost.Text, Convert.ToDateTime(Date_start.Text), Convert.ToDateTime(Date_End.Text), lbl_name.Text, Now)
        MessageBox.Show("تم تعديل بيانات المشروع بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        filldatagrid()
        clearTolls()
        bt_edit.Enabled = False
        bt_new.Enabled = True
        setv(False)
    End Sub

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click
        If txt_iden.Text Is String.Empty Then
            MsgBox("قم بإختيار المعرف")
            Return
        End If
        prd.Delete_Project(Convert.ToInt16(txt_iden.Text))
        MessageBox.Show("تم حذف بيانات المشروع بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
        filldatagrid()
        clearTolls()
        setv(False)

        bt_delete.Enabled = False
        bt_new.Enabled = True
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        setv(True)
        bt_edit.Enabled = True
        bt_delete.Enabled = True
        bt_save.Enabled = False
        bt_new.Enabled = True
        Try
            txt_iden.Text = CStr(GridView1.GetFocusedRowCellValue("معرف المشروع"))
            txt_cost.Text = CStr(GridView1.GetFocusedRowCellValue("تكلفة المشروع"))
            txt_loc.Text = CStr(GridView1.GetFocusedRowCellValue("موقع المشروع"))
            txt_woner.Text = CStr(GridView1.GetFocusedRowCellValue("مالك المشروع"))
            txt_name.Text = CStr(GridView1.GetFocusedRowCellValue("إسم المشروع"))
            Date_start.Text = CStr(GridView1.GetFocusedRowCellValue("تاريخ بدايةالمشروع"))
            Date_End.Text = CStr(GridView1.GetFocusedRowCellValue("تاريخ نهايةالمشروع"))
        Catch ex As Exception
            Return '
            '    MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Project_M_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub txt_cost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cost.KeyPress
        JustNumber(e)
    End Sub
End Class