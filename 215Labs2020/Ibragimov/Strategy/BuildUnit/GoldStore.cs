using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.BuildUnit
{
    class GoldStore:AbsarctClassVse,IZdanie
    {
        public int Gold { get; private set; }

     
        public GoldStore(int xp, int gold)
        {

            XP = xp;

            Gold = gold;

        }

        public void Zdanie1()
        {
            Console.WriteLine($"имеет хп {XP} и хранит {Gold} ");


        }
    }
}
