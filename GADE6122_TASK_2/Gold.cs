using System;
using System.Collections.Generic;
using System.Text;

namespace GADE6122_TASK_2
{
    class Gold : Item ////
    {
        private int goldAmount;
        public int GoldAmount
        {
            get { return goldAmount; }
            set { goldAmount = value; }
        }

        Random randomGold = new Random();

        public Gold(int x, int y) : base(x, y)
        {
            GoldAmount = randomGold.Next(1, 6);
        }
        public override string ToString()
        {
            return ""; //////////
        }
    }
}
