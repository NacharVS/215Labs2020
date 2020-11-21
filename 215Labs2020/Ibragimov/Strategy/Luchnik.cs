using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy
{
    class Luchnik
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
                Console.WriteLine($"лучник атакует{DamagedBuilding} ");

            }
        }
    }
}
