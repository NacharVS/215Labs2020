using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov.StrategyGames.mirnyy
{
    class MirnyyMekhanik : Abstract, IMovable,IResource, IWork
    {
        public double Speed { get; private set; }
        public int Resource { get; private set; }
        public int Hours { get; private set; }

        public MirnyyMekhanik(string name, int xp, double speed, int resource1, int hours)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Resource = resource1;
            Hours = hours;
        }
    }
}
