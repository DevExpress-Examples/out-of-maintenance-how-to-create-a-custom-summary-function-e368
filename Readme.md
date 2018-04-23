# How to create a custom summary function


<p>XtraCharts provides you with the capability to calculate several built-in summary functions (MIN, MAX, SUM, AVERAGE, COUNT) against series values. In addition to the provided summary functions, you can create a custom one to calculate a summary value in any required way in your application. Moreover, the convenient approach of registering custom summary functions within a particular chart instance makes it possible for your end-users to use these functions in the <strong>Chart Wizard</strong>.</p>
<p>The following example demonstrates how to create a custom summary function, which returns a product of two values (Price * Count). To accomplish this task, it is required to create a summary function delegate and register it via the  <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraChartsChartControl_RegisterSummaryFunctiontopic793">ChartControl.RegisterSummaryFunction</a> (or <strong>WebChartControl.RegisterSummaryFunction</strong>) method.</p>
<p>The code below illustrates how this can be done.</p>

<br/>


