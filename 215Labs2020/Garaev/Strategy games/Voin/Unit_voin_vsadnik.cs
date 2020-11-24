using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    class Unit_voin_vsadnik : unit_abstract, IAttack, ISpeed
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public Unit_voin_vsadnik(string name, int xp, double speed, int damage)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Damage = damage;
        }
    }
}
