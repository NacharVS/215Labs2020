using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.StrategyGame.Peaceful
{
    class Thief:Units, ITheft
    {
        public Thief(int health, int speed)
        {
            Thief.Speed = speed;
            Thief.Health = health;

        }
        public void Move()
        {
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine($"Двигается со скоростью : {Thief.Speed} ");
            
        }
        public void Theft()
        {
            System.Threading.Thread.Sleep(5000);
            Random rnd = new Random();
            int a = rnd.Next(5, 23);
            if (Thief.Health != 0)
            {
                Console.WriteLine($"Воворует из казны мой милорд {Units.Gold - a}");
                Console.WriteLine($"Народ не доволен, уважение : {Units.Respect -a}"); ;
            }
        }
    }
}
