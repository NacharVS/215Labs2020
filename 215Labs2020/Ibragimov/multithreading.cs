using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020.Ibragimov
{
    class multithreading
    {
        public static void A()
        {
            int[] mass = new int[5];
            int[] mass1 = new int[5];
            int[] sum = new int[5];
            Console.WriteLine("Main thread");
            Task task1 = new Task(() =>
            {

                Random rnd = new Random();

                for (int i = 0; i < 5; i++)
                {

                    mass[i] = rnd.Next(1, 10);
                    Thread.Sleep(100);
                    mass1[i] = rnd.Next(1, 10);
                    Thread.Sleep(200);
                    sum[i] = mass[i] + mass1[i];
                    Console.WriteLine($"mass 1: {mass[i]} ");
                    Console.WriteLine($"mass 2: {mass1[i]} ");
                    Console.WriteLine($"Sum: {sum[i]} ");
                }
                Console.WriteLine();

            }
            );
            task1.Start();
            task1.Wait();

            int temp;
            for (int i = 0; i < sum.Length - 1; i++)
            {
                for (int j = i + 1; j < sum.Length; j++)
                {
                    if (sum[i] > sum[j])
                    {
                        temp = sum[i];
                        sum[i] = sum[j];
                        sum[j] = temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine(sum[i]);
            }

        }
    }
}
