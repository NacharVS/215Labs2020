using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.Deligates
{
    class GeneralOffice
    {
        public static void Ex1(int[] mass)
        {
            int max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (max<mass[i])
                {
                    max = mass[i];
                }              
            }
            Console.WriteLine($"Максимум массива{max}");
        }
        public static void Ex2(int[] mass)
        {
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                summ += mass[i];
            }
            Console.WriteLine($"Сумма массива {summ}");
            
        }
        public static void Ex3(int[] mass)
        {
            int[] array = mass;
            Array.Sort(array);
            Console.Write("Сортировка массива: ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static void Ex4(int[] mass1, int[] mass2)
        {
            int[] mass_sum = new int[mass1.Length];
            Console.Write("Сумма массивов: ");
            for (int i = 0; i < mass1.Length; i++)
            {
                mass_sum[i] = mass1[i] + mass2[i];
                Console.Write($"{mass_sum[i]} ");
            }
            Console.WriteLine();
        }
        public static void Ex5(int[] mass1, int[] mass2)
        {
            int[] mass_diff = new int[5];
            Console.Write("Разность массивов: ");
            for (int i = 0; i < mass1.Length; i++)
            {
                mass_diff[i] = mass1[i] - mass2[i];
                Console.Write($"{mass_diff[i]} ");
            }
            Console.WriteLine();
        }
        public static void Ex6(int[] mass1, int[] mass2)
        {
            int[] mass_diff = new int[5];
            Console.Write("Произведение массивов: ");
            for (int i = 0; i < mass1.Length; i++)
            {
                mass_diff[i] = mass1[i] * mass2[i];
                Console.Write($"{mass_diff[i]} ");
            }
            Console.WriteLine();
        }
    }
}
