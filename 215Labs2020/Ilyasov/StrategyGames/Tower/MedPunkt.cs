using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasov.StrategyGames.Towers
{
    class MedPunkt : Abstract, IBolnisa
    {
        public int Bol { get; private set; }


        public MedPunkt(int xp, int bol)
        {
            Xp = xp;
            Bol = bol;
        }
        public void bolychka()
        {
            Console.WriteLine($"В больнице лечатся: {Bol} воинов");
        }
    }
}
