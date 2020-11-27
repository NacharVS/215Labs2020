using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.BuildUnit
{
    class StrelokTower:AbsarctClassVse,IZdanie
    {
        public int Damage { get; private set; }

        public StrelokTower(int xp, int damage)
        {

            XP = xp;

            Damage = damage;

        }
        public void Zdanie1()
        {
            Console.WriteLine($"имеет хп {XP} и атакует с силой {Damage} ");

        }
    }
}
