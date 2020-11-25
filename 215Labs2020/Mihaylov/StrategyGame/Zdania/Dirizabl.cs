using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Zdania
{
    class Dirizabl : absract, Radius
    {
        public double Radius { get; private set; }

        public Dirizabl(int xp, double radius1)
        {
            Xp= xp;
            Radius = radius1;
        }
        public void Rad()
        {
            Console.WriteLine($"Имеет радиус {Radius} м");
        }
    }
}
