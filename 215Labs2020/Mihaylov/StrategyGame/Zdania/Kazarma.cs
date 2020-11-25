using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Zdania
{
    class Kazarma : absract, Ikazarma
    {
        public int Voinkol { get; private set; }

        public Kazarma(string name, int xp, int voin_kol)
        {
            Name = name;
            Xp = xp;
            Voinkol = Voinkol;
        }
        public void VoinKol()
        {
            Console.WriteLine($"Готовы {Voinkol} воинов");
        }
    }
}