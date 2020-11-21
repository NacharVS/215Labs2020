using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    abstract class abilities_of_units
    {
        private static int _maxhealth = 250;
        private static int _minhealth = 0;
        private static int _health;
        private static int _maxarmour = 300;
        private static int _minarmour = 50;
        private int _armour;
        private static int _maxspeed = 30;
        private static int _minspeed = 0;
        private int _speed;
        private static int _maxdamage = 250;
        private static int _mindamage = 10;
        private int _damage;
        private static int Health
        {
            get
            {
               
                return  _health; 

            }
            set
            {
                _health = value;
            }
        }
    }
}
