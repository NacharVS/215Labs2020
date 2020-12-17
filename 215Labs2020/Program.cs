using System;
using _215Labs2020.Garaev.Bank;
using _215Labs2020.Garaev.Delegates;
using _215Labs2020.Garaev;
using _215Labs2020.Garaev.Strategy_games;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace _215Labs2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankPerson.Bank_deysviya();
            //ObservableCollection.Main1();
            //int[] mass2 = new int[10];
            //Random rnd = new Random();
            //for (int i = 0; i < mass2.Length; i++)
            //{
            //    mass2[i] = rnd.Next(10, 99);
            //    Console.Write($"{mass2[i]} ");
            //}
            //for (int i = 0; i < mass2.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < mass2.Length; j++)
            //    {
            //        if (mass2[i] > mass2[j])
            //        {
            //            int bufer = mass2[i];
            //            mass2[i] = mass2[j];
            //            mass2[j] = bufer;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < mass2.Length; i++)
            //{
            //    Console.Write($"{mass2[i]} ");
            //}
            Tasks.Task();
            Console.ReadKey();
        }
    }
}
