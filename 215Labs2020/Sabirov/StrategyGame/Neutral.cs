using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
    class Neutral : Unit, IAttack,IMoveUnit,IResourceGatGold, IResourceGatWood
    {
        public Neutral(string name, int dam, int health, int range, int _Speed, int armor)
        {
            Neutral.Name = name;
            Neutral.Damage = dam;
            Neutral.Health = health;
            Neutral.Range = range;
            Neutral.Speed = _Speed;
            Neutral.Armor = armor;
        }
        public void Attack()
        {
            Console.WriteLine($"{Neutral.Name} dealed {Neutral.Damage}");
        }
        public void Move()
        {
            Console.WriteLine($"{Neutral.Name} is moving with this speed: {Neutral.Speed}");
        }
        public void ResW()
        {
            Console.WriteLine($"{Neutral.Name} is now gathering wood");
        }
        public void ResG()
        {
            Console.WriteLine($"{Neutral.Name} is now gathering gold");
        }

    }
}
