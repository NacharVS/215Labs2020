using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    abstract class abilities_of_units
    {
        private static int _maxhealth = 250;
        private static int _minhealth = 0;
        private  int _health;
        private static int _maxarmour = 300;
        private static int _minarmour = 50;
        private int  _armour;
        private static int _maxspeed = 30;
        private static int _minspeed = 0;
        private int _speed;
        private static int _maxdamage = 250;
        private static int _mindamage = 10;
        private int _damage;
        
        private  int Health
        {
            get
            {
               
                return  _health; 

            }
            set
            {
                _health = value;
                if (value == 0)
                    Console.WriteLine("animation dead") ;
                if (value>= _maxhealth)
                {
                    _health = _maxhealth;
                }
                else _health = value;
            }

        }
        private  int Armour
        {
            get
            {
                return _armour;
            }
            set
            {
                _armour = value;
            }
        }
        
    }
}
