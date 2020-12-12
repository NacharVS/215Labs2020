using System;
using System.Collections.Generic;
using _215Labs2020.Шагимуратова.Bank;

namespace _215Labs2020
{
    class Program
    {

        static void Main(string[] args)
        {

           int numer = 0;
            List<bank> kleints = new List<bank>();
            kleints.Add(new bank("Masha","Domova",23000,"89874568945",12,03,1998, kleints.Count));
            kleints.Add(new bank("Natalia", "Nikonova", 45000, "89874523945", 22, 12, 2000, kleints.Count));
            kleints.Add(new bank("Rima", "Shveth", 10000, "79874523445", 07, 11, 2001, kleints.Count));
            kleints.Add(new bank("Mark", "Drob", 90000, "89634523425", 17, 04, 1950, kleints.Count));
            
            































            //int[] mass = new int[10];
            //Random rnd = new Random();
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    mass[i] = rnd.Next(10);
            //    Console.Write($" {mass[i]}");
            //}

            //Console.WriteLine();

            //int[] mass1 = new int[10];
            //Random rnd1 = new Random();
            //for (int i = 0; i < mass1.Length; i++)
            //{
            //    mass1[i] = rnd1.Next(10);
            //    Console.Write($" {mass1[i]}");
            //}

            //Console.WriteLine();

            //BranchOffice.Invoke(mass);
            //BranchOffice.Invoke2(mass,mass1);



        }

    }

}
