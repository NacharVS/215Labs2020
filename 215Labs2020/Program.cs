using System;
using _215Labs2020.Шагимуратова.Bank;

namespace _215Labs2020
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10);
                Console.Write($" {array[i]}");
            }

            Console.WriteLine();
           
            



        }
        
    }

}
