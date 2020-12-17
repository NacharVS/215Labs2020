using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _215Labs2020.Garaev
{
    class Tasks
    {
        public static void Task()
        {
            Random rnd = new Random();
            int[] mass1 = new int[10];
            int[] mass2 = new int[10];
            int[] mass3 = new int[10];
            Task task1 = new Task(()=>
            {
                for (int i = 0; i < mass1.Length; i++)
                {
                    mass1[i] = rnd.Next(10,99);
                }
                for (int i = 0; i < mass1.Length; i++)
                {
                    Console.WriteLine($"Mass1 [{i}]: {mass1[i]}");
                }
                Console.WriteLine();
            });
            Task task2 = new Task(() =>
            {
                for (int i = 0; i < mass2.Length; i++)
                {
                    mass2[i] = rnd.Next(10, 99);
                }
                for (int i = 0; i < mass2.Length; i++)
                {
                    Console.WriteLine($"Mass2 [{i}]: {mass2[i]}");
                }
                Console.WriteLine();
            });
            Task task3 = new Task(() =>
            {
                for (int i = 0; i < mass1.Length - 1; i++)
                {
                    for (int j = i + 1; j < mass1.Length; j++)
                    {
                        if (mass1[i] > mass1[j])
                        {
                            int bufer = mass1[i];
                            mass1[i] = mass1[j];
                            mass1[j] = bufer;
                        }
                    }
                }
            });
            Task task4 = new Task(() =>
            {
                for (int i = 0; i < mass2.Length - 1; i++)
                {
                    for (int j = i + 1; j < mass2.Length; j++)
                    {
                        if (mass2[i] > mass2[j])
                        {
                            int bufer = mass2[i];
                            mass2[i] = mass2[j];
                            mass2[j] = bufer;
                        }
                    }
                }
            });
            task1.Start();
            task1.Wait();
            task2.Start();
            task2.Wait();
            for (int i = 0; i < mass3.Length; i++)
            {
                mass3[i] = mass1[i] + mass2[i];
            }
            task3.Start();
            task3.Wait();
            task4.Start();
            task4.Wait();
            Console.WriteLine("Summa: ");
            for (int i = 0; i < mass3.Length; i++)
            {
                Console.Write($"{mass3[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Sortirovka");
            Console.Write("mass1: ");
            for (int i = 0; i < mass1.Length; i++)
            {
                Console.Write($"{mass1[i]} ");
            }
            Console.WriteLine();
            Console.Write("mass2: ");
            for (int i = 0; i < mass2.Length; i++)
            {
                Console.Write($"{mass2[i]} ");
            }
        }
    }
}
