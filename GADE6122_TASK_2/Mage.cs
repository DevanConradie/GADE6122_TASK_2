using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_2
{
    class Mage : Enemy
    {
        bool inRange;
        public Mage(int aX, int aY) : base(aX, aY, 5, 5, TILETYPE.enemy)
        {

        }
        public override MOVEMENT ReturnMove(MOVEMENT move = MOVEMENT.noMovement)
        {  
            return MOVEMENT.noMovement;
        }
        public virtual bool CheckRange(Mage[] target)
        {
            if (Mage[x - 1][y - 1] != TILETYPE.emptyTile)//topleft
            {
                return inRange = true;
            }
            if (Mage[x - 1][y] != TILETYPE.emptyTile)//top
            {
                return inRange = true;
            }
            if (Mage[x - 1][y + 1] != TILETYPE.emptyTile)//topright
            {
                return inRange = true;
            }
            if (Mage[x][y + 1] != TILETYPE.emptyTile)//right
            {
                return inRange = true;
            }
            if (Mage[x][y - 1] != TILETYPE.emptyTile)//left
            {
                return inRange = true;
            }
            if (Mage[x + 1][y - 1] != TILETYPE.emptyTile)//bottomleft
            {
                return inRange = true;
            }
            if (Mage[x + 1][y] != TILETYPE.emptyTile)//bottom
            {
                return inRange = true;
            }
            if (Mage[x + 1][y + 1] != TILETYPE.emptyTile)//bottomright
            {
                return inRange = true;
            }
            else
            {
                return inRange = false;
            }

        }

        public override string ToString()
        {
            return ""; //////////
        }
    }
}
