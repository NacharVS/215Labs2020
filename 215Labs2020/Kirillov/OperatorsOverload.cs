using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov
{
    class OperatorsOverload
    {
        private int number1;
        private int number2;
        public OperatorsOverload(int _number1, int _number2)
        {
            number1 = _number1;
            number2 = _number2;
        }
        public static int operator +(OperatorsOverload n1, OperatorsOverload n2)
        {
            return n1.number1 + n2.number2;
        }
        public static void sum()
        {
            OperatorsOverload n0 = new OperatorsOverload(5, 10);
            int result = n0.number1 + n0.number2;
            Console.WriteLine(result);
        }
        public static int operator -(OperatorsOverload n1, OperatorsOverload n2)
        {
            return n1.number1 - n2.number2;
        }
        public static void dif()
        {
            OperatorsOverload n0 = new OperatorsOverload(5, 10);
            int result = n0.number1 - n0.number2;
            Console.WriteLine(result);
        }
        public static int operator *(OperatorsOverload n1, OperatorsOverload n2)
        {
            return n1.number1 * n2.number2;
        }
        public static void multiply()
        {
            OperatorsOverload n0 = new OperatorsOverload(5, 10);
            int result = n0.number1 * n0.number2;
            Console.WriteLine(result);
        }
        public static double operator /(OperatorsOverload n1, OperatorsOverload n2)
        {
            return n1.number1 / n2.number2;
        }
        public static void div()
        {
            OperatorsOverload n0 = new OperatorsOverload(5, 10);
            double result = n0.number1 / n0.number2;
            Console.WriteLine(result);
        }
    }
}

