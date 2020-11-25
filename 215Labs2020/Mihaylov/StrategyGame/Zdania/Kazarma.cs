using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Zdania
{
    class Kazarma : absract, Ikazarma
    {
        public int Voinkol { get; private set; }

        public Kazarma(int xp, int voin_kol)
        {
            Xp = xp;
            Voinkol = Voinkol;
        }
        public void VoinKol()
        {
            Console.WriteLine($"Готовы {Voinkol} воинов");
        }
    }
}