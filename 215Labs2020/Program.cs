using _215Labs2020.Hasanov.Delegates;
using System;

namespace _215Labs2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array1 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array1[i] = rnd.Next(10, 111);
                Console.WriteLine(array1[i]);
            }
            Random rnd1 = new Random();
            int[] array2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array1[i] = rnd.Next(10, 111);
                Console.WriteLine(array1[i]);
            }
        }
    }
}
