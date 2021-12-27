Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co

Public Class sub_item
    Dim prd As ClS_project = New ClS_project()
    Public Sub generate_newID()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = prd.get_last_id_SubCat()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        TXT_ID.Text = id.ToString()
        txt_Sub_Name.Focus()
    End Sub
    Public Sub fill_combo()
        combo_MainCat.DataSource = prd.fill_comb_mainCat()
        combo_MainCat.DisplayMember = "cat_name"
        combo_MainCat.ValueMember = "cat_id"
    End Sub
    Public Sub fill_Gridview()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = prd.get_all_SubCat()
        Grid_SubCat.DataSource = dt
    End Sub
    Sub cleartxt()
        txt_id.Text = ""
        txt_Sub_Name.Text = ""
        combo_MainCat.Text = ""
    End Sub

    Sub setv(ByVal x As Boolean)
        txt_Sub_Name.Enabled = x
        combo_MainCat.Enabled = x
    End Sub

    Private Sub sub_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_combo()
        fill_Gridview()
        setv(False)
        bt_del.Enabled = False
        bt_edit.Enabled = False
        bt_save.Enabled = False
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If txt_id.Text Is String.Empty Or txt_Sub_Name.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        prd.Add_Sub_Cat(Convert.ToInt16(txt_id.Text), Convert.ToInt32(combo_MainCat.SelectedValue), txt_Sub_Name.Text)
        MessageBox.Show("تمت إضافة البند بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        cleartxt()
        setv(False)

        bt_save.Enabled = False
        SimpleButton1.Enabled = True
    End Sub

    Private Sub bt_back_Click(sender As Object, e As EventArgs) Handles bt_back.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub bt_del_Click(sender As Object, e As EventArgs) Handles bt_del.Click
        If txt_id.Text Is String.Empty Or txt_Sub_Name.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        prd.Del_SubCat(Convert.ToInt16(txt_id.Text))
        MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        cleartxt()
        bt_del.Enabled = False
        SimpleButton1.Enabled = True
    End Sub

    Private Sub bt_edit_Click(sender As Object, e As EventArgs) Handles bt_edit.Click
        If txt_id.Text Is String.Empty Or txt_Sub_Name.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If
        prd.Edite_SubCat(Convert.ToInt16(txt_id.Text), Convert.ToInt32(combo_MainCat.SelectedValue), txt_Sub_Name.Text)
        MessageBox.Show("تم تعديل البند بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)
        fill_Gridview()
        setv(False)

        cleartxt()
        bt_edit.Enabled = False
        SimpleButton1.Enabled = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        setv(True)
        bt_del.Enabled = False
        bt_edit.Enabled = False
        bt_save.Enabled = True
        cleartxt()
        generate_newID()
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        setv(True)
        bt_edit.Enabled = True
        bt_del.Enabled = True
        bt_save.Enabled = False
        Try
            cleartxt()
            txt_id.Text = CStr(GridView1.GetFocusedRowCellValue("معرف البند"))
            txt_Sub_Name.Text = CStr(GridView1.GetFocusedRowCellValue("اسم البند الفرعي"))
            combo_MainCat.Text = CStr(GridView1.GetFocusedRowCellValue("اسم البند الرئيسي"))
        Catch ex As Exception
            MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

  
    Private Sub sub_item_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class