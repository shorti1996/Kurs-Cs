using System;
using System.Drawing;
using System.Windows.Forms;

namespace WojciechLiebertLab3
{
    public partial class FormMain : Form
    {
        private Graphics graphics;
        private int shift = 0;//used to move the shape back and forth

        public FormMain()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            // Set KeyPreview object to true to allow the form to process
            // the key before the control with focus processes it.
            this.KeyPreview = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearGraphics();
        }

        private void buttonElipse_Click(object sender, EventArgs e)
        {
            graphics.DrawEllipse(Pens.Blue, CreateRectangle());
        }

        private void buttonElipseFill_Click(object sender, EventArgs e)
        {
            graphics.FillEllipse(Brushes.Blue, CreateRectangle());
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            graphics.DrawRectangle(Pens.OrangeRed, CreateRectangle());
        }

        private void buttonRectangleFill_Click(object sender, EventArgs e)
        {
            graphics.FillRectangle(Brushes.OrangeRed, CreateRectangle());
        }

        private void buttonShape_Click(object sender, EventArgs e)
        {
            shift = 0;
            CreateTrain(shift);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ClearGraphics();
            shift += Int32.Parse(textBoxShift.Text);
            CreateTrain(shift);
        }

        private void buttonTimerStart_Click(object sender, EventArgs e)
        {
            timerMove.Start();
        }

        private void buttonTimerStop_Click(object sender, EventArgs e)
        {
            timerMove.Stop();
            shift = 0;
        }

        /// <summary>
        /// Clears form from all graphics
        /// </summary>
        private void ClearGraphics()
        {
            graphics.Clear(Color.Azure);
        }

        /// <summary>
        /// Method creating a rectangle
        /// </summary>
        /// <returns></returns>
        private Rectangle CreateRectangle()
        {
            Rectangle rectangle = new Rectangle(Int32.Parse(textBoxStartX.Text), Int32.Parse(textBoxStartY.Text), Int32.Parse(textBoxWidth.Text), Int32.Parse(textBoxHeight.Text));
            return rectangle;
        }

        /// <summary>
        /// Creates a shape consisting of simple shapes
        /// </summary>
        /// <param name="shift"></param>
        private void CreateTrain(int shift)
        {
            int callibrateY = 150;
            graphics.FillEllipse(Brushes.Black, new Rectangle(350 + shift, 250 + callibrateY, 50, 50));//kolo1
            graphics.FillPie(Brushes.Bisque, new Rectangle(350 + shift, 250 + callibrateY, 50, 50), 90 + shift, 270);//efekt1
            graphics.FillEllipse(Brushes.Black, new Rectangle(450 + shift, 250 + callibrateY, 50, 50));//kolo2
            graphics.FillPie(Brushes.Bisque, new Rectangle(450 + shift, 250 + callibrateY, 50, 50), 90 + shift, 270);//efekt3
            graphics.FillRectangle(Brushes.Gray, new Rectangle(360 + shift, 200 + callibrateY, 10, 30));//komin
            graphics.FillRectangle(Brushes.Red, new Rectangle(340 + shift, 225 + callibrateY, 100, 50));//kadlubek1
            graphics.FillRectangle(Brushes.Red, new Rectangle(440 + shift, 180 + callibrateY, 60, 95));//kadlubek2
            graphics.FillRectangle(Brushes.SkyBlue, new Rectangle(445 + shift, 185 + callibrateY, 30, 30));//okienko
            graphics.FillRectangle(Brushes.SteelBlue, new Rectangle(420 + shift, 175 + callibrateY, 80, 5));//daszek
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'z')
            {
                ClearGraphics();
                shift -= Int32.Parse(textBoxShift.Text);
                CreateTrain(shift);
            }
            if (e.KeyChar == 'x')
            {
                ClearGraphics();
                shift += Int32.Parse(textBoxShift.Text);
                CreateTrain(shift);
            }
        }

        private void buttonRespawn_Click(object sender, EventArgs e)
        {
            ClearGraphics();
            shift = 0;
            CreateTrain(shift);
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            ClearGraphics();
            shift += Int32.Parse(textBoxShift.Text);
            CreateTrain(shift);
        }
    }
}