<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(users))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PIC_S = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_pass = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.combo_Type = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_fullName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_conf_pass = New DevExpress.XtraEditors.TextEdit()
        Me.txt_pass = New DevExpress.XtraEditors.TextEdit()
        Me.txt_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_user = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_id_user = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PIC_S.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fullName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_conf_pass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Grid_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lbl_id_user)
        Me.GroupControl1.Controls.Add(Me.PIC_S)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.lbl_pass)
        Me.GroupControl1.Controls.Add(Me.lbl_name)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.combo_Type)
        Me.GroupControl1.Controls.Add(Me.txt_id)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_fullName)
        Me.GroupControl1.Controls.Add(Me.txt_conf_pass)
        Me.GroupControl1.Controls.Add(Me.txt_pass)
        Me.GroupControl1.Controls.Add(Me.txt_name)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 7)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(545, 213)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "بيانات المستخدم"
        '
        'PIC_S
        '
        Me.PIC_S.EditValue = CType(resources.GetObject("PIC_S.EditValue"), Object)
        Me.PIC_S.Location = New System.Drawing.Point(276, 152)
        Me.PIC_S.Name = "PIC_S"
        Me.PIC_S.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PIC_S.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PIC_S.Size = New System.Drawing.Size(173, 45)
        Me.PIC_S.TabIndex = 84
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(452, 153)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(30, 15)
        Me.LabelControl7.TabIndex = 83
        Me.LabelControl7.Text = "التوقيع"
        '
        'lbl_pass
        '
        Me.lbl_pass.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_pass.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_pass.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_pass.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_pass.Location = New System.Drawing.Point(276, 51)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(57, 20)
        Me.lbl_pass.TabIndex = 82
        Me.lbl_pass.Visible = False
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(276, 23)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 20)
        Me.lbl_name.TabIndex = 81
        Me.lbl_name.Visible = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(191, 46)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 17)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "نوع المستخدم"
        '
        'combo_Type
        '
        Me.combo_Type.EditValue = ""
        Me.combo_Type.Enabled = False
        Me.combo_Type.Location = New System.Drawing.Point(25, 44)
        Me.combo_Type.Name = "combo_Type"
        Me.combo_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.combo_Type.Properties.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.combo_Type.Size = New System.Drawing.Size(162, 20)
        Me.combo_Type.TabIndex = 10
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(358, 44)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Properties.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(91, 20)
        Me.txt_id.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(453, 46)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 15)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "معرف المستخدم"
        '
        'txt_fullName
        '
        Me.txt_fullName.Location = New System.Drawing.Point(25, 76)
        Me.txt_fullName.Name = "txt_fullName"
        Me.txt_fullName.Size = New System.Drawing.Size(162, 20)
        Me.txt_fullName.TabIndex = 7
        '
        'txt_conf_pass
        '
        Me.txt_conf_pass.Location = New System.Drawing.Point(25, 117)
        Me.txt_conf_pass.Name = "txt_conf_pass"
        Me.txt_conf_pass.Size = New System.Drawing.Size(162, 20)
        Me.txt_conf_pass.TabIndex = 6
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(276, 115)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(173, 20)
        Me.txt_pass.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(276, 77)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(173, 20)
        Me.txt_name.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(189, 119)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(79, 17)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "تأكيد كلمة المرور"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(452, 118)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 15)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "كلمة المرور"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(190, 76)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 17)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "الإسم الكامل"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(453, 79)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "إسم المستخدم"
        '
        'simpleButton3
        '
        Me.simpleButton3.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.simpleButton3.Appearance.Options.UseFont = True
        Me.simpleButton3.Image = CType(resources.GetObject("simpleButton3.Image"), System.Drawing.Image)
        Me.simpleButton3.Location = New System.Drawing.Point(328, 226)
        Me.simpleButton3.Name = "simpleButton3"
        Me.simpleButton3.Size = New System.Drawing.Size(75, 32)
        Me.simpleButton3.TabIndex = 47
        Me.simpleButton3.Text = "حذف"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(245, 226)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 32)
        Me.SimpleButton2.TabIndex = 50
        Me.SimpleButton2.Text = "تعديل"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(413, 226)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 32)
        Me.SimpleButton1.TabIndex = 51
        Me.SimpleButton1.Text = "رجوع"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(160, 226)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 32)
        Me.SimpleButton5.TabIndex = 49
        Me.SimpleButton5.Text = "حفظ"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Grid_user)
        Me.GroupControl2.Location = New System.Drawing.Point(5, 264)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(546, 240)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "لائحة المستخدمين"
        '
        'Grid_user
        '
        Me.Grid_user.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_user.Location = New System.Drawing.Point(2, 20)
        Me.Grid_user.MainView = Me.GridView1
        Me.Grid_user.Name = "Grid_user"
        Me.Grid_user.Size = New System.Drawing.Size(542, 218)
        Me.Grid_user.TabIndex = 0
        Me.Grid_user.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_user
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(79, 226)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 32)
        Me.SimpleButton4.TabIndex = 52
        Me.SimpleButton4.Text = "جديد"
        '
        'lbl_id_user
        '
        Me.lbl_id_user.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_id_user.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_id_user.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_id_user.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_id_user.Location = New System.Drawing.Point(51, 177)
        Me.lbl_id_user.Name = "lbl_id_user"
        Me.lbl_id_user.Size = New System.Drawing.Size(57, 20)
        Me.lbl_id_user.TabIndex = 85
        Me.lbl_id_user.Visible = False
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 510)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.simpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "users"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إدارة المستخدمين"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PIC_S.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fullName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_conf_pass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Grid_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_fullName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_conf_pass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_pass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_name As DevExpress.XtraEditors.TextEdit
    Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Grid_user As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents combo_Type As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents lbl_pass As DevExpress.XtraEditors.LabelControl
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PIC_S As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Public WithEvents lbl_id_user As DevExpress.XtraEditors.LabelControl
End Class
