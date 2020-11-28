using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov.StrategyGames
{
    class Building : IProduction, IBuildingTime
    {
        private static int armour;
        private static int health;
        private static string name;
        private static int time;
        private static int res;
        private static int qua;
        public static int Armour { get => armour; set => armour = value; }
        public static int Health { get => health; set => health = value; }
        public static string Name { get => name; set => name = value; }
        public static int Time1 { get => time; set => time = value; }
        public static int Res { get => res; set => res = value; }
        public static int Qua { get => qua; set => qua = value; }

        public Building(string name, int armour, int health, int res, int time, int qua)
        {
            Building.Name = name;
            Building.Armour = armour;
            Building.Health = health;
            Building.Res = res;
            Building.Time1 = time;
            Building.Qua = qua;
        }
        public void Time()
        {
            System.Threading.Thread.Sleep(Building.Time1);
            Console.WriteLine("Building proccess is over");
        }
        public void Production()
        {
            System.Threading.Thread.Sleep(Building.Res);
            Console.WriteLine($"Gold({Building.Name}): {Unit.Gold += Building.Qua}");


        }
    }
}
