using _215Labs2020.Mihaylov.StrategyGame.Mirniy;
using _215Labs2020.Mihaylov.StrategyGame.Voiny;
using _215Labs2020.Mihaylov.StrategyGame.Zdania;
using System;

namespace _215Labs2020.Mihaylov.StrategyGame
{
    class Game
    {
        public static void Program()
        {
            Movable move;
            Attack attack;
            Resource resource;
            Radius radius;
            Ikazarma kazarma;

            Console.WriteLine("********Мирные********");
            Console.WriteLine();
            move = new Fermer("Фермер", 100, 6, 20);
            Console.Write(Fermer.Name + " ");
            move.Move();
            resource = new Fermer("Фермер", 100, 6, 20);
            resource.Res();
            Console.Write(Fermer.Name + " ");
            Console.WriteLine($"Здоровье: {Fermer.Xp}");
            Console.WriteLine();

            move = new Kuznes("Кузнец", 150, 6, 16);
            Console.Write(Kuznes.Name + " ");
            move.Move();
            resource = new Kuznes("Кузнец", 150, 6, 16);
            resource.Res();
            Console.Write(Kuznes.Name + " ");
            Console.WriteLine($"Здоровье: {Kuznes.Xp}");
            Console.WriteLine();

            move = new Lesnik("Лесник", 160, 6, 15);
            Console.Write(Lesnik.Name + " ");
            move.Move();
            resource = new Lesnik("Лесник", 160, 6, 15);
            resource.Res();
            Console.Write(Lesnik.Name + " ");
            Console.WriteLine($"Здоровье: {Lesnik.Xp}");
            Console.WriteLine();

            move = new Povar("Повар", 80, 6, 30);
            Console.Write(Povar.Name + " ");
            move.Move();
            resource = new Povar("Повар", 80, 6, 30);
            resource.Res();
            Console.Write(Povar.Name + " ");
            Console.WriteLine($"Здоровье: {Povar.Xp}");
            Console.WriteLine();

            move = new Stroitel("Строитель", 170, 6, 25);
            Console.Write(Stroitel.Name + " ");
            move.Move();
            resource = new Stroitel("Строитель", 170, 6, 25);
            resource.Res();
            Console.Write(Stroitel.Name + " ");
            Console.WriteLine($"Здоровье: {Stroitel.Xp}");
            Console.WriteLine();

            Console.WriteLine("********Воины********");
            move = new Goblin("Гоблин", 250, 20, 60);
            Console.Write(Goblin.Name + " ");
            move.Move();
            attack = new Goblin("Гоблин", 250, 20, 60);
            Console.Write(Goblin.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {Goblin.Xp}");
            Console.WriteLine();

            move = new Golem("Голем", 1000, 2, 100);
            Console.Write(Golem.Name + " ");
            move.Move();
            attack = new Golem("Голем", 1000, 2, 100);
            Console.Write(Golem.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {Golem.Xp}");
            Console.WriteLine();

            move = new Luchnik("Лучник", 300, 20, 50);
            Console.Write(Luchnik.Name + " ");
            move.Move();
            attack = new Luchnik("Лучник", 300, 20, 50);
            Console.Write(Luchnik.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {Luchnik.Xp}");
            Console.WriteLine();

            move = new Risar("Рыцарь", 500, 15, 65);
            Console.Write(Risar.Name + " ");
            move.Move();
            attack = new Risar("Рыцарь", 500, 15, 65);
            Console.Write(Risar.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {Risar.Xp}");
            Console.WriteLine();

            move = new Stenoboi("Стенобой", 100, 30, 200);
            Console.Write(Stenoboi.Name + " ");
            move.Move();
            attack = new Stenoboi("Стенобой", 100, 30, 200);
            Console.Write(Stenoboi.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {Stenoboi.Xp}");
            Console.WriteLine();

            Console.WriteLine("********Здания********");
            Console.WriteLine();


            attack = new Arbalet("Арбалет", 1000, 20);
            attack.Attack();
            Console.Write(Kazarma.Name + " ");
            Console.WriteLine($"Здоровье: {Arbalet.Xp}");
            Console.WriteLine();

            radius = new Dirizabl("Дирижабль", 400, 20);
            radius.Rad();
            Console.Write(Inferno.Name + " ");
            Console.WriteLine($"Здоровье: {Inferno.Xp}");
            Console.WriteLine();

            attack = new Inferno("Адская башня", 500, 60);
            attack.Attack();
            Console.Write(Inferno.Name + " ");
            Console.WriteLine($"Здоровье: {Inferno.Xp}");
            Console.WriteLine();

            kazarma = new Kazarma("Казарма", 300, 50);
            Console.Write(Kazarma.Name + " ");
            kazarma.VoinKol();
            Console.WriteLine($"Здоровье: {Kazarma.Xp}");
            Console.WriteLine();

            resource = new Ratusha("Ратуша", 1500, 3000);
            Console.Write(Ratusha.Name + " ");
            resource.Res();
            Console.WriteLine($"Здоровье: {Ratusha.Xp}");
            Console.WriteLine();
        }
    }
}
