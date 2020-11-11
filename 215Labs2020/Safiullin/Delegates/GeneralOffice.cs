using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Delegates
{
    class GeneralOffice
    {
        public static void Max(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }

            }
            Console.WriteLine($"Мax: {max} ");
        }
        public static void Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum: {sum}");
        }
        public static void Sortirovka(int[] array)
        {
            Console.WriteLine($"Sortirovka: ");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }
            Console.WriteLine();
        }
        public static void SummMass(int[] array)
        {
            int a = 0;
            foreach (int item in array)
            {
                a += item;
            }
            Console.WriteLine($"Сумма двух массив: {a}");
        }
    }
}
