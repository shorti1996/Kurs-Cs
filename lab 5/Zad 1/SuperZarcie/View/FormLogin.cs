using SuperZarcie.Controller;
using SuperZarcie.Model;
using SuperZarcie.View;
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
            //Get only logins and GUIDs
            userTableAdapter1.FillByLoginAndGUID(dataTable, login);
            dataGridView1.DataSource = dataTable;
            //If only one login matches designed login, hash and try hashed password
            if (dataTable.Rows.Count == 1)
            {
                string password = textBoxPassword.Text;
                string hashedPassword = Security.HashSHA1(password + dataTable.Rows[0]["userGUID"].ToString());
                Console.WriteLine("hashedPassword: " + hashedPassword);
                userTableAdapter1.FillByLoginAndPassword(dataTable, login, hashedPassword);
            }
            dataGridView1.DataSource = dataTable;
            //If only one match is found, login OK
            if (dataTable.Rows.Count == 1)
            {
                string role = dataTable.Rows[0]["Role"].ToString();
                MessageBox.Show("Login as " + role + " succeeded.\nWelcome, " + login + ".");
                if (role == "Cook")
                {
                    FormCook formCook = new FormCook();
                    formCook.Show();
                    this.Close();
                }
                if (role == "Driver")
                {
                    FormDriver formDriver = new FormDriver();
                    formDriver.Show();
                    this.Close();
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            /*FormOrder formOrder = new FormOrder();
            formOrder.Show();*/
            this.Close();
        }
    }
}
