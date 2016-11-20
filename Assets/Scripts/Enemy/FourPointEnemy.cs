using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Enemy
{
     public class FourPointEnemy : MonoBehaviour, IEnemy
    {
        FourPointEnemyProfile profile = new FourPointEnemyProfile();
        public FourPointEnemy()
        {

        }
        void Update()
        {

        }
        public void MoveDown()
        {
            //check grid to see if moving down is legal
            throw new NotImplementedException();
        }

        public void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public void MoveRight()
        {
            throw new NotImplementedException();
        }

        public void MoveUp()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int dam)
        {
            profile.health -= dam;

            if(profile.health < 0)
            {
                Destroy(this.gameObject);
            }
        }
        
    }
}
