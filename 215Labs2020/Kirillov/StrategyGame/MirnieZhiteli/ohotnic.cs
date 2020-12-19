using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov.StrategyGame.MirnieZhiteli
{
    class ohotnic : mainuint, Imzh
    {
        public static string gun;
        public static int countOfKapkan;

        public ohotnic(string Name, int Health, int Radius, int CountOfKapkan, string Gun)
        {
            name = Name; health = Health; radius = Radius; gun = Gun; countOfKapkan = CountOfKapkan;
        }

        public void Mzh()
        {
            Console.WriteLine($"Имя охотниса: {name}, кол-во здоровья: {health}, радиус действия: {radius}, оружие: {gun}, кол-во капканов: {countOfKapkan}");
            Console.WriteLine("Профессиональный охотник.");
            Console.WriteLine();
        }
    }
}
