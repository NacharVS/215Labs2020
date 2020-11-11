using System;
using _215Labs2020.Imamov;

namespace _215Labs2020
{
    class Program
    {
        public static int[] array1 = new int[5];
        public static int[] array2 = new int[5];
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < Program.array1.Length; i++)
            {
                Program.array1[i] = rnd.Next(1, 9);
            }
            for (int i = 0; i < Program.array2.Length; i++)
            {
                Program.array2[i] = rnd.Next(1, 9);
            }
            General.Operations();
        }
    }
}
