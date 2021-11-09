using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_2
{
    class GameEngine
    {
        public Map newMap;
        public GameEngine()
        {
            newMap = new Map(15,15,10,10,10);
            
        }
        public void MovePlayer(Character.MOVEMENT direction)
        {
            var validMove = newMap.player.ReturnMove(direction);

            if (newMap.player.ReturnMove(direction) != Character.MOVEMENT.noMovement)
            {
                newMap.map[newMap.player.X, newMap.player.Y] = null;

                switch (direction)
                {
                    case Character.MOVEMENT.Up:
                        newMap.player.X -= 1;
                        break;
                    case Character.MOVEMENT.Down:
                        newMap.player.Y += 1;
                        break;
                    case Character.MOVEMENT.Right:
                        newMap.player.X += 1;
                        break;
                    case Character.MOVEMENT.Left:
                        newMap.player.X -= 1;
                        break;
                }

                newMap.map[newMap.player.X, newMap.player.Y] = newMap.player;
            }
        }
        public string BuildMap()
        {
            var mapString = new StringBuilder();

            for (int y = 0; y <= newMap.map.GetUpperBound(1); y++)
            {
                for (int x = 0; x <= newMap.map.GetUpperBound(0); x++)
                {
                    mapString.Append($"{GetSymbol(newMap.map[x, y]?.TileType)}\t");
                }
                mapString.AppendLine();
            }

            return mapString.ToString();
        }

        private char GetSymbol(Tile.TILETYPE? tileType)
        {
            switch (tileType)
            {
                case Tile.TILETYPE.hero:
                    return 'H';
                case Tile.TILETYPE.enemy:
                    return 'G';
                case Tile.TILETYPE.obstacle:
                    return 'X';
                default:
                    return '.';
            }
        }
    }
}
