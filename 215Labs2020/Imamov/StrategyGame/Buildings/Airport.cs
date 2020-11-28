using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.StrategyGame.Buildings
{
    class Airport : UnitInfo, IntCredits, IntRange
    {
        public Airport(string name, int health, int range, int credits)
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
