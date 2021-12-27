Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class payments
    Dim EMP As ClS_employes = New ClS_employes()
    Dim BILS As CLS_Bills = New CLS_Bills()
    Dim prd As ClS_project = New ClS_project()
    Public id, id1, ID2 As Integer

    Sub TXT_TOTAL_SUM()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = BILS.GET_TOTAL_PAYMENT(id1, Combo_pro.Text)
        Dim id As Double = Convert.ToDouble(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_TOTAL.Text = id.ToString
    End Sub

    Sub fill_CO_TYPE()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()

        Dim sql As String = "select * from sub_category"
        Dim CMD As SqlCommand = New SqlCommand(sql, DAL.sqlconn)
        Dim reader As SqlDataReader
        Try
            DAL.open()
            reader = CMD.ExecuteReader()
            While reader.Read
                Dim p_name As String = reader.Item("sub_name").ToString
                Combo_TYPE.Items.Add(p_name)
            End While
        Catch ex As Exception
            Return
        End Try
    End Sub
    Sub COMB_S_ID()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        Dim sql As String = "select * from sub_category where sub_name = N'" & Combo_TYPE.Text & "'"
        Dim CMD As SqlCommand = New SqlCommand(sql, DAL.sqlconn)
        Dim reader As SqlDataReader
        Try
            DAL.open()
            reader = CMD.ExecuteReader()
            While reader.Read
                id2 = CInt(reader.Item("sub_id"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub fill_pro()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()

        Dim sql As String = "select * from x_work_info"
        Dim CMD As SqlCommand = New SqlCommand(sql, DAL.sqlconn)
        Dim reader As SqlDataReader
        Try
            DAL.open()
            reader = CMD.ExecuteReader()
            While reader.Read
                Dim p_name As String = reader.Item("x_name").ToString
                Combo_NAME.Items.Add(p_name)
            End While
        Catch ex As Exception
            Return
        End Try
    End Sub
    Sub COMB_x_ID()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        Dim sql As String = "select * from x_work_info where x_name = N'" & Combo_NAME.Text & "'"
        Dim CMD As SqlCommand = New SqlCommand(sql, DAL.sqlconn)
        Dim reader As SqlDataReader
        Try
            DAL.open()
            reader = CMD.ExecuteReader()
            While reader.Read
                id1 = CInt(reader.Item("x_id"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub COMB_ID()
        Dim dt As DataTable
        dt = BILS.GET_MONEY_X_WORKER(id1, Combo_pro.Text, ID2)
        Grid_MONEY.DataSource = dt
    End Sub
    Public Sub fill_txt_id()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = EMP.GET_ID_PAYMENT()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_id.Text = id.ToString()
        Combo_NAME.Focus()
    End Sub
    Public Sub fill_combo_xworker()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        Dim sql As String = "select * from projects"
        Dim CMD As SqlCommand = New SqlCommand(sql, DAL.sqlconn)
        Dim reader As SqlDataReader
        Try
            DAL.open()
            reader = CMD.ExecuteReader()
            While reader.Read
                Dim p_name As String = reader.Item("pro_name").ToString
                Combo_pro.Items.Add(p_name)
            End While
        Catch ex As Exception
            Return
        End Try
    End Sub
    Public Sub filldatagrid()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable
        dt = EMP.get_all_payment()
        Grid_PAYMENT.DataSource = dt
        GridView2.Columns(4).Visible = False
    End Sub
    Sub cleartext()
        TXT_ID.Text = ""
        TXT_MONY.Text = ""
        Date_PAY.Text = ""
        Combo_NAME.Text = ""
        Combo_PAY.Text = ""
        Combo_pro.Text = ""
    End Sub

    Sub setv(ByVal x As Boolean)
        TXT_MONY.Enabled = x
        Combo_NAME.Enabled = x
        Combo_PAY.Enabled = x
        Combo_pro.Enabled = x
        Date_PAY.Enabled = x
        Combo_TYPE.Enabled = x
    End Sub

    Private Sub payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TXT_TOTAL_SUM()
        Combo_NAME.Text = ""
        Combo_pro.Text = ""
        lbl_name.Text = Form_Log.log_name
        cleartext()
        setv(False)
        filldatagrid()
        BT_SAVE.Enabled = False
        BT_EDITE.Enabled = False
        TXT_TOTAL.Text = "0.00"
    End Sub
    Private Sub BT_SAVE_Click(sender As Object, e As EventArgs) Handles BT_SAVE.Click
        'SimpleButton1.Enabled = True
        If TXT_ID.Text Is String.Empty Or TXT_MONY.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        TXT_MONY_Validated(sender, e)
        BILS.update_paid_X_WORKER(id1, ID2, Combo_pro.Text, TXT_MONY.Text)
        st = " تم سداد مبلغ قدره  '" & TXT_MONY.Text & "'  كـ  '" & Combo_PAY.Text & "'"
        BILS.Add_payment_2(Convert.ToInt16(TXT_ID.Text), id1, Combo_pro.Text, ID2, Combo_PAY.Text, TXT_MONY.Text, Date_PAY.DateTime, lbl_name.Text, Now, st)
        MessageBox.Show("تم السداد", "عملية الدفع", MessageBoxButtons.OK, MessageBoxIcon.Information)
        filldatagrid()
        TXT_TOTAL_SUM()
        COMB_ID()
        cleartext()
        setv(False)
        BT_SAVE.Enabled = False
        SimpleButton1.Enabled = True
    End Sub
  
    Private Sub BT_BACK_Click(sender As Object, e As EventArgs) Handles BT_BACK.Click
        Me.Dispose()
        Me.Close()
        x_workers.ref_form()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Controls.Clear()
        InitializeComponent()
        TXT_TOTAL_SUM()
        fill_CO_TYPE()
        fill_pro()
        setv(True)
        BT_SAVE.Enabled = True
        BT_EDITE.Enabled = False
        cleartext()
        fill_txt_id()
        fill_combo_xworker()
        filldatagrid()
    End Sub

    Private Sub GridView2_Click(sender As Object, e As EventArgs) Handles GridView2.Click
        setv(True)
        SimpleButton1.Enabled = False
        BT_EDITE.Enabled = True
        BT_SAVE.Enabled = False
        VISIBLE_TOOL()
        Try
            TXT_ID.Text = CStr(GridView2.GetFocusedRowCellValue("معرف الدفعة"))
            TXT_MONY.Text = CStr(GridView2.GetFocusedRowCellValue("المبلغ المدفوع"))
            Combo_NAME.Text = CStr(GridView2.GetFocusedRowCellValue("إسم مقاول الباطن"))
            Combo_PAY.Text = CStr(GridView2.GetFocusedRowCellValue("الدفعة"))
            Combo_pro.Text = CStr(GridView2.GetFocusedRowCellValue("المشروع"))
            Date_PAY.Text = CStr(GridView2.GetFocusedRowCellValue("تاريخ الدفع"))
            Combo_TYPE.Text = CStr(GridView2.GetFocusedRowCellValue("نوع العمل"))

        Catch ex As Exception
            Return
            '  MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Project_M.ShowDialog()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Add_xName.ShowDialog()
    End Sub

    Private Sub payments_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub Combo_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_NAME.SelectedIndexChanged
        COMB_x_ID()
        COMB_ID()
        COMB_S_ID()
        TXT_TOTAL_SUM()
    End Sub

    Private Sub Combo_pro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_pro.SelectedIndexChanged
        COMB_ID()
        COMB_x_ID()
        COMB_S_ID()
        TXT_TOTAL_SUM()
    End Sub
    Private Sub Combo_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_TYPE.SelectedIndexChanged
        COMB_S_ID()
        COMB_ID()
        COMB_x_ID()
        VISIBLE_TOOL()
    End Sub
    Sub VISIBLE_TOOL()
        Combo_PAY.Visible = True
        Date_PAY.Visible = True
        TXT_MONY.Visible = True
        LabelControl1.Visible = True
        LabelControl3.Visible = True
        LabelControl6.Visible = True
    End Sub

    Private Sub TXT_MONY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MONY.KeyPress
        JustNumber(e)
    End Sub
   
    Private Sub TXT_MONY_Validated(sender As Object, e As EventArgs) Handles TXT_MONY.Validated
        If TXT_MONY.Text = "" Then
            Return
        Else
            Dim dt As DataTable = New DataTable()
            dt = BILS.MONEY_X__CONFIQ(id1, ID2, Combo_pro.Text, CDbl(TXT_MONY.Text).ToString)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("المبلغ المدفوع أكبر من المتبقي", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TXT_MONY.Focus()
                TXT_MONY.SelectionStart = 0
                Return
            End If
        End If
    End Sub

    Private Sub BT_EDITE_Click(sender As Object, e As EventArgs) Handles BT_EDITE.Click
        Try
            If TXT_ID.Text = "" Then
                MessageBox.Show("الرجاءإختيار معرف الدفعة المراد حذفها ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            BILS.update_X_paid_pay_case_del(id1, ID2, Combo_pro.Text, TXT_MONY.Text)
            BILS.DELET_PAYMENT(Convert.ToInt16(TXT_ID.Text))
            MessageBox.Show("تم حذف بيانات الدفعة  ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXT_TOTAL_SUM()
            COMB_ID()
            filldatagrid()
            SimpleButton1.Enabled = False
            BT_SAVE.Enabled = False
            cleartext()
            setv(False)
        Catch ex As Exception
            Return
        End Try
    End Sub
End Class