using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame.Military
{
    class Knight : Unit, IMoveUnit, IAttack
    {




        public Knight(int dam, int health, int range, int _Speed, int armor)
        {
            Knight.Armor = armor;
            Knight.Damage = dam;
            Knight.Health = health;
            Knight.Range = range;
            Knight.Speed = _Speed;
        }

        public void Move()
        {
            Console.WriteLine($"Unit is moving with this speed: {Knight.Speed} ");
        }
        public void Attack()
        {
            Console.WriteLine($"Unit dealed {Knight.Damage} damage");
        }







    }
}
