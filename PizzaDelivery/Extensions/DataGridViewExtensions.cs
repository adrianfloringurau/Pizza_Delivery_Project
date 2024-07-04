using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery.Extensions
{
    public static class DataGridViewExtensions
    {
        public static DataGridView AddTextBoxColumn(this DataGridView dataGridView, string propertyName, string columnName)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = propertyName,
                Name = propertyName,
                HeaderText = columnName
            };

            dataGridView.Columns.Add(column);

            return dataGridView;
        }
        public static DataGridView AddButtonColumn(this DataGridView dataGridView, string columnName, string labelText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = columnName,
                HeaderText = labelText,
                Text = labelText,
                UseColumnTextForButtonValue = true
            };

            dataGridView.Columns.Add(buttonColumn);

            return dataGridView;
        }
        public static DataGridView UpdateDataSource<T>(this DataGridView dataGridView, List<T> dataSource)
        {
            dataGridView.DataSource = null;
            var observableDataSource = new BindingList<T>(dataSource);
            dataGridView.DataSource = observableDataSource;

            return dataGridView;
        }
    }
}
