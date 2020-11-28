using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov.StrategyGames.Warrior
{
    class Drakon : Abstract, IAttack, IMovable, IHeight
    {
        public int Damage { get; private set; }
        public double Speed { get; private set; }
        public double height { get; private set; }
        public Drakon(int xp, double speed, int damage, double height1)
        {
            Xp = xp;
            Speed = speed;
            height = height1;
            Damage = damage;
        }
        public void Attack()
        {
            Console.WriteLine($"Дракон нанес {Damage} ед. урона");
        }
        public void Move()
        {
            Console.WriteLine($"Дракон летит со скоростью: {Speed}");
        }
        public void Height()
        {
            Console.WriteLine($"Дракон упал с высоты {height} и нанес {Damage} урона");
        }
    }
}
