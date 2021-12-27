<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class System_Conf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(System_Conf))
        Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.RB_WIN = New System.Windows.Forms.RadioButton()
        Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_BASE = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_SERVER = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BT_SAVE = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupControl1.SuspendLayout()
        CType(Me.TXT_BASE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_SERVER.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupControl1
        '
        Me.groupControl1.Controls.Add(Me.RB_WIN)
        Me.groupControl1.Controls.Add(Me.labelControl5)
        Me.groupControl1.Controls.Add(Me.TXT_BASE)
        Me.groupControl1.Controls.Add(Me.labelControl2)
        Me.groupControl1.Controls.Add(Me.TXT_SERVER)
        Me.groupControl1.Controls.Add(Me.labelControl1)
        Me.groupControl1.Location = New System.Drawing.Point(6, 5)
        Me.groupControl1.Name = "groupControl1"
        Me.groupControl1.Size = New System.Drawing.Size(347, 148)
        Me.groupControl1.TabIndex = 15
        Me.groupControl1.Text = " ... ربط الإتصال"
        '
        'RB_WIN
        '
        Me.RB_WIN.AutoSize = True
        Me.RB_WIN.Checked = True
        Me.RB_WIN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_WIN.Location = New System.Drawing.Point(39, 110)
        Me.RB_WIN.Name = "RB_WIN"
        Me.RB_WIN.Size = New System.Drawing.Size(195, 23)
        Me.RB_WIN.TabIndex = 17
        Me.RB_WIN.TabStop = True
        Me.RB_WIN.Text = "Windows Authentiocation"
        Me.RB_WIN.UseVisualStyleBackColor = True
        '
        'labelControl5
        '
        Me.labelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.labelControl5.Location = New System.Drawing.Point(235, 112)
        Me.labelControl5.Name = "labelControl5"
        Me.labelControl5.Size = New System.Drawing.Size(79, 19)
        Me.labelControl5.TabIndex = 16
        Me.labelControl5.Text = "طريقة الولوج :"
        '
        'TXT_BASE
        '
        Me.TXT_BASE.Location = New System.Drawing.Point(18, 73)
        Me.TXT_BASE.Name = "TXT_BASE"
        Me.TXT_BASE.Properties.ReadOnly = True
        Me.TXT_BASE.Size = New System.Drawing.Size(215, 20)
        Me.TXT_BASE.TabIndex = 15
        '
        'labelControl2
        '
        Me.labelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.labelControl2.Location = New System.Drawing.Point(235, 73)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(87, 22)
        Me.labelControl2.TabIndex = 14
        Me.labelControl2.Text = "قاعدة البيانات:"
        '
        'TXT_SERVER
        '
        Me.TXT_SERVER.Location = New System.Drawing.Point(19, 37)
        Me.TXT_SERVER.Name = "TXT_SERVER"
        Me.TXT_SERVER.Size = New System.Drawing.Size(214, 20)
        Me.TXT_SERVER.TabIndex = 13
        '
        'labelControl1
        '
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.labelControl1.Location = New System.Drawing.Point(235, 37)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(80, 22)
        Me.labelControl1.TabIndex = 12
        Me.labelControl1.Text = "أسم السيرفر:"
        '
        'BT_SAVE
        '
        Me.BT_SAVE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.BT_SAVE.Image = CType(resources.GetObject("BT_SAVE.Image"), System.Drawing.Image)
        Me.BT_SAVE.Location = New System.Drawing.Point(136, 159)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.Size = New System.Drawing.Size(104, 32)
        Me.BT_SAVE.TabIndex = 14
        Me.BT_SAVE.Text = "حفظ"
        '
        'System_Conf
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 198)
        Me.Controls.Add(Me.groupControl1)
        Me.Controls.Add(Me.BT_SAVE)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "System_Conf"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إعدادات الإتصال بالسيرفر ..."
        CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupControl1.ResumeLayout(False)
        Me.groupControl1.PerformLayout()
        CType(Me.TXT_BASE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_SERVER.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents RB_WIN As System.Windows.Forms.RadioButton
    Private WithEvents labelControl5 As DevExpress.XtraEditors.LabelControl
    Private WithEvents TXT_BASE As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents TXT_SERVER As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents BT_SAVE As DevExpress.XtraEditors.SimpleButton
End Class
