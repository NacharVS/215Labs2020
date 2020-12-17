using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020.Sadukov
{
    public class multithreading
    {
        public static void A()
        {
            Console.WriteLine("Main thread");
            Task task1 = new Task(() =>
            {
                
                Random rnd = new Random();
                int[] mass = new int[5];
                int[] mass1 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    
                    mass[i] = rnd.Next(1, 10);
                    Thread.Sleep(1000);
                    mass1[i] = rnd.Next(1, 10);
                    Console.WriteLine($"mass 1: {mass[i]} ");
                    Console.WriteLine($"mass 2: {mass1[i]} ");
                }
                Console.WriteLine();

            }
            );
            

            
            task1.Start();
            task1.Wait();
  



        }


    }
}
