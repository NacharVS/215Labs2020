using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasov.Delegates
{
    class DelegateClass
    {
        private delegate void Handler1(int[] array);
        private delegate void Handler2(int[] array, int[] array1);

        public static void metod2(int[] mass, int[] mass1)
        {
            Handler2 handler1 = MethodClass.SummMass;
            handler1 += MethodClass.SubMass;
            handler1 += MethodClass.MultMass;
            handler1(mass, mass1);
        }
        public static void metod1(int[] mass)
        {
            Handler1 handler = MethodClass.MaxElement;
            handler += MethodClass.SortirovkaMass;
            handler += MethodClass.SummElMass;
            handler(mass);
        }
    }
}
