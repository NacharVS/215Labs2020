using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.StrategyGame.Military
{
    class Bomber:Units, IAttack, IMove
    {
        public Bomber(int damage, int health, int speed, int armor)
        {
            Bomber.Speed = speed;
            Bomber.Armor = armor;
            Bomber.Damage = damage;
            Bomber.Health = health;

        }
        public void Move()
        {
            Console.WriteLine($"Двигается со скоростью : {Archer.Speed} ");
        }
        public void Attack()
        {
            Console.WriteLine("Был атакован в спину");
            System.Threading.Thread.Sleep(10000);
            if (Units.Respect != _maxrespect) Console.WriteLine($"атаковал на  {Golem.Damage + 10} ");
            else Console.WriteLine($"атаковал на  {Golem.Damage - 10} ");
            Console.WriteLine($"Повредил броню на {Archer.Armor}");
            Console.WriteLine($"Был ранен на {Archer.Health}");
        }
    }
}
