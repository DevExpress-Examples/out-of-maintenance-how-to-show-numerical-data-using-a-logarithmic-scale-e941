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
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("1970", New Object() { (DirectCast(850000, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("1975", New Object() { (DirectCast(970000, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("1980", New Object() { (DirectCast(1030000, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("1985", New Object() { (DirectCast(930000, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("1990", New Object() { (DirectCast(1080000, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("1995", New Object() { (DirectCast(1150000, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("2000", New Object() { (DirectCast(1450000, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("2005", New Object() { (DirectCast(1670000, Object))})
            Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("1970", New Object() { (DirectCast(6, Object))})
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("1975", New Object() { (DirectCast(9, Object))})
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("1980", New Object() { (DirectCast(9, Object))})
            Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("1985", New Object() { (DirectCast(14, Object))})
            Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("1990", New Object() { (DirectCast(12, Object))})
            Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("1995", New Object() { (DirectCast(17, Object))})
            Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("2000", New Object() { (DirectCast(25, Object))})
            Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("2005", New Object() { (DirectCast(34, Object))})
            Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
            Dim pointSeriesLabel3 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView3 As New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.btnLogarithm10 = New System.Windows.Forms.Button()
            Me.btnLogarithm100 = New System.Windows.Forms.Button()
            Me.btnDisableLogarithm = New System.Windows.Forms.Button()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.AppearanceName = "Light"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl1.Location = New System.Drawing.Point(8, 61)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PaletteName = "Pastel Kit"
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.Label = pointSeriesLabel1
            series1.Name = "Big Country "
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            series1.View = lineSeriesView1
            pointSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series2.Label = pointSeriesLabel2
            series2.Name = "Small Country"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16})
            series2.View = lineSeriesView2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
            pointSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.Label = pointSeriesLabel3
            Me.chartControl1.SeriesTemplate.View = lineSeriesView3
            Me.chartControl1.Size = New System.Drawing.Size(496, 300)
            Me.chartControl1.TabIndex = 0
            chartTitle1.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle1.Text = "Gross Domestic Product"
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.False
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
            ' 
            ' btnLogarithm100
            ' 
            Me.btnLogarithm100.Location = New System.Drawing.Point(192, 12)
            Me.btnLogarithm100.Name = "btnLogarithm100"
            Me.btnLogarithm100.Size = New System.Drawing.Size(117, 39)
            Me.btnLogarithm100.TabIndex = 1
            Me.btnLogarithm100.Text = "Logarithm 100"
            Me.btnLogarithm100.UseVisualStyleBackColor = True
            ' 
            ' btnDisableLogarithm
            ' 
            Me.btnDisableLogarithm.Location = New System.Drawing.Point(391, 12)
            Me.btnDisableLogarithm.Name = "btnDisableLogarithm"
            Me.btnDisableLogarithm.Size = New System.Drawing.Size(117, 39)
            Me.btnDisableLogarithm.TabIndex = 1
            Me.btnDisableLogarithm.Text = "Disable Logarithm"
            Me.btnDisableLogarithm.UseVisualStyleBackColor = True
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
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private WithEvents btnLogarithm10 As System.Windows.Forms.Button
        Private WithEvents btnLogarithm100 As System.Windows.Forms.Button
        Private WithEvents btnDisableLogarithm As System.Windows.Forms.Button
    End Class
End Namespace

