Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class Res_Special
    Dim BILS As CLS_Bills = New CLS_Bills()
    Public con As SqlConnection = Nothing
    Public cmd, cmd1 As SqlCommand
    Sub MySub()
        lbl_name.Text = Form_Log.log_name
        setv(False)
        bt_edit.Enabled = False
        bt_save.Enabled = False
        FILL_COMBO()
        fill_Gridview()
    End Sub
    Sub ref_form()
        'Me.Show()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        MySub()
        Refresh()
    End Sub
   
    Public Sub fill_txt_id()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        DAL.sqlconn.Open()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = BILS.get_id_sbill()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        txt_id.Text = id.ToString()
        Combo_Sbill.Focus()
    End Sub
    Sub FILL_COMBO()
        Combo_Sbill.DataSource = BILS.fill_comb_Sbill()
        Combo_Sbill.DisplayMember = "Mbill_name"
        Combo_Sbill.ValueMember = "Mbill_id"
    End Sub
    Public Sub fill_Gridview()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        DAL.sqlconn.Open()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = BILS.get_all_sbill()
        Grid_sbills.DataSource = dt
    End Sub
    Sub cleartxt()
        txt_id.Text = ""
        txt_mony.Text = ""
        TXT_NOTE.Text = ""
        Combo_Sbill.Text = ""
        date_bills.Text = ""
    End Sub
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")> Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Add_Sbills.ShowDialog()
    End Sub

    Private Sub Res_Special_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySub()
    End Sub

    Sub setv(ByVal x As Boolean)
        txt_mony.Enabled = x
        TXT_NOTE.Enabled = x
        Combo_Sbill.Enabled = x
        date_bills.Enabled = x
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If txt_id.Text Is String.Empty Or txt_mony.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        BILS.ADD_Sbill(Convert.ToInt16(txt_id.Text), Convert.ToInt16(Combo_Sbill.SelectedValue), date_bills.DateTime, TXT_NOTE.Text, txt_mony.Text, lbl_name.Text, Now)
        MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        cleartxt()
        setv(False)
        bt_save.Enabled = False
        SimpleButton2.Enabled = True
        bt_edit.Enabled = False
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        If txt_id.Text Is String.Empty Or txt_mony.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        BILS.EDIT_SBILL(Convert.ToInt16(txt_id.Text), Convert.ToInt16(Combo_Sbill.SelectedValue), date_bills.DateTime, TXT_NOTE.Text, txt_mony.Text, lbl_name.Text, Now)
        MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        cleartxt()
        setv(False)
        bt_edit.Enabled = False
        bt_save.Enabled = False
        SimpleButton2.Enabled = True
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        setv(True)
        bt_edit.Enabled = False
        bt_save.Enabled = True
        cleartxt()
        fill_txt_id()
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        setv(True)
        bt_edit.Enabled = True
        bt_save.Enabled = False
        SimpleButton2.Enabled = True
        cleartxt()
        Try
            txt_id.Text = CStr(GridView1.GetFocusedRowCellValue("معرف الفاتورة"))
            txt_mony.Text = CStr(GridView1.GetFocusedRowCellValue("المبلغ"))
            TXT_NOTE.Text = CStr(GridView1.GetFocusedRowCellValue("ملاحظة"))
            Combo_Sbill.Text = CStr(GridView1.GetFocusedRowCellValue("نوع الفاتورة"))
            date_bills.Text = CStr(GridView1.GetFocusedRowCellValue("تاريخ الفاتورة"))
        Catch ex As Exception
            Return
            '    MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Res_Special_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub txt_mony_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mony.KeyPress
        JustNumber(e)
    End Sub
End Class