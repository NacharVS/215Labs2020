using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov.StrategyGames.Towers
{
    class Kazarma : Abstract, IKazarma
    {
        public int Voin_kol { get; private set; }

        public Kazarma(string name, int xp, int voin_kol)
        {
            Name = name;
            Xp = xp;
            Voin_kol = voin_kol;
        }
        public void VoinKol()
        {
            Console.WriteLine($"содержит {Voin_kol} воинов");
        }
    }
}
