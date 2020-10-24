using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev4
{
    class Operators
    {
        private int _number;
        public Operators(int number)
        {
            _number = number;
        }
        public static double operator + (Operators number1, Operators number2) 
        {
            return (number1._number + number2._number);
        }
        public static double operator -(Operators number1, Operators number2)
        {
            return (number1._number - number2._number);
        }
        public static double operator *(Operators number1, Operators number2)
        {
            return (number1._number * number2._number);
        }
        public static double operator /(Operators number1, Operators number2)
        {
            return (number1._number / number2._number);
        }
        public static void a()
        {
            Console.Write("Введите первое число: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b2 = int.Parse(Console.ReadLine());
            Operators operator1 = new Operators(b1);
            Operators operator2 = new Operators(b2);
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            double average = 0;
            string vibor = Console.ReadLine();
            switch(vibor)
            {
                case "+": average = (operator1 + operator2); break;
                case"-": average = (operator1 - operator2); break;
                case "*": average = (operator1 * operator2); break;
                case "/": average = (operator1 / operator2); break;
            }
            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}
