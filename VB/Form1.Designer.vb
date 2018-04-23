<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel4 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.NwindDataSet = New WindowsApplication1.nwindDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl1
        '
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "ProductName"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series1.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("CategoryID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        PointSeriesLabel1.LineVisible = True
        Series1.Label = PointSeriesLabel1
        Series1.Name = "Unit Price"
        Series1.ValueDataMembersSerializable = "UnitPrice"
        Series1.View = LineSeriesView1
        Series2.ArgumentDataMember = "ProductName"
        Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series2.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("CategoryID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        PointSeriesLabel2.LineVisible = True
        Series2.Label = PointSeriesLabel2
        Series2.Name = "Units in Stock"
        Series2.ValueDataMembersSerializable = "UnitsInStock"
        Series2.View = LineSeriesView2
        Series3.ArgumentDataMember = "ProductName"
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series3.DataFilters.ClearAndAddRange(New DevExpress.XtraCharts.DataFilter() {New DevExpress.XtraCharts.DataFilter("CategoryID", "System.Int32", DevExpress.XtraCharts.DataFilterCondition.Equal, 1)})
        PointSeriesLabel3.LineVisible = True
        Series3.Label = PointSeriesLabel3
        Series3.Name = "(Unit Price) * (Units in Stock)"
        Series3.SummaryFunction = "PRODUCT([UnitPrice],[UnitsInStock])"
        Series3.View = LineSeriesView3
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3}
        PointSeriesLabel4.LineVisible = True
        Me.ChartControl1.SeriesTemplate.Label = PointSeriesLabel4
        Me.ChartControl1.SeriesTemplate.View = LineSeriesView4
        Me.ChartControl1.Size = New System.Drawing.Size(750, 413)
        Me.ChartControl1.TabIndex = 0
        '
        'NwindDataSet
        '
        Me.NwindDataSet.DataSetName = "nwindDataSet"
        Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.NwindDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 413)
        Me.Controls.Add(Me.ChartControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ProductsTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents NwindDataSet As WindowsApplication1.nwindDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource

End Class
