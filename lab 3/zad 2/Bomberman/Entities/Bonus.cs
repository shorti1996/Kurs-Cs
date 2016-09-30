using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman.Entities
{
    class Bonus : MapObject
    {
        private Chest.bonusType boon; //basically, type of this bonus
        private Timer timer = new Timer();
        private double destroyTime = 5; //when the bonus will be destroyed

        public Chest.bonusType Boon
        {
            get
            {
                return boon;
            }

            set
            {
                boon = value;
            }
        }

        public Timer Timer
        {
            get
            {
                return timer;
            }

            set
            {
                timer = value;
            }
        }

        public Bonus(Chest chest) : base(chest.X, chest.Y)
        {
            this.X = chest.X;
            this.Y = chest.Y;
            this.Deadly = false;
            this.Destroyable = false;
            this.PassThrough = true;
            this.Map = chest.Map;
            this.Form = chest.Form;
            this.Panel = chest.Panel;
            if (chest.ContainedBonus != Chest.bonusType.none)
            {
                this.Boon = chest.ContainedBonus;
            }
            Timer.Interval = 200;
            Timer.Tick += Timer_Tick;
            //timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            destroyTime -= 0.2;
            checkAnybodyEntered();
            if (destroyTime < 0)
            {
                DestroyBonus();
            }
        }

        public Bonus(int x, int y, Chest chest = null) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.Deadly = false;
            this.Destroyable = false;
            this.PassThrough = true;
            if (chest.ContainedBonus != Chest.bonusType.none)
            {
                this.Boon = chest.ContainedBonus;
            }
        }

        private void DestroyBonus()
        {
            timer.Stop();
            Form.Controls.Remove(this.CorrespondingPanel);
            Map.EveryEntityList.Remove(this);
        }

        public void checkAnybodyEntered()
        {
            foreach (MapObject mapObject in Map.EveryEntityList)
            {
                if (!(mapObject is Player)) //check only for mapObject of Player type
                    continue;
                if (Methods.DetectCollision(mapObject.CorrespondingPanel, CorrespondingPanel))
                {
                    Player newPlayer = mapObject as Player;
                    this.Acquire(newPlayer);
                    DestroyBonus();
                    return;
                }
            }
        }

        /// <summary>
        /// Make designated player acquire this bonus.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="playerOther"></param>
        public void Acquire(Player player, Player playerOther = null)
        {
            switch (boon)
            {
                case Chest.bonusType.none:
                    break;
                case Chest.bonusType.speedIncrease:
                    if (player.Speed < 8)
                    {
                        player.Speed += 1;
                    }
                    DestroyBonus();
                    break;
                case Chest.bonusType.explosionPowerIncrease:
                    if (player.ExplosionPower < 10)
                    {
                        player.ExplosionPower++;
                    }
                    DestroyBonus();
                    break;
                case Chest.bonusType.oneUp:
                    player.Hp++;
                    DestroyBonus();
                    break;
                case Chest.bonusType.changePlayers:
                    foreach (MapObject mapObject in Map.EveryEntityList)
                    {
                        if (mapObject is Player && mapObject != player)
                        {
                            playerOther = mapObject as Player;
                        }
                    }
                    //idea behind this- temp=a, a=b, b=temp
                    Panel newPanel = new Panel();
                    newPanel.Bounds = player.CorrespondingPanel.Bounds;
                    player.CorrespondingPanel.Bounds = playerOther.CorrespondingPanel.Bounds;
                    playerOther.CorrespondingPanel.Bounds = newPanel.Bounds;
                    newPanel.Dispose();
                    DestroyBonus();
                    #region effect
                    //silly effect upon acquiring this one
                    Point oldPoint = player.Form.Location; //remember where it initially was
                    Random random = new Random(this.GetHashCode()); //even more random random!
                    Timer timer = new Timer() { Interval = 50 };
                    int lifetime = 300;
                    int range = 100;
                    timer.Tick += (sender, e) => {
                        Point newPoint = new Point(oldPoint.X + random.Next(-range, range), oldPoint.Y /*+ random.Next(-50, 50)*/);
                        player.Form.Location = newPoint;
                        lifetime -= timer.Interval;
                        range = range / 2;
                        if (lifetime <= 0)
                        {
                            player.Form.Location = oldPoint;
                            timer.Dispose();
                        }
                    };
                    timer.Start();
                    #endregion
                    break;
                case Chest.bonusType.maxBombIncrease:
                    if (player.MaxBomb > 4)
                        return;
                    player.MaxBomb++;
                    DestroyBonus();
                    break;
                default:
                    break;
            }
        }

    }
}
