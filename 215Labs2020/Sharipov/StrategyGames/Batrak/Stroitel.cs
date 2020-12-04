using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sharipov.StrategyGames.Batrak
{
    class Stroitel : Abstract, IMovable, IResource
    {
        public double Speed { get; private set; }
        public int Resource { get; private set; }
        public int Hours { get; private set; }

        public Stroitel(int xp, double speed, int diamond, int hours)
        {
            Xp = xp;
            Resource = diamond;
            Hours = hours;
        }
        public void Move()
        {
            Console.WriteLine($"СТроитель движется со скоростью: {Speed} км/ч");
        }
        public void Res()
        {
            Console.WriteLine($"Ресурсы: {Resource} золота");
        }
        public void Work()
        {
            Console.WriteLine($"Он работает {Hours} часов.");
        }
    }
}