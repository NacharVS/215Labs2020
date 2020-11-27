using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.buildings
{
    class Shop : mainuint, Ibuilding1
    {
        public static string tovar1;
        public static string tovar2;
        public static string tovar3;
        public Shop(int Health, string Tovar1, string Tovar2, string Tovar3)
        {
            health = Health; tovar1 = Tovar1; tovar2 = Tovar2; tovar3 = Tovar3;
        }
        public void build1()
        {
            Console.WriteLine($"Kол-во здоровья: {health}, продаваемый товар №1: {tovar1}, продаваемый товар №2: {tovar2}, продаваемый товар №3: {tovar3}");
            Console.WriteLine();
        }
    }
}
