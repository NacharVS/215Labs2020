using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin.Game.buildings
{
    class resource_warehouse : mainunit, Ibuilding1
    {
        public static int maxCountOfTree;
        public static int maxCountOfStone;
        public resource_warehouse(int Health, int MaxCountOfTree, int MaxCountOfStone)
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
