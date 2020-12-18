using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev.Strategy
{
    class game
    {
        public static void Gotov()
        {
            Ibuilding1 ib1;
            Imzh im1;
            Iwar iw1;
            Console.WriteLine("__________________Постройки______________");
            Console.WriteLine();
            ib1 = new Stroiteli.hijina(50, "stone", 9);
            ib1.build1();
            ib1 = new Stroiteli.ClanovayaBashnya(67, 400, 12);
            ib1.build1();
            ib1 = new Stroiteli.Resurse(100, 350, 350);
            ib1.build1();
            ib1 = new Stroiteli.shahta(50, 30, 700);
            ib1.build1();
            ib1 = new Stroiteli.Magaz(1000, "Products", "Knifes", "Clothing");
            ib1.build1();
            Console.WriteLine("__________________Мирные жители_______________");
            Console.WriteLine();
            im1 = new MirnieZhiteli.builder("Oleg", 3, 10, "molotok");
            im1.Mzh();
            im1 = new MirnieZhiteli.Rabotnik("Danya", 4, 24, "gvozd");
            im1.Mzh();
            im1 = new MirnieZhiteli.Ohotnik("Valera", 7, 10, 2, "Kalash");
            im1.Mzh();
            im1 = new MirnieZhiteli.Chelovechek("Vova", 6, 45, "Naezdnic");
            im1.Mzh();
            im1 = new MirnieZhiteli.Detye("rafil", 20, 13, "Chill");
            im1.Mzh();
            Console.WriteLine("__________________Воины_______________");
            Console.WriteLine();
            iw1 = new Ataka.Bomber("Mashina", 10, 5, "Bomba", 20, 30);
            iw1.war();
            iw1 = new Ataka.dvoynik("Neo", 5, 5, "Teleport", 4);
            iw1.war();
            iw1 = new Ataka.Luchnik("RobinGud", 10, 9, "luk", 21);
            iw1.war();
            iw1 = new Ataka.Pehotinec("Natasha", 8, 5, "Mech", 2);
            iw1.war();
            iw1 = new Ataka.Shpion("Gennadiy", 4, "zatochka", 50);
            iw1.war();
        }
    }
}
