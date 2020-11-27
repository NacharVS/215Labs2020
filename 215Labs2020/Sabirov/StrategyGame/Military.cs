using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
    class Millitary : Unit, IMoveUnit, IAttack
    {
        public Millitary(string name,int dam, int health, int range, int _Speed, int armor)
        {
            Millitary.Name = name;
            Millitary.Armor = armor;
            Millitary.Damage = dam;
            Millitary.Health = health;
            Millitary.Range = range;
            Millitary.Speed = _Speed;
        }

        public void Move()
            {
                Console.WriteLine($"{Millitary.Name} is moving with this speed: {Millitary.Speed} ");
            }
        
        
        
            public void Attack()
            {
                Console.WriteLine($"{Millitary.Name} dealed {Millitary.Damage} damage");
            }
        



    }
}
