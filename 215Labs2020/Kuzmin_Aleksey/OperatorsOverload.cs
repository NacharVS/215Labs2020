using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class OperatorsOverload
    {
        public int _number1;       
        public OperatorsOverload(int number1)
        {
            _number1 = number1;
        }
        public static int operator +(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 + s2._number1;
        }
        public static int operator -(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 + s2._number1;
        }
        public static int operator *(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 + s2._number1;
        }
        public static int operator /(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 + s2._number1;
        }
        public static bool operator ==(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 == s2._number1;
        }
        public static bool operator !=(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 == s2._number1;
        }

        public static void Program()
        {
            OperatorsOverload nb1 = new OperatorsOverload(5);
            OperatorsOverload nb2 = new OperatorsOverload(6);
            bool a = nb1 == nb2;
            Console.WriteLine(a);
        }
    }
}
