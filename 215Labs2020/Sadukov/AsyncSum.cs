using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020.Sadukov
{
    class AsyncSum
    {
      
        public static void Secondary(int[] mass, int[] mass1,int[]sum)
        {

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                mass[i] = rnd.Next(1, 10);

                Console.WriteLine($"mass 1: {mass[i]} ");

            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {

                mass1[i] = rnd.Next(1, 10);

                Console.WriteLine($"mass 2: {mass1[i]} ");
            }
            Console.WriteLine();
      
            for (int i = 0; i < 10; i++)
            {
                sum[i] = mass[i] + mass1[i];
                Console.WriteLine($"Sum: {sum[i]} ");
            }
            Console.WriteLine();
        }
        public static async void SumAsync(int[] mass, int[] mass1, int[] sum)
        {
            await Task.Run(() => Secondary(mass, mass1, sum));
        }
        public static void asd(int[]sum)
        {
            int x = int.Parse(Console.ReadLine());
            int[] users = new int[x];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = sum[i];
                Console.WriteLine($" {users[i]}");
            }
        }

       
}
}

