using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class OperationOverloads
    {
        private double _number;
        public OperationOverloads(double number)
        {
            _number = number;
        }
        public static double operator + (OperationOverloads number1, OperationOverloads number2)
        {
            return (number1._number + number2._number);
        }
        public static double operator - (OperationOverloads number1, OperationOverloads number2)
        {
            return (number1._number - number2._number);
        }
        public static double operator * (OperationOverloads number1, OperationOverloads number2)
        {
            return (number1._number * number2._number);
        }
        public static double operator / (OperationOverloads number1, OperationOverloads number2)
        {
            return (number1._number / number2._number);
        }
        public static void a()
        {
            Console.Write("nymber1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("nymber2: ");
            double num2 = double.Parse(Console.ReadLine());
            OperationOverloads operator1 = new OperationOverloads(num1);
            OperationOverloads operator2 = new OperationOverloads(num2);

            double average = 0;
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.Write("Ждемс: ");
            string prov = Console.ReadLine();
            switch (prov)
            {
                case "+": average = (operator1 + operator2); break;
                case "-": average = (operator1 - operator2); break;
                case "*": average = (operator1 * operator2); break;
                case "/": average = (operator1 / operator2); break;
            }
            Console.WriteLine(average);
        }
    }
}
