﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei
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
    public static int operator + (OperatorsOverloads n1, OperatorsOverloads n2)
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
        public static double operator /(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 / n2._num2;
        }
        public static double operator %(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 % n2._num2;
        }
        public static bool operator >(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 > n2._num2;
        }
        public static bool operator <(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 < n2._num2;
        }
        public static bool operator ==(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 == n2._num2;
        }
        public static bool operator !=(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._num1 != n2._num2;
        }
        public static void method()
        {
            OperatorsOverloads o1 = new OperatorsOverloads(10, 5);
            int sum = o1._num1 + o1._num2;
            Console.WriteLine(sum);
            int raznost = o1._num1 - o1._num2;
            Console.WriteLine(raznost);
            int multiplication = o1._num1 * o1._num2;
            Console.WriteLine(multiplication);
            double delenie = o1._num1 / o1._num2;
            Console.WriteLine(delenie);
            double ost = o1._num1 % o1._num2;
            Console.WriteLine(ost);
            bool bolmen = o1._num1 > o1._num2;
            Console.WriteLine(bolmen);
            bool bn = o1._num1 < o1._num2;
            Console.WriteLine(bn);
            bool ravno = o1._num1 == o1._num2;
            Console.WriteLine(ravno);
            bool neravno = o1._num1 != o1._num2;
            Console.WriteLine(ravno);
        }
    }
}
