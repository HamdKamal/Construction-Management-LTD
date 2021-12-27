<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class TakeReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TakeReport))
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.Header = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.amount = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Bank = New DevExpress.XtraReports.Parameters.Parameter()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.thatFor = New DevExpress.XtraReports.Parameters.Parameter()
        Me.P_serial = New DevExpress.XtraReports.Parameters.Parameter()
        Me.chequeDate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.cheque = New DevExpress.XtraReports.Parameters.Parameter()
        Me.project = New DevExpress.XtraReports.Parameters.Parameter()
        Me.namex = New DevExpress.XtraReports.Parameters.Parameter()
        Me.main = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.user = New DevExpress.XtraReports.Parameters.Parameter()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.money_writting = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrPanel3 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPanel5 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel6 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel4 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel7 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine10 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine11 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine12 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine13 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel8 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine14 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel68 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Aim-Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "pro_name"
        Table1.Name = "projects"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "pro_id"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Name = "projects"
        SelectQuery1.Tables.Add(Table1)
        ColumnExpression3.ColumnName = "SIGNITURE"
        Table2.Name = "users"
        ColumnExpression3.Table = Table2
        Column3.Expression = ColumnExpression3
        SelectQuery2.Columns.Add(Column3)
        SelectQuery2.FilterString = "[users.user_id] = ?user"
        SelectQuery2.Name = "users"
        QueryParameter1.Name = "user"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.user]", GetType(Integer))
        SelectQuery2.Parameters.Add(QueryParameter1)
        SelectQuery2.Tables.Add(Table2)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1, SelectQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Header
        '
        Me.Header.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.Name = "Header"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'amount
        '
        Me.amount.Description = "المبلغ"
        Me.amount.Name = "amount"
        Me.amount.ValueInfo = "0"
        '
        'Bank
        '
        Me.Bank.Description = "البنك"
        Me.Bank.Name = "Bank"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 9.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'thatFor
        '
        Me.thatFor.Description = "وذلك عن"
        Me.thatFor.Name = "thatFor"
        '
        'P_serial
        '
        Me.P_serial.Description = "serial number"
        Me.P_serial.Name = "P_serial"
        Me.P_serial.Type = GetType(Short)
        Me.P_serial.ValueInfo = "0"
        Me.P_serial.Visible = False
        '
        'chequeDate
        '
        Me.chequeDate.Description = "تاريخ الشيك"
        Me.chequeDate.Name = "chequeDate"
        Me.chequeDate.Type = GetType(Date)
        Me.chequeDate.ValueInfo = "2018-12-01"
        '
        'cheque
        '
        Me.cheque.Description = "رقم الشيك"
        Me.cheque.Name = "cheque"
        '
        'project
        '
        Me.project.Description = "المشروع"
        DynamicListLookUpSettings1.DataAdapter = Nothing
        DynamicListLookUpSettings1.DataMember = "projects"
        DynamicListLookUpSettings1.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings1.DisplayMember = "pro_name"
        DynamicListLookUpSettings1.ValueMember = "pro_name"
        Me.project.LookUpSettings = DynamicListLookUpSettings1
        Me.project.Name = "project"
        '
        'namex
        '
        Me.namex.Description = "الاسم"
        Me.namex.Name = "namex"
        '
        'main
        '
        Me.main.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main.Name = "main"
        '
        'Detail
        '
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Black
        Me.FieldCaption.Name = "FieldCaption"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Teal
        Me.Title.Name = "Title"
        '
        'user
        '
        Me.user.Description = "userId"
        Me.user.Name = "user"
        Me.user.Type = GetType(Integer)
        Me.user.ValueInfo = "0"
        Me.user.Visible = False
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel58, Me.XrLabel68, Me.XrPanel3, Me.XrPanel5, Me.XrLabel66, Me.XrLabel67, Me.XrLine14, Me.XrPageInfo2})
        Me.ReportHeaderBand1.HeightF = 1011.703!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.BorderColor = System.Drawing.Color.White
        Me.XrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPageInfo2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo2.Format = "{0:d MMMM, yyyy}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(6.000185!, 996.4177!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(136.0685!, 14.6666!)
        Me.XrPageInfo2.StyleName = "PageInfo"
        Me.XrPageInfo2.StylePriority.UseBorderColor = False
        Me.XrPageInfo2.StylePriority.UseBorders = False
        Me.XrPageInfo2.StylePriority.UseFont = False
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.money_writting, "Text", "")})
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(175.8017!, 32.76933!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(412.3124!, 18.34885!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel51"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'money_writting
        '
        Me.money_writting.Description = ": المبلغ كتابة "
        Me.money_writting.Name = "money_writting"
        '
        'XrPanel3
        '
        Me.XrPanel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox2, Me.XrPictureBox3})
        Me.XrPanel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel3.Name = "XrPanel3"
        Me.XrPanel3.SizeF = New System.Drawing.SizeF(735.5792!, 211.1794!)
        Me.XrPanel3.StylePriority.UseBorders = False
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(16.23425!, 27.18749!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(123.8398!, 168.3125!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPictureBox3
        '
        Me.XrPictureBox3.Image = CType(resources.GetObject("XrPictureBox3.Image"), System.Drawing.Image)
        Me.XrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(414.8967!, 27.18749!)
        Me.XrPictureBox3.Name = "XrPictureBox3"
        Me.XrPictureBox3.SizeF = New System.Drawing.SizeF(319.2615!, 105.8125!)
        Me.XrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPanel5
        '
        Me.XrPanel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrPanel6, Me.XrPanel4, Me.XrLabel39, Me.XrLabel40, Me.XrPanel7, Me.XrLabel48, Me.XrLine12, Me.XrLine13, Me.XrPictureBox4, Me.XrLabel50, Me.XrLabel53, Me.XrPanel8})
        Me.XrPanel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 312.326!)
        Me.XrPanel5.Name = "XrPanel5"
        Me.XrPanel5.SizeF = New System.Drawing.SizeF(732.7372!, 548.1668!)
        Me.XrPanel5.StylePriority.UseBorders = False
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 525.1668!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(732.7372!, 23.0!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        '
        'XrPanel6
        '
        Me.XrPanel6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9, Me.XrLabel37, Me.XrLabel12, Me.XrLabel36, Me.XrLabel31, Me.XrLabel32})
        Me.XrPanel6.LocationFloat = New DevExpress.Utils.PointFloat(17.03751!, 336.5834!)
        Me.XrPanel6.Name = "XrPanel6"
        Me.XrPanel6.SizeF = New System.Drawing.SizeF(698.6622!, 76.56245!)
        Me.XrPanel6.StylePriority.UseBorders = False
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 32.76916!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(111.6156!, 23.8965!)
        Me.XrLabel9.StyleName = "main"
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Project Name :"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel37
        '
        Me.XrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.project, "Text", "")})
        Me.XrLabel37.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(121.6156!, 32.76913!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(487.999!, 23.89651!)
        Me.XrLabel37.StylePriority.UseBorders = False
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "المشروع"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(609.6146!, 32.76913!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(83.0481!, 23.89651!)
        Me.XrLabel12.StyleName = "main"
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = ": أسم المشروع"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel36
        '
        Me.XrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.thatFor, "Text", "")})
        Me.XrLabel36.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(80.49936!, 8.8727!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(531.1155!, 23.8966!)
        Me.XrLabel36.StyleName = "main"
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = ":  .............................................................................." &
    "...............  :"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel31
        '
        Me.XrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel31.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 8.8727!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(70.49934!, 23.8965!)
        Me.XrLabel31.StyleName = "main"
        Me.XrLabel31.StylePriority.UseBorders = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Being :"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel32
        '
        Me.XrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel32.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(611.6148!, 8.8727!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(79.04749!, 23.89646!)
        Me.XrLabel32.StyleName = "main"
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = ": وذلك مقابل"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPanel4
        '
        Me.XrPanel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel41, Me.XrLabel13, Me.XrLabel45, Me.XrLabel24, Me.XrLabel29, Me.XrLabel33, Me.XrLabel34, Me.XrLabel35, Me.XrLabel38})
        Me.XrPanel4.LocationFloat = New DevExpress.Utils.PointFloat(17.03751!, 245.9584!)
        Me.XrPanel4.Name = "XrPanel4"
        Me.XrPanel4.SizeF = New System.Drawing.SizeF(698.6622!, 76.56245!)
        Me.XrPanel4.StylePriority.UseBorders = False
        '
        'XrLabel41
        '
        Me.XrLabel41.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.Bank, "Text", "")})
        Me.XrLabel41.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(58.17396!, 54.66586!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(585.0016!, 21.89659!)
        Me.XrLabel41.StyleName = "main"
        Me.XrLabel41.StylePriority.UseBorders = False
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = ":  .............................................................................." &
    "...............  :"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.chequeDate, "Text", "{0:MM/dd/yyyy}")})
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(58.17396!, 34.76928!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(578.2778!, 19.89662!)
        Me.XrLabel13.StyleName = "main"
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = ":  .............................................................................." &
    "...............  :"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel45
        '
        Me.XrLabel45.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.cheque, "Text", "")})
        Me.XrLabel45.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(104.0173!, 8.872803!)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(520.4152!, 23.89655!)
        Me.XrLabel45.StyleName = "main"
        Me.XrLabel45.StylePriority.UseBorders = False
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = ":  .............................................................................." &
    "...............  :"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 54.66589!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(48.17395!, 21.89655!)
        Me.XrLabel24.StyleName = "main"
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "Bank :"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel29
        '
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(643.1755!, 54.66586!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(49.487!, 21.89655!)
        Me.XrLabel29.StyleName = "main"
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = ": البنك"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel33
        '
        Me.XrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel33.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 32.76929!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(48.17395!, 17.78111!)
        Me.XrLabel33.StyleName = "main"
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Date :"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel34.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(636.4517!, 32.76935!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(54.21082!, 21.89655!)
        Me.XrLabel34.StyleName = "main"
        Me.XrLabel34.StylePriority.UseBorders = False
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = ": بتاريخ "
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel35
        '
        Me.XrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel35.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 8.872734!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(94.01731!, 23.89655!)
        Me.XrLabel35.StyleName = "main"
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "Cheque No :"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel38
        '
        Me.XrLabel38.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel38.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(624.4324!, 8.872803!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(66.22986!, 23.89655!)
        Me.XrLabel38.StyleName = "main"
        Me.XrLabel38.StylePriority.UseBorders = False
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = " : شيك رقم"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel39
        '
        Me.XrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel39.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(255.264!, 121.8753!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(147.3027!, 21.89658!)
        Me.XrLabel39.StyleName = "main"
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "300670567300003 : "
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel40
        '
        Me.XrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel40.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(402.5667!, 121.8753!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(86.36523!, 21.89656!)
        Me.XrLabel40.StyleName = "main"
        Me.XrLabel40.StylePriority.UseBorders = False
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "الرقم الضريبي"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPanel7
        '
        Me.XrPanel7.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel47, Me.XrLabel60, Me.XrLabel42, Me.XrLabel43, Me.XrLabel44, Me.XrLabel46, Me.XrLine8, Me.XrLine10, Me.XrLine11})
        Me.XrPanel7.LocationFloat = New DevExpress.Utils.PointFloat(498.193!, 38.62534!)
        Me.XrPanel7.Name = "XrPanel7"
        Me.XrPanel7.SizeF = New System.Drawing.SizeF(215.2825!, 106.25!)
        '
        'XrLabel60
        '
        Me.XrLabel60.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel60.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(130.4592!, 83.25!)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(78.82367!, 21.89655!)
        Me.XrLabel60.StyleName = "main"
        Me.XrLabel60.StylePriority.UseBorders = False
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        Me.XrLabel60.Text = "المبــلــغ"
        Me.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel42
        '
        Me.XrLabel42.BorderColor = System.Drawing.Color.Black
        Me.XrLabel42.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.amount, "Text", "{0}   SR")})
        Me.XrLabel42.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrLabel42.ForeColor = System.Drawing.Color.Black
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(9.868652!, 83.24999!)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(118.5904!, 23.00001!)
        Me.XrLabel42.StylePriority.UseBorderColor = False
        Me.XrLabel42.StylePriority.UseBorders = False
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseForeColor = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "XrLabel75"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel43
        '
        Me.XrLabel43.BorderColor = System.Drawing.Color.White
        Me.XrLabel43.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.chequeDate, "Text", "{0:MM/dd/yyyy}")})
        Me.XrLabel43.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(9.868721!, 51.00012!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(118.5904!, 20.29602!)
        Me.XrLabel43.StyleName = "main"
        Me.XrLabel43.StylePriority.UseBorderColor = False
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = ":  .............................................................................." &
    "...............  :"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel44
        '
        Me.XrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel44.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(130.4592!, 51.0001!)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(76.82352!, 20.3124!)
        Me.XrLabel44.StyleName = "main"
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "التــاريــخ"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel46
        '
        Me.XrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel46.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(130.4592!, 14.60339!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(76.82347!, 21.89658!)
        Me.XrLabel46.StyleName = "main"
        Me.XrLabel46.StylePriority.UseBorders = False
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.Text = "رقم الفاتورة"
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine8
        '
        Me.XrLine8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine8.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine8.LocationFloat = New DevExpress.Utils.PointFloat(128.4591!, 0!)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.SizeF = New System.Drawing.SizeF(2.000183!, 106.25!)
        Me.XrLine8.StylePriority.UseBorders = False
        '
        'XrLine10
        '
        Me.XrLine10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine10.LocationFloat = New DevExpress.Utils.PointFloat(0!, 71.31248!)
        Me.XrLine10.Name = "XrLine10"
        Me.XrLine10.SizeF = New System.Drawing.SizeF(215.2825!, 2.0!)
        Me.XrLine10.StylePriority.UseBorders = False
        '
        'XrLine11
        '
        Me.XrLine11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine11.LocationFloat = New DevExpress.Utils.PointFloat(0.00009536743!, 36.49998!)
        Me.XrLine11.Name = "XrLine11"
        Me.XrLine11.SizeF = New System.Drawing.SizeF(215.2825!, 2.0!)
        Me.XrLine11.StylePriority.UseBorders = False
        '
        'XrLabel48
        '
        Me.XrLabel48.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(732.7372!, 23.0!)
        Me.XrLabel48.StylePriority.UseBackColor = False
        '
        'XrLine12
        '
        Me.XrLine12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrLine12.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine12.LocationFloat = New DevExpress.Utils.PointFloat(524.3078!, 493.396!)
        Me.XrLine12.Name = "XrLine12"
        Me.XrLine12.SizeF = New System.Drawing.SizeF(134.7023!, 2.083344!)
        Me.XrLine12.StylePriority.UseBorderDashStyle = False
        '
        'XrLine13
        '
        Me.XrLine13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrLine13.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine13.LocationFloat = New DevExpress.Utils.PointFloat(48.00703!, 493.396!)
        Me.XrLine13.Name = "XrLine13"
        Me.XrLine13.SizeF = New System.Drawing.SizeF(119.6917!, 2.083344!)
        Me.XrLine13.StylePriority.UseBorderDashStyle = False
        '
        'XrPictureBox4
        '
        Me.XrPictureBox4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPictureBox4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Me.SqlDataSource1, "users.SIGNITURE")})
        Me.XrPictureBox4.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.XrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(51.8862!, 458.1028!)
        Me.XrPictureBox4.Name = "XrPictureBox4"
        Me.XrPictureBox4.SizeF = New System.Drawing.SizeF(112.6293!, 35.29333!)
        Me.XrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox4.StylePriority.UseBorders = False
        '
        'XrLabel50
        '
        Me.XrLabel50.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(37.44304!, 436.2063!)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(135.9052!, 21.89655!)
        Me.XrLabel50.StyleName = "main"
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "Manager    المدير"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel53
        '
        Me.XrLabel53.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(524.3078!, 436.2063!)
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(135.9052!, 21.89655!)
        Me.XrLabel53.StyleName = "main"
        Me.XrLabel53.StylePriority.UseBorders = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.Text = "Receiver    المستلم"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPanel8
        '
        Me.XrPanel8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel54, Me.XrLabel55, Me.XrLabel57, Me.XrLabel59, Me.XrLabel63, Me.XrLabel64, Me.XrLabel65})
        Me.XrPanel8.LocationFloat = New DevExpress.Utils.PointFloat(14.8133!, 157.9866!)
        Me.XrPanel8.Name = "XrPanel8"
        Me.XrPanel8.SizeF = New System.Drawing.SizeF(698.6622!, 76.56245!)
        Me.XrPanel8.StylePriority.UseBorders = False
        '
        'XrLabel54
        '
        Me.XrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel54.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 54.66589!)
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(48.17395!, 21.89655!)
        Me.XrLabel54.StyleName = "main"
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "Cash :"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel55
        '
        Me.XrLabel55.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel55.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(658.5511!, 54.66589!)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(34.11145!, 21.89655!)
        Me.XrLabel55.StyleName = "main"
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = ": نقداً"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel57
        '
        Me.XrLabel57.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel57.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 32.76929!)
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(164.9111!, 17.78111!)
        Me.XrLabel57.StyleName = "main"
        Me.XrLabel57.StylePriority.UseBorders = False
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = "The Amount Writting :"
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel59
        '
        Me.XrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel59.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(589.3635!, 32.76929!)
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(101.299!, 21.89655!)
        Me.XrLabel59.StyleName = "main"
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.Text = ": المبلغ كتابة فقط "
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel63
        '
        Me.XrLabel63.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel63.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel63.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 8.872731!)
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel63.SizeF = New System.Drawing.SizeF(113.2556!, 23.89657!)
        Me.XrLabel63.StyleName = "main"
        Me.XrLabel63.StylePriority.UseBorders = False
        Me.XrLabel63.StylePriority.UseFont = False
        Me.XrLabel63.StylePriority.UseTextAlignment = False
        Me.XrLabel63.Text = "Receipt From :"
        Me.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel64
        '
        Me.XrLabel64.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel64.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.namex, "Text", "")})
        Me.XrLabel64.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(123.8398!, 8.872731!)
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(434.2432!, 23.8966!)
        Me.XrLabel64.StyleName = "main"
        Me.XrLabel64.StylePriority.UseBorders = False
        Me.XrLabel64.StylePriority.UseFont = False
        Me.XrLabel64.StylePriority.UseTextAlignment = False
        Me.XrLabel64.Text = ":  .............................................................................." &
    "...............  :"
        Me.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel65
        '
        Me.XrLabel65.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel65.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(558.083!, 8.872731!)
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(132.5793!, 23.8966!)
        Me.XrLabel65.StyleName = "main"
        Me.XrLabel65.StylePriority.UseBorders = False
        Me.XrLabel65.StylePriority.UseFont = False
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.Text = ": إستلمنا من السيد/السادة"
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel66
        '
        Me.XrLabel66.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel66.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(291.3453!, 228.3454!)
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(135.9052!, 21.89655!)
        Me.XrLabel66.StyleName = "main"
        Me.XrLabel66.StylePriority.UseBorders = False
        Me.XrLabel66.StylePriority.UseFont = False
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = "ســـند قــبض"
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel67
        '
        Me.XrLabel67.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(291.3454!, 252.242!)
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(135.9052!, 21.89656!)
        Me.XrLabel67.StyleName = "main"
        Me.XrLabel67.StylePriority.UseBorders = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        Me.XrLabel67.Text = "Receipt Voucher"
        Me.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine14
        '
        Me.XrLine14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine14.LocationFloat = New DevExpress.Utils.PointFloat(270.2781!, 250.242!)
        Me.XrLine14.Name = "XrLine14"
        Me.XrLine14.SizeF = New System.Drawing.SizeF(173.438!, 2.0!)
        Me.XrLine14.StylePriority.UseBorders = False
        '
        'XrLabel47
        '
        Me.XrLabel47.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.P_serial, "Text", "")})
        Me.XrLabel47.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(6.615893!, 13.49998!)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(121.8432!, 22.99998!)
        Me.XrLabel47.StylePriority.UseBorders = False
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.Text = "XrLabel1"
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel58
        '
        Me.XrLabel58.BorderColor = System.Drawing.Color.White
        Me.XrLabel58.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel58.Font = New System.Drawing.Font("Times New Roman", 8.8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(4.262733!, 947.9928!)
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(732.7372!, 23.00012!)
        Me.XrLabel58.StylePriority.UseBorderColor = False
        Me.XrLabel58.StylePriority.UseBorders = False
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        Me.XrLabel58.Text = "المخواة - الشارع الـعام - جوار جامع الإمام البخاري - رقم المبنى 9516 - الرمز البر" &
    "يدي 65312 - - س .ت: 5806010132 - جوال: 0504582101/0505471113   "
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel68
        '
        Me.XrLabel68.BorderColor = System.Drawing.Color.White
        Me.XrLabel68.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel68.Font = New System.Drawing.Font("Times New Roman", 8.2!, System.Drawing.FontStyle.Bold)
        Me.XrLabel68.LocationFloat = New DevExpress.Utils.PointFloat(2.841783!, 970.9929!)
        Me.XrLabel68.Name = "XrLabel68"
        Me.XrLabel68.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel68.SizeF = New System.Drawing.SizeF(732.7373!, 23.0!)
        Me.XrLabel68.StylePriority.UseBorderColor = False
        Me.XrLabel68.StylePriority.UseBorders = False
        Me.XrLabel68.StylePriority.UseFont = False
        Me.XrLabel68.StylePriority.UseTextAlignment = False
        Me.XrLabel68.Text = "Makhwah- Main Street - Near jamie Imam albakhari - Building No. 9516 - zip 6531 -" &
    "C.R 5806010132 -TEL: 0504582101 / 0505471113"
        Me.XrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TakeReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeaderBand1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.Margins = New System.Drawing.Printing.Margins(45, 45, 9, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.project, Me.namex, Me.amount, Me.cheque, Me.chequeDate, Me.Bank, Me.thatFor, Me.user, Me.P_serial, Me.money_writting})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField, Me.Header, Me.main})
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Header As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents amount As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Bank As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents thatFor As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents chequeDate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents cheque As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents project As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents namex As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents main As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents user As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents P_serial As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents money_writting As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel3 As XtraReports.UI.XRPanel
    Friend WithEvents XrPictureBox2 As XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox3 As XtraReports.UI.XRPictureBox
    Friend WithEvents XrPanel5 As XtraReports.UI.XRPanel
    Friend WithEvents XrLabel1 As XtraReports.UI.XRLabel
    Friend WithEvents XrPanel6 As XtraReports.UI.XRPanel
    Friend WithEvents XrLabel9 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As XtraReports.UI.XRLabel
    Friend WithEvents XrPanel4 As XtraReports.UI.XRPanel
    Friend WithEvents XrLabel41 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As XtraReports.UI.XRLabel
    Friend WithEvents XrPanel7 As XtraReports.UI.XRPanel
    Friend WithEvents XrLabel47 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As XtraReports.UI.XRLabel
    Friend WithEvents XrLine8 As XtraReports.UI.XRLine
    Friend WithEvents XrLine10 As XtraReports.UI.XRLine
    Friend WithEvents XrLine11 As XtraReports.UI.XRLine
    Friend WithEvents XrLabel48 As XtraReports.UI.XRLabel
    Friend WithEvents XrLine12 As XtraReports.UI.XRLine
    Friend WithEvents XrLine13 As XtraReports.UI.XRLine
    Friend WithEvents XrPictureBox4 As XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel50 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As XtraReports.UI.XRLabel
    Friend WithEvents XrPanel8 As XtraReports.UI.XRPanel
    Friend WithEvents XrLabel54 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel59 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel64 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel67 As XtraReports.UI.XRLabel
    Friend WithEvents XrLine14 As XtraReports.UI.XRLine
    Friend WithEvents XrLabel58 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel68 As XtraReports.UI.XRLabel
End Class
