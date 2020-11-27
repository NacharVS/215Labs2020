using System;
using _215Labs2020.Ohotnicov.StrategyGames.Warrior;
using _215Labs2020.Ohotnicov.StrategyGames.Batrak;
using _215Labs2020.Ohotnicov.StrategyGames.Towers;

namespace _215Labs2020.Ohotnicov.StrategyGames

{
    class StartGame
    {
        public static void StartGameStrategy()
        {
            IMovable move;
            IAttack attack;
            IHeight height;
            IResource resource;
            IWork work;
            IRadius radius;
            IKuznitsa kuznitsa;
            IKazarma kazarma;
            IBolnisa bolnoy_pers;


            move = new Drakon(100, 14, 16, 5);
            move.Move();
            height = new Drakon(100, 14, 16, 5);
            height.Height();
            Console.WriteLine();

            move = new Ogr(90, 13, 10);
            move.Move();
            attack = new Ogr(90, 13, 10);
            Console.Write(Ogr.Name + " ");
            attack.Attack();
            Console.WriteLine();

            move = new Mechnik(60, 10, 9);
            move.Move();
            attack = new Mechnik(60, 10, 9);
            attack.Attack();
            Console.WriteLine();

            move = new Povar(100, 4, 20, 8);
            move.Move();
            resource = new Povar(100, 5, 23, 8);
            resource.Res();
            Console.WriteLine();

            move = new Stroitel(100, 3, 15, 8);
            move.Move();
            resource = new Stroitel(100, 3, 15, 8);
            resource.Res();
            Console.WriteLine();

            move = new Rabochiy(100, 3, 10, 5);
            move.Move();
            resource = new Rabochiy(100, 3, 10, 5);
            resource.Res();

            move = new Stroitel(100, 3, 20, 10);
            move.Move();
            resource = new Stroitel(100, 3, 20, 10);
            resource.Res();
            Console.WriteLine();


            radius = new Luchniki(100, 50);
            radius.Rad();
            Console.WriteLine();

            
            kazarma = new Kazarma(80, 15);
            kazarma.VoinKol();
            Console.WriteLine();

            kuznitsa = new Kuznitsa("Кузница", 95, 23);
            kuznitsa.Kuz_kol();
            Console.WriteLine();

            bolnoy_pers = new MedPunkt(80, 300);
            bolnoy_pers.bolychka();
            Console.WriteLine();

            kazarma = new Ratusha(95, 25);
            kazarma.VoinKol();
            Console.WriteLine($"Здоровье: {Ratusha.Xp}");
            Console.WriteLine();
        }
    }
}
