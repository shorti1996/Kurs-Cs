using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics; //for complex numbers

namespace Kalkulator
{
    public partial class Form2 : Form
    {
        double real1, real2, imaginary1, imaginary2, dResult;
        Complex complex1, complex2, cResult;
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonKeyCE_Click(object sender, EventArgs e)
        {
            real1 = real2 = imaginary1 = imaginary2 = 0;
            complex1 = complex2 = cResult = 0; 
            textBoxRe1.Text = null;
            textBoxRe2.Text = null;
            textBoxIm1.Text = null;
            textBoxIm2.Text = null;
            textBoxResult.Text = "Result";
        }

        private void buttonPhase_Click(object sender, EventArgs e)
        {
            readComplex1();
            complex1 = new Complex(real1, imaginary1);
            dResult = complex1.Phase;
            textBoxResult.Text = dResult.ToString();
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            double realPower, imaginaryPower;
            readComplex1();
            complex1 = new Complex(real1, imaginary1);
            FormGetPower formGetPower = new FormGetPower();
            if (!(textBoxRe1.Text.Equals("")))
            {
                try
                {
                    formGetPower.ShowDialog();
                    realPower = Double.Parse(formGetPower.realPower);

                    imaginaryPower = Double.Parse(formGetPower.imaginaryPower);
                    if (imaginaryPower == 0)
                    {
                        cResult = Complex.Pow(complex1, realPower);
                    }
                    else
                    {
                        Complex cPower = new Complex(realPower, imaginaryPower);
                        cResult = Complex.Pow(complex1, cPower);
                    }
                    textBoxResult.Text = cResult.ToString();
                    //textBoxResult.Text = complex1.ToString();
                }
                catch (System.FormatException) { }
            }
        }

        private void buttonKeyMagnitude_Click(object sender, EventArgs e)
        {
            readComplex1();
            complex1 = new Complex(real1, imaginary1);
            dResult = complex1.Magnitude;
            textBoxResult.Text = dResult.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void readComplex1()
        {
            try {
                real1 = Double.Parse(textBoxRe1.Text);
                imaginary1 = Double.Parse(textBoxIm1.Text);
            }
            catch (Exception) { }; //laziness
            
        }

        private void readComplex2()
        {
            try
            {
                real2 = Double.Parse(textBoxRe2.Text);
                imaginary2 = Double.Parse(textBoxIm2.Text);
            }
            catch (Exception) { }; //laziness

        }

        private void buttonKeySolve_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxOperations.SelectedIndex;
            switch (selectedIndex)
            {
                default: break;
                case 0:
                    {
                        readComplex1();
                        readComplex2();
                        complex1 = new Complex(real1, imaginary1);
                        complex2 = new Complex(real2, imaginary2);
                        cResult = Complex.Add(complex1, complex2);
                        textBoxResult.Text = cResult.ToString();
                        break;
                    }
                case 1:
                    {
                        readComplex1();
                        readComplex2();
                        complex1 = new Complex(real1, imaginary1);
                        complex2 = new Complex(real2, imaginary2);
                        cResult = Complex.Subtract(complex1, complex2);
                        textBoxResult.Text = cResult.ToString();
                        break;
                    }
                case 2:
                    {
                        readComplex1();
                        readComplex2();
                        complex1 = new Complex(real1, imaginary1);
                        complex2 = new Complex(real2, imaginary2);
                        cResult = Complex.Multiply(complex1, complex2);
                        textBoxResult.Text = cResult.ToString();
                        break;
                    }
                case 3:
                    {
                        readComplex1();
                        readComplex2();
                        complex1 = new Complex(real1, imaginary1);
                        complex2 = new Complex(real2, imaginary2);
                        cResult = Complex.Divide(complex1, complex2);
                        textBoxResult.Text = cResult.ToString();
                        break;
                    }
            }
        }
    }
}
