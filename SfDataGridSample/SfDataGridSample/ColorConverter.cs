using Syncfusion.Maui.DataGrid;
using System.Globalization;

namespace SfDataGridSample
{
    public class ColorConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo info)
        {
            var dataGridRow = value as DataGridRow;
            var rowData = dataGridRow.DataRow.RowData;
            if (rowData == (dataGridRow.DataGrid.BindingContext as EmployeeViewModel).Employees[5])
                return Colors.LightBlue;
            else
                return Colors.White;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
