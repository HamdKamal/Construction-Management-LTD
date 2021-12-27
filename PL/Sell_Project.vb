Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class Sell_Project
    Dim BILS As CLS_Bills = New CLS_Bills()
    Dim prd As ClS_project = New ClS_project()
    Dim bmb As BindingManagerBase
    Dim dt As DataTable = New DataTable()
    Public id As Integer

    Sub MYSUB()
        lbl_name.Text = Form_Log.log_name
        bt_edite.Enabled = False
        bt_save.Enabled = False
        fill_combo()
        fill_pro()
        fill_Gridview()
        setv(False)
    End Sub
    Sub ref_form()
        ' Me.Show()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        MySub()
        Refresh()
    End Sub
    Public Sub fill_txt_id()
        Dim dt As DataTable = New DataTable()
        dt = BILS.grt_id_buildbills()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        txt_id.Text = id.ToString()
        Combo_main.Focus()
    End Sub
    Public Sub fill_combo()
        Combo_main.DataSource = prd.fill_comb_mainCat()
        Combo_main.DisplayMember = "cat_name"
        Combo_main.ValueMember = "cat_id"
        Combo_sub.DataSource = prd.fill_combo_sub()
        Combo_sub.DisplayMember = "sub_name"
        Combo_sub.ValueMember = "sub_id"
    End Sub
    Sub fill_pro()
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
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Clear_TXT()
        txt_id.Text = ""
        txt_unit.Text = ""
        txt_Qun.Text = ""
        txt_price.Text = ""
        txt_owner.Text = ""
        txt_note.Text = ""
        txt_location.Text = ""
        Date_pay.Text = ""
        Combo_main.Text = ""
        Combo_pro.Text = ""
        Combo_sub.Text = ""
        lbl_total.Text = "0.00"
        lbl_Plus.Text = "0.00"
        lbl_money.Text = "0.00"
    End Sub
    Public Sub fill_Gridview()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = prd.get_all_buildbills()
        Grid_build.DataSource = dt
    End Sub
    Sub GET_TYPE()
        If lbl_money.Text = lbl_total.Text Then
            RD_not.Checked = True
        End If
        If lbl_money.Text <> lbl_total.Text Then
            RD_be.Checked = True
        End If
    End Sub

    Private Sub Sell_Project_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MYSUB()
    End Sub

    Sub setv(ByVal x As Boolean)
        txt_location.Enabled = x
        txt_Qun.Enabled = x
        txt_unit.Enabled = x
        txt_price.Enabled = x
        txt_note.Enabled = x
        txt_owner.Enabled = x
        Combo_main.Enabled = x
        Combo_pro.Enabled = x
        Combo_sub.Enabled = x
        Date_pay.Enabled = x
        RD_be.Enabled = x
        RD_not.Enabled = x
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        main_item.ShowDialog()
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        sub_item.ShowDialog()
    End Sub
    Private Sub TextEdit5_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_price.KeyUp
        Try
            If RD_be.Checked = True Then
                Dim amount As Decimal = CDec(txt_price.Text)
                lbl_total.Text = CStr(amount + amount * 5 / 100)
                lbl_Plus.Text = CStr(amount * 5 / 100)
                lbl_money.Text = txt_price.Text.ToString
            Else
                Dim amount As Decimal = CDec(txt_price.Text)
                lbl_total.Text = CStr(amount + amount * 0 / 100)
                lbl_Plus.Text = CStr(amount * 0 / 100)
                lbl_money.Text = txt_price.Text.ToString
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub txt_Qun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Qun.KeyPress
        JustNumber(e)
    End Sub
    Private Sub TextEdit4_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Qun.KeyUp
        Try
            If RD_be.Checked = True Then
                txt_price.Text = CStr(CDec(txt_unit.Text) * CDec(txt_Qun.Text))
                Dim amount As Decimal = CDec(txt_price.Text)
                lbl_total.Text = CStr(amount + amount * 5 / 100)
                lbl_Plus.Text = CStr(amount * 5 / 100)
                lbl_money.Text = CStr(CDec(txt_unit.Text) * CDec(txt_Qun.Text))
                Return
            Else
                txt_price.Text = CStr(CDec(txt_unit.Text) * CDec(txt_Qun.Text))
                Dim amount As Decimal = CDec(txt_price.Text)
                lbl_total.Text = CStr(amount + amount * 0 / 100)
                lbl_Plus.Text = CStr(amount * 0 / 100)
                lbl_money.Text = CStr(CDec(txt_unit.Text) * CDec(txt_Qun.Text))
                Return
            End If
        Catch ex As Exception
            Return
            ' MsgBox("الرجاء إدخال القيم بصورة صحيحة")
        End Try
    End Sub
    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        Me.Dispose()
        Me.Close()
    End Sub

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")>
    Private Sub Combo_pro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_pro.SelectedIndexChanged
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        Dim sql As String = "select * from projects where pro_name = N'" & Combo_pro.Text & "'"
        Dim CMD As SqlCommand = New SqlCommand(sql, DAL.sqlconn)
        Dim reader As SqlDataReader
        Try
            DAL.open()
            reader = CMD.ExecuteReader()

            While reader.Read
                Dim p_loc As String = reader.GetString(2)
                Dim p_owner As String = reader.GetString(3)
                txt_location.Text = p_loc
                txt_owner.Text = p_owner

                id = CInt(reader.Item("pro_id"))

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If txt_id.Text Is String.Empty Or txt_Qun.Text Is String.Empty Or txt_unit.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        prd.ADD_BUILD_BILLS(Convert.ToInt16(txt_id.Text), id, Convert.ToInt16(Combo_sub.SelectedValue), txt_Qun.Text, txt_unit.Text, txt_price.Text, Date_pay.DateTime, txt_note.Text, lbl_total.Text, lbl_Plus.Text, Convert.ToInt16(Combo_main.SelectedValue), lbl_name.Text, Now)
        MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        setv(False)
        Clear_TXT()
        bt_save.Enabled = False
        bt_new.Enabled = True
    End Sub

    Private Sub bt_edite_Click(sender As Object, e As EventArgs) Handles bt_edite.Click
        If txt_id.Text Is String.Empty Or txt_Qun.Text Is String.Empty Or txt_unit.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        prd.EDIT_BUILD_BILLS(Convert.ToInt16(txt_id.Text), id, Convert.ToInt16(Combo_sub.SelectedValue), txt_Qun.Text, txt_unit.Text, txt_price.Text, Date_pay.DateTime, txt_note.Text, lbl_total.Text, lbl_Plus.Text, Convert.ToInt16(Combo_main.SelectedValue), lbl_name.Text, Now)
        MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        setv(False)
        Clear_TXT()
        bt_edite.Enabled = False
        bt_new.Enabled = True
    End Sub

    Private Sub txt_unit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_unit.KeyPress
        JustNumber(e)
    End Sub

    Private Sub txt_unit_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_unit.KeyUp
        'Try
        '    If RD_be.Checked = True Then
        '        txt_price.Text = CStr(CDbl(txt_unit.Text) * CDbl(txt_Qun.Text))
        '        Dim amount As Double = CDbl(txt_price.Text)
        '        lbl_total.Text = CStr(amount + amount * 5 / 100)
        '        lbl_Plus.Text = CStr(amount * 5 / 100)
        '        lbl_money.Text = CStr(CDbl(txt_unit.Text) * CDbl(txt_Qun.Text))
        '        Return
        '    Else
        '        txt_price.Text = CStr(CDbl(txt_unit.Text) * CDbl(txt_Qun.Text))
        '        Dim amount As Double = CDbl(txt_price.Text)
        '        lbl_total.Text = CStr(amount + amount * 0 / 100)
        '        lbl_Plus.Text = CStr(amount * 0 / 100)
        '        lbl_money.Text = CStr(CDbl(txt_unit.Text) * CDbl(txt_Qun.Text))
        '        Return
        '    End If
        'Catch ex As Exception
        '    Return
        '    ' MsgBox("الرجاء إدخال القيم بصورة صحيحة")
        'End Try
        Try
            If RD_be.Checked = True Then
                txt_price.Text = CStr(CDec(txt_unit.Text) * CDec(txt_Qun.Text))
                Dim amount As Decimal = CDec(txt_price.Text)
                lbl_total.Text = CStr(amount + amount * 5 / 100)
                lbl_Plus.Text = CStr(amount * 5 / 100)
                lbl_money.Text = CStr(CDec(txt_unit.Text) * CDec(txt_Qun.Text))
                Return
            Else
                txt_price.Text = CStr(CDec(txt_unit.Text) * CDec(txt_Qun.Text))
                Dim amount As Decimal = CDec(txt_price.Text)
                lbl_total.Text = CStr(amount + amount * 0 / 100)
                lbl_Plus.Text = CStr(amount * 0 / 100)
                lbl_money.Text = CStr(CDec(txt_unit.Text) * CDec(txt_Qun.Text))
                Return
            End If
        Catch ex As Exception
            Return
            ' MsgBox("الرجاء إدخال القيم بصورة صحيحة")
        End Try

    End Sub

    Private Sub bt_new_Click(sender As Object, e As EventArgs) Handles bt_new.Click
        Me.Controls.Clear()
        InitializeComponent()
        MYSUB()
        Clear_TXT()
        setv(True)
        fill_txt_id()
        bt_save.Enabled = True
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        setv(True)
        bt_edite.Enabled = True
        bt_save.Enabled = False
        Try
            Clear_TXT()
            txt_id.Text = CStr(GridView1.GetFocusedRowCellValue("معرف الفاتورة"))
            txt_unit.Text = CStr(GridView1.GetFocusedRowCellValue("سعر الوحدة"))
            txt_Qun.Text = CStr(GridView1.GetFocusedRowCellValue("الكمية"))

            txt_price.Text = CStr(GridView1.GetFocusedRowCellValue("المبلغ"))
            txt_note.Text = CStr(GridView1.GetFocusedRowCellValue("ملاحظة"))

            lbl_money.Text = CStr(GridView1.GetFocusedRowCellValue("المبلغ"))
            lbl_total.Text = CStr(GridView1.GetFocusedRowCellValue("المبلغ بعد القيمة المضافة"))
            lbl_Plus.Text = CStr(GridView1.GetFocusedRowCellValue("القيمة المضافة"))

            Combo_main.Text = CStr(GridView1.GetFocusedRowCellValue("البند الرئيسي"))
            Combo_pro.Text = CStr(GridView1.GetFocusedRowCellValue("اسم المشروع"))

            Combo_sub.Text = CStr(GridView1.GetFocusedRowCellValue("البند الفرعي"))
            Date_pay.Text = CStr(GridView1.GetFocusedRowCellValue("التاريخ"))
        Catch ex As Exception
            Return
            'MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub lbl_total_Click(sender As Object, e As EventArgs) Handles lbl_total.Click

    End Sub

    Private Sub Sell_Project_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub RD_be_CheckedChanged(sender As Object, e As EventArgs) Handles RD_be.CheckedChanged
        Try
            If RD_be.Checked = True Then
                Dim amount As Decimal = CDec(txt_price.Text)
                lbl_total.Text = CStr(amount + amount * 5 / 100)
                lbl_Plus.Text = CStr(amount * 5 / 100)
                lbl_money.Text = txt_price.Text.ToString
            Else
                Dim amount As Decimal = CDec(txt_price.Text)
                lbl_total.Text = CStr(amount + amount * 0 / 100)
                lbl_Plus.Text = CStr(amount * 0 / 100)
                lbl_money.Text = txt_price.Text.ToString
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub RD_not_CheckedChanged(sender As Object, e As EventArgs) Handles RD_not.CheckedChanged
        'Try
        '    If RD_be.Checked = True Then
        '        Dim amount As Double = CDbl(txt_price.Text)
        '        lbl_total.Text = CStr(amount + amount * 5 / 100)
        '        lbl_Plus.Text = CStr(amount * 5 / 100)
        '        lbl_money.Text = txt_price.Text.ToString
        '    Else
        '        Dim amount As Double = CDbl(txt_price.Text)
        '        lbl_total.Text = CStr(amount + amount * 0 / 100)
        '        lbl_Plus.Text = CStr(amount * 0 / 100)
        '        lbl_money.Text = txt_price.Text.ToString
        '    End If

        'Catch ex As Exception
        '    Return
        'End Try

        Try
            If RD_be.Checked = True Then
                Dim amount As Decimal = CDec(txt_price.Text)
                lbl_total.Text = CStr(amount + amount * 5 / 100)
                lbl_Plus.Text = CStr(amount * 5 / 100)
                lbl_money.Text = txt_price.Text.ToString
            Else
                Dim amount As Decimal = CDec(txt_price.Text)
                lbl_total.Text = CStr(amount + amount * 0 / 100)
                lbl_Plus.Text = CStr(amount * 0 / 100)
                lbl_money.Text = txt_price.Text.ToString
            End If
        Catch ex As Exception
            Return
        End Try

    End Sub
End Class