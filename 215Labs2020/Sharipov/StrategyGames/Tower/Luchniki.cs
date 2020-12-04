using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sharipov.StrategyGames.Towers
{
    class Luchniki : Abstract, IRadius
    {
        public double Radius { get; private set; }

        public Luchniki(int xp, double radius1)
        {
            Xp = xp;
            Radius = radius1;
        }
        public void Rad()
        {
            Console.WriteLine($"Башня лучниц наблюдает в {Radius} м. вокруг себя");
        }
    }
}