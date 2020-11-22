using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
    class Archer : Unit
    {
        public Archer(int dam, int health,int range)
        {
            Archer.Damage = dam;
            Archer.Health = health;
            Archer.Range = range;
        }
       
        public static void stats()
        { 
            Archer first = new Archer(15,100,30);
            Console.WriteLine(Archer.Damage);
        }
           
        
            
            
   
    }
}
