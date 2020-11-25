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
        public void Attack()
        {
            Console.WriteLine($"атаковал с уроном: {Damage} ед.");
        }
        public void Move()
        {
            Console.WriteLine($"движется со скоростью: {Speed} км/ч");
        }
        public void Height()
        {
            Console.WriteLine($"нанес урон {Damage} с высоты: {height} м.");
        }
    }
}
