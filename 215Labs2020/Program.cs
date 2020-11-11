using _215Labs2020.Shakirovа;
using _215Labs2020.Shakirovа.bank;
using System;

namespace _215Labs2020
{
    class Program
    {
        public static int[] mass(int dlinamass, int MaxRandomValue)
        {
            int[] mas = new int[dlinamass];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(MaxRandomValue);
                Console.WriteLine(mas[i]);
            }
            return mas;
        }
        public static int[] mass2(int dlinamass, int MaxRandomValue)
        {
            int[] mas = new int[dlinamass];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(MaxRandomValue);
                Console.WriteLine(mas[i]);
            }
            return mas;
        }

    }
}
