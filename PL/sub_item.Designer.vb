<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sub_item
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sub_item))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Grid_SubCat = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_id = New DevExpress.XtraEditors.TextEdit()
        Me.combo_MainCat = New System.Windows.Forms.ComboBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.bt_back = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_del = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_edit = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_save = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_Sub_Name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Grid_SubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Sub_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Grid_SubCat)
        Me.GroupControl2.Location = New System.Drawing.Point(6, 182)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(467, 311)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "البنود الفرعية"
        '
        'Grid_SubCat
        '
        Me.Grid_SubCat.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.Grid_SubCat.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Grid_SubCat.Location = New System.Drawing.Point(2, 20)
        Me.Grid_SubCat.MainView = Me.GridView1
        Me.Grid_SubCat.Name = "Grid_SubCat"
        Me.Grid_SubCat.Size = New System.Drawing.Size(463, 289)
        Me.Grid_SubCat.TabIndex = 0
        Me.Grid_SubCat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid_SubCat
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_id)
        Me.GroupControl1.Controls.Add(Me.combo_MainCat)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.bt_back)
        Me.GroupControl1.Controls.Add(Me.bt_del)
        Me.GroupControl1.Controls.Add(Me.bt_edit)
        Me.GroupControl1.Controls.Add(Me.bt_save)
        Me.GroupControl1.Controls.Add(Me.txt_Sub_Name)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(6, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(467, 174)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "بيانات البند"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(357, 127)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 33)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "جديد"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(335, 32)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "معرف البند الفرعي :"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(239, 29)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Properties.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(93, 20)
        Me.txt_id.TabIndex = 10
        '
        'combo_MainCat
        '
        Me.combo_MainCat.FormattingEnabled = True
        Me.combo_MainCat.Location = New System.Drawing.Point(70, 61)
        Me.combo_MainCat.Name = "combo_MainCat"
        Me.combo_MainCat.Size = New System.Drawing.Size(262, 21)
        Me.combo_MainCat.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(336, 96)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "اسم البند الفرعي :"
        '
        'bt_back
        '
        Me.bt_back.Image = CType(resources.GetObject("bt_back.Image"), System.Drawing.Image)
        Me.bt_back.Location = New System.Drawing.Point(20, 128)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(75, 33)
        Me.bt_back.TabIndex = 6
        Me.bt_back.Text = "رجوع"
        '
        'bt_del
        '
        Me.bt_del.Image = CType(resources.GetObject("bt_del.Image"), System.Drawing.Image)
        Me.bt_del.Location = New System.Drawing.Point(104, 128)
        Me.bt_del.Name = "bt_del"
        Me.bt_del.Size = New System.Drawing.Size(75, 33)
        Me.bt_del.TabIndex = 5
        Me.bt_del.Text = "حذف"
        '
        'bt_edit
        '
        Me.bt_edit.Image = CType(resources.GetObject("bt_edit.Image"), System.Drawing.Image)
        Me.bt_edit.Location = New System.Drawing.Point(189, 128)
        Me.bt_edit.Name = "bt_edit"
        Me.bt_edit.Size = New System.Drawing.Size(75, 33)
        Me.bt_edit.TabIndex = 4
        Me.bt_edit.Text = "تعديل"
        '
        'bt_save
        '
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.Location = New System.Drawing.Point(273, 128)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.Size = New System.Drawing.Size(75, 33)
        Me.bt_save.TabIndex = 3
        Me.bt_save.Text = "إضافة"
        '
        'txt_Sub_Name
        '
        Me.txt_Sub_Name.Location = New System.Drawing.Point(70, 94)
        Me.txt_Sub_Name.Name = "txt_Sub_Name"
        Me.txt_Sub_Name.Size = New System.Drawing.Size(262, 20)
        Me.txt_Sub_Name.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(335, 64)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "اختار البند الرئيسي :"
        '
        'sub_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 496)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sub_item"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "البنود الفرعية"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Grid_SubCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Sub_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Grid_SubCat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bt_back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_Sub_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents combo_MainCat As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
