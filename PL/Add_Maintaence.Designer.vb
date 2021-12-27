<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Maintaence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Maintaence))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_name = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.bt_save = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txt_name)
        Me.GroupControl1.Controls.Add(Me.labelControl4)
        Me.GroupControl1.Location = New System.Drawing.Point(6, 7)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(272, 84)
        Me.GroupControl1.TabIndex = 35
        Me.GroupControl1.Text = "أدخل نوع الصرف"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(6, 43)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(187, 20)
        Me.txt_name.TabIndex = 33
        '
        'labelControl4
        '
        Me.labelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labelControl4.Location = New System.Drawing.Point(196, 44)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(64, 17)
        Me.labelControl4.TabIndex = 32
        Me.labelControl4.Text = "أسم الصرف:"
        '
        'bt_save
        '
        Me.bt_save.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_save.Appearance.Options.UseFont = True
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.Location = New System.Drawing.Point(108, 107)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(75, 32)
        Me.bt_save.TabIndex = 36
        Me.bt_save.Text = "إضافة"
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(215, 111)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 25)
        Me.lbl_name.TabIndex = 80
        Me.lbl_name.Visible = False
        '
        'Add_Maintaence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 148)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.bt_save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_Maintaence"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة مصروفات السيارة"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents txt_name As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bt_save As DevExpress.XtraEditors.SimpleButton
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
End Class
