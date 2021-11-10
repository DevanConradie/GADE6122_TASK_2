using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_2
{
    abstract class Character : Tile
    {
        char symbol;
        protected int characterGold;
        public int CharacterGold
        {
            get { return characterGold; }
        }
        protected int HP;
        public int hp
        {
            get { return HP; }
        }
        protected int maxHP;
        public int MAXhp
        {
            get { return maxHP; }
        }
        protected int Damage;
        public int DAMAGE
        {
            get { return Damage; }
        }
        public Tile[] Vision = new Tile[4];
        public enum MOVEMENT
        {
            noMovement, Up, Down, Left, Right
        }

        //constructor
        public Character(int aX, int aY, TILETYPE aTileType) : base(aX, aY, aTileType)
        {

        }
        //methods
        public virtual void Attack(Character target)
        {
            target.HP = target.HP - Damage;
        }
        public bool IsDead()
        {
            if (HP <= 0)
            {
                 return true;
            }
            return false;
        }
        public virtual bool CheckRange(Character target)
        {
            return DistanceTo(target) <= 1;

        }
        private int DistanceTo(Character target)
        {
            return Math.Abs(x - target.x) + Math.Abs(y - target.y);
        }
        public void Move(MOVEMENT mOVEMENT)
        {
            switch (mOVEMENT)
            {
                case MOVEMENT.Up : y = y + 1; break;
                case MOVEMENT.Down : y = y - 1; break;
                case MOVEMENT.Right : x = x + 1; break;
                case MOVEMENT.Left : x = x - 1; break;
            }
        }
        public abstract MOVEMENT ReturnMove(MOVEMENT mOVEMENT = 0);
       
        public abstract override string ToString();

        public void Pickup(Item i)
        {
            if (Character[x,y] = Item[x,y])
            {
                if(Character[x,y] = Gold[x,y])
                {
                    characterGold++;
                    return;
                }

            }
        }
        public Item GetItemAtPosition(int x, int y)
        {
            if (Item[x, y] != TILETYPE.emptyTile)
            {
                return Item[x, y];
                Item[x, y] = null;
            }
            else return null;
        }

    }
}
