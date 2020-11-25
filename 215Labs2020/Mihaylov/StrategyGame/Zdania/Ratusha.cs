using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Zdania
{
    class Ratusha : absract
    {
        public double Radius { get; private set; }
        public int Resource { get; private set; }

        public Ratusha(int xp, double radius, int resource)
        {
            Xp = xp;
            Radius = radius;
            Resource = resource;
        }
        public void Res()
        {
            Console.WriteLine($"В казне {Resource} золота");
        }
        public void Rad()
        {
            Console.WriteLine($"Имеет радиус {Radius} м");
        }
    }
}