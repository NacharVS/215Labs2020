using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin.Game
{
    class game
    {
        public static void zapusk()
        {
            Ibuilding1 ib1;
            Imzh im1;
            Iwar iw1;
            Console.WriteLine("__________________Постройки______________");
            Console.WriteLine();
            ib1 = new buildings.HouseOfBuilders(50, "stone", 9);
            ib1.build1();
            ib1 = new buildings.Clan_house(67, 400, 12);
            ib1.build1();
            ib1 = new buildings.resource_warehouse(100, 350, 350);
            ib1.build1();
            ib1 = new buildings.mine(50, 30, 700);
            ib1.build1();
            ib1 = new buildings.shop(1000, "Products", "Knifes", "Clothing");
            ib1.build1();
            Console.WriteLine("__________________Мирные жители_______________");
            Console.WriteLine();
            im1 = new civilians.builder("Vacya", 3, 10, "molotok");
            im1.Mzh();
            im1 = new civilians.farmer("Ilya", 4, 24, "kartoshka");
            im1.Mzh();
            im1 = new civilians.hunter("Valera", 7, 10, 2, "Ruzhio");
            im1.Mzh();
            im1 = new civilians.man("Kolyan", 6, 45, "Naezdnic");
            im1.Mzh();
            im1 = new civilians.Kid("Mbappe", 20, 13, "Black");
            im1.Mzh();
            Console.WriteLine("__________________Воины_______________");
            Console.WriteLine();
            iw1 = new enemies.battleship("Mashina", 10, 5, "Bomba", 20, 30);
            iw1.war();
            iw1 = new enemies.klon("Neo", 5, 5, "Teleport", 4);
            iw1.war();
            iw1 = new enemies.archer("RobinGud", 10, 9, "luk", 21);
            iw1.war();
            iw1 = new enemies.infantryman("Natasha", 8, 5, "Mech", 2);
            iw1.war();
            iw1 = new enemies.vor("Gennadiy", 4, "zatochka", 50);
            iw1.war();
        }
    }

   }

