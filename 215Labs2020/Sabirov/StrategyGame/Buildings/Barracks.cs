using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame.Buildings
{
    class Barracks : Building, IBuildingTime, IProduction
    {
        public Barracks(int health, int armour)
        {
            Barracks.Armour = armour;
            Barracks.Health = health;
        }

        public void Time()
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Building proccess is over");
        }
        public void Production()
        {
            System.Threading.Thread.Sleep(15000);
            Console.WriteLine($"Gold(Barracks): {Unit.Gold + 700}");


        }
    }
}
