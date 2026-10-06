# Syncfusion WPF Data Grid in .NET Core 3.0

This sample demonstrates how to use the [Syncfusion WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) control in a .NET Core 3.0 WPF application.

The application creates an `SfDataGrid` and binds it to a `DataTable` that contains employee information such as employee ID, employee name, customer ID, country, and date.

## Project structure

- `NETCoreWPFDemo.sln` – Visual Studio solution file
- `NETCoreWPFDemo/` – WPF application project
- `NETCoreWPFDemo/MainWindow.xaml` – application layout
- `NETCoreWPFDemo/MainWindow.xaml.cs` – sample data generation and grid initialization
- `NETCoreWPFDemo/NETCoreWPFDemo.csproj` – project configuration and NuGet references

## Prerequisites

Before running the sample, make sure you have:

- Visual Studio 2019
- .NET Core 3.0 SDK
- NuGet package restore enabled in Visual Studio

## Getting started

1. Clone this repository to your local machine.
2. Open `NETCoreWPFDemo.sln` in Visual Studio 2019.
3. Restore the required NuGet packages.
4. Build the solution and press `F5` to run the application.

The sample uses the `Syncfusion.SfGrid.WPF` NuGet package and targets `netcoreapp3.0`.

## Output

The application displays a WPF Data Grid with employee records and automatically resizes columns to fit the available width.
