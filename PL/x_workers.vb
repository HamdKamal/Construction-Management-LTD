Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class x_workers
    Dim EMP As ClS_employes = New ClS_employes()
    Dim BILS As CLS_Bills = New CLS_Bills()
    Dim prd As ClS_project = New ClS_project()
    Sub MYSUB()
        lbl_name.Text = Form_Log.log_name
        BT_DEL.Enabled = False
        BT_EDITE.Enabled = False
        BT_SAVE.Enabled = False
        setv(False)
        fill_combo()
        filldatagrid()
    End Sub
    Sub ref_form()
        Me.Show()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        MySub()
        Refresh()
    End Sub

    Public Sub fill_txt_id()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = EMP.GET_ID_X_WORKER()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_id.Text = id.ToString()
        Combo_PRO.Focus()
    End Sub
    Public Sub fill_combo()
        Combo_main.DataSource = prd.fill_comb_mainCat()
        Combo_main.DisplayMember = "cat_name"
        Combo_main.ValueMember = "cat_id"
        Combo_SUP.DataSource = prd.fill_combo_sub()
        Combo_SUP.DisplayMember = "sub_name"
        Combo_SUP.ValueMember = "sub_id"
        Comb_xname.DataSource = EMP.fill_combo_xname()
        Comb_xname.DisplayMember = "x_name"
        Comb_xname.ValueMember = "x_id"

    End Sub
    Public Sub filldatagrid()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = EMP.get_all_xworker()
        Grid_X_WORKER.DataSource = dt
    End Sub
    Sub CLEAE_TXT()
        TXT_ID.Text = ""
        TXT_MONY.Text = ""
        Comb_xname.Text = ""
        Combo_MAIN.Text = ""
        Combo_PRO.Text = ""
        Combo_SUP.Text = ""
        Date_pay.Text = ""
        txt_left.Text = ""
        txt_paid.Text = ""
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Me.Hide()
        payments.ShowDialog()
    End Sub

    Sub setv(ByVal x As Boolean)
        TXT_MONY.Enabled = x
        Comb_xname.Enabled = x
        Combo_MAIN.Enabled = x
        Combo_PRO.Enabled = x
        Combo_SUP.Enabled = x
        Date_pay.Enabled = x
        txt_paid.Enabled = x
        txt_left.Enabled = x
    End Sub

    Private Sub x_workers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MYSUB()
    End Sub

    Private Sub BT_SAVE_Click(sender As Object, e As EventArgs) Handles BT_SAVE.Click
        If TXT_ID.Text Is String.Empty Or TXT_MONY.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        EMP.Add_xworker(Convert.ToInt16(TXT_ID.Text), Combo_PRO.Text, Convert.ToInt16(Comb_xname.SelectedValue), Convert.ToInt16(Combo_MAIN.SelectedValue), Convert.ToInt16(Combo_SUP.SelectedValue), TXT_MONY.Text, Date_pay.DateTime, lbl_name.Text, Now, txt_paid.Text, txt_left.Text)
        MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        filldatagrid()
        CLEAE_TXT()
        setv(True)

        BT_DEL.Enabled = False
        BT_EDITE.Enabled = False
        BT_SAVE.Enabled = False
        SimpleButton2.Enabled = True

    End Sub

    Private Sub BT_EDITE_Click(sender As Object, e As EventArgs) Handles BT_EDITE.Click
        If TXT_ID.Text Is String.Empty Or TXT_MONY.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        EMP.EDIT_Xworker(Convert.ToInt16(TXT_ID.Text), Combo_PRO.Text, Convert.ToInt16(Comb_xname.SelectedValue), Convert.ToInt16(Combo_MAIN.SelectedValue), Convert.ToInt16(Combo_SUP.SelectedValue), TXT_MONY.Text, Date_pay.DateTime, lbl_name.Text, Now, txt_paid.Text, txt_left.Text)
        MessageBox.Show("تم التعديل بنجاح", "عمليةالتعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        filldatagrid()
        setv(False)

        CLEAE_TXT()
        BT_DEL.Enabled = False
        BT_EDITE.Enabled = False
        BT_SAVE.Enabled = False
        SimpleButton2.Enabled = True
    End Sub

    Private Sub BT_DEL_Click(sender As Object, e As EventArgs) Handles BT_DEL.Click
        If TXT_ID.Text Is String.Empty Or TXT_MONY.Text Is String.Empty Then
            MsgBox(" قم بإدخال المعرف  ")
            Return
        End If
        EMP.Delet_Xworker(Convert.ToInt16(TXT_ID.Text))
        MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
        filldatagrid()
        CLEAE_TXT()
        BT_DEL.Enabled = False
        BT_EDITE.Enabled = False
        BT_SAVE.Enabled = False
        SimpleButton2.Enabled = True
    End Sub
    Private Sub BT_BACK_Click(sender As Object, e As EventArgs) Handles BT_BACK.Click
        Me.Dispose()
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Hide()
        Add_xName.ShowDialog()

    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        setv(True)
        CLEAE_TXT()
        fill_txt_id()
        BT_DEL.Enabled = False
        BT_EDITE.Enabled = False
        BT_SAVE.Enabled = True
        SimpleButton1.Enabled = True
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        setv(True)
        BT_SAVE.Enabled = False
        BT_EDITE.Enabled = True
        BT_DEL.Enabled = True
        Try
            CLEAE_TXT()
            TXT_ID.Text = CStr(GridView1.GetFocusedRowCellValue("معرف البند"))
            TXT_MONY.Text = CStr(GridView1.GetFocusedRowCellValue("المبلغ"))
            Comb_xname.Text = CStr(GridView1.GetFocusedRowCellValue("إسم مقاول الباطن"))
            Combo_SUP.Text = CStr(GridView1.GetFocusedRowCellValue("نوع العمل"))
            Combo_PRO.Text = CStr(GridView1.GetFocusedRowCellValue("إسم المشروع"))
            Combo_MAIN.Text = CStr(GridView1.GetFocusedRowCellValue("البند"))
            Date_pay.Text = CStr(GridView1.GetFocusedRowCellValue("تاريخ الدفع"))
            txt_paid.Text = CStr(GridView1.GetFocusedRowCellValue("المبلغ المدفوع"))
            txt_left.Text = CStr(GridView1.GetFocusedRowCellValue("المبلغ المتبقي"))

        Catch ex As Exception
            Return
            'MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        main_item.ShowDialog()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        sub_item.ShowDialog()
    End Sub

    Private Sub x_workers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub TXT_MONY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MONY.KeyPress
        JustNumber(e)
    End Sub

    Private Sub TXT_MONY_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_MONY.KeyUp
        Try
            Dim tot As Decimal = Convert.ToDecimal(TXT_MONY.Text)
            Dim Amount As Decimal = Convert.ToDecimal(txt_paid.Text)
            Dim left As Decimal = tot - Amount
            txt_left.Text = left.ToString
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub txt_paid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_paid.KeyPress
        JustNumber(e)
    End Sub

    Private Sub txt_paid_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_paid.KeyUp
        'Try
        '    Dim tot As Double = Convert.ToDouble(TXT_MONY.Text)
        '    Dim Amount As Double = Convert.ToDouble(txt_paid.Text)
        '    Dim left As Double = tot - Amount
        '    txt_left.Text = left.ToString
        'Catch ex As Exception
        '    Return
        'End Try
        Try
            Dim tot As Decimal = Convert.ToDecimal(TXT_MONY.Text)
            Dim Amount As Decimal = Convert.ToDecimal(txt_paid.Text)
            Dim left As Decimal = tot - Amount
            txt_left.Text = left.ToString
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class