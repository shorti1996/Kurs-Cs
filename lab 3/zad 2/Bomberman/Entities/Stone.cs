using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    public class Stone : MapObject
    {
        public Stone(int x, int y) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.Deadly = false;
            this.Destroyable = false;
            this.PassThrough = false;
        }
    }
}
