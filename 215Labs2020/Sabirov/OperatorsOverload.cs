using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace _215Labs2020.Sabirov
{
    class OperatorsOverloads
    {
        private double _number;
        public OperatorsOverloads(int a)
        {
            _number = a;
        }

        public static bool operator >(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._number > n2._number;

        }
        public static bool operator <(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._number < n2._number;

        }
        public static double operator +(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._number + n2._number;
        }
        public static double operator -(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._number - n2._number;
        }
        public static double operator /(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._number / n2._number;
        }
        public static double operator *(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._number * n2._number;
        }
        public static double operator %(OperatorsOverloads n1, OperatorsOverloads n2)
        {
            return n1._number % n2._number;
        }
        
        public static OperatorsOverloads operator ++(OperatorsOverloads n1)
        {
            n1._number += 4;
            return n1;
        }
        public static OperatorsOverloads operator --(OperatorsOverloads n1)
        {
           n1._number -= 4;
            return n1;
        }
        public static void rnd()
        {
            Random rnd = new Random();

            OperatorsOverloads n1 = new OperatorsOverloads(rnd.Next(10, 100));
            OperatorsOverloads n2 = new OperatorsOverloads(rnd.Next(10, 100));
            Console.WriteLine($"a:{n1._number}\nb:{n2._number}");
            double add = n1 + n2;
            double substraction = n1 - n2;
            double multiply = n1 * n2;
            double divide = n1 / n2;
            double percent = n1 % n2;
            bool result = n1 > n2;
            double res = n1._number ++;

            Console.WriteLine($"a > b: {result}");
            Console.WriteLine($"Вычитание: { substraction}");
            Console.WriteLine($"Умножение: {multiply}");
            Console.WriteLine($"Деление: {divide}");
            Console.WriteLine($"Остаток от деления двух данных чисел: {percent}");
        }
    }
}
