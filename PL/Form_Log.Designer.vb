<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Log
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Log))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.passTxt = New DevExpress.XtraEditors.TextEdit()
        Me.NameTxt = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.loginBtn = New DevExpress.XtraEditors.CheckButton()
        Me.closeBtn = New DevExpress.XtraEditors.CheckButton()
        Me.groupBox1.SuspendLayout()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.PictureEdit3)
        Me.groupBox1.Controls.Add(Me.PictureEdit2)
        Me.groupBox1.Controls.Add(Me.PictureEdit1)
        Me.groupBox1.Controls.Add(Me.passTxt)
        Me.groupBox1.Controls.Add(Me.NameTxt)
        Me.groupBox1.Controls.Add(Me.labelControl2)
        Me.groupBox1.Controls.Add(Me.labelControl1)
        Me.groupBox1.Controls.Add(Me.loginBtn)
        Me.groupBox1.Controls.Add(Me.closeBtn)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(0, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(484, 211)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "تسجيل الدخول للنظام"
        '
        'PictureEdit3
        '
        Me.PictureEdit3.EditValue = CType(resources.GetObject("PictureEdit3.EditValue"), Object)
        Me.PictureEdit3.Location = New System.Drawing.Point(136, 91)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit3.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit3.Size = New System.Drawing.Size(31, 20)
        Me.PictureEdit3.TabIndex = 18
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(136, 53)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit2.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit2.Size = New System.Drawing.Size(31, 20)
        Me.PictureEdit2.TabIndex = 17
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = Global.نظام_إدارة_شركة_مقاولات.My.Resources.Resources.Logo
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 2)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(129, 209)
        Me.PictureEdit1.TabIndex = 16
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(173, 91)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passTxt.Size = New System.Drawing.Size(203, 20)
        Me.passTxt.TabIndex = 1
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(173, 53)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(203, 20)
        Me.NameTxt.TabIndex = 0
        '
        'labelControl2
        '
        Me.labelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelControl2.Appearance.Options.UseFont = True
        Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.labelControl2.Location = New System.Drawing.Point(393, 94)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(68, 17)
        Me.labelControl2.TabIndex = 15
        Me.labelControl2.Text = "كلمة المرور :"
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelControl1.Appearance.Options.UseFont = True
        Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.labelControl1.Location = New System.Drawing.Point(393, 53)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(79, 17)
        Me.labelControl1.TabIndex = 14
        Me.labelControl1.Text = "إسم المستخدم :"
        '
        'loginBtn
        '
        Me.loginBtn.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.Appearance.Options.UseFont = True
        Me.loginBtn.ImageOptions.Image = CType(resources.GetObject("loginBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.loginBtn.Location = New System.Drawing.Point(260, 138)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(116, 35)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.Text = "تسجيل الدخول"
        '
        'closeBtn
        '
        Me.closeBtn.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Appearance.Options.UseFont = True
        Me.closeBtn.ImageOptions.Image = CType(resources.GetObject("closeBtn.ImageOptions.Image"), System.Drawing.Image)
        Me.closeBtn.Location = New System.Drawing.Point(173, 138)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(70, 35)
        Me.closeBtn.TabIndex = 3
        Me.closeBtn.Text = "إلغاء"
        '
        'Form_Log
        '
        Me.AcceptButton = Me.loginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 211)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Log"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نافذة الدخول"
        Me.groupBox1.ResumeLayout(False)
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents passTxt As DevExpress.XtraEditors.TextEdit
    Public WithEvents NameTxt As DevExpress.XtraEditors.TextEdit
    Public WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Public WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents loginBtn As DevExpress.XtraEditors.CheckButton
    Public WithEvents closeBtn As DevExpress.XtraEditors.CheckButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
End Class
