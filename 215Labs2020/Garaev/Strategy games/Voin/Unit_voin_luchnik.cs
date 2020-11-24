using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    class Unit_voin_luchnick : unit_abstract, IAttack, ISpeed, IDalnost
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public int Dalnost { get; private set; }

        public Unit_voin_luchnick(string name, int xp, double speed, int damage, int dalnost)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Damage = damage;
            Dalnost = dalnost;
        }
    }
}
