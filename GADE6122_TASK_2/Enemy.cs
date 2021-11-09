using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_1
{
    abstract class Enemy : Character
    {
        protected Random RNG = new Random();
        public Enemy(int aX, int aY, int aDamage, int aMaxHP, TILETYPE aTileType) : base(aX, aY, aTileType)
        {
            Damage = aDamage;
            maxHP = aMaxHP;
            HP = aMaxHP;
        }
        public abstract override string ToString();
    }
}
