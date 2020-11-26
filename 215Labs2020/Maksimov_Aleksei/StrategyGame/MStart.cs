using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.MirnieZhiteli
{
    class MStart
    {
        public static void zapuskM()
        {
            builder bu = new builder("Vacya", 3, 10, "molotok");
            builder.bul();
            fermer f = new fermer("Ilya", 4, 24, "kartoshka");
            fermer.fer();
            ohotnic o = new ohotnic("Valera", 7, 10, 2, "Ruzhio");
            ohotnic.hunt();
            prostoChelovek pr = new prostoChelovek("Kolyan", 6, 45, "Naezdnic");
            prostoChelovek.chel();
            Rebenok r = new Rebenok("Mbappe", 20, 13, "Black");
            Rebenok.reb();
        }
    }
}
