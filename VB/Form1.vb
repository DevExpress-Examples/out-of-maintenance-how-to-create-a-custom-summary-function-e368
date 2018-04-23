' Developer Express Code Central Example:
' How to create a custom summary function
' 
' XtraCharts provides you with the capability to calculate several built-in
' summary functions (MIN, MAX, SUM, AVERAGE, COUNT) against series values. In
' addition to the provided summary functions, you can create a custom one to
' calculate a summary value in any required way in your application. Moreover, the
' convenient approach of registering custom summary functions within a particular
' chart instance makes it possible for your end-users to use these functions in
' the Chart Wizard.
' The following example demonstrates how to create a custom
' summary function, which returns a product of two values (Price * Count). To
' accomplish this task, it is required to create a summary function delegate and
' register it via the ChartControl.RegisterSummaryFunction (or
' WebChartControl.RegisterSummaryFunction) method.
' The code below illustrates how
' this can be done.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E368

Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            ' Create argument descriptions for the summary function.
            Dim argument1Description As New SummaryFunctionArgumentDescription("Price", ScaleType.Numerical)
            Dim argument2Description As New SummaryFunctionArgumentDescription("Count", ScaleType.Numerical)

            ' Register the summary function in a chart.
            chartControl1.RegisterSummaryFunction("PRODUCT", "PRODUCT", 1, New SummaryFunctionArgumentDescription() { argument1Description, argument2Description }, AddressOf CalcProductValue)

            ' Provide a datasource for the chart.
            chartControl1.DataSource = nwindDataSet.Products
        End Sub

        ' Declare the Product summary function.
        Private Shared Function CalcProductValue(ByVal series As Series, ByVal argument As Object, ByVal functionArguments() As String, ByVal values() As DataSourceValues) As SeriesPoint()

            ' Create an array of the resulting series points.
            Dim points(values.Length - 1) As SeriesPoint

            ' Calculate the resulting series points as Price * Count.
            For i As Integer = 0 To values.Length - 1
                points(i) = New SeriesPoint(argument, Convert.ToDouble(values(i)(functionArguments(0))) * Convert.ToDouble(values(i)(functionArguments(1))))
            Next i

            ' Return the result.
            Return points
        End Function

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' This line of code loads data into the 'nwindDataSet.Products' table.
            Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)

        End Sub
    End Class
End Namespace
