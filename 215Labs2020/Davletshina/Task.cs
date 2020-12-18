﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _215Labs2020.Davletshina
{
    class Task
    {
        private Action p;

        public Task(Action p)
        {
            this.p = p;
        }

        public static void Run()
        {
            Random rnd = new Random();
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];

            Task task = new Task(() =>
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rnd.Next(1, 9);
                }
            });
            Task task2 = new Task(() =>
            {
                Thread.Sleep(1000);
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = rnd.Next(1, 9);
                }
            });
            Task task3 = new Task(() =>
            {
                Thread.Sleep(2000);
                for (int i = 0; i < array3.Length; i++)
                {
                    array3[i] = array1[i] + array2[i];
                }
            });

            Console.Write("1 массив: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            Console.Write("2 массив: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Суммированный массив массива: ");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
            
            int temp;
            for (int i = 0; i < array3.Length - 1; i++)
            {
                for (int j = i + 1; j < array3.Length; j++)
                {                      
                    if (array3[i] > array3[j])
                    {
                        temp = array3[i];
                        array3[i] = array3[j];
                        array3[j] = temp;
                    }
                }
            }
            Console.Write("Вывод отсортированного массива: ");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + " ");
            }
        }
    }
}