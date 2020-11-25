using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.BuildUnit
{
    class Pushka:AbsarctClassVse
    {
        public int Damage { get; private set; }   

        public  Pushka (int xp, int damage)
        {

            XP = xp;
           
            Damage = damage;
            
        }
    }
}
