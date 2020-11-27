using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasova.StrategyGame.Wars
{
    class bronenosec : mainuint, Iwar
    {
        public static int speed;
        public static int armour;
        public static string gun;
        public bronenosec(string Name, int Health, int Radius, string Gun, int Armour, int Speed)
        {
            name = Name; health = Health; radius = Radius; gun = Gun; speed = Speed; armour = Armour;
        }

        public void war()
        {
            Console.WriteLine($"Имя воина:{name}, кол-во здоровья:{health}, радиус действия:{radius}, кол-во брони: {armour}, максимальная скорость: {speed}, оружие: {gun}");
            Console.WriteLine("Имеет способность переносить огромные повреждения.");
            Console.WriteLine();
        }
    }
}
