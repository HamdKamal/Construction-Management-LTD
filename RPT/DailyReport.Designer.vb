<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DailyReport
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
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table3 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Join1 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Join2 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Sorting1 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table5 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table6 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter4 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Join3 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Join4 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo4 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Sorting2 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim SelectQuery3 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression20 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table7 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression21 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column20 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression22 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column21 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression23 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column22 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression24 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression25 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table8 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim QueryParameter5 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter6 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Join5 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo5 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Sorting3 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression26 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim SelectQuery4 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression27 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table9 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column25 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression28 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column26 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression29 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column27 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression30 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column28 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression31 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column29 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression32 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table10 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column30 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression33 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table11 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim QueryParameter7 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter8 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Join6 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo6 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Join7 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo7 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim Sorting4 As DevExpress.DataAccess.Sql.Sorting = New DevExpress.DataAccess.Sql.Sorting()
        Dim ColumnExpression34 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim SelectQuery5 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column31 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression35 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table12 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column32 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression36 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column33 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression37 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column34 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression38 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column35 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression39 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column36 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression40 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table13 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column37 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression41 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim QueryParameter9 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter10 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Join8 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo8 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim SelectQuery6 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column38 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression42 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table14 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column39 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression43 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column40 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression44 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column41 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression45 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column42 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression46 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column43 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression47 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim QueryParameter11 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter12 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim SelectQuery7 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column44 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression48 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table15 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column45 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression49 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column46 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression50 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column47 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression51 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column48 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression52 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column49 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression53 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column50 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression54 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table16 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column51 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression55 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim QueryParameter13 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter14 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Join9 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo9 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim SelectQuery8 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column52 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression56 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table17 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column53 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression57 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column54 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression58 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column55 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression59 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column56 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression60 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column57 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression61 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column58 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression62 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table18 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim QueryParameter15 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim QueryParameter16 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim Join10 As DevExpress.DataAccess.Sql.Join = New DevExpress.DataAccess.Sql.Join()
        Dim RelationColumnInfo10 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailyReport))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell125 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell126 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell127 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell128 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell129 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell130 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell131 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell132 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable8 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell97 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell98 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell99 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell100 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Stotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GroupHeader7 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell89 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell90 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.EDate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SDate = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell79 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable13 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell101 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell102 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell103 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell104 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell105 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell106 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell107 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell108 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BayRule = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ReportHeader7 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.XrTableCell92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.BuyTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupHeader6 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable9 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell121 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell109 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell110 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Detail6 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable10 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell122 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell123 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell124 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter9 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable15 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell133 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell134 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.GroupFooter7 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableCell93 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportHeader8 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableCell94 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell91 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell95 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell96 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.DetailReport5 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.ReportHeader6 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter6 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableCell114 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Ptotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TableHeader = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable17 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell80 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell81 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell82 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell83 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell84 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell85 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell86 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportHeader1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable16 = New DevExpress.XtraReports.UI.XRTable()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.WorkerTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Detail7 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.Detail9 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable18 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow20 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell115 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell116 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell117 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell118 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell119 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell120 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader8 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable11 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.DetailReport2 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail3 = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeader3 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader5 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable7 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell113 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader9 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable14 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CarTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DetailReport7 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail8 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable12 = New DevExpress.XtraReports.UI.XRTable()
        Me.GroupFooter8 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeader2 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ProjectTtotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DetailReport6 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.ReportHeader5 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.area_income = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Rest = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TableBody2 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.Xtotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Pro_income = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DetailReport8 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.ReportHeader9 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.IncomeTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TableBody = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailReport4 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail5 = New DevExpress.XtraReports.UI.DetailBand()
        Me.GroupFooter5 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.BayTotal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.BillSum = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'XrTableRow12
        '
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell125, Me.XrTableCell126, Me.XrTableCell127, Me.XrTableCell128, Me.XrTableCell129, Me.XrTableCell130, Me.XrTableCell131, Me.XrTableCell132})
        Me.XrTableRow12.Name = "XrTableRow12"
        Me.XrTableRow12.Weight = 11.5R
        '
        'XrTableCell125
        '
        Me.XrTableCell125.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PAYMENT_Bills.LOGS_TIME")})
        Me.XrTableCell125.Name = "XrTableCell125"
        Me.XrTableCell125.Text = "XrTableCell125"
        Me.XrTableCell125.Weight = 0.15923566878980891R
        '
        'XrTableCell126
        '
        Me.XrTableCell126.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PAYMENT_Bills.USER_NAME")})
        Me.XrTableCell126.Name = "XrTableCell126"
        Me.XrTableCell126.Text = "XrTableCell126"
        Me.XrTableCell126.Weight = 0.13176659850195177R
        '
        'XrTableCell127
        '
        Me.XrTableCell127.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PAYMENT_Bills.pay_date", "{0:MM/dd/yyyy}")})
        Me.XrTableCell127.Name = "XrTableCell127"
        Me.XrTableCell127.Text = "XrTableCell127"
        Me.XrTableCell127.Weight = 0.15240877055460222R
        '
        'XrTableCell128
        '
        Me.XrTableCell128.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PAYMENT_Bills.NOTE")})
        Me.XrTableCell128.Name = "XrTableCell128"
        Me.XrTableCell128.Text = "XrTableCell128"
        Me.XrTableCell128.Weight = 0.1667388404686169R
        '
        'XrTableCell129
        '
        Me.XrTableCell129.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PAYMENT_Bills.PAID_MONEY", "{0:c2}")})
        Me.XrTableCell129.Name = "XrTableCell129"
        Me.XrTableCell129.Text = "XrTableCell129"
        Me.XrTableCell129.Weight = 0.16489830204350328R
        '
        'XrTableCell130
        '
        Me.XrTableCell130.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PAYMENT_Bills.pay_no")})
        Me.XrTableCell130.Name = "XrTableCell130"
        Me.XrTableCell130.Text = "XrTableCell130"
        Me.XrTableCell130.Weight = 0.13565465235420932R
        '
        'XrTableCell131
        '
        Me.XrTableCell131.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PAYMENT_Bills.bill_name")})
        Me.XrTableCell131.Name = "XrTableCell131"
        Me.XrTableCell131.Text = "XrTableCell131"
        Me.XrTableCell131.Weight = 0.15086862270892709R
        '
        'XrTableCell132
        '
        Me.XrTableCell132.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PAYMENT_Bills.pro_name")})
        Me.XrTableCell132.Name = "XrTableCell132"
        Me.XrTableCell132.Text = "XrTableCell132"
        Me.XrTableCell132.Weight = 0.21231389489685179R
        '
        'XrTable8
        '
        Me.XrTable8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 31.33334!)
        Me.XrTable8.Name = "XrTable8"
        Me.XrTable8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow13})
        Me.XrTable8.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow13
        '
        Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell57, Me.XrTableCell58, Me.XrTableCell59, Me.XrTableCell60, Me.XrTableCell97, Me.XrTableCell98, Me.XrTableCell99, Me.XrTableCell100})
        Me.XrTableRow13.Name = "XrTableRow13"
        Me.XrTableRow13.Weight = 11.5R
        '
        'XrTableCell57
        '
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.StyleName = "TableHeader"
        Me.XrTableCell57.Text = "وقت العملية"
        Me.XrTableCell57.Weight = 0.15923566878980891R
        '
        'XrTableCell58
        '
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.StyleName = "TableHeader"
        Me.XrTableCell58.Text = "المستخدم"
        Me.XrTableCell58.Weight = 0.1317666604062443R
        '
        'XrTableCell59
        '
        Me.XrTableCell59.Name = "XrTableCell59"
        Me.XrTableCell59.StyleName = "TableHeader"
        Me.XrTableCell59.Text = "المشروع"
        Me.XrTableCell59.Weight = 0.21774042517888656R
        '
        'XrTableCell60
        '
        Me.XrTableCell60.Name = "XrTableCell60"
        Me.XrTableCell60.StyleName = "TableHeader"
        Me.XrTableCell60.Text = "التاريخ"
        Me.XrTableCell60.Weight = 0.16674066664524612R
        '
        'XrTableCell97
        '
        Me.XrTableCell97.Name = "XrTableCell97"
        Me.XrTableCell97.StyleName = "TableHeader"
        Me.XrTableCell97.Text = "المبلغ "
        Me.XrTableCell97.Weight = 0.19490343643504809R
        '
        'XrTableCell98
        '
        Me.XrTableCell98.Name = "XrTableCell98"
        Me.XrTableCell98.StyleName = "TableHeader"
        Me.XrTableCell98.Text = "الكمية"
        Me.XrTableCell98.Weight = 0.083505795390723239R
        '
        'XrTableCell99
        '
        Me.XrTableCell99.Name = "XrTableCell99"
        Me.XrTableCell99.StyleName = "TableHeader"
        Me.XrTableCell99.Text = "سعر الوحدة"
        Me.XrTableCell99.Weight = 0.19245202645137732R
        '
        'XrTableCell100
        '
        Me.XrTableCell100.Name = "XrTableCell100"
        Me.XrTableCell100.StyleName = "TableHeader"
        Me.XrTableCell100.Text = "الأسم"
        Me.XrTableCell100.Weight = 0.12754067102113675R
        '
        'Stotal
        '
        Me.Stotal.DataMember = "Sbill"
        Me.Stotal.DataSource = Me.SqlDataSource1
        Me.Stotal.Expression = "Iif(IsNull([].Sum([total])),0  ,[].Sum([total]) )"
        Me.Stotal.Name = "Stotal"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Aim-Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "note"
        Table1.Name = "build_bills"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "price"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "quantity"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "Value_Price"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "pay_date"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "USER_NAME"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "LOGS_TIME"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "sub_name"
        Table2.Name = "sub_category"
        ColumnExpression8.Table = Table2
        Column8.Expression = ColumnExpression8
        ColumnExpression9.ColumnName = "pro_name"
        Table3.Name = "projects"
        ColumnExpression9.Table = Table3
        Column9.Expression = ColumnExpression9
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Columns.Add(Column9)
        SelectQuery1.FilterString = "[build_bills.pay_date] Between(?SDate, ?EDate)"
        SelectQuery1.Name = "build_bills"
        QueryParameter1.Name = "SDate"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.SDate]", GetType(Date))
        QueryParameter2.Name = "EDate"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.EDate]", GetType(Date))
        SelectQuery1.Parameters.Add(QueryParameter1)
        SelectQuery1.Parameters.Add(QueryParameter2)
        RelationColumnInfo1.NestedKeyColumn = "sub_id"
        RelationColumnInfo1.ParentKeyColumn = "sub_id"
        Join1.KeyColumns.Add(RelationColumnInfo1)
        Join1.Nested = Table2
        Join1.Parent = Table1
        RelationColumnInfo2.NestedKeyColumn = "pro_id"
        RelationColumnInfo2.ParentKeyColumn = "pro_id"
        Join2.KeyColumns.Add(RelationColumnInfo2)
        Join2.Nested = Table3
        Join2.Parent = Table1
        SelectQuery1.Relations.Add(Join1)
        SelectQuery1.Relations.Add(Join2)
        ColumnExpression10.ColumnName = "pay_date"
        ColumnExpression10.Table = Table1
        Sorting1.Expression = ColumnExpression10
        SelectQuery1.Sorting.Add(Sorting1)
        SelectQuery1.Tables.Add(Table1)
        SelectQuery1.Tables.Add(Table2)
        SelectQuery1.Tables.Add(Table3)
        ColumnExpression11.ColumnName = "pay_date"
        Table4.Name = "workers_bills"
        ColumnExpression11.Table = Table4
        Column10.Expression = ColumnExpression11
        ColumnExpression12.ColumnName = "amount"
        ColumnExpression12.Table = Table4
        Column11.Expression = ColumnExpression12
        ColumnExpression13.ColumnName = "note"
        ColumnExpression13.Table = Table4
        Column12.Expression = ColumnExpression13
        ColumnExpression14.ColumnName = "USER_NAME"
        ColumnExpression14.Table = Table4
        Column13.Expression = ColumnExpression14
        ColumnExpression15.ColumnName = "LOGS_TIME"
        ColumnExpression15.Table = Table4
        Column14.Expression = ColumnExpression15
        ColumnExpression16.ColumnName = "emp_name"
        Table5.Name = "workers"
        ColumnExpression16.Table = Table5
        Column15.Expression = ColumnExpression16
        ColumnExpression17.ColumnName = "job"
        ColumnExpression17.Table = Table5
        Column16.Expression = ColumnExpression17
        ColumnExpression18.ColumnName = "pro_name"
        Table6.Name = "projects"
        ColumnExpression18.Table = Table6
        Column17.Expression = ColumnExpression18
        SelectQuery2.Columns.Add(Column10)
        SelectQuery2.Columns.Add(Column11)
        SelectQuery2.Columns.Add(Column12)
        SelectQuery2.Columns.Add(Column13)
        SelectQuery2.Columns.Add(Column14)
        SelectQuery2.Columns.Add(Column15)
        SelectQuery2.Columns.Add(Column16)
        SelectQuery2.Columns.Add(Column17)
        SelectQuery2.FilterString = "[workers_bills.pay_date] Between(?SDate, ?EDate)"
        SelectQuery2.Name = "workers_bills"
        QueryParameter3.Name = "SDate"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("[Parameters.SDate]", GetType(Date))
        QueryParameter4.Name = "EDate"
        QueryParameter4.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter4.Value = New DevExpress.DataAccess.Expression("[Parameters.EDate]", GetType(Date))
        SelectQuery2.Parameters.Add(QueryParameter3)
        SelectQuery2.Parameters.Add(QueryParameter4)
        RelationColumnInfo3.NestedKeyColumn = "emp_id"
        RelationColumnInfo3.ParentKeyColumn = "emp_id"
        Join3.KeyColumns.Add(RelationColumnInfo3)
        Join3.Nested = Table5
        Join3.Parent = Table4
        RelationColumnInfo4.NestedKeyColumn = "pro_id"
        RelationColumnInfo4.ParentKeyColumn = "pro_id"
        Join4.KeyColumns.Add(RelationColumnInfo4)
        Join4.Nested = Table6
        Join4.Parent = Table4
        SelectQuery2.Relations.Add(Join3)
        SelectQuery2.Relations.Add(Join4)
        ColumnExpression19.ColumnName = "pay_date"
        ColumnExpression19.Table = Table4
        Sorting2.Expression = ColumnExpression19
        SelectQuery2.Sorting.Add(Sorting2)
        SelectQuery2.Tables.Add(Table4)
        SelectQuery2.Tables.Add(Table5)
        SelectQuery2.Tables.Add(Table6)
        ColumnExpression20.ColumnName = "total"
        Table7.Name = "Sbill"
        ColumnExpression20.Table = Table7
        Column18.Expression = ColumnExpression20
        ColumnExpression21.ColumnName = "Sbill_date"
        ColumnExpression21.Table = Table7
        Column19.Expression = ColumnExpression21
        ColumnExpression22.ColumnName = "note"
        ColumnExpression22.Table = Table7
        Column20.Expression = ColumnExpression22
        ColumnExpression23.ColumnName = "User_name"
        ColumnExpression23.Table = Table7
        Column21.Expression = ColumnExpression23
        ColumnExpression24.ColumnName = "Logs_time"
        ColumnExpression24.Table = Table7
        Column22.Expression = ColumnExpression24
        ColumnExpression25.ColumnName = "Mbill_name"
        Table8.Name = "Mbill"
        ColumnExpression25.Table = Table8
        Column23.Expression = ColumnExpression25
        SelectQuery3.Columns.Add(Column18)
        SelectQuery3.Columns.Add(Column19)
        SelectQuery3.Columns.Add(Column20)
        SelectQuery3.Columns.Add(Column21)
        SelectQuery3.Columns.Add(Column22)
        SelectQuery3.Columns.Add(Column23)
        SelectQuery3.FilterString = "[Sbill.Sbill_date] Between(?SDate, ?EDate)"
        SelectQuery3.Name = "Sbill"
        QueryParameter5.Name = "SDate"
        QueryParameter5.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter5.Value = New DevExpress.DataAccess.Expression("[Parameters.SDate]", GetType(Date))
        QueryParameter6.Name = "EDate"
        QueryParameter6.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter6.Value = New DevExpress.DataAccess.Expression("[Parameters.EDate]", GetType(Date))
        SelectQuery3.Parameters.Add(QueryParameter5)
        SelectQuery3.Parameters.Add(QueryParameter6)
        RelationColumnInfo5.NestedKeyColumn = "Mbill_id"
        RelationColumnInfo5.ParentKeyColumn = "Mbill_id"
        Join5.KeyColumns.Add(RelationColumnInfo5)
        Join5.Nested = Table8
        Join5.Parent = Table7
        SelectQuery3.Relations.Add(Join5)
        ColumnExpression26.ColumnName = "Sbill_date"
        ColumnExpression26.Table = Table7
        Sorting3.Expression = ColumnExpression26
        SelectQuery3.Sorting.Add(Sorting3)
        SelectQuery3.Tables.Add(Table7)
        SelectQuery3.Tables.Add(Table8)
        ColumnExpression27.ColumnName = "total"
        Table9.Name = "carBills"
        ColumnExpression27.Table = Table9
        Column24.Expression = ColumnExpression27
        ColumnExpression28.ColumnName = "carBill_date"
        ColumnExpression28.Table = Table9
        Column25.Expression = ColumnExpression28
        ColumnExpression29.ColumnName = "Note"
        ColumnExpression29.Table = Table9
        Column26.Expression = ColumnExpression29
        ColumnExpression30.ColumnName = "USER_NAME"
        ColumnExpression30.Table = Table9
        Column27.Expression = ColumnExpression30
        ColumnExpression31.ColumnName = "LOGS_TIME"
        ColumnExpression31.Table = Table9
        Column28.Expression = ColumnExpression31
        ColumnExpression32.ColumnName = "car_name"
        Table10.Name = "cars"
        ColumnExpression32.Table = Table10
        Column29.Expression = ColumnExpression32
        ColumnExpression33.ColumnName = "mainten_name"
        Table11.Name = "maintenance"
        ColumnExpression33.Table = Table11
        Column30.Expression = ColumnExpression33
        SelectQuery4.Columns.Add(Column24)
        SelectQuery4.Columns.Add(Column25)
        SelectQuery4.Columns.Add(Column26)
        SelectQuery4.Columns.Add(Column27)
        SelectQuery4.Columns.Add(Column28)
        SelectQuery4.Columns.Add(Column29)
        SelectQuery4.Columns.Add(Column30)
        SelectQuery4.FilterString = "[carBills.carBill_date] Between(?SDate, ?EDate)"
        SelectQuery4.Name = "carBills"
        QueryParameter7.Name = "SDate"
        QueryParameter7.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter7.Value = New DevExpress.DataAccess.Expression("[Parameters.SDate]", GetType(Date))
        QueryParameter8.Name = "EDate"
        QueryParameter8.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter8.Value = New DevExpress.DataAccess.Expression("[Parameters.EDate]", GetType(Date))
        SelectQuery4.Parameters.Add(QueryParameter7)
        SelectQuery4.Parameters.Add(QueryParameter8)
        RelationColumnInfo6.NestedKeyColumn = "car_id"
        RelationColumnInfo6.ParentKeyColumn = "car_id"
        Join6.KeyColumns.Add(RelationColumnInfo6)
        Join6.Nested = Table10
        Join6.Parent = Table9
        RelationColumnInfo7.NestedKeyColumn = "mainten_id"
        RelationColumnInfo7.ParentKeyColumn = "mainten_id"
        Join7.KeyColumns.Add(RelationColumnInfo7)
        Join7.Nested = Table11
        Join7.Parent = Table9
        SelectQuery4.Relations.Add(Join6)
        SelectQuery4.Relations.Add(Join7)
        ColumnExpression34.ColumnName = "carBill_date"
        ColumnExpression34.Table = Table9
        Sorting4.Expression = ColumnExpression34
        SelectQuery4.Sorting.Add(Sorting4)
        SelectQuery4.Tables.Add(Table9)
        SelectQuery4.Tables.Add(Table10)
        SelectQuery4.Tables.Add(Table11)
        ColumnExpression35.ColumnName = "P_MONEY"
        Table12.Name = "RES_PROJECT"
        ColumnExpression35.Table = Table12
        Column31.Expression = ColumnExpression35
        ColumnExpression36.ColumnName = "NOTE"
        ColumnExpression36.Table = Table12
        Column32.Expression = ColumnExpression36
        ColumnExpression37.ColumnName = "PAY_DATE"
        ColumnExpression37.Table = Table12
        Column33.Expression = ColumnExpression37
        ColumnExpression38.ColumnName = "USER_NAME"
        ColumnExpression38.Table = Table12
        Column34.Expression = ColumnExpression38
        ColumnExpression39.ColumnName = "LOGS_TIME"
        ColumnExpression39.Table = Table12
        Column35.Expression = ColumnExpression39
        ColumnExpression40.ColumnName = "pro_name"
        Table13.Name = "projects"
        ColumnExpression40.Table = Table13
        Column36.Expression = ColumnExpression40
        ColumnExpression41.ColumnName = "owner"
        ColumnExpression41.Table = Table13
        Column37.Expression = ColumnExpression41
        SelectQuery5.Columns.Add(Column31)
        SelectQuery5.Columns.Add(Column32)
        SelectQuery5.Columns.Add(Column33)
        SelectQuery5.Columns.Add(Column34)
        SelectQuery5.Columns.Add(Column35)
        SelectQuery5.Columns.Add(Column36)
        SelectQuery5.Columns.Add(Column37)
        SelectQuery5.FilterString = "[RES_PROJECT.PAY_DATE] Between(?SDate, ?EDate)"
        SelectQuery5.Name = "RES_PROJECT"
        QueryParameter9.Name = "SDate"
        QueryParameter9.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter9.Value = New DevExpress.DataAccess.Expression("[Parameters.SDate]", GetType(Date))
        QueryParameter10.Name = "EDate"
        QueryParameter10.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter10.Value = New DevExpress.DataAccess.Expression("[Parameters.EDate]", GetType(Date))
        SelectQuery5.Parameters.Add(QueryParameter9)
        SelectQuery5.Parameters.Add(QueryParameter10)
        RelationColumnInfo8.NestedKeyColumn = "pro_id"
        RelationColumnInfo8.ParentKeyColumn = "PRO_ID"
        Join8.KeyColumns.Add(RelationColumnInfo8)
        Join8.Nested = Table13
        Join8.Parent = Table12
        SelectQuery5.Relations.Add(Join8)
        SelectQuery5.Tables.Add(Table12)
        SelectQuery5.Tables.Add(Table13)
        ColumnExpression42.ColumnName = "AREA_NAME"
        Table14.Name = "RES_AREA"
        ColumnExpression42.Table = Table14
        Column38.Expression = ColumnExpression42
        ColumnExpression43.ColumnName = "A_MONEY"
        ColumnExpression43.Table = Table14
        Column39.Expression = ColumnExpression43
        ColumnExpression44.ColumnName = "NOTE"
        ColumnExpression44.Table = Table14
        Column40.Expression = ColumnExpression44
        ColumnExpression45.ColumnName = "PAY_DATE"
        ColumnExpression45.Table = Table14
        Column41.Expression = ColumnExpression45
        ColumnExpression46.ColumnName = "USER_NAME"
        ColumnExpression46.Table = Table14
        Column42.Expression = ColumnExpression46
        ColumnExpression47.ColumnName = "LOGS_TIME"
        ColumnExpression47.Table = Table14
        Column43.Expression = ColumnExpression47
        SelectQuery6.Columns.Add(Column38)
        SelectQuery6.Columns.Add(Column39)
        SelectQuery6.Columns.Add(Column40)
        SelectQuery6.Columns.Add(Column41)
        SelectQuery6.Columns.Add(Column42)
        SelectQuery6.Columns.Add(Column43)
        SelectQuery6.FilterString = "[RES_AREA.PAY_DATE] Between(?SDate, ?EDate)"
        SelectQuery6.Name = "RES_AREA"
        QueryParameter11.Name = "SDate"
        QueryParameter11.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter11.Value = New DevExpress.DataAccess.Expression("[Parameters.SDate]", GetType(Date))
        QueryParameter12.Name = "EDate"
        QueryParameter12.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter12.Value = New DevExpress.DataAccess.Expression("[Parameters.EDate]", GetType(Date))
        SelectQuery6.Parameters.Add(QueryParameter11)
        SelectQuery6.Parameters.Add(QueryParameter12)
        SelectQuery6.Tables.Add(Table14)
        ColumnExpression48.ColumnName = "PAID_MONEY"
        Table15.Name = "PAYMENT_Bills"
        ColumnExpression48.Table = Table15
        Column44.Expression = ColumnExpression48
        ColumnExpression49.ColumnName = "NOTE"
        ColumnExpression49.Table = Table15
        Column45.Expression = ColumnExpression49
        ColumnExpression50.ColumnName = "pay_date"
        ColumnExpression50.Table = Table15
        Column46.Expression = ColumnExpression50
        ColumnExpression51.ColumnName = "USER_NAME"
        ColumnExpression51.Table = Table15
        Column47.Expression = ColumnExpression51
        ColumnExpression52.ColumnName = "LOGS_TIME"
        ColumnExpression52.Table = Table15
        Column48.Expression = ColumnExpression52
        ColumnExpression53.ColumnName = "pay_no"
        ColumnExpression53.Table = Table15
        Column49.Expression = ColumnExpression53
        ColumnExpression54.ColumnName = "bill_name"
        Table16.Name = "bills"
        ColumnExpression54.Table = Table16
        Column50.Expression = ColumnExpression54
        ColumnExpression55.ColumnName = "pro_name"
        ColumnExpression55.Table = Table16
        Column51.Expression = ColumnExpression55
        SelectQuery7.Columns.Add(Column44)
        SelectQuery7.Columns.Add(Column45)
        SelectQuery7.Columns.Add(Column46)
        SelectQuery7.Columns.Add(Column47)
        SelectQuery7.Columns.Add(Column48)
        SelectQuery7.Columns.Add(Column49)
        SelectQuery7.Columns.Add(Column50)
        SelectQuery7.Columns.Add(Column51)
        SelectQuery7.FilterString = "[PAYMENT_Bills.pay_date] Between(?SDate, ?EDate)"
        SelectQuery7.Name = "PAYMENT_Bills"
        QueryParameter13.Name = "SDate"
        QueryParameter13.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter13.Value = New DevExpress.DataAccess.Expression("[Parameters.SDate]", GetType(Date))
        QueryParameter14.Name = "EDate"
        QueryParameter14.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter14.Value = New DevExpress.DataAccess.Expression("[Parameters.EDate]", GetType(Date))
        SelectQuery7.Parameters.Add(QueryParameter13)
        SelectQuery7.Parameters.Add(QueryParameter14)
        RelationColumnInfo9.NestedKeyColumn = "bill_id"
        RelationColumnInfo9.ParentKeyColumn = "bill_id"
        Join9.KeyColumns.Add(RelationColumnInfo9)
        Join9.Nested = Table16
        Join9.Parent = Table15
        SelectQuery7.Relations.Add(Join9)
        SelectQuery7.Tables.Add(Table15)
        SelectQuery7.Tables.Add(Table16)
        ColumnExpression56.ColumnName = "pro_name"
        Table17.Name = "payments"
        ColumnExpression56.Table = Table17
        Column52.Expression = ColumnExpression56
        ColumnExpression57.ColumnName = "pay_name"
        ColumnExpression57.Table = Table17
        Column53.Expression = ColumnExpression57
        ColumnExpression58.ColumnName = "amount"
        ColumnExpression58.Table = Table17
        Column54.Expression = ColumnExpression58
        ColumnExpression59.ColumnName = "pay_date"
        ColumnExpression59.Table = Table17
        Column55.Expression = ColumnExpression59
        ColumnExpression60.ColumnName = "USER_NAME"
        ColumnExpression60.Table = Table17
        Column56.Expression = ColumnExpression60
        ColumnExpression61.ColumnName = "LOGS_TIME"
        ColumnExpression61.Table = Table17
        Column57.Expression = ColumnExpression61
        ColumnExpression62.ColumnName = "x_name"
        Table18.Name = "x_work_info"
        ColumnExpression62.Table = Table18
        Column58.Expression = ColumnExpression62
        SelectQuery8.Columns.Add(Column52)
        SelectQuery8.Columns.Add(Column53)
        SelectQuery8.Columns.Add(Column54)
        SelectQuery8.Columns.Add(Column55)
        SelectQuery8.Columns.Add(Column56)
        SelectQuery8.Columns.Add(Column57)
        SelectQuery8.Columns.Add(Column58)
        SelectQuery8.FilterString = "[payments.pay_date] Between(?SDate, ?EDate)"
        SelectQuery8.Name = "payments"
        QueryParameter15.Name = "SDate"
        QueryParameter15.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter15.Value = New DevExpress.DataAccess.Expression("[Parameters.SDate]", GetType(Date))
        QueryParameter16.Name = "EDate"
        QueryParameter16.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter16.Value = New DevExpress.DataAccess.Expression("[Parameters.EDate]", GetType(Date))
        SelectQuery8.Parameters.Add(QueryParameter15)
        SelectQuery8.Parameters.Add(QueryParameter16)
        RelationColumnInfo10.NestedKeyColumn = "x_id"
        RelationColumnInfo10.ParentKeyColumn = "x_id"
        Join10.KeyColumns.Add(RelationColumnInfo10)
        Join10.Nested = Table18
        Join10.Parent = Table17
        SelectQuery8.Relations.Add(Join10)
        SelectQuery8.Tables.Add(Table17)
        SelectQuery8.Tables.Add(Table18)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1, SelectQuery2, SelectQuery3, SelectQuery4, SelectQuery5, SelectQuery6, SelectQuery7, SelectQuery8})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GroupHeader7
        '
        Me.GroupHeader7.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.GroupHeader7.HeightF = 25.0!
        Me.GroupHeader7.Name = "GroupHeader7"
        '
        'XrTable1
        '
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell37, Me.XrTableCell38, Me.XrTableCell55, Me.XrTableCell56, Me.XrTableCell89, Me.XrTableCell90})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 11.5R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.StyleName = "TableHeader"
        Me.XrTableCell37.Text = "وقت العملية"
        Me.XrTableCell37.Weight = 3.5714285714285716R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.StyleName = "TableHeader"
        Me.XrTableCell38.Text = "المستخدم"
        Me.XrTableCell38.Weight = 3.2159916371839281R
        '
        'XrTableCell55
        '
        Me.XrTableCell55.Multiline = True
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.StyleName = "TableHeader"
        Me.XrTableCell55.Text = "ملاحظة" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrTableCell55.Weight = 4.1657161452316833R
        '
        'XrTableCell56
        '
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.StyleName = "TableHeader"
        Me.XrTableCell56.Text = "التاريخ"
        Me.XrTableCell56.Weight = 2.8295637587181974R
        '
        'XrTableCell89
        '
        Me.XrTableCell89.Name = "XrTableCell89"
        Me.XrTableCell89.StyleName = "TableHeader"
        Me.XrTableCell89.Text = "المبلغ"
        Me.XrTableCell89.Weight = 3.3635696570801668R
        '
        'XrTableCell90
        '
        Me.XrTableCell90.Name = "XrTableCell90"
        Me.XrTableCell90.StyleName = "TableHeader"
        Me.XrTableCell90.Text = "اسم الجهة"
        Me.XrTableCell90.Weight = 4.2823016589288825R
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrLabel23, Me.XrPictureBox2, Me.XrPictureBox1, Me.XrLabel13})
        Me.ReportHeader.Expanded = False
        Me.ReportHeader.HeightF = 178.0833!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel27
        '
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(313.5!, 129.25!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(17.25!, 42.99996!)
        Me.XrLabel27.StyleName = "Title"
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "/"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel26
        '
        Me.XrLabel26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.EDate, "Text", "{0:MM/dd/yyyy}")})
        Me.XrLabel26.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(181.4999!, 129.25!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(132.0!, 42.99996!)
        Me.XrLabel26.StyleName = "Title"
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "XrLabel25"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'EDate
        '
        Me.EDate.Description = "نهاية الفترة"
        Me.EDate.Name = "EDate"
        Me.EDate.Type = GetType(Date)
        '
        'XrLabel25
        '
        Me.XrLabel25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.SDate, "Text", "{0:MM/dd/yyyy}")})
        Me.XrLabel25.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(332.9998!, 129.25!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(137.2502!, 42.99996!)
        Me.XrLabel25.StyleName = "Title"
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "XrLabel25"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'SDate
        '
        Me.SDate.Description = "بداية الفترة"
        Me.SDate.Name = "SDate"
        Me.SDate.Type = GetType(Date)
        '
        'XrLabel24
        '
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(164.2499!, 129.25!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(17.25!, 42.99996!)
        Me.XrLabel24.StyleName = "Title"
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "("
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel23
        '
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(470.25!, 129.25!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(17.25!, 42.99996!)
        Me.XrLabel23.StyleName = "Title"
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = ")"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(7.999929!, 0!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(117.4001!, 110.375!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(300.7917!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(318.2083!, 71.95832!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Simplified Arabic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.ForeColor = System.Drawing.Color.Black
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(501.6!, 71.95832!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(117.4!, 42.99999!)
        Me.XrLabel13.StyleName = "Title"
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "اليومي"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine4
        '
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 254.0833!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(628.0!, 23.0!)
        '
        'XrLabel46
        '
        Me.XrLabel46.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(448.9583!, 0!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(153.125!, 31.33334!)
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.Text = "إيرادات من جهة"
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableCell44
        '
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.StyleName = "TableHeader"
        Me.XrTableCell44.Text = "السيارة"
        Me.XrTableCell44.Weight = 3.5714285714285716R
        '
        'XrLine5
        '
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 42.70834!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(627.0!, 15.0!)
        '
        'XrTableRow16
        '
        Me.XrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell73, Me.XrTableCell74, Me.XrTableCell75, Me.XrTableCell76, Me.XrTableCell77, Me.XrTableCell78, Me.XrTableCell79})
        Me.XrTableRow16.Name = "XrTableRow16"
        Me.XrTableRow16.Weight = 11.5R
        '
        'XrTableCell73
        '
        Me.XrTableCell73.Name = "XrTableCell73"
        Me.XrTableCell73.StyleName = "TableHeader"
        Me.XrTableCell73.Text = "وقت العملية"
        Me.XrTableCell73.Weight = 0.15923566878980891R
        '
        'XrTableCell74
        '
        Me.XrTableCell74.Name = "XrTableCell74"
        Me.XrTableCell74.StyleName = "TableHeader"
        Me.XrTableCell74.Text = "المستخدم"
        Me.XrTableCell74.Weight = 0.1322947001523955R
        '
        'XrTableCell75
        '
        Me.XrTableCell75.Name = "XrTableCell75"
        Me.XrTableCell75.StyleName = "TableHeader"
        Me.XrTableCell75.Text = "ملاحظة"
        Me.XrTableCell75.Weight = 0.16768783907642895R
        '
        'XrTableCell76
        '
        Me.XrTableCell76.Name = "XrTableCell76"
        Me.XrTableCell76.StyleName = "TableHeader"
        Me.XrTableCell76.Text = "التاريخ"
        Me.XrTableCell76.Weight = 0.14308807143691471R
        '
        'XrTableCell77
        '
        Me.XrTableCell77.Name = "XrTableCell77"
        Me.XrTableCell77.StyleName = "TableHeader"
        Me.XrTableCell77.Text = "المبلغ"
        Me.XrTableCell77.Weight = 0.15928215697897996R
        '
        'XrTableCell78
        '
        Me.XrTableCell78.Name = "XrTableCell78"
        Me.XrTableCell78.StyleName = "TableHeader"
        Me.XrTableCell78.Text = "المالك"
        Me.XrTableCell78.Weight = 0.1672863046210544R
        '
        'XrTableCell79
        '
        Me.XrTableCell79.Name = "XrTableCell79"
        Me.XrTableCell79.StyleName = "TableHeader"
        Me.XrTableCell79.Text = "المشروع"
        Me.XrTableCell79.Weight = 0.18577494047307991R
        '
        'XrTableCell45
        '
        Me.XrTableCell45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "carBills.LOGS_TIME")})
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.Text = "XrTableCell45"
        Me.XrTableCell45.Weight = 4.4244788797255321R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers_bills.amount", "{0:c2}")})
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Text = "XrTableCell13"
        Me.XrTableCell13.Weight = 0.15923566878980891R
        '
        'XrTable3
        '
        Me.XrTable3.EvenStyleName = "TableBody2"
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.OddStyleName = "TableBody"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 11.5R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers_bills.LOGS_TIME")})
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Text = "XrTableCell9"
        Me.XrTableCell9.Weight = 0.15923566878980891R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers_bills.USER_NAME")})
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Text = "XrTableCell10"
        Me.XrTableCell10.Weight = 0.13229474077708744R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers_bills.pro_name")})
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Text = "XrTableCell11"
        Me.XrTableCell11.Weight = 0.18617659680253038R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers_bills.pay_date", "{0:MM/dd/yyyy}")})
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Text = "XrTableCell12"
        Me.XrTableCell12.Weight = 0.15923566878980891R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers_bills.job")})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.Weight = 0.15923566878980891R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers_bills.emp_name")})
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Text = "XrTableCell15"
        Me.XrTableCell15.Weight = 0.15923566878980891R
        '
        'XrTable13
        '
        Me.XrTable13.EvenStyleName = "TableBody2"
        Me.XrTable13.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable13.Name = "XrTable13"
        Me.XrTable13.OddStyleName = "TableBody"
        Me.XrTable13.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow19})
        Me.XrTable13.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow19
        '
        Me.XrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell101, Me.XrTableCell102, Me.XrTableCell103, Me.XrTableCell104, Me.XrTableCell105, Me.XrTableCell106, Me.XrTableCell107, Me.XrTableCell108})
        Me.XrTableRow19.Name = "XrTableRow19"
        Me.XrTableRow19.Weight = 11.5R
        '
        'XrTableCell101
        '
        Me.XrTableCell101.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "build_bills.LOGS_TIME")})
        Me.XrTableCell101.Name = "XrTableCell101"
        Me.XrTableCell101.Text = "XrTableCell101"
        Me.XrTableCell101.Weight = 0.15923566878980891R
        '
        'XrTableCell102
        '
        Me.XrTableCell102.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "build_bills.USER_NAME")})
        Me.XrTableCell102.Name = "XrTableCell102"
        Me.XrTableCell102.Text = "XrTableCell102"
        Me.XrTableCell102.Weight = 0.13176662945409803R
        '
        'XrTableCell103
        '
        Me.XrTableCell103.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "build_bills.pro_name")})
        Me.XrTableCell103.Name = "XrTableCell103"
        Me.XrTableCell103.Text = "XrTableCell103"
        Me.XrTableCell103.Weight = 0.21774045613103282R
        '
        'XrTableCell104
        '
        Me.XrTableCell104.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "build_bills.pay_date", "{0:MM/dd/yyyy}")})
        Me.XrTableCell104.Name = "XrTableCell104"
        Me.XrTableCell104.Text = "XrTableCell104"
        Me.XrTableCell104.Weight = 0.16674066664524609R
        '
        'XrTableCell105
        '
        Me.XrTableCell105.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "build_bills.Value_Price", "{0:c2}")})
        Me.XrTableCell105.Name = "XrTableCell105"
        Me.XrTableCell105.Text = "XrTableCell105"
        Me.XrTableCell105.Weight = 0.19490331262646304R
        '
        'XrTableCell106
        '
        Me.XrTableCell106.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "build_bills.quantity")})
        Me.XrTableCell106.Name = "XrTableCell106"
        Me.XrTableCell106.Text = "XrTableCell106"
        Me.XrTableCell106.Weight = 0.08350591919930829R
        '
        'XrTableCell107
        '
        Me.XrTableCell107.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "build_bills.price", "{0:c2}")})
        Me.XrTableCell107.Name = "XrTableCell107"
        Me.XrTableCell107.Text = "XrTableCell107"
        Me.XrTableCell107.Weight = 0.19245202645137732R
        '
        'XrTableCell108
        '
        Me.XrTableCell108.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "build_bills.sub_name")})
        Me.XrTableCell108.Name = "XrTableCell108"
        Me.XrTableCell108.Text = "XrTableCell108"
        Me.XrTableCell108.Weight = 0.12754067102113675R
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(465.8751!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(153.125!, 31.33334!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "المشتريات"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel51
        '
        Me.XrLabel51.Font = New System.Drawing.Font("Simplified Arabic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel51.FormattingRules.Add(Me.BayRule)
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(284.4426!, 143.125!)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(110.1003!, 49.375!)
        Me.XrLabel51.StyleName = "Title"
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        Me.XrLabel51.Text = "المتبقي"
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BayRule
        '
        Me.BayRule.Condition = "[IncomeTotal] < [BayTotal]"
        Me.BayRule.DataSource = Me.SqlDataSource1
        Me.BayRule.Formatting.ForeColor = System.Drawing.Color.Red
        Me.BayRule.Name = "BayRule"
        '
        'ReportHeader7
        '
        Me.ReportHeader7.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel46})
        Me.ReportHeader7.HeightF = 32.29167!
        Me.ReportHeader7.Name = "ReportHeader7"
        '
        'XrTableCell67
        '
        Me.XrTableCell67.Name = "XrTableCell67"
        Me.XrTableCell67.StyleName = "TableHeader"
        Me.XrTableCell67.Text = "اسم المقاول"
        Me.XrTableCell67.Weight = 0.15923566878980891R
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Simplified Arabic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Name = "Title"
        '
        'XrTableCell92
        '
        Me.XrTableCell92.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_AREA.USER_NAME")})
        Me.XrTableCell92.Name = "XrTableCell92"
        Me.XrTableCell92.Text = "XrTableCell92"
        Me.XrTableCell92.Weight = 3.2159911165246107R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StyleName = "TableHeader"
        Me.XrTableCell43.Text = "نوع الصيانة"
        Me.XrTableCell43.Weight = 3.5714285714285716R
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 100.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'BuyTotal
        '
        Me.BuyTotal.DataMember = "build_bills"
        Me.BuyTotal.DataSource = Me.SqlDataSource1
        Me.BuyTotal.Expression = "Iif(IsNull([].Sum([Value_Price])),0  ,[].Sum([Value_Price]) )"
        Me.BuyTotal.Name = "BuyTotal"
        '
        'GroupHeader6
        '
        Me.GroupHeader6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable9})
        Me.GroupHeader6.HeightF = 25.0!
        Me.GroupHeader6.Name = "GroupHeader6"
        '
        'XrTable9
        '
        Me.XrTable9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable9.Name = "XrTable9"
        Me.XrTable9.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9})
        Me.XrTable9.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell39, Me.XrTableCell40, Me.XrTableCell41, Me.XrTableCell42, Me.XrTableCell43, Me.XrTableCell44})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 11.5R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.StyleName = "TableHeader"
        Me.XrTableCell39.Text = "وقت العملية"
        Me.XrTableCell39.Weight = 4.4244783590662147R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.StyleName = "TableHeader"
        Me.XrTableCell40.Text = "المستخدم"
        Me.XrTableCell40.Weight = 3.0343286550728386R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.StyleName = "TableHeader"
        Me.XrTableCell41.Text = "التاريخ"
        Me.XrTableCell41.Weight = 3.2554787001466621R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.StyleName = "TableHeader"
        Me.XrTableCell42.Text = "المبلغ"
        Me.XrTableCell42.Weight = 3.5714285714285716R
        '
        'XrTableCell121
        '
        Me.XrTableCell121.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "carBills.carBill_date", "{0:MM/dd/yyyy}")})
        Me.XrTableCell121.Name = "XrTableCell121"
        Me.XrTableCell121.Text = "XrTableCell121"
        Me.XrTableCell121.Weight = 3.255479741465297R
        '
        'XrTable4
        '
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell109, Me.XrTableCell110})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 11.5R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StyleName = "TableHeader"
        Me.XrTableCell16.Text = "وقت العملية"
        Me.XrTableCell16.Weight = 0.15923566878980891R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StyleName = "TableHeader"
        Me.XrTableCell17.Text = "المستخدم"
        Me.XrTableCell17.Weight = 0.13229472723552346R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StyleName = "TableHeader"
        Me.XrTableCell18.Text = "المشروع"
        Me.XrTableCell18.Weight = 0.18617661034409436R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StyleName = "TableHeader"
        Me.XrTableCell19.Text = "التاريخ"
        Me.XrTableCell19.Weight = 0.15923566878980891R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StyleName = "TableHeader"
        Me.XrTableCell20.Text = "المبلغ"
        Me.XrTableCell20.Weight = 0.15923566878980891R
        '
        'XrTableCell109
        '
        Me.XrTableCell109.Name = "XrTableCell109"
        Me.XrTableCell109.StyleName = "TableHeader"
        Me.XrTableCell109.Text = "الوظيفة"
        Me.XrTableCell109.Weight = 0.15923566878980891R
        '
        'XrTableCell110
        '
        Me.XrTableCell110.Name = "XrTableCell110"
        Me.XrTableCell110.StyleName = "TableHeader"
        Me.XrTableCell110.Text = "الاسم"
        Me.XrTableCell110.Weight = 0.15923566878980891R
        '
        'Detail6
        '
        Me.Detail6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Detail6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable10})
        Me.Detail6.HeightF = 25.0!
        Me.Detail6.Name = "Detail6"
        Me.Detail6.StylePriority.UseBorders = False
        Me.Detail6.StylePriority.UseTextAlignment = False
        Me.Detail6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable10
        '
        Me.XrTable10.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable10.Name = "XrTable10"
        Me.XrTable10.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow10})
        Me.XrTable10.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell45, Me.XrTableCell46, Me.XrTableCell121, Me.XrTableCell122, Me.XrTableCell123, Me.XrTableCell124})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 11.5R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "carBills.USER_NAME")})
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.Text = "XrTableCell46"
        Me.XrTableCell46.Weight = 3.0343270930948862R
        '
        'XrTableCell122
        '
        Me.XrTableCell122.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "carBills.total", "{0:c2}")})
        Me.XrTableCell122.Name = "XrTableCell122"
        Me.XrTableCell122.Text = "XrTableCell122"
        Me.XrTableCell122.Weight = 3.5714285714285716R
        '
        'XrTableCell123
        '
        Me.XrTableCell123.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "carBills.mainten_name")})
        Me.XrTableCell123.Name = "XrTableCell123"
        Me.XrTableCell123.Text = "XrTableCell123"
        Me.XrTableCell123.Weight = 3.5714285714285716R
        '
        'XrTableCell124
        '
        Me.XrTableCell124.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "carBills.car_name")})
        Me.XrTableCell124.Name = "XrTableCell124"
        Me.XrTableCell124.Text = "XrTableCell124"
        Me.XrTableCell124.Weight = 3.5714285714285716R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.StyleName = "TableHeader"
        Me.XrTableCell52.Text = "الدفعة"
        Me.XrTableCell52.Weight = 0.13565465235420937R
        '
        'GroupFooter9
        '
        Me.GroupFooter9.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9, Me.XrLabel32})
        Me.GroupFooter9.Expanded = False
        Me.GroupFooter9.HeightF = 51.04167!
        Me.GroupFooter9.Name = "GroupFooter9"
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(365.0417!, 18.04167!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(262.4583!, 23.0!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "الإجمالي"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "payments.Ptotal", "{0:c2}")})
        Me.XrLabel32.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(0.500061!, 18.04167!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(364.5417!, 23.0!)
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:c2}"
        Me.XrLabel32.Summary = XrSummary1
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable15
        '
        Me.XrTable15.EvenStyleName = "TableBody2"
        Me.XrTable15.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable15.Name = "XrTable15"
        Me.XrTable15.OddStyleName = "TableBody"
        Me.XrTable15.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow15})
        Me.XrTable15.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow15
        '
        Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell68, Me.XrTableCell69, Me.XrTableCell70, Me.XrTableCell71, Me.XrTableCell72, Me.XrTableCell133, Me.XrTableCell134})
        Me.XrTableRow15.Name = "XrTableRow15"
        Me.XrTableRow15.Weight = 11.5R
        '
        'XrTableCell68
        '
        Me.XrTableCell68.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "payments.LOGS_TIME")})
        Me.XrTableCell68.Name = "XrTableCell68"
        Me.XrTableCell68.Text = "XrTableCell68"
        Me.XrTableCell68.Weight = 0.15923566878980891R
        '
        'XrTableCell69
        '
        Me.XrTableCell69.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "payments.USER_NAME")})
        Me.XrTableCell69.Name = "XrTableCell69"
        Me.XrTableCell69.Text = "XrTableCell69"
        Me.XrTableCell69.Weight = 0.15923566878980891R
        '
        'XrTableCell70
        '
        Me.XrTableCell70.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "payments.pay_date", "{0:MM/dd/yyyy}")})
        Me.XrTableCell70.Name = "XrTableCell70"
        Me.XrTableCell70.Text = "XrTableCell70"
        Me.XrTableCell70.Weight = 0.15923566878980891R
        '
        'XrTableCell71
        '
        Me.XrTableCell71.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "payments.amount", "{0:c2}")})
        Me.XrTableCell71.Name = "XrTableCell71"
        Me.XrTableCell71.Text = "XrTableCell71"
        Me.XrTableCell71.Weight = 0.15923566878980891R
        '
        'XrTableCell72
        '
        Me.XrTableCell72.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "payments.pay_name")})
        Me.XrTableCell72.Name = "XrTableCell72"
        Me.XrTableCell72.Text = "XrTableCell72"
        Me.XrTableCell72.Weight = 0.12464570710903646R
        '
        'XrTableCell133
        '
        Me.XrTableCell133.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "payments.pro_name")})
        Me.XrTableCell133.Name = "XrTableCell133"
        Me.XrTableCell133.Text = "XrTableCell133"
        Me.XrTableCell133.Weight = 0.19382563047058138R
        '
        'XrTableCell134
        '
        Me.XrTableCell134.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "payments.x_name")})
        Me.XrTableCell134.Name = "XrTableCell134"
        Me.XrTableCell134.Text = "XrTableCell134"
        Me.XrTableCell134.Weight = 0.15923566878980891R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel52, Me.XrLabel51, Me.XrLine4, Me.XrLabel31, Me.XrLabel30, Me.XrLabel29, Me.XrLabel28})
        Me.ReportFooter.Expanded = False
        Me.ReportFooter.HeightF = 277.0833!
        Me.ReportFooter.KeepTogether = True
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel52
        '
        Me.XrLabel52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.SqlDataSource1, "Rest", "{0:c2}")})
        Me.XrLabel52.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel52.FormattingRules.Add(Me.BayRule)
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(205.8428!, 192.5!)
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(250.8!, 49.375!)
        Me.XrLabel52.StyleName = "Title"
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.Text = "XrLabel28"
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.Font = New System.Drawing.Font("Simplified Arabic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(69.34275!, 37.5!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(149.25!, 49.37499!)
        Me.XrLabel31.StyleName = "Title"
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "المصروفات"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel30
        '
        Me.XrLabel30.Font = New System.Drawing.Font("Simplified Arabic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(409.8426!, 37.5!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(110.1003!, 49.375!)
        Me.XrLabel30.StyleName = "Title"
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "الإيرادات"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel29
        '
        Me.XrLabel29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.SqlDataSource1, "IncomeTotal", "{0:c2}")})
        Me.XrLabel29.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(339.3428!, 93.75!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(262.2501!, 49.375!)
        Me.XrLabel29.StyleName = "Title"
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "XrLabel28"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel28
        '
        Me.XrLabel28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Me.SqlDataSource1, "BayTotal", "{0:c2}")})
        Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(18.34285!, 93.75!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(250.8!, 49.375!)
        Me.XrLabel28.StyleName = "Title"
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "XrLabel28"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46.875!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(627.0!, 15.0!)
        '
        'GroupFooter7
        '
        Me.GroupFooter7.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel50, Me.XrLabel49})
        Me.GroupFooter7.Expanded = False
        Me.GroupFooter7.HeightF = 82.29166!
        Me.GroupFooter7.Name = "GroupFooter7"
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 54.87499!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(627.0!, 15.0!)
        '
        'XrLabel50
        '
        Me.XrLabel50.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_AREA.area_income", "{0:c2}")})
        Me.XrLabel50.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(364.5416!, 23.0!)
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:c2}"
        Me.XrLabel50.Summary = XrSummary2
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel49
        '
        Me.XrLabel49.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel49.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(364.5417!, 10.00001!)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(263.4583!, 23.0!)
        Me.XrLabel49.StylePriority.UseBorders = False
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "إجمالي الإيرادات الجهات"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableCell93
        '
        Me.XrTableCell93.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_AREA.NOTE")})
        Me.XrTableCell93.Name = "XrTableCell93"
        Me.XrTableCell93.Text = "XrTableCell93"
        Me.XrTableCell93.Weight = 4.1657166658910008R
        '
        'ReportHeader8
        '
        Me.ReportHeader8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel53})
        Me.ReportHeader8.Expanded = False
        Me.ReportHeader8.HeightF = 34.375!
        Me.ReportHeader8.Name = "ReportHeader8"
        '
        'XrLabel53
        '
        Me.XrLabel53.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(465.8753!, 0!)
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(153.125!, 31.33334!)
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.Text = "دفعات فواتير"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell94
        '
        Me.XrTableCell94.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_AREA.PAY_DATE", "{0:MM/dd/yyyy}")})
        Me.XrTableCell94.Name = "XrTableCell94"
        Me.XrTableCell94.Text = "XrTableCell94"
        Me.XrTableCell94.Weight = 2.8295658413554667R
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell47, Me.XrTableCell48, Me.XrTableCell49, Me.XrTableCell50, Me.XrTableCell51, Me.XrTableCell52, Me.XrTableCell53, Me.XrTableCell54})
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Weight = 11.5R
        '
        'XrTableCell47
        '
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.StyleName = "TableHeader"
        Me.XrTableCell47.Text = "وقت العملية"
        Me.XrTableCell47.Weight = 0.15923566878980891R
        '
        'XrTableCell48
        '
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.StyleName = "TableHeader"
        Me.XrTableCell48.Text = "المستخدم"
        Me.XrTableCell48.Weight = 0.13176662945409803R
        '
        'XrTableCell49
        '
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.StyleName = "TableHeader"
        Me.XrTableCell49.Text = "التاريخ"
        Me.XrTableCell49.Weight = 0.1524087086503097R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.StyleName = "TableHeader"
        Me.XrTableCell50.Text = "ملاحظة"
        Me.XrTableCell50.Weight = 0.16606265988145438R
        '
        'XrTableCell51
        '
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.StyleName = "TableHeader"
        Me.XrTableCell51.Text = "المبلغ"
        Me.XrTableCell51.Weight = 0.16557457548710455R
        '
        'XrTableCell53
        '
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.StyleName = "TableHeader"
        Me.XrTableCell53.Text = "نوع الفاتورة"
        Me.XrTableCell53.Weight = 0.15086849890034204R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.StyleName = "TableHeader"
        Me.XrTableCell54.Text = "المشروع"
        Me.XrTableCell54.Weight = 0.21231395680114429R
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLabel11})
        Me.GroupFooter3.Expanded = False
        Me.GroupFooter3.HeightF = 52.08333!
        Me.GroupFooter3.Name = "GroupFooter3"
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "workers_bills.amount")})
        Me.XrLabel12.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0!, 13.87501!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(364.5417!, 23.0!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:c2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel12.Summary = XrSummary3
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(364.5417!, 13.87501!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(262.4583!, 23.0!)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "إجمالي مصاريف العمالة"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow18
        '
        Me.XrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell91, Me.XrTableCell92, Me.XrTableCell93, Me.XrTableCell94, Me.XrTableCell95, Me.XrTableCell96})
        Me.XrTableRow18.Name = "XrTableRow18"
        Me.XrTableRow18.Weight = 11.5R
        '
        'XrTableCell91
        '
        Me.XrTableCell91.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_AREA.LOGS_TIME")})
        Me.XrTableCell91.Name = "XrTableCell91"
        Me.XrTableCell91.Text = "XrTableCell91"
        Me.XrTableCell91.Weight = 3.5714285714285716R
        '
        'XrTableCell95
        '
        Me.XrTableCell95.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_AREA.A_MONEY", "{0:c2}")})
        Me.XrTableCell95.Name = "XrTableCell95"
        Me.XrTableCell95.Text = "XrTableCell95"
        Me.XrTableCell95.Weight = 3.3635696570801672R
        '
        'XrTableCell96
        '
        Me.XrTableCell96.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_AREA.AREA_NAME")})
        Me.XrTableCell96.Name = "XrTableCell96"
        Me.XrTableCell96.Text = "XrTableCell96"
        Me.XrTableCell96.Weight = 4.2822995762916127R
        '
        'DetailReport5
        '
        Me.DetailReport5.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail6, Me.ReportHeader6, Me.GroupHeader6, Me.GroupFooter6})
        Me.DetailReport5.DataMember = "carBills"
        Me.DetailReport5.DataSource = Me.SqlDataSource1
        Me.DetailReport5.Expanded = False
        Me.DetailReport5.Level = 6
        Me.DetailReport5.Name = "DetailReport5"
        '
        'ReportHeader6
        '
        Me.ReportHeader6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20})
        Me.ReportHeader6.HeightF = 32.29167!
        Me.ReportHeader6.Name = "ReportHeader6"
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(465.8751!, 0!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(153.125!, 31.33334!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "فواتير السيارات"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupFooter6
        '
        Me.GroupFooter6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabel22, Me.XrLabel21})
        Me.GroupFooter6.Expanded = False
        Me.GroupFooter6.HeightF = 69.79166!
        Me.GroupFooter6.Name = "GroupFooter6"
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 44.79167!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(627.0!, 15.0!)
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "carBills.total")})
        Me.XrLabel22.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(0!, 9.999974!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(364.5417!, 23.0!)
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:c2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel22.Summary = XrSummary4
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel21.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(364.5416!, 9.999974!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(262.4584!, 23.0!)
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "الإجمالي"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell114
        '
        Me.XrTableCell114.Name = "XrTableCell114"
        Me.XrTableCell114.StyleName = "TableHeader"
        Me.XrTableCell114.Text = "اسم الفاتورة"
        Me.XrTableCell114.Weight = 3.5714285714285716R
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(364.5416!, 10.00001!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(262.4583!, 23.0!)
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "الإجمالي"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Ptotal
        '
        Me.Ptotal.DataMember = "payments"
        Me.Ptotal.DataSource = Me.SqlDataSource1
        Me.Ptotal.Expression = "Iif(IsNull([].Sum([amount])),0  ,[].Sum([amount]) )"
        Me.Ptotal.Name = "Ptotal"
        '
        'TableHeader
        '
        Me.TableHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TableHeader.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TableHeader.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableHeader.Name = "TableHeader"
        Me.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.ReportHeader1, Me.GroupHeader1, Me.GroupFooter1})
        Me.DetailReport.DataMember = "RES_PROJECT"
        Me.DetailReport.DataSource = Me.SqlDataSource1
        Me.DetailReport.Expanded = False
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable17})
        Me.Detail1.HeightF = 25.0!
        Me.Detail1.Name = "Detail1"
        Me.Detail1.StylePriority.UseTextAlignment = False
        Me.Detail1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable17
        '
        Me.XrTable17.EvenStyleName = "TableBody2"
        Me.XrTable17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable17.Name = "XrTable17"
        Me.XrTable17.OddStyleName = "TableBody"
        Me.XrTable17.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow17})
        Me.XrTable17.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow17
        '
        Me.XrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell80, Me.XrTableCell81, Me.XrTableCell82, Me.XrTableCell83, Me.XrTableCell84, Me.XrTableCell85, Me.XrTableCell86})
        Me.XrTableRow17.Name = "XrTableRow17"
        Me.XrTableRow17.Weight = 11.5R
        '
        'XrTableCell80
        '
        Me.XrTableCell80.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_PROJECT.LOGS_TIME")})
        Me.XrTableCell80.Name = "XrTableCell80"
        Me.XrTableCell80.Text = "XrTableCell80"
        Me.XrTableCell80.Weight = 0.15923566878980891R
        '
        'XrTableCell81
        '
        Me.XrTableCell81.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_PROJECT.USER_NAME")})
        Me.XrTableCell81.Name = "XrTableCell81"
        Me.XrTableCell81.Text = "XrTableCell81"
        Me.XrTableCell81.Weight = 0.13229472723552346R
        '
        'XrTableCell82
        '
        Me.XrTableCell82.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_PROJECT.NOTE")})
        Me.XrTableCell82.Name = "XrTableCell82"
        Me.XrTableCell82.Text = "XrTableCell82"
        Me.XrTableCell82.Weight = 0.16768786615955691R
        '
        'XrTableCell83
        '
        Me.XrTableCell83.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_PROJECT.PAY_DATE", "{0:MM/dd/yyyy}")})
        Me.XrTableCell83.Name = "XrTableCell83"
        Me.XrTableCell83.Text = "XrTableCell83"
        Me.XrTableCell83.Weight = 0.1430879631044028R
        '
        'XrTableCell84
        '
        Me.XrTableCell84.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_PROJECT.P_MONEY", "{0:c2}")})
        Me.XrTableCell84.Name = "XrTableCell84"
        Me.XrTableCell84.Text = "XrTableCell84"
        Me.XrTableCell84.Weight = 0.15928212989585203R
        '
        'XrTableCell85
        '
        Me.XrTableCell85.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_PROJECT.owner")})
        Me.XrTableCell85.Name = "XrTableCell85"
        Me.XrTableCell85.Text = "XrTableCell85"
        Me.XrTableCell85.Weight = 0.16728641295356631R
        '
        'XrTableCell86
        '
        Me.XrTableCell86.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_PROJECT.pro_name")})
        Me.XrTableCell86.Name = "XrTableCell86"
        Me.XrTableCell86.Text = "XrTableCell86"
        Me.XrTableCell86.Weight = 0.18577491338995195R
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.ReportHeader1.HeightF = 34.375!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(448.9583!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(153.125!, 31.33334!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "إيرادات المشاريع"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable16})
        Me.GroupHeader1.HeightF = 25.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable16
        '
        Me.XrTable16.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable16.Name = "XrTable16"
        Me.XrTable16.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow16})
        Me.XrTable16.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrLabel3, Me.XrLabel2})
        Me.GroupFooter1.Expanded = False
        Me.GroupFooter1.HeightF = 71.875!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RES_PROJECT.Pro_income", "{0:c2}")})
        Me.XrLabel3.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(364.5416!, 23.0!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:c2}"
        Me.XrLabel3.Summary = XrSummary5
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(364.5417!, 10.00001!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(263.4583!, 23.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "إجمالي الإيرادات المشاريع"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel57
        '
        Me.XrLabel57.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel57.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PAYMENT_Bills.BillSum", "{0:c2}")})
        Me.XrLabel57.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(364.5417!, 23.0!)
        Me.XrLabel57.StylePriority.UseBorders = False
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:c2}"
        Me.XrLabel57.Summary = XrSummary6
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell63
        '
        Me.XrTableCell63.Name = "XrTableCell63"
        Me.XrTableCell63.StyleName = "TableHeader"
        Me.XrTableCell63.Text = "التاريخ"
        Me.XrTableCell63.Weight = 0.15923566878980891R
        '
        'WorkerTotal
        '
        Me.WorkerTotal.DataMember = "workers_bills"
        Me.WorkerTotal.DataSource = Me.SqlDataSource1
        Me.WorkerTotal.Expression = "Iif(IsNull([].Sum([amount])), 0 ,[].Sum([amount]) )"
        Me.WorkerTotal.Name = "WorkerTotal"
        '
        'Detail7
        '
        Me.Detail7.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail7.EvenStyleName = "TableBody2"
        Me.Detail7.HeightF = 25.0!
        Me.Detail7.Name = "Detail7"
        Me.Detail7.OddStyleName = "TableBody"
        '
        'XrTable2
        '
        Me.XrTable2.EvenStyleName = "TableBody2"
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.OddStyleName = "TableBody"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow18})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Detail9
        '
        Me.Detail9.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable15})
        Me.Detail9.HeightF = 25.0!
        Me.Detail9.Name = "Detail9"
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(465.8751!, 0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(153.125!, 31.33334!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "فواتير خاصة شهرية"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.GroupHeader3.HeightF = 25.0!
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'XrTableCell61
        '
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.StyleName = "TableHeader"
        Me.XrTableCell61.Text = "وقت العملية"
        Me.XrTableCell61.Weight = 0.15923566878980891R
        '
        'XrTable18
        '
        Me.XrTable18.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable18.Name = "XrTable18"
        Me.XrTable18.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow20})
        Me.XrTable18.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow20
        '
        Me.XrTableRow20.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell115, Me.XrTableCell116, Me.XrTableCell117, Me.XrTableCell118, Me.XrTableCell119, Me.XrTableCell120})
        Me.XrTableRow20.Name = "XrTableRow20"
        Me.XrTableRow20.Weight = 11.5R
        '
        'XrTableCell115
        '
        Me.XrTableCell115.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sbill.Logs_time")})
        Me.XrTableCell115.Name = "XrTableCell115"
        Me.XrTableCell115.Text = "XrTableCell115"
        Me.XrTableCell115.Weight = 3.9979532049177346R
        '
        'XrTableCell116
        '
        Me.XrTableCell116.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sbill.User_name")})
        Me.XrTableCell116.Name = "XrTableCell116"
        Me.XrTableCell116.Text = "XrTableCell116"
        Me.XrTableCell116.Weight = 2.7894670036947651R
        '
        'XrTableCell117
        '
        Me.XrTableCell117.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sbill.note")})
        Me.XrTableCell117.Name = "XrTableCell117"
        Me.XrTableCell117.Text = "XrTableCell117"
        Me.XrTableCell117.Weight = 4.57517616959243R
        '
        'XrTableCell118
        '
        Me.XrTableCell118.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sbill.Sbill_date", "{0:MM/dd/yyyy}")})
        Me.XrTableCell118.Name = "XrTableCell118"
        Me.XrTableCell118.Text = "XrTableCell118"
        Me.XrTableCell118.Weight = 2.923117907509357R
        '
        'XrTableCell119
        '
        Me.XrTableCell119.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sbill.total", "{0:c2}")})
        Me.XrTableCell119.Name = "XrTableCell119"
        Me.XrTableCell119.Text = "XrTableCell119"
        Me.XrTableCell119.Weight = 3.5714285714285716R
        '
        'XrTableCell120
        '
        Me.XrTableCell120.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sbill.Mbill_name")})
        Me.XrTableCell120.Name = "XrTableCell120"
        Me.XrTableCell120.Text = "XrTableCell120"
        Me.XrTableCell120.Weight = 3.5714285714285716R
        '
        'GroupHeader8
        '
        Me.GroupHeader8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable11})
        Me.GroupHeader8.Expanded = False
        Me.GroupHeader8.HeightF = 25.0!
        Me.GroupHeader8.Name = "GroupHeader8"
        '
        'XrTable11
        '
        Me.XrTable11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable11.Name = "XrTable11"
        Me.XrTable11.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow11})
        Me.XrTable11.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.StyleName = "TableHeader"
        Me.XrTableCell31.Text = "وقت العملية"
        Me.XrTableCell31.Weight = 3.9979532049177346R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StyleName = "TableHeader"
        Me.XrTableCell34.Text = "التاريخ"
        Me.XrTableCell34.Weight = 2.9231199901466267R
        '
        'DetailReport2
        '
        Me.DetailReport2.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail3, Me.ReportHeader3, Me.GroupHeader3, Me.GroupFooter3})
        Me.DetailReport2.DataMember = "workers_bills"
        Me.DetailReport2.DataSource = Me.SqlDataSource1
        Me.DetailReport2.Expanded = False
        Me.DetailReport2.Level = 3
        Me.DetailReport2.Name = "DetailReport2"
        '
        'Detail3
        '
        Me.Detail3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.Detail3.HeightF = 25.0!
        Me.Detail3.Name = "Detail3"
        '
        'ReportHeader3
        '
        Me.ReportHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10})
        Me.ReportHeader3.HeightF = 31.33334!
        Me.ReportHeader3.Name = "ReportHeader3"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(465.8751!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(153.125!, 31.33334!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "مصاريف العمالة"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupHeader5
        '
        Me.GroupHeader5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable7})
        Me.GroupHeader5.HeightF = 25.0!
        Me.GroupHeader5.Name = "GroupHeader5"
        '
        'XrTable7
        '
        Me.XrTable7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable7.Name = "XrTable7"
        Me.XrTable7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable7.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell33, Me.XrTableCell34, Me.XrTableCell113, Me.XrTableCell114})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 11.5R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StyleName = "TableHeader"
        Me.XrTableCell32.Text = "المستخدم"
        Me.XrTableCell32.Weight = 2.7894664830354476R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StyleName = "TableHeader"
        Me.XrTableCell33.Text = "ملاحظة"
        Me.XrTableCell33.Weight = 4.5751746076144775R
        '
        'XrTableCell113
        '
        Me.XrTableCell113.Name = "XrTableCell113"
        Me.XrTableCell113.StyleName = "TableHeader"
        Me.XrTableCell113.Text = "المبلغ"
        Me.XrTableCell113.Weight = 3.5714285714285716R
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(250.8!, 10.00001!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(153.125!, 31.33334!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "المصروفات"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupHeader9
        '
        Me.GroupHeader9.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable14})
        Me.GroupHeader9.HeightF = 25.0!
        Me.GroupHeader9.Name = "GroupHeader9"
        '
        'XrTable14
        '
        Me.XrTable14.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable14.Name = "XrTable14"
        Me.XrTable14.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow14})
        Me.XrTable14.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'XrTableRow14
        '
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell61, Me.XrTableCell62, Me.XrTableCell63, Me.XrTableCell64, Me.XrTableCell65, Me.XrTableCell66, Me.XrTableCell67})
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.Weight = 11.5R
        '
        'XrTableCell62
        '
        Me.XrTableCell62.Name = "XrTableCell62"
        Me.XrTableCell62.StyleName = "TableHeader"
        Me.XrTableCell62.Text = "المستخدم"
        Me.XrTableCell62.Weight = 0.15923566878980891R
        '
        'XrTableCell64
        '
        Me.XrTableCell64.Name = "XrTableCell64"
        Me.XrTableCell64.StyleName = "TableHeader"
        Me.XrTableCell64.Text = "المبلغ"
        Me.XrTableCell64.Weight = 0.15923566878980891R
        '
        'XrTableCell65
        '
        Me.XrTableCell65.Name = "XrTableCell65"
        Me.XrTableCell65.StyleName = "TableHeader"
        Me.XrTableCell65.Text = "رقم الدفعة"
        Me.XrTableCell65.Weight = 0.12464570710903646R
        '
        'XrTableCell66
        '
        Me.XrTableCell66.Name = "XrTableCell66"
        Me.XrTableCell66.StyleName = "TableHeader"
        Me.XrTableCell66.Text = "المشروع"
        Me.XrTableCell66.Weight = 0.19382563047058138R
        '
        'XrLabel56
        '
        Me.XrLabel56.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel56.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(364.5415!, 10.00001!)
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(262.4584!, 23.0!)
        Me.XrLabel56.StylePriority.UseBorders = False
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        Me.XrLabel56.Text = "الإجمالي"
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'CarTotal
        '
        Me.CarTotal.DataMember = "carBills"
        Me.CarTotal.DataSource = Me.SqlDataSource1
        Me.CarTotal.Expression = "Iif(IsNull([].Sum([total])),0  ,[].Sum([total]) )"
        Me.CarTotal.Name = "CarTotal"
        '
        'DetailReport7
        '
        Me.DetailReport7.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail8, Me.ReportHeader8, Me.GroupHeader8, Me.GroupFooter8})
        Me.DetailReport7.DataMember = "PAYMENT_Bills"
        Me.DetailReport7.DataSource = Me.SqlDataSource1
        Me.DetailReport7.Expanded = False
        Me.DetailReport7.Level = 7
        Me.DetailReport7.Name = "DetailReport7"
        '
        'Detail8
        '
        Me.Detail8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable12})
        Me.Detail8.Expanded = False
        Me.Detail8.HeightF = 25.0!
        Me.Detail8.Name = "Detail8"
        Me.Detail8.StylePriority.UseTextAlignment = False
        Me.Detail8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable12
        '
        Me.XrTable12.EvenStyleName = "TableBody2"
        Me.XrTable12.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable12.Name = "XrTable12"
        Me.XrTable12.OddStyleName = "TableBody"
        Me.XrTable12.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow12})
        Me.XrTable12.SizeF = New System.Drawing.SizeF(628.0!, 25.0!)
        '
        'GroupFooter8
        '
        Me.GroupFooter8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine5, Me.XrLabel57, Me.XrLabel56})
        Me.GroupFooter8.Expanded = False
        Me.GroupFooter8.HeightF = 67.70834!
        Me.GroupFooter8.Name = "GroupFooter8"
        '
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2, Me.ReportHeader2, Me.GroupHeader2, Me.GroupFooter2})
        Me.DetailReport1.DataMember = "build_bills"
        Me.DetailReport1.DataSource = Me.SqlDataSource1
        Me.DetailReport1.Expanded = False
        Me.DetailReport1.Level = 2
        Me.DetailReport1.Name = "DetailReport1"
        '
        'Detail2
        '
        Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable13})
        Me.Detail2.HeightF = 25.0!
        Me.Detail2.Name = "Detail2"
        '
        'ReportHeader2
        '
        Me.ReportHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4})
        Me.ReportHeader2.Expanded = False
        Me.ReportHeader2.HeightF = 52.08333!
        Me.ReportHeader2.Name = "ReportHeader2"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable8, Me.XrLabel5})
        Me.GroupHeader2.HeightF = 56.95836!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel6})
        Me.GroupFooter2.Expanded = False
        Me.GroupFooter2.HeightF = 48.95833!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "build_bills.Value_Price")})
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(364.5417!, 23.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:c2}"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel7.Summary = XrSummary7
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(364.5417!, 10.00001!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(263.4583!, 23.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "إجمالي المشتريات"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ProjectTtotal
        '
        Me.ProjectTtotal.DataMember = "projects"
        Me.ProjectTtotal.DataSource = Me.SqlDataSource1
        Me.ProjectTtotal.Expression = "Iif(IsNull([].Sum([total_budget])),0  ,[].Sum([total_budget]) )"
        Me.ProjectTtotal.Name = "ProjectTtotal"
        '
        'DetailReport6
        '
        Me.DetailReport6.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail7, Me.ReportHeader7, Me.GroupHeader7, Me.GroupFooter7})
        Me.DetailReport6.DataMember = "RES_AREA"
        Me.DetailReport6.DataSource = Me.SqlDataSource1
        Me.DetailReport6.Expanded = False
        Me.DetailReport6.Level = 1
        Me.DetailReport6.Name = "DetailReport6"
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Sbill.total")})
        Me.XrLabel19.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.00001!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(364.5416!, 23.0!)
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:c2}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel19.Summary = XrSummary8
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 100.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'ReportHeader5
        '
        Me.ReportHeader5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17})
        Me.ReportHeader5.HeightF = 34.375!
        Me.ReportHeader5.Name = "ReportHeader5"
        '
        'area_income
        '
        Me.area_income.DataMember = "RES_AREA"
        Me.area_income.DataSource = Me.SqlDataSource1
        Me.area_income.Expression = "Iif(IsNull([].Sum([A_MONEY])),0  ,[].Sum([A_MONEY]) )"
        Me.area_income.Name = "area_income"
        '
        'Rest
        '
        Me.Rest.DataSource = Me.SqlDataSource1
        Me.Rest.Expression = "[IncomeTotal] - [BayTotal]"
        Me.Rest.Name = "Rest"
        '
        'TableBody2
        '
        Me.TableBody2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TableBody2.Font = New System.Drawing.Font("Simplified Arabic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableBody2.Name = "TableBody2"
        Me.TableBody2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Xtotal
        '
        Me.Xtotal.DataMember = "x_workers"
        Me.Xtotal.DataSource = Me.SqlDataSource1
        Me.Xtotal.Expression = "Iif(IsNull([].Sum([bidget])),0  ,[].Sum([bidget]) )"
        Me.Xtotal.Name = "Xtotal"
        '
        'Pro_income
        '
        Me.Pro_income.DataMember = "RES_PROJECT"
        Me.Pro_income.DataSource = Me.SqlDataSource1
        Me.Pro_income.Expression = "Iif(IsNull([].Sum([P_MONEY])),0  ,[].Sum([P_MONEY]) )"
        Me.Pro_income.Name = "Pro_income"
        '
        'DetailReport8
        '
        Me.DetailReport8.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail9, Me.ReportHeader9, Me.GroupHeader9, Me.GroupFooter9})
        Me.DetailReport8.DataMember = "payments"
        Me.DetailReport8.DataSource = Me.SqlDataSource1
        Me.DetailReport8.Expanded = False
        Me.DetailReport8.Level = 4
        Me.DetailReport8.Name = "DetailReport8"
        '
        'ReportHeader9
        '
        Me.ReportHeader9.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8})
        Me.ReportHeader9.HeightF = 34.375!
        Me.ReportHeader9.Name = "ReportHeader9"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(465.8753!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(153.125!, 31.33334!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "دفعات مقاولين الباطن"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'IncomeTotal
        '
        Me.IncomeTotal.DataSource = Me.SqlDataSource1
        Me.IncomeTotal.Expression = "[RES_AREA.area_income] + [RES_PROJECT.Pro_income]"
        Me.IncomeTotal.Name = "IncomeTotal"
        '
        'Detail
        '
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Detail.Visible = False
        '
        'TableBody
        '
        Me.TableBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableBody.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.TableBody.Font = New System.Drawing.Font("Simplified Arabic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableBody.Name = "TableBody"
        Me.TableBody.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TableBody.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DetailReport4
        '
        Me.DetailReport4.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail5, Me.ReportHeader5, Me.GroupHeader5, Me.GroupFooter5})
        Me.DetailReport4.DataMember = "Sbill"
        Me.DetailReport4.DataSource = Me.SqlDataSource1
        Me.DetailReport4.Expanded = False
        Me.DetailReport4.Level = 5
        Me.DetailReport4.Name = "DetailReport4"
        '
        'Detail5
        '
        Me.Detail5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Detail5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable18})
        Me.Detail5.HeightF = 25.0!
        Me.Detail5.Name = "Detail5"
        Me.Detail5.StylePriority.UseBorders = False
        Me.Detail5.StylePriority.UseTextAlignment = False
        Me.Detail5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupFooter5
        '
        Me.GroupFooter5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel19, Me.XrLabel18})
        Me.GroupFooter5.Expanded = False
        Me.GroupFooter5.HeightF = 52.08333!
        Me.GroupFooter5.Name = "GroupFooter5"
        '
        'BayTotal
        '
        Me.BayTotal.DataSource = Me.SqlDataSource1
        Me.BayTotal.Expression = "[build_bills.BuyTotal] + [carBills.CarTotal] + [Sbill.Stotal] + [workers_bills.Wo" &
    "rkerTotal] + [payments.Ptotal] + [PAYMENT_Bills.BillSum]"
        Me.BayTotal.Name = "BayTotal"
        '
        'BillSum
        '
        Me.BillSum.DataMember = "PAYMENT_Bills"
        Me.BillSum.DataSource = Me.SqlDataSource1
        Me.BillSum.Expression = "Iif(IsNull([].Sum([PAID_MONEY])),0  ,[].Sum([PAID_MONEY]) )"
        Me.BillSum.Name = "BillSum"
        '
        'DailyReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1, Me.DetailReport, Me.DetailReport1, Me.DetailReport2, Me.DetailReport4, Me.DetailReport5, Me.ReportHeader, Me.ReportFooter, Me.DetailReport6, Me.DetailReport7, Me.DetailReport8})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.BuyTotal, Me.ProjectTtotal, Me.CarTotal, Me.Stotal, Me.WorkerTotal, Me.Xtotal, Me.BayTotal, Me.Pro_income, Me.area_income, Me.IncomeTotal, Me.Rest, Me.BillSum, Me.Ptotal})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.BayRule})
        Me.Margins = New System.Drawing.Printing.Margins(100, 99, 100, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.SDate, Me.EDate})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.TableHeader, Me.TableBody, Me.TableBody2})
        Me.Version = "17.1"
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell125 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell126 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell127 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell128 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell129 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell130 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell131 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell132 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell59 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell97 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell98 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell99 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell100 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Stotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GroupHeader7 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell89 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell90 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents EDate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SDate As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTableRow16 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell73 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell74 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell75 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell76 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell77 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell78 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell79 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable13 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow19 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell101 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell102 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell103 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell104 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell105 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell106 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell107 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell108 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BayRule As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents ReportHeader7 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrTableCell67 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents XrTableCell92 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents BuyTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents GroupHeader6 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable9 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell121 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell109 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell110 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Detail6 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable10 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell122 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell123 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell124 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter9 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable15 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow15 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell68 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell69 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell70 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell71 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell72 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell133 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell134 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupFooter7 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell93 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeader8 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell94 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableRow18 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell91 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell95 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell96 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DetailReport5 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents ReportHeader6 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter6 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell114 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ptotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TableHeader As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable17 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow17 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell80 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell81 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell82 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell83 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell84 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell85 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell86 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeader1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable16 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell63 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents WorkerTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Detail7 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents Detail9 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTableCell61 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable18 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow20 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell115 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell116 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell117 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell118 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell119 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell120 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader8 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable11 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DetailReport2 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail3 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeader3 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader5 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell113 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader9 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable14 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell62 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell64 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell65 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell66 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CarTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents DetailReport7 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail8 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable12 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents GroupFooter8 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail2 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeader2 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ProjectTtotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents DetailReport6 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents ReportHeader5 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents area_income As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Rest As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TableBody2 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents Xtotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Pro_income As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents DetailReport8 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents ReportHeader9 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents IncomeTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TableBody As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailReport4 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail5 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupFooter5 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents BayTotal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents BillSum As DevExpress.XtraReports.UI.CalculatedField
End Class
