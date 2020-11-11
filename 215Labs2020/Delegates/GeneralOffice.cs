using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Delegates
{
    class GeneralOffice
    {
        public static void max()
        {
            int[] z = { 1, 6, 9, 14, 15, 23 };
            Array.Sort(z);
            int max = z[z.Length - 1];
            Console.WriteLine(max);

        }
        public static void sum()
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (int value in numbers)
            {
                sum += value;
            }

            Console.WriteLine("Сумма элементов массива: " + sum);
        }
        public static void sor()
        {
            Random rnd = new Random();
            int[] sor = new int[2];
            for (int z =0; z < sor.Length; z++)
            {
                sor[z] = rnd.Next(1, 5);
            }
            int xx;
            for(int z = 0; z < sor.Length; z++)
            {
                for (int k = 0; k < sor.Length - 1; k++)
                {
                    if (sor[k] > sor[k + 1])
                    {
                        xx = sor[k];
                        sor[k] = sor[k + 1];
                        sor[k + 1] = xx;
                    }
                }
                for (int i = 0; i < sor.Length;i++)
                {
                    Console.WriteLine(sor[i]);
                }
            }
        }
        public static void summas(int[] mas1, int[] mas2)
        {
            int[] mas = new int[mas1.Length];
            for (int i = 0; i < mas1.Length - 1; i++)
            {
                mas[i] = mas1.Length + mas2[i];
            }
            Console.WriteLine();
            Console.WriteLine("sum 2 mas");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]}");
            }
            Console.WriteLine();
        }

        public static void mul()
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
        public static void sub()
        {
            Console.WriteLine("Enter 1 mass");
            int[] mass = new int[2];
            for (int z = 0; z < 2; z++)
            {
                Console.Write("mass[{0}]=', z");
                mass[z] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter 2 mass");
            int[] mass2 = new int[2];
            for (int z = 0; z < 2; z++)
            {
                Console.Write("mass2[{0}]=', z");
                mass2[z] = int.Parse(Console.ReadLine());
            }
            int[] sub = new int[2];
            for (int z = 0; z < 2; z++)
            {
                sub[z] = mass[z] - mass2[z];
            }
            Console.WriteLine("sub");
            foreach (var z in sub)
                Console.WriteLine(z);
        }
    }
}
