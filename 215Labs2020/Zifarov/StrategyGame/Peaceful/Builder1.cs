using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.StrategyGame.Peaceful
{
    class Builder1 : Units, IMove, IBuilding
    {
        public Builder1(int health, int speed)
        {
            Builder1.Speed = speed;
            Builder1.Health = health;

        }
        public void Move()
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Двигается со скоростью : {Builder1.Speed} ");
        }
        public void Building()
        {
            if (Builder1.Health != 0) Console.WriteLine("Строитель готов строить");
            else Console.WriteLine("К сожалению строитель мертв");
        }
    }
}
