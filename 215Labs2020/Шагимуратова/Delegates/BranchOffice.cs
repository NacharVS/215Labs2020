using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Delegates
{
    class BranchOffice
    {
        private delegate void Otvet(string otv);

        public static void max (int[] array, int MaxRandomValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(MaxRandomValue);
                //Console.WriteLine(array[i]);
            }
        }
        public static void summ2(string[] args)
        {
            int[,] array = new int[10,10];
            Random rnd = new Random();
            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    array[i,j] = rnd.Next(10, 100);
                    Console.Write($"{array[i, j]} ");
                    if (i == j) summ = summ + array[i, j];

                }
                Console.WriteLine();
            }
            Console.WriteLine(summ);
        }

        public static void sort()
        {

        } 
    }

}
