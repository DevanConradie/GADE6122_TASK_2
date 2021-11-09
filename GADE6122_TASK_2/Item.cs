using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_2
{
    abstract class Item : Tile
    {
        public Item(int x, int y) : base(x, y, TILETYPE.item)
        {

        }
        public override abstract string ToString();
    }
}
