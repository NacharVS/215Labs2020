using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Davletshina.StrategyGame.Batrak
{
    class Fermer
    { 
        public double Speed { get; private set; }
        public int Resource { get; private set; }
         
        public Fermer(double speed, int resource1)
        {

            Speed = speed;
            Resource = resource1;
        }
    }
}