using System;

namespace _215Labs2020.Galyautdinov.Delegates
{
    class BranchOffice
    {
        private delegate void Handler1(int[] array);
        private delegate void Handler2(int[] array, int[] array1);

        public static void metod1(int[] mass)
        {
            Handler1 handler = GeneralOffice.Sum_el_array;
            handler += GeneralOffice.Max_el_array;
            handler += GeneralOffice.Sort_el_array;
            handler(mass);
        }
        public static void metod2(int[] mass, int[] mass1)
        {
            Handler2 handler1 = GeneralOffice.SumArray;
            handler1 += GeneralOffice.Sub_el_array;
            handler1 += GeneralOffice.Com_el_array;
            handler1(mass, mass1);
        }
        public static void Run()
        {
            int[] mass = new int[3] { 1, 2, 3, };
            int[] mass1 = new int[3] { 1, 2, 5, };
            BranchOffice.metod1(mass);
            BranchOffice.metod2(mass, mass1);
        }
    }
}
