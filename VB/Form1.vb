Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...


Public Class Form1

    ' Declare the Product summary function.
    Private Shared Function CalcProductValue(ByVal series As Series, ByVal argument As Object, _
    ByVal functionArguments() As String, ByVal values() As DataSourceValues) As SeriesPoint()

        ' Create an array of the resulting series points.
        Dim points(values.Length - 1) As SeriesPoint

        ' Calculate the resulting series points as Price * Count.
        For i As Integer = 0 To values.Length - 1
            points(i) = New SeriesPoint(argument, _
            Convert.ToDouble(values(i)(functionArguments(0))) * _
            Convert.ToDouble(values(i)(functionArguments(1))))
        Next i

        ' Return the result.
        Return points
    End Function

    Public Sub New()
        InitializeComponent()

        ' Create argument descriptions for the summary function.
        Dim argument1Description As New SummaryFunctionArgumentDescription("Price", ScaleType.Numerical)
        Dim argument2Description As New SummaryFunctionArgumentDescription("Count", ScaleType.Numerical)

        ' Register the summary function in a chart.
        ChartControl1.RegisterSummaryFunction("PRODUCT", "PRODUCT", 1, _
            New SummaryFunctionArgumentDescription() {argument1Description, argument2Description}, _
            AddressOf CalcProductValue)

        ' Provide a datasource for the chart.
        ChartControl1.DataSource = ProductsBindingSource
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load
        ' This line of code loads data into the 'NwindDataSet.Products' table.
        Me.ProductsTableAdapter.Fill(Me.NwindDataSet.Products)
    End Sub

End Class
