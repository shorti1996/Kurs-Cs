using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WojciechLiebertLab1v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String password = textBoxPassword.Text;
            if (name == password)
            {
                MessageBox.Show("Zalogowano");
                this.BackColor = Color.Honeydew;
                buttonLogin.BackColor = Color.Thistle;
                buttonLogin.Text = "OK";
                FormLogged formLogged = new FormLogged();
                formLogged.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wyszłoXD");
                this.BackColor = Color.Tomato;
            }
        }
    }
}
