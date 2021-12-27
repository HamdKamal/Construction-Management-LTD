<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Res_Special
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Res_Special))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        Me.date_bills = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Combo_Sbill = New System.Windows.Forms.ComboBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_edit = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_save = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_NOTE = New System.Windows.Forms.TextBox()
        Me.txt_mony = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_sbills = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.date_bills.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_bills.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_mony.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl2.SuspendLayout()
        CType(Me.Grid_sbills, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lbl_name)
        Me.GroupControl1.Controls.Add(Me.date_bills)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.Combo_Sbill)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton4)
        Me.GroupControl1.Controls.Add(Me.bt_edit)
        Me.GroupControl1.Controls.Add(Me.bt_save)
        Me.GroupControl1.Controls.Add(Me.txt_id)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.TXT_NOTE)
        Me.GroupControl1.Controls.Add(Me.txt_mony)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupControl1.Size = New System.Drawing.Size(808, 198)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "فواتير خاصة شهرية"
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(69, 31)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 25)
        Me.lbl_name.TabIndex = 80
        Me.lbl_name.Visible = False
        '
        'date_bills
        '
        Me.date_bills.EditValue = Nothing
        Me.date_bills.Location = New System.Drawing.Point(447, 111)
        Me.date_bills.Name = "date_bills"
        Me.date_bills.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.date_bills.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.date_bills.Size = New System.Drawing.Size(264, 20)
        Me.date_bills.TabIndex = 69
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(485, 161)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(71, 32)
        Me.SimpleButton2.TabIndex = 68
        Me.SimpleButton2.Text = "جديد"
        '
        'Combo_Sbill
        '
        Me.Combo_Sbill.FormattingEnabled = True
        Me.Combo_Sbill.Location = New System.Drawing.Point(447, 71)
        Me.Combo_Sbill.Name = "Combo_Sbill"
        Me.Combo_Sbill.Size = New System.Drawing.Size(264, 21)
        Me.Combo_Sbill.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(406, 66)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 29)
        Me.SimpleButton1.TabIndex = 16
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(242, 161)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(74, 32)
        Me.SimpleButton4.TabIndex = 6
        Me.SimpleButton4.Text = "رجوع"
        '
        'bt_edit
        '
        Me.bt_edit.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_edit.Appearance.Options.UseFont = True
        Me.bt_edit.Image = CType(resources.GetObject("bt_edit.Image"), System.Drawing.Image)
        Me.bt_edit.Location = New System.Drawing.Point(323, 161)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(73, 32)
        Me.bt_edit.TabIndex = 5
        Me.bt_edit.Text = "تعديل"
        '
        'bt_save
        '
        Me.bt_save.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_save.Appearance.Options.UseFont = True
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.Location = New System.Drawing.Point(403, 161)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(75, 32)
        Me.bt_save.TabIndex = 4
        Me.bt_save.Text = "حفظ"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(574, 34)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Properties.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(137, 20)
        Me.txt_id.TabIndex = 12
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Location = New System.Drawing.Point(714, 35)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(59, 17)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "رقم الفاتورة"
        '
        'TXT_NOTE
        '
        Me.TXT_NOTE.Location = New System.Drawing.Point(69, 70)
        Me.TXT_NOTE.Multiline = True
        Me.TXT_NOTE.Name = "TXT_NOTE"
        Me.TXT_NOTE.Size = New System.Drawing.Size(264, 61)
        Me.TXT_NOTE.TabIndex = 3
        '
        'txt_mony
        '
        Me.txt_mony.Location = New System.Drawing.Point(186, 35)
        Me.txt_mony.Name = "txt_mony"
        Me.txt_mony.Properties.Mask.BeepOnError = True
        Me.txt_mony.Properties.Mask.EditMask = "n0"
        Me.txt_mony.Size = New System.Drawing.Size(147, 20)
        Me.txt_mony.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(339, 72)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 17)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "ملاحظة"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(715, 111)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(34, 17)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "التاريخ"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(339, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 17)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "المبلغ"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(714, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 17)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "نوع الفاتورة"
        '
        'groupControl2
        '
        Me.groupControl2.Controls.Add(Me.Grid_sbills)
        Me.groupControl2.Location = New System.Drawing.Point(5, 218)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.groupControl2.Size = New System.Drawing.Size(808, 347)
        Me.groupControl2.TabIndex = 6
        Me.groupControl2.Text = "عرض الفواتير"
        '
        'Grid_sbills
        '
        Me.Grid_sbills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_sbills.Location = New System.Drawing.Point(2, 20)
        Me.Grid_sbills.MainView = Me.GridView1
        Me.Grid_sbills.Name = "Grid_sbills"
        Me.Grid_sbills.Size = New System.Drawing.Size(804, 325)
        Me.Grid_sbills.TabIndex = 5
        Me.Grid_sbills.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_sbills
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Res_Special
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 568)
        Me.Controls.Add(Me.groupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Res_Special"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نافذة الفواتير الخاصة الشهرية"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.date_bills.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_bills.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_mony.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl2.ResumeLayout(False)
        CType(Me.Grid_sbills, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TXT_NOTE As System.Windows.Forms.TextBox
    Friend WithEvents txt_mony As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents groupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid_sbills As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Combo_Sbill As System.Windows.Forms.ComboBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents date_bills As DevExpress.XtraEditors.DateEdit
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
End Class
