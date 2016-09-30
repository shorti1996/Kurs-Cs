using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WojciechLiebertEgzA.Model;

namespace WojciechLiebertEgzA
{
    public partial class Form1 : Form
    {
        Model.DataClasses1DataContext dataContext = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            IQueryable<Customer> query = Model.Customer.GetAllCustomers(dataContext);
            dataGridViewCustomers.DataSource = null;
            dataGridViewCustomers.DataSource = query;
        }

        private void buttonA2Suppliers_Click(object sender, EventArgs e)
        {
            IQueryable<Supplier> query = Model.Supplier.GetAllSuppliers(dataContext);
            dataGridViewSuppliers.DataSource = null;
            dataGridViewSuppliers.DataSource = query;
        }

        private void buttonA2Products_Click(object sender, EventArgs e)
        {
            IQueryable<Product> query = Model.Product.GetAllProducts(dataContext);
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = query;
        }
    }
}
