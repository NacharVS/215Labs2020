using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Imamov.RPGGame;
using _215Labs2020.Imamov.RPGGame.Hero;
using _215Labs2020.Imamov.RPGGame.Texts;

namespace _215Labs2020.Imamov.RPGGame.Location
{
    class OldVillage
    {
       public static void VillageCamp()
       {
            Story.OldVillage();
            Console.WriteLine("*Choose stranger you want to speek: ");
            Console.WriteLine("1.Bounty Hunter");
            Console.WriteLine("2.Plague Doctor");
            Console.WriteLine("3.Paladin");
            Console.WriteLine("4.Witch");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                BountyHunter.DialogBH();
            }
            if (choice == 2)
            {
                PlagueDoctor.DialogPD();
            }
            if (choice == 3)
            {
                Paladin.DialogPldn();
            }
            if (choice == 4)
            {
                Witch.DialogWtch();
            }
       }
    }
}
