using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame.Military
{
    class GnomishSubmarine : Unit, IAttack, IMoveUnit
    {
        public GnomishSubmarine(int dam, int health, int range, int _Speed, int armor)
        {
            GnomishSubmarine.Damage = dam;
            GnomishSubmarine.Health = health;
            GnomishSubmarine.Range = range;
            GnomishSubmarine.Speed = _Speed;
            GnomishSubmarine.Armor = armor;
        }

        public void Move()
        {
            Console.WriteLine($"Unit is moving with this speed: {GnomishSubmarine.Speed} ");
        }
        public void Attack()
        {
            Console.WriteLine($"Unit dealed {GnomishSubmarine.Damage} damage");
        }
    }
}
