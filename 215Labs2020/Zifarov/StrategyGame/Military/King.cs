using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.StrategyGame.Military
{
    class King:Units, IAttack, IMove
    {
        public King(int damage, int health, int speed, int armor)
        {
            King.Speed = speed;
            King.Armor = armor;
            King.Damage = damage;
            King.Health = health;

        }
        public void Move()
        {
            Console.WriteLine($"Двигается со скоростью : {Archer.Speed} ");
        }
        public void Attack()
        {
            Console.WriteLine("Король повел свое войско в бой");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"атаковал на  {King.Damage} ");
            
            
           
            
        }
    }
}
