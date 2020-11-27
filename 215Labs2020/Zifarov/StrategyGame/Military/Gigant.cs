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
            Console.WriteLine("Атаковал врага");
            if (Units.Respect != _maxrespect) Console.WriteLine($"атаковал на  {Golem.Damage + 10} ");
            else Console.WriteLine($"атаковал на  {Golem.Damage - 10} ");
            
        }
        
    }
}
