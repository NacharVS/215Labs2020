using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov
{
    class Multitask
    {
        public static void Start()
        {
            int[] mass = new int[6];
            int[] mass2 = new int[6];
            int[] sum = new int[6];
            Console.WriteLine("Main thread");
            Task task1 = new Task(() =>
            {
                Random rnd = new Random();
                for (int i = 0; i < 6; i++)
                {
                    mass[i] = rnd.Next(1, 10);
                    Thread.Sleep(1000);
                    mass2[i] = rnd.Next(1, 10);
                    Thread.Sleep(2000);
                    sum[i] = mass[i] + mass2[i];
                    Console.WriteLine($"Mass 1: {mass[i]} ");
                    Console.WriteLine($"Mass 2: {mass2[i]} ");
                    Console.WriteLine($"Sum of mass: {sum[i]} ");
                }
                {
                    Console.WriteLine();
                }
            }
            );
            task1.Start();
            task1.Wait();

            int sort;
            for (int i = 0; i < sum.Length - 1; i++)
            {
                for (int r = i + 1; r < sum.Length; r++)
                {
                    if (sum[i] > sum[r])
                    {
                        sort = sum[i];
                        sum[i] = sum[r];
                        sum[r] = sort;
                    }
                }
            }
            Console.WriteLine("Sorted mass");
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine(sum[i]);
            }
            Console.ReadLine();
        }
    }
}

