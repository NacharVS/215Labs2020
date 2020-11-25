using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Voiny
{
    class Stenoboi : absract, Attack, Movable
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public Stenoboi(int xp, double speed, int damage)
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
