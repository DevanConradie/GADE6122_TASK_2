using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_1
{
    class Goblin : Enemy
    {
        public Goblin (int aX, int aY) : base(aX, aY, 1, 10, TILETYPE.enemy)
        {
            
        }
        public override MOVEMENT ReturnMove(MOVEMENT move = MOVEMENT.noMovement)
        {
            var invalidTiles = new TILETYPE[] { TILETYPE.hero, TILETYPE.obstacle };

            while (1 == 1)
            {
                Random rng = new Random();
                var moveGoblinRandom = (MOVEMENT)rng.Next(1, 5);

                switch (moveGoblinRandom)
                {
                    case MOVEMENT.Up:
                        if (Array.IndexOf(invalidTiles, Vision[0].TileType) == -1)
                            return moveGoblinRandom;
                        break;
                    case MOVEMENT.Down:
                        if (Array.IndexOf(invalidTiles, Vision[1].TileType) == -1)
                            return moveGoblinRandom;
                        break;
                    case MOVEMENT.Right:
                        if (Array.IndexOf(invalidTiles, Vision[2].TileType) == -1)
                            return moveGoblinRandom;
                        break;
                    case MOVEMENT.Left:
                        if (Array.IndexOf(invalidTiles, Vision[3].TileType) == -1)
                            return moveGoblinRandom;
                        break;
                    default:
                        return MOVEMENT.noMovement;
                }
            }
        }
        public override string ToString()
        {
            return ""; //////////
        }
    }
}
