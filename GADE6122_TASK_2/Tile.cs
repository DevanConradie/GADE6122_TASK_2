using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_1
{
    public abstract class Tile
    {
        protected int x;
        protected TILETYPE tileType;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        protected int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public TILETYPE TileType
        {
            get { return tileType; }
            set { tileType = value; }
        }
        public Tile(int x, int y, TILETYPE tileType)
        {
            this.x = x;
            this.y = y;
            this.tileType = tileType;
        }
        public enum TILETYPE
        {
            hero,enemy,obstacle,emptyTile
        }

    }
}
