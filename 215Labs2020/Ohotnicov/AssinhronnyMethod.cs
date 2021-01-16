using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020.Ohotnicov
{
    class AssinhronnyMethod
    {
        public static void MainMethod()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] arraysumm = new int[10];
            Summ(array1, array2, arraysumm);
            Console.WriteLine("Количество эллементов:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(arraysumm[i]);
            }
        }
        public static void SumArrays(int[] array1, int[] array2, int[] arraysumm)
        {
            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 10);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(1, 10);
            }
            for (int i = 0; i < arraysumm.Length; i++)
            {
                arraysumm[i] = array1[i] + array2[i];
            }
        }
        public static async void Summ(int[] array1, int[] array2, int[] arraysumm)
        {
            await Task.Run(() => SumArrays(array1, array2, arraysumm));
        }
    }
}
 
