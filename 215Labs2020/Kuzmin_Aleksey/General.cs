using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class General
    {
        public delegate int Branch_Office(int[] mass);
        public delegate int General_Office(int[] mass1, int[] mass2);
        public static void Program()
        {
            int[] a = new int[5] { 4, 2, 7, 1, 8 };
            int[] b = new int[5] { 2, 4, 6, 7, 9 };
            Branch_Office array1;
            array1 = Deligates.BranchOffice.Ex1;
            Console.WriteLine(array1(a));
            array1 += Deligates.BranchOffice.Ex2;            
            Console.WriteLine(array1(a));
            array1 += Deligates.BranchOffice.Ex3;
            array1(a);
            General_Office array2;
            array2 = Deligates.GeneralOffice.Ex4;
            array2(a, b);
            array2 += Deligates.GeneralOffice.Ex5;
            array2(a, b);
        }
    }
}
