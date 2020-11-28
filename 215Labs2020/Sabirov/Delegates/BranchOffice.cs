using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov.Delegates
{
    class BranchOffice
    {
        private delegate void SecondGP(int[] mass, int[] mass1);
        private delegate void FirstGP(int[] mass);



        public static void gal2(int[] mass, int[] mass1)
        {
            SecondGP sec;
            sec = GeneralOffice.Mul;
            sec += GeneralOffice.Sub;
            sec += GeneralOffice.Summ;
            sec(mass, mass1);
        }
        public static void gal(int[] mass)
        {
            FirstGP fir;
            fir = GeneralOffice.Max;
            fir += GeneralOffice.sort;
            fir(mass);

        }
    }
}
