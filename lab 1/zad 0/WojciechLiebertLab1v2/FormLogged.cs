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
    public partial class FormLogged : Form
    {
        public FormLogged()
        {
            InitializeComponent();
        }

        private void FormLogged_Load(object sender, EventArgs e)
        {

        }

        private void Space_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int counter = Int32.Parse(textBoxCounter.Text);
            TextBoxSpace.Text += "*";
            for (int i = 0; i < counter; i++)
            {
                for(int j = 0; j < i*2; j++)
                {
                    TextBoxSpace.Text += i;
                }
                TextBoxSpace.Text += Environment.NewLine;
            }
            TextBoxSpace.Text += "|||";
        }
    }
}
