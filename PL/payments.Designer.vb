<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payments))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_PAYMENT = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Combo_TYPE = New System.Windows.Forms.ComboBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_MONEY = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Combo_pro = New System.Windows.Forms.ComboBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Combo_PAY = New System.Windows.Forms.ComboBox()
        Me.Combo_NAME = New System.Windows.Forms.ComboBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_ID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_MONY = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Date_PAY = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.BT_BACK = New DevExpress.XtraEditors.SimpleButton()
        Me.BT_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.BT_EDITE = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.TXT_TOTAL = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.Grid_PAYMENT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Grid_MONEY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_MONY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_PAY.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_PAY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.TXT_TOTAL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.Grid_PAYMENT)
        Me.GroupControl3.Location = New System.Drawing.Point(2, 278)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(843, 277)
        Me.GroupControl3.TabIndex = 19
        Me.GroupControl3.Text = "الدفعات"
        '
        'Grid_PAYMENT
        '
        Me.Grid_PAYMENT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_PAYMENT.Location = New System.Drawing.Point(2, 20)
        Me.Grid_PAYMENT.MainView = Me.GridView2
        Me.Grid_PAYMENT.Name = "Grid_PAYMENT"
        Me.Grid_PAYMENT.Size = New System.Drawing.Size(839, 255)
        Me.Grid_PAYMENT.TabIndex = 0
        Me.Grid_PAYMENT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.Grid_PAYMENT
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsFind.AlwaysVisible = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_PAYMENT
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Combo_TYPE)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.lbl_name)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.Combo_pro)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.Combo_PAY)
        Me.GroupControl1.Controls.Add(Me.Combo_NAME)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.TXT_ID)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.TXT_MONY)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.Date_PAY)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl1.Size = New System.Drawing.Size(842, 195)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "تسديد الدفعات"
        '
        'Combo_TYPE
        '
        Me.Combo_TYPE.FormattingEnabled = True
        Me.Combo_TYPE.Location = New System.Drawing.Point(550, 127)
        Me.Combo_TYPE.Name = "Combo_TYPE"
        Me.Combo_TYPE.Size = New System.Drawing.Size(186, 21)
        Me.Combo_TYPE.TabIndex = 84
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(737, 129)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(58, 17)
        Me.LabelControl7.TabIndex = 85
        Me.LabelControl7.Text = " نوع العمل:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Grid_MONEY)
        Me.GroupControl2.Location = New System.Drawing.Point(7, 26)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(495, 122)
        Me.GroupControl2.TabIndex = 83
        Me.GroupControl2.Text = " : المبالغ المدفوعة "
        '
        'Grid_MONEY
        '
        Me.Grid_MONEY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_MONEY.Location = New System.Drawing.Point(2, 20)
        Me.Grid_MONEY.MainView = Me.GridView3
        Me.Grid_MONEY.Name = "Grid_MONEY"
        Me.Grid_MONEY.Size = New System.Drawing.Size(491, 100)
        Me.Grid_MONEY.TabIndex = 1
        Me.Grid_MONEY.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView4})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.Grid_MONEY
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.Grid_MONEY
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsBehavior.ReadOnly = True
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(495, 18)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 25)
        Me.lbl_name.TabIndex = 82
        Me.lbl_name.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(508, 58)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(38, 27)
        Me.SimpleButton2.TabIndex = 79
        Me.SimpleButton2.Text = "SimpleButton2"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(508, 91)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(38, 29)
        Me.SimpleButton3.TabIndex = 78
        Me.SimpleButton3.Text = "SimpleButton3"
        '
        'Combo_pro
        '
        Me.Combo_pro.FormattingEnabled = True
        Me.Combo_pro.Location = New System.Drawing.Point(550, 93)
        Me.Combo_pro.Name = "Combo_pro"
        Me.Combo_pro.Size = New System.Drawing.Size(186, 21)
        Me.Combo_pro.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(733, 94)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(83, 17)
        Me.LabelControl5.TabIndex = 71
        Me.LabelControl5.Text = "تحديد المشروع: "
        '
        'Combo_PAY
        '
        Me.Combo_PAY.FormattingEnabled = True
        Me.Combo_PAY.Items.AddRange(New Object() {"الدفعة الأولى", "الدفعة الثانية", "الدفعة الثالثة", "الدفعة الرابعة", "الدفعة الخامسة ", "الدفعة السادسة"})
        Me.Combo_PAY.Location = New System.Drawing.Point(550, 163)
        Me.Combo_PAY.Name = "Combo_PAY"
        Me.Combo_PAY.Size = New System.Drawing.Size(186, 21)
        Me.Combo_PAY.TabIndex = 1
        Me.Combo_PAY.Visible = False
        '
        'Combo_NAME
        '
        Me.Combo_NAME.FormattingEnabled = True
        Me.Combo_NAME.Location = New System.Drawing.Point(550, 58)
        Me.Combo_NAME.Name = "Combo_NAME"
        Me.Combo_NAME.Size = New System.Drawing.Size(186, 21)
        Me.Combo_NAME.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(737, 27)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 17)
        Me.LabelControl4.TabIndex = 65
        Me.LabelControl4.Text = "معرف الدفعة:"
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(631, 26)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Properties.Mask.BeepOnError = True
        Me.TXT_ID.Properties.Mask.EditMask = "n"
        Me.TXT_ID.Properties.ReadOnly = True
        Me.TXT_ID.Size = New System.Drawing.Size(105, 20)
        Me.TXT_ID.TabIndex = 64
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(737, 60)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 17)
        Me.LabelControl2.TabIndex = 61
        Me.LabelControl2.Text = "إسم مقاول الباطن:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(463, 165)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 17)
        Me.LabelControl1.TabIndex = 58
        Me.LabelControl1.Text = "المبلغ:"
        Me.LabelControl1.Visible = False
        '
        'TXT_MONY
        '
        Me.TXT_MONY.Location = New System.Drawing.Point(263, 164)
        Me.TXT_MONY.Name = "TXT_MONY"
        Me.TXT_MONY.Properties.Mask.BeepOnError = True
        Me.TXT_MONY.Properties.Mask.EditMask = "n0"
        Me.TXT_MONY.Size = New System.Drawing.Size(199, 20)
        Me.TXT_MONY.TabIndex = 2
        Me.TXT_MONY.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(737, 164)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 17)
        Me.LabelControl3.TabIndex = 55
        Me.LabelControl3.Text = " الدفعة:"
        Me.LabelControl3.Visible = False
        '
        'Date_PAY
        '
        Me.Date_PAY.EditValue = Nothing
        Me.Date_PAY.Location = New System.Drawing.Point(7, 164)
        Me.Date_PAY.Name = "Date_PAY"
        Me.Date_PAY.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_PAY.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_PAY.Size = New System.Drawing.Size(202, 20)
        Me.Date_PAY.TabIndex = 4
        Me.Date_PAY.Visible = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(209, 165)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl6.TabIndex = 53
        Me.LabelControl6.Text = "التاريخ:"
        Me.LabelControl6.Visible = False
        '
        'BT_BACK
        '
        Me.BT_BACK.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_BACK.Appearance.Options.UseFont = True
        Me.BT_BACK.Image = CType(resources.GetObject("BT_BACK.Image"), System.Drawing.Image)
        Me.BT_BACK.Location = New System.Drawing.Point(60, 27)
        Me.BT_BACK.Name = "BT_BACK"
        Me.BT_BACK.Size = New System.Drawing.Size(75, 32)
        Me.BT_BACK.TabIndex = 7
        Me.BT_BACK.Text = "رجوع"
        '
        'BT_SAVE
        '
        Me.BT_SAVE.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_SAVE.Appearance.Options.UseFont = True
        Me.BT_SAVE.Image = CType(resources.GetObject("BT_SAVE.Image"), System.Drawing.Image)
        Me.BT_SAVE.Location = New System.Drawing.Point(222, 27)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.Size = New System.Drawing.Size(74, 32)
        Me.BT_SAVE.TabIndex = 5
        Me.BT_SAVE.Text = "سداد"
        '
        'BT_EDITE
        '
        Me.BT_EDITE.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_EDITE.Appearance.Options.UseFont = True
        Me.BT_EDITE.Image = CType(resources.GetObject("BT_EDITE.Image"), System.Drawing.Image)
        Me.BT_EDITE.Location = New System.Drawing.Point(141, 27)
        Me.BT_EDITE.Name = "BT_EDITE"
        Me.BT_EDITE.Size = New System.Drawing.Size(75, 32)
        Me.BT_EDITE.TabIndex = 6
        Me.BT_EDITE.Text = "حذف"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(303, 27)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(74, 32)
        Me.SimpleButton1.TabIndex = 73
        Me.SimpleButton1.Text = "جديد"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.BT_BACK)
        Me.GroupControl4.Controls.Add(Me.SimpleButton1)
        Me.GroupControl4.Controls.Add(Me.BT_EDITE)
        Me.GroupControl4.Controls.Add(Me.BT_SAVE)
        Me.GroupControl4.Location = New System.Drawing.Point(214, 205)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(440, 66)
        Me.GroupControl4.TabIndex = 23
        Me.GroupControl4.Text = " : العمليات المتاحة"
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Enabled = False
        Me.TXT_TOTAL.Location = New System.Drawing.Point(409, 567)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TXT_TOTAL.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TXT_TOTAL.Properties.Appearance.Options.UseFont = True
        Me.TXT_TOTAL.Properties.Appearance.Options.UseForeColor = True
        Me.TXT_TOTAL.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TXT_TOTAL.Properties.DisplayFormat.FormatString = "SR"
        Me.TXT_TOTAL.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TXT_TOTAL.Properties.Mask.BeepOnError = True
        Me.TXT_TOTAL.Properties.Mask.EditMask = "c2"
        Me.TXT_TOTAL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TXT_TOTAL.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TXT_TOTAL.Properties.ReadOnly = True
        Me.TXT_TOTAL.Properties.XlsxFormatString = "SR"
        Me.TXT_TOTAL.Size = New System.Drawing.Size(159, 26)
        Me.TXT_TOTAL.TabIndex = 86
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl8.Location = New System.Drawing.Point(277, 568)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(126, 25)
        Me.LabelControl8.TabIndex = 85
        Me.LabelControl8.Text = " إجمالي الدفعات :"
        '
        'payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 605)
        Me.Controls.Add(Me.TXT_TOTAL)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "payments"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الدفعات"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.Grid_PAYMENT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Grid_MONEY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_MONY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_PAY.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_PAY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.TXT_TOTAL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TXT_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BT_BACK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BT_EDITE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BT_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TXT_MONY As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Date_PAY As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Combo_PAY As System.Windows.Forms.ComboBox
    Friend WithEvents Combo_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents Combo_pro As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid_PAYMENT As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid_MONEY As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Combo_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TXT_TOTAL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
