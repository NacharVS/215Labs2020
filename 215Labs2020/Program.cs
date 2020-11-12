using System;
using _215Labs2020.Imamov;
using _215Labs2020.Imamov.Delegates;

namespace _215Labs2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5] { 1, 15, 8, 6, 20 };
            int[] array2 = new int[5] { 2, 12, 7, 3, 14 };
            BranchOffice.Operations1(array1);
            BranchOffice.Operations2(array1, array2);
        }
    }
}
