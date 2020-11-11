using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.Deligates
{
    class BranchOffice
    {
        public static int Ex1(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length-1; j++)
                {
                    if (mass[j] < mass[i])
                    {
                        int a = mass[j];
                        mass[j] = mass[i];
                        mass[i] = a;
                    }
                }                
            }
            return mass[0];
            
        }
        public static int Ex2(int[] mass)
        {
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                summ += mass[i];
            }
            return summ;
        }
        public static int Ex3(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length - 1; j++)
                {
                    if (mass[j] > mass[i])
                    {
                        int a = mass[j];
                        mass[j] = mass[i];
                        mass[i] = a;
                    }
                }
            }
            foreach (var item in mass)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            return 0;

        }

    }
}
