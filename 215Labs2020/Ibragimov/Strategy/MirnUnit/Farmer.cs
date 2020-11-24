using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.Unit
{
    class Farmer: AbsarctClassVse
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }

        public double ProizvodctvoEda { get; private set; }
        public Farmer(int xp, double speed, int damage,int eda)
        {

            XP = xp;
            Speed = speed;
            Damage = damage;
            ProizvodctvoEda = eda;
        }
    }
}
