using System;
using System.Collections.Generic;
using System.Text;

namespace _20xTerningSpil
{
    public class Die
    {
        public int FaceValue;
        static Random r = new Random();

        public void Roll()
        {
            FaceValue = r.Next(1, 7);
        }
    }
}
