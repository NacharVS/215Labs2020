using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasova.StrategyGame.Wars
{
    class luchnic : mainuint, Iwar
    {
        public static int countOfArrow;
        public static string gun;
        public luchnic(string Name, int Health, int Radius, string Gun, int CountOfArrow)
        {
            name = Name; health = Health; radius = Radius; gun = Gun; countOfArrow = CountOfArrow;
        }

        public void war()
        {
            Console.WriteLine($"Имя воина:{name}, кол-во здоровья:{health}, радиус действия:{radius}, оружие: {gun}, кол-во стрел{countOfArrow}");
            Console.WriteLine("Обычный лучник");
            Console.WriteLine();
        }
    }
}
