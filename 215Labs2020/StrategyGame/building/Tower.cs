using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.StrategyGame
{
    class Tower : Unit
    {
        public static void O()
        {
            Tower.Damage = 55;
            Tower.Health = 250;
            Tower.Speed = 12;
        }
    }
}
