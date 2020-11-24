using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.Unit
{
    class Stroitel : AbsarctClassVse
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }

        public int Stroit { get; private set; }
        public Stroitel(int xp, double speed, int damage,int stroit)
        {

            XP = xp;
            Speed = speed;
            Damage = damage;
            Stroit = stroit;
        }
    }
}
