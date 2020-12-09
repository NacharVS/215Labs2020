using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
     abstract class Unit
    {
        static int _health;
        static int _damage;
        static int _range;
        static int _speed;
        static int _armor;
        public static int _gold;
        static int _wood;
        static string _name;


        public static int Damage { get => _damage; set => _damage = value; }
        public static int Range { get => _range; set => _range = value; }
        public static int Speed { get => _speed; set => _speed = value; }
        public static int Armor { get => _armor; set => _armor = value; }
        public static string Name { get => _name; set => _name = value; }
        public static int Gold
        {
            get
            {
                return _gold;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("You're out of gold, my Lord");
                }
                else _gold = value;
            }
        }
        public static int Wood
        {
            get
            {
                return _wood;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("You're out of wood, my Lord");
                }
                else _wood = value;
            }
        }
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
