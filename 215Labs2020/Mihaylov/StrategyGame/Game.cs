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
            Movement move;
            Attack attack;
            Productivity product;
            Radius radius;
            Ikazarma kazarma;

            Console.WriteLine("Мирные - 5 видов");
            Console.WriteLine();
            move = new Fermer("Фермер", 100, 6, 20);
            Console.WriteLine(Fermer.Name + " ");
            move.Movemen();
            product = new Fermer("Фермер", 100, 6, 20);
            product.product();
            Console.WriteLine($"Здоровье: {Fermer.Xp} ед.");
            Console.WriteLine();

            move = new Kuznes("Кузнец", 150, 6, 16);
            Console.WriteLine(Kuznes.Name + " ");
            move.Movemen();
            product = new Kuznes("Кузнец", 150, 6, 16);
            product.product();
            Console.WriteLine($"Здоровье: {Kuznes.Xp} ед.");
            Console.WriteLine();

            move = new Lesnik("Лесник", 160, 6, 15);
            Console.WriteLine(Lesnik.Name + " ");
            move.Movemen();
            product = new Lesnik("Лесник", 160, 6, 15);
            product.product();
            Console.WriteLine($"Здоровье: {Lesnik.Xp} ед.");
            Console.WriteLine();

            move = new Povar("Повар", 80, 6, 30);
            Console.WriteLine(Povar.Name + " ");
            move.Movemen();
            product = new Povar("Повар", 80, 6, 30);
            product.product();
            Console.WriteLine($"Здоровье: {Povar.Xp} ед.");
            Console.WriteLine();

            move = new Stroitel("Строитель", 170, 6, 25);
            Console.WriteLine(Stroitel.Name + " ");
            move.Movemen();
            product = new Stroitel("Строитель", 170, 6, 25);
            product.product();
            Console.WriteLine($"Здоровье: {Stroitel.Xp} ед.");
            Console.WriteLine();

            Console.WriteLine("Воины - 5 видов");
            Console.WriteLine();

            move = new Goblin("Гоблин", 250, 20, 60);
            Console.WriteLine(Goblin.Name + " ");
            move.Movemen();
            attack = new Goblin("Гоблин", 250, 20, 60);
            attack.Attack();
            Console.WriteLine($"Здоровье: {Goblin.Xp} ед.");
            Console.WriteLine();

            move = new Golem("Голем", 1000, 2, 100);
            Console.WriteLine(Golem.Name + " ");
            move.Movemen();
            attack = new Golem("Голем", 1000, 2, 100);
            attack.Attack();
            Console.WriteLine($"Здоровье: {Golem.Xp} ед.");
            Console.WriteLine();

            move = new Luchnik("Лучник", 300, 20, 50);
            Console.WriteLine(Luchnik.Name + " ");
            move.Movemen();
            attack = new Luchnik("Лучник", 300, 20, 50);
            attack.Attack();
            Console.WriteLine($"Здоровье: {Luchnik.Xp} ед.");
            Console.WriteLine();

            move = new Risar("Рыцарь", 500, 15, 65);
            Console.WriteLine(Risar.Name + " ");
            move.Movemen();
            attack = new Risar("Рыцарь", 500, 15, 65);
            attack.Attack();
            Console.WriteLine($"Здоровье: {Risar.Xp} ед.");
            Console.WriteLine();

            move = new Stenoboi("Стенобой", 100, 30, 200);
            Console.WriteLine(Stenoboi.Name + " ");
            move.Movemen();
            attack = new Stenoboi("Стенобой", 100, 30, 200);
            attack.Attack();
            Console.WriteLine($"Здоровье: {Stenoboi.Xp} ед.");
            Console.WriteLine();

            Console.WriteLine("Здания - 5 типов");
            Console.WriteLine();

            attack = new Arbalet("Арбалет", 1000, 20);
            Console.WriteLine(Kazarma.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {Arbalet.Xp} ед.");
            Console.WriteLine();

            radius = new Dirizabl("Дирижабль", 400, 20);
            Console.WriteLine(Dirizabl.Name + " ");
            radius.Rad();
            Console.WriteLine($"Здоровье: {Dirizabl.Xp} ед.");
            Console.WriteLine();

            attack = new Inferno("Адская башня", 500, 60);            
            Console.WriteLine(Inferno.Name + " ");
            attack.Attack();
            Console.WriteLine($"Здоровье: {Inferno.Xp} ед.");
            Console.WriteLine();

            kazarma = new Kazarma("Казарма", 300, 50);
            Console.WriteLine(Kazarma.Name + " ");
            kazarma.VoinKol();
            Console.WriteLine($"Здоровье: {Kazarma.Xp} ед.");
            Console.WriteLine();

            product = new Ratusha("Ратуша", 1500, 3000);
            Console.WriteLine(Ratusha.Name + " ");
            product.product();
            Console.WriteLine($"Здоровье: {Ratusha.Xp} ед.");
            Console.WriteLine();
        }
    }
}

