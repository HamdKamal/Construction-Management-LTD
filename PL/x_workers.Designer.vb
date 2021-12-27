<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class x_workers
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(x_workers))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_X_WORKER = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.BT_DEL = New DevExpress.XtraEditors.SimpleButton()
        Me.BT_BACK = New DevExpress.XtraEditors.SimpleButton()
        Me.BT_EDITE = New DevExpress.XtraEditors.SimpleButton()
        Me.BT_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_MONY = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.Combo_MAIN = New System.Windows.Forms.ComboBox()
        Me.Combo_SUP = New System.Windows.Forms.ComboBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_left = New DevExpress.XtraEditors.TextEdit()
        Me.txt_paid = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Combo_PRO = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Comb_xname = New System.Windows.Forms.ComboBox()
        Me.Date_pay = New DevExpress.XtraEditors.DateEdit()
        Me.TXT_ID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Grid_X_WORKER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.TXT_MONY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_left.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_paid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Combo_PRO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_pay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_pay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Grid_X_WORKER)
        Me.GroupControl2.Location = New System.Drawing.Point(6, 293)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(687, 297)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "بيانات مقاولين الباطن"
        '
        'Grid_X_WORKER
        '
        Me.Grid_X_WORKER.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_X_WORKER.Location = New System.Drawing.Point(2, 20)
        Me.Grid_X_WORKER.MainView = Me.GridView1
        Me.Grid_X_WORKER.Name = "Grid_X_WORKER"
        Me.Grid_X_WORKER.Size = New System.Drawing.Size(683, 275)
        Me.Grid_X_WORKER.TabIndex = 0
        Me.Grid_X_WORKER.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_X_WORKER
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.SimpleButton2)
        Me.GroupControl4.Controls.Add(Me.BT_DEL)
        Me.GroupControl4.Controls.Add(Me.BT_BACK)
        Me.GroupControl4.Controls.Add(Me.BT_EDITE)
        Me.GroupControl4.Controls.Add(Me.BT_SAVE)
        Me.GroupControl4.Location = New System.Drawing.Point(6, 219)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(687, 69)
        Me.GroupControl4.TabIndex = 49
        Me.GroupControl4.Text = "العمليات"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(471, 23)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 32)
        Me.SimpleButton2.TabIndex = 47
        Me.SimpleButton2.Text = "جديد"
        '
        'BT_DEL
        '
        Me.BT_DEL.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_DEL.Appearance.Options.UseFont = True
        Me.BT_DEL.Image = CType(resources.GetObject("BT_DEL.Image"), System.Drawing.Image)
        Me.BT_DEL.Location = New System.Drawing.Point(213, 23)
        Me.BT_DEL.Name = "BT_DEL"
        Me.BT_DEL.Size = New System.Drawing.Size(75, 32)
        Me.BT_DEL.TabIndex = 42
        Me.BT_DEL.Text = "حذف"
        '
        'BT_BACK
        '
        Me.BT_BACK.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_BACK.Appearance.Options.UseFont = True
        Me.BT_BACK.Image = CType(resources.GetObject("BT_BACK.Image"), System.Drawing.Image)
        Me.BT_BACK.Location = New System.Drawing.Point(132, 23)
        Me.BT_BACK.Name = "BT_BACK"
        Me.BT_BACK.Size = New System.Drawing.Size(75, 32)
        Me.BT_BACK.TabIndex = 46
        Me.BT_BACK.Text = "رجوع"
        '
        'BT_EDITE
        '
        Me.BT_EDITE.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_EDITE.Appearance.Options.UseFont = True
        Me.BT_EDITE.Image = CType(resources.GetObject("BT_EDITE.Image"), System.Drawing.Image)
        Me.BT_EDITE.Location = New System.Drawing.Point(299, 23)
        Me.BT_EDITE.Name = "BT_EDITE"
        Me.BT_EDITE.Size = New System.Drawing.Size(75, 32)
        Me.BT_EDITE.TabIndex = 45
        Me.BT_EDITE.Text = "تعديل"
        '
        'BT_SAVE
        '
        Me.BT_SAVE.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_SAVE.Appearance.Options.UseFont = True
        Me.BT_SAVE.Image = CType(resources.GetObject("BT_SAVE.Image"), System.Drawing.Image)
        Me.BT_SAVE.Location = New System.Drawing.Point(385, 23)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.Size = New System.Drawing.Size(75, 32)
        Me.BT_SAVE.TabIndex = 44
        Me.BT_SAVE.Text = "حفظ"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(601, 65)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "أسم المشروع :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(600, 98)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 15)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "اسم مقاول الباطن :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(600, 135)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 15)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "نوع العمل :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(600, 173)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(25, 15)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "البند :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(240, 68)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 15)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "المبلغ :"
        '
        'TXT_MONY
        '
        Me.TXT_MONY.Location = New System.Drawing.Point(27, 65)
        Me.TXT_MONY.Name = "TXT_MONY"
        Me.TXT_MONY.Properties.Mask.BeepOnError = True
        Me.TXT_MONY.Properties.Mask.EditMask = "n0"
        Me.TXT_MONY.Size = New System.Drawing.Size(211, 20)
        Me.TXT_MONY.TabIndex = 10
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(239, 174)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(37, 15)
        Me.LabelControl8.TabIndex = 17
        Me.LabelControl8.Text = "التاريخ :"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(27, 23)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(131, 36)
        Me.SimpleButton6.TabIndex = 19
        Me.SimpleButton6.Text = "الدفعات"
        '
        'Combo_MAIN
        '
        Me.Combo_MAIN.FormattingEnabled = True
        Me.Combo_MAIN.Location = New System.Drawing.Point(388, 171)
        Me.Combo_MAIN.Name = "Combo_MAIN"
        Me.Combo_MAIN.Size = New System.Drawing.Size(211, 21)
        Me.Combo_MAIN.TabIndex = 69
        '
        'Combo_SUP
        '
        Me.Combo_SUP.FormattingEnabled = True
        Me.Combo_SUP.Location = New System.Drawing.Point(388, 133)
        Me.Combo_SUP.Name = "Combo_SUP"
        Me.Combo_SUP.Size = New System.Drawing.Size(211, 21)
        Me.Combo_SUP.TabIndex = 70
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txt_left)
        Me.GroupControl1.Controls.Add(Me.txt_paid)
        Me.GroupControl1.Controls.Add(Me.labelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.lbl_name)
        Me.GroupControl1.Controls.Add(Me.SimpleButton4)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.Combo_PRO)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.Comb_xname)
        Me.GroupControl1.Controls.Add(Me.Date_pay)
        Me.GroupControl1.Controls.Add(Me.TXT_ID)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.Combo_SUP)
        Me.GroupControl1.Controls.Add(Me.Combo_MAIN)
        Me.GroupControl1.Controls.Add(Me.SimpleButton6)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.TXT_MONY)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(6, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(687, 209)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "بيانات العقد"
        '
        'txt_left
        '
        Me.txt_left.Location = New System.Drawing.Point(27, 134)
        Me.txt_left.Name = "txt_left"
        Me.txt_left.Properties.Mask.BeepOnError = True
        Me.txt_left.Properties.Mask.EditMask = "n0"
        Me.txt_left.Properties.ReadOnly = True
        Me.txt_left.Size = New System.Drawing.Size(211, 20)
        Me.txt_left.TabIndex = 86
        '
        'txt_paid
        '
        Me.txt_paid.EditValue = ""
        Me.txt_paid.Location = New System.Drawing.Point(27, 100)
        Me.txt_paid.Name = "txt_paid"
        Me.txt_paid.Properties.Mask.BeepOnError = True
        Me.txt_paid.Properties.Mask.EditMask = "n0"
        Me.txt_paid.Size = New System.Drawing.Size(211, 20)
        Me.txt_paid.TabIndex = 85
        '
        'labelControl7
        '
        Me.labelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labelControl7.Location = New System.Drawing.Point(238, 134)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(72, 17)
        Me.labelControl7.TabIndex = 84
        Me.labelControl7.Text = "المبلغ المتبقي :"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Location = New System.Drawing.Point(238, 101)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(74, 17)
        Me.LabelControl9.TabIndex = 83
        Me.LabelControl9.Text = "المبلغ المدفوع :"
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(411, 23)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 25)
        Me.lbl_name.TabIndex = 82
        Me.lbl_name.Visible = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(347, 129)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(38, 29)
        Me.SimpleButton4.TabIndex = 78
        Me.SimpleButton4.Text = "SimpleButton4"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(347, 168)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(38, 29)
        Me.SimpleButton3.TabIndex = 77
        Me.SimpleButton3.Text = "SimpleButton3"
        '
        'Combo_PRO
        '
        Me.Combo_PRO.Location = New System.Drawing.Point(388, 63)
        Me.Combo_PRO.Name = "Combo_PRO"
        Me.Combo_PRO.Size = New System.Drawing.Size(211, 20)
        Me.Combo_PRO.TabIndex = 76
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(347, 92)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 29)
        Me.SimpleButton1.TabIndex = 75
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'Comb_xname
        '
        Me.Comb_xname.FormattingEnabled = True
        Me.Comb_xname.Location = New System.Drawing.Point(388, 96)
        Me.Comb_xname.Name = "Comb_xname"
        Me.Comb_xname.Size = New System.Drawing.Size(211, 21)
        Me.Comb_xname.TabIndex = 74
        '
        'Date_pay
        '
        Me.Date_pay.EditValue = Nothing
        Me.Date_pay.Location = New System.Drawing.Point(27, 171)
        Me.Date_pay.Name = "Date_pay"
        Me.Date_pay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_pay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_pay.Size = New System.Drawing.Size(211, 20)
        Me.Date_pay.TabIndex = 73
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(500, 31)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Properties.ReadOnly = True
        Me.TXT_ID.Size = New System.Drawing.Size(99, 20)
        Me.TXT_ID.TabIndex = 72
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(600, 31)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(51, 15)
        Me.LabelControl6.TabIndex = 71
        Me.LabelControl6.Text = "معرف البند:"
        '
        'x_workers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 592)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "x_workers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مقاولين الباطن"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Grid_X_WORKER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.TXT_MONY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_left.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_paid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Combo_PRO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_pay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_pay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid_X_WORKER As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Private WithEvents BT_DEL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BT_BACK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BT_EDITE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BT_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TXT_MONY As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Combo_MAIN As System.Windows.Forms.ComboBox
    Friend WithEvents Combo_SUP As System.Windows.Forms.ComboBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TXT_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Date_pay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Comb_xname As System.Windows.Forms.ComboBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Combo_PRO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_left As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_paid As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl7 As DevExpress.XtraEditors.LabelControl
    Private WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
