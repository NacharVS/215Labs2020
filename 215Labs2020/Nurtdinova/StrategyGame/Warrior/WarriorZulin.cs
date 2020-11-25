using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova.StrategyGame.Warrior
{
    class WarriorZulin : IAttack, ISpeeed
    {
        public int Damage { get; private set; }
        public int Speed { get; private set; }
        public int Attack { get; private set; }

        public WarriorZulin(int speed, int attack)
        {
            Attack = attack;
            Speed = speed;
        }
        public void Att()
        {
            Console.WriteLine($"Zulin -  {Attack}");
        }
        public void sp()
        {
            Console.WriteLine($"Speed - {Speed}");
        }
    }
}
