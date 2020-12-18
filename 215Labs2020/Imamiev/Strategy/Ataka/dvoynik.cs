using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev.Strategy.Ataka
{
    class dvoynik: mainuint, Iwar
    {
        public static int countKlon;
        public static string gun;

        public dvoynik(string Name, int Health, int Radius, string Gun, int Countklon)
        {
            name = Name; health = Health; radius = Radius; gun = Gun; countKlon = Countklon;
        }

        public void war()
        {
            Console.WriteLine($"Имя: {name}, здоровье: {health}, радиус действия:{radius}, оружие: {gun}, кол-во создаваемых клонов{countKlon}");
            Console.WriteLine("Имеет способность создавать клоны себя.");
            Console.WriteLine();
        }
    }
}
