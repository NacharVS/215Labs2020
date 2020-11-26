using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.StrategyGame.Military
{
    class Gigant:Units, IAttack, IMove
    {
        public Gigant(int damage, int health, int speed, int armor)
        {
            Gigant.Speed = speed;
            Gigant.Armor = armor;
            Gigant.Damage = damage;
            Gigant.Health = health;

        }
        public void Move()
        {
            Console.WriteLine($"Двигается со скоростью : {Gigant.Speed} ");
        }
        public void Attack()
        {
            Console.WriteLine($"Нанес урон врагу  : {Gigant.Damage} ");
        }
        
    }
}
