using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
    class Footman : Unit, IAttack, IMoveUnit
    {
        public Footman(int dam, int health, int range, int _Speed, int armor)
        {
            Peasant.Damage = dam;
            Peasant.Health = health;
            Peasant.Range = range;
            Peasant.Speed = _Speed;
            Peasant.Armor = armor;
        }

        public void Move()
        {
            Console.WriteLine($"Unit is moving with this speed: {Peasant.Speed} ");
        }
        public void Attack()
        {
            Console.WriteLine($"Unit dealed {Peasant.Damage} damage");
        }
    }
}
