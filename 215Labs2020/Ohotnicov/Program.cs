using System;
using _215Labs2020.Ohotnicov.StrategyGames;

namespace _215Labs2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                array[i] = rand.Next();
                Console.WriteLine(array[i]);
            }
        }
    }
}
