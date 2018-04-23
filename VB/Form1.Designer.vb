Imports Microsoft.VisualBasic
Imports System
Namespace LogarithmicScale
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("1970", New Object() { (CObj(850000))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("1975", New Object() { (CObj(970000))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("1980", New Object() { (CObj(1030000))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("1985", New Object() { (CObj(930000))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("1990", New Object() { (CObj(1080000))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("1995", New Object() { (CObj(1150000))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("2000", New Object() { (CObj(1450000))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("2005", New Object() { (CObj(1670000))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("1970", New Object() { (CObj(6))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("1975", New Object() { (CObj(9))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("1980", New Object() { (CObj(9))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("1985", New Object() { (CObj(14))})
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("1990", New Object() { (CObj(12))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("1995", New Object() { (CObj(17))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("2000", New Object() { (CObj(25))})
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("2005", New Object() { (CObj(34))})
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Dim pointSeriesLabel3 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim lineSeriesView3 As New DevExpress.XtraCharts.LineSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.btnLogarithm10 = New System.Windows.Forms.Button()
			Me.btnLogarithm100 = New System.Windows.Forms.Button()
			Me.btnDisableLogarithm = New System.Windows.Forms.Button()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.AppearanceName = "Light"
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
			Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
			Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chartControl1.Location = New System.Drawing.Point(8, 61)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.PaletteName = "Pastel Kit"
			pointSeriesLabel1.LineVisible = True
			series1.Label = pointSeriesLabel1
			series1.Name = "Big Country "
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
			series1.View = lineSeriesView1
			pointSeriesLabel2.LineVisible = True
			series2.Label = pointSeriesLabel2
			series2.Name = "Small Country"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16})
			series2.View = lineSeriesView2
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			pointSeriesLabel3.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = pointSeriesLabel3
			Me.chartControl1.SeriesTemplate.View = lineSeriesView3
			Me.chartControl1.Size = New System.Drawing.Size(496, 300)
			Me.chartControl1.TabIndex = 0
			chartTitle1.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle1.Text = "Gross Domestic Product"
			chartTitle1.Visible = False
			Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' btnLogarithm10
			' 
			Me.btnLogarithm10.Location = New System.Drawing.Point(0, 12)
			Me.btnLogarithm10.Name = "btnLogarithm10"
			Me.btnLogarithm10.Size = New System.Drawing.Size(124, 39)
			Me.btnLogarithm10.TabIndex = 1
			Me.btnLogarithm10.Text = "Logarithm 10"
			Me.btnLogarithm10.UseVisualStyleBackColor = True
'			Me.btnLogarithm10.Click += New System.EventHandler(Me.btnLogarithm10_Click);
			' 
			' btnLogarithm100
			' 
			Me.btnLogarithm100.Location = New System.Drawing.Point(192, 12)
			Me.btnLogarithm100.Name = "btnLogarithm100"
			Me.btnLogarithm100.Size = New System.Drawing.Size(117, 39)
			Me.btnLogarithm100.TabIndex = 1
			Me.btnLogarithm100.Text = "Logarithm 100"
			Me.btnLogarithm100.UseVisualStyleBackColor = True
'			Me.btnLogarithm100.Click += New System.EventHandler(Me.btnLogarithm100_Click);
			' 
			' btnDisableLogarithm
			' 
			Me.btnDisableLogarithm.Location = New System.Drawing.Point(391, 12)
			Me.btnDisableLogarithm.Name = "btnDisableLogarithm"
			Me.btnDisableLogarithm.Size = New System.Drawing.Size(117, 39)
			Me.btnDisableLogarithm.TabIndex = 1
			Me.btnDisableLogarithm.Text = "Disable Logarithm"
			Me.btnDisableLogarithm.UseVisualStyleBackColor = True
'			Me.btnDisableLogarithm.Click += New System.EventHandler(Me.btnDisableLogarithm_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(520, 367)
			Me.Controls.Add(Me.btnDisableLogarithm)
			Me.Controls.Add(Me.btnLogarithm100)
			Me.Controls.Add(Me.btnLogarithm10)
			Me.Controls.Add(Me.chartControl1)
			Me.MaximumSize = New System.Drawing.Size(536, 403)
			Me.MinimumSize = New System.Drawing.Size(536, 403)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private WithEvents btnLogarithm10 As System.Windows.Forms.Button
		Private WithEvents btnLogarithm100 As System.Windows.Forms.Button
		Private WithEvents btnDisableLogarithm As System.Windows.Forms.Button
	End Class
End Namespace

