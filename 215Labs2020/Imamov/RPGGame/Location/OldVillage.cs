using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Imamov.RPGGame;
using _215Labs2020.Imamov.RPGGame.NPCs;

namespace _215Labs2020.Imamov.RPGGame.Location
{
    class OldVillage
    {
       public static void Active()
       {
            Console.WriteLine("*Choose stranger you want to speek: ");
            Console.WriteLine("1.Bounty Hunter");
            Console.WriteLine("2.Plague Doctor");
            Console.WriteLine("3.Paladin");
            Console.WriteLine("4.Witch");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                BountyHunter.Quest();
            }
            if (choice == 2)
            {
                Quest.PlagueDoctor();
            }
            if (choice == 3)
            {
                Quest.Paladin();
            }
            if (choice == 4)
            {
                Quest.Witch();
            }
       }
    }
}
