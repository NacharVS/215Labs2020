using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    class Golem : Units, IAttack, IMove
    {
        public Golem(int damage, int health, int speed, int armor)
        {
            Golem.Speed = speed;
            Golem.Armor = armor;
            Golem.Damage = damage;
            Golem.Health = health;

        }
        public void Move()
        {
            Console.WriteLine($"Двигается со скоростью : {Golem.Speed} ");
        }
        public void Attack()
        {
            Console.WriteLine("ГОлем обнаружил противника");
            Console.WriteLine($"атаковал на  {Golem.Damage} ");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"Повредил броню на {Golem.Armor}");
            Console.WriteLine($"Упал с высоты  и нанаес себе урон {Golem.Health - 40}");
        }
    }
}
