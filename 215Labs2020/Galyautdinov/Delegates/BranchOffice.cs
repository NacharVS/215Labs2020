using System;
using _215Labs2020.Galyautdinov.Delegates;

namespace _215Labs2020.Galyautdinov.Delegates
{
    class BranchOffice
    {
        private delegate void Action(int mes);
        

        public static void max()
        {
            Action max;
            max = GeneralOffice.Max_el_array;
            max(25);
        }
    }
}
