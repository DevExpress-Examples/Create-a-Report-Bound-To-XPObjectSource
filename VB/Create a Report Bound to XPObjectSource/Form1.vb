Imports Create_a_Report_Bound_to_XPObjectSource.nwind
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraReports.UI
Imports System
Imports System.ComponentModel
Imports System.Configuration
Imports System.Drawing
Imports System.Windows.Forms

Namespace Create_a_Report_Bound_to_XPObjectSource

    Public Partial Class Form1
        Inherits Form

        ' A data layer instance that is used in the ResolveSession/DismissSession event handlers
        Private DataLayerInstance As IDataLayer = Nothing

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Function CreateDataSource() As XPObjectSource
            Dim dataSource As XPObjectSource = New XPObjectSource() With {.ConnectionStringName = "nwind"}
            dataSource.SetEntityType(GetType(Products))
            Return dataSource
        End Function

        Private Function CreateReport() As XtraReport
            Dim report As XtraReport = New XtraReport()
            Dim DetailBand As DetailBand = New DetailBand()
            DetailBand.HeightF = 50
            Dim XRLabel As XRLabel = New XRLabel()
            XRLabel.WidthF = 300
            XRLabel.ExpressionBindings.Add(New ExpressionBinding("BeforePrint", "Text", "[ProductName]"))
            DetailBand.Controls.Add(XRLabel)
            report.Bands.Add(DetailBand)
            report.DataSource = CreateDataSource()
            Return report
        End Function

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Show the report's Print Preview
            Dim report As XtraReport1 = New XtraReport1()
            Dim printTool As ReportPrintTool = New ReportPrintTool(report)
            printTool.ShowRibbonPreviewDialog()
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Open the report in an End-User Report Designer
            Dim report As XtraReport1 = New XtraReport1()
            Dim designTool As ReportDesignTool = New ReportDesignTool(report)
            designTool.ShowRibbonDesignerDialog()
        End Sub

        Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport = CreateReport()
            Dim printTool As ReportPrintTool = New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        End Sub

        Private Sub simpleButton4_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport1 = New XtraReport1()
            Dim dataSource As XPObjectSource = CType(report.DataSource, XPObjectSource)
             ''' Cannot convert AssignmentExpressionSyntax, System.NullReferenceException: Object reference not set to an instance of an object.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             dataSource.ResolveSession += new System.EventHandler<ResolveSessionEventArgs>(this.OnResolveSession)
'''   ''' Cannot convert AssignmentExpressionSyntax, System.NullReferenceException: Object reference not set to an instance of an object.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             dataSource.DismissSession += new System.EventHandler<ResolveSessionEventArgs>(this.OnDismissSession)
'''  Dim printTool As ReportPrintTool = New ReportPrintTool(report)
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
