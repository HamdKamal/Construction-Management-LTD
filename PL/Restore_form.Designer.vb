<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restore_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restore_form))
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.bt_close = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_Restore = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_path = New System.Windows.Forms.TextBox()
        Me.bt_select_path = New DevExpress.XtraEditors.SimpleButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_name = New DevExpress.XtraEditors.LabelControl()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.lbl_name)
        Me.groupBox2.Controls.Add(Me.bt_close)
        Me.groupBox2.Controls.Add(Me.bt_Restore)
        Me.groupBox2.Controls.Add(Me.txt_path)
        Me.groupBox2.Controls.Add(Me.bt_select_path)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.ForeColor = System.Drawing.Color.Black
        Me.groupBox2.Location = New System.Drawing.Point(2, 1)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(600, 195)
        Me.groupBox2.TabIndex = 31
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "إستعادة النسخة الإحتياطية"
        '
        'bt_close
        '
        Me.bt_close.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_close.Appearance.Options.UseFont = True
        Me.bt_close.Image = CType(resources.GetObject("bt_close.Image"), System.Drawing.Image)
        Me.bt_close.Location = New System.Drawing.Point(37, 128)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(65, 30)
        Me.bt_close.TabIndex = 37
        Me.bt_close.Text = "إلغاء"
        '
        'bt_Restore
        '
        Me.bt_Restore.Appearance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.bt_Restore.Appearance.Options.UseFont = True
        Me.bt_Restore.Image = CType(resources.GetObject("bt_Restore.Image"), System.Drawing.Image)
        Me.bt_Restore.Location = New System.Drawing.Point(117, 128)
        Me.bt_Restore.Name = "bt_Restore"
        Me.bt_Restore.Size = New System.Drawing.Size(223, 30)
        Me.bt_Restore.TabIndex = 35
        Me.bt_Restore.Text = "إستعادة النسخة الإحتياطية"
        '
        'txt_path
        '
        Me.txt_path.Location = New System.Drawing.Point(117, 66)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.ReadOnly = True
        Me.txt_path.Size = New System.Drawing.Size(412, 21)
        Me.txt_path.TabIndex = 33
        '
        'bt_select_path
        '
        Me.bt_select_path.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.bt_select_path.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomLeft
        Me.bt_select_path.Location = New System.Drawing.Point(37, 66)
        Me.bt_select_path.Name = "bt_select_path"
        Me.bt_select_path.Size = New System.Drawing.Size(65, 20)
        Me.bt_select_path.TabIndex = 31
        Me.bt_select_path.Text = "..."
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.label1.Location = New System.Drawing.Point(301, 36)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(250, 17)
        Me.label1.TabIndex = 29
        Me.label1.Text = "رجاء قم بتحديد مسار تواجد النسخة الإحتياطية ..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_name.Appearance.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_name.Location = New System.Drawing.Point(491, 133)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 25)
        Me.lbl_name.TabIndex = 84
        Me.lbl_name.Visible = False
        '
        'Restore_form
        '
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 197)
        Me.Controls.Add(Me.groupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Restore_form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نافذة إستعادة النسخة الإحتياطية"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents bt_close As DevExpress.XtraEditors.SimpleButton
    Private WithEvents bt_Restore As DevExpress.XtraEditors.SimpleButton
    Private WithEvents txt_path As System.Windows.Forms.TextBox
    Private WithEvents bt_select_path As DevExpress.XtraEditors.SimpleButton
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents lbl_name As DevExpress.XtraEditors.LabelControl
End Class
