using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020
{
    class Threading
    {
        public static void Tasks()
        {
            int[] sum = new int[5];
            int[] mass1 = new int[5];
            int[] mass2 = new int[5];
            Task task1 = new Task(() => Generationmass());
            Task task2 = new Task(() => summass());
            void Generationmass()
            {
                Random rnd = new Random();
                for (int i = 0; i < mass1.Length; i++)
                {
                    mass1[i] = rnd.Next(1, 10);
                    mass2[i] = rnd.Next(1, 10);

                }

            }
            void summass()
            {

                for (int i = 0; i < mass1.Length; i++)
                {
                    Thread.Sleep(1);
                    sum[i] = mass1[i] + mass2[i];

                }


            }
            task1.Start();
            task2.Start();
            task2.Wait();
            int buffer;
            for (int i = 0; i < sum.Length; i++)
            {


                for (int j = 0; j < sum.Length - 1; j++)
                {
                    if (sum[j] > sum[j + 1])
                    {
                        buffer = sum[j];
                        sum[j] = sum[j + 1];
                        sum[j + 1] = buffer;

                    }

                }

            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine(sum[i]);
            }
        }
    }
}
