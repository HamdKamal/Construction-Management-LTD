<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bills_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bills_form))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        Me.txt_left = New DevExpress.XtraEditors.TextEdit()
        Me.txt_paid = New DevExpress.XtraEditors.TextEdit()
        Me.txt_total = New DevExpress.XtraEditors.TextEdit()
        Me.Combo_MAIN = New DevExpress.XtraEditors.TextEdit()
        Me.Combo_pro = New DevExpress.XtraEditors.TextEdit()
        Me.txt_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.BT_EDITE = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Date_pay = New DevExpress.XtraEditors.DateEdit()
        Me.Grid_BILLS = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl1.SuspendLayout()
        CType(Me.txt_left.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_paid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Combo_MAIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Combo_pro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.Date_pay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_pay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_BILLS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl1.Location = New System.Drawing.Point(681, 129)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(64, 17)
        Me.labelControl1.TabIndex = 51
        Me.labelControl1.Text = "تاريخ الدفع :"
        '
        'labelControl7
        '
        Me.labelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl7.Location = New System.Drawing.Point(323, 133)
        Me.labelControl7.Name = "labelControl7"
        Me.labelControl7.Size = New System.Drawing.Size(78, 17)
        Me.labelControl7.TabIndex = 50
        Me.labelControl7.Text = "المبلغ المتبقي :"
        '
        'labelControl8
        '
        Me.labelControl8.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl8.Location = New System.Drawing.Point(323, 100)
        Me.labelControl8.Name = "labelControl8"
        Me.labelControl8.Size = New System.Drawing.Size(81, 17)
        Me.labelControl8.TabIndex = 49
        Me.labelControl8.Text = "المبلغ المدفوع :"
        '
        'labelControl6
        '
        Me.labelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl6.Location = New System.Drawing.Point(682, 67)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(64, 17)
        Me.labelControl6.TabIndex = 38
        Me.labelControl6.Text = "إسم  الجهة :"
        '
        'labelControl5
        '
        Me.labelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl5.Location = New System.Drawing.Point(681, 99)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(71, 17)
        Me.labelControl5.TabIndex = 37
        Me.labelControl5.Text = "نوع الفاتورة :"
        '
        'labelControl4
        '
        Me.labelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl4.Location = New System.Drawing.Point(323, 67)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(68, 17)
        Me.labelControl4.TabIndex = 36
        Me.labelControl4.Text = "المبلغ الكلي :"
        '
        'groupControl1
        '
        Me.groupControl1.Controls.Add(Me.SimpleButton6)
        Me.groupControl1.Controls.Add(Me.lbl_name)
        Me.groupControl1.Controls.Add(Me.txt_left)
        Me.groupControl1.Controls.Add(Me.txt_paid)
        Me.groupControl1.Controls.Add(Me.txt_total)
        Me.groupControl1.Controls.Add(Me.Combo_MAIN)
        Me.groupControl1.Controls.Add(Me.Combo_pro)
        Me.groupControl1.Controls.Add(Me.txt_id)
        Me.groupControl1.Controls.Add(Me.LabelControl3)
        Me.groupControl1.Controls.Add(Me.txt_note)
        Me.groupControl1.Controls.Add(Me.LabelControl2)
        Me.groupControl1.Controls.Add(Me.GroupControl3)
        Me.groupControl1.Controls.Add(Me.Date_pay)
        Me.groupControl1.Controls.Add(Me.labelControl1)
        Me.groupControl1.Controls.Add(Me.labelControl7)
        Me.groupControl1.Controls.Add(Me.labelControl8)
        Me.groupControl1.Controls.Add(Me.labelControl6)
        Me.groupControl1.Controls.Add(Me.labelControl5)
        Me.groupControl1.Controls.Add(Me.labelControl4)
        Me.groupControl1.Location = New System.Drawing.Point(2, 3)
        Me.groupControl1.Name = "groupControl1"
        Me.groupControl1.Size = New System.Drawing.Size(815, 261)
        Me.groupControl1.TabIndex = 0
        Me.groupControl1.Text = "بيانات الفاتورة"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(179, 190)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(141, 37)
        Me.SimpleButton6.TabIndex = 81
        Me.SimpleButton6.Text = "الدفعات"
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(179, 37)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 25)
        Me.lbl_name.TabIndex = 80
        Me.lbl_name.Visible = False
        '
        'txt_left
        '
        Me.txt_left.Location = New System.Drawing.Point(179, 133)
        Me.txt_left.Name = "txt_left"
        Me.txt_left.Properties.Mask.BeepOnError = True
        Me.txt_left.Properties.Mask.EditMask = "n0"
        Me.txt_left.Properties.ReadOnly = True
        Me.txt_left.Size = New System.Drawing.Size(141, 20)
        Me.txt_left.TabIndex = 69
        '
        'txt_paid
        '
        Me.txt_paid.EditValue = ""
        Me.txt_paid.Location = New System.Drawing.Point(179, 99)
        Me.txt_paid.Name = "txt_paid"
        Me.txt_paid.Properties.Mask.BeepOnError = True
        Me.txt_paid.Properties.Mask.EditMask = "n0"
        Me.txt_paid.Size = New System.Drawing.Size(141, 20)
        Me.txt_paid.TabIndex = 68
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(179, 67)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Properties.Mask.BeepOnError = True
        Me.txt_total.Properties.Mask.EditMask = "n0"
        Me.txt_total.Size = New System.Drawing.Size(141, 20)
        Me.txt_total.TabIndex = 67
        '
        'Combo_MAIN
        '
        Me.Combo_MAIN.Location = New System.Drawing.Point(440, 101)
        Me.Combo_MAIN.Name = "Combo_MAIN"
        Me.Combo_MAIN.Size = New System.Drawing.Size(240, 20)
        Me.Combo_MAIN.TabIndex = 66
        '
        'Combo_pro
        '
        Me.Combo_pro.Location = New System.Drawing.Point(440, 69)
        Me.Combo_pro.Name = "Combo_pro"
        Me.Combo_pro.Size = New System.Drawing.Size(240, 20)
        Me.Combo_pro.TabIndex = 65
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(552, 34)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Properties.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(127, 20)
        Me.txt_id.TabIndex = 64
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(682, 34)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(80, 17)
        Me.LabelControl3.TabIndex = 63
        Me.LabelControl3.Text = "معرف الفاتورة :"
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(441, 162)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(239, 65)
        Me.txt_note.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(682, 163)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 17)
        Me.LabelControl2.TabIndex = 60
        Me.LabelControl2.Text = "ملاحظة:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.BT_EDITE)
        Me.GroupControl3.Controls.Add(Me.SimpleButton4)
        Me.GroupControl3.Controls.Add(Me.SimpleButton1)
        Me.GroupControl3.Controls.Add(Me.SimpleButton3)
        Me.GroupControl3.Location = New System.Drawing.Point(11, 37)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(152, 204)
        Me.GroupControl3.TabIndex = 6
        Me.GroupControl3.Text = "العمليات المتاحة "
        '
        'BT_EDITE
        '
        Me.BT_EDITE.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BT_EDITE.Appearance.Options.UseFont = True
        Me.BT_EDITE.Image = CType(resources.GetObject("BT_EDITE.Image"), System.Drawing.Image)
        Me.BT_EDITE.Location = New System.Drawing.Point(39, 114)
        Me.BT_EDITE.Name = "BT_EDITE"
        Me.BT_EDITE.Size = New System.Drawing.Size(75, 32)
        Me.BT_EDITE.TabIndex = 15
        Me.BT_EDITE.Text = "تعديل"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(39, 25)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 32)
        Me.SimpleButton4.TabIndex = 14
        Me.SimpleButton4.Text = "جديد"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(39, 69)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 32)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "حفظ"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(39, 160)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 32)
        Me.SimpleButton3.TabIndex = 1
        Me.SimpleButton3.Text = "رجوع"
        '
        'Date_pay
        '
        Me.Date_pay.EditValue = Nothing
        Me.Date_pay.Location = New System.Drawing.Point(440, 130)
        Me.Date_pay.Name = "Date_pay"
        Me.Date_pay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_pay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_pay.Size = New System.Drawing.Size(240, 20)
        Me.Date_pay.TabIndex = 2
        '
        'Grid_BILLS
        '
        Me.Grid_BILLS.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.Grid_BILLS.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.Grid_BILLS.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid_BILLS.Location = New System.Drawing.Point(2, 20)
        Me.Grid_BILLS.MainView = Me.GridView2
        Me.Grid_BILLS.Name = "Grid_BILLS"
        Me.Grid_BILLS.Size = New System.Drawing.Size(811, 308)
        Me.Grid_BILLS.TabIndex = 4
        Me.Grid_BILLS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'GridView2
        '
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.GridView2.GridControl = Me.Grid_BILLS
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsFind.AlwaysVisible = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_BILLS
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Grid_BILLS)
        Me.GroupControl2.Location = New System.Drawing.Point(2, 263)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(815, 330)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "لائحة الفواتير الأجلة غير المدفوعة"
        '
        'Bills_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 594)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.groupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bills_form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نافذة الفواتير الأجلة "
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl1.ResumeLayout(False)
        Me.groupControl1.PerformLayout()
        CType(Me.txt_left.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_paid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Combo_MAIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Combo_pro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.Date_pay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_pay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_BILLS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl7 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl8 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl5 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents groupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Date_pay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Private WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txt_id As DevExpress.XtraEditors.TextEdit
    Private WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Friend WithEvents Grid_BILLS As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Combo_pro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Combo_MAIN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_left As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_paid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_total As DevExpress.XtraEditors.TextEdit
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BT_EDITE As DevExpress.XtraEditors.SimpleButton
End Class
