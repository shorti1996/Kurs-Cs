using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KredekKeyMoves
{
    public partial class KredekKeyMoves : Form
    {
        Graphics graphics;
        int x = 100;
        int y = 100;
        int width = 10;
        int height = 10;

        public KredekKeyMoves()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
        }
        private void buttonPaint_Click(object sender, EventArgs e)
        {
            FillCircle(x, y, width, height);
        }

        private void FillCircle(int x, int y, int width, int height)
        {
            Rectangle rectangle = new Rectangle(x, y, width, height);
            graphics.FillEllipse(Brushes.Blue, rectangle);
        }
        
       

        private void buttonPaint_KeyDown(object sender, KeyEventArgs e)
        {
            MovePlayer(e);
        }

        private void MovePlayer(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    x++; break;
                case Keys.Left:
                    x--; break;
                case Keys.Up:
                    y--; break;
                case Keys.Down:
                    y++; break;
                default:
                    break;
            }

            FillCircle(x, y, width, height);
        }

        private void textBoxMove_KeyDown(object sender, KeyEventArgs e)
        {
            MovePlayer(e);
        }
    }
}
