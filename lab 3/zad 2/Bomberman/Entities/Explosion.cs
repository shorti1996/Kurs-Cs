using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman.Entities
{
    /// <summary>
    /// Explosion is just a statement that the area right there will hurt.
    /// But ExplosionFamily class is who does the job!
    /// </summary>
    public class Explosion : MapObject
    {

        public Explosion(int x, int y, Bomb bomb) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.Deadly = true;
            this.Destroyable = false;
            this.PassThrough = true;
            this.Name = "explosion" + this.X + "_" + this.Y;
        }

    }
}
