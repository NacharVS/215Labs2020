using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov.Delegates
{
    class BranchOffice
    {
        private delegate void FirstGP();

       
        public static void gal()
        {

            GeneralOffice.arr1();
            GeneralOffice.arr2();
            FirstGP fir;

            fir = GeneralOffice.Summ;
            fir += GeneralOffice.Sub;
            fir += GeneralOffice.Mul;
            fir += GeneralOffice.Max;
            fir += GeneralOffice.sort;
            fir();
        }
        

    }
}
