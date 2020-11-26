using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov.StrategyGames.Towers
{
    class Luchniki : Abstract, IRadius
    {
        public double Radius { get; private set; }

        public Luchniki
            (string name, int xp, double radius1)
        {
            Name = name;
            Xp = xp;
            Radius = radius1;
        }
        public void Rad()
        {
            Console.WriteLine($"наблюдает в радиусе: {Radius} м.");
        }
    }
}
