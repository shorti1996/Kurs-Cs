using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMoveKredek
{
    public partial class FormMouseMove : Form
    {
        Graphics graphics;
        int x = 100;
        int y = 100;
        int width = 10;
        int height = 10;

        public FormMouseMove()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            FillCircle(x, y, width, height);
        }

        /// <summary>
        /// Funkcja rysująca element poruszający się po ekranie
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void FillCircle(int x, int y, int width, int height)
        {
            Rectangle rectangle = new Rectangle(x, y, width, height);
            graphics.FillEllipse(Brushes.Blue, rectangle);
        }

        private void FormMouseMove_MouseClick(object sender, MouseEventArgs e)
        {
            graphics.Clear(Color.LightSlateGray);
            x = e.X;
            y = e.Y;
            FillCircle(x, y, width, height);
        }

        private void FormMouseMove_MouseMove(object sender, MouseEventArgs e)
        {
            //Linijkę niżej należy odkomentować żeby obiekt się poruszał
            //graphics.Clear(Color.LightSlateGray);
            x = e.X;
            y = e.Y;
            FillCircle(x, y, width, height);
        }
        
    }
}
