using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    class Queen : Units, IMove
    {
        public Queen(int health, int speed)
        {
            Queen.Speed = speed;
            Queen.Health = health;

        }
        public void Move()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine($"Двигается со скоростью : {Queen.Speed} ");
        }
    }
}
