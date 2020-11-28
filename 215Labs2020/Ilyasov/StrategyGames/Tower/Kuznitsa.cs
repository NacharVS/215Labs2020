using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasov.StrategyGames.Towers
{
    class Kuznitsa : Abstract, IKuznitsa
    {
        public int Kol { get; private set; }

        public Kuznitsa(string name, int xp, int kol)
        {
            Name = name;
            Xp = xp;
            Kol = kol;
        }
        public void Kuz_kol()
        {
            Console.WriteLine($"В кузнице готово {Kol} деталей");
        }
    }
}
