using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Entities
{
    class Chest : MapObject
    {
        public enum bonusType { none, speedIncrease, explosionPowerIncrease, oneUp, changePlayers, maxBombIncrease }
        private bonusType containedBonus;

        public bonusType ContainedBonus
        {
            get
            {
                return containedBonus;
            }

            set
            {
                containedBonus = value;
            }
        }

        public Chest(int x, int y, bonusType containedBonus = bonusType.none) : base(x, y)
        {
            this.X = x;
            this.Y = y;
            this.Deadly = false;
            this.Destroyable = true;
            this.PassThrough = false;
            this.ContainedBonus = containedBonus;
        }

        public void DropBonus()
        {
            if (containedBonus == bonusType.none)
                return;
            Bonus bonus = new Bonus(this);
            Methods.DrawEntity(bonus, "bonus", "Images/" + Enum.GetName(typeof(bonusType), ContainedBonus) + ".png");
            Map.EveryEntityList.Add(bonus);
            bonus.Timer.Start();
        }

    }
}
