using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
    abstract class Unit
    {
        private static int damage;
        private const int minDamage = 0;
        private static int maxDamage = 1000;
        private static int _health;
        private const int maxHealth = 9999;
        private const int minHealth = 0;
        
        public static int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }
             public static int Maxdamage
        {
            get
            {
                return maxDamage;
            }
            set
            {
                maxDamage = value;
            }
        }

        public static int MinHealth { get; set; }
        public static int Health { get => _health; set => _health = value; }

        public interface IDamage
        {
         
            void DealDamage(Building g);
            

        }
    }
}
