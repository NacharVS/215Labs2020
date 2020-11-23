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

            var voinbatrak = new VoinBatrak("Батрак", 30,  10, 5);
            Console.WriteLine(VoinBatrak.Name);
            move = voinbatrak;
            move.Move();
            attack = voinbatrak;
            attack.Attack();
            Console.WriteLine();
                               /*имя,здоровье, скорость, урон,высота*/
            var voindrakon = new VoinDrakon("Дракон", 100, 14, 16, 5);
            Console.WriteLine(VoinDrakon.Name);
            move = voindrakon;
            move.Move();
            height = voindrakon;
            height.Height();
            Console.WriteLine();

            var voinofr = new VoinOgr("Огр", 90, 13, 10);
            Console.WriteLine(VoinOgr.Name);
            move = voinofr;
            move.Move();
            attack = voinofr;
            attack.Attack();
            Console.WriteLine();

            var voinpekhotinets = new VoinPekhotinets("Пехотинец", 60, 10, 9);
            Console.WriteLine(VoinPekhotinets.Name);
            move = voinpekhotinets;
            move.Move();
            attack = voinpekhotinets;
            attack.Attack();
            Console.WriteLine();

            var voinzulin = new VoinZulin("Зулин", 40, 10, 8);
            Console.WriteLine(VoinZulin.Name);
            move = voinzulin;
            move.Move();
            attack = voinzulin;
            attack.Attack();
            Console.WriteLine();

            var mirnyyfermer = new MirnyyFermer("Фермер", 100, 4, 20);
            Console.WriteLine(MirnyyFermer.Name);
            move = mirnyyfermer;
            move.Move();
            resource = mirnyyfermer;
            resource.Res();
            Console.WriteLine();
        }
    }
}
