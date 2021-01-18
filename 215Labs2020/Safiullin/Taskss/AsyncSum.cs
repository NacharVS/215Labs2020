using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020.Safiullin.Taskss
{
    class AsyncSum
    {
        static Random rnd = new Random();
        static int[] summ = new int[10];
        public static void Summ()
        {
            int[] mass1 = new int[10];
            int[] mass2 = new int[10];
            for (int i = 0; i < mass1.Length; i++)
            {
                mass1[i] = rnd.Next(0, 10);
                Console.Write(mass1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < mass1.Length; i++)
            {
                mass2[i] = rnd.Next(0, 10);
                Console.Write(mass2[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < summ.Length; i++)
            {
                Thread.Sleep(2);
                summ[i] = rnd.Next(0, 10);
                Console.Write(summ[i] + " ");
            }
        }
        public async void Mass()
        {
            await Task.Run(() => Summ());
        }
        public static void MainMethod()
        {
            Summ();
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(summ[i] + " ");
            }
        }
    }
}
