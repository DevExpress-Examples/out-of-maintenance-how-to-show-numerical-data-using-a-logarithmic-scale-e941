Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace LogarithmicScale
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnLogarithm10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogarithm10.Click
			Dim axis As AxisY = (CType(chartControl1.Diagram, XYDiagram)).AxisY
			axis.Logarithmic = True
			axis.LogarithmicBase = 10
			axis.Range.AlwaysShowZeroLevel = False
		End Sub

		Private Sub btnLogarithm100_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogarithm100.Click
			Dim axis As AxisY = (CType(chartControl1.Diagram, XYDiagram)).AxisY
			axis.Logarithmic = True
			axis.LogarithmicBase = 100
			axis.Range.AlwaysShowZeroLevel = False
		End Sub

		Private Sub btnDisableLogarithm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDisableLogarithm.Click
			Dim axis As AxisY = (CType(chartControl1.Diagram, XYDiagram)).AxisY
			axis.Logarithmic = False
			axis.Range.AlwaysShowZeroLevel = True
		End Sub
	End Class
End Namespace