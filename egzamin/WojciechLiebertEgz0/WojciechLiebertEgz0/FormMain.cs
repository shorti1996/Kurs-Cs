using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechLiebertEgz0
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void B1_Policz_Click(object sender, EventArgs e)
        {
            string userText = textBoxB1.Text;
            int count = 0;
            for (int i = 0; i < userText.Length; i++)
            {
                if (userText[i] == '@')
                {
                    count++;
                }
            }
            MessageBox.Show("Ilość @ = " + count);
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(textBoxTriangleN.Text);
            bool nextLetterX = true;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nextLetterX == true)
                    {
                        richTextBoxTriangle.Text += 'X';
                        nextLetterX = !nextLetterX;
                        continue;
                    }
                    else
                    {
                        richTextBoxTriangle.Text += 'O';
                        nextLetterX = !nextLetterX;
                        continue;
                    }
                }
                richTextBoxTriangle.Text += "\n";
            }
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            timerB3.Start();
        }

        private void timerB3_Tick(object sender, EventArgs e)
        {
            progressBarB3.PerformStep();
        }
    }
}
