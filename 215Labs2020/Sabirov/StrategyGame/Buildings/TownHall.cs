using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace _215Labs2020.Sabirov.StrategyGame
{
    class TownHall : Building, IBuildingTime, IProduction
    {
       public TownHall(int health, int armour)
        {
            TownHall.Armour = armour;
            TownHall.Health = health;
        }
        
        public void Time()
        {
            Thread.Sleep(2500);
            Console.WriteLine("Building proccess is over");
        }
        public void Production()
        {
            Thread.Sleep(17000);
            Console.WriteLine($"Gold(TownHall): {Unit.Gold + 1200}");


        }




    }
}
