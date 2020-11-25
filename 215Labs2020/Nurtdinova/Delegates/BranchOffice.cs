//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace _215Labs2020.Nurtdinova.Delegates
//{
//    class BranchOffice
//    {
//        class DelegateClass
//        {
//            private delegate void Handler1(int[] array);
//            private delegate void Handler2(int[] array, int[] array1);

//            public static void metod2(int[] mass, int[] mass1)
//            {
//                Handler2 handler1 = GeneralOffice.SummMass;
//                handler1 += GeneralOffice.SubMass;
//                handler1 += GeneralOffice.MultMass;
//                handler1(mass, mass1);
//            }
//            public static void metod1(int[] mass)
//            {
//                Handler1 handler = GeneralOffice.MaxElement;
//                handler += GeneralOffice.SortirovkaMass;
//                handler += GeneralOffice.SummElMass;
//                handler(mass);
//            }
//        }
//    }
//}