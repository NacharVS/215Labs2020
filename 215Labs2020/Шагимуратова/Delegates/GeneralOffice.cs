using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Delegates
{
    class GeneralOffice
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
            Console.WriteLine(" ");
        }
    public static void max(int[] mass)
        {
            int max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > max) max = mass[i];
            }
            Console.WriteLine($"Максимально число {max}");
            Console.WriteLine(" ");

        }
        public static void summ (int[] mass)
        {
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
               
                    summ += mass[i];
            }
            Console.WriteLine($"Summ = {summ}");
            Console.WriteLine(" ");

        }
        public static void Sortirovka(int[] mass)
        {
            Console.Write($" sortirovka ");
            int buff;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {

                    if (mass[i] < mass[j])
                    {
                        buff = mass[i];
                        mass[i] = mass[j];
                        mass[j] = buff;

                    }
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($" {mass[i]}");
                
                
            }

           
        }
        
        
        public static void summa_massivov(int[] mass, int[] mass1)
        {
            Console.Write($" summ 2 array ");

            int[] massum = new int[mass.Length];
            Random rnd = new Random();
            for (int i = 0; i < massum.Length; i++)
            {
                massum[i] = mass[i] + mass1[i];
                
                Console.Write($"{massum[i]} ");
            }
            Console.WriteLine(" ");

        }

        public static void vichetanie_massivov(int[] mass, int[] mass1)
        {
            Console.Write($" vichetanie 2 array ");
            int[] massum = new int[mass.Length];
            Random rnd = new Random();
            for (int i = 0; i < massum.Length; i++)
            {
                massum[i] = mass[i] - mass1[i];
                Console.Write($"{massum[i]} ");
            }
            Console.WriteLine(" ");

        }

        public static void proizv_massivov(int[] mass, int[] mass1)
        {
            int[] array3 = new int[10];
            Console.WriteLine($"произведение ");

            for (int i = 0; i < mass1.GetLength(0); i++)
            {
                for (int j = 0; j < mass1.GetLength(0); j++)
                {
                    array3[i] = mass[i] + mass1[j];
                    Console.Write($" {array3[i]} ");
                }
                Console.WriteLine();

            }

        }

    }

}
