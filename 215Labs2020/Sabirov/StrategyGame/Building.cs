using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
    abstract class Building
    {
        private static int armour;
        private static int health;

        public static int Armour { get => armour; set => armour = value; }
        public static int Health { get => health; set => health = value; }
    }
}
