using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov.StrategyGames.Warrior
{
    class Mechnik : Abstract, IAttack, IMovable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public Mechnik(string name, int xp, double speed, int damage)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Damage = damage;
        }
        public void Attack()
        {
            Console.WriteLine($"атаковал с уроном: {Damage} ед.");
        }
        public void Move()
        {
            Console.WriteLine($"движется со скоростью: {Speed} км/ч");
        }
    }
}
