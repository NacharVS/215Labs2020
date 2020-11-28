using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.RPGGame.Texts
{
    class NPCsDialogs
    {
        public static void QuestBountyHunter()
        {
            Console.WriteLine("This man looks really dangerous");
            Console.WriteLine("His helmet is hiding his face and weapon can tell that he came here from the North");
            Console.WriteLine("-Looks like you still can understand us. Thats good. Your sword will be enough to kill some bastards");
            Console.WriteLine("They are located in forest camp on the West from here. Help me and maybe i'll help you to fix this rusty iron bar");
            Console.WriteLine("");
            Console.WriteLine("You decided to not ask any questions to him");
        }
        public static void QuestCompleteBountyHunter()
        {
            Console.WriteLine("-Oh, i see. The work is done. True warrior could feel when sword got the blood.");
            Console.WriteLine("Well, i think i can do something with you rusty stick");
            Console.WriteLine("And let me teach you some fighting tehnics from where i came.....");
            Console.WriteLine("-Now, go and talk with others.There are waiting for you.");
        }
    }
}
