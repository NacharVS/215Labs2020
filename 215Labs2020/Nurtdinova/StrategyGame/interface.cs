using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova.StrategyGame
{
    interface IAttack
    {
        public int Attack { get; }

        public void Att();
    }
   interface ISpeeed
   {
        public int Speed { get; }

        public void sp();
   }
}
