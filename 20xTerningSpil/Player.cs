using System;
using System.Collections.Generic;
using System.Text;

namespace _20xTerningSpil
{
    public class Player
    {
        public string name;
        public int sum;

        public void TakeTurn() 
        {
            Die d1 = new Die();
            Die d2 = new Die();
            d1.Roll();
            d2.Roll();
            sum = d1.FaceValue + d2.FaceValue;
        }
    }
}
