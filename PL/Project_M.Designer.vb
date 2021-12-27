<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Project_M
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Project_M))
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_Project = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cost = New DevExpress.XtraEditors.TextEdit()
        Me.txt_loc = New DevExpress.XtraEditors.TextEdit()
        Me.txt_woner = New DevExpress.XtraEditors.TextEdit()
        Me.Date_start = New DevExpress.XtraEditors.DateEdit()
        Me.Date_End = New DevExpress.XtraEditors.DateEdit()
        Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        Me.txt_name = New DevExpress.XtraEditors.TextEdit()
        Me.txt_iden = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.comb_name_pro = New DevExpress.XtraEditors.GroupControl()
        Me.bt_new = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_back = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_edit = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_save = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl2.SuspendLayout()
        CType(Me.Grid_Project, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_loc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_woner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_End.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl1.SuspendLayout()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_iden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comb_name_pro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.comb_name_pro.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupControl2
        '
        Me.groupControl2.Controls.Add(Me.Grid_Project)
        Me.groupControl2.Location = New System.Drawing.Point(4, 224)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.groupControl2.Size = New System.Drawing.Size(944, 291)
        Me.groupControl2.TabIndex = 4
        Me.groupControl2.Text = "لائحة المشاريع "
        '
        'Grid_Project
        '
        Me.Grid_Project.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Project.Location = New System.Drawing.Point(2, 20)
        Me.Grid_Project.MainView = Me.GridView1
        Me.Grid_Project.Name = "Grid_Project"
        Me.Grid_Project.Size = New System.Drawing.Size(940, 269)
        Me.Grid_Project.TabIndex = 0
        Me.Grid_Project.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_Project
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl1.Location = New System.Drawing.Point(833, 63)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(75, 17)
        Me.labelControl1.TabIndex = 0
        Me.labelControl1.Text = "إسم المشروع :"
        '
        'labelControl2
        '
        Me.labelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl2.Location = New System.Drawing.Point(568, 99)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(39, 17)
        Me.labelControl2.TabIndex = 1
        Me.labelControl2.Text = "المالك :"
        '
        'labelControl3
        '
        Me.labelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl3.Location = New System.Drawing.Point(568, 63)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(42, 17)
        Me.labelControl3.TabIndex = 2
        Me.labelControl3.Text = "الموقع :"
        '
        'labelControl4
        '
        Me.labelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl4.Location = New System.Drawing.Point(833, 99)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(81, 17)
        Me.labelControl4.TabIndex = 3
        Me.labelControl4.Text = "تكلفة المشروع :"
        '
        'labelControl5
        '
        Me.labelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl5.Location = New System.Drawing.Point(223, 63)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(110, 17)
        Me.labelControl5.TabIndex = 4
        Me.labelControl5.Text = "تاريخ بداية المشروع :"
        '
        'labelControl6
        '
        Me.labelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl6.Location = New System.Drawing.Point(220, 99)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(113, 17)
        Me.labelControl6.TabIndex = 5
        Me.labelControl6.Text = "تاريخ تسليم المشروع :"
        '
        'txt_cost
        '
        Me.txt_cost.Location = New System.Drawing.Point(642, 99)
        Me.txt_cost.Name = "txt_cost"
        Me.txt_cost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_cost.Properties.Mask.BeepOnError = True
        Me.txt_cost.Properties.Mask.EditMask = "n0"
        Me.txt_cost.Properties.Mask.IgnoreMaskBlank = False
        Me.txt_cost.Size = New System.Drawing.Size(191, 20)
        Me.txt_cost.TabIndex = 2
        '
        'txt_loc
        '
        Me.txt_loc.Location = New System.Drawing.Point(366, 63)
        Me.txt_loc.Name = "txt_loc"
        Me.txt_loc.Size = New System.Drawing.Size(202, 20)
        Me.txt_loc.TabIndex = 1
        '
        'txt_woner
        '
        Me.txt_woner.Location = New System.Drawing.Point(366, 99)
        Me.txt_woner.Name = "txt_woner"
        Me.txt_woner.Size = New System.Drawing.Size(202, 20)
        Me.txt_woner.TabIndex = 3
        '
        'Date_start
        '
        Me.Date_start.EditValue = Nothing
        Me.Date_start.Location = New System.Drawing.Point(27, 63)
        Me.Date_start.Name = "Date_start"
        Me.Date_start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_start.Size = New System.Drawing.Size(195, 20)
        Me.Date_start.TabIndex = 4
        '
        'Date_End
        '
        Me.Date_End.EditValue = Nothing
        Me.Date_End.Location = New System.Drawing.Point(27, 99)
        Me.Date_End.Name = "Date_End"
        Me.Date_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_End.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_End.Size = New System.Drawing.Size(194, 20)
        Me.Date_End.TabIndex = 5
        '
        'groupControl1
        '
        Me.groupControl1.Controls.Add(Me.lbl_name)
        Me.groupControl1.Controls.Add(Me.txt_name)
        Me.groupControl1.Controls.Add(Me.txt_iden)
        Me.groupControl1.Controls.Add(Me.LabelControl7)
        Me.groupControl1.Controls.Add(Me.Date_End)
        Me.groupControl1.Controls.Add(Me.Date_start)
        Me.groupControl1.Controls.Add(Me.txt_woner)
        Me.groupControl1.Controls.Add(Me.txt_loc)
        Me.groupControl1.Controls.Add(Me.txt_cost)
        Me.groupControl1.Controls.Add(Me.labelControl6)
        Me.groupControl1.Controls.Add(Me.labelControl5)
        Me.groupControl1.Controls.Add(Me.labelControl4)
        Me.groupControl1.Controls.Add(Me.labelControl3)
        Me.groupControl1.Controls.Add(Me.labelControl2)
        Me.groupControl1.Controls.Add(Me.labelControl1)
        Me.groupControl1.Location = New System.Drawing.Point(6, 6)
        Me.groupControl1.Name = "groupControl1"
        Me.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.groupControl1.Size = New System.Drawing.Size(940, 134)
        Me.groupControl1.TabIndex = 0
        Me.groupControl1.Text = "بيانات المشروع"
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(53, 29)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 25)
        Me.lbl_name.TabIndex = 84
        Me.lbl_name.Visible = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(642, 63)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(191, 20)
        Me.txt_name.TabIndex = 0
        '
        'txt_iden
        '
        Me.txt_iden.Location = New System.Drawing.Point(727, 29)
        Me.txt_iden.Name = "txt_iden"
        Me.txt_iden.Properties.Mask.BeepOnError = True
        Me.txt_iden.Properties.Mask.EditMask = "n0"
        Me.txt_iden.Properties.Mask.IgnoreMaskBlank = False
        Me.txt_iden.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_iden.Properties.ReadOnly = True
        Me.txt_iden.Size = New System.Drawing.Size(106, 20)
        Me.txt_iden.TabIndex = 6
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Location = New System.Drawing.Point(833, 29)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(85, 17)
        Me.LabelControl7.TabIndex = 51
        Me.LabelControl7.Text = "معرف المشروع :"
        '
        'comb_name_pro
        '
        Me.comb_name_pro.Controls.Add(Me.bt_new)
        Me.comb_name_pro.Controls.Add(Me.bt_delete)
        Me.comb_name_pro.Controls.Add(Me.bt_back)
        Me.comb_name_pro.Controls.Add(Me.bt_edit)
        Me.comb_name_pro.Controls.Add(Me.bt_save)
        Me.comb_name_pro.Location = New System.Drawing.Point(89, 146)
        Me.comb_name_pro.Name = "comb_name_pro"
        Me.comb_name_pro.Size = New System.Drawing.Size(784, 72)
        Me.comb_name_pro.TabIndex = 1
        Me.comb_name_pro.Text = "العمليات"
        '
        'bt_new
        '
        Me.bt_new.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_new.Appearance.Options.UseFont = True
        Me.bt_new.Image = CType(resources.GetObject("bt_new.Image"), System.Drawing.Image)
        Me.bt_new.Location = New System.Drawing.Point(627, 35)
        Me.bt_new.Name = "bt_new"
        Me.bt_new.Size = New System.Drawing.Size(75, 32)
        Me.bt_new.TabIndex = 5
        Me.bt_new.Text = "جديد"
        '
        'bt_delete
        '
        Me.bt_delete.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_delete.Appearance.Options.UseFont = True
        Me.bt_delete.Enabled = False
        Me.bt_delete.Image = CType(resources.GetObject("bt_delete.Image"), System.Drawing.Image)
        Me.bt_delete.Location = New System.Drawing.Point(219, 35)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.Size = New System.Drawing.Size(75, 32)
        Me.bt_delete.TabIndex = 2
        Me.bt_delete.Text = "حذف"
        '
        'bt_back
        '
        Me.bt_back.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_back.Appearance.Options.UseFont = True
        Me.bt_back.Image = CType(resources.GetObject("bt_back.Image"), System.Drawing.Image)
        Me.bt_back.Location = New System.Drawing.Point(77, 35)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(75, 32)
        Me.bt_back.TabIndex = 4
        Me.bt_back.Text = "رجوع"
        '
        'bt_edit
        '
        Me.bt_edit.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_edit.Appearance.Options.UseFont = True
        Me.bt_edit.Enabled = False
        Me.bt_edit.Image = CType(resources.GetObject("bt_edit.Image"), System.Drawing.Image)
        Me.bt_edit.Location = New System.Drawing.Point(354, 35)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(75, 32)
        Me.bt_edit.TabIndex = 1
        Me.bt_edit.Text = "تعديل"
        '
        'bt_save
        '
        Me.bt_save.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_save.Appearance.Options.UseFont = True
        Me.bt_save.Enabled = False
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.Location = New System.Drawing.Point(486, 35)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(75, 32)
        Me.bt_save.TabIndex = 0
        Me.bt_save.Text = "حفظ"
        '
        'Project_M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 518)
        Me.Controls.Add(Me.comb_name_pro)
        Me.Controls.Add(Me.groupControl2)
        Me.Controls.Add(Me.groupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Project_M"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نافذة إدارة المشاريع"
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl2.ResumeLayout(False)
        CType(Me.Grid_Project, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_loc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_woner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_End.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl1.ResumeLayout(False)
        Me.groupControl1.PerformLayout()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_iden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comb_name_pro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.comb_name_pro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupControl2 As DevExpress.XtraEditors.GroupControl

    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl5 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txt_cost As DevExpress.XtraEditors.TextEdit
    Private WithEvents txt_loc As DevExpress.XtraEditors.TextEdit
    Private WithEvents txt_woner As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Date_start As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Date_End As DevExpress.XtraEditors.DateEdit
    Private WithEvents groupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents txt_iden As DevExpress.XtraEditors.TextEdit
    Private WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents comb_name_pro As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bt_new As DevExpress.XtraEditors.SimpleButton
    Private WithEvents bt_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_save As DevExpress.XtraEditors.SimpleButton
    Private WithEvents txt_name As DevExpress.XtraEditors.TextEdit
    Public WithEvents Grid_Project As DevExpress.XtraGrid.GridControl
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
End Class
