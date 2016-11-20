using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public interface IEnemy
{
    int health { get; set; }
    int atkDmg { get; set; }
    void TakeDamage(int dam);
}
