using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Delegates
{
    class BranchOffice
    {
        private delegate void Onemass(int[] array1);
        private delegate void Twomass(int[] array1, int[] array2);
        public static void ab(int[] array1)
        {
            Onemass tr;
            tr = GeneralOffice.max;
            tr += GeneralOffice.sum;
            tr += GeneralOffice.sorting;
            tr(array1);
        }
        public static void abc(int[] array1, int[] array2)
        {
            Twomass t1r;
            t1r = GeneralOffice.summas;
            t1r = t1r + GeneralOffice.diffmas;
            t1r = t1r + GeneralOffice.mulmas;
            t1r(array1, array2);
        }
    }

}
