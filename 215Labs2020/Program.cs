using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame
{
    class Program
    {
        static void Main(string[] args)
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