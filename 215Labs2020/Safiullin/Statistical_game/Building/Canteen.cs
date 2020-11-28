using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Statistical_game.Actions
{
    class Canteen : abstact, IDalnost, IResources
    {
        public double Speed { get; private set; }
        public int height { get; private set; }
        public int Dalnost { get; private set; }
        public int resources { get; private set; }
        public int wellness { get; private set; }
        public Cateen(string name, int wellness, int height1, int dalnost, int resources1)
        {
            Name = name;
            Wellness = wellness;
            Dalnost = dalnost;
            height = height1;
            resources = resources1;

        }
        public void dalnost()
        {
            Console.WriteLine($"Дальность видения: {Dalnost} м.");
        }
        public void resoursces1()
        {
            Console.WriteLine($"Ресурсов собрано {resources} ед.");
        }
        public void Height()
        {
            Console.WriteLine($"находится на высоте: {height} м.");
        }
    }
}
