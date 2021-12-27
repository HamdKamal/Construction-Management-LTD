<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_item))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TXT_NAME = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_ID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_MainCat = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.bt_back = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_del = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_edit = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_add = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TXT_NAME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Grid_MainCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TXT_NAME)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.TXT_ID)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(4, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(484, 103)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "بيانات البند"
        '
        'TXT_NAME
        '
        Me.TXT_NAME.Location = New System.Drawing.Point(131, 69)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(219, 20)
        Me.TXT_NAME.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(352, 71)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "إسم البند الرئيسي :"
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(240, 32)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Properties.Mask.BeepOnError = True
        Me.TXT_ID.Properties.Mask.EditMask = "n0"
        Me.TXT_ID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TXT_ID.Properties.ReadOnly = True
        Me.TXT_ID.Size = New System.Drawing.Size(110, 20)
        Me.TXT_ID.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(352, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "معرف البند الرئيسي :"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Grid_MainCat)
        Me.GroupControl2.Location = New System.Drawing.Point(4, 209)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(486, 331)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "البنود الرئيسية"
        '
        'Grid_MainCat
        '
        Me.Grid_MainCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_MainCat.Location = New System.Drawing.Point(2, 20)
        Me.Grid_MainCat.MainView = Me.GridView1
        Me.Grid_MainCat.Name = "Grid_MainCat"
        Me.Grid_MainCat.Size = New System.Drawing.Size(482, 309)
        Me.Grid_MainCat.TabIndex = 0
        Me.Grid_MainCat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_MainCat
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'bt_back
        '
        Me.bt_back.Image = CType(resources.GetObject("bt_back.Image"), System.Drawing.Image)
        Me.bt_back.Location = New System.Drawing.Point(40, 32)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(75, 33)
        Me.bt_back.TabIndex = 10
        Me.bt_back.Text = "رجوع"
        '
        'bt_del
        '
        Me.bt_del.Image = CType(resources.GetObject("bt_del.Image"), System.Drawing.Image)
        Me.bt_del.Location = New System.Drawing.Point(127, 32)
        Me.bt_del.Name = "bt_del"
        Me.bt_del.Size = New System.Drawing.Size(75, 33)
        Me.bt_del.TabIndex = 9
        Me.bt_del.Text = "حذف"
        '
        'bt_edit
        '
        Me.bt_edit.Image = CType(resources.GetObject("bt_edit.Image"), System.Drawing.Image)
        Me.bt_edit.Location = New System.Drawing.Point(214, 32)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(75, 33)
        Me.bt_edit.TabIndex = 8
        Me.bt_edit.Text = "تعديل"
        '
        'bt_add
        '
        Me.bt_add.Image = CType(resources.GetObject("bt_add.Image"), System.Drawing.Image)
        Me.bt_add.Location = New System.Drawing.Point(300, 32)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(75, 33)
        Me.bt_add.TabIndex = 7
        Me.bt_add.Text = "إضافة"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.SimpleButton1)
        Me.GroupControl3.Controls.Add(Me.bt_edit)
        Me.GroupControl3.Controls.Add(Me.bt_back)
        Me.GroupControl3.Controls.Add(Me.bt_add)
        Me.GroupControl3.Controls.Add(Me.bt_del)
        Me.GroupControl3.Location = New System.Drawing.Point(4, 111)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(484, 92)
        Me.GroupControl3.TabIndex = 11
        Me.GroupControl3.Text = "العمليات المتاحة"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(391, 32)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(38, 33)
        Me.SimpleButton1.TabIndex = 11
        '
        'main_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 542)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main_item"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "البنود الرئيسية"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TXT_NAME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Grid_MainCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TXT_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Grid_MainCat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TXT_NAME As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bt_back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
