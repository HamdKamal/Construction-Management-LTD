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

Public Class Frm_RESIPET
    Dim RES As CLS_Resipet = New CLS_Resipet()
    Dim PRD As ClS_project = New ClS_project()
    Dim LOG As New CLS_login
    Public id As Integer

    Sub OPE_SUM()
        ' Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        Dim dt1 As DataTable = New DataTable()
        dt = RES.GET_TOTAL_PRO
        dt1 = RES.GET_TOTAL_AREA
        Dim id As Double = Convert.ToDouble(dt.Rows(dt.Rows.Count - 1)(0))
        Dim id1 As Double = Convert.ToDouble(dt1.Rows(dt1.Rows.Count - 1)(0))
        TXT_TOTAL_pro.Text = id.ToString
        txt_total_area.Text = id1.ToString
        txt_total.Text = (id + id1).ToString
    End Sub

    Public Sub fill_Gridview()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        DAL.sqlconn.Open()
        Dim dt As DataTable = New DataTable()
        Dim dt1 As DataTable = New DataTable()
        dt = RES.GET_RES_PRO
        dt1 = RES.GET_RES_AREA
        Grid_PRO.DataSource = dt
        Grid_AREA.DataSource = dt1
    End Sub

    Public Sub fill_combo()
        Combo_Pro.DataSource = prd.fill_combo_proj()
        Combo_Pro.DisplayMember = "pro_name"
        Combo_Pro.ValueMember = "pro_id"
    End Sub
    Sub id_res_pro()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = RES.get_id_RES_PRO
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_ID.Text = id.ToString()
        Combo_pro.Focus()
    End Sub
    Sub id_res_area()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = RES.get_id_area
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_ID.Text = id.ToString()
        txt_name.Focus()
    End Sub
    Sub cleartext()
        TXT_ID.Text = ""
        TXT_MONY.Text = ""
        Date_PAY.Text = ""
        txt_note.Text = ""
        Combo_pro.Text = ""
        txt_name.Text = ""
        rd_area.Checked = False
        rd_pro.Checked = False
    End Sub

    Sub setv(ByVal x As Boolean)
        TXT_ID.Enabled = x
        txt_note.Enabled = x
        rd_area.Enabled = x
        rd_pro.Enabled = x
        TXT_MONY.Enabled = x
        Combo_pro.Enabled = x
        txt_name.Enabled = x
        Date_PAY.Enabled = x
    End Sub
    Private Sub Resipet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_name.Visible = False
        Combo_pro.Visible = False
        bt_save.Enabled = False
        bt_del.Enabled = False
        SimpleButton1.Enabled = False
        setv(False)
        lbl_name.Text = Form_Log.log_name
        fill_Gridview()
        OPE_SUM()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles bt_new.Click
        bt_del.Enabled = False
        bt_new.Enabled = False
        bt_save.Enabled = True
        txt_name.Visible = False
        rd_pro.Checked = False
        rd_area.Checked = False
        Combo_pro.Visible = False
        TXT_ID.Text = ""
        Combo_pro.Text = ""
        cleartext()
        setv(True)
    End Sub

    Private Sub rd_area_CheckedChanged(sender As Object, e As EventArgs) Handles rd_area.CheckedChanged
        Combo_pro.Visible = False
        txt_name.Visible = True
        TXT_ID.Text = ""
        id_res_area()
    End Sub

    Private Sub rd_pro_CheckedChanged(sender As Object, e As EventArgs) Handles rd_pro.CheckedChanged
        txt_name.Visible = False
        TXT_ID.Text = ""
        Combo_pro.Visible = True
        fill_combo()
        id_res_pro()
    End Sub

    Private Sub BT_BACK_Click(sender As Object, e As EventArgs) Handles BT_BACK.Click
        Dispose()
        Close()
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        Try
            If rd_area.Checked = True Then
                If TXT_MONY.Text Is String.Empty Or txt_name.Text Is String.Empty Then
                    MessageBox.Show("الرجاء ملء جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                RES.ADD_RES_AREA(Convert.ToInt16(TXT_ID.Text), txt_name.Text, TXT_MONY.Text, txt_note.Text, Date_PAY.DateTime, lbl_name.Text, Now)
            Else
                RES.ADD_RES_PRO(Convert.ToInt16(TXT_ID.Text), Convert.ToInt16(Combo_pro.SelectedValue).ToString, TXT_MONY.Text, txt_note.Text, Date_PAY.DateTime, lbl_name.Text, Now)
            End If
            MessageBox.Show("تم الحفظ ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
            OPE_SUM()
            fill_Gridview()
            cleartext()
            setv(False)
            TXT_ID.Text = ""
            Combo_pro.Visible = False
            txt_name.Visible = False
            rd_pro.Checked = False
            rd_area.Checked = False
            bt_save.Enabled = False
            bt_new.Enabled = True
            SimpleButton1.Enabled = True
        Catch ex As Exception
            Return
        End Try
      
    End Sub

    Private Sub bt_del_Click(sender As Object, e As EventArgs) Handles bt_del.Click
        bt_del.Enabled = False
        Try
            If TXT_ID.Text = "" Then
                MessageBox.Show("الرجاءإختيار معرف الدفعة المراد حذفها ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If rd_area.Checked = True Then
                RES.DEL_RES_AREA(Convert.ToInt16(TXT_ID.Text))
            ElseIf rd_pro.Checked = True Then
                RES.DEL_RES_PRO(Convert.ToInt16(TXT_ID.Text))
            End If
            MessageBox.Show("تم الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fill_Gridview()
            OPE_SUM()
            cleartext()
            setv(False)
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        setv(True)
        bt_del.Enabled = True
        bt_new.Enabled = True
        bt_save.Enabled = False
        Try
            rd_pro.Checked = True
            rd_area.Enabled = False
            Combo_pro.Visible = True
            Combo_pro.Enabled = True

            TXT_ID.Text = CStr(GridView1.GetFocusedRowCellValue("معرف الإيراد"))
            TXT_MONY.Text = CStr(GridView1.GetFocusedRowCellValue("المبلغ"))
            Combo_pro.Text = CStr(GridView1.GetFocusedRowCellValue("المشروع"))
            txt_note.Text = CStr(GridView1.GetFocusedRowCellValue("ملاحظة"))
            Date_PAY.Text = CStr(GridView1.GetFocusedRowCellValue("تاريخ الدفع"))
        Catch ex As Exception
            Return '
            MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GridView2_Click(sender As Object, e As EventArgs) Handles GridView2.Click
        setv(True)
        bt_del.Enabled = True
        bt_new.Enabled = True
        bt_save.Enabled = False
        Try
            rd_area.Checked = True
            Combo_pro.Enabled = False
            Combo_pro.Visible = False
            rd_area.Enabled = True
            txt_name.Visible = True
            txt_name.Enabled = True

            TXT_ID.Text = CStr(GridView2.GetFocusedRowCellValue("معرف الإيراد"))
            TXT_MONY.Text = CStr(GridView2.GetFocusedRowCellValue("المبلغ"))
            txt_name.Text = CStr(GridView2.GetFocusedRowCellValue("الجهة"))
            txt_note.Text = CStr(GridView2.GetFocusedRowCellValue("ملاحظة"))
            Date_PAY.Text = CStr(GridView2.GetFocusedRowCellValue("تاريخ الدفع"))
        Catch ex As Exception
            Return '
            MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Frm_RESIPET_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim TK As New TakeReport
        TK.Parameters("user").Value = Form_Log.LOG_ID
        TK.Parameters("P_serial").Value = Main_Form.lbl_serial.Text
        Reportin.DocumentViewer1.DocumentSource = TK
        Reportin.ShowDialog()
        Me.Cursor = Cursors.Default
        LOG.ADD_S_NO(Main_Form.lbl_serial.Text)
        Main_Form.lbl_serial.Text = " "
        Main_Form.S_NO()
    End Sub

    Private Sub TXT_MONY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MONY.KeyPress
        JustNumber(e)
    End Sub
End Class