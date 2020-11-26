using System;
using _215Labs2020.Ohotnicov.StrategyGames.Warrior;
using _215Labs2020.Ohotnicov.StrategyGames.Batrak;
//using _215Labs2020.Ohotnicov.StrategyGames.Tower;
//using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov.StrategyGames

{
    class Run
    {
        public static void RunStrategy()
        {
            IMovable move;
            IAttack attack;
            IHeight height;
            IResource resource;
            IWork work;
            IRadius radius;
            IKuznitsa kuznitsa;
            IKazarma kazarma;

            Console.WriteLine("----------------------------Воины-------------------------------");

            move = new Drakon("Дракон", 100, 14, 16, 5);
            Console.Write(Drakon.Name + " ");
            move.Move();
            height = new Drakon("Дракон", 100, 14, 16, 5);
            Console.Write(Drakon.Name + " ");
            height.Height();
            Console.WriteLine($"Здоровье: {Drakon.Xp}");
            Console.WriteLine();

            move = new Ogr("Огр", 90, 13, 10);
            Console.Write(Ogr.Name + " ");
            move.Move();
            attack = new Ogr("Огр", 90, 13, 10);
            Console.Write(Ogr.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {Ogr.Xp}");
            Console.WriteLine();

            move = new Mechnik("Пехотинец", 60, 10, 9);
            Console.Write(Mechnik.Name + " ");
            move.Move();
            attack = new Mechnik("Пехотинец", 60, 10, 9);
            Console.Write(Mechnik.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {Mechnik.Xp}");
            Console.WriteLine();

            Console.WriteLine("----------------------------Мирные жители-------------------------------");

            move = new Rabochiy("Фермер", 100, 4, 20, 6);
            Console.Write(Rabochiy.Name + " ");
            move.Move();
            resource = new Rabochiy("Фермер", 100, 4, 20, 6);
            resource.Res();
            work = new Rabochiy("Фермер", 100, 4, 20, 6);
            Console.Write(Rabochiy.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {Rabochiy.Xp}");
            Console.WriteLine();

            move = new MirnyyMekhanik("Механик", 100, 4, 20, 8);
            Console.Write(MirnyyMekhanik.Name + " ");
            move.Move();
            resource = new MirnyyMekhanik("Механик", 100, 5, 23, 8);
            resource.Res();
            work = new MirnyyMekhanik("Механик", 100, 5, 23, 8);
            Console.Write(MirnyyMekhanik.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {MirnyyMekhanik.Xp}");
            Console.WriteLine();

            move = new Povar("Повар", 100, 3, 15, 8);
            Console.Write(Povar.Name + " ");
            move.Move();
            resource = new Povar("Повар", 100, 3, 15, 8);
            resource.Res();
            work = new Povar("Повар", 100, 3, 15, 8);
            Console.Write(Povar.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {Povar.Xp}");
            Console.WriteLine();

            move = new MirnyyRybak("Рыбак", 100, 3, 10, 5);
            Console.Write(MirnyyRybak.Name + " ");
            move.Move();
            resource = new MirnyyRybak("Рыбак", 100, 3, 10, 5);
            resource.Res();
            work = new MirnyyRybak("Рыбак", 100, 3, 10, 5);
            Console.Write(MirnyyRybak.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {MirnyyRybak.Xp}");
            Console.WriteLine();

            move = new Stroitel("Строитель", 100, 3, 20, 10);
            Console.Write(Stroitel.Name + " ");
            move.Move();
            resource = new Stroitel("Строитель", 100, 3, 20, 10);
            resource.Res();
            work = new Stroitel("Строитель", 100, 3, 20, 10);
            Console.Write(Stroitel.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {Stroitel.Xp}");
            Console.WriteLine();

            Console.WriteLine("----------------------------Башни-------------------------------");

            radius = new Luchniki("Лучники", 100, 50);
            Console.Write(Luchniki.Name + " ");
            radius.Rad();
            Console.WriteLine($"Здоровье: {Luchniki.Xp}");
            Console.WriteLine();

            radius = new ("Крепость", 80, 15, 200);
            Console.Write(BashnyaKrepost.Name + " ");
            radius.Rad();
            resource = new BashnyaKrepost("Крепость", 80, 15, 200);
            resource.Res();
            Console.WriteLine($"Здоровье: {BashnyaKrepost.Xp}");
            Console.WriteLine();

            kuznitsa = new BashnyaKuznitsa("Кузница", 95, 23);
            Console.Write(BashnyaKuznitsa.Name + " ");
            kuznitsa.Kuz_kol();
            Console.WriteLine($"Здоровье: {BashnyaKuznitsa.Xp}");
            Console.WriteLine();

            resource = new BashnyaMagazin("Магазин", 80, 300);
            Console.WriteLine(BashnyaMagazin.Name);
            resource.Res();
            Console.WriteLine($"Здоровье: {BashnyaMagazin.Xp}");
            Console.WriteLine();

            kazarma = new BashnyaKazarma("Казарма", 95, 25);
            Console.Write(BashnyaKazarma.Name + " ");
            kazarma.VoinKol();
            Console.WriteLine($"Здоровье: {BashnyaKazarma.Xp}");
            Console.WriteLine();
        }
    }
}
