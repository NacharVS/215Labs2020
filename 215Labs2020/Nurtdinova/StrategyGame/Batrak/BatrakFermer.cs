using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova.StrategyGame.Batrak
{
    class BatrakFermer : Abstract, IMovable, IResource
    {
        public double Speed { get; private set; }
        public int Resource { get; private set; }

        public BatrakFermer(string name, int xp, double speed, int resource1)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Resource = resource1;
        }
    }
