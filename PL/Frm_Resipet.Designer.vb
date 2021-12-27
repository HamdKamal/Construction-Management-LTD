<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RESIPET
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_RESIPET))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_name = New DevExpress.XtraEditors.TextEdit()
        Me.rd_pro = New System.Windows.Forms.RadioButton()
        Me.Combo_pro = New System.Windows.Forms.ComboBox()
        Me.rd_area = New System.Windows.Forms.RadioButton()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_ID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_MONY = New DevExpress.XtraEditors.TextEdit()
        Me.Date_PAY = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_del = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_new = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_save = New DevExpress.XtraEditors.SimpleButton()
        Me.BT_BACK = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_PRO = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TXT_TOTAL_pro = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_AREA = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_total_area = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_total = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_MONY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_PAY.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_PAY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.Grid_PRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_TOTAL_pro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.Grid_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_area.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txt_note)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.TXT_ID)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.TXT_MONY)
        Me.GroupControl1.Controls.Add(Me.Date_PAY)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(672, 220)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = " ... بيانات الإيراد  "
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.PanelControl1.Controls.Add(Me.txt_name)
        Me.PanelControl1.Controls.Add(Me.rd_pro)
        Me.PanelControl1.Controls.Add(Me.Combo_pro)
        Me.PanelControl1.Controls.Add(Me.rd_area)
        Me.PanelControl1.Location = New System.Drawing.Point(9, 26)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(554, 68)
        Me.PanelControl1.TabIndex = 75
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(324, 35)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(226, 20)
        Me.txt_name.TabIndex = 75
        '
        'rd_pro
        '
        Me.rd_pro.AutoSize = True
        Me.rd_pro.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rd_pro.Location = New System.Drawing.Point(166, 5)
        Me.rd_pro.Name = "rd_pro"
        Me.rd_pro.Size = New System.Drawing.Size(95, 23)
        Me.rd_pro.TabIndex = 74
        Me.rd_pro.TabStop = True
        Me.rd_pro.Text = "إيراد مشروع"
        Me.rd_pro.UseVisualStyleBackColor = True
        '
        'Combo_pro
        '
        Me.Combo_pro.FormattingEnabled = True
        Me.Combo_pro.Location = New System.Drawing.Point(5, 35)
        Me.Combo_pro.Name = "Combo_pro"
        Me.Combo_pro.Size = New System.Drawing.Size(256, 21)
        Me.Combo_pro.TabIndex = 74
        '
        'rd_area
        '
        Me.rd_area.AutoSize = True
        Me.rd_area.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.rd_area.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.rd_area.Location = New System.Drawing.Point(441, 5)
        Me.rd_area.Name = "rd_area"
        Me.rd_area.Size = New System.Drawing.Size(109, 23)
        Me.rd_area.TabIndex = 73
        Me.rd_area.TabStop = True
        Me.rd_area.Text = "إيراد جهة معينة"
        Me.rd_area.UseVisualStyleBackColor = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Location = New System.Drawing.Point(273, 109)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(45, 17)
        Me.LabelControl11.TabIndex = 73
        Me.LabelControl11.Text = "ملاحظة :"
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(9, 110)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(261, 94)
        Me.txt_note.TabIndex = 72
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(566, 108)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 17)
        Me.LabelControl4.TabIndex = 71
        Me.LabelControl4.Text = " معرف الإيراد :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(569, 28)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 17)
        Me.LabelControl2.TabIndex = 72
        Me.LabelControl2.Text = "تحديد نوع الإيراد :"
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(470, 109)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Properties.Mask.BeepOnError = True
        Me.TXT_ID.Properties.Mask.EditMask = "n0"
        Me.TXT_ID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TXT_ID.Properties.ReadOnly = True
        Me.TXT_ID.Size = New System.Drawing.Size(93, 20)
        Me.TXT_ID.TabIndex = 70
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(566, 147)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 17)
        Me.LabelControl1.TabIndex = 69
        Me.LabelControl1.Text = "المبلغ :"
        '
        'TXT_MONY
        '
        Me.TXT_MONY.Location = New System.Drawing.Point(333, 146)
        Me.TXT_MONY.Name = "TXT_MONY"
        Me.TXT_MONY.Properties.Mask.BeepOnError = True
        Me.TXT_MONY.Properties.Mask.EditMask = "n0"
        Me.TXT_MONY.Size = New System.Drawing.Size(230, 20)
        Me.TXT_MONY.TabIndex = 66
        '
        'Date_PAY
        '
        Me.Date_PAY.EditValue = Nothing
        Me.Date_PAY.Location = New System.Drawing.Point(333, 183)
        Me.Date_PAY.Name = "Date_PAY"
        Me.Date_PAY.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_PAY.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_PAY.Size = New System.Drawing.Size(230, 20)
        Me.Date_PAY.TabIndex = 67
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(567, 183)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 17)
        Me.LabelControl6.TabIndex = 68
        Me.LabelControl6.Text = "تاريخ الدفع :"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Controls.Add(Me.bt_del)
        Me.GroupControl2.Controls.Add(Me.bt_new)
        Me.GroupControl2.Controls.Add(Me.bt_save)
        Me.GroupControl2.Controls.Add(Me.BT_BACK)
        Me.GroupControl2.Location = New System.Drawing.Point(114, 239)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(457, 64)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = " ... العمليات المتاحة"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(109, 23)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton1.Size = New System.Drawing.Size(74, 32)
        Me.SimpleButton1.TabIndex = 83
        Me.SimpleButton1.Text = "طباعة"
        '
        'bt_del
        '
        Me.bt_del.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_del.Appearance.Options.UseFont = True
        Me.bt_del.Image = CType(resources.GetObject("bt_del.Image"), System.Drawing.Image)
        Me.bt_del.Location = New System.Drawing.Point(192, 23)
        Me.bt_del.Name = "bt_del"
        Me.bt_del.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bt_del.Size = New System.Drawing.Size(74, 32)
        Me.bt_del.TabIndex = 82
        Me.bt_del.Text = "حذف"
        '
        'bt_new
        '
        Me.bt_new.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_new.Appearance.Options.UseFont = True
        Me.bt_new.Image = CType(resources.GetObject("bt_new.Image"), System.Drawing.Image)
        Me.bt_new.Location = New System.Drawing.Point(356, 23)
        Me.bt_new.Name = "bt_new"
        Me.bt_new.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bt_new.Size = New System.Drawing.Size(74, 32)
        Me.bt_new.TabIndex = 81
        Me.bt_new.Text = "جديد"
        '
        'bt_save
        '
        Me.bt_save.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_save.Appearance.Options.UseFont = True
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.Location = New System.Drawing.Point(274, 23)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bt_save.Size = New System.Drawing.Size(74, 32)
        Me.bt_save.TabIndex = 79
        Me.bt_save.Text = "حفظ"
        '
        'BT_BACK
        '
        Me.BT_BACK.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_BACK.Appearance.Options.UseFont = True
        Me.BT_BACK.Image = CType(resources.GetObject("BT_BACK.Image"), System.Drawing.Image)
        Me.BT_BACK.Location = New System.Drawing.Point(25, 23)
        Me.BT_BACK.Name = "BT_BACK"
        Me.BT_BACK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BT_BACK.Size = New System.Drawing.Size(75, 32)
        Me.BT_BACK.TabIndex = 80
        Me.BT_BACK.Text = "رجوع"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.Grid_PRO)
        Me.GroupControl3.Location = New System.Drawing.Point(681, 3)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(639, 300)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = " ... تفاصيل إيرادات المشاريع"
        '
        'Grid_PRO
        '
        Me.Grid_PRO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_PRO.Location = New System.Drawing.Point(2, 20)
        Me.Grid_PRO.MainView = Me.GridView1
        Me.Grid_PRO.Name = "Grid_PRO"
        Me.Grid_PRO.Size = New System.Drawing.Size(635, 278)
        Me.Grid_PRO.TabIndex = 0
        Me.Grid_PRO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_PRO
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'TXT_TOTAL_pro
        '
        Me.TXT_TOTAL_pro.Enabled = False
        Me.TXT_TOTAL_pro.Location = New System.Drawing.Point(321, 409)
        Me.TXT_TOTAL_pro.Name = "TXT_TOTAL_pro"
        Me.TXT_TOTAL_pro.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_TOTAL_pro.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TXT_TOTAL_pro.Properties.Appearance.Options.UseFont = True
        Me.TXT_TOTAL_pro.Properties.Appearance.Options.UseForeColor = True
        Me.TXT_TOTAL_pro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TXT_TOTAL_pro.Properties.DisplayFormat.FormatString = "SR"
        Me.TXT_TOTAL_pro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TXT_TOTAL_pro.Properties.Mask.BeepOnError = True
        Me.TXT_TOTAL_pro.Properties.Mask.EditMask = "c2"
        Me.TXT_TOTAL_pro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TXT_TOTAL_pro.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TXT_TOTAL_pro.Properties.ReadOnly = True
        Me.TXT_TOTAL_pro.Properties.XlsxFormatString = "SR"
        Me.TXT_TOTAL_pro.Size = New System.Drawing.Size(229, 26)
        Me.TXT_TOTAL_pro.TabIndex = 86
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl7.Location = New System.Drawing.Point(126, 409)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(190, 25)
        Me.LabelControl7.TabIndex = 85
        Me.LabelControl7.Text = " إجمالي إيرادات المشاريع:"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.Grid_AREA)
        Me.GroupControl4.Location = New System.Drawing.Point(681, 307)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(639, 301)
        Me.GroupControl4.TabIndex = 87
        Me.GroupControl4.Text = " ... تفاصيل إيرادات الجهات"
        '
        'Grid_AREA
        '
        Me.Grid_AREA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_AREA.Location = New System.Drawing.Point(2, 20)
        Me.Grid_AREA.MainView = Me.GridView2
        Me.Grid_AREA.Name = "Grid_AREA"
        Me.Grid_AREA.Size = New System.Drawing.Size(635, 279)
        Me.Grid_AREA.TabIndex = 0
        Me.Grid_AREA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.Grid_AREA
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsFind.AlwaysVisible = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'txt_total_area
        '
        Me.txt_total_area.Enabled = False
        Me.txt_total_area.Location = New System.Drawing.Point(321, 461)
        Me.txt_total_area.Name = "txt_total_area"
        Me.txt_total_area.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txt_total_area.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_total_area.Properties.Appearance.Options.UseFont = True
        Me.txt_total_area.Properties.Appearance.Options.UseForeColor = True
        Me.txt_total_area.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_total_area.Properties.DisplayFormat.FormatString = "SR"
        Me.txt_total_area.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_total_area.Properties.Mask.BeepOnError = True
        Me.txt_total_area.Properties.Mask.EditMask = "c2"
        Me.txt_total_area.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total_area.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total_area.Properties.ReadOnly = True
        Me.txt_total_area.Properties.XlsxFormatString = "SR"
        Me.txt_total_area.Size = New System.Drawing.Size(229, 26)
        Me.txt_total_area.TabIndex = 89
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl3.Location = New System.Drawing.Point(138, 462)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(178, 25)
        Me.LabelControl3.TabIndex = 88
        Me.LabelControl3.Text = " إجمالي إيرادات الجهات:"
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(321, 514)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txt_total.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_total.Properties.Appearance.Options.UseFont = True
        Me.txt_total.Properties.Appearance.Options.UseForeColor = True
        Me.txt_total.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_total.Properties.DisplayFormat.FormatString = "SR"
        Me.txt_total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_total.Properties.Mask.BeepOnError = True
        Me.txt_total.Properties.Mask.EditMask = "c2"
        Me.txt_total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_total.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_total.Properties.ReadOnly = True
        Me.txt_total.Properties.XlsxFormatString = "SR"
        Me.txt_total.Size = New System.Drawing.Size(229, 26)
        Me.txt_total.TabIndex = 91
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl5.Location = New System.Drawing.Point(206, 514)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(110, 25)
        Me.LabelControl5.TabIndex = 90
        Me.LabelControl5.Text = "الإجمالي العام :"
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(619, 239)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 25)
        Me.lbl_name.TabIndex = 92
        Me.lbl_name.Visible = False
        '
        'Frm_RESIPET
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 613)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_total_area)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TXT_TOTAL_pro)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_RESIPET"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نافذة الإيرادات"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_MONY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_PAY.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_PAY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.Grid_PRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_TOTAL_pro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.Grid_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_area.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid_PRO As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TXT_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TXT_MONY As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Date_PAY As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bt_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BT_BACK As DevExpress.XtraEditors.SimpleButton
    Private WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Friend WithEvents Combo_pro As System.Windows.Forms.ComboBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rd_pro As System.Windows.Forms.RadioButton
    Friend WithEvents rd_area As System.Windows.Forms.RadioButton
    Friend WithEvents txt_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TXT_TOTAL_pro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid_AREA As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_total_area As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
