using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Enemy
{
    public interface IEnemyProfile
    {
        int health { get; set; }
        int atkDmg { get; set; }
    }
}
