using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame.Buildings
{
    class Quarters : UnitInfo, IntCredits, IntRange
    {
        public Quarters(string name, int health, int range, int credits)
        {
            Name = name;
            Health = health;
            ViewRange = range;
            Credits = credits;
        }
        public void PointsCredit()
        {
            Console.WriteLine($"{Name} is producing credits : {credits}");
        }
        public void BuildingViewRange()
        {
            Console.WriteLine($"{Name} has range of attacking: {ViewRange} m.");
        }
    }
}
