﻿//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace _215Labs2020.Sharipov
//{
//    class OperatorsOverloads
//    {
//        private int _num1;
//        private int _num2;
//        public OperatorsOverloads(int num1, int num2)
//        {
//            _num1 = num1;
//            _num2 = num2;
//        }
//        public static int operator +(OperatorsOverloads n1, OperatorsOverloads n2)
//        {
//            return n1._num1 + n2._num2;
//        }
//        public static int operator -(OperatorsOverloads n1, OperatorsOverloads n2)
//        {
//            return n1._num1 - n2._num2;
//        }
//        public static int operator *(OperatorsOverloads n1, OperatorsOverloads n2)
//        {
//            return n1._num1 * n2._num2;
//        }
//        public static double operator /(OperatorsOverloads n1, OperatorsOverloads n2)
//        {
//            return n1._num1 / n2._num2;
//        }
//        public static double operator %(OperatorsOverloads n1, OperatorsOverloads n2)
//        {
//            return n1._num1 % n2._num2;
//        }
//        public static bool operator >(OperatorsOverloads n1, OperatorsOverloads n2)
//        {
//            return n1._num1 > n2._num2;
//        }
//        public static bool operator <(OperatorsOverloads n1, OperatorsOverloads n2)
//        {
//            return n1._num1 < n2._num2;
//        }
//        public static bool operator ==(OperatorsOverloads n1, OperatorsOverloads n2)
//        {
//            return n1._num1 == n2._num2;
//        }
//        public static bool operator !=(OperatorsOverloads n1, OperatorsOverloads n2)
//        {
//            return n1._num1 != n2._num2;
//        }
//        public static void method()
//        {
//            OperatorsOverloads o1 = new OperatorsOverloads(10, 5);
//            int sum = o1._num1 + o1._num2;
//            Console.WriteLine($"Сложение: {sum}");
//            int raznost = o1._num1 - o1._num2;
//            Console.WriteLine($"Вычитание: {raznost}");
//            int multiplication = o1._num1 * o1._num2;
//            Console.WriteLine($"Умножение: {multiplication}");
//            double delenie = o1._num1 / o1._num2;
//            Console.WriteLine($"Целочисленное деление: {delenie}");
//            double ost = o1._num1 % o1._num2;
//            Console.WriteLine($"Остаток от деления: {ost}");
//            bool bolmen = o1._num1 > o1._num2;
//            Console.WriteLine($"Больше: {bolmen}");
//            bool bn = o1._num1 < o1._num2;
//            Console.WriteLine($"Меньше: {ost}");
//            bool ravno = o1._num1 == o1._num2;
//            Console.WriteLine($"Равенство: {ravno}");
//            bool neravno = o1._num1 != o1._num2;
//            Console.WriteLine($"Неравенство:{neravno}");
//        }
//    }
//}

