using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace _215Labs2020.Zifarov.Delegates
{
    class BranchOffice
    {
        private delegate void One();
        public static void ab()
        {
            One tr;
            tr = GeneralOffice.max;
            tr = tr + GeneralOffice.sum;
            tr = tr + GeneralOffice.sorting;
            tr();
        }
        private delegate void One1();
        public static void abc()
        {
            One1 t1r;
            t1r = GeneralOffice.summas;
            t1r = t1r + GeneralOffice.diffmas;
            t1r = t1r + GeneralOffice.mulmas;
            t1r();
        }
    }

}
