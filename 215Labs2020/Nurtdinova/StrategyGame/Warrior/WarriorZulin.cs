using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova.StrategyGame.Warrior
{
    class WarriorZulin
    {
        class WarriorZulin : Abstract, IMovable, IAttack
        {
            public int Damage { get; private set; }
            public double Speed { get; private set; }
            public WarriorZulin(string name, int xp, double speed, int damage)
            {
                Name = name;
                Xp = xp;
                Speed = speed;
                Damage = damage;
            }
        }
}
