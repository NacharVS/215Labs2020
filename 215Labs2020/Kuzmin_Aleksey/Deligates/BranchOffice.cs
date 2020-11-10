using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.Deligates
{
    class BranchOffice
    {
        public static void Ex1(int[] mass)
        {
            for (int i = 0; i < mass.Length-1-i; i++)
            {                
                if (mass[i]<mass[i+1])
                {
                    int a = mass[i];                    
                    mass[i] = mass[i + 1];
                    mass[i+1]=a;
                }
            }
            foreach (var item in mass)
            {
                Console.WriteLine(item);
            }
        }
    }
}
