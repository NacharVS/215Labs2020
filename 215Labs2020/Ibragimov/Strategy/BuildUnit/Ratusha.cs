using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.BuildUnit
{
    class Ratusha: AbsarctClassVse,IZdanie
    {
        public Ratusha (int xp)
        {
            XP = xp;
        }
        public void Zdanie1()
        {
            Console.WriteLine($"имеет хп {XP} ");


        }
    }
}
