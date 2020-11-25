using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov.StrategyGames.Bashnya
{
    class BashnyaDirizhabl : Abstract,IRadius
    {
        public double Radius { get; private set; }

        public BashnyaDirizhabl(string name, int xp, double radius1)
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
