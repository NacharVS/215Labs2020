using _215Labs2020.Hasanov;
using _215Labs2020.Zifarov.Delegates;
using System;

namespace _215Labs2020.Zifarov
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 99);
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            Random rnd1 = new Random();
            int[] array2 = new int[10];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd1.Next(1, 99);
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine();
            BranchOffice.ab(array1);
            Bank.LaunchBank();
        }
        
    }
}
