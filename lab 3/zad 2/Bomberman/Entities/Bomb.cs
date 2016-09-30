using Bomberman.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bomberman
{
    public class Bomb : MapObject
    {
        public Player belongsTo; //player which planted this bomb
        public Map map;
        public Form form;
        private Timer timer;
        private double destroyTime = 3; //when the bomb explodes in seconds
        private int explosionPower; //how far the bomb is deadly
        public List<MapObject> canPassThrough; //list of objects that can pass through this bomb
        public List<Explosion> explosions; //list of explosion entities triggered by Destroy()

        public enum canPlaceExplosion { Yes, No, Last };

        private List<Explosion> family;

        public double DestroyTime
        {
            get { return destroyTime; }
            set { destroyTime = value; }
        }

        public List<Explosion> Family
        {
            get
            {
                return family;
            }

            set
            {
                family = value;
            }
        }

        public Bomb(int x, int y, double destroyTime) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.DestroyTime = destroyTime;
            this.Deadly = false;
            this.Destroyable = false;
            this.PassThrough = false;
            this.Name = "bomb" + this.X + "_" + this.Y;
            this.explosionPower = 2;
            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        public Bomb(int x, int y, Player player, double destroyTime, Map map, Form form) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.DestroyTime = destroyTime;
            this.Deadly = false;
            this.Destroyable = false;
            this.PassThrough = false;
            this.Name = "bomb" + this.X + "_" + this.Y;
            this.map = map;
            this.form = form;
            this.belongsTo = player;
            this.explosionPower = player.ExplosionPower;
            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        public Bomb(int x, int y, double destroyTime, Map map, Form form) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.DestroyTime = destroyTime;
            this.Deadly = false;
            this.Destroyable = false;
            this.PassThrough = false;
            this.Name = "bomb" + this.X + "_" + this.Y;
            this.map = map;
            this.form = form;
            this.explosionPower = 0;
            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        /// <summary>
        /// Creates a panel of bomb, draws it on the board and adds to everyEntityList.
        /// Checks if somebody will be stuck in the bomb panel and handles the issue.
        /// The bomb should be planted with this method.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="form"></param>
        public void Plant(Map map, Form form)
        {
            Methods.DrawEntity
                (this, "bomb", map, form, form.Controls.Find("panelGame", false)[0] as Panel, "Images/bomb.png", 0.8);
            canPassThrough = new List<MapObject>();
            foreach (MapObject mapObject in map.EveryEntityList)
            {
                if (Methods.DetectCollision(mapObject, this))
                {
                    canPassThrough.Add(mapObject);
                }
            }
            this.map = map;
            this.form = form;
        }

        /// <summary>
        /// Counting down to explosion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Timer_Tick(object sender, EventArgs e)
        {
            destroyTime -= 0.1;
            if (destroyTime <= 0)
            {
                timer.Stop();
                Destroy();
            }
        }

        /// <summary>
        /// Find and destroy this bomb.
        /// Remove drawn panel.
        /// Remove from everyEntityList.
        /// Decreasae one's planted bombs number.
        /// Perform level destruction.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="form"></param>
        public void Destroy()
        {
            //code in comment below is no longer needed but left here to remember what's going on.
            /*if (this.map == null)
            {
                Family = new List<Explosion>() { new Explosion(X, Y, this) };
                DrawExplosions(Family);
            }
            else*/
            Destroy(this.map, this.form);
        }

        /// <summary>
        /// Find and destroy this bomb. Remove drawn panel. Remove from everyEntityList. Decreasae one's planted bombs number.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="form"></param>
        public void Destroy(Map map, Form form)
        {
            Family = new List<Explosion>();
            Family = CalculateExplosions();
            ExplosionFamily explosionFamily = new ExplosionFamily(this);
            DrawExplosions(Family);
            explosionFamily.StartCountdown();
            string search = "bomb" + this.X + "_" + this.Y;
            try
            {
                Panel panel = form.Controls.Find(search, false)[0] as Panel;
                form.Controls.Remove(panel);
                belongsTo.CurrentBombs--;
            }
            catch (Exception e)
            {
                Console.WriteLine("No panel corresponding to " + search);
            }
            map.EveryEntityList.Remove(this as MapObject);
        }

        /// <summary>
        /// Calculates where the deadly explosions should be and creates a list.
        /// </summary>
        public List<Explosion> CalculateExplosions()
        {
            explosions = new List<Explosion>();
            Explosion explosion = new Explosion(this.X, this.Y, this);
            explosions.Add(explosion);
            int i = 1;
            for (int j = 0; j < 4; j++)
                CalculateExplosion(ref explosion, j);
            return explosions;
        }

        /// <summary>
        /// Calculates how many explosions can be placed in specified direction and whether it is the last one in that direction.
        /// </summary>
        /// <param name="explosion">Reference because working on the same explosion</param>
        /// <param name="j">0: left, 1: up, 2: right, 3: left</param>
        private void CalculateExplosion(ref Explosion explosion, int j)
        {
            int i = 1;
            while (i <= explosionPower)
            {
                switch (j)
                {
                    case 0:
                        //left
                        explosion = new Explosion(this.X - i, this.Y, this);
                        break;

                    case 1:
                        //up
                        explosion = new Explosion(this.X, this.Y - i, this);
                        break;

                    case 2:
                        //right
                        explosion = new Explosion(this.X + i, this.Y, this);
                        break;

                    case 3:
                        //down
                        explosion = new Explosion(this.X, this.Y + i, this);
                        break;

                    default:
                        break;
                }
                canPlaceExplosion can = CanPlaceExplosion(explosion.X, explosion.Y);
                if (can == canPlaceExplosion.Yes)
                    explosions.Add(explosion);
                if (can == canPlaceExplosion.Last)
                {
                    explosions.Add(explosion);
                    break;
                }
                if (can == canPlaceExplosion.No)
                {
                    break;
                }
                i++;
            }
        }

        /// <summary>
        /// If block is undestroyable- no
        /// If block is destroyable- last
        /// If block is empty- yes
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public canPlaceExplosion CanPlaceExplosion(int x, int y)
        {
            canPlaceExplosion soCan = canPlaceExplosion.No; //so can finally place? (default: no)
            foreach (MapObject mapObject in map.EveryEntityList)
            {
                //if empty- no problem
                if (mapObject == null)
                {
                    return canPlaceExplosion.Yes;
                }
                //if has no corresponding panel- no problem
                if (map.EntityList[x, y] == null || map.EntityList[x, y].CorrespondingPanel == null)
                {
                    return canPlaceExplosion.Yes;
                }
                //if on the same position as Destroyable and non-PassThrough object
                //last one
                if (mapObject.X == x
                    && mapObject.Y == y
                    && mapObject.Destroyable
                    && !mapObject.PassThrough)
                {
                    soCan = canPlaceExplosion.Last;
                }
                //if on the same position as undestroyable object- no
                if (mapObject.X == x
                    && mapObject.Y == y
                    && !mapObject.Destroyable)
                {
                    soCan = canPlaceExplosion.No;
                }
            }
            return soCan;
        }

        /// <summary>
        /// Draw given explosion list on the form.
        /// </summary>
        /// <param name="explosions"></param>
        public void DrawExplosions(List<Explosion> explosions, string texture = "Images/explosion.gif")
        {
            foreach (Explosion explosion in explosions)
            {
                try
                {
                    Methods.DrawEntity(explosion, "explosion", map, form, form.Controls.Find("panelGame", false)[0] as Panel, texture);
                    CorrespondingPanel.BringToFront();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot draw explosion, terminating.");
                    return;
                }
            }
        }

    }
}