using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_2
{
    class Mage : Enemy
    {
        public Mage(int aX, int aY) : base(aX, aY, 5, 5, TILETYPE.enemy)
        {

        }
        public override MOVEMENT ReturnMove(MOVEMENT move = MOVEMENT.noMovement)
        {  
            return MOVEMENT.noMovement;
        }
        public virtual bool CheckRange(Mage target)
        {
            return DistanceTo(target) == 1;

        }
        private int DistanceTo(Mage target)
        {
            return 1;
        }
        public override string ToString()
        {
            return ""; //////////
        }
    }
}
