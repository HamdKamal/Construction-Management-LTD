Imports System.ComponentModel
Imports System.Text
Imports System.Data.SqlClient
Imports نظام_إدارة_شركة_مقاولات.Constraction_Management_Co


Partial Public Class Main_Form
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Dim log As New CLS_login
    Sub S_NO()
        Dim DAL As DAL.DataAccessLayer = New DAL.DataAccessLayer()
        DAL.sqlconn.Open()
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim dt As DataTable = New DataTable()
        dt = log.GET_S_NO()
        Dim id As Integer = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)(0))
        lbl_serial.Text = id.ToString()
    End Sub
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
     
    End Sub

    Private Sub Main_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        S_NO()
        lbl_name.Text = Form_Log.log_name
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub barButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem5.ItemClick
        Res_Special.ShowDialog()

    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Workers.ShowDialog()

    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Car_Res.ShowDialog()

    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Sell_Project.ShowDialog()

    End Sub

    Private Sub barButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
        Project_M.ShowDialog()

    End Sub

    Private Sub barButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem3.ItemClick
        Emp_form.ShowDialog()

    End Sub


    Private Sub RibbonControl2_Click(sender As Object, e As EventArgs) Handles RibbonControl2.Click

    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Bakup_form.ShowDialog()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Restore_form.ShowDialog()
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        If MessageBox.Show("هل تريد الخروج من النظام", "Confirm To Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        main_item.ShowDialog()
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        sub_item.ShowDialog()
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        users.ShowDialog()
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        x_workers.ShowDialog()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_clock.Text = Now.ToString
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Bills_form.ShowDialog()
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        About_pro.ShowDialog()
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        About_Co.ShowDialog()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        System_Conf.ShowDialog()
    End Sub

    Private Sub BarButtonItem14_ItemClick_1(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Reportin.DocumentViewer1.DocumentSource = New Projectreport
        Reportin.ShowDialog()
        Me.Cursor = Cursors.Default


    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Reportin.DocumentViewer1.DocumentSource = New WorkersReport
        Reportin.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Reportin.DocumentViewer1.DocumentSource = New TaxtReport
        Reportin.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Reportin.DocumentViewer1.DocumentSource = New DailyReport
        Reportin.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Dim TK As New TakeReport
        TK.Parameters("user").Value = Form_Log.LOG_ID
        TK.Parameters("P_serial").Value = lbl_serial.Text
        Reportin.DocumentViewer1.DocumentSource = TK
        Reportin.ShowDialog()
        Me.Cursor = Cursors.Default
        log.ADD_S_NO(lbl_serial.Text)
        S_NO()
    End Sub

    Private Sub BarButtonItem23_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Dim PR As New PayReport
        PR.Parameters("user").Value = Form_Log.LOG_ID
        PR.Parameters("serial_no").Value = lbl_serial.Text
        Reportin.DocumentViewer1.DocumentSource = PR
        Reportin.ShowDialog()
        Me.Cursor = Cursors.Default
        log.ADD_S_NO(lbl_serial.Text)
        S_NO()
    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        Frm_RESIPET.ShowDialog()
    End Sub
End Class

