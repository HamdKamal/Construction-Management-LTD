<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Workers))
        Me.txt_mony = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_new = New DevExpress.XtraEditors.SimpleButton()
        Me.TXT_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.Combo_Pro = New System.Windows.Forms.ComboBox()
        Me.combo_Worker = New System.Windows.Forms.ComboBox()
        Me.bt_back = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_edite = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_save = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Date_Pay = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_Worker = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.txt_mony.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl1.SuspendLayout()
        CType(Me.TXT_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_Pay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_Pay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Grid_Worker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_mony
        '
        Me.txt_mony.Location = New System.Drawing.Point(440, 131)
        Me.txt_mony.Name = "txt_mony"
        Me.txt_mony.Properties.Mask.EditMask = "n0"
        Me.txt_mony.Size = New System.Drawing.Size(123, 20)
        Me.txt_mony.TabIndex = 31
        '
        'labelControl4
        '
        Me.labelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl4.Location = New System.Drawing.Point(566, 132)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(38, 17)
        Me.labelControl4.TabIndex = 21
        Me.labelControl4.Text = "المبلغ :"
        '
        'labelControl3
        '
        Me.labelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl3.Location = New System.Drawing.Point(566, 98)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(53, 17)
        Me.labelControl3.TabIndex = 20
        Me.labelControl3.Text = "المشروع :"
        '
        'labelControl2
        '
        Me.labelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl2.Location = New System.Drawing.Point(566, 65)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(61, 17)
        Me.labelControl2.TabIndex = 19
        Me.labelControl2.Text = "إسم العامل :"
        '
        'groupControl1
        '
        Me.groupControl1.Controls.Add(Me.lbl_name)
        Me.groupControl1.Controls.Add(Me.SimpleButton1)
        Me.groupControl1.Controls.Add(Me.SimpleButton3)
        Me.groupControl1.Controls.Add(Me.bt_new)
        Me.groupControl1.Controls.Add(Me.TXT_id)
        Me.groupControl1.Controls.Add(Me.LabelControl6)
        Me.groupControl1.Controls.Add(Me.Combo_Pro)
        Me.groupControl1.Controls.Add(Me.combo_Worker)
        Me.groupControl1.Controls.Add(Me.bt_back)
        Me.groupControl1.Controls.Add(Me.bt_edite)
        Me.groupControl1.Controls.Add(Me.bt_save)
        Me.groupControl1.Controls.Add(Me.txt_note)
        Me.groupControl1.Controls.Add(Me.LabelControl5)
        Me.groupControl1.Controls.Add(Me.Date_Pay)
        Me.groupControl1.Controls.Add(Me.LabelControl1)
        Me.groupControl1.Controls.Add(Me.GroupControl2)
        Me.groupControl1.Controls.Add(Me.txt_mony)
        Me.groupControl1.Controls.Add(Me.labelControl4)
        Me.groupControl1.Controls.Add(Me.labelControl3)
        Me.groupControl1.Controls.Add(Me.labelControl2)
        Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupControl1.Location = New System.Drawing.Point(0, 0)
        Me.groupControl1.Name = "groupControl1"
        Me.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.groupControl1.Size = New System.Drawing.Size(656, 511)
        Me.groupControl1.TabIndex = 2
        Me.groupControl1.Text = "مصاريف العمالة"
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(43, 34)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 25)
        Me.lbl_name.TabIndex = 82
        Me.lbl_name.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(338, 97)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 29)
        Me.SimpleButton1.TabIndex = 80
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(338, 62)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(38, 29)
        Me.SimpleButton3.TabIndex = 79
        Me.SimpleButton3.Text = "SimpleButton3"
        '
        'bt_new
        '
        Me.bt_new.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_new.Appearance.Options.UseFont = True
        Me.bt_new.Image = CType(resources.GetObject("bt_new.Image"), System.Drawing.Image)
        Me.bt_new.Location = New System.Drawing.Point(399, 177)
        Me.bt_new.Name = "bt_new"
        Me.bt_new.Size = New System.Drawing.Size(75, 32)
        Me.bt_new.TabIndex = 65
        Me.bt_new.Text = "جديد"
        '
        'TXT_id
        '
        Me.TXT_id.Location = New System.Drawing.Point(440, 33)
        Me.TXT_id.Name = "TXT_id"
        Me.TXT_id.Properties.ReadOnly = True
        Me.TXT_id.Size = New System.Drawing.Size(123, 20)
        Me.TXT_id.TabIndex = 64
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Location = New System.Drawing.Point(566, 34)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(82, 17)
        Me.LabelControl6.TabIndex = 63
        Me.LabelControl6.Text = "معرف الصرف : "
        '
        'Combo_Pro
        '
        Me.Combo_Pro.FormattingEnabled = True
        Me.Combo_Pro.Location = New System.Drawing.Point(378, 98)
        Me.Combo_Pro.Name = "Combo_Pro"
        Me.Combo_Pro.Size = New System.Drawing.Size(186, 21)
        Me.Combo_Pro.TabIndex = 62
        '
        'combo_Worker
        '
        Me.combo_Worker.FormattingEnabled = True
        Me.combo_Worker.Location = New System.Drawing.Point(378, 66)
        Me.combo_Worker.Name = "combo_Worker"
        Me.combo_Worker.Size = New System.Drawing.Size(186, 21)
        Me.combo_Worker.TabIndex = 61
        '
        'bt_back
        '
        Me.bt_back.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_back.Appearance.Options.UseFont = True
        Me.bt_back.Image = CType(resources.GetObject("bt_back.Image"), System.Drawing.Image)
        Me.bt_back.Location = New System.Drawing.Point(156, 177)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(75, 32)
        Me.bt_back.TabIndex = 60
        Me.bt_back.Text = "رجوع"
        '
        'bt_edite
        '
        Me.bt_edite.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_edite.Appearance.Options.UseFont = True
        Me.bt_edite.Image = CType(resources.GetObject("bt_edite.Image"), System.Drawing.Image)
        Me.bt_edite.Location = New System.Drawing.Point(237, 177)
        Me.bt_edite.Name = "bt_edite"
        Me.bt_edite.Size = New System.Drawing.Size(75, 32)
        Me.bt_edite.TabIndex = 59
        Me.bt_edite.Text = "تعديل"
        '
        'bt_save
        '
        Me.bt_save.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_save.Appearance.Options.UseFont = True
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.Location = New System.Drawing.Point(318, 177)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(75, 32)
        Me.bt_save.TabIndex = 58
        Me.bt_save.Text = "حفظ"
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(43, 66)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(224, 53)
        Me.txt_note.TabIndex = 54
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Location = New System.Drawing.Point(269, 65)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 17)
        Me.LabelControl5.TabIndex = 53
        Me.LabelControl5.Text = "ملاحظة :"
        '
        'Date_Pay
        '
        Me.Date_Pay.EditValue = Nothing
        Me.Date_Pay.Location = New System.Drawing.Point(43, 131)
        Me.Date_Pay.Name = "Date_Pay"
        Me.Date_Pay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Pay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Pay.Size = New System.Drawing.Size(224, 20)
        Me.Date_Pay.TabIndex = 52
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(269, 130)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 17)
        Me.LabelControl1.TabIndex = 51
        Me.LabelControl1.Text = "التاريخ :"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Grid_Worker)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 232)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(650, 275)
        Me.GroupControl2.TabIndex = 50
        Me.GroupControl2.Text = "عرض مصاريف العمالة"
        '
        'Grid_Worker
        '
        Me.Grid_Worker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Worker.Location = New System.Drawing.Point(2, 20)
        Me.Grid_Worker.MainView = Me.GridView1
        Me.Grid_Worker.Name = "Grid_Worker"
        Me.Grid_Worker.Size = New System.Drawing.Size(646, 253)
        Me.Grid_Worker.TabIndex = 5
        Me.Grid_Worker.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_Worker
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'Workers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 511)
        Me.Controls.Add(Me.groupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Workers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نافذة مصاريف العمال"
        CType(Me.txt_mony.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl1.ResumeLayout(False)
        Me.groupControl1.PerformLayout()
        CType(Me.TXT_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_Pay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_Pay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Grid_Worker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txt_mony As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents groupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid_Worker As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Date_Pay As DevExpress.XtraEditors.DateEdit
    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Private WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bt_back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_edite As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Combo_Pro As System.Windows.Forms.ComboBox
    Friend WithEvents combo_Worker As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bt_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
End Class
