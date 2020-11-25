using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova.StrategyGame.Warrior
{
    class WarriorBatrak : IAttack
    {

        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public int Attack { get; private set; }

        public WarriorBatrak(double speed, int damage, int attack)
        {
            Speed = speed;
            Damage = damage;
            Attack = attack;
        }
        public void Att()
        {
            Console.WriteLine($"rfgbvsrftgsr {Attack}");
        }


    }
}
