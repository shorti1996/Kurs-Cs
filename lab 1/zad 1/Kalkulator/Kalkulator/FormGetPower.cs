using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class FormGetPower : Form
    {
        // Closing this window with OK button if input is null is not possible
        public string realPower { get { return textBoxReal.Text; } }
        public string imaginaryPower { get { return textBoxImaginary.Text; } }
        public FormGetPower()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!(textBoxReal.Text.Equals(""))) this.Close();
        }

        private void textBoxReal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
