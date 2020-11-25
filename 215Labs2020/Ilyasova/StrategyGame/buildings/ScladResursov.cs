using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei.StrategyGame.buildings
{
    class ScladResursov : mainuint
    {
        public static int maxCountOfTree;
        public static int maxCountOfStone;
        public ScladResursov( int Health, int MaxCountOfTree, int MaxCountOfStone)
        {
            health = Health; maxCountOfTree = MaxCountOfTree; maxCountOfStone = MaxCountOfStone;
        }

        public static void sk()
        {
            Console.WriteLine($"Кол-во здоровья:{health}, максимальное хранимое кол-во дерева: {maxCountOfTree}, максимальное хранимое кол-во камня: {maxCountOfStone}");
            Console.WriteLine();
        }
    }
}
