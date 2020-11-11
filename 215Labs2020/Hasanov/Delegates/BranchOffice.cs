using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Delegates
{
    class BranchOffice
    {
        private delegate void DLG();
        private delegate void DLG1();
        public static void method()
        {
            DLG HI;
            HI = GeneralOffice.max;
            HI += GeneralOffice.sum;
            HI += GeneralOffice.sortirovka;
            HI();
;            DLG1 HI1;
            HI1 = GeneralOffice.summmass;
            HI1 += GeneralOffice.umnmass;
            HI1 += GeneralOffice.razmass;
            HI1();
        }
    }
}
