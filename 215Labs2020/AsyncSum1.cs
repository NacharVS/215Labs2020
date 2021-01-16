using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp29
{
    class AsyncSum1
    {
        public static void Mainmethod()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] arraysum = new int[10];
            AsyncSum(array1, array2, arraysum);
            Console.WriteLine("Введите колмчество элементов");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(arraysum[i]);
            }

        }
        public static void SumArray1(int[] array1, int[] array2, int[] arraysum)
        {
            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 10);

            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(1, 10);

            }

            for (int i = 0; i < arraysum.Length; i++)
            {
                arraysum[i] = array1[i] + array2[i];
            }


        }
        public static async void AsyncSum(int[] array1, int[] array2, int[] arraysum)
        {
            await Task.Run(() => SumArray1(array1, array2, arraysum));
        }

    }
}
