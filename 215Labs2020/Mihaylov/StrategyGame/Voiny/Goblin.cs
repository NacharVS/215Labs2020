using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Voiny
{
    class Goblin : absract, Attack, Movable
    { 
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public Goblin(int xp, double speed, int damage)
        {
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