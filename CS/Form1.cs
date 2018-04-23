// Developer Express Code Central Example:
// How to create a custom summary function
// 
// XtraCharts provides you with the capability to calculate several built-in
// summary functions (MIN, MAX, SUM, AVERAGE, COUNT) against series values. In
// addition to the provided summary functions, you can create a custom one to
// calculate a summary value in any required way in your application. Moreover, the
// convenient approach of registering custom summary functions within a particular
// chart instance makes it possible for your end-users to use these functions in
// the Chart Wizard.
// The following example demonstrates how to create a custom
// summary function, which returns a product of two values (Price * Count). To
// accomplish this task, it is required to create a summary function delegate and
// register it via the ChartControl.RegisterSummaryFunction (or
// WebChartControl.RegisterSummaryFunction) method.
// The code below illustrates how
// this can be done.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E368

using System;
using System.Windows.Forms;
using DevExpress.Charts.Native;
using DevExpress.XtraCharts;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Create argument descriptions for the summary function.
            SummaryFunctionArgumentDescription argument1Description = 
                new SummaryFunctionArgumentDescription("Price", ScaleType.Numerical);
            SummaryFunctionArgumentDescription argument2Description = 
                new SummaryFunctionArgumentDescription("Count", ScaleType.Numerical);

            // Register the summary function in a chart.
            chartControl1.RegisterSummaryFunction("PRODUCT", "PRODUCT", 1, 
                new SummaryFunctionArgumentDescription[] { argument1Description, argument2Description },
                CalcProductValue);


            // Provide a datasource for the chart.
            chartControl1.DataSource = nwindDataSet.Products;
        }

        // Declare the Product summary function.
        private static SeriesPoint[] CalcProductValue(Series series, object argument, string[] functionArguments, DataSourceValues[] values, object[] colors)
        {

            // Create an array of the resulting series points.
            SeriesPoint[] points = new SeriesPoint[values.Length];

            // Calculate the resulting series points as Price * Count.
            for (int i = 0; i < values.Length; i++)
                points[i] = new SeriesPoint(argument,
                    Convert.ToDouble(values[i][functionArguments[0]]) *
                    Convert.ToDouble(values[i][functionArguments[1]]));

            // Return the result.
            return points;
        }

        private void Form1_Load(object sender, EventArgs e) {
            // This line of code loads data into the 'nwindDataSet.Products' table.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }
    }
}
