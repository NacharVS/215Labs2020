using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.Deligates
{
    public delegate void Branch1(int[] mass);
    public delegate void Branch2(int[] mass1, int[] mass2);
    class BranchOffice
    {
        public static void Work(int[] mass1, int[] mass2)
        {
            Branch1 branch1;
            branch1 = Deligates.GeneralOffice.Ex1;
            branch1 += Deligates.GeneralOffice.Ex2;
            branch1 += Deligates.GeneralOffice.Ex3;
            branch1(mass1);
            Branch2 branch2;
            branch2 = Deligates.GeneralOffice.Ex4;
            branch2 += Deligates.GeneralOffice.Ex5;
            branch2 += Deligates.GeneralOffice.Ex6;
            branch2(mass1, mass2);
        }

    }
}
