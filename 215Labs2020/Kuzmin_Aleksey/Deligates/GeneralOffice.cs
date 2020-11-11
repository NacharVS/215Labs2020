using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.Deligates
{
    class GeneralOffice
    {
        public static int Ex4(int[] mass1, int[] mass2)
        {
            int[] mass_summ = new int[5];
            for (int i = 0; i < mass1.Length; i++)
            {
                mass_summ[i] = mass1[i] + mass2[i];
                Console.Write($"{mass_summ[i]} ");
            }            
            Console.WriteLine();
            return 0;
        }
        public static int Ex5(int[] mass1, int[] mass2)
        {
            int[] mass_diff = new int[5];
            for (int i = 0; i < mass1.Length; i++)
            {
                mass_diff[i] = mass1[i] - mass2[i];
                Console.Write($"{mass_diff[i]} ");
            }            
            Console.WriteLine();
            return 0;
        }
    }
}
