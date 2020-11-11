using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _215Labs2020.Safiullin.Delegates
{
    class BranchOffice
    {
        public delegate void Ht1(int[] array);
        public static void Invoke(int[] array)
        {
            Ht1 handler = GeneralOffice.Max;
            handler += GeneralOffice.Sum;
            handler += GeneralOffice.Sortirovka;
            handler += GeneralOffice.SummMass;
            handler(array);
        }
    }
}
