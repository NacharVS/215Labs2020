using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Delegates
{
    class GeneralOffise
    {
    
        public static void SortArray(int[] array)
        {
            Console.WriteLine("Coртировка");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void SummArray(int[] array)
        {
            Console.WriteLine("Сумма элементов массива");
            Console.WriteLine();
            int res = 0;
            foreach (int item in array)
            {
                res += item;
            }
            Console.WriteLine($"Сумма = {res}");
            Console.WriteLine();
        }
        public static void MaxArray(int[] array)
        {
            Console.WriteLine("Максимальный элемент внутри массива");
            Console.WriteLine();
            int max = 0;
            foreach (int item in array)
            {
                if (item > max) max = item;
            }
            Console.WriteLine($"Макс = {max}");
            Console.WriteLine();
        }
        public static void SummOfMassives(int[] array1, int[] array2)
        {
            int[] arrayRes = new int[array1.Length];
            for (int i = 0; i < array1.Length ; i++)
            {
                arrayRes[i] = array1[i] + array2[i];
            }
            Console.WriteLine();
            Console.WriteLine("Сумма двух массивов ");

            for (int i = 0; i < arrayRes.Length; i++)
            {
                Console.Write($" {arrayRes[i]} ");
            }
            Console.WriteLine();
        }
        public static void DifOfMassives(int[] array1, int[] array2)
        {
            int[] arrayRes = new int[array1.Length];
            for (int i = 0; i < array1.Length ; i++)
            {
                arrayRes[i] = array1[i] - array2[i];
            }
            Console.WriteLine();
            Console.WriteLine("Разность двух массивов");

            for (int i = 0; i < arrayRes.Length; i++)
            {
                Console.Write($" {arrayRes[i]} ");
            }
            Console.WriteLine();
        }
        public static void ProizvedenieOfMassives(int[] array1, int[] array2)
        {
            int[] arrayRes = new int[array1.Length];
            for (int i = 0; i < array1.Length ; i++)
            {
                arrayRes[i] = array1[i] * array2[i];
            }
            Console.WriteLine();
            Console.WriteLine("Произведение двух массивов");

            for (int i = 0; i < arrayRes.Length; i++)
            {
                Console.Write($" {arrayRes[i]} ");
            }
            Console.WriteLine();
        }
    }
}