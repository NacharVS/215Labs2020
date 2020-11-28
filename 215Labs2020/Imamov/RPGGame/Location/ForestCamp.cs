using System;
using _215Labs2020.Imamov.RPGGame.Texts;
using _215Labs2020.Imamov.RPGGame.Hero;
using _215Labs2020.Imamov.RPGGame.Enemies;
using _215Labs2020.Imamov.RPGGame.BattleInfo;

namespace _215Labs2020.Imamov.RPGGame.Location
{
    class ForestCamp
    {
        public void BattleWithBandits(Forgotten hero, Bandit Bandit)
        {
            Story.ForestCampQuest();
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
            Story.AfterBandits();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
