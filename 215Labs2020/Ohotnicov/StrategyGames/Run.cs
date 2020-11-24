using System;
using _215Labs2020.Ohotnicov.StrategyGames.Warrior;
using _215Labs2020.Ohotnicov.StrategyGames.Batrak;
using _215Labs2020.Ohotnicov.StrategyGames.Tower;
using System.Collections.Generic;
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

            var warriorbatrak = new WarriorBatrak("Батрак", 30, 10, 5);
            Console.WriteLine(WarriorBatrak.Name);
            move = warriorbatrak;
            move.Move();
            attack = warriorbatrak;
            attack.Attack();
            Console.WriteLine();
            /*имя,здоровье, скорость, урон,высота*/
            var warriordrakon = new WarriorDrakon("Дракон", 100, 14, 16, 5);
            Console.WriteLine(WarriorDrakon.Name);
            move = warriordrakon;
            move.Move();
            height = warriordrakon;
            height.Height();
            Console.WriteLine();

            var warriorogr = new WarriorOgr ("Огр", 90, 13, 10);
            Console.WriteLine(WarriorOgr.Name);
            move = warriorogr;
            move.Move();
            attack = warriorogr;
            attack.Attack();
            Console.WriteLine();

            var warriorpekhotinets = new WarriorPekhotinets("Пехотинец", 60, 10, 9);
            Console.WriteLine(WarriorPekhotinets.Name);
            move = warriorpekhotinets;
            move.Move();
            attack = warriorpekhotinets;
            attack.Attack();
            Console.WriteLine();

            var warriorzulin = new WarriorZulin("Зулин", 40, 10, 8);
            Console.WriteLine(WarriorZulin.Name);
            move = warriorzulin;
            move.Move();
            attack = warriorzulin;
            attack.Attack();
            Console.WriteLine();

            var batrakfermer = new BatrakFermer("Фермер", 100, 4, 20);
            Console.WriteLine(BatrakFermer.Name);
            move = batrakfermer;
            move.Move();
            resource = batrakfermer;
            resource.Res();
            Console.WriteLine();
        }
    }
}
