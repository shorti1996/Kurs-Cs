using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperZarcie
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SuperZarcieDataSet.UserDataTable dataTable = new SuperZarcieDataSet.UserDataTable();
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            userTableAdapter1.FillByLoginAndPassword(dataTable ,login, password);
            //userTableAdapter1.GetDataByLoginAndPassword(login, password);
            dataGridView1.DataSource = dataTable;
        }
    }
}
