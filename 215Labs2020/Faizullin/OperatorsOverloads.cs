using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin
{
    class OperatorsOverloads
    {
        private int _name;
        private int _mark;

        public OperatorsOverloads(int name, int mark)
        {
            _name = name;
            _mark = mark;

        }
        public static double operator +(OperatorsOverloads s1, OperatorsOverloads s2)
        {
            return s1._name + s2._mark;
        }
        public static double operator -(OperatorsOverloads s1, OperatorsOverloads s2)
        {
            return s1._name + s2._mark;
        }
        public static double operator *(OperatorsOverloads s1, OperatorsOverloads s2)
        {
            return s1._name + s2._mark;
        }
        public static double operator /(OperatorsOverloads s1, OperatorsOverloads s2)
        {
            return s1._name / s2._mark;
        }
        public static bool operator >(OperatorsOverloads s1, OperatorsOverloads s2)
        {
            return s1._name > s2._mark;
        }
        public static bool operator <(OperatorsOverloads s1, OperatorsOverloads s2)
        {
            return s1._name < s2._mark;
        }
        public static void KONEC()
        {
            OperatorsOverloads m1 = new OperatorsOverloads(3, 6);
            int sum = m1._name + m1._mark;
            Console.WriteLine("sum");
            int sub = m1._name - m1._mark;
            Console.WriteLine("sub");
            int mul = m1._name * m1._mark;
            Console.WriteLine("mul");
            int del = m1._name / m1._mark;
            Console.WriteLine("del");
            bool more = m1._name > m1._mark;
            Console.WriteLine("more");

        }
    }
}
