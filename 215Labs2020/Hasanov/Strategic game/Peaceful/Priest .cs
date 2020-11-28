using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    class Priest : Units, IMove
    {
        public Priest(int health, int speed)
        {
            Priest.Speed = speed;
            Priest.Health = health;

        }
        public void Move()
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Двигается со скоростью : {Priest.Speed} ");
        }
    }
}
