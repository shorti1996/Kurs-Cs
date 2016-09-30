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
    public partial class FormDriver : Form
    {
        DataTable dataTableOrders = new DataTable();
        string customerGuid;
        public FormDriver()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshOrders();
        }

        private void RefreshOrders()
        {
            dataTableOrders = orderTableAdapter1.GetDataByBoxIdGroup();
            dataTableOrders.Columns.RemoveAt(1);
            dataGridViewDisplay.DataSource = dataTableOrders;
        }

        private void dataGridViewDisplay_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                customerGuid = dataGridViewDisplay.SelectedRows[0].Cells["CustomerId"].Value.ToString();
            }
            catch (Exception) { };
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            customerTableAdapter1.DeleteQuery(customerGuid);
        }
    }
}
