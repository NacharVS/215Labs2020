using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ohotnicov.Delegates
{
    class DelegateClass
    {
        private delegate void mass1(int[]mass);

        public void Helper(int[] array)
        {
            mass1 mass = MethodClass.SummElMass;
        }



    }
}
