using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame.Military
{
    class Ballista : Unit, IMoveUnit, IAttack
    {




        public Ballista(int dam, int health, int range, int _Speed, int armor)
        {
            Ballista.Armor = armor;
            Ballista.Damage = dam;
            Ballista.Health = health;
            Ballista.Range = range;
            Ballista.Speed = _Speed;
        }

        public void Move()
        {
            Console.WriteLine($"Unit is moving with this speed: {Ballista.Speed} ");
        }
        public void Attack()
        {
            Console.WriteLine($"Unit dealed {Ballista.Damage} damage");
        }







    }
}
