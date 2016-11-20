using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Enemy
{
    public class FourPointEnemyProfile
    {
        public int health { get; set; }
        public int atkDmg { get; private set; }
        public FourPointEnemyProfile()
        {
            atkDmg = 30;
        }
    }
}
