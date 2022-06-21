Imports Create_a_Report_Bound_to_XPObjectSource.nwind
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Create_a_Report_Bound_to_XPObjectSource
	Partial Public Class Form1
		Inherits Form

		' A data layer instance that is used in the ResolveSession/DismissSession event handlers
		Private DataLayerInstance As IDataLayer = Nothing

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function CreateDataSource() As XPObjectSource
			Dim dataSource As New XPObjectSource() With {.ConnectionStringName = "nwind"}
			dataSource.SetEntityType(GetType(Products))
			Return dataSource
		End Function

		Private Function CreateReport() As XtraReport
			Dim report As New XtraReport()
			Dim DetailBand As New DetailBand()
			DetailBand.HeightF = 50

			Dim XRLabel As New XRLabel()
			XRLabel.WidthF = 300
			XRLabel.ExpressionBindings.Add(New ExpressionBinding("BeforePrint", "Text", "[ProductName]"))

			DetailBand.Controls.Add(XRLabel)
			report.Bands.Add(DetailBand)
			report.DataSource = CreateDataSource()
			Return report
		End Function

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click, Me.Click
			' Show the report's Print Preview
			Dim report As New XtraReport1()
			Dim printTool As New ReportPrintTool(report)
			printTool.ShowRibbonPreviewDialog()
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			' Open the report in an End-User Report Designer
			Dim report As New XtraReport1()
			Dim designTool As New ReportDesignTool(report)
			designTool.ShowRibbonDesignerDialog()
		End Sub

		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			Dim report As XtraReport = CreateReport()
			Dim printTool As New ReportPrintTool(report)
			printTool.ShowPreviewDialog()
		End Sub

		Private Sub simpleButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton4.Click
			Dim report As New XtraReport1()

			Dim dataSource As XPObjectSource = CType(report.DataSource, XPObjectSource)
			AddHandler dataSource.ResolveSession, AddressOf OnResolveSession
			AddHandler dataSource.DismissSession, AddressOf OnDismissSession

			Dim printTool As New ReportPrintTool(report)
			printTool.ShowPreviewDialog()
		End Sub

		Private Sub OnResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs)
			'Сreate a single instance of IDataLayer if it is not created
			If DataLayerInstance Is Nothing Then
				Dim connectionString As String = ConfigurationManager.ConnectionStrings("nwind").ConnectionString
				DataLayerInstance = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists)
			End If

			'Create new session based on the instance of DataLayer
			e.Session = New UnitOfWork(DataLayerInstance)
		End Sub

		Private Sub OnDismissSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs)
			e.Session.Session.Dispose()
		End Sub
	End Class
End Namespace
