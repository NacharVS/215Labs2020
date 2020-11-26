using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Imamov.RPGGame.Location;

namespace _215Labs2020.Imamov.RPGGame.NPCs
{
    class BountyHunter
    {
        public static void Quest()
        {
            Console.WriteLine("This man looks really dangerous");
            Console.WriteLine("His helmet is hiding his face and weapon can tell that he came here from the North");
            Console.WriteLine("-Looks like you still can understand us. Thats good. Your sword will be enough to kill some bastards");
            Console.WriteLine("They are located in forest camp on the West from here. Help me and maybe i'll help to fix you this rusty iron bar");
            Console.WriteLine("");
            Console.WriteLine("You decided to not ask any questions to him");
            Console.WriteLine("");
            Console.WriteLine("*Your choice: ");
            Console.WriteLine("1.Go to the forest");
            Console.WriteLine("2.Talk with others");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                OldVillage.Active();
            }
            if (choice == 2)
            {
                ForestCamp.BattleWithBandits();
            }
        }

    }
}
