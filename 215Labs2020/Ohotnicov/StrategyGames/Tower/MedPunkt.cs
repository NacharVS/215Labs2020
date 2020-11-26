using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov.StrategyGames.Towers
{
    class MedPunkt : Abstract
    {
        public double Bolnitsa { get; private set; }

        public MedPunkt(string name, int xp, double radius1, int bol)
        {
            Name = name;
            Xp = xp;
            Bolnitsa = bol;
        }
        public void Rad()
        {
            Console.WriteLine($"Вылеченно: {Bolnitsa} воинов");
        }
    }
}
