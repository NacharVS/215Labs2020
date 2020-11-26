using _215Labs2020.Ohotnicov;
using _215Labs2020.Ohotnicov.Delegates;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace _215Labs2020
{
    class Program
    {
        public delegate bool Positive(int x);
        public static int Operation(Positive x, int y)
        {

            return y + 10;

        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int Result = Operation(x => x > 0, 5) ;
            Console.WriteLine(Result);
        }
    }
}
