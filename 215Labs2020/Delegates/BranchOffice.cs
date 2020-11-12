using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Delegates
{
    class BranchOffice
    {
        private delegate void onemass (int[] mass1);
        private delegate void twomass (int[] mass1, int[] mass2);
        public static void xx(int[] mass1)
        {
            onemass zz;
            zz = GeneralOffice.max;
            zz += GeneralOffice.sum;
            zz += GeneralOffice.sor;
            zz(mass1);
        }
        public static void zzc(int[] mass1, int[] mass2)
        {
            twomass z1z;
            z1z = GeneralOffice.summas;
            z1z +=  GeneralOffice.mul;
            z1z += GeneralOffice.sub;
            z1z(mass1, mass2);


        }
    }
}
