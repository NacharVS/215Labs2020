using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova.StrategyGame.Batrak
{
    class BatrakFermer
    {
        public double Speed { get; private set; }
        public int Resource { get; private set; }

        public BatrakFermer(double speed, int resource1)
        {

            Speed = speed;
            Resource = resource1;
        }
    }
}
