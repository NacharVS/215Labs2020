using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Strategy.BuildUnit
{
    class GoldStore:AbsarctClassVse
    {
        public int Gold { get; private set; }

     
        public GoldStore(int xp, int gold)
        {

            XP = xp;

            Gold = gold;

        }
    }
}
