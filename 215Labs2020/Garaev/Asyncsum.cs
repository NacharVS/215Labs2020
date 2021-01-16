using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _215Labs2020.Garaev
{
    class Asyncsum
    {
        static int[] mass1;
        static int[] mass2;
        static int[] mass3;
        static void generation_sum()
        {
            Random rnd = new Random();
            for (int i = 0; i < mass1.Length; i++)
            {
                mass1[i] = rnd.Next(0,100);
            }
            for (int i = 0; i < mass2.Length; i++)
            {
                mass2[i] = rnd.Next(0, 100);
            }
            for (int i = 0; i < mass3.Length; i++)
            {
                mass3[i] = mass1[i] + mass2[i];
            }
        }
        async static void generation_sumAsync()
        {
            await Task.Run(()=>generation_sum());
        }
        public static void mainMethod()
        {
            mass1 = new int[10];
            mass2 = new int[10];
            mass3 = new int[10];
            generation_sumAsync();
            int interval = int.Parse(Console.ReadLine());
            for (int i = 0; i < interval; i++)
            {
                Console.Write($"{mass3[i]} ");
            }
        }
    }
}
