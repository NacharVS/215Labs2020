using System;
using System.Xml.Serialization;
using System.Text;

namespace _215Labs2020.Kirillov.Delegates
{
    class BranchOffice
    {
        private delegate void Hander1(int[] arr);
        private delegate void Hander2(int[] arr, int[] arr2);


        public static void Operations1(int[] array1)
        {
            Hander1 hander = GeneralOffice.Max_Elem;
            hander += GeneralOffice.Sum_Of_El;
            hander += GeneralOffice.Filt;
            hander(array1);
        }
        public static void Operations2(int[] array1, int[] array2)
        {
            Hander2 hander2 = GeneralOffice.Sum_Of_Arr;
            hander2 += GeneralOffice.Substract;
            hander2 += GeneralOffice.Multiply;
            hander2(array1, array2);
        }
    }
}
