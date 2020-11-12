using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Delegates
{
    class GeneralOffice
    {
        public static void Max(int[] array)
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine();
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }

            }
            Console.WriteLine($"Мax: |{max}| ");
        }
        public static void Sum(int[] array)
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum: |{sum}|");
        }
        public static void Sortirovka(int[] array)
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine();
            Console.Write($"Sortirovka: ");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" |{array[i]}| ");
            }
            Console.WriteLine();
        }
        public static void SummMass(int[] array1, int[] array2)
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine();
            Console.Write("Сумма двух массив: ");
            int[] array = new int[array1.Length];
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = array1[i] + array2[i];
                Console.Write($"|{ array[i] }| ");
            }
            Console.WriteLine();
        }
        public static void RazNost(int[] array1, int[] array2)
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine();
            Console.Write("Разность двух массив : " );
            int[] array = new int[array1.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array1[i] - array2[i];
                Console.Write($"|{ array[i] }| ");
            }
            Console.WriteLine();
        }
        public static void Proiz(int[] array1, int[] array2)
        {
            Console.WriteLine("________________________________________________________");
            Console.WriteLine();
            Console.Write("Произведение двух массив : ");
            int[] array = new int[array1.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array1[i] * array2[i];
                Console.Write($"|{ array[i] }| ");
            }
            Console.WriteLine();
            Console.WriteLine("________________________________________________________");
        }

    }
}
