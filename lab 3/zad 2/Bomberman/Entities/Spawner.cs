using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class Spawner : MapObject
    {
        public int whichPlayer;
        public Spawner(int x, int y, int whichPlayer) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.Deadly = false;
            this.Destroyable = false;
            this.PassThrough = true;
            this.whichPlayer = whichPlayer;
        }

        public Player SpawnPlayer(int x, int y, int whichPlayer)
        {
            Player player = new Player(x, y, whichPlayer);
            return player;
        }
    }
}
