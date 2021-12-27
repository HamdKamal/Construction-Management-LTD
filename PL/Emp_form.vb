Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class Emp_form
    Dim emp As ClS_employes = New ClS_employes()
    Public Sub filldatagrid()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = emp.get_all_employees()
        GRID_EMP.DataSource = dt
    End Sub
    Public Sub FILL_COMBOBOX()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        DAL.sqlconn.Open()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = emp.get_last_id_employee()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_ID.Text = id.ToString()
        txt_name.Focus()
    End Sub
    Sub cleartext()
        TXT_ID.Text = ""
        txt_job.Text = ""
        txt_name.Text = ""
        txt_salary.Text = ""
        txt_stay_NO.Text = ""
    End Sub

    Sub setv(ByVal x As Boolean)
        txt_job.Enabled = x
        txt_name.Enabled = x
        txt_salary.Enabled = x
        txt_stay_NO.Enabled = x
        date_STAY.Enabled = x
    End Sub


    Private Sub Emp_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldatagrid()
        setv(False)
        bt_save.Enabled = False
        bt_del.Enabled = False
        bt_edit.Enabled = False
    End Sub
    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If TXT_ID.Text Is String.Empty Or txt_name.Text Is String.Empty Or txt_stay_NO.Text Is String.Empty Or txt_job.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        emp.add_Employess(Convert.ToInt16(TXT_ID.Text), txt_name.Text, txt_stay_NO.Text, date_STAY.DateTime, txt_job.Text, txt_salary.Text)
        MessageBox.Show("تمت إضافة البيانات بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        filldatagrid()
        cleartext()
        SimpleButton1.Enabled = True
        bt_save.Enabled = False
        bt_del.Enabled = False
        bt_edit.Enabled = False

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cleartext()
        setv(True)
        FILL_COMBOBOX()
        SimpleButton1.Enabled = False
        bt_save.Enabled = True
        bt_del.Enabled = False
        bt_edit.Enabled = False
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        If TXT_ID.Text Is String.Empty Or txt_name.Text Is String.Empty Or txt_stay_NO.Text Is String.Empty Or txt_job.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        emp.edite_EMployeess(Convert.ToInt16(TXT_ID.Text), txt_name.Text, txt_stay_NO.Text, date_STAY.DateTime, txt_job.Text, txt_salary.Text)
        MessageBox.Show("تم تعديل بيانات الموظف بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        filldatagrid()
        cleartext()
        setv(False)

        SimpleButton1.Enabled = True
        bt_save.Enabled = False
        bt_del.Enabled = False
        bt_edit.Enabled = False
    End Sub

    Private Sub bt_del_Click(sender As Object, e As EventArgs) Handles bt_del.Click
        If TXT_ID.Text Is String.Empty Then
            MsgBox("قم بإختيار معرف الموظف")
            Return
        End If
        emp.Delete_Emp(Convert.ToInt16(TXT_ID.Text))
        MessageBox.Show("تم حذف بيانات الموظف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
        filldatagrid()
        cleartext()
        setv(False)

        SimpleButton1.Enabled = True
        bt_save.Enabled = False
        bt_del.Enabled = False
        bt_edit.Enabled = False
    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        setv(True)
        SimpleButton1.Enabled = True
        bt_save.Enabled = False
        bt_del.Enabled = True
        bt_edit.Enabled = True
        Try
            cleartext()
            TXT_ID.Text = CStr(GridView1.GetFocusedRowCellValue("رقم الموظف"))
            txt_job.Text = CStr(GridView1.GetFocusedRowCellValue("الوظيفة"))
            txt_name.Text = CStr(GridView1.GetFocusedRowCellValue("إسم الموظف"))
            txt_salary.Text = CStr(GridView1.GetFocusedRowCellValue("الراتب"))
            txt_stay_NO.Text = CStr(GridView1.GetFocusedRowCellValue("رقم الإقامة"))
            date_STAY.Text = CStr(GridView1.GetFocusedRowCellValue("صلاحية الإقامة"))
        Catch ex As Exception
            Return '
            MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Emp_form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub txt_salary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_salary.KeyPress
        JustNumber(e)
    End Sub
End Class