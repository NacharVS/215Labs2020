using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace _215Labs2020.Sabirov.StrategyGame
{
    class Barraks : Building, IBuildingTime
    {
       public Barraks(int health, int armour)
        {
            Barraks.Armour = armour;
            Barraks.Health = health;
        }
        
        public void Time()
        {
            Thread.Sleep(2500);
            Console.WriteLine("Building proccess is over");
        }
           
       
        
            
        
    }
}
