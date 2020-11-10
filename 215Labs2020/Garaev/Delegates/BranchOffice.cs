using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using _215Labs2020.Garaev;

namespace _215Labs2020.Garaev.Delegates
{
    class BranchOffice
    {
        private delegate void Trainee(int mes);
        private delegate void MASS(string mes);
        public static void max()
        {
            int max = 0;
            for (int i = 0; i < General.mass1.Length; i++)
            {
                if (General.mass1[i]>max)
                {
                    max = General.mass1[i];
                }
            }
            Trainee tr1;
            tr1 = GeneralOffice.Max_el_mass;
            tr1(max);
        }
        public static void Summ_el()
        {
            int sum = 0;
            for (int i = 0; i < General.mass1.Length; i++)
            {
                sum += General.mass1[i];
            }
            Trainee tr1;
            tr1 = GeneralOffice.Summ_el_mass;
            tr1(sum);
        }
        public static void Sortirovka()
        {
            int bufer = 0;
            for (int i = 0; i < General.mass1.Length; i++)
            {
                for (int j = 1; j < General.mass1.Length-i; j++)
                {
                    if (General.mass1[j-1]> General.mass1[j])
                    {
                        bufer = General.mass1[j];
                        General.mass1[j] = General.mass1[j-1];
                        General.mass1[j-1] = bufer;
                    }
                }
            }
            string mass = "";
            for (int i = 0; i < General.mass1.Length; i++)
            {
                mass += $"{Convert.ToString(General.mass1[i])} ";
            }
            MASS tr1;
            tr1 = GeneralOffice.Sortirovka;
            tr1(mass);
        }
        public static void Summ_mass()
        {
            int[] mass = new int[General.mass1.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = General.mass1[i] + General.mass2[i];
            }
            string massiv = "";
            for (int i = 0; i < General.mass1.Length; i++)
            {
                massiv += $"{Convert.ToString(mass[i])} ";
            }
            MASS tr1;
            tr1 = GeneralOffice.Summ_massiv;
            tr1(massiv);
        }
        public static void raznost()
        {
            int[] mass = new int[General.mass1.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = General.mass1[i] - General.mass2[i];
            }
            string massiv = "";
            for (int i = 0; i < General.mass1.Length; i++)
            {
                massiv += $"{Convert.ToString(mass[i])} ";
            }
            MASS tr1;
            tr1 = GeneralOffice.Raznost_massiv;
            tr1(massiv);
        }
        public static void MU()
        {
            int[] mass = new int[General.mass1.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = General.mass1[i] * General.mass2[i];
            }
            string massiv = "";
            for (int i = 0; i < General.mass1.Length; i++)
            {
                massiv += $"{Convert.ToString(mass[i])} ";
            }
            MASS tr1;
            tr1 = GeneralOffice.MU_massiv;
            tr1(massiv);
        }
    }
}
