using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _215Labs2020.Imamov
{
    class AsyncSum
    {
        public static void Main()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] sum = new int[10];
            AsyncSums(array1, array2, sum);
            Console.WriteLine("Enter the amount of elems: ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i< amount; i++)
            {
                Console.WriteLine(sum[i]);
            }
        }
        static void ArraySum(int[] array1, int[] array2, int[] sum)
        {
            Random rnd = new Random();
            for (int i = 0; i <array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = array1[i] + array2[i];
            }
        }
        static async void AsyncSums(int[] array1, int[] array2, int[] sum)
        {
            await Task.Run(() => ArraySum(array1, array2, sum));
        }
    }
}
