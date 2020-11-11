using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin
{
        class OperatorsOverloads
        {
            private int number1;
            private int number2;
            public OperatorsOverloads(int _number1, int _number2)
            {
                number1 = _number1;
                number2 = _number2;
            }
            public static int operator +(OperatorsOverloads n1, OperatorsOverloads n2)
            {
                return n1.number1 + n2.number2;
            }
            public static void sum()
            {
                OperatorsOverloads n0 = new OperatorsOverloads(5, 10);
                int result = n0.number1 = n0.number2;
                Console.WriteLine("result");
            }
            public static int operator -(OperatorsOverloads n1, OperatorsOverloads n2)
            {
                return n1.number1 - n2.number2;
            }
            public static void dif()
            {
                OperatorsOverloads n0 = new OperatorsOverloads(5, 10);
                int result = n0.number1 = n0.number2;
                Console.WriteLine("result");
            }
            public static int operator *(OperatorsOverloads n1, OperatorsOverloads n2)
            {
                return n1.number1 - n2.number2;
            }
            public static void multiply()
            {
                OperatorsOverloads n0 = new OperatorsOverloads(5, 10);
                int result = n0.number1 = n0.number2;
                Console.WriteLine("result");
            }
            public static double operator /(OperatorsOverloads n1, OperatorsOverloads n2)
            {
                return n1.number1 / n2.number2;
            }
            public static void div()
            {
                OperatorsOverloads n0 = new OperatorsOverloads(5, 10);
                int result = n0.number1 = n0.number2;
                Console.WriteLine("result");
            }
        }
}
