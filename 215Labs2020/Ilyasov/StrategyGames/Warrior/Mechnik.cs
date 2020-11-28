using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasov.StrategyGames.Warrior
{
    class Mechnik : Abstract, IAttack, IMovable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public Mechnik(int xp, double speed, int damage)
        {
            Xp = xp;
            Speed = speed;
            Damage = damage;
        }
        public void Attack()
        {
            Console.WriteLine($"Варвар произвел атаку и нанес {Damage} урона");
        }
        public void Move()
        {
            Console.WriteLine($"Варвар бежит со скоростью: {Speed}");
        }
    }
}
