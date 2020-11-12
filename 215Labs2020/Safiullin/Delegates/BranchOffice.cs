using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _215Labs2020.Safiullin.Delegates
{
    class BranchOffice
    {
        public delegate void Ht2(int[] array1, int[] array2);
        public delegate void Ht1(int[] array1);

        public static void Invoke(int[] array1, int[] array2)
        {
            Ht1 handler = GeneralOffice.Max;
            handler += GeneralOffice.Sum;
            handler += GeneralOffice.Sortirovka;
            Ht2 handler1 = GeneralOffice.SummMass;
            handler1 += GeneralOffice.RazNost;
            handler1 += GeneralOffice.Proiz;
            handler(array1);
            handler1(array1, array2);



        }
    }
}
