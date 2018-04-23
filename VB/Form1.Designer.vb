Namespace WindowsFormsApplication1
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
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
            Dim series3 As New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel3 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView3 As New DevExpress.XtraCharts.LineSeriesView()
            Dim pointSeriesLabel4 As New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView4 As New DevExpress.XtraCharts.LineSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.nwindDataSet = New WindowsFormsApplication1.nwindDataSet()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.productsTableAdapter = New WindowsFormsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = True
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = True
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.ArgumentDataMember = "ProductName"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() { New DevExpress.XtraCharts.DataFilter("CategoryID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.Label = pointSeriesLabel1
            series1.Name = "Unit Price"
            series1.ValueDataMembersSerializable = "UnitPrice"
            series1.View = lineSeriesView1
            series2.ArgumentDataMember = "ProductName"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            series2.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() { New DevExpress.XtraCharts.DataFilter("CategoryID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
            pointSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series2.Label = pointSeriesLabel2
            series2.Name = "Units in Stock"
            series2.ValueDataMembersSerializable = "UnitsInStock"
            series2.View = lineSeriesView2
            series3.ArgumentDataMember = "ProductName"
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            series3.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() { New DevExpress.XtraCharts.DataFilter("CategoryID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
            pointSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            series3.Label = pointSeriesLabel3
            series3.Name = "(Unit Price) * (Units in Stock)"
            series3.SummaryFunction = "PRODUCT([UnitPrice],[UnitsInStock])"
            series3.View = lineSeriesView3
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
            pointSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.Label = pointSeriesLabel4
            Me.chartControl1.SeriesTemplate.View = lineSeriesView4
            Me.chartControl1.Size = New System.Drawing.Size(881, 492)
            Me.chartControl1.TabIndex = 0
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' productsBindingSource
            ' 
            Me.productsBindingSource.DataMember = "Products"
            Me.productsBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' productsTableAdapter
            ' 
            Me.productsTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(881, 492)
            Me.Controls.Add(Me.chartControl1)
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
            DirectCast(series3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(pointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
        Private nwindDataSet As nwindDataSet
        Private productsBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace

