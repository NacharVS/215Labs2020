using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
    class Peasant : Unit, IAttack, IMoveUnit, IResourceGatGold, IResourceGatWood
    {
        public Peasant(int dam, int health, int range, int _Speed, int armor)
        {
            Peasant.Damage = dam;
            Peasant.Health = health;
            Peasant.Range = range;
            Peasant.Speed = _Speed;
            Peasant.Armor = armor;
        }
        public void ResG()
        {
            Console.WriteLine($"Unit is now gathering gold now\nResource: {Unit.Gold} gold");
        }
        public void ResW()
        {
            Console.WriteLine($"Unit is now gathering gold now\nResource: {Unit.Wood} wood");
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
