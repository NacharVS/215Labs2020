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
            if (Units.Gold == _mingold) Console.WriteLine("Мой милорд, мы не можем потратить остатки казны на тренировку воинов. Или вы хотите есть свои кожанные сапоги на завтрак, обед и ужин?)");
            else
            {
                System.Threading.Thread.Sleep(10000);
                Random rnd = new Random();
                int count = rnd.Next(3, 13);
                Console.WriteLine($"Казна: {Units.Gold - 30}");
                Console.WriteLine($"Было собрано войско из {count}");
            }
        }
    }
}
