using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Bomberman.Entities
{
    /// <summary>
    /// This class allows grouping explosions. Groups are independant and can intersect.
    /// One group will cause damage only once.
    /// </summary>
    public class ExplosionFamily
    {
        private List<Explosion> family; //the most important field
        private List<MapObject> ignored = new List<MapObject>(); //these object were injured. Don't do this again.
        private Bomb bomb; //family belongs to...
        double destroyTime = 1.5; //explosions will only last for this amount of time
        //one timer for every field on the map being in range of the bomb-
        //that's the idea of this whole class.
        System.Windows.Forms.Timer timer;

        public Bomb Bomb
        {
            get
            {
                return bomb;
            }

            set
            {
                bomb = value;
            }
        }

        public List<MapObject> Ignored
        {
            get
            {
                return ignored;
            }

            set
            {
                ignored = value;
            }
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

        public ExplosionFamily(Bomb bomb)
        {
            this.bomb = bomb;
            this.Family = bomb.Family;
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(Timer_Tick);
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            destroyTime -= 0.1; //count down
            DisintegrateEntities(); //destroy poor things ;c
            if (destroyTime <= 0) //if the time has come, bye.
            {
                timer.Stop();
                Destroy(this.bomb.map, this.bomb.form);
            }
        }

        /// <summary>
        /// More accurate because can be triggered after drawing.
        /// </summary>
        public void StartCountdown()
        {
            //maybe in the future better thread management will be implemented
            //Thread thread = new Thread(Destroy);
            //thread.Start(Destroy);
            timer.Start();
        }

        /// <summary>
        /// Remove panel, remove from everyEntityList.
        /// Delete family.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="form"></param>
        public void Destroy(Map map, Form form)
        {
            if (Family != null)
            {
                foreach (Explosion explosion in Family)
                {
                    explosion.CorrespondingPanel.Dispose();
                    //form.Controls.Remove(explosion.CorrespondingPanel);
                    map.EveryEntityList.Remove(explosion as MapObject);
                }
                Family = null;
            }
        }

        /// <summary>
        /// Check whether something should be destroyed. If it's a player, substract hp instead.
        /// This should be triggered every timer tick.
        /// </summary>
        public void DisintegrateEntities()
        {
            foreach (Explosion explosion in Family)
            {
                foreach (MapObject mapObject in bomb.map.EveryEntityList)
                {
                    if (ignored.Contains(mapObject as MapObject) == false) //if not on ignored list
                    {
                        if (Methods.DetectCollision(explosion, mapObject) && mapObject.Destroyable) //if intersects on the board an is destroyable
                        {
                            if (mapObject is Player) //if player: hp--
                            {
                                Player player = new Player(mapObject.X, mapObject.Y, 99999);
                                player = mapObject as Player;
                                player.Hp--;
                                Console.WriteLine(player.Name + " hp= " + player.Hp);
                                //prevent hp substraction multiple times for crossing one explosion family
                                ignored.Add(mapObject);
                            }
                            else //if other MapObject: destroy
                            {
                                bomb.form.Controls.Remove(mapObject.CorrespondingPanel);
                                mapObject.CorrespondingPanel = null;
                                bomb.map.EveryEntityList.Remove(mapObject);
                                bomb.map.EntityList[mapObject.X, mapObject.Y] = null;
                                if (mapObject is Chest)
                                {
                                    Chest chest;
                                    chest = mapObject as Chest;
                                    chest.DropBonus();
                                }
                                return;
                            }
                        }
                    }
                }
            }
        }



    }
}
