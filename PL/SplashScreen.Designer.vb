<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits DevExpress.XtraSplashScreen.SplashScreen

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.marqueeProgressBarControl1 = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(23, 243)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(106, 13)
        Me.labelControl2.TabIndex = 12
        Me.labelControl2.Text = "جاري تشغيل النظام ..."
        '
        'labelControl1
        '
        Me.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.labelControl1.Location = New System.Drawing.Point(23, 286)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(126, 13)
        Me.labelControl1.TabIndex = 11
        Me.labelControl1.Text = "Smart Vision © 2013-2019"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3500
        '
        'marqueeProgressBarControl1
        '
        Me.marqueeProgressBarControl1.EditValue = 0
        Me.marqueeProgressBarControl1.Location = New System.Drawing.Point(23, 268)
        Me.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1"
        Me.marqueeProgressBarControl1.Size = New System.Drawing.Size(404, 12)
        Me.marqueeProgressBarControl1.TabIndex = 15
        '
        'PictureEdit3
        '
        Me.PictureEdit3.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit3.EditValue = Global.نظام_إدارة_شركة_مقاولات.My.Resources.Resources.Title
        Me.PictureEdit3.Location = New System.Drawing.Point(44, 181)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.AllowFocused = False
        Me.PictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Properties.InitialImage = CType(resources.GetObject("PictureEdit3.Properties.InitialImage"), System.Drawing.Image)
        Me.PictureEdit3.Properties.ShowMenu = False
        Me.PictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit3.Size = New System.Drawing.Size(361, 60)
        Me.PictureEdit3.TabIndex = 16
        '
        'pictureEdit2
        '
        Me.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureEdit2.EditValue = Global.نظام_إدارة_شركة_مقاولات.My.Resources.Resources.Logo
        Me.pictureEdit2.Location = New System.Drawing.Point(152, 5)
        Me.pictureEdit2.Name = "pictureEdit2"
        Me.pictureEdit2.Properties.AllowFocused = False
        Me.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit2.Properties.InitialImage = CType(resources.GetObject("pictureEdit2.Properties.InitialImage"), System.Drawing.Image)
        Me.pictureEdit2.Properties.ShowMenu = False
        Me.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pictureEdit2.Size = New System.Drawing.Size(153, 178)
        Me.pictureEdit2.TabIndex = 14
        '
        'pictureEdit1
        '
        Me.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureEdit1.EditValue = Global.نظام_إدارة_شركة_مقاولات.My.Resources.Resources.photo5929367884918795990
        Me.pictureEdit1.Location = New System.Drawing.Point(353, 284)
        Me.pictureEdit1.Name = "pictureEdit1"
        Me.pictureEdit1.Properties.AllowFocused = False
        Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit1.Properties.ShowMenu = False
        Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pictureEdit1.Size = New System.Drawing.Size(74, 32)
        Me.pictureEdit1.TabIndex = 13
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 320)
        Me.Controls.Add(Me.PictureEdit3)
        Me.Controls.Add(Me.marqueeProgressBarControl1)
        Me.Controls.Add(Me.pictureEdit2)
        Me.Controls.Add(Me.pictureEdit1)
        Me.Controls.Add(Me.labelControl2)
        Me.Controls.Add(Me.labelControl1)
        Me.Name = "SplashScreen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "SplashScreen"
        CType(Me.marqueeProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents pictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents labelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents marqueeProgressBarControl1 As DevExpress.XtraEditors.MarqueeProgressBarControl
    Private WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
End Class
