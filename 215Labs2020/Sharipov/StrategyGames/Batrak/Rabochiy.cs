using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sharipov.StrategyGames.Batrak
{
    class Rabochiy : Abstract, IMovable, IResource
    {
        public double Speed { get; private set; }
        public int Resource { get; private set; }
        public int Hours { get; private set; }

        public Rabochiy(int xp, double speed, int diamond, int hours)
        {
            Speed = speed;
            Xp = xp;
            Resource = diamond;
            Hours = hours;
        }
        public void Move()
        {
            Console.WriteLine($"Рабочий движется со скоростью: {Speed} км/ч");
        }
        public void Res()
        {
            Console.WriteLine($"Ресурсы: {Resource} алмазов");
        }
        public void Work()
        {
            Console.WriteLine($"Юнит работает {Hours} часов.");
        }
    }
}