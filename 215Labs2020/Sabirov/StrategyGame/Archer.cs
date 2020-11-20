using System;
using System.Collections.Generic;
using System.Text;
using static _215Labs2020.Sabirov.StrategyGame.Unit;

namespace _215Labs2020.Sabirov.StrategyGame
{
    class Archer : Unit, IDamage
    {
       void Stats()
        {
            Archer.Damage = 100;
            Archer.Health = 150;

        }
        public void DealDamage(Building DamagedBuilding) 
        {
            Console.WriteLine($"Archer attacked {DamagedBuilding} ");
            
        }
    }
}
