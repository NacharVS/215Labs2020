using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin.Delegates
{
    class BranchOffice
    {
        private delegate void Handler1(int[] arr);
        private delegate void Handler2(int[] arr, int[] arr2);
        public static void Operations1(int[] array1)
        {
            Handler1 handler = GeneralOffice.Max_Elem;
            handler += GeneralOffice.Sum_Of_El;
            handler += GeneralOffice.Filt;
            handler(array1);
        }
        public static void Operations2(int[] array1, int[] array2)
        {
            Handler2 handler = GeneralOffice.Sum_Of_Arr;
            handler2 += GeneralOffice.Sum_Of_El;
            handler2 += GeneralOffice.Filt;
            handler2(array1, array2);
        }
    }
}
