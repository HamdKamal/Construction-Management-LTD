Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing

Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co


Public Class users
    Dim Log As CLS_login = New CLS_login()
    Dim frm As New Form_Log()
    Public id1 As Integer
    Dim dt As DataTable = New DataTable()

    Sub upd_name()
        Dim DT As DataTable = Log.Login(lbl_name.Text, lbl_pass.Text)
        If DT.Rows.Count > 0 Then
            Main_Form.lbl_name.Text = DT.Rows(0)("User_FullName").ToString()
        End If
    End Sub

    Public Sub fill_txt_id()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = Log.GET_ID_USER
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        txt_id.Text = id.ToString()
        txt_name.Focus()
    End Sub

    Public Sub filldatagrid()
        Try
            Dim DT As DataTable = Log.Login(lbl_name.Text, lbl_pass.Text)
            If DT.Rows.Count > 0 Then
                If DT.Rows(0)(4).ToString() = "ADMIN" Then
                    Dim dt1 As DataTable = New DataTable()
                    dt1 = Log.get_all_users()
                    Grid_user.DataSource = dt1
                End If
            End If
            If DT.Rows.Count > 0 Then
                If DT.Rows(0)(4).ToString() = "USER" Then
                    id1 = Convert.ToInt16(DT.Rows(0)("user_id"))
                    Dim dt2 As DataTable = New DataTable()
                    dt2 = Log.get_ONE_users(id1)
                    Grid_user.DataSource = dt2

                    SimpleButton2.Visible = False
                    SimpleButton4.Visible = False
                    SimpleButton5.Visible = False
                    simpleButton3.Visible = False
                    combo_Type.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            Return
        End Try
        Grid_user.Refresh()
    End Sub
    Sub cleartxt()
        txt_id.Text = ""
        txt_fullName.Text = ""
        txt_name.Text = ""
        txt_pass.Text = ""
        txt_conf_pass.Text = ""
    End Sub
    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_name.Text = Form_Log.lo_name
        lbl_pass.Text = Form_Log.lo_pass
        SimpleButton2.Enabled = False
        SimpleButton5.Enabled = False
        simpleButton3.Enabled = False
        filldatagrid()
        setv(False)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        SimpleButton2.Enabled = False
        SimpleButton5.Enabled = False
        simpleButton3.Enabled = False
        Try
            If txt_conf_pass.Text <> txt_pass.Text Then
                MessageBox.Show("كلمة المرور غير متطابقة ", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If
            If txt_id.Text Is String.Empty Or txt_name.Text Is String.Empty Or txt_fullName.Text Is String.Empty Then
                MsgBox("الرجاء ملء جميع الحقول")
                Return
            End If

            dt = Log.VErfiy_ID(CInt(txt_id.Text))
            If dt.Rows.Count > 0 Then
                MessageBox.Show("هذا المعرف موجود مسبقاً", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_id.Focus()
                txt_id.SelectionStart = 0
            End If
            If PIC_S.Image Is Nothing Then
                Log.add_User_no_pic(txt_id.Text, txt_name.Text, txt_fullName.Text, txt_pass.Text, combo_Type.Text)
            Else
                Dim ms As MemoryStream = New MemoryStream()
                PIC_S.Image.Save(ms, PIC_S.Image.RawFormat)
                Dim byteimage As Byte() = ms.ToArray()
                Log.add_User(txt_id.Text, txt_name.Text, txt_fullName.Text, txt_pass.Text, combo_Type.Text, byteimage)
            End If
            MessageBox.Show("تمت إضافة المستخدم بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information)
            filldatagrid()
            cleartxt()
            setv(False)

            SimpleButton2.Enabled = False
            SimpleButton5.Enabled = False
            simpleButton3.Enabled = False
        Catch ex As Exception
            MessageBox.Show("يرجو إدخال البيانات بصورة سليمة", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dispose()
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If txt_conf_pass.Text <> txt_pass.Text Then
            MessageBox.Show("كلمة المرور غير متطابقة ", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If
        If txt_id.Text Is String.Empty Or txt_name.Text Is String.Empty Or txt_fullName.Text Is String.Empty Then
            MsgBox("الرجاء ملء جميع الحقول")
            Return
        End If

        Dim ms As MemoryStream = New MemoryStream()
        PIC_S.Image.Save(ms, PIC_S.Image.RawFormat)
        Dim byteimage As Byte() = ms.ToArray()
        Log.Edite_User(txt_id.Text, txt_name.Text, txt_fullName.Text, txt_pass.Text, combo_Type.Text, byteimage)

        MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim DT As DataTable = Log.Login(lbl_name.Text, lbl_pass.Text)
        If DT.Rows.Count > 0 Then
            If DT.Rows(0)(4).ToString() = "ADMIN" Then
                Dim dt1 As DataTable = New DataTable()
                dt1 = Log.get_all_users()
                Grid_user.DataSource = dt1
            Else
                Dim dt2 As DataTable = New DataTable()
                dt2 = Log.get_ONE_users(id1)
                Grid_user.DataSource = dt2
            End If
        End If

        cleartxt()
        setv(False)
        SimpleButton2.Enabled = False
        SimpleButton5.Enabled = False
        simpleButton3.Enabled = False
        upd_name()
    End Sub

    Private Sub simpleButton3_Click(sender As Object, e As EventArgs) Handles simpleButton3.Click
        If txt_id.Text Is String.Empty Then
            MsgBox("قم بإختيار المعرف")
            Return
        End If
        Log.Delete_User(txt_id.Text)
        MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim dt1 As DataTable = New DataTable()
        dt1 = Log.get_all_users()
        Grid_user.DataSource = dt1
        cleartxt()
        SimpleButton2.Enabled = False
        SimpleButton5.Enabled = False
        simpleButton3.Enabled = False
    End Sub

    Private Sub txt_conf_pass_Validated(sender As Object, e As EventArgs) Handles txt_conf_pass.Validated
        If txt_conf_pass.Text <> txt_pass.Text Then
            MessageBox.Show("كلمة المرور غير متطابقة ", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        setv(True)
        simpleButton3.Enabled = True
        SimpleButton2.Enabled = True
        SimpleButton2.Visible = True
        SimpleButton5.Enabled = False
        Try
            cleartxt()
            PIC_S.Image = Nothing
            txt_id.Text = CStr(GridView1.GetFocusedRowCellValue("معرف المستخدم"))
            txt_name.Text = CStr(GridView1.GetFocusedRowCellValue("إسم المستخدم"))
            txt_fullName.Text = CStr(GridView1.GetFocusedRowCellValue("الأسم الكامل"))
            txt_pass.Text = CStr(GridView1.GetFocusedRowCellValue("كلمة المرور"))
            txt_conf_pass.Text = CStr(GridView1.GetFocusedRowCellValue("كلمة المرور"))
            combo_Type.Text = CStr(GridView1.GetFocusedRowCellValue("نوع المستخدم"))
            Dim PIC As Byte() = CType(GridView1.GetFocusedRowCellValue("التوقيع"), Byte())
            Dim ms As MemoryStream = New MemoryStream(pic)
            PIC_S.Image = Image.FromStream(ms)
        Catch ex As Exception
            Return
            'MessageBox.Show("لا توجد بيانات للعرض", "مساعدة", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txt_id_Validated(sender As Object, e As EventArgs) Handles txt_id.Validated
        If txt_id.Text = "" Then
            Return
        Else
            Dim dt As DataTable = New DataTable()
            dt = Log.VErfiy_ID(CInt(txt_id.Text))

            If dt.Rows.Count > 0 Then
                MessageBox.Show("هذا المعرف موجود مسبقاً", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_id.Focus()
                txt_id.SelectionStart = 0
                Return
            End If
        End If


    End Sub

    Sub setv(ByVal x As Boolean)
        txt_conf_pass.Enabled = x
        txt_fullName.Enabled = x
        txt_name.Enabled = x
        txt_pass.Enabled = x
        txt_id.Enabled = x
        PIC_S.Enabled = x
        combo_Type.Enabled = x
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        SimpleButton2.Enabled = False
        SimpleButton5.Enabled = True
        simpleButton3.Enabled = False
        cleartxt()
        fill_txt_id()
        setv(True)
        PIC_S.Image = My.Resources.noor
    End Sub

    Private Sub users_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub PIC_S_Click(sender As Object, e As EventArgs) Handles PIC_S.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Filter = "ملفات الصور |*.JPG;*.PNG;*.GIF;*.BMP"

        If ofd.ShowDialog() = DialogResult.OK Then
            PIC_S.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub LabelControl6_Click(sender As Object, e As EventArgs) Handles LabelControl6.Click

    End Sub
End Class