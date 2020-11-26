using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.StrategyGame.Zdania
{
    class Kazarma : absract, Ikazarma
    {
        public int Voinkol { get; private set; }

        public Kazarma(string name, int xp, int voinkol)
        {
            Name = name;
            Xp = xp;
            Voinkol = voinkol;
        }
        public void VoinKol()
        {
            Console.WriteLine($"Готовы {Voinkol} воинов");
        }
    }
}