using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class OperatorsOverload
    {
        private int _number1;
        private int _number2;

        public OperatorsOverload(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public static double operator +(OperatorsOverload n1, OperatorsOverload n2)
        {
            return (n1._number1 + n2._number2);
        }
        public static double operator -(OperatorsOverload n1, OperatorsOverload n2)
        {
            return (n1._number1 - n2._number2);
        }
        public static double operator /(OperatorsOverload n1, OperatorsOverload n2)
        {
            return (n1._number1 / n2._number2);
        }
        public static double operator *(OperatorsOverload n1, OperatorsOverload n2)
        {
            return n1._number1 * n2._number2;
        }
        public static bool operator ==(OperatorsOverload n1, OperatorsOverload n2)
        {
            return n1._number1 == n2._number2;
        }
        public static bool operator !=(OperatorsOverload n1, OperatorsOverload n2)
        {
            return n1._number1 != n2._number2;
        }

        public static void Program()
        { 
            OperatorsOverload number1 = new OperatorsOverload(4, 5);
            OperatorsOverload number2 = new OperatorsOverload(2, 5);
            double a = number1 + number2;
            Console.WriteLine(a);

        }
    }
}
