using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Delegates
{
    class GeneralOffice
    {
        public static void max(int[] mass1)
        {
            int[] z = { 1, 6, 9, 14, 15, 23 };
            Array.Sort(z);
            int max = z[z.Length - 1];
            Console.WriteLine(max);

        }
        public static void sum(int[] mass1)
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i =0; i < mass1.Length; i++)
            {
                sum += mass1[i];
            }

            Console.WriteLine(" sum");
        }
        public static void sor(int[] mass1)
        {
            Random rnd = new Random();
            int[] mass= new int[2];
            for (int z =0; z < mass1.Length; z++)
            {
                mass1[z] = rnd.Next(1, 5);
            }
            int xx;
            for(int z = 0; z < mass1.Length; z++)
            {
                for (int k = 0; k < mass1.Length - 1; k++)
                {
                    if (mass1[k] > mass1[k + 1])
                    {
                        xx = mass1[k];
                        mass1[k] = mass1[k + 1];
                        mass1[k + 1] = xx;
                    }
                }
                for (int i = 0; i < mass1.Length;i++)
                {
                    Console.WriteLine(mass1[i]);
                }
            }
        }
        public static void summas(int[] mass1, int[] mass2)
        {
            int[] mas = new int[mass1.Length];
            for (int i = 0; i < mass1.Length - 1; i++)
            {
                mas[i] = mass1.Length + mass2[i];
            }
            Console.WriteLine();
            Console.WriteLine("sum 2 mas");
            for (int i = 0; i < mass2.Length; i++)
            {
                Console.Write($"{mass2[i]}");
            }
            Console.WriteLine();
        }

        public static void mul(int[] mass1, int[] mass2)
        {
            Console.WriteLine("Enter how many numbers");
            int z = int.Parse(Console.ReadLine());
            int[] num = new int[z];
            int mul = 1;
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Please enter an integer");
                mul *= int.Parse(Console.ReadLine());
            }
            Console.WriteLine(mul);
            Console.ReadLine();
        }
        public static void sub(int[] mass1, int[] mass2)
        {
            int[] mass = new int[mass1.Length];
            for (int i = 0; i < mass1.Length; i++)
            {
                mass[i] = mass1[i] - mass2[i];
            }
            Console.WriteLine("sub");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("mass");
            }
            Console.WriteLine();

        }
    }
}
