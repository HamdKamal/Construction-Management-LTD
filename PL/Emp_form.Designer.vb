<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_form))
        Me.txt_stay_NO = New DevExpress.XtraEditors.TextEdit()
        Me.txt_salary = New DevExpress.XtraEditors.TextEdit()
        Me.txt_job = New DevExpress.XtraEditors.TextEdit()
        Me.txt_name = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TXT_ID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.date_STAY = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_del = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_back = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_edit = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_save = New DevExpress.XtraEditors.SimpleButton()
        Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GRID_EMP = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.txt_stay_NO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_salary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_job.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl1.SuspendLayout()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_STAY.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_STAY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl2.SuspendLayout()
        CType(Me.GRID_EMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_stay_NO
        '
        Me.txt_stay_NO.Location = New System.Drawing.Point(107, 73)
        Me.txt_stay_NO.Name = "txt_stay_NO"
        Me.txt_stay_NO.Properties.Mask.BeepOnError = True
        Me.txt_stay_NO.Properties.Mask.EditMask = "[0-9]+"
        Me.txt_stay_NO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txt_stay_NO.Properties.MaxLength = 20
        Me.txt_stay_NO.Properties.ValidateOnEnterKey = True
        Me.txt_stay_NO.Size = New System.Drawing.Size(227, 20)
        Me.txt_stay_NO.TabIndex = 3
        '
        'txt_salary
        '
        Me.txt_salary.Location = New System.Drawing.Point(107, 29)
        Me.txt_salary.Name = "txt_salary"
        Me.txt_salary.Properties.Mask.BeepOnError = True
        Me.txt_salary.Properties.Mask.EditMask = "n0"
        Me.txt_salary.Size = New System.Drawing.Size(228, 20)
        Me.txt_salary.TabIndex = 2
        '
        'txt_job
        '
        Me.txt_job.Location = New System.Drawing.Point(462, 114)
        Me.txt_job.Name = "txt_job"
        Me.txt_job.Size = New System.Drawing.Size(233, 20)
        Me.txt_job.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(462, 71)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(233, 20)
        Me.txt_name.TabIndex = 0
        '
        'labelControl6
        '
        Me.labelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl6.Location = New System.Drawing.Point(339, 116)
        Me.labelControl6.Name = "labelControl6"
        Me.labelControl6.Size = New System.Drawing.Size(83, 17)
        Me.labelControl6.TabIndex = 23
        Me.labelControl6.Text = "صلاحية الإقامة :"
        '
        'labelControl5
        '
        Me.labelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl5.Location = New System.Drawing.Point(339, 73)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(61, 17)
        Me.labelControl5.TabIndex = 22
        Me.labelControl5.Text = "رقم الإقامة :"
        '
        'labelControl4
        '
        Me.labelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl4.Location = New System.Drawing.Point(341, 28)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(41, 17)
        Me.labelControl4.TabIndex = 21
        Me.labelControl4.Text = "الراتب :"
        '
        'labelControl3
        '
        Me.labelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl3.Location = New System.Drawing.Point(701, 116)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(47, 17)
        Me.labelControl3.TabIndex = 20
        Me.labelControl3.Text = "الوظيفة :"
        '
        'labelControl2
        '
        Me.labelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl2.Location = New System.Drawing.Point(701, 70)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(71, 17)
        Me.labelControl2.TabIndex = 19
        Me.labelControl2.Text = "أسم الموظف :"
        '
        'groupControl1
        '
        Me.groupControl1.Controls.Add(Me.TXT_ID)
        Me.groupControl1.Controls.Add(Me.LabelControl1)
        Me.groupControl1.Controls.Add(Me.date_STAY)
        Me.groupControl1.Controls.Add(Me.txt_stay_NO)
        Me.groupControl1.Controls.Add(Me.txt_salary)
        Me.groupControl1.Controls.Add(Me.txt_job)
        Me.groupControl1.Controls.Add(Me.txt_name)
        Me.groupControl1.Controls.Add(Me.labelControl6)
        Me.groupControl1.Controls.Add(Me.labelControl5)
        Me.groupControl1.Controls.Add(Me.labelControl4)
        Me.groupControl1.Controls.Add(Me.labelControl3)
        Me.groupControl1.Controls.Add(Me.labelControl2)
        Me.groupControl1.Location = New System.Drawing.Point(1, 1)
        Me.groupControl1.Name = "groupControl1"
        Me.groupControl1.Size = New System.Drawing.Size(816, 149)
        Me.groupControl1.TabIndex = 1
        Me.groupControl1.Text = "بيانات الموظف"
        '
        'TXT_ID
        '
        Me.TXT_ID.Enabled = False
        Me.TXT_ID.Location = New System.Drawing.Point(572, 29)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Properties.Mask.BeepOnError = True
        Me.TXT_ID.Properties.Mask.IgnoreMaskBlank = False
        Me.TXT_ID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TXT_ID.Size = New System.Drawing.Size(123, 20)
        Me.TXT_ID.TabIndex = 50
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(701, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl1.TabIndex = 49
        Me.LabelControl1.Text = "رقم الموظف :"
        '
        'date_STAY
        '
        Me.date_STAY.EditValue = Nothing
        Me.date_STAY.Location = New System.Drawing.Point(107, 116)
        Me.date_STAY.Name = "date_STAY"
        Me.date_STAY.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.date_STAY.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.date_STAY.Size = New System.Drawing.Size(227, 20)
        Me.date_STAY.TabIndex = 4
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.SimpleButton1)
        Me.GroupControl3.Controls.Add(Me.bt_del)
        Me.GroupControl3.Controls.Add(Me.bt_back)
        Me.GroupControl3.Controls.Add(Me.bt_edit)
        Me.GroupControl3.Controls.Add(Me.bt_save)
        Me.GroupControl3.Location = New System.Drawing.Point(18, 156)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(784, 72)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "العمليات"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(640, 30)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 32)
        Me.SimpleButton1.TabIndex = 47
        Me.SimpleButton1.Text = "جديد"
        '
        'bt_del
        '
        Me.bt_del.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_del.Appearance.Options.UseFont = True
        Me.bt_del.Image = CType(resources.GetObject("bt_del.Image"), System.Drawing.Image)
        Me.bt_del.Location = New System.Drawing.Point(223, 30)
        Me.bt_del.Name = "bt_del"
        Me.bt_del.Size = New System.Drawing.Size(75, 32)
        Me.bt_del.TabIndex = 2
        Me.bt_del.Text = "حذف"
        '
        'bt_back
        '
        Me.bt_back.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_back.Appearance.Options.UseFont = True
        Me.bt_back.Image = CType(resources.GetObject("bt_back.Image"), System.Drawing.Image)
        Me.bt_back.Location = New System.Drawing.Point(76, 30)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(75, 32)
        Me.bt_back.TabIndex = 3
        Me.bt_back.Text = "رجوع"
        '
        'bt_edit
        '
        Me.bt_edit.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_edit.Appearance.Options.UseFont = True
        Me.bt_edit.Image = CType(resources.GetObject("bt_edit.Image"), System.Drawing.Image)
        Me.bt_edit.Location = New System.Drawing.Point(362, 30)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(75, 32)
        Me.bt_edit.TabIndex = 1
        Me.bt_edit.Text = "تعديل"
        '
        'bt_save
        '
        Me.bt_save.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_save.Appearance.Options.UseFont = True
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.Location = New System.Drawing.Point(503, 30)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(75, 32)
        Me.bt_save.TabIndex = 0
        Me.bt_save.Text = "حفظ"
        '
        'groupControl2
        '
        Me.groupControl2.Controls.Add(Me.GRID_EMP)
        Me.groupControl2.Location = New System.Drawing.Point(4, 234)
        Me.groupControl2.Name = "groupControl2"
        Me.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.groupControl2.Size = New System.Drawing.Size(813, 281)
        Me.groupControl2.TabIndex = 6
        Me.groupControl2.Text = "لائحة الموظفين"
        '
        'GRID_EMP
        '
        Me.GRID_EMP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GRID_EMP.Location = New System.Drawing.Point(2, 20)
        Me.GRID_EMP.MainView = Me.GridView1
        Me.GRID_EMP.Name = "GRID_EMP"
        Me.GRID_EMP.Size = New System.Drawing.Size(809, 259)
        Me.GRID_EMP.TabIndex = 0
        Me.GRID_EMP.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GRID_EMP
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'Emp_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 520)
        Me.Controls.Add(Me.groupControl2)
        Me.Controls.Add(Me.groupControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Emp_form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نافذة إدارة الموظفين"
        CType(Me.txt_stay_NO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_salary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_job.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl1.ResumeLayout(False)
        Me.groupControl1.PerformLayout()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_STAY.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_STAY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl2.ResumeLayout(False)
        CType(Me.GRID_EMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txt_stay_NO As DevExpress.XtraEditors.TextEdit
    Private WithEvents txt_salary As DevExpress.XtraEditors.TextEdit
    Private WithEvents txt_job As DevExpress.XtraEditors.TextEdit
    Private WithEvents txt_name As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl6 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl5 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents groupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bt_back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_save As DevExpress.XtraEditors.SimpleButton
    Private WithEvents bt_del As DevExpress.XtraEditors.SimpleButton
    Private WithEvents groupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents date_STAY As DevExpress.XtraEditors.DateEdit

    Private WithEvents TXT_ID As DevExpress.XtraEditors.TextEdit
    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GRID_EMP As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView

End Class
