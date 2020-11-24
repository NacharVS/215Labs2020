using System;
using _215Labs2020.Galyautdinov.StrategyGames.Voin;
using _215Labs2020.Galyautdinov.StrategyGames.mirnyy;
using _215Labs2020.Galyautdinov.StrategyGames.Bashnya;

namespace _215Labs2020.Galyautdinov.StrategyGames
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

            move = new VoinBatrak("Батрак", 30, 10, 5);
            Console.Write(VoinBatrak.Name + " ");
            move.Move();
            attack = new VoinBatrak("Батрак", 30, 10, 5);
            Console.Write(VoinBatrak.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {VoinBatrak.Xp}");
            Console.WriteLine();
                               /*имя,здоровье, скорость, урон,высота*/
            move = new VoinDrakon("Дракон", 100, 14, 16, 5);
            Console.Write(VoinDrakon.Name + " ");
            move.Move();
            height = new VoinDrakon("Дракон", 100, 14, 16, 5);
            Console.Write(VoinDrakon.Name + " ");
            height.Height();
            Console.WriteLine($"Здоровье: {VoinDrakon.Xp}");
            Console.WriteLine();

            move = new VoinOgr("Огр", 90, 13, 10);
            Console.Write(VoinOgr.Name + " ");
            move.Move();
            attack = new VoinOgr("Огр", 90, 13, 10);
            Console.Write(VoinOgr.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {VoinOgr.Xp}");
            Console.WriteLine();

            move = new VoinPekhotinets("Пехотинец", 60, 10, 9);
            Console.Write(VoinPekhotinets.Name + " ");
            move.Move();
            attack = new VoinPekhotinets("Пехотинец", 60, 10, 9);
            Console.Write(VoinPekhotinets.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {VoinPekhotinets.Xp}");
            Console.WriteLine();

            move = new VoinZulin("Зулин", 40, 10, 8);
            Console.Write(VoinZulin.Name + " ");
            move.Move();
            attack = new VoinZulin("Зулин", 40, 10, 8);
            Console.Write(VoinZulin.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {VoinZulin.Xp}");
            Console.WriteLine();

            move = new MirnyyFermer("Фермер", 100, 4, 20, 6);
            Console.Write(MirnyyFermer.Name + " ");
            move.Move();
            resource = new MirnyyFermer("Фермер", 100, 4, 20, 6);
            resource.Res();
            work = new MirnyyFermer("Фермер", 100, 4, 20, 6);
            Console.Write(MirnyyFermer.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {MirnyyFermer.Xp}");
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

            move = new MirnyyPovar("Повар", 100, 3, 15, 8);
            Console.Write(MirnyyPovar.Name + " ");
            move.Move();
            resource = new MirnyyPovar("Повар", 100, 3, 15, 8);
            resource.Res();
            work = new MirnyyPovar("Повар", 100, 3, 15, 8);
            Console.Write(MirnyyPovar.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {MirnyyPovar.Xp}");
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

            move = new MirnyyStroitel("Строитель", 100, 3, 20, 10);
            Console.Write(MirnyyStroitel.Name + " ");
            move.Move();
            resource = new MirnyyStroitel("Строитель", 100, 3, 20, 10);
            resource.Res();
            work = new MirnyyStroitel("Строитель", 100, 3, 20, 10);
            Console.Write(MirnyyStroitel.Name + " ");
            work.Work();
            Console.WriteLine($"Здоровье: {MirnyyStroitel.Xp}");
            Console.WriteLine();

            radius = new BashnyaDirizhabl("Дирижабель", 100, 50);
            Console.Write(MirnyyStroitel.Name + " ");
            radius.Rad();
            Console.WriteLine($"Здоровье: {MirnyyStroitel.Xp}");
            Console.WriteLine();
        }
    }
}
