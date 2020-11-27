using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.StrategyGame.Buildings
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
            if (Units.Respect == _maxrespect) Console.WriteLine("Ваши поданные верны вам, проповеди не нужны мой милорд");
            if (Units.Respect == _minrespect) Console.WriteLine("Люди вам не доверяют");
            else
            {
                System.Threading.Thread.Sleep(10000);
                Console.WriteLine($"Любовь к вам растет : {Units.Respect + confidence}");
            }
        }
    }
}
