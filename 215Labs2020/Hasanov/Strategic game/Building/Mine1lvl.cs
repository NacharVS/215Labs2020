using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Strategic_game
{
    class Mine1lvl : Units, IMaining
    {
        public Mine1lvl(int health)
        {
            Mine1lvl.Health = health;
        }
        public void Maining()
        {
            Console.WriteLine("Шахата построена");
            Random rnd = new Random();
            int resourse = rnd.Next(2, 5);
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine($"Добыча: {Units.Gold + resourse}");
        }
    }
}
