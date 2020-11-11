using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Shakirovа.delegates
{
    class General
    {
        //public static int[] mass(int dlinamass, int MaxRandomValue)
        //{
        //    int[] mas = new int[dlinamass];
        //    Random rnd = new Random();
        //    for (int i = 0; i < mas.Length; i++)
        //    {
        //        mas[i] = rnd.Next(MaxRandomValue);
        //        Console.WriteLine(mas[i]);
        //    }
        //    return mas;
        //}
        //public static int[] mass2(int dlinamass, int MaxRandomValue)
        //{
        //    int[] mas = new int[dlinamass];
        //    Random rnd = new Random();
        //    for (int i = 0; i < mas.Length; i++)
        //    {
        //        mas[i] = rnd.Next(MaxRandomValue);
        //        Console.WriteLine(mas[i]);
        //    }
        //    return mas;
        //}
        public static void max(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            Console.WriteLine($"Максимально число {max}");
        }
        public static void summ(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {

                summ += array[i];
            }
            Console.WriteLine($"Summ = {summ}");
        }
        public static void Sortirovka(int[] array)
        {
            int buff;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {

                    if (array[i] < array[j])
                    {
                        buff = array[i];
                        array[i] = array[j];
                        array[j] = buff;

                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
        }
        public static void summa_massivov(int[] array, int[] array2)
        {
            int[] massum = new int[array.Length];
            Random rnd = new Random();
            for (int i = 0; i < massum.Length; i++)
            {
                massum[i] = array[i] + array2[i];
                Console.WriteLine(massum[i]);
            }
        }

        public static void vichetanie_massivov(int[] array, int[] array2)
        {
            int[] massum = new int[array.Length];
            Random rnd = new Random();
            for (int i = 0; i < massum.Length; i++)
            {
                massum[i] = array[i] - array2[i];
                Console.WriteLine(massum[i]);
            }

        }
        public static void ymnozhenie(int[] array, int[] array2)
        {

        }
    }
}
