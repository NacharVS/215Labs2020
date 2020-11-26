using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov.StrategyGames.Batrak
{
    class Rabochiy : Abstract, IMovable, IResource
    {
        public double Speed { get; private set; }
        public int Resource { get; private set; }
        public int Hours { get; private set; }

        public Rabochiy(string name, int xp, double speed, int diamond, int hours)
        {
            Name = name;
            Xp = xp;
            Resource = diamond;
            Hours = hours;
        }
        public void Move()
        {
            Console.WriteLine($"движется со скоростью: {Speed} км/ч");
        }
        public void Res()
        {
            Console.WriteLine($"Ресурсы: {Resource} алмазов");
        }
        public void Work()
        {
            Console.WriteLine($"работает {Hours} часов.");
        }
    }
}
