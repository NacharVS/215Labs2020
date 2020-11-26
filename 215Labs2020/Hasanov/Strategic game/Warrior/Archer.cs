using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    class Archer : Units, IAttack, IMove
    {
        public Archer(int damage, int health, int speed, int armor)
        {
            Archer.Speed = speed;
            Archer.Armor = armor;
            Archer.Damage = damage;
            Archer.Health = health;

        }
        public void Move()
        {
            Console.WriteLine($"Двигается со скоростью : {Archer.Speed} ");
        }
        public void Attack()
        {
            Console.WriteLine("Был атакован в спину");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"Повредил броню на {Archer.Armor}");
            Console.WriteLine($"Был ранен на {Archer.Health}");
        }
    }


}
