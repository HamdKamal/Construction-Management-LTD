<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PayReport
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
        Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayReport))
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.serial_no = New DevExpress.XtraReports.Parameters.Parameter()
        Me.amount = New DevExpress.XtraReports.Parameters.Parameter()
        Me.chequeDate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.thatFor = New DevExpress.XtraReports.Parameters.Parameter()
        Me.project = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Bank = New DevExpress.XtraReports.Parameters.Parameter()
        Me.cheque = New DevExpress.XtraReports.Parameters.Parameter()
        Me.namex = New DevExpress.XtraReports.Parameters.Parameter()
        Me.user = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.MONEY_HAND = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrPanel3 = New DevExpress.XtraReports.UI.XRPanel()
        Me.Header = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.main = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLine12 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine11 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel5 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel4 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel6 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
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
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Name = "projects"
        SelectQuery1.Tables.Add(Table1)
        ColumnExpression2.ColumnName = "SIGNITURE"
        Table2.Name = "users"
        ColumnExpression2.Table = Table2
        Column2.Expression = ColumnExpression2
        SelectQuery2.Columns.Add(Column2)
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
        'serial_no
        '
        Me.serial_no.Description = "serial number"
        Me.serial_no.Name = "serial_no"
        Me.serial_no.Type = GetType(Short)
        Me.serial_no.ValueInfo = "0"
        Me.serial_no.Visible = False
        '
        'amount
        '
        Me.amount.Description = "المبلغ"
        Me.amount.Name = "amount"
        Me.amount.ValueInfo = "0"
        '
        'chequeDate
        '
        Me.chequeDate.Description = "تار يخ الشيك"
        Me.chequeDate.Name = "chequeDate"
        Me.chequeDate.Type = GetType(Date)
        Me.chequeDate.ValueInfo = "2018-12-01"
        '
        'thatFor
        '
        Me.thatFor.Description = "وذلك عن"
        Me.thatFor.Name = "thatFor"
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
        'Bank
        '
        Me.Bank.Description = "البنك"
        Me.Bank.Name = "Bank"
        '
        'cheque
        '
        Me.cheque.Description = "رقم الشيك"
        Me.cheque.Name = "cheque"
        '
        'namex
        '
        Me.namex.Description = "الاسم"
        Me.namex.Name = "namex"
        '
        'user
        '
        Me.user.Description = "userId"
        Me.user.Name = "user"
        Me.user.Type = GetType(Integer)
        Me.user.ValueInfo = "0"
        Me.user.Visible = False
        '
        'Detail
        '
        Me.Detail.HeightF = 2.083374!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel3, Me.XrLabel1, Me.XrLabel2, Me.XrLabel14, Me.XrPageInfo1, Me.XrPanel5, Me.XrPanel3})
        Me.ReportHeaderBand1.HeightF = 1014.498!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'MONEY_HAND
        '
        Me.MONEY_HAND.Description = "المبلغ كتابة"
        Me.MONEY_HAND.Name = "MONEY_HAND"
        '
        'XrPanel3
        '
        Me.XrPanel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox2, Me.XrPictureBox1})
        Me.XrPanel3.LocationFloat = New DevExpress.Utils.PointFloat(1.420879!, 0!)
        Me.XrPanel3.Name = "XrPanel3"
        Me.XrPanel3.SizeF = New System.Drawing.SizeF(735.5792!, 211.1794!)
        Me.XrPanel3.StylePriority.UseBorders = False
        '
        'Header
        '
        Me.Header.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.Name = "Header"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 1.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'main
        '
        Me.main.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main.Name = "main"
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
        'XrLabel2
        '
        Me.XrLabel2.BorderColor = System.Drawing.Color.White
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 8.2!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(1.420879!, 975.6804!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(732.7373!, 23.0!)
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Makhwah- Main Street - Near jamie Imam albakhari - Building No. 9516 - zip 6531 -" &
    "C.R 5806010132 -TEL: 0504582101 / 0505471113"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.BorderColor = System.Drawing.Color.White
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 8.8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(2.84183!, 952.6803!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(732.7372!, 23.00012!)
        Me.XrLabel14.StylePriority.UseBorderColor = False
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "المخواة - الشارع الـعام - جوار جامع الإمام البخاري - رقم المبنى 9516 - الرمز البر" &
    "يدي 65312 - - س .ت: 5806010132 - جوال: 0504582101/0505471113   "
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.BorderColor = System.Drawing.Color.White
        Me.XrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Format = "{0:d MMMM, yyyy}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(2.841858!, 998.6804!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(138.6531!, 14.6666!)
        Me.XrPageInfo1.StyleName = "PageInfo"
        Me.XrPageInfo1.StylePriority.UseBorderColor = False
        Me.XrPageInfo1.StylePriority.UseBorders = False
        Me.XrPageInfo1.StylePriority.UseFont = False
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
        'XrLabel55
        '
        Me.XrLabel55.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel55.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(591.4888!, 8.872734!)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(99.17358!, 23.89655!)
        Me.XrLabel55.StyleName = "main"
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = ": اصرفوا للمكرم"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel54
        '
        Me.XrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel54.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 8.872734!)
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(72.72355!, 23.89655!)
        Me.XrLabel54.StyleName = "main"
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "Pay To :"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel49
        '
        Me.XrLabel49.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(524.3078!, 436.2063!)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(135.9052!, 21.89655!)
        Me.XrLabel49.StyleName = "main"
        Me.XrLabel49.StylePriority.UseBorders = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "Receiver    المستلم"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel48
        '
        Me.XrLabel48.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.namex, "Text", "")})
        Me.XrLabel48.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(82.72357!, 8.872734!)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(508.7652!, 23.89655!)
        Me.XrLabel48.StyleName = "main"
        Me.XrLabel48.StylePriority.UseBorders = False
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = ":  .............................................................................." &
    "...............  :"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
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
        'XrLabel38
        '
        Me.XrLabel38.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(37.44304!, 436.2063!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(135.9052!, 21.89655!)
        Me.XrLabel38.StyleName = "main"
        Me.XrLabel38.StylePriority.UseBorders = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "Manager    المدير"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        'XrLine12
        '
        Me.XrLine12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrLine12.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine12.LocationFloat = New DevExpress.Utils.PointFloat(48.00703!, 493.396!)
        Me.XrLine12.Name = "XrLine12"
        Me.XrLine12.SizeF = New System.Drawing.SizeF(119.6917!, 2.083344!)
        Me.XrLine12.StylePriority.UseBorderDashStyle = False
        '
        'XrLine11
        '
        Me.XrLine11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrLine11.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.XrLine11.LocationFloat = New DevExpress.Utils.PointFloat(524.3078!, 493.396!)
        Me.XrLine11.Name = "XrLine11"
        Me.XrLine11.SizeF = New System.Drawing.SizeF(134.7023!, 2.083344!)
        Me.XrLine11.StylePriority.UseBorderDashStyle = False
        '
        'XrLabel35
        '
        Me.XrLabel35.BorderColor = System.Drawing.Color.Black
        Me.XrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.amount, "Text", "{0}   SR")})
        Me.XrLabel35.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrLabel35.ForeColor = System.Drawing.Color.Black
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(9.868652!, 83.24999!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(118.5904!, 23.00001!)
        Me.XrLabel35.StylePriority.UseBorderColor = False
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseForeColor = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "XrLabel75"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel33
        '
        Me.XrLabel33.BorderColor = System.Drawing.Color.White
        Me.XrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.chequeDate, "Text", "{0:MM/dd/yyyy}")})
        Me.XrLabel33.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(9.868721!, 51.00012!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(118.5904!, 20.29602!)
        Me.XrLabel33.StyleName = "main"
        Me.XrLabel33.StylePriority.UseBorderColor = False
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = ":  .............................................................................." &
    "...............  :"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.BorderColor = System.Drawing.Color.White
        Me.XrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.serial_no, "Text", "")})
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(9.999977!, 14.60337!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(118.4591!, 21.8966!)
        Me.XrLabel30.StylePriority.UseBorderColor = False
        Me.XrLabel30.StylePriority.UseBorders = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "XrLabel3"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(589.3635!, 32.76929!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(101.299!, 21.89655!)
        Me.XrLabel24.StyleName = "main"
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = ": المبلغ كتابة فقط "
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel13
        '
        Me.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 32.76929!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(164.9111!, 17.78111!)
        Me.XrLabel13.StyleName = "main"
        Me.XrLabel13.StylePriority.UseBorders = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "The Amount Writting :"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.MONEY_HAND, "Text", "")})
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(174.9111!, 32.76929!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(414.4524!, 21.89655!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel51"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPanel5
        '
        Me.XrPanel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel23, Me.XrPanel6, Me.XrPanel4, Me.XrLabel8, Me.XrLabel7, Me.XrPanel1, Me.XrLabel4, Me.XrLine11, Me.XrLine12, Me.XrPictureBox4, Me.XrLabel38, Me.XrLabel49, Me.XrPanel2})
        Me.XrPanel5.LocationFloat = New DevExpress.Utils.PointFloat(2.84183!, 312.326!)
        Me.XrPanel5.Name = "XrPanel5"
        Me.XrPanel5.SizeF = New System.Drawing.SizeF(732.7372!, 548.1668!)
        Me.XrPanel5.StylePriority.UseBorders = False
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(414.8967!, 27.18749!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(319.2615!, 105.8125!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(16.23425!, 27.18749!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(123.8398!, 168.3125!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(292.3146!, 261.6169!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(135.9052!, 21.89656!)
        Me.XrLabel1.StyleName = "main"
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Payment Voucher"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(292.3146!, 237.7204!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(135.9052!, 21.89655!)
        Me.XrLabel3.StyleName = "main"
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "ســـند صـــرف"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine1
        '
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(271.2474!, 259.6169!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(173.438!, 2.0!)
        Me.XrLine1.StylePriority.UseBorders = False
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(732.7372!, 23.0!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        '
        'XrPanel1
        '
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel60, Me.XrLabel35, Me.XrLabel33, Me.XrLabel6, Me.XrLabel5, Me.XrLabel30, Me.XrLine4, Me.XrLine3, Me.XrLine2})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(498.193!, 38.62534!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(215.2825!, 106.25!)
        '
        'XrLine2
        '
        Me.XrLine2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.00009536743!, 36.49998!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(215.2825!, 2.0!)
        Me.XrLine2.StylePriority.UseBorders = False
        '
        'XrLine3
        '
        Me.XrLine3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 71.31248!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(215.2825!, 2.0!)
        Me.XrLine3.StylePriority.UseBorders = False
        '
        'XrLine4
        '
        Me.XrLine4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(128.4591!, 0!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(2.000183!, 106.25!)
        Me.XrLine4.StylePriority.UseBorders = False
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(130.4592!, 14.60339!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(76.82347!, 21.89658!)
        Me.XrLabel5.StyleName = "main"
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "رقم الفاتورة"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(130.4592!, 51.0001!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(76.82352!, 20.3124!)
        Me.XrLabel6.StyleName = "main"
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "التــاريــخ"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(402.5667!, 121.8753!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(86.36523!, 21.89656!)
        Me.XrLabel7.StyleName = "main"
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "الرقم الضريبي"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(255.264!, 121.8753!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(147.3027!, 21.89658!)
        Me.XrLabel8.StyleName = "main"
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "300670567300003 : "
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPanel2
        '
        Me.XrPanel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel9, Me.XrLabel13, Me.XrLabel12, Me.XrLabel24, Me.XrLabel54, Me.XrLabel48, Me.XrLabel55})
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(14.8133!, 157.9866!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(698.6622!, 76.56245!)
        Me.XrPanel2.StylePriority.UseBorders = False
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(658.5511!, 54.66589!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(34.11145!, 21.89655!)
        Me.XrLabel9.StyleName = "main"
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = ": نقداً"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 54.66589!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(48.17395!, 21.89655!)
        Me.XrLabel10.StyleName = "main"
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Cash :"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPanel4
        '
        Me.XrPanel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel41, Me.XrLabel17, Me.XrLabel45, Me.XrLabel11, Me.XrLabel15, Me.XrLabel16, Me.XrLabel18, Me.XrLabel19, Me.XrLabel21})
        Me.XrPanel4.LocationFloat = New DevExpress.Utils.PointFloat(17.03751!, 245.9584!)
        Me.XrPanel4.Name = "XrPanel4"
        Me.XrPanel4.SizeF = New System.Drawing.SizeF(698.6622!, 76.56245!)
        Me.XrPanel4.StylePriority.UseBorders = False
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 54.66589!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(48.17395!, 21.89655!)
        Me.XrLabel11.StyleName = "main"
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Bank :"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(643.1755!, 54.66586!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(49.487!, 21.89655!)
        Me.XrLabel15.StyleName = "main"
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = ": البنك"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 32.76929!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(48.17395!, 17.78111!)
        Me.XrLabel16.StyleName = "main"
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Date :"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(636.4517!, 32.76935!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(54.21082!, 21.89655!)
        Me.XrLabel18.StyleName = "main"
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = ": بتاريخ "
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 8.872734!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(94.01731!, 23.89655!)
        Me.XrLabel19.StyleName = "main"
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Cheque No :"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(624.4324!, 8.872803!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(66.22986!, 23.89655!)
        Me.XrLabel21.StyleName = "main"
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = " : شيك رقم"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
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
        'XrLabel17
        '
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.chequeDate, "Text", "{0:MM/dd/yyyy}")})
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(58.17396!, 34.76928!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(578.2778!, 19.89662!)
        Me.XrLabel17.StyleName = "main"
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = ":  .............................................................................." &
    "...............  :"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPanel6
        '
        Me.XrPanel6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel22, Me.XrLabel37, Me.XrLabel20, Me.XrLabel36, Me.XrLabel31, Me.XrLabel32})
        Me.XrPanel6.LocationFloat = New DevExpress.Utils.PointFloat(17.03751!, 336.5834!)
        Me.XrPanel6.Name = "XrPanel6"
        Me.XrPanel6.SizeF = New System.Drawing.SizeF(698.6622!, 76.56245!)
        Me.XrPanel6.StylePriority.UseBorders = False
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
        'XrLabel20
        '
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(609.6146!, 32.76913!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(83.0481!, 23.89651!)
        Me.XrLabel20.StyleName = "main"
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = ": أسم المشروع"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 32.76916!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(111.6156!, 23.8965!)
        Me.XrLabel22.StyleName = "main"
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Project Name :"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel23
        '
        Me.XrLabel23.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(0!, 525.1668!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(732.7372!, 23.0!)
        Me.XrLabel23.StylePriority.UseBackColor = False
        '
        'PayReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeaderBand1})
        Me.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.Margins = New System.Drawing.Printing.Margins(45, 45, 1, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.project, Me.namex, Me.amount, Me.cheque, Me.chequeDate, Me.Bank, Me.thatFor, Me.user, Me.serial_no, Me.MONEY_HAND})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField, Me.Header, Me.main})
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents thatFor As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents project As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Bank As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents chequeDate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents cheque As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents amount As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents namex As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents user As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents Header As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents main As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents serial_no As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents MONEY_HAND As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPanel3 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel2 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As XtraReports.UI.XRPageInfo
    Friend WithEvents XrPanel5 As XtraReports.UI.XRPanel
    Friend WithEvents XrLabel12 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As XtraReports.UI.XRLabel
    Friend WithEvents XrLine11 As XtraReports.UI.XRLine
    Friend WithEvents XrLine12 As XtraReports.UI.XRLine
    Friend WithEvents XrPictureBox4 As XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel36 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As XtraReports.UI.XRLine
    Friend WithEvents XrLabel3 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox2 As XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox1 As XtraReports.UI.XRPictureBox
    Friend WithEvents XrPanel1 As XtraReports.UI.XRPanel
    Friend WithEvents XrLine4 As XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As XtraReports.UI.XRLine
    Friend WithEvents XrLabel4 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As XtraReports.UI.XRLabel
    Friend WithEvents XrPanel6 As XtraReports.UI.XRPanel
    Friend WithEvents XrLabel22 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As XtraReports.UI.XRLabel
    Friend WithEvents XrPanel4 As XtraReports.UI.XRPanel
    Friend WithEvents XrLabel17 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As XtraReports.UI.XRLabel
    Friend WithEvents XrPanel2 As XtraReports.UI.XRPanel
    Friend WithEvents XrLabel10 As XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As XtraReports.UI.XRLabel
End Class
