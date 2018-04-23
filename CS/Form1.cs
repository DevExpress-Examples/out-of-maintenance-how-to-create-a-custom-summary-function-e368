using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace WindowsApplication1 {
    public partial class Form1 : Form {

        // Declare the Product summary function.
        private static SeriesPoint[] CalcProductValue(Series series, object argument, 
        string[] functionArguments, DataSourceValues[] values) {

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

        private void Form1_Load(object sender, EventArgs e) {
            // This line of code loads data into the 'nwindDataSet.Products' table.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }
    }
}