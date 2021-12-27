Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class Workers
    Dim EMP As ClS_employes = New ClS_employes()
    Dim prd As ClS_project = New ClS_project()
    Sub MySub()
        lbl_name.Text = Form_Log.log_name
        fill_combo()
        setv(False)
        fill_Gridview()
        bt_edite.Enabled = False
        bt_save.Enabled = False
    End Sub
    Sub ref_form()
        ' Me.Show()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        MySub()
        Refresh()
    End Sub
    Public Sub fill_txt_id()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = EMP.get_ID_workerbills()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_id.Text = id.ToString()
        Combo_Pro.Focus()
    End Sub
    Public Sub fill_combo()
        Combo_Pro.DataSource = prd.fill_combo_proj()
        Combo_Pro.DisplayMember = "pro_name"
        Combo_Pro.ValueMember = "pro_id"
        combo_Worker.DataSource = EMP.fill_combo_emp()
        combo_Worker.DisplayMember = "emp_name"
        combo_Worker.ValueMember = "emp_id"
    End Sub
    Public Sub fill_Gridview()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = EMP.get_all_workerPay()
        Grid_Worker.DataSource = dt
    End Sub
    Sub clear_txt()
        TXT_id.Text = ""
        txt_mony.Text = ""
        Date_Pay.Text = ""
        txt_note.Text = ""
        Combo_Pro.Text = ""
        combo_Worker.Text = ""
    End Sub

    Sub setv(ByVal x As Boolean)
        txt_mony.Enabled = x
        txt_note.Enabled = x
        Date_Pay.Enabled = x
        Combo_Pro.Enabled = x
        combo_Worker.Enabled = x
    End Sub

    Private Sub Workers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySub()
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If TXT_id.Text Is String.Empty Or txt_mony.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        EMP.Add_Worker_bills(Convert.ToInt16(TXT_id.Text), Convert.ToInt16(combo_Worker.SelectedValue), Convert.ToInt16(Combo_Pro.SelectedValue), txt_mony.Text, Date_Pay.DateTime, txt_note.Text, lbl_name.Text, Now)
        MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        setv(False)
        clear_txt()
        bt_save.Enabled = False
        bt_new.Enabled = True
        bt_edite.Enabled = False
    End Sub

    Private Sub bt_edite_Click(sender As Object, e As EventArgs) Handles bt_edite.Click
        If TXT_id.Text Is String.Empty Or txt_mony.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        EMP.Edite_Workers_Bills(Convert.ToInt16(TXT_id.Text), Convert.ToInt16(combo_Worker.SelectedValue), Convert.ToInt16(Combo_Pro.SelectedValue), txt_mony.Text, Date_Pay.DateTime, txt_note.Text, lbl_name.Text, Now)
        MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        clear_txt()
        setv(False)
        bt_save.Enabled = False
        bt_new.Enabled = True
        bt_edite.Enabled = False
    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub bt_new_Click(sender As Object, e As EventArgs) Handles bt_new.Click
        bt_edite.Enabled = False
        bt_save.Enabled = True
        clear_txt()
        setv(True)

        fill_txt_id()
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        setv(True)
        bt_edite.Enabled = True
        bt_save.Enabled = False
        Try
            TXT_id.Text = CStr(GridView1.GetFocusedRowCellValue("معرف الصرف"))
            txt_mony.Text = CStr(GridView1.GetFocusedRowCellValue("المبلغ"))
            txt_note.Text = CStr(GridView1.GetFocusedRowCellValue("ملاحظة"))
            Combo_Pro.Text = CStr(GridView1.GetFocusedRowCellValue("اسم المشروع"))
            combo_Worker.Text = CStr(GridView1.GetFocusedRowCellValue("أسم الموظف"))
            Date_Pay.Text = CStr(GridView1.GetFocusedRowCellValue("تاريخ الدفع"))
        Catch ex As Exception
            Return
            ' MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Emp_form.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Project_M.ShowDialog()
    End Sub

    Private Sub Workers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub txt_mony_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mony.KeyPress
        JustNumber(e)
    End Sub
End Class