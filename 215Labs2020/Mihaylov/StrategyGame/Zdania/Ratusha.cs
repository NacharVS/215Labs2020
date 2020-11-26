using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Zdania
{
    class Ratusha : absract, Resource
    {
        public double Radius { get; private set; }
        public int Resource { get; private set; }

        public Ratusha(string name, int xp, int resource)
        {
            Name = name;
            Xp = xp;
            Resource = resource;
        }
        public void Res()
        {
            Console.WriteLine($"В казне {Resource} золота");
        }
    }
}