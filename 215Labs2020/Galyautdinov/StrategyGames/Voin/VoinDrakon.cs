using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov.StrategyGames.Voin
{

    class VoinDrakon : Abstract, IAttack, IMovable, IHeight
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public double height { get; private set; }
        public VoinDrakon(string name, int xp, double speed, int damage, double height1)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            height = height1;
            Damage = damage;
        }
    }
}
