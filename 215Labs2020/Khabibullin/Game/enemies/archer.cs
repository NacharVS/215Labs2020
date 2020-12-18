using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin.Game.enemies
{
    class archer : mainunit, Iwar
    {
        public static int countOfArrow;
        public static string gun;
        public archer(string Name, int Health, int Radius, string Gun, int CountOfArrow)
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
