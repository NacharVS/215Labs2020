using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020
{
    class AsyncSum
    {
        public static void mainmethod()
        {
            
            int[] sum = new int[10];
            int[] mass1 = new int[10];
            int[] mass2 = new int[10];
            


            Random rnd = new Random();
            for (int v = 0; v < mass1.Length; v++)
            {
                mass1[v] = rnd.Next(1, 10);
                Console.WriteLine(mass1[v]);

            }
            Console.WriteLine();
            for (int v = 0; v < mass2.Length; v++)
            {
                mass2[v] = rnd.Next(1, 10);
                Console.WriteLine(mass2[v]);
            }
            Console.WriteLine();
            for (int v = 0; v < mass1.Length; v++)
            {
                sum[v] = mass1[v] + mass2[v];
                Console.WriteLine(sum[v]);
            }
           
        }


        public static async void AsyncSum(int[] mass1, int[] mass2, int[] sum)
        {
            await Task.Run(() => mainmethod());
        }
    }
}
