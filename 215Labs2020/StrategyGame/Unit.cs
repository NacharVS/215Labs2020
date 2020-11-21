using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    abstract class Unit
    {
        private static int _health;
        private static  int minhealth = 34;
        private static int maxhealth = 57;
        private static int _damage;
        private static int mindamage = 111;
        private static int maxdamage = 12234;


        public static int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
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
        public static int MinDamage
        {
            get
            {
                return mindamage;
            }
            set
            {
                mindamage= value;
            }
            
        }
    }
}
