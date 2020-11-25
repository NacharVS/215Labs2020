using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov.StrategyGames.Bashnya
{
    class BashnyaKazarma : Abstract, IKazarma
    {
        public int Voin_kol { get; private set; }

        public BashnyaKazarma(string name, int xp, int voin_kol)
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
