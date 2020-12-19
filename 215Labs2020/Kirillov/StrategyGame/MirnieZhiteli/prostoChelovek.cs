using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov.StrategyGame.MirnieZhiteli
{
    class prostoChelovek : mainuint, Imzh
    {
        public static int age;
        public static string job;

        public prostoChelovek(string Name, int Health, int Age, string Job)
        {
            name = Name; health = Health; age = Age; job = Job;
        }

        public void Mzh()
        {
            Console.WriteLine($"Имя человека: {name}, кол-во здоровья: {health}, возраст: {age}, работа: {job}");
            Console.WriteLine("Просто мирный житель");
            Console.WriteLine();
        }
    }
}
