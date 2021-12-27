<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class WorkersReport
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
        Me.components = New System.ComponentModel.Container()
        Dim TableQuery1 As DevExpress.DataAccess.Sql.TableQuery = New DevExpress.DataAccess.Sql.TableQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim SortingInfo1 As DevExpress.DataAccess.Sql.SortingInfo = New DevExpress.DataAccess.Sql.SortingInfo()
        Dim TableInfo1 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
        Dim ColumnInfo1 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim ColumnInfo2 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim TableQuery2 As DevExpress.DataAccess.Sql.TableQuery = New DevExpress.DataAccess.Sql.TableQuery()
        Dim SortingInfo2 As DevExpress.DataAccess.Sql.SortingInfo = New DevExpress.DataAccess.Sql.SortingInfo()
        Dim TableInfo2 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
        Dim ColumnInfo3 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim ColumnInfo4 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkersReport))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.XrControlStyle3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart()
        Me.MonthsLeft = New DevExpress.XtraReports.UI.CalculatedField()
        Me.worker = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrControlStyle2 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrControlStyle4 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Footer = New DevExpress.XtraReports.UI.XRControlStyle()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Aim-Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        TableQuery1.FilterString = "[workers.emp_id] In (?worker)"
        TableQuery1.Name = "workers"
        QueryParameter1.Name = "worker"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.worker]", GetType(Integer))
        TableQuery1.Parameters.Add(QueryParameter1)
        SortingInfo1.Column = "stay_end"
        SortingInfo1.Table = "workers"
        TableQuery1.Sorting.AddRange(New DevExpress.DataAccess.Sql.SortingInfo() {SortingInfo1})
        TableInfo1.Name = "workers"
        ColumnInfo1.Name = "emp_name"
        ColumnInfo2.Name = "stay_end"
        TableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo1, ColumnInfo2})
        TableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() {TableInfo1})
        TableQuery2.Name = "workers_1"
        SortingInfo2.Column = "emp_name"
        SortingInfo2.Table = "workers"
        TableQuery2.Sorting.AddRange(New DevExpress.DataAccess.Sql.SortingInfo() {SortingInfo2})
        TableInfo2.Name = "workers"
        ColumnInfo3.Name = "emp_id"
        ColumnInfo4.Name = "emp_name"
        TableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo3, ColumnInfo4})
        TableQuery2.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() {TableInfo2})
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {TableQuery1, TableQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'XrControlStyle3
        '
        Me.XrControlStyle3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrControlStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.XrControlStyle3.Name = "XrControlStyle3"
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
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(7.999929!, 10.00001!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(123.9583!, 115.5833!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(219.0!, 448.9997!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(122.9167!, 23.0!)
        Me.XrLabel2.StyleName = "XrControlStyle1"
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "أنتهاء الاقامة"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 100.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Simplified Arabic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(412.25!, 82.5833!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(206.75!, 43.0!)
        Me.XrLabel5.StyleName = "Title"
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "حالة الإقامة"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(119.0!, 448.9997!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel3.StyleName = "XrControlStyle1"
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "الاشهر المتبقية"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Simplified Arabic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'XrTableCell3
        '
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers.emp_name")})
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell3.Weight = 1.9558337251650686R
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrPictureBox2, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrLabel5, Me.XrChart1})
        Me.ReportHeaderBand1.HeightF = 471.9997!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(319.0001!, 10.00001!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(299.9999!, 70.91665!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(341.9167!, 448.9997!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(195.5833!, 23.0!)
        Me.XrLabel1.StyleName = "XrControlStyle1"
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "أسم العامل"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.Color.Black
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrChart1.Diagram = XyDiagram1
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 150.5833!)
        Me.XrChart1.Name = "XrChart1"
        Series1.ArgumentDataMember = "workers.emp_name"
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Name = "الأشهر المتبقية"
        Series1.ValueDataMembersSerializable = "workers.MonthsLeft"
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.XrChart1.SizeF = New System.Drawing.SizeF(621.0!, 264.9584!)
        '
        'MonthsLeft
        '
        Me.MonthsLeft.DataMember = "workers"
        Me.MonthsLeft.Expression = "DateDiffMonth(Now(),[stay_end] )"
        Me.MonthsLeft.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
        Me.MonthsLeft.Name = "MonthsLeft"
        '
        'worker
        '
        Me.worker.Description = "أسم العامل"
        DynamicListLookUpSettings1.DataAdapter = Nothing
        DynamicListLookUpSettings1.DataMember = "workers_1"
        DynamicListLookUpSettings1.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings1.DisplayMember = "emp_name"
        DynamicListLookUpSettings1.ValueMember = "emp_id"
        Me.worker.LookUpSettings = DynamicListLookUpSettings1
        Me.worker.MultiValue = True
        Me.worker.Name = "worker"
        Me.worker.Type = GetType(Integer)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers.stay_end", "{0:yyyy-MM-dd}")})
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell2.Weight = 1.2291667432702402R
        '
        'XrControlStyle2
        '
        Me.XrControlStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.XrControlStyle2.Name = "XrControlStyle2"
        Me.XrControlStyle2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'XrControlStyle4
        '
        Me.XrControlStyle4.ForeColor = System.Drawing.Color.Gray
        Me.XrControlStyle4.Name = "XrControlStyle4"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Simplified Arabic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(119.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.OddStyleName = "XrControlStyle2"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(418.5!, 25.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers.MonthsLeft")})
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell1.Weight = 0.9999999191911334R
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.XrControlStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrControlStyle1.Name = "XrControlStyle1"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Footer
        '
        Me.Footer.ForeColor = System.Drawing.Color.Gray
        Me.Footer.Name = "Footer"
        '
        'WorkersReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeaderBand1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.MonthsLeft})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "workers"
        Me.DataSource = Me.SqlDataSource1
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.worker})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField, Me.XrControlStyle1, Me.XrControlStyle2, Me.XrControlStyle3, Me.XrControlStyle4, Me.Footer})
        Me.Version = "15.2"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents XrControlStyle3 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents MonthsLeft As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents worker As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrControlStyle2 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrControlStyle4 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Footer As DevExpress.XtraReports.UI.XRControlStyle
End Class
