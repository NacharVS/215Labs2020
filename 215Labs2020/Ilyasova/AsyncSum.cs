using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _215Labs2020.Ilyasova
{
    class AsyncSum
    {
        public static void Mainmethod()
        {
            int[] a1 = new int[10];
            int[] a2 = new int[10];
            int[] asum = new int[10];
            AsyncSm(a1, a2, asum);
            Console.WriteLine("Enter the numbers of elements");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(asum[i]);
            }
        }
        public static void Sum(int[] array1, int[] array2, int[] arraysum)
        {
            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 10);
                array2[i] = rnd.Next(1, 10);
                arraysum[i] = array1[i] + array2[i];
            }
        }
        public static async void AsyncSm(int[] mus1, int[] mus2, int[] sum)
        {
            await Task.Run(() => Sum(mus1, mus2, sum));
        }
    }
}
