using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kalkulator
{
    public partial class MainWindow : Form
    {
        /*
        TODO:
        >DONE Correct names for "Form1" and "Form2" (I don't want to break all the code now)
        >DONE Ensure that input is of correct type and not null (too much work since it's only a homework)
        >DONE ^ In complex calc form too ^
        >DONE Avoid multiple commas input somehow
        >Give a non-ugly look
        >Fix uncomfortable complex calc
        */
        string displayedNumber = null; //string user sees as input and output
        double temporaryNumber1 = 0; //temporary number used in the actual calculations
        double temporaryNumber2 = 0; //temporary number used in the actual calculations
        //operations: 0- nothing, 1- addition, 2- substraction, 3- multiplying, 4- dividing
        int operation = 0;

        public MainWindow()
        {
            InitializeComponent();
            textBoxDisplay.Text += displayedNumber;
        }

        /*Number input works as follows:
        >displayedNumber of type string is concatenated with char of proper key
        >refresh textBoxDisplay.Text because of new value*/
        private void buttonKey0_Click(object sender, EventArgs e)
        {
            displayedNumber += '0';
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonKey1_Click(object sender, EventArgs e)
        {
            displayedNumber += '1';
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonKey2_Click(object sender, EventArgs e)
        {
            displayedNumber += '2';
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonKey3_Click(object sender, EventArgs e)
        {
            displayedNumber += '3';
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonKey4_Click(object sender, EventArgs e)
        {
            displayedNumber += '4';
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonKey5_Click(object sender, EventArgs e)
        {
            displayedNumber += '5';
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonKey6_Click(object sender, EventArgs e)
        {
            displayedNumber += '6';
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonKey7_Click(object sender, EventArgs e)
        {
            displayedNumber += '7';
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonKey8_Click(object sender, EventArgs e)
        {
            displayedNumber += '8';
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonKey9_Click(object sender, EventArgs e)
        {
            displayedNumber += '9';
            textBoxDisplay.Text = displayedNumber;
        }

        //method used to avoid repeating parsing string from "display" in code
        private void GetNum1ClearTextBoxDisplay()
        {
            if (displayedNumber != null)
            {
                temporaryNumber1 = Double.Parse(displayedNumber);
                displayedNumber = null;
                textBoxDisplay.Text = displayedNumber;
            }
        }

        /*User doesn't have to click "=" after every operation,
        so operations can be chained*/
        private void buttonKeyAdd_Click(object sender, EventArgs e)
        {
            if (operation != 0) buttonKeyEquals.PerformClick();
            operation = 1;
            GetNum1ClearTextBoxDisplay();
        }

        private void buttonKeySubstract_Click(object sender, EventArgs e)
        {
            if (operation != 0) buttonKeyEquals.PerformClick();
            operation = 2;
            GetNum1ClearTextBoxDisplay();
        }

        private void buttonKeyMultiply_Click(object sender, EventArgs e)
        {
            if (operation != 0) buttonKeyEquals.PerformClick();
            operation = 3;
            GetNum1ClearTextBoxDisplay();
        }

        private void buttonKeyDivide_Click(object sender, EventArgs e)
        {
            if (operation != 0) buttonKeyEquals.PerformClick();
            operation = 4;
            GetNum1ClearTextBoxDisplay();
        }

        private void buttonKeyEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 0: break;
                case 1: {
                        if (displayedNumber != null)
                        {
                            temporaryNumber2 = temporaryNumber1 + Double.Parse(displayedNumber);
                            displayedNumber = temporaryNumber2.ToString();
                            textBoxDisplay.Text = null;
                            textBoxDisplay.Text += temporaryNumber2;
                            operation = 0;
                            break;
                        }
                        break;
                    }
                case 2:
                    {
                        if (displayedNumber != null)
                        {
                            temporaryNumber2 = temporaryNumber1 - Double.Parse(displayedNumber);
                            displayedNumber = temporaryNumber2.ToString();
                            textBoxDisplay.Text = null;
                            textBoxDisplay.Text += temporaryNumber2;
                            operation = 0;
                            break;
                        }
                        break;
                    }
                case 3:
                    {
                        if (displayedNumber != null)
                        {
                            temporaryNumber2 = temporaryNumber1 * Double.Parse(displayedNumber);
                            displayedNumber = temporaryNumber2.ToString();
                            textBoxDisplay.Text = null;
                            textBoxDisplay.Text += temporaryNumber2;
                            operation = 0;
                            break;
                        }
                        break;
                    }
                case 4:
                    {
                        if (displayedNumber != null)
                        {
                            temporaryNumber2 = temporaryNumber1 / Double.Parse(displayedNumber);
                            displayedNumber = temporaryNumber2.ToString();
                            textBoxDisplay.Text = null;
                            textBoxDisplay.Text += temporaryNumber2;
                            operation = 0;
                            break;
                        }
                        break;
                    }
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            //This should remove all commas from string and place a new one on it's very end
            try
            {
                displayedNumber = textBoxDisplay.Text.Replace(",", "");
            }
            catch (ArgumentOutOfRangeException)
            {
                Debug.WriteLine("Out of range Exception");
            }
            textBoxDisplay.Text = displayedNumber;
            displayedNumber += ',';
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonKeyInverseSign_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != null)
            {
                try
                {
                    displayedNumber = ((Double.Parse(textBoxDisplay.Text)) * -1).ToString();
                    textBoxDisplay.Text = displayedNumber;
                }
                catch (System.FormatException) { };
            }
        }

        //Clear window and variables
        private void buttonCE_Click(object sender, EventArgs e)
        {
            temporaryNumber1 = 0;
            temporaryNumber2 = 0;
            operation = 0;
            displayedNumber = null;
            textBoxDisplay.Text = displayedNumber;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != String.Empty) displayedNumber = displayedNumber.Remove(displayedNumber.Length - 1);
            textBoxDisplay.Text = displayedNumber;
        }

        //Go to a form with calculations on complex numbers
        private void buttonKeyImaginary_Click(object sender, EventArgs e)
        {
            buttonCE.PerformClick();
            Form2 form2 = new Form2();
            form2.Show();
            this.AddOwnedForm(form2);
            this.Hide();
        }

    }
}
