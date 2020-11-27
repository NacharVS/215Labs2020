using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasova.StrategyGame.buildings
{
    class ScladResursov : mainuint, Ibuilding1
    {
        public static int maxCountOfTree;
        public static int maxCountOfStone;
        public ScladResursov( int Health, int MaxCountOfTree, int MaxCountOfStone)
        {
            health = Health; maxCountOfTree = MaxCountOfTree; maxCountOfStone = MaxCountOfStone;
        }

        public void build1()
        {
            Console.WriteLine($"Кол-во здоровья: {health}, максимальное хранимое кол-во дерева: {maxCountOfTree}, максимальное хранимое кол-во камня: {maxCountOfStone}");
            Console.WriteLine();
        }
    }
}
