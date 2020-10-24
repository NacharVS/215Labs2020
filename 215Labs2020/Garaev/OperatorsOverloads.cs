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
            Operators operator1 = new Operators(5);
            Operators operator2 = new Operators(9);
            double average = (operator1 + operator2);
            Console.WriteLine(average);
        }
    }
}
