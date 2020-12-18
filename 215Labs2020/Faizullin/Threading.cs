using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020.Faizullin
{
    class Threading
    {
        public static void Azatmethod()
        {
            int[] sum = new int[4];
            int[] mass1 = new int[4];
            int[] mass2 = new int[4];
            Task task1 = new Task(() => Generationmass());
            Task task2 = new Task(() => summass());
            void Generationmass()
            {
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
            }
            void summass()
            {

                for (int v = 0; v < mass1.Length; v++)
                {
                    Thread.Sleep(10);
                    sum[v] = mass1[v] + mass2[v];

                }
            }
            task1.Start();
            task2.Start();
            task2.Wait();
            int buffer;
            for (int v = 0; v < sum.Length; v++)
            {

                for (int j = 0; j < sum.Length - 1; j++)
                {
                    if (sum[j] > sum[j + 1])
                    {
                        buffer = sum[j];
                        sum[j] = sum[j + 1];
                        sum[j + 1] = buffer;

                    }

                }

            }
            for (int v = 0; v < sum.Length; v++)
            {
                Console.WriteLine(sum[v];
            }
        }
    }
}

