using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
     class Unit
    {
        static int _health;
        static int _damage;
        static int _range;

        public static int Damage { get => _damage; set => _damage = value; }
        public static int Range { get => _range; set => _range = value; }

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
                    Console.WriteLine("Unit is dead");
                }
                else _health = value;
            }
        }
    }
}
