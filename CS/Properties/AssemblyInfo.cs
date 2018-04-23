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

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WindowsFormsApplication1")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("WindowsFormsApplication1")]
[assembly: AssemblyCopyright("Copyright ©  2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("6fc79060-0b88-4485-9a18-26712ea00819")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
