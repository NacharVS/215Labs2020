using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _215Labs2020.Galyautdinov
{
    class AsyncSum
    {
        public static void mainMethod()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];
            Asum(array1, array2, array3);
            Console.Write("Сколько элементов вывести ");
            int kol = int.Parse(Console.ReadLine());
            for (int i = 0; i < kol; i++)
            {
                Console.Write(array3[i] + " ");
            }
        }
        static void sum(int[] array1, int[] array2, int[] array3)
        {
            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
            }
        }
        static async void Asum(int[] array1, int[] array2, int[] array3)
        {
            await Task.Run(() => sum(array1,array2,array3));
            
        }
    }
}
