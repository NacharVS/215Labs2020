using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using _215Labs2020.Garaev;

namespace _215Labs2020.Garaev.Delegates
{
    class BranchOffice
    {
       
        public static void max(int[] mass1)
        {
            int max = 0;
            for (int i = 0; i < mass1.Length; i++)
            {
                if (mass1[i]>max)
                {
                    max = mass1[i];
                }
            }
            Console.WriteLine($"Максимальное значение первого массива: {max}");
            //Trainee tr1;
            //tr1 = GeneralOffice.Max_el_mass;
            //tr1(max);
        }
        public static void Summ_el(int[] mass1)
        {
            int sum = 0;
            for (int i = 0; i < mass1.Length; i++)
            {
                sum += mass1[i];
            }
            Console.WriteLine($"Сумма элементов первого массива: {sum}");
            //Trainee tr1;
            //tr1 = GeneralOffice.Summ_el_mass;
            //tr1(sum);
        }
        public static void Sortirovka(int[] mass1)
        {
            int bufer = 0;
            for (int i = 0; i < mass1.Length; i++)
            {
                for (int j = 1; j < mass1.Length-i; j++)
                {
                    if (mass1[j-1]> mass1[j])
                    {
                        bufer = mass1[j];
                        mass1[j] = mass1[j-1];
                        mass1[j-1] = bufer;
                    }
                }
            }
            string mass = "";
            for (int i = 0; i < mass1.Length; i++)
            {
                mass += $"{Convert.ToString(mass1[i])} ";
            }
            //MASS tr1;
            //tr1 = GeneralOffice.Sortirovka;
            //tr1(mass);
        }
        public static void Summ_mass(int[] mass1, int[] mass2)
        {
            int[] mass = new int[mass1.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = mass1[i] + mass2[i];
            }
            string massiv = "";
            for (int i = 0; i < mass1.Length; i++)
            {
                massiv += $"{Convert.ToString(mass[i])} ";
            }
            //MASS tr1;
            //tr1 = GeneralOffice.Summ_massiv;
            //tr1(massiv);
        }
        public static void raznost(int[] mass1, int[] mass2)
        {
            int[] mass = new int[mass1.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = mass1[i] - mass2[i];
            }
            string massiv = "";
            for (int i = 0; i < mass1.Length; i++)
            {
                massiv += $"{Convert.ToString(mass[i])} ";
            }
            //MASS tr1;
            //tr1 = GeneralOffice.Raznost_massiv;
            //tr1(massiv);
        }
        public static void MU(int[] mass1, int[] mass2)
        {
            int[] mass = new int[mass1.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = mass1[i] * mass2[i];
            }
            string massiv = "";
            for (int i = 0; i < mass1.Length; i++)
            {
                massiv += $"{Convert.ToString(mass[i])} ";
            }
            //MASS tr1;
            //tr1 = GeneralOffice.MU_massiv;
            //tr1(massiv);
        }
    }
}
