using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WojciechLiebertLab4
{
    public partial class FormMain : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter sqlAdapter;
        public FormMain()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-C63SA6V\SQLEXPRESS;Initial Catalog=ShopWojciechLiebert;Integrated Security=True");

        }

        private void buttonShow_Click_1(object sender, EventArgs e)
        {
            dataGridViewDatabase.DataSource = null;
            dataGridViewDatabase.DataSource = Customer.GetAllCustomer(sqlAdapter, sqlConnection);
        }
    }
}
