using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Imamov.RPGGame.Hero;
using _215Labs2020.Imamov.RPGGame.Enemies;

namespace _215Labs2020.Imamov.RPGGame.BattleInfo
{
    class Battle
    {
        public static void IsHeroDead(Forgotten hero)
        {
            if (hero.health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Looks like you are dead!");
                Console.WriteLine("Better luck next time!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void PrintTheStats(Person person1, Person person2)
        {
            person1.PrintStats();
            Console.WriteLine("");
            person2.PrintStats();
            Console.WriteLine("");
        }

        public static void WithBandit(Forgotten hero, Bandit Bandit)
        {
            while (Bandit.health > 0 && hero.health > 0)
            {
                PrintTheStats(Bandit, hero);

                hero.YourTurn(hero.Choice(), Bandit);

                if (Bandit.health > 0)
                {
                    Bandit.BanditTurn(Bandit.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine($"{Bandit.name} was killed!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithCultist(Forgotten hero, Cultist cultist)
        {
            while (cultist.health > 0 && hero.health > 0)
            {
                PrintTheStats(cultist, hero);

                hero.YourTurn(hero.Choice(), cultist);

                if (cultist.health > 0)
                {
                    cultist.CultistTurn(cultist.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine($"{cultist.name} was killed!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithRat(Forgotten hero, Rat rat)
        {
            while (rat.health > 0 && hero.health > 0)
            {
                PrintTheStats(rat, hero);

                hero.YourTurn(hero.Choice(), rat);

                if (rat.health > 0)
                {
                    rat.RatTurn(rat.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine($"{rat.name} was killed!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithZombie(Forgotten hero, Zombie zombie)
        {
            while (zombie.health > 0 && hero.health > 0)
            {
                PrintTheStats(zombie, hero);

                hero.YourTurn(hero.Choice(), zombie);

                if (zombie.health > 0)
                {
                    zombie.ZombieTurn(zombie.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine($"{zombie.name} was killed!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithDragon(Forgotten hero, Dragon dragon)
        {
            while (dragon.health > 0 && hero.health > 0)
            {
                PrintTheStats(dragon, hero);

                hero.YourTurn(hero.Choice(), dragon);

                if (dragon.health > 0)
                {
                    dragon.DragonTurn(dragon.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine($"{dragon.name} was killed !");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
