﻿













































































































































































































































using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasov.StrategyGames.Towers
{
    class Kazarma : Abstract, IKazarma
    {
        
        public int Voin_kol { get; private set; }

        public Kazarma(int xp, int voin_kol)
        {
            Xp = xp;
            Voin_kol = voin_kol;
        }
        public void VoinKol()
        {
            Console.WriteLine($"В казарме готовятся {Voin_kol} воинов");
        }
    }
}
