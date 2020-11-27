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

            move = new Povar("Повар", 100, 4, 20, 8);
            Console.Write(Povar.Name + " ");
            move.Move();
            resource = new Povar("Повар", 100, 5, 23, 8);
            resource.Res();
            work = new Povar("Механик", 100, 5, 23, 8);
            Console.Write(Povar.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {Povar.Xp}");
            Console.WriteLine();

            move = new Stroitel("Строитель", 100, 3, 15, 8);
            Console.Write(Stroitel.Name + " ");
            move.Move();
            resource = new Stroitel("Строитель", 100, 3, 15, 8);
            resource.Res();
            work = new Stroitel("Строитель", 100, 3, 15, 8);
            Console.Write(Stroitel.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {Stroitel.Xp}");
            Console.WriteLine();

            move = new Rabochiy("Рабочий", 100, 3, 10, 5);
            Console.Write(Rabochiy.Name + " ");
            move.Move();
            resource = new Rabochiy("Рабочий", 100, 3, 10, 5);
            resource.Res();
            work = new Rabochiy("Рабочий", 100, 3, 10, 5);
            Console.Write(Rabochiy.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {Rabochiy.Xp}");
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


            radius = new Luchniki("Лучники", 100, 50);
            Console.Write(Luchniki.Name + " ");
            radius.Rad();
            Console.WriteLine($"Здоровье: {Luchniki.Xp}");
            Console.WriteLine();

            radius = new Kazarma("Крепость", 80, 15, 200);
            Console.Write(kazarma.Name + " ");
            radius.Rad();
            resource = new Kazarma("Крепость", 80, 15, 200);
            resource.Res();
            Console.WriteLine($"Здоровье: {Kazarma.Xp}");
            Console.WriteLine();

            kuznitsa = new Kuznitsa("Кузница", 95, 23);
            Console.Write(Kuznitsa.Name + " ");
            kuznitsa.Kuz_kol();
            Console.WriteLine($"Здоровье: {BashnyaKuznitsa.Xp}");
            Console.WriteLine();

            resource = new MedPunkt("Больница", 80, 300);
            Console.WriteLine(MedPunkt.Name);
            resource.Res();
            Console.WriteLine($"Здоровье: {MedPunkt.Xp}");
            Console.WriteLine();

            kazarma = new Ratusha("Ратуша", 95, 25);
            Console.Write(Ratusha.Name + " ");
            kazarma.VoinKol();
            Console.WriteLine($"Здоровье: {Ratusha.Xp}");
            Console.WriteLine();
        }
    }
}
