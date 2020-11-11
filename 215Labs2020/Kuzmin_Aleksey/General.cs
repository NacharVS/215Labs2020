using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class General
    {
        public delegate int BranchOffice1(int[] mass);
        public static void general()
        {
            BranchOffice1 array;
            array = Deligates.BranchOffice.Ex1;
            array += Deligates.BranchOffice.Ex1;
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array(a));
        }
    }
}
