<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment_Bills
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment_Bills))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
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
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_MONEY = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.BT_BACK = New DevExpress.XtraEditors.SimpleButton()
        Me.BT_pay = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GRID_PAYMENTS = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_TOTAL = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_MONY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_PAY.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_PAY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.Grid_MONEY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GRID_PAYMENTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.TXT_TOTAL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
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
        Me.GroupControl1.Location = New System.Drawing.Point(5, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl1.Size = New System.Drawing.Size(359, 225)
        Me.GroupControl1.TabIndex = 20
        Me.GroupControl1.Text = " ... تفاصيل الدفعات"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LabelControl5.Location = New System.Drawing.Point(26, 32)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(57, 25)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Visible = False
        '
        'Combo_PAY
        '
        Me.Combo_PAY.FormattingEnabled = True
        Me.Combo_PAY.Items.AddRange(New Object() {"الدفعة الأولى", "الدفعة الثانية", "الدفعة الثالثة", "الدفعة الرابعة", "الدفعة الخامسة ", "الدفعة السادسة"})
        Me.Combo_PAY.Location = New System.Drawing.Point(13, 107)
        Me.Combo_PAY.Name = "Combo_PAY"
        Me.Combo_PAY.Size = New System.Drawing.Size(239, 21)
        Me.Combo_PAY.TabIndex = 1
        '
        'Combo_NAME
        '
        Me.Combo_NAME.FormattingEnabled = True
        Me.Combo_NAME.Location = New System.Drawing.Point(13, 65)
        Me.Combo_NAME.Name = "Combo_NAME"
        Me.Combo_NAME.Size = New System.Drawing.Size(239, 21)
        Me.Combo_NAME.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(254, 29)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 17)
        Me.LabelControl4.TabIndex = 65
        Me.LabelControl4.Text = "معرف الدفعة:"
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(147, 29)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Properties.Mask.BeepOnError = True
        Me.TXT_ID.Properties.Mask.EditMask = "n"
        Me.TXT_ID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TXT_ID.Properties.ReadOnly = True
        Me.TXT_ID.Size = New System.Drawing.Size(105, 20)
        Me.TXT_ID.TabIndex = 64
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(254, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 17)
        Me.LabelControl2.TabIndex = 61
        Me.LabelControl2.Text = "الجهة:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(254, 150)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 17)
        Me.LabelControl1.TabIndex = 58
        Me.LabelControl1.Text = "المبلغ:"
        '
        'TXT_MONY
        '
        Me.TXT_MONY.Location = New System.Drawing.Point(13, 149)
        Me.TXT_MONY.Name = "TXT_MONY"
        Me.TXT_MONY.Properties.Mask.BeepOnError = True
        Me.TXT_MONY.Properties.Mask.EditMask = "n0"
        Me.TXT_MONY.Size = New System.Drawing.Size(239, 20)
        Me.TXT_MONY.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(254, 107)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 17)
        Me.LabelControl3.TabIndex = 55
        Me.LabelControl3.Text = " الدفعة:"
        '
        'Date_PAY
        '
        Me.Date_PAY.EditValue = Nothing
        Me.Date_PAY.Location = New System.Drawing.Point(13, 190)
        Me.Date_PAY.Name = "Date_PAY"
        Me.Date_PAY.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_PAY.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_PAY.Size = New System.Drawing.Size(239, 20)
        Me.Date_PAY.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(254, 190)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 17)
        Me.LabelControl6.TabIndex = 53
        Me.LabelControl6.Text = "تاريخ الدفع:"
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(836, 92)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 25)
        Me.lbl_name.TabIndex = 82
        Me.lbl_name.Visible = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.Grid_MONEY)
        Me.GroupControl3.Location = New System.Drawing.Point(368, 5)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(532, 69)
        Me.GroupControl3.TabIndex = 21
        Me.GroupControl3.Text = " : المبالغ المدفوعة "
        '
        'Grid_MONEY
        '
        Me.Grid_MONEY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_MONEY.Location = New System.Drawing.Point(2, 20)
        Me.Grid_MONEY.MainView = Me.GridView1
        Me.Grid_MONEY.Name = "Grid_MONEY"
        Me.Grid_MONEY.Size = New System.Drawing.Size(528, 47)
        Me.Grid_MONEY.TabIndex = 1
        Me.Grid_MONEY.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_MONEY
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.Grid_MONEY
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(347, 32)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton1.Size = New System.Drawing.Size(74, 32)
        Me.SimpleButton1.TabIndex = 77
        Me.SimpleButton1.Text = "جديد"
        '
        'BT_BACK
        '
        Me.BT_BACK.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_BACK.Appearance.Options.UseFont = True
        Me.BT_BACK.Image = CType(resources.GetObject("BT_BACK.Image"), System.Drawing.Image)
        Me.BT_BACK.Location = New System.Drawing.Point(100, 32)
        Me.BT_BACK.Name = "BT_BACK"
        Me.BT_BACK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BT_BACK.Size = New System.Drawing.Size(75, 32)
        Me.BT_BACK.TabIndex = 76
        Me.BT_BACK.Text = "رجوع"
        '
        'BT_pay
        '
        Me.BT_pay.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_pay.Appearance.Options.UseFont = True
        Me.BT_pay.Image = CType(resources.GetObject("BT_pay.Image"), System.Drawing.Image)
        Me.BT_pay.Location = New System.Drawing.Point(265, 32)
        Me.BT_pay.Name = "BT_pay"
        Me.BT_pay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BT_pay.Size = New System.Drawing.Size(74, 32)
        Me.BT_pay.TabIndex = 74
        Me.BT_pay.Text = "سداد"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GRID_PAYMENTS)
        Me.GroupControl2.Location = New System.Drawing.Point(5, 236)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(895, 358)
        Me.GroupControl2.TabIndex = 78
        Me.GroupControl2.Text = " : تفاصيل الدفعات المسددة"
        '
        'GRID_PAYMENTS
        '
        Me.GRID_PAYMENTS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRID_PAYMENTS.Location = New System.Drawing.Point(2, 20)
        Me.GRID_PAYMENTS.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.GRID_PAYMENTS.MainView = Me.GridView3
        Me.GRID_PAYMENTS.Name = "GRID_PAYMENTS"
        Me.GRID_PAYMENTS.Size = New System.Drawing.Size(891, 336)
        Me.GRID_PAYMENTS.TabIndex = 0
        Me.GRID_PAYMENTS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView4})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GRID_PAYMENTS
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.OptionsFind.AlwaysVisible = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GRID_PAYMENTS
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsBehavior.ReadOnly = True
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.SimpleButton2)
        Me.GroupControl4.Controls.Add(Me.SimpleButton1)
        Me.GroupControl4.Controls.Add(Me.BT_pay)
        Me.GroupControl4.Controls.Add(Me.BT_BACK)
        Me.GroupControl4.Location = New System.Drawing.Point(370, 155)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(528, 75)
        Me.GroupControl4.TabIndex = 22
        Me.GroupControl4.Text = " : العمليات المتاحة"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(183, 32)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SimpleButton2.Size = New System.Drawing.Size(74, 32)
        Me.SimpleButton2.TabIndex = 78
        Me.SimpleButton2.Text = "حذف"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl7.Location = New System.Drawing.Point(313, 602)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(126, 25)
        Me.LabelControl7.TabIndex = 83
        Me.LabelControl7.Text = " إجمالي الدفعات :"
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Enabled = False
        Me.TXT_TOTAL.Location = New System.Drawing.Point(445, 601)
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
        Me.TXT_TOTAL.TabIndex = 84
        '
        'Payment_Bills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 639)
        Me.Controls.Add(Me.TXT_TOTAL)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Payment_Bills"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تسديد دفعات الفواتير الأجلة "
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_MONY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_PAY.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_PAY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.Grid_MONEY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GRID_PAYMENTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.TXT_TOTAL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Combo_PAY As System.Windows.Forms.ComboBox
    Friend WithEvents Combo_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TXT_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TXT_MONY As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Date_PAY As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BT_BACK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BT_pay As DevExpress.XtraEditors.SimpleButton
    Public WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GRID_PAYMENTS As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Grid_MONEY As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TXT_TOTAL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
