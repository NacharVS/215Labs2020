using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.BuildUnit
{
    class Pushka:AbsarctClassVse,IZdanie
    {
        public int Damage { get; private set; }   

        public  Pushka (int xp, int damage)
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
