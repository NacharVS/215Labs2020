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
            Console.WriteLine("Мирные");
            Console.WriteLine($"Фермер, Здоровье: {Fermer.Xp}");
            Console.WriteLine($"Кузнец, Здоровье: {Kuznes.Xp}");
            Console.WriteLine($"Лесник, Здоровье: {Lesnik.Xp}");
            Console.WriteLine($"Повар, Здоровье: {Povar.Xp}");
            Console.WriteLine($"Строитель, Здоровье: {Stroitel.Xp}");
            Console.WriteLine("Воины");
            Console.WriteLine($"Гоблин, Здоровье: {Goblin.Xp}");
            Console.WriteLine($"Голем, Здоровье: {Golem.Xp}");
            Console.WriteLine($"Лучник, Здоровье: {Luchnik.Xp}");
            Console.WriteLine($"Рыцарь, Здоровье: {Risar.Xp}");
            Console.WriteLine($"Стенобой, Здоровье: {Stenoboi.Xp}");
            Console.WriteLine("Здания");
            Console.WriteLine($"Арбалет, Здоровье: {Arbalet.Xp}");
            Console.WriteLine($"Дирижабль, Здоровье: {Dirizabl.Xp}");
            Console.WriteLine($"Адская Башня, Здоровье: {Inferno.Xp}");
            Console.WriteLine($"Казарма, Здоровье: {Kazarma.Xp}");
            Console.WriteLine($"Ратуша, Здоровье: {Ratusha.Xp}");

        }
    }
}
