using System;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class ParallelStreams
    {
        public static void Program()
        {
            Random rnd = new Random();
            int[] mass1 = new int[5];
            int[] mass2 = new int[5];
            int[] summ = new int[5];
            Task task1 = new Task(() =>
            {
                for (int i = 0; i < mass1.Length; i++)
                {
                    mass1[i] = new int();
                    mass2[i] = new int();
                    mass1[i] = rnd.Next(0, 10);
                    mass2[i] = rnd.Next(0, 10);
                    Console.WriteLine($"{mass1[i]} {mass2[i]}");
                }
            });
            Task task2 = new Task(() =>
            {
                for (int i = 0; i < summ.Length; i++)
                {
                    Thread.Sleep();
                    summ[i] = mass1[i] + mass2[i];
                    Console.WriteLine(summ[i]);
                }
            });
            Task task3 = new Task(() =>
            {
                
                for (int i = 0; i < summ.Length; i++)
                {
                    Thread.Sleep(8);
                    for (int j = 0; j < summ.Length; j++)
                    {
                        if (summ[i]<summ[j])
                        {
                            int a = summ[i];
                            summ[i] = summ[j];
                            summ[j] = a;
                        }
                    }
                }
                foreach (var item in summ)
                {
                    Console.WriteLine(item);
                }
            });
            task1.Start();
            task2.Start();
            task3.Start();
            task3.Wait();
        }
    }
}
