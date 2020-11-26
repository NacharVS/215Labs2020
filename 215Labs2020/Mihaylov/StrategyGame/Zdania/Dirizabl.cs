using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Zdania
{
    class Dirizabl : absract, Radius
    {
        public double Radius { get; private set; }

        public Dirizabl(string name, int xp, double radius1)
        {
            Name = name;
            Xp = xp;
            Radius = radius1;
        }
        public void Rad()
        {
            Console.WriteLine($"Имеет радиус разведки {Radius} м");
        }
    }
}
