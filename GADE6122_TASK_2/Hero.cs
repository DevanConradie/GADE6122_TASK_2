using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_1
{
    class Hero : Character
    {
        public Hero(int aX, int aY, int aHP) : base(aX, aY, TILETYPE.hero)
        {
            HP = aHP;
            maxHP = aHP;
            Damage = 2;
        }
        public override MOVEMENT ReturnMove(MOVEMENT move)
        {
            var invalidTiles = new TILETYPE[] { TILETYPE.hero, TILETYPE.obstacle };

            switch (move)
            {
                case MOVEMENT.Up:
                    if (Array.IndexOf(invalidTiles, Vision[0].TileType) == -1)
                        return move;
                    else
                        return MOVEMENT.noMovement;
                case MOVEMENT.Down:
                    if (Array.IndexOf(invalidTiles, Vision[1].TileType) == -1)
                        return move;
                    else
                        return MOVEMENT.noMovement;
                case MOVEMENT.Right:
                    if (Array.IndexOf(invalidTiles, Vision[2].TileType) == -1)
                        return move;
                    else
                        return MOVEMENT.noMovement;
                case MOVEMENT.Left:
                    if (Array.IndexOf(invalidTiles, Vision[3].TileType) == -1)
                        return move;
                    else
                        return MOVEMENT.noMovement;
                default:
                    return MOVEMENT.noMovement;
            }
            
         }
        public override string ToString()
        {
            return ""; //////////
        }
    }
}
