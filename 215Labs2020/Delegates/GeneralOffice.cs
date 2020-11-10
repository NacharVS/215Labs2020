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
            int[] mas = new int[2];
            Random rnd = new Random(0);
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 2);
                sum += mas[i];
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine(sum);
        }
        public static void mul()
        {
            int[] mas = new int[2];
            Random rnd = new Random(0);
            int mul = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 2);
                mul *= mas[i];
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine(mul);
        }

}   }
