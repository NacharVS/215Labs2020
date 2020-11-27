using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Zdania
{
    class Ratusha : absract, Productivity
    {
        public double Radius { get; private set; }
        public int Gold { get; private set; }

        public Ratusha(string name, int xp, int gold)
        {
            Name = name;
            Xp = xp;
            Gold = gold;
        }
        public void product()
        {
            Console.WriteLine($"Запас: {Gold} золота.");
        }
    }
}