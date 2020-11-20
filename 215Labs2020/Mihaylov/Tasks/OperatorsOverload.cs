using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov
{
    class OperatorsOverload
    {
        private int _number1;
        private int _number2;
        public OperatorsOverload()
        {
            Console.WriteLine("Введите первое число");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int number2 = int.Parse(Console.ReadLine());
            _number1 = number1;
            _number2 = number2;
        }
        public static int operator +(OperatorsOverload a1, OperatorsOverload a2)
        {
            return a1._number1 + a2._number2;
        }
        public static int operator -(OperatorsOverload a1, OperatorsOverload a2)
        {
            return a1._number1 - a2._number2;
        }
        public static int operator *(OperatorsOverload a1, OperatorsOverload a2)
        {
            return a1._number1 * a2._number2;
        }
        public static int operator /(OperatorsOverload a1, OperatorsOverload a2)
        {
            return a1._number1 / a2._number2;
        }
        public static int operator %(OperatorsOverload a1, OperatorsOverload a2)
        {
            return a1._number1 % a2._number2;
        }
        public static bool operator ==(OperatorsOverload a1, OperatorsOverload a2)
        {
            return a1._number1 == a2._number2;
        }
        public static bool operator !=(OperatorsOverload a1, OperatorsOverload a2)
        {
            return a1._number1 != a2._number2;
        }
        public static void Program()
        {
            OperatorsOverload s1 = new OperatorsOverload();
            Console.WriteLine($" Сумма { s1._number1 + s1._number2}");
            Console.WriteLine($" Разность {s1._number1 - s1._number2}");
            Console.WriteLine($" Произведение {s1._number1 * s1._number2}");
            Console.WriteLine($" Частное {s1._number1 / s1._number2}");
            Console.WriteLine($" Равенство {s1._number1 == s1._number2}");
            Console.WriteLine($" Неравенство { s1._number1 != s1._number2}");
        }
    }
}
