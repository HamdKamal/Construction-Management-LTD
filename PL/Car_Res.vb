Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class Car_Res
    Dim BILS As CLS_Bills = New CLS_Bills()

    Sub MySub()
        lbl_name.Text = Form_Log.log_name
        setv(False)
        fill_Gridview()
        fill_combo()
        cleartext()
        bt_save.Enabled = False
        bt_edit.Enabled = False
    End Sub
    Sub ref_form()
        ' Me.Show()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        MySub()
        Refresh()
    End Sub

    Sub cleartext()
        txt_id.Text = ""
        txt_note.Text = ""
        txt_mony.Text = ""
        Date_pay.Text = ""
        Combo_Car.Text = ""
        Combo_Pay.Text = ""
    End Sub
    Public Sub fill_txt_id()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        DAL.sqlconn.Open()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = BILS.get_id_carbills()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_id.Text = id.ToString()
        Combo_Car.Focus()
    End Sub
    Public Sub fill_combo()
        Combo_Car.DataSource = BILS.fill_combo_car()
        Combo_Car.DisplayMember = "car_name"
        Combo_Car.ValueMember = "car_id"
        Combo_Pay.DataSource = BILS.Fill_combo_maintance()
        Combo_Pay.DisplayMember = "mainten_name"
        Combo_Pay.ValueMember = "mainten_id"
    End Sub
    Public Sub fill_Gridview()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = BILS.get_all_Car_Bills()
        Grid_Car.DataSource = dt
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Hide()
        ADD_CARS.ShowDialog()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'Hide()
        Add_Maintaence.ShowDialog()
    End Sub
    Sub setv(ByVal s As Boolean)
        txt_mony.Enabled = s
        txt_note.Enabled = s
        Combo_Car.Enabled = s
        Combo_Pay.Enabled = s
        Date_pay.Enabled = s
    End Sub
    Private Sub Car_Res_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySub()
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If txt_id.Text Is String.Empty Or txt_mony.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        BILS.Add_Carbills(Convert.ToInt16(txt_id.Text), Convert.ToInt16(Combo_Car.SelectedValue), Convert.ToInt16(Combo_Pay.SelectedValue), Convert.ToDateTime(Date_pay.Text), txt_mony.Text, txt_note.Text, lbl_name.Text, Now)
        MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        cleartext()
        setv(False)
        bt_save.Enabled = False
        bt_edit.Enabled = False
        SimpleButton3.Enabled = True
    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        If txt_id.Text Is String.Empty Or txt_mony.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        BILS.EDIT_CARBILLS(Convert.ToInt16(txt_id.Text), Convert.ToInt16(Combo_Car.SelectedValue), Convert.ToInt16(Combo_Pay.SelectedValue), Convert.ToDateTime(Date_pay.Text), txt_mony.Text, txt_note.Text, lbl_name.Text, Now)
        MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        cleartext()
        setv(False)
        bt_save.Enabled = False
        bt_edit.Enabled = False
        SimpleButton3.Enabled = True
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        setv(True)
        cleartext()
        fill_txt_id()
        SimpleButton3.Enabled = False
        bt_save.Enabled = True
        bt_edit.Enabled = False
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        setv(True)
        Try
            bt_edit.Enabled = True
            bt_save.Enabled = False
            SimpleButton3.Enabled = True
            cleartext()
            txt_id.Text = CStr(GridView1.GetFocusedRowCellValue("الرقم"))
            txt_mony.Text = CStr(GridView1.GetFocusedRowCellValue("المبلغ"))
            txt_note.Text = CStr(GridView1.GetFocusedRowCellValue("ملاحظات"))
            Combo_Car.Text = CStr(GridView1.GetFocusedRowCellValue("نوع السيارة"))
            Date_pay.Text = CStr(GridView1.GetFocusedRowCellValue("تاريخ الصرف"))
            Combo_Pay.Text = CStr(GridView1.GetFocusedRowCellValue("نوع الصرف"))
        Catch ex As Exception
            Return '
            MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Car_Res_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub txt_mony_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mony.KeyPress
        JustNumber(e)
    End Sub
End Class


