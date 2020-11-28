using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Statistical_game.Actions
{
    class Strateg_play
    {
        public static void Start_game()
        {
            IResources resources;
            IAttack attack;
            IMovable move;
            IDalnost dalnost;
            Console.WriteLine("-----ЗДАНИЯ-----");
            Console.WriteLine();

            var canteen = new Canteen("Столовая", 100, 8, 5);
            Console.WriteLine(Canteen.Name);
            Console.WriteLine($"Wellness: {Canteen.Wellness}");
            resources = Canteen;
            resources.Resources();
            dalnost = Canteen;
            dalnost.Dalnost();






        }
    }
}
