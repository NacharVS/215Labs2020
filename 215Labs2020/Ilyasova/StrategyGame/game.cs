using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame
{
    class game
    {
        public static void zapusk()
        {
            Console.WriteLine("Список воинов:");
            Console.WriteLine();
            Warier.VStart.zapuskV();
            Console.WriteLine("Список мирных жителей:");
            Console.WriteLine();
            MirnieZhiteli.MStart.zapuskM();
            Console.WriteLine("Список построек:");
            Console.WriteLine();
            buildings.BStart.zapuskB();
            Console.WriteLine();
        }
    }
}
