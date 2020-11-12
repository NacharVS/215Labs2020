using System;
using _215Labs2020.Шагимуратова.Bank;
using _215Labs2020.Шагимуратова.Delegates;

namespace _215Labs2020
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] mass = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(10);
                Console.Write($" {mass[i]}");
            }

            Console.WriteLine();

            int[] mass1 = new int[10];
            Random rnd1 = new Random();
            for (int i = 0; i < mass1.Length; i++)
            {
                mass1[i] = rnd1.Next(10);
                Console.Write($" {mass1[i]}");
            }

            Console.WriteLine();

            BranchOffice.Invoke(mass);
            BranchOffice.Invoke2(mass,mass1);



        }
       
    }

}
