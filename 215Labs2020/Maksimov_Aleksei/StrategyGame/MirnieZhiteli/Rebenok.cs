using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.MirnieZhiteli
{
    class Rebenok : mainuint
    {
        public static string color;
        public static int age;
        public Rebenok(string Name, int Health, int Age, string Color)
        {
            name = Name; health = Health; age = Age; color = Color;
        }

        public static void reb()
        {
            Console.WriteLine($"Имя: {name}, кол-во здоровья: {health}, возраст: {age}, цвет: {color}");
            Console.WriteLine("Имеет способность переносить огромные повреждения.");
            Console.WriteLine();
        }
    }
}
