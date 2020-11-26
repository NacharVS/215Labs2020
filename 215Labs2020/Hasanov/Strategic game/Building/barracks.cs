using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    class barracks : Units, ITraining
    {
        public barracks(int health)
        {
            barracks.Health = health;
        }
        public void Training()
        {
            Console.WriteLine("Казарма построена ");
            Console.WriteLine("Теперь вы можете тренировать бойцов");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine($"Добыча: {Units.Gold - 3}");
        }
    }
}
