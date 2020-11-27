using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.Unit
{
    class Shakter:AbsarctClassVse, IAttack, ISkorost, IDobychaRud
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }

        public double DobychaRuda { get; private set; } 
        public Shakter(int xp, double speed, int damage,int ruda)
        {

            XP = xp;
            Speed = speed;
            Damage = damage;
            DobychaRuda = ruda;
        }

    }
}
