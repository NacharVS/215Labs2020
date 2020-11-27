using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    abstract class Unit
    {
        public static int _speed = 12;
        public static int _health = 10000;
        public static int _armor = 10000;
        public static int _damage = 3535;



        public static int Damage { get => _damage; set => _damage = value; }
        public static int Speed { get => _speed; set => _speed = value; }
        public static int Armor { get => _armor; set => _armor = value; }
        public static int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Dead");
                }
                else _health = value;
            }
        }






    }
}
