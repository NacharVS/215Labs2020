using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    class Unit_basa_Dirizhable : unit_abstract, IHeight, IDalnost, ISpeed
    {
        public double Speed { get; private set; }
        public int height { get; private set; }
        public int Dalnost { get; private set; }
        public Unit_basa_Dirizhable(string name, int xp, double speed, int height1, int dalnost)
        {
            Name = name;
            Xp = xp;
            Speed = speed;
            Dalnost = dalnost;
            height = height1;
        }
        public void dalnost()
        {
            Console.WriteLine($"Дальность видения: {Dalnost} м.");
        }
        public void scorost()
        {
            Console.WriteLine($"Скорость: {Speed} км/ч");
        }
        public void Height()
        {
            Console.WriteLine($"находится на высоте: {height} м.");
        }
    }
}
