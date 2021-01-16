using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020.Ibragimov
{
    class Asuncsum
    {

           int[] mass = new int[5];
          int[] mass1 = new int[5];

        internal static void Asuncsum1()
        {
            throw new NotImplementedException();
        }

        int[] sum = new int[5];

        public static  void Asuncsum1(int[] sum)
        {
            Task task1 = new Task(() =>
            {

                Random rnd = new Random();

                for (int i = 0; i < 5; i++)
                {

                    sum[i] = rnd.Next(1, 10);
                    Thread.Sleep(100);
                    sum[i] = rnd.Next(1, 10);
                    Thread.Sleep(100);
                    sum[i] = sum[i] + sum[i];
                    Console.WriteLine($"mass 1: {sum[i]} ");
                    Console.WriteLine($"mass 2: {sum[i]} ");
                    Console.WriteLine($"Sum: {sum[i]} ");
                }
                Console.WriteLine();

            }
            );

        }
 
      


    }
}







