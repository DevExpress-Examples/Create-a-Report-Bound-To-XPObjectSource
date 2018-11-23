Namespace Create_a_Report_Bound_to_XPObjectSource
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.xpObjectSource1 = New DevExpress.Xpo.XPObjectSource(Me.components)
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailCaption2 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData2 = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.table1 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.table2 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.table3 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.table4 = New DevExpress.XtraReports.UI.XRTable()
            Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            CType(Me.xpObjectSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' xpObjectSource1
            ' 
            Me.xpObjectSource1.ConnectionStringName = "nwind"
            Me.xpObjectSource1.EntityTypeString = "Create_a_Report_Bound_to_XPObjectSource.nwind.Categories, Create a Report Bound t" & "o XPObjectSource, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.xpObjectSource1.Name = "xpObjectSource1"
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Tahoma", 14F)
            Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
            Me.Title.Name = "Title"
            ' 
            ' GroupCaption1
            ' 
            Me.GroupCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
            Me.GroupCaption1.BorderColor = System.Drawing.Color.White
            Me.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupCaption1.BorderWidth = 2F
            Me.GroupCaption1.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(228)))), (CInt((CByte(228)))), (CInt((CByte(228)))))
            Me.GroupCaption1.Name = "GroupCaption1"
            Me.GroupCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' GroupData1
            ' 
            Me.GroupData1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
            Me.GroupData1.BorderColor = System.Drawing.Color.White
            Me.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.GroupData1.BorderWidth = 2F
            Me.GroupData1.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.GroupData1.ForeColor = System.Drawing.Color.White
            Me.GroupData1.Name = "GroupData1"
            Me.GroupData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
            Me.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailCaption1
            ' 
            Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
            Me.DetailCaption1.BorderColor = System.Drawing.Color.White
            Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailCaption1.BorderWidth = 2F
            Me.DetailCaption1.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.DetailCaption1.ForeColor = System.Drawing.Color.White
            Me.DetailCaption1.Name = "DetailCaption1"
            Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData1
            ' 
            Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailData1.BorderWidth = 2F
            Me.DetailData1.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.DetailData1.ForeColor = System.Drawing.Color.Black
            Me.DetailData1.Name = "DetailData1"
            Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailCaption2
            ' 
            Me.DetailCaption2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(111)))), (CInt((CByte(111)))), (CInt((CByte(111)))))
            Me.DetailCaption2.BorderColor = System.Drawing.Color.White
            Me.DetailCaption2.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailCaption2.BorderWidth = 2F
            Me.DetailCaption2.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.DetailCaption2.ForeColor = System.Drawing.Color.White
            Me.DetailCaption2.Name = "DetailCaption2"
            Me.DetailCaption2.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailCaption2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData2
            ' 
            Me.DetailData2.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData2.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.DetailData2.BorderWidth = 2F
            Me.DetailData2.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.DetailData2.ForeColor = System.Drawing.Color.Black
            Me.DetailData2.Name = "DetailData2"
            Me.DetailData2.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' DetailData3_Odd
            ' 
            Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
            Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
            Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DetailData3_Odd.BorderWidth = 1F
            Me.DetailData3_Odd.Font = New System.Drawing.Font("Tahoma", 8F)
            Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
            Me.DetailData3_Odd.Name = "DetailData3_Odd"
            Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
            Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
            Me.PageInfo.Name = "PageInfo"
            Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.pageInfo1, Me.pageInfo2})
            Me.BottomMargin.Name = "BottomMargin"
            ' 
            ' pageInfo1
            ' 
            Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.pageInfo1.Name = "pageInfo1"
            Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.pageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.pageInfo1.StyleName = "PageInfo"
            ' 
            ' pageInfo2
            ' 
            Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
            Me.pageInfo2.Name = "pageInfo2"
            Me.pageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.pageInfo2.StyleName = "PageInfo"
            Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.pageInfo2.TextFormatString = "Page {0} of {1}"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label1})
            Me.ReportHeader.HeightF = 60F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' label1
            ' 
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.label1.Name = "label1"
            Me.label1.SizeF = New System.Drawing.SizeF(638F, 25.55338F)
            Me.label1.StyleName = "Title"
            Me.label1.Text = "Categories"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table1})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 27F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' table1
            ' 
            Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 2F)
            Me.table1.Name = "table1"
            Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow1})
            Me.table1.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' tableRow1
            ' 
            Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell1, Me.tableCell2})
            Me.tableRow1.Name = "tableRow1"
            Me.tableRow1.Weight = 1R
            ' 
            ' tableCell1
            ' 
            Me.tableCell1.Name = "tableCell1"
            Me.tableCell1.StyleName = "GroupCaption1"
            Me.tableCell1.Text = "CATEGORY NAME"
            Me.tableCell1.Weight = 0.16183860191932092R
            ' 
            ' tableCell2
            ' 
            Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
            Me.tableCell2.Name = "tableCell2"
            Me.tableCell2.StyleName = "GroupData1"
            Me.tableCell2.Weight = 0.8381614332932692R
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table2})
            Me.Detail.HeightF = 56F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            ' 
            ' table2
            ' 
            Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table2.Name = "table2"
            Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow2, Me.tableRow3})
            Me.table2.SizeF = New System.Drawing.SizeF(650F, 56F)
            ' 
            ' tableRow2
            ' 
            Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell3})
            Me.tableRow2.Name = "tableRow2"
            Me.tableRow2.Weight = 0.5R
            ' 
            ' tableCell3
            ' 
            Me.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell3.Name = "tableCell3"
            Me.tableCell3.StyleName = "DetailCaption1"
            Me.tableCell3.StylePriority.UseBorders = False
            Me.tableCell3.Text = "Description"
            Me.tableCell3.Weight = 1R
            ' 
            ' tableRow3
            ' 
            Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell4})
            Me.tableRow3.Name = "tableRow3"
            Me.tableRow3.Weight = 0.5R
            ' 
            ' tableCell4
            ' 
            Me.tableCell4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
            Me.tableCell4.Name = "tableCell4"
            Me.tableCell4.StyleName = "DetailData1"
            Me.tableCell4.StylePriority.UseBorders = False
            Me.tableCell4.Weight = 1R
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.GroupHeader2, Me.Detail1})
            Me.DetailReport.DataMember = "ProductsCollection"
            Me.DetailReport.DataSource = Me.xpObjectSource1
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' GroupHeader2
            ' 
            Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table3})
            Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader2.HeightF = 28F
            Me.GroupHeader2.Name = "GroupHeader2"
            ' 
            ' table3
            ' 
            Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table3.Name = "table3"
            Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow4})
            Me.table3.SizeF = New System.Drawing.SizeF(650F, 28F)
            ' 
            ' tableRow4
            ' 
            Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell5, Me.tableCell6, Me.tableCell7})
            Me.tableRow4.Name = "tableRow4"
            Me.tableRow4.Weight = 1R
            ' 
            ' tableCell5
            ' 
            Me.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell5.Name = "tableCell5"
            Me.tableCell5.StyleName = "DetailCaption2"
            Me.tableCell5.StylePriority.UseBorders = False
            Me.tableCell5.Text = "Product Name"
            Me.tableCell5.Weight = 0.36587630051832931R
            ' 
            ' tableCell6
            ' 
            Me.tableCell6.Name = "tableCell6"
            Me.tableCell6.StyleName = "DetailCaption2"
            Me.tableCell6.StylePriority.UseTextAlignment = False
            Me.tableCell6.Text = "Unit Price"
            Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell6.Weight = 0.26884307861328127R
            ' 
            ' tableCell7
            ' 
            Me.tableCell7.Name = "tableCell7"
            Me.tableCell7.StyleName = "DetailCaption2"
            Me.tableCell7.StylePriority.UseTextAlignment = False
            Me.tableCell7.Text = "Units In Stock"
            Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell7.Weight = 0.36528062086838942R
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table4})
            Me.Detail1.HeightF = 25F
            Me.Detail1.Name = "Detail1"
            ' 
            ' table4
            ' 
            Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.table4.Name = "table4"
            Me.table4.OddStyleName = "DetailData3_Odd"
            Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow5})
            Me.table4.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' tableRow5
            ' 
            Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell8, Me.tableCell9, Me.tableCell10})
            Me.tableRow5.Name = "tableRow5"
            Me.tableRow5.Weight = 11.5R
            ' 
            ' tableCell8
            ' 
            Me.tableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.tableCell8.Name = "tableCell8"
            Me.tableCell8.StyleName = "DetailData2"
            Me.tableCell8.StylePriority.UseBorders = False
            Me.tableCell8.Weight = 0.36587630051832931R
            ' 
            ' tableCell9
            ' 
            Me.tableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.tableCell9.Name = "tableCell9"
            Me.tableCell9.StyleName = "DetailData2"
            Me.tableCell9.StylePriority.UseTextAlignment = False
            Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell9.TextFormatString = "{0:C2}"
            Me.tableCell9.Weight = 0.26884307861328127R
            ' 
            ' tableCell10
            ' 
            Me.tableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsInStock]")})
            Me.tableCell10.Name = "tableCell10"
            Me.tableCell10.StyleName = "DetailData2"
            Me.tableCell10.StylePriority.UseTextAlignment = False
            Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.tableCell10.Weight = 0.36528062086838942R
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.DetailReport})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.xpObjectSource1})
            Me.DataSource = Me.xpObjectSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.GroupCaption1, Me.GroupData1, Me.DetailCaption1, Me.DetailData1, Me.DetailCaption2, Me.DetailData2, Me.DetailData3_Odd, Me.PageInfo})
            Me.Version = "18.2"
            CType(Me.xpObjectSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private xpObjectSource1 As DevExpress.Xpo.XPObjectSource
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private GroupCaption1 As DevExpress.XtraReports.UI.XRControlStyle
        Private GroupData1 As DevExpress.XtraReports.UI.XRControlStyle
        Private DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
        Private DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
        Private DetailCaption2 As DevExpress.XtraReports.UI.XRControlStyle
        Private DetailData2 As DevExpress.XtraReports.UI.XRControlStyle
        Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private label1 As DevExpress.XtraReports.UI.XRLabel
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private table1 As DevExpress.XtraReports.UI.XRTable
        Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private table2 As DevExpress.XtraReports.UI.XRTable
        Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private tableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
        Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private table3 As DevExpress.XtraReports.UI.XRTable
        Private tableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Private tableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Private Detail1 As DevExpress.XtraReports.UI.DetailBand
        Private table4 As DevExpress.XtraReports.UI.XRTable
        Private tableRow5 As DevExpress.XtraReports.UI.XRTableRow
        Private tableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Private tableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Private tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
