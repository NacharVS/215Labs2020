using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Imamov.RPGGame.Enemies;
using _215Labs2020.Imamov.RPGGame.Hero;

namespace _215Labs2020.Imamov.StrategyGame
{
    class Start
    {
        static void Main(string[] args)
        {
            var Forgotten = new Forgotten("Forgotten", 3, 15);

            var bandits = new[]
            {
                new Bandit("Bandit Robber", 1,5),
                new Bandit("Bandit Trooper", 2, 8)
            };

            var cultists = new[]
            {
                new Cultist("Cultist Follower", 3, 12),
                new Cultist("Cultist Knowing", 5, 15)
            };

            var rats = new[]
            {
                new Rat("Plague Rat", 3, 8),
                new Rat("King of rats", 5, 17)
            };

            var zombie = new[]
            {
                new Zombie("Zombie Warrior", 4, 12),
                new Zombie("Zombie Peasunt", 2, 9),
                new Zombie("Undead Knight", 6, 20)
            };

            var dragon = new[]
            {
                new Dragon("The Suneater", 7, 30, 2),
            };

            Story.Awakening();

            Story.OldVillage();

            Story.ForestCamp();
            foreach (var bandit in bandits)
            {
                Battle.WithBandit(Forgotten, bandit);
            }

            Forgotten.LevelUp();

            Story.BeforeBandits();
            Battle.WithBandit(Forgotten, bandit);
            Battle.WithBandit(Forgotten, bandit);

            Forgotten.LevelUp();

            Story.BeforeCultists();
            Battle.WithCultist(Forgotten, Follower);
            Battle.WithCultist(Forgotten, Knowing);

            Forgotten.LevelUp();

            Story.BeforeRats
            Battle.WithRat(Forgotten, Plague);
            Battle.WithRat(Forgotten, King);

            Forgotten.LevelUp();

            Story.BeforeDragon();
            Battle.WithDragon(Forgotten, Suneater);

            Story.TheEnd();
        }
    }
}
