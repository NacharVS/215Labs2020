﻿using System;
using System.Security.Cryptography.X509Certificates;
using _215Labs2020.Sabirov;
using _215Labs2020.Sabirov.StrategyGame;
using _215Labs2020.Sabirov.User;

namespace _215Labs2020
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Первый массив:");
            //Random rnd = new Random();
            //GeneralOffice.array = new int[5];
            //for (int i = 0; i < GeneralOffice.array.Length; i++)
            //{
            //    GeneralOffice.array[i] = rnd.Next(1, 9);
            //    Console.Write($"{GeneralOffice.array[i]} ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Второй массив:");

            //GeneralOffice.array2 = new int[5];
            //for (int i = 0; i < GeneralOffice.array2.Length; i++)
            //{
            //    GeneralOffice.array2[i] = rnd.Next(1, 9);
            //    Console.Write($"{GeneralOffice.array2[i]} ");
            //}
            //Console.WriteLine();

            //BranchOffice.gal2(GeneralOffice.array, GeneralOffice.array2);
            //BranchOffice.gal(GeneralOffice.array);
            User.Check();
        }

       
    }

}
