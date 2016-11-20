﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Enemy
{
    public interface IEnemy
    {
        int health { get; set; }
        int atkDmg { get; set; }
        void TakeDamage(int dam);
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
    }
}
