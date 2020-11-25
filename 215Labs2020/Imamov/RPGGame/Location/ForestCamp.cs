using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Imamov.RPGGame.Hero;
using _215Labs2020.Imamov.RPGGame.Enemies;
using _215Labs2020.Imamov.RPGGame.BattleInfo;

namespace _215Labs2020.Imamov.RPGGame.Location
{
    class ForestCamp
    {
        public static void BattleWithBandits(Forgotten hero, Bandit Bandit)
        {
            while (Bandit.health > 0 && hero.health > 0)
            {
                Battle.PrintTheStats(Bandit, hero);

                hero.YourTurn(hero.Choice(), Bandit);

                if (Bandit.health > 0)
                {
                    Bandit.BanditTurn(Bandit.EChoice(), hero);
                    Battle.IsHeroDead(hero);
                }

            }

            Console.WriteLine($"{Bandit.name} was killed!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
