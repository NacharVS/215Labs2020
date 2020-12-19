using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov.StrategyGame
{
    class game
    {
        public static void zapusk()
        {
            Ibuilding1 ib1;
            Imzh im1;
            Iwar iw1;
            Console.WriteLine("__________________Постройки______________");
            Console.WriteLine( );
            ib1 = new buildings.HouseOfBuilders(50, "stone", 9);
            ib1.build1();
            ib1 = new buildings.KlanovoeZdanie(67, 400, 12);
            ib1.build1();
            ib1 = new buildings.ScladResursov(100, 350, 350);
            ib1.build1();
            ib1 = new buildings.Shahta(50, 30, 700);
            ib1.build1();
            ib1 = new buildings.Shop(1000, "Products", "Knifes", "Clothing");
            ib1.build1();
            Console.WriteLine("__________________Мирные жители_______________");
            Console.WriteLine();
            im1 = new MirnieZhiteli.builder("Vacya", 3, 10, "molotok");
            im1.Mzh();
            im1 = new MirnieZhiteli.fermer("Ilya", 4, 24, "kartoshka");
            im1.Mzh();
            im1 = new MirnieZhiteli.ohotnic("Valera", 7, 10, 2, "Ruzhio");
            im1.Mzh();
            im1 = new MirnieZhiteli.prostoChelovek("Kolyan", 6, 45, "Naezdnic");
            im1.Mzh();
            im1 = new MirnieZhiteli.Rebenok("Mbappe", 20, 13, "Black");
            im1.Mzh();
            Console.WriteLine("__________________Воины_______________");
            Console.WriteLine();
            iw1 = new Wars.bronenosec("Mashina", 10, 5, "Bomba", 20, 30);
            iw1.war();
            iw1 = new Wars.klon("Neo", 5, 5, "Teleport", 4);
            iw1.war();
            iw1 = new Wars.luchnic("RobinGud", 10, 9, "luk", 21);
            iw1.war();
            iw1 = new Wars.pehotinec("Natasha", 8, 5, "Mech", 2);
            iw1.war();
            iw1 = new Wars.vor("Gennadiy", 4, "zatochka", 50);
            iw1.war();
        }
    }
}
