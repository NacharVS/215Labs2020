using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    abstract class Unit
    {
        public static int _speed = 12;
        public static int _health;
        public static int minhealth = 1;
        public static int maxhealth = 10000;
        public static int _damage;
        public static int mindamage = 1;
        public static int maxdamage = 10000;


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
                mindamage = value;
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
        

         
        
    }
}
