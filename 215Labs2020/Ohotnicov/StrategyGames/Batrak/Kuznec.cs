using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov.StrategyGames.Batrak
{
    class Kuznec : Abstract, IMovable, IResource
    {
        public double Speed { get; private set; }
        public int Resource { get; private set; }
        public int Hours { get; private set; }

        public Kuznec(string name, int xp, double speed, int resource1, int hours)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Resource = resource1;
            Hours = hours;
        }
        public void Move()
        {
            Console.WriteLine($"движется со скоростью: {Speed} км/ч");
        }
        public void Res()
        {
            Console.WriteLine($"Ресурсы: {Resource} золота");
        }
        public void Work()
        {
            Console.WriteLine($"работает {Hours} часов.");
        }
    }
}
