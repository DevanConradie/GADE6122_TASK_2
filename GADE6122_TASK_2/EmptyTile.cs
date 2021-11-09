using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_2
{
    class EmptyTile : Tile
    {
        public EmptyTile(int x, int y) : base(x, y, TILETYPE.emptyTile)
        {

        }
    }
}
