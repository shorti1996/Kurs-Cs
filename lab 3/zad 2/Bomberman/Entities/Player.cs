using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman
{
    public class Player : MapObject
    {
        private int speed = 5;
        private double bombCountdown = 3.0;
        private int size;
        private int collisionSize;
        public enum direction { Up, Left, Down, Right };
        private direction lastMoved = direction.Left;
        private int currentBombs = 0; //number of currently planted bombs
        public enum plantingMode { Under, Towards };
        private plantingMode plantingStyle = plantingMode.Under; //for future use
        private int explosionPower = 1; //how far player's bombs are deadly
        private int maxBomb = 1;
        private int hp = 3;
        private int index; //used to identify the player

        #region Encapsulated fields

        //!!!!!!!!
        //mind wisely-used setters
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
                UpdateLabels();
            }
        }

        public double BombCountdown
        {
            get
            {
                return bombCountdown;
            }

            set
            {
                bombCountdown = value;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }

            set
            {
               size = value;
            }
        }

        public int CollisionSize
        {
            get
            {
                return collisionSize;
            }

            set
            {
                collisionSize = value;
            }
        }

        public direction LastMoved
        {
            get
            {
                return lastMoved;
            }

            set
            {
                lastMoved = value;
            }
        }

        public int CurrentBombs
        {
            get
            {
                return currentBombs;
            }

            set
            {
                currentBombs = value;
            }
        }

        public plantingMode PlantingWay
        {
            get
            {
                return plantingStyle;
            }

            set
            {
                plantingStyle = value;
            }
        }

        public int ExplosionPower
        {
            get
            {
                return explosionPower;
            }

            set
            {
                explosionPower = value;
                UpdateLabels();
            }
        }

        public int MaxBomb
        {
            get
            {
                return maxBomb;
            }

            set
            {
                maxBomb = value;
                UpdateLabels();
            }
        }

        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
                UpdateLabels();
                Methods.FlashPanel(CorrespondingPanel, 200, "Images/damaged.png");
            }
        }

        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }
        #endregion

        public Player(int x, int y, int index) : base (x, y)
        {
            this.Index = index;
            this.Name = "player" + index.ToString();
            this.Deadly = false;
            this.Destroyable = true;
            this.PassThrough = false;
        }

        public int CalculateCollisionSize(double collision)
        {
            int collisionSize = (int)(this.Size * collision);
            return collisionSize;
        }

        /// <summary>
        /// There are two ways of planting bomb. For future use.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="form"></param>
        public void PlantBomb(Map map, Form form)
        {
            if (MaxBomb == currentBombs)
            {
                return;
            }
            Point point = new Point();
            if (this.PlantingWay == plantingMode.Towards)
            {
                switch (LastMoved)
                {
                    case direction.Up:
                        point.X = (this.CorrespondingPanel.Location.X + CorrespondingPanel.Size.Width / 2) / map.ElementSize;
                        point.Y = (this.CorrespondingPanel.Location.Y - CorrespondingPanel.Size.Height) / map.ElementSize;
                        break;
                    case direction.Left:
                        point.X = (this.CorrespondingPanel.Location.X - CorrespondingPanel.Size.Width) / map.ElementSize;
                        point.Y = (this.CorrespondingPanel.Location.Y + CorrespondingPanel.Size.Height / 2) / map.ElementSize;
                        break;
                    case direction.Down:
                        point.X = (this.CorrespondingPanel.Location.X + CorrespondingPanel.Size.Width / 2) / map.ElementSize;
                        point.Y = (this.CorrespondingPanel.Location.Y + CorrespondingPanel.Size.Height * 2) / map.ElementSize;
                        break;
                    case direction.Right:
                        point.X = (this.CorrespondingPanel.Location.X + CorrespondingPanel.Size.Width * 2) / map.ElementSize;
                        point.Y = (this.CorrespondingPanel.Location.Y + CorrespondingPanel.Size.Height / 2) / map.ElementSize;
                        break;
                    default:
                        break;
                }
                foreach (MapObject mapObject in map.EveryEntityList)
                {
                    if (mapObject.X == point.X && mapObject.Y == point.Y && mapObject.PassThrough == false)
                    {
                        return;
                    }
                }
            }
            if (this.PlantingWay == plantingMode.Under)
            {
                point.X = (this.CorrespondingPanel.Location.X + this.CorrespondingPanel.Size.Width / 2) / map.ElementSize;
                point.Y = (this.CorrespondingPanel.Location.Y + this.CorrespondingPanel.Size.Height / 2) / map.ElementSize;
            }
            Bomb bomb = new Bomb(point.X, point.Y, this, BombCountdown, map, form);
            CurrentBombs++;
            bomb.Plant(map, form);
        }

        public void UpdateLabels()
        {
            try
            {
                var labels = Methods.GetAllControls(Form, typeof(Label));
                //labelPlayerXHpAmount
                //update shown stats
                foreach (Control control in labels)
                {
                    if (control.Name == "labelPlayer" + this.Index.ToString() + "HpAmount")
                    {
                        control.Text = this.Hp.ToString();
                    }
                    if (control.Name == "labelPlayer" + this.Index.ToString() + "ExplosionPowerAmount")
                    {
                        control.Text = this.ExplosionPower.ToString();
                    }
                    if (control.Name == "labelPlayer" + this.Index.ToString() + "MaxBombAmount")
                    {
                        control.Text = this.MaxBomb.ToString();
                    }
                    if (control.Name == "labelPlayer" + this.Index.ToString() + "SpeedAmount")
                    {
                        control.Text = this.Speed.ToString();
                    }
                }
            }
            catch (Exception) { Console.WriteLine("UpdateLabels has failed."); }
        }
    }
}
