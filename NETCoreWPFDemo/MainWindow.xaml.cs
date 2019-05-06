using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using Syncfusion.UI.Xaml.Grid;

namespace NETCoreWPFDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SfDataGrid dataGrid = new SfDataGrid() { Height = 550, Width = 600, ColumnSizer = GridLengthUnitType.Star };
            dataGrid.ItemsSource = GetDataTable();
            this.ROOT_Grid.Children.Add(dataGrid);
        }

        public DataTable GetDataTable()
        {
            DataTable employeeCollection = new DataTable();
            var dt = DateTime.Now;

            employeeCollection.Columns.Add("EmployeeID", typeof(int));
            employeeCollection.Columns[0].ColumnName = "Employee ID";
            employeeCollection.Columns.Add("EmployeeName", typeof(string));
            employeeCollection.Columns["EmployeeName"].ColumnName = "Employee Name";
            employeeCollection.Columns.Add("CustomerID", typeof(string));
            employeeCollection.Columns["CustomerID"].ColumnName = "Customer ID";
            employeeCollection.Columns.Add("Country", typeof(string));
            employeeCollection.Columns.Add("Date", typeof(DateTime));

            employeeCollection.Rows.Add(1001, "Belgim", "YHGTR", "US", new DateTime(dt.Year, dt.Month, dt.Day));
            employeeCollection.Rows.Add(1002, "Oliver", "LDON", "UK", new DateTime(dt.Year, dt.Month, dt.AddDays(-1).Day));
            employeeCollection.Rows.Add(1003, "Bernald", "ALFKI", "US", new DateTime(dt.Year, dt.Month, dt.AddDays(-5).Day));
            employeeCollection.Rows.Add(1004, "James", "YHGTR", "US", new DateTime(dt.Year, dt.Month, dt.AddDays(-1).Day));
            employeeCollection.Rows.Add(1005, "Beverton", "BERGS", "Europe", new DateTime(dt.Year, dt.Month, dt.Day));

            return employeeCollection;
        }
    }
}
