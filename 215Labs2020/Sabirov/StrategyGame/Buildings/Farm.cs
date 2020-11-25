using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame.Buildings
{
    class Farm : Building, IBuildingTime, IProduction
    {
        public Farm(int health, int armour)
        {
            Farm.Armour = armour;
            Farm.Health = health;
        }

        public void Time()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Building proccess is over");
        }
        public void Production()
        {
            Thread.Sleep(10000);
            Console.WriteLine($"Gold(Farm): {Unit.Gold + 500}");


        }
    }
}
