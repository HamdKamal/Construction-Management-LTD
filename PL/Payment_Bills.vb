Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports DevExpress.XtraEditors
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class Payment_Bills
    Dim BILS As CLS_Bills = New CLS_Bills()
    Public id5 As Integer
    Dim frm As New Bills_form()

    Sub mysub()
        filldatagrid()
        BT_pay.Enabled = False
        SimpleButton2.Enabled = False
        setv(False)
        lbl_name.Text = Form_Log.log_name
        GridView3.Columns(4).Visible = False
    End Sub
    Sub TXT_TOTAL_SUM()
        Dim da5 As SqlDataAdapter = New SqlDataAdapter()
        Dim d1 As DataTable = New DataTable()
        d1 = BILS.GET_TOTAL_MONEY(id5)
        Dim id As Double = Convert.ToDouble(d1.Rows(d1.Rows.Count - 1)(0))
        TXT_TOTAL.Text = id.ToString
    End Sub

    Sub fill_pro()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        Dim sql As String = "select * from BILLS"
        Dim CMD As SqlCommand = New SqlCommand(sql, DAL.sqlconn)
        Dim reader As SqlDataReader
        Try
            DAL.open()
            reader = CMD.ExecuteReader()
            While reader.Read
                Dim p_name As String = reader.Item("pro_name").ToString
                Combo_NAME.Items.Add(p_name)
            End While
        Catch ex As Exception
            Return
        End Try
    End Sub

    
    Sub COMB_ID()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        Dim sql As String = "select * from BILLS where pro_name = N'" & Combo_NAME.Text & "'"
        Dim CMD As SqlCommand = New SqlCommand(sql, DAL.sqlconn)
        Dim reader As SqlDataReader
        Try
            DAL.open()
            reader = CMD.ExecuteReader()
            While reader.Read
                id5 = CInt(reader.Item("BILL_id"))
                Dim da As SqlDataAdapter = New SqlDataAdapter()
                Dim dt As DataTable
                dt = BILS.get_mony_bills(id5)
                Grid_MONEY.DataSource = dt

                ''''''''''''''''''''
                TXT_TOTAL_SUM()
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
   
    Public Sub fill_txt_id()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = BILS.get_id_pay_bills
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_ID.Text = id.ToString()
        Combo_NAME.Focus()
    End Sub
    Sub cleartext()
        TXT_ID.Text = ""
        TXT_MONY.Text = ""
        Date_PAY.Text = ""
        Combo_PAY.Text = ""
    End Sub

    Sub setv(ByVal x As Boolean)
        TXT_MONY.Enabled = x
        Combo_NAME.Enabled = x
        Combo_PAY.Enabled = x
        Date_PAY.Enabled = x
    End Sub

    Public Sub filldatagrid()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable
        dt = BILS.GET_PayMENT_bills
        GRID_PAYMENTS.DataSource = dt
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Controls.Clear()
        InitializeComponent()
        mysub()
        Refresh()
        SimpleButton1.Enabled = False
        setv(True)
        cleartext()
        fill_pro()
        fill_txt_id()
        BT_pay.Enabled = True
        SimpleButton2.Enabled = False
    End Sub

    Private Sub Payment_Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TXT_TOTAL_SUM()
        mysub()
    End Sub

    Private Sub BT_BACK_Click(sender As Object, e As EventArgs) Handles BT_BACK.Click
        Dispose()
        Me.Close()
        Bills_form.ref_form()
        '   frm.ref_form()
    End Sub

    Private Sub Combo_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_NAME.SelectedIndexChanged

        COMB_ID() '
        BT_pay.Enabled = True
    End Sub

    Private Sub BT_pay_Click(sender As Object, e As EventArgs) Handles BT_pay.Click
        Try
            If TXT_MONY.Text Is String.Empty Or Combo_NAME.Text Is String.Empty Or Combo_PAY.Text Is String.Empty Then
                MessageBox.Show("الرجاء ملء جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            TXT_MONY_Validated(sender, e)
            BILS.update_paid_pay(id5, TXT_MONY.Text)
            st = " تم سداد مبلغ قدره  '" & TXT_MONY.Text & "'  كـ  '" & Combo_PAY.Text & "'"
            BILS.Add_pay_bills(Convert.ToInt16(TXT_ID.Text), id5, TXT_MONY.Text, st, Date_PAY.DateTime, lbl_name.Text, Now, Combo_PAY.Text)
            MessageBox.Show("تم السداد ", "عملية الدفع", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXT_TOTAL_SUM()
            COMB_ID()
            filldatagrid()
            SimpleButton1.Enabled = True

            BT_pay.Enabled = False
            cleartext()
            setv(False)
        Catch ex As Exception
            Return
        End Try
        frm.Refresh()
    End Sub

  

    Private Sub GridView3_Click(sender As Object, e As EventArgs) Handles GridView3.Click
        setv(True)
        SimpleButton1.Enabled = False
        SimpleButton2.Enabled = True
        BT_pay.Enabled = False

        Try
            TXT_ID.Text = CStr(GridView3.GetFocusedRowCellValue("معرف الدفعة"))
            TXT_MONY.Text = CStr(GridView3.GetFocusedRowCellValue("المبلغ"))
            Combo_NAME.Text = CStr(GridView3.GetFocusedRowCellValue("الجهة"))
            Combo_PAY.Text = CStr(GridView3.GetFocusedRowCellValue("الدفعة"))
            Date_PAY.Text = CStr(GridView3.GetFocusedRowCellValue("تاريخ الدفع"))
            COMB_ID()
        Catch ex As Exception
            Return
            '      MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub TXT_MONY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MONY.KeyPress
        JustNumber(e)
    End Sub

    Private Sub TXT_MONY_Validated(sender As Object, e As EventArgs) Handles TXT_MONY.Validated
        If TXT_MONY.Text = "" Then
            Return
        Else
            Dim dt As DataTable = New DataTable()
            dt = BILS.MONEY_CONFIQ(id5, CDbl(TXT_MONY.Text).ToString)

            If dt.Rows.Count > 0 Then
                MessageBox.Show("المبلغ المدفوع أكبر من المتبقي", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TXT_MONY.Focus()
                TXT_MONY.SelectionStart = 0
                Return
            End If
        End If
    End Sub

    Private Sub Payment_Bills_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            If TXT_ID.Text = "" Then
                MessageBox.Show("الرجاءإختيار معرف الدفعة المراد حذفها ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            BILS.update_paid_pay_case_del(id5, TXT_MONY.Text)
            BILS.DELETE_PAY_BILS(Convert.ToInt16(TXT_ID.Text))
            MessageBox.Show("تم حذف بيانات الدفعة  ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXT_TOTAL_SUM()
            COMB_ID()
            filldatagrid()
            SimpleButton1.Enabled = False

            BT_pay.Enabled = False
            cleartext()
            setv(False)
        Catch ex As Exception
            Return
        End Try
        frm.Refresh()
    End Sub
End Class