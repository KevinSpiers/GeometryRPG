using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class FourPointEnemyProfile : IEnemyProfile
{
    public int health { get; set; }
    public int atkDmg { get; set; }
    public FourPointEnemyProfile()
    {
        atkDmg = 30;
    }
}

