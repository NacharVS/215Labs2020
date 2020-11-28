using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    class Village : Units
    {
        public Village(int health, int speed)
        {
            Village.Speed = speed;
            Village.Health = health;

        }
        public void Move()
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"Двигается со скоростью : {Village.Speed} ");
        }
    }
}
