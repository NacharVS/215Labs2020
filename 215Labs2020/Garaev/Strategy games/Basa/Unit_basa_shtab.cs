using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Strategy_games
{
    class Unit_basa_shtab : unit_abstract, IDalnost
    {
        public double Speed { get; private set; }
        public int height { get; private set; }
        public int Dalnost { get; private set; }
        public Unit_basa_shtab(string name, int xp, int dalnost)
        {
            Name = name;
            Xp = xp;
            Dalnost = dalnost;
        }
        public void dalnost()
        {
            Console.WriteLine($"Дальность видения: {Dalnost} м.");
        }
    }
}
