using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame
{
    abstract class UnitInfo
    {
        static string name;
        static int health;
        static int damage;
        static int range;
        static int speed;
       public static int credits;
        static int rank;
        static int viewrange;

        public static string Name { get => name; set => name = value; }
        public static int Damage { get => damage; set => damage = value; }
        public static int Range { get => range; set => range = value; }
        public static int Speed { get => speed; set => speed = value; }
        public static int Rank { get => rank; set => rank = value; }
        public static int ViewRange { get => viewrange; set => viewrange = value; }
        public static int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Unite is dead");
                }
                else health = value;
            }
        }
        public static int Credits
        {
            get
            {
                return credits;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Ran out of credits");
                }
                else credits = value;
            }
        }
    }
}
