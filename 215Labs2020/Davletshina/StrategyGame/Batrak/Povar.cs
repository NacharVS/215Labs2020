using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Davletshina.StrategyGame.Batrak
{
    class Povar
    {
        public double Tasty { get; private set; }
        public int Fantasy { get; private set; }

        public Povar(double tasty, int fantasy)
        {
        Tasty = tasty;
        Fantasy = fantasy; 
        }
    }
}
