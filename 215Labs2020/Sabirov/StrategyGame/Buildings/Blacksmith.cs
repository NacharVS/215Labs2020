using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame.Buildings
{
    class Blacksmith : Building, IBuildingTime, IProduction
    {
        public Blacksmith(int health, int armour)
        {
            Blacksmith.Armour = armour;
            Blacksmith.Health = health;
        }

        public void Time()
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Building proccess is over");
        }
        public void Production()
        {
            System.Threading.Thread.Sleep(12000);
            Console.WriteLine($"Gold(Blacksmith): {Unit.Gold + 800}");


        }
    }
}
