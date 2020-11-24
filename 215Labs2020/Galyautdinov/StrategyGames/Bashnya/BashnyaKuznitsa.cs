using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov.StrategyGames.Bashnya
{
    class BashnyaKuznitsa : Abstract, IKuznitsa
    {
        public int Kol { get; private set; }

        public BashnyaKuznitsa(string name, int xp, int kol)
        {
            Name = name;
            Xp = xp;
            Kol = kol;
        }
    }
}
