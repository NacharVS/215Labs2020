using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class OperatorsOverload
    {
        public double _number1;
        public static void line(bool take)
        {            
            if (take)
            {
                Console.WriteLine();
                Console.WriteLine("**********************************************");
                Console.WriteLine("Ошибка. Не верно введены данные в строку.");
                Console.WriteLine("**********************************************");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine();
            }
        }
        public OperatorsOverload(double number1)
        {
            _number1 = number1;
        }
        public static double operator +(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 + s2._number1;
        }
        public static double operator -(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 - s2._number1;
        }
        public static double operator *(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 * s2._number1;
        }
        public static double operator /(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 / s2._number1;
        }
        public static bool operator ==(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 == s2._number1;
        }
        public static bool operator !=(OperatorsOverload s1, OperatorsOverload s2)
        {
            return s1._number1 == s2._number1;
        }

        public static void Program()
        {
            while (true)
            {
                while (true)
                {
                    OperatorsOverload nb1 = new OperatorsOverload(0);
                    OperatorsOverload nb2 = new OperatorsOverload(0);
                    try
                    {
                        Console.Write("Введите два числа.(Пример: 123 456) ");
                        string numbers = Console.ReadLine();
                        string[] mass = numbers.Split();
                        nb1 = new OperatorsOverload(double.Parse(mass[0]));
                        nb2 = new OperatorsOverload(double.Parse(mass[1]));
                    }
                    catch { line(true); break; }
                    Console.WriteLine("Выберите доступное действие над числами:");
                    Console.WriteLine("Сложение.  Введите знак { + }.");
                    Console.WriteLine("Вычетание. Введите знак { - }.");
                    Console.WriteLine("Деление.   Введите знак { / }.");
                    Console.WriteLine("Умножение. Введите знак { * }.");
                    Console.WriteLine("Сравнение. Введите знак { = }.");
                    Console.Write("Введите знак действя: ");
                    string action = Console.ReadLine();
                    switch (action)
                    {
                        case "+": Console.WriteLine($"Ответ: {nb1 + nb2}"); line(false); break;
                        case "-": Console.WriteLine($"Ответ: {nb1 - nb2}"); line(false); break;
                        case "/": Console.WriteLine($"Ответ: {nb1 / nb2}"); line(false); break;
                        case "*": Console.WriteLine($"Ответ: {nb1 * nb2}"); line(false); break;
                        case "=": Console.WriteLine($"Ответ: {nb1 == nb2}"); line(false); break;
                        default: line(true); break; ;
                    }
                }
            }
        }
    }
}