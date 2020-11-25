using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.BuildUnit
{
    class StrelokTower:AbsarctClassVse
    {
        public int Damage { get; private set; }

        public StrelokTower(int xp, int damage)
        {

            XP = xp;

            Damage = damage;

        }
    }
}
