using SuperZarcie.Model;
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
    public partial class FormOrder : Form
    {
        SuperZarcieDataSet.MealDataTable mealDataTable = new SuperZarcieDataSet.MealDataTable();
        SuperZarcieDataSet.CustomerDataTable customerDataTable = new SuperZarcieDataSet.CustomerDataTable();
        SuperZarcieDataSet.OrderDataTable orderDataTable = new SuperZarcieDataSet.OrderDataTable();
        DataTable newOrderTable = new DataTable();
        Customer customer = new Customer();
        public FormOrder()
        {
            InitializeComponent();
            CreateNewOrderTable();
            RefreshDatagridViewOrder();
        }

        private void CreateNewOrderTable()
        {
            newOrderTable.Columns.Add("MealId");
            newOrderTable.Columns.Add("MealName");
            newOrderTable.Columns.Add("Price");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewMeals.DataSource = null;
            mealTableAdapter1.Fill(mealDataTable);
            dataGridViewMeals.DataSource = mealDataTable;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = newOrderTable.NewRow();
                newRow["MealId"] = dataGridViewMeals.SelectedRows[0].Cells["Id"].Value;
                newRow["MealName"] = dataGridViewMeals.SelectedRows[0].Cells["Name"].Value;
                newRow["Price"] = dataGridViewMeals.SelectedRows[0].Cells["Price"].Value;
                newOrderTable.Rows.Add(newRow);
                RefreshDatagridViewOrder();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd");
            }
        }

        private void RefreshDatagridViewOrder()
        {
            dataGridViewOrder.DataSource = null;
            dataGridViewOrder.DataSource = newOrderTable;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridViewOrder.SelectedCells)
            {
                if (cell.Selected)
                    dataGridViewOrder.Rows.RemoveAt(cell.RowIndex);
            }
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            Guid userGuid = System.Guid.NewGuid();
            customer.CustomerGUID = userGuid.ToString();
            Console.WriteLine(customer.CustomerGUID);
            customer.Name = textBoxName.Text;
            customer.Surname = textBoxSurname.Text;
            customer.Address = textBoxAddress.Text;
            //OrderId in Customer table is for use in the future
            customerTableAdapter1.Insert(customer.CustomerGUID, customer.Name, customer.Surname, customer.Address, 0);
            foreach (DataGridViewRow row in dataGridViewOrder.Rows)
            {
                try
                {
                    Order order = new Order();
                    order.MealId = Int32.Parse(row.Cells["MealId"].Value.ToString());
                    order.CustomerId = customer.CustomerGUID;
                    orderTableAdapter1.Insert(order.CustomerId, order.MealId);
                }
                catch (Exception ex)
                {
                    //some null- valued rows can occur, hence no need to handle this exception
                    Console.WriteLine(ex.Message);
                };
            }
            MessageBox.Show("Złożono zamówienie.");
            ClearOrder();
        }

        private void ClearOrder()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                newOrderTable = new DataTable();
                CreateNewOrderTable();
                RefreshDatagridViewOrder();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            //this.Close();
        }
    }
}
