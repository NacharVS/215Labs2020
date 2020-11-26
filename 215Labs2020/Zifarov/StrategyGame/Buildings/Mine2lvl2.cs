using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.StrategyGame.Buildings
{
    class Mine2lvl2:Units, IMaining
    {
        public Mine2lvl2(int health)
        {
            Mine2lvl2.Health = health;
        }
        public void Maining()
        {
            Console.WriteLine("Шахата построена");
            Random rnd = new Random();
            int resourse = rnd.Next(5, 8);
            System.Threading.Thread.Sleep(7000);
            Console.WriteLine($"Добыча: {Units.Gold + resourse}");
        }
    }
}
