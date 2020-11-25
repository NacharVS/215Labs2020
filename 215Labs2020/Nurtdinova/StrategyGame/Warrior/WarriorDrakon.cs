using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova.StrategyGame.Warrior
{
    class WarriorDrakon
    {
        class WarriorDrakon : Abstract, IAttack, IMovable, IHeight
        {
            public int Damage { get; private set; }
            public double Speed { get; private set; }
            public double height { get; private set; }
            public WarriorDrakon(string name, int xp, double speed, int damage, double height1)
            {
                Name = name;
                Xp = xp;
                Speed = speed;
                height = height1;
                Damage = damage;
            }
        }
}
