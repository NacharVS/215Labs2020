using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sharipov.StrategyGames.Batrak
{
    class Povar : Abstract, IMovable, IResource
    {
        public double Speed { get; private set; }
        public int Resource { get; private set; }
        public int Hours { get; private set; }

        public Povar(int xp, double speed, int resource1, int hours)
        {
            Xp = xp;
            Speed = speed;
            Resource = resource1;
            Hours = hours;
        }
        public void Move()
        {
            Console.WriteLine($"Повар движется со скоростью: {Speed} км/ч");
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