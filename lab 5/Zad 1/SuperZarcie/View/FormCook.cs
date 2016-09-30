using SuperZarcie.Model;
using SuperZarcie.SuperZarcieDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperZarcie.View
{
    public partial class FormCook : Form
    {
        DataTable dataTableOrders = new DataTable();
        DataTable dataTableMeals = new DataTable();
        SuperZarcieDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();
        string customerIdQuery;

        public FormCook()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataTableOrders = orderTableAdapter1.GetDataByOrdersToCustomer();
            dataTableOrders.Columns.RemoveAt(0);
            dataTableOrders.Columns.RemoveAt(0);
            dataGridViewOrders.DataSource = dataTableOrders;
        }

        private void dataGridViewOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerIdQuery = dataGridViewOrders.SelectedRows[0].Cells["CustomerGUID"].Value.ToString();
            RefreshDataGridViewMeals(customerIdQuery);
        }

        private void RefreshDataGridViewMeals(string customerId)
        {
            dataTableMeals = orderTableAdapter1.GetDataByMealsOfCustomerId(customerId);
            dataTableMeals.Columns.RemoveAt(0);
            dataGridViewMeals.DataSource = dataTableMeals;
        }

        private void buttonAddBox_Click(object sender, EventArgs e)
        {
            int boxId = Int32.Parse(textBoxBoxId.Text);
            orderTableAdapter1.UpdateBoxIdQuery(boxId, customerIdQuery);
            RefreshDataGridViewMeals(customerIdQuery);
            queriesTableAdapter.insBox(customerIdQuery, boxId);
        }
    }
}
