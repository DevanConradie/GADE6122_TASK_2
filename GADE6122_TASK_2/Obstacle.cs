using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_2
{
    class Obstacle : Tile
    {
        public Obstacle(int x, int y) : base(x,y, TILETYPE.obstacle)
        {

        }
    }
}
