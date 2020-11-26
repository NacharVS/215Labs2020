using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.Warier
{
    class VStart
    {
        public static void zapuskV()
        {
            bronenosec b = new bronenosec("Mashina", 10, 5, "Bomba", 20, 30);
            bronenosec.Bron();
            klon k = new klon("Neo", 5, 5, "Teleport", 4);
            k.kln();
            luchnic l = new luchnic("RobinGud", 10, 9, "luk", 21);
            luchnic.luch();
            pehotinec p = new pehotinec("Natasha", 8, 5, "Mech", 2);
            pehotinec.peh();
            vor v = new vor("Gennadiy", 4, "zatochka", 50);
            vor.vr();
        }

    }
}
