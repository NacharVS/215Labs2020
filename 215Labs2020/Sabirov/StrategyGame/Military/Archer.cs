using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.StrategyGame
{
    class Archer : Unit, IMoveUnit, IAttack
    {

        
       

        public Archer(int dam, int health,int range, int _Speed, int armor)
        {
            Archer.Armor = armor;
            Archer.Damage = dam;
            Archer.Health = health;
            Archer.Range = range;
            Archer.Speed = _Speed;
        }
      
        public void Move()
        {
            Console.WriteLine($"Unit is moving with this speed: {Archer.Speed} ");
        }
        public void Attack()
        {
            Console.WriteLine($"Unit dealed {Archer.Damage} damage");
        }
       
       
           
        
            
            
   
    }
}
