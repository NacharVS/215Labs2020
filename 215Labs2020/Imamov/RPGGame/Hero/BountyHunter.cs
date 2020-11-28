using System;
using _215Labs2020.Imamov.RPGGame.Texts;
using _215Labs2020.Imamov.RPGGame.Location;

namespace _215Labs2020.Imamov.RPGGame.Hero
{
    class BountyHunter
    {
        public static void DialogBH()
        {
            int QuestComplete = 0;
            if (QuestComplete == 0)
            {
                NPCsDialogs.QuestBountyHunter();
                Console.WriteLine("*Your choice: ");
                Console.WriteLine("1.Talk with others");
                Console.WriteLine("2.Go to the forest");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    OldVillage.VillageCamp();
                }
                if (choice == 2)
                {
                    ForestCamp.BattleWithBandits();
                    QuestComplete += 1;
                }
            }
            if (QuestComplete == 1)
            {
                NPCsDialogs.QuestCompleteBountyHunter();
                Forgotten.LevelUp();
            }
        }
    }
}
