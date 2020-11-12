using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Shakirovа.delegates


{
    class BranchOffice
    {
        private delegate void Handler(int[] array);
        private delegate void Handler2(int[] array, int[] array1);
        public static void Invoke(int[] mass)
        {
            Handler handler = GeneralOffice.max;
            handler += GeneralOffice.summ;
            handler += GeneralOffice.Sortirovka;
            handler(mass);
        }

        public static void Invoke2(int[] mass, int[] mass1)
        {
            Handler2 handler2 = GeneralOffice.summa_massivov;
            handler2 += GeneralOffice.vichetanie_massivov;
            handler2 += GeneralOffice.proizv_massivov;
            handler2(mass, mass1);

        }

    }
}
