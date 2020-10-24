using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov
{
    class OperatorsOverloads
    {
       
        private int _num1;
        private int _num2;

        public OperatorsOverloads(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }
        public static int operator +(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 + n2._num2;
        }
        public static int operator -(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 - n2._num2;
        }
        public static int operator *(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 * n2._num2;
        }
        public static int operator /(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 / n2._num2;
        }
        public static bool operator >(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 > n2._num2;
        }
        public static bool operator <(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 < n2._num2;
        }
        public static void vvod()
        {
            OperatorsOverloads o1 = new OperatorsOverloads(2, 3);
            int sum = o1._num1 + o1._num2;
            Console.WriteLine(sum);
            int raznost = o1._num1 - o1._num2;
            Console.WriteLine(raznost);
            int umnojenie = o1._num1 * o1._num2;
            Console.WriteLine(umnojenie);
            int delenie = o1._num1 / o1._num2;
            Console.WriteLine(delenie);
            bool bolshe = o1._num1 > o1._num2;
            Console.WriteLine(bolshe);

        }
    }


}

