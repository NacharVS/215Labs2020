using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class General
    {
        public delegate void BranchOffice(int[] array);
        public static void Ex1()
        {
            BranchOffice mass;
            mass = Delegates.BranchOffice.Task1;
            mass += Delegates.BranchOffice.Task1;
            mass[];
        }

    }
}
