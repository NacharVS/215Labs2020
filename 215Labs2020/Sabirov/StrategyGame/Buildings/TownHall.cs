using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace _215Labs2020.Sabirov.StrategyGame
{
    class TownHall : Building, IBuildingTime
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
           
       
        
            
        
    }
}
