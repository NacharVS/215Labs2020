using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.Delegates
{
    class GeneralOffice
    {
        public static int[] array = { };
        public static int[] array2 = { };

        public static void Summ(int[] mass, int[] mass1)
        {
            Console.WriteLine("Сложение:");
            int[] sum = new int[5];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = mass[i] + mass1[i];
                Console.Write($"{sum[i]} ");

            }
            Console.WriteLine();
        }
        public static void Sub(int[] mass, int[] mass1)
        {
            Console.WriteLine("Вычитание:");
            int[] sub = new int[5];
            for (int i = 0; i < sub.Length; i++)
            {
                sub[i] = mass[i] - mass1[i];
                Console.Write($"{sub[i]} ");

            }
            Console.WriteLine();
        }
        public static void Mul(int[] mass, int[] mass1)
        {
            Console.WriteLine("Умножение:");
            int[] mul = new int[5];
            for (int i = 0; i < mul.Length; i++)
            {
                mul[i] = mass[i] * mass1[i];
                Console.Write($"{mul[i]} ");

            }
            Console.WriteLine();
        }
        public static int[] sortedarr = { };
        public static void Max(int[] mass)
        {


            int max = mass.Max();
            Console.WriteLine($"Максимальное число первого массива: {max} ");
        }

        public static void sort(int[] mass)
        {
            sortedarr = mass;
            Array.Sort(sortedarr);
            Console.WriteLine("Сортированный первый массив");
            foreach (int a in sortedarr)
                Console.Write($"{a} ");
            Console.WriteLine();
        }


    }
}
