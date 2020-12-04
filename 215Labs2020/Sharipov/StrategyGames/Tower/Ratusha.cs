using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sharipov.StrategyGames.Towers
{
    class Ratusha : Abstract, IKazarma
    {
        public int Voin_kol { get; private set; }

        public Ratusha(int xp, int radius1)
        {
            Xp = xp;
            Voin_kol = radius1;
        }
        public void VoinKol()
        {
            Console.WriteLine($"Готово {Voin_kol} бойцов");
        }

    }
}