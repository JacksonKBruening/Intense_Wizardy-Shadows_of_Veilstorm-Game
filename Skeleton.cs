using System;
using System.Collections.Generic;
using System.Text;

namespace Intense_Wizardy
{
    class Skeleton : Enemy
    {
        public Skeleton(string enemyType, int level) : base(enemyType, level)
        {
            Health = 6 + (2 * level);
            Wisdom = 0;
            Strength = 6 + (2 * level);
            Armor = 6 + (2 * level);
        }

    }
}
