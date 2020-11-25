using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.AtackUnit
{
    class Bomber:AbsarctClassVse
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }


        public Bomber(int xp, double speed, int damage, int )
        {

            XP = xp;
            Speed = speed;
            Damage = damage;
        }
    }
}
