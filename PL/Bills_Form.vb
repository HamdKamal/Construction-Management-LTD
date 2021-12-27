Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class Bills_form
    Dim BILS As CLS_Bills = New CLS_Bills()
    Dim prd As ClS_project = New ClS_project()

    Sub MySub()
        setv(False)
        fill_Gridview()
        cleartext()
        SimpleButton1.Enabled = False
        BT_EDITE.Enabled = False
        lbl_name.Text = Form_Log.log_name
    End Sub

    Sub ref_form()
        Me.Show()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        MySub()
        Refresh()
    End Sub

    Sub cleartext()
        txt_id.Text = ""
        txt_left.Text = ""
        txt_note.Text = ""
        txt_paid.Text = ""
        txt_total.Text = ""
        Date_pay.Text = ""
        Combo_MAIN.Text = ""
        Combo_pro.Text = ""
    End Sub
    Public Sub fill_txt_id()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        DAL.sqlconn.Open()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = BILS.get_id_bills()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        txt_id.Text = id.ToString()
        Combo_pro.Focus()
    End Sub
    Public Sub fill_Gridview()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        DAL.sqlconn.Open()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = BILS.GET_ALL_BILL()
        Grid_BILLS.DataSource = dt
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Sub setv(ByVal key As Boolean)
        txt_total.Enabled = key
        txt_paid.Enabled = key
        txt_note.Enabled = key
        txt_left.Enabled = key
        Combo_MAIN.Enabled = key
        Combo_pro.Enabled = key
        Date_pay.Enabled = key
    End Sub

    Private Sub Bills_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySub()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txt_id.Text Is String.Empty Or txt_paid.Text Is String.Empty Or txt_total.Text Is String.Empty Or Combo_MAIN.Text Is String.Empty Or Combo_pro.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        BILS.Add_bills(Convert.ToInt16(txt_id.Text), txt_note.Text, Combo_MAIN.Text, Combo_pro.Text, txt_total.Text, txt_paid.Text, txt_left.Text, Date_pay.DateTime, lbl_name.Text, Now)
        MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        setv(False)
        fill_Gridview()
        cleartext()
        SimpleButton1.Enabled = False
        SimpleButton4.Enabled = True
        BT_EDITE.Enabled = False
    End Sub

    Private Sub GridView2_Click(sender As Object, e As EventArgs) Handles GridView2.Click
        setv(True)
        SimpleButton1.Enabled = False
        BT_EDITE.Enabled = True
        SimpleButton4.Enabled = True
        Try
            cleartext()
            txt_id.Text = CStr(GridView2.GetFocusedRowCellValue("معرف الفاتورة"))
            txt_left.Text = CStr(GridView2.GetFocusedRowCellValue("المبلغ المتبقي"))
            txt_paid.Text = CStr(GridView2.GetFocusedRowCellValue("المبلغ المدفوع"))
            txt_total.Text = CStr(GridView2.GetFocusedRowCellValue("المبلغ الكلي"))
            txt_note.Text = CStr(GridView2.GetFocusedRowCellValue("ملاحظة"))
            Combo_pro.Text = CStr(GridView2.GetFocusedRowCellValue("إسم الجهة"))
            Date_pay.Text = CStr(GridView2.GetFocusedRowCellValue("تاريخ الدفع"))
            Combo_MAIN.Text = CStr(GridView2.GetFocusedRowCellValue("نوع الفاتورة"))
        Catch ex As Exception
            Return '
            ' MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        setv(True)
        txt_left.Text = ""
        txt_note.Text = ""
        txt_paid.Text = ""
        txt_total.Text = ""
        Date_pay.Text = ""
        Combo_MAIN.Text = ""
        Combo_pro.Text = ""
        fill_txt_id()
        SimpleButton1.Enabled = True
        BT_EDITE.Enabled = False
        SimpleButton4.Enabled = False
        txt_paid.Text = "0"
    End Sub

    Private Sub txt_total_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_total.KeyUp
        Try
            Dim tot As Decimal = Convert.ToDecimal(txt_total.Text)
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
        Try
            Dim tot As Decimal = Convert.ToDecimal(txt_total.Text)
            Dim Amount As Decimal = Convert.ToDecimal(txt_paid.Text)
            Dim left As Decimal = tot - Amount
            txt_left.Text = left.ToString
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub BT_EDITE_Click(sender As Object, e As EventArgs) Handles BT_EDITE.Click
        If txt_id.Text Is String.Empty Or txt_paid.Text Is String.Empty Or txt_total.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        BILS.edite_bills1(Convert.ToInt16(txt_id.Text), txt_note.Text, Combo_MAIN.Text, Combo_pro.Text, txt_total.Text, txt_paid.Text, txt_left.Text, Date_pay.DateTime, lbl_name.Text, Now)
        MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        setv(False)
        fill_Gridview()
        cleartext()
        SimpleButton1.Enabled = False
        BT_EDITE.Enabled = False
        SimpleButton4.Enabled = True
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Hide()
        Payment_Bills.ShowDialog()
    End Sub

    Private Sub Bills_form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

 
    Private Sub txt_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total.KeyPress
        JustNumber(e)
    End Sub
End Class



