using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.StrategyGame
{
    abstract class Units
    {
        public static int _health;
        public static int _speed;
        public static int _damage;
        public static int _armor;
        public static int _respect;
        public static int _maxrespect = 100;
        public static int _minrespect = 10;
        public static int _gold;
        public static int _maxgold = 1000;
        public static int _mingold = 10;


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
                    Console.WriteLine("Персонаж мертв");
                }
                else _health = value;
            }


        }
        public static int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                 _speed = value;
            }


        }
        public static int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }


        }
        public static int Armor
        {
            get
            {
                return _armor;
            }
            set
            {
                _armor = value;
            }



        }
        public static int Respect
        {
            get
            {
                return _respect;
            }
            set
            {
                if (_respect == _maxrespect) Console.WriteLine("Люди любят вас мой милорд");
                if (_respect == _minrespect) Console.WriteLine("Люди вам не доверяют мой милорд");
                else _respect = value;
            }


        }
        public static int Gold
        {
            get
            {
                return _gold;
            }
            set
            {
                if (_gold == _maxgold)
                {
                    Console.WriteLine("Мы богаты мой милорд");
                    
                }

                if (_gold == _mingold) Console.WriteLine("Казана пуста мой милорд");
                else _gold = value;
            }


        }
    }
}
