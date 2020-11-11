using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.Delegates
{
    class branchOffise
    {
        private delegate void ArrayOprerations(int[] array);
        private delegate void OperationsOnArrays(int[] array1, int[] array2);

        public static void start()
        {
            ArrayOprerations oprerations = GeneralOffise.SortArray;
            oprerations += GeneralOffise.MaxArray;
            oprerations += GeneralOffise.SummArray;
            OperationsOnArrays OperationsOnArrays = GeneralOffise.SummOfMassives;
            OperationsOnArrays += GeneralOffise.DifOfMassives;
            OperationsOnArrays += GeneralOffise.ProizvedenieOfMassives;
            Random rnd = new Random();
            int[] array = new int[rnd.Next(5, 10)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 100);
            }
            Console.WriteLine("Массив для сортировки и для макс числа , суммы элементов");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            oprerations(array);
            int[] array1 = new int[rnd.Next(5, 10)];
            
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(10, 100);
            }
            Console.WriteLine("Массивы для суммы, произведения и разности ");
            Console.WriteLine("");
            Console.WriteLine("Первый массив");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($" {array1[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = rnd.Next(10, 100);
            }
            Console.WriteLine("Второй массив");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($" {array2[i]} ");
            }
            Console.WriteLine();
            OperationsOnArrays(array1, array2);
        }
    }
}