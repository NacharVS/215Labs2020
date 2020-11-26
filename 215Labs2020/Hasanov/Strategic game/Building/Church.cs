using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    class Church : Units, ISermon
    {
        public Church(int health)
        {
            Church.Health = health;
        }
        public void Sermon()
        {
            Console.WriteLine("Церковь открыта");
            Random rnd = new Random();
            int confidence = rnd.Next(2, 5);
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine($"Добыча: {Units.Respect + confidence}");
        }
    }
}
