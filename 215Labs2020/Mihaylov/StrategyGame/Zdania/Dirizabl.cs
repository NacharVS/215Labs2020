using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Zdania
{
    class Dirizabl : absract, Radius
    {
        public int Radius { get; private set; }

        public Dirizabl(string name, int xp, int radius1)
        {
            Name = name;
            Xp = xp;
            Radius = radius1;
        }
        public void Rad()
        {
            Console.WriteLine($"Радиус: {Radius} м.");
        }
    }
}
