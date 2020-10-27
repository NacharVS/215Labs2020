using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov
{
    class OperatorsOverloads
    {
        private int _num1;
        private int _num2;
        public OperatorsOverloads()
        {
            Console.WriteLine("Число1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Число2");
            int num2 = int.Parse(Console.ReadLine());
            _num1 = num1;
            _num2 = num2;
        }
        public static int operator +(OperatorsOverloads a1, OperatorsOverloads a2)
        {
            return a1._num1 + a2._num2;
        }
        public static int operator -(OperatorsOverloads a1, OperatorsOverloads a2)
        {
            return a1._num1 - a2._num2;
        }
        public static int operator *(OperatorsOverloads a1, OperatorsOverloads a2)
        {
            return a1._num1 * a2._num2;
        }
        public static int operator /(OperatorsOverloads a1, OperatorsOverloads a2)
        {
            return a1._num1 / a2._num2;
        }
        public static int operator %(OperatorsOverloads a1, OperatorsOverloads a2)
        {
            return a1._num1 % a2._num2;
        }
        public static bool operator <(OperatorsOverloads a1, OperatorsOverloads a2)
        {
            return a1._num1 < a2._num2;
        }
        public static bool operator >(OperatorsOverloads a1, OperatorsOverloads a2)
        {
            return a1._num1 > a2._num2;
        }
        public static bool operator ==(OperatorsOverloads a1, OperatorsOverloads a2)
        {
            return a1._num1 == a2._num2;
        }
        public static bool operator !=(OperatorsOverloads a1, OperatorsOverloads a2)
        {
            return a1._num1 != a2._num2;
        }
        public static void One()
        {
            OperatorsOverloads b1 = new OperatorsOverloads();
            Console.WriteLine($"(Сумма { b1._num1 + b1._num2}) (Разность {b1._num1 - b1._num2}) (Произведение {b1._num1 * b1._num2}) (Частное {b1._num1 / b1._num2}) (Остаток частного {b1._num1 % b1._num2}) (Больше {b1._num1 < b1._num2}) (Меньше {b1._num1 > b1._num2}) (Равенство {b1._num1 == b1._num2}) (Неравенство {b1._num1 != b1._num2})");
        }
    }
}




